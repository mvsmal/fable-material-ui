#load ".fake/build.fsx/intellisense.fsx"
open Fake.IO
open System.IO
open Fake.Core
open Fake.DotNet
open Fake.IO
open Fake.IO.Globbing.Operators
open Fake.Core.TargetOperators
open Fake.Api
open Fake.JavaScript
open Fake.Tools.Git

let outputDir = "nuget"
let summary = "Fable bindings for MaterialUI"
let project = "Fable.MaterialUI"
let release =  ReleaseNotes.load "RELEASE_NOTES.md"
let gitOwner = "mvsmal"
let gitRepo = "fable-material-ui"
let configuration = "Release"

let toLines (strs: string list) = String.concat "\n" strs

let cleanDirs root output _ =
    !! (root + "src/**/bin")
    ++ (root + "src/**/obj")
    ++ output
    |> Shell.cleanDirs

let build root _ =
    !! (root + "src/**/*.*proj")
    |> Seq.iter (DotNet.build id)

Target.create "Clean" (cleanDirs "" outputDir)

Target.create "AssemblyInfo" (fun _ ->
    let getAssemblyInfoAttributes projectName =
        [ AssemblyInfo.Title (projectName)
          AssemblyInfo.Product project
          AssemblyInfo.Description summary
          AssemblyInfo.Version release.AssemblyVersion
          AssemblyInfo.FileVersion release.AssemblyVersion
          AssemblyInfo.Configuration configuration ]

    let getProjectDetails projectPath =
        let projectName = System.IO.Path.GetFileNameWithoutExtension(projectPath)
        ( System.IO.Path.GetDirectoryName(projectPath),
          (getAssemblyInfoAttributes projectName)
        )
    !! "src/**/*.??proj"
    |> Seq.map getProjectDetails
    |> Seq.iter (fun (folderName, attributes) ->
        AssemblyInfoFile.createFSharp (Path.combine folderName "AssemblyInfo.fs") attributes
        )
)

Target.create "Build" (build "")

Target.create "NuGet" (fun _ ->
    Paket.pack(fun p ->
        { p with
            OutputPath = outputDir
            Version = release.NugetVersion
            ReleaseNotes = toLines release.Notes})
)

Target.create "PublishNuGet" (fun _ ->
    Paket.push(fun p ->
        { p with
            PublishUrl = "https://www.nuget.org"
            WorkingDir = outputDir })
)

Target.create "GitHubRelease" (fun _ ->
    let token =
        match Environment.environVarOrDefault "github_token" "" with
        | s when not (System.String.IsNullOrWhiteSpace s) -> s
        | _ -> failwith "please set the github_token environment variable to a github personal access token with repro access."

    let files = !! ".output/**/*.*"

    token
    |> GitHub.createClientWithToken
    |> GitHub.draftNewRelease gitOwner gitRepo release.NugetVersion (release.SemVer.PreRelease <> None) release.Notes
    |> GitHub.uploadFiles files
    |> GitHub.publishDraft
    |> Async.RunSynchronously)

Target.create "DocsClean" (cleanDirs "docs/" "docs/dist")
Target.create "DocsBuild" (build "docs/")
Target.create "DemosCopy" (fun _ ->
    Shell.cleanDir "docs/demos"
    Shell.copyDir
        "docs/demos"
        "docs/src/bin/Release/netstandard2.0/Demos"
        (fun _ -> true) )
Target.create "DocsYarnInstall" (fun _ -> 
    Yarn.install (fun o -> { o with WorkingDirectory = "docs/" }))
let inline withWorkDir wd =
    DotNet.Options.withWorkingDirectory wd

Target.create "DocsRun" (fun _ -> DotNet.exec (withWorkDir "./docs/src") "fable" "yarn-run start" |> ignore)

Target.create "DocsPackage" (fun _ ->
    DotNet.exec
        (withWorkDir "./docs/src")
        "fable"
        "yarn-run build"
        |> ignore)

// Where to push generated documentation
let githubLink = "https://github.com/mvsmal/fable-material-ui.git"
let publishBranch = "gh-pages"
let temp        = "docs/temp"
let docsOuput = "docs/dist"

// --------------------------------------------------------------------------------------
// Release Scripts

Target.create "DocsPublish" (fun _ ->
    let now = System.DateTime.Now
    Shell.cleanDir temp
    Repository.cloneSingleBranch "" githubLink publishBranch temp

    Shell.copyRecursive docsOuput temp true |> Trace.tracefn "%A"
    Staging.stageAll temp
    Commit.exec temp (sprintf "Update site (%s)" (now.ToShortDateString()))
    Branches.push temp
)

Target.create "All" ignore
Target.create "BuildPackage" ignore
Target.create "BuildSamples" ignore
Target.create "Release" ignore

"Clean"
    ==> "DocsClean"
    ==> "DocsBuild"
    ==> "DemosCopy"
    ==> "DocsYarnInstall"

"DocsYarnInstall"
    ==> "DocsRun"

"DocsYarnInstall"
    ==> "DocsPackage"
    ==> "DocsPublish"

"Clean"
    ==> "AssemblyInfo"
    ==> "Build"
    ==> "Nuget"
    ==> "BuildPackage"
    ==> "All"

"BuildPackage"
    ==> "PublishNuget"
    ==> "GitHubRelease"
    ==> "Release"

Target.runOrDefault "Build"
