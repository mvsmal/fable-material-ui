#load ".fake/build.fsx/intellisense.fsx"
open Fake.SystemHelper
open Fake.JavaScript
open Fake.IO
open Fake.Core
open Fake.DotNet
open Fake.IO.Globbing.Operators
open Fake.Core.TargetOperators
open Fake.Api
open Fake.Tools.Git

let paketToolpath = if Environment.isWindows then ".\paket.cmd" else "./paket.sh"
let outputDir = "nuget"
let release =  ReleaseNotes.load "RELEASE_NOTES.md"
let gitOwner = "mvsmal"
let gitRepo = "fable-material-ui"

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

Target.create "Restore" (fun _ ->
    Paket.restore (fun p -> { p with ToolPath = paketToolpath })
)

Target.create "Build" (build "")

Target.create "NuGet" (fun _ ->
    Paket.pack(fun p ->
        { p with
            ToolPath = paketToolpath
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

let inline withDocsWorkDir (p : Yarn.YarnParams) =
    { p with WorkingDirectory = "docs/" }

Target.create "DocsClean" (cleanDirs "docs/" "docs/dist")
Target.create "DocsBuild" (build "docs/")
Target.create "DocsYarnInstall" (fun _ -> Yarn.install withDocsWorkDir)
Target.create "DocsRun" (fun _ -> Yarn.exec "start" withDocsWorkDir)
Target.create "DocsPackage" (fun _ -> Yarn.exec "build" withDocsWorkDir)

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
    ==> "Restore"
    ==> "DocsClean"
    ==> "DocsBuild"
    ==> "DocsYarnInstall"

"DocsYarnInstall"
    ==> "DocsRun"

"DocsYarnInstall"
    ==> "DocsPackage"
    ==> "DocsPublish"

"Clean"
    ==> "Restore"
    ==> "Build"
    ==> "Nuget"
    ==> "BuildPackage"
    ==> "All"

"BuildPackage"
    ==> "PublishNuget"
    ==> "GitHubRelease"
    ==> "Release"

Target.runOrDefault "Build"
