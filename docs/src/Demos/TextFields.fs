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

let outlinedText = """
## Outlined

`TextField` supports outlined styling.
"""

let filledText = """
## Filled

`TextField` supports filled styling.
"""
let view () =
    div [] [
        Markdown.view text
        Demo.view textFieldText "./TextFields/TextField.fs" TextField.view
        Demo.view outlinedText "./TextFields/Outlined.fs" Outlined.view
        Demo.view filledText "./TextFields/Filled.fs" Filled.view
    ]
