module Demos.TextFields.View

open Fable.Core.JsInterop
open Fable.Helpers.React

open Demos
open Demos.TextFields
open Components

let text = importDefault "./TextFields.md"
let textFieldText = """
## TextField

The `TextField` wrapper component is a complete form control including a label, input and help text.
"""
let view () =
    div [] [
        Markdown.view text
        Demo.view textFieldText "./TextFields/TextField.fs" TextField.view
    ]
