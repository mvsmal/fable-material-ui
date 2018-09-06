module GettingStarted.Installation.View
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Components.Typography
open Components.Code

let root () =
    div [] [
        title "Installation"
        description "Install Fable bindings for Material-UI"
        display1 "Nuget"
        p [] [
            str "Fable Material-UI is available as "
            a [ 
                Target "_blank"
                Href "https://www.nuget.org/packages/Fable.MaterialUI/"
            ] [ str "Nuget package" ]
        ]
        code "dotnet add package Fable.MaterialUI" "shell"
        p [ Class "low" ] [ str "or" ]
        code "paket add Fable.MaterialUI" "shell"
        display1 "NPM"
        p [] [
            str "You also need to install "
            a [
                Target "_blank"
                Href "https://material-ui.com/getting-started/installation/"
            ] [ str "Material-UI" ]
            str " npm package"
        ]
        code "npm install @material-ui/core" "shell"
        p [ Class "low" ] [ str "or" ]
        code "yarn add @material-ui/core" "shell"
    ]