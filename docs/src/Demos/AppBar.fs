module Demos.AppBar.View

open Fable.Core.JsInterop
open Fable.React

open Demos.AppBar
open Components

let text = importDefault "./AppBar.md"

let view () =
    div [] [
        Markdown.view text
        Demo.view "## Simple App Bar" "./Demos/AppBar/SimpleAppBar.fs" SimpleAppBar.view
        Demo.view "## App Bar with buttons" "./Demos/AppBar/AppBarWithButtons.fs" AppBarWithButtons.view
    ]