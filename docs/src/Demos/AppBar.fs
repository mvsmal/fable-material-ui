module Demos.AppBar.View

open Fable.Core.JsInterop
open Fable.Helpers.React

open Demos
open Demos.AppBar
open Components

let text = importDefault "./AppBar.md"

let view () =
    div [] [
        Markdown.view text
        Demo.view "## Simple App Bar" "./AppBar/SimpleAppBar.fs" SimpleAppBar.view
        Demo.view "## App Bar with buttons" "./AppBar/AppBarWithButtons.fs" AppBarWithButtons.view
    ]