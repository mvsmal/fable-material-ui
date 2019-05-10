module Demos.Popper.View

open Fable.Core.JsInterop
open Fable.React

open Demos.Popper
open Components

let text = importDefault "./Popper.md"

let view () =
    div [] [
        Markdown.view text
        Demo.view "## Simple Popper" "./Demos/Popper/SimplePopper.fs" SimplePopper.view
    ]