module Demos.AppBar.View
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Components.Typography
open Demos.AppBar
open Demos

let root () =
    div [] [
        title "App Bar"
        description "The App Bar displays information and actions relating to the current screen."
        p [] [
            str "The top App Bar provides content and actions related to the current screen. It’s used for branding, screen titles, navigation, and actions."
        ]
        p [] [
            str "It can transform into a contextual action bar or used as a navbar."
        ]
        Demo.root "Simple App Bar" "./AppBar/SimpleAppBar.fs" SimpleAppBar.view
        Demo.root "App Bar with buttons" "./AppBar/AppBarWithButtons.fs" AppBarWithButtons.view
    ]