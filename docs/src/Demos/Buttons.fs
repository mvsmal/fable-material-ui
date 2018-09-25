module Demos.Buttons.View

open Fable.Core.JsInterop
open Fable.Helpers.React

open Demos
open Demos.Buttons
open Components
open Demos.Buttons

let text = importDefault "./Buttons.md"

let textButtonsText = """
## Text Buttons

[Text buttons](https://material.io/design/components/buttons.html#text-button)
are typically used for less-pronounced actions, including those located:

- In dialogs
- In cards

In cards, text buttons help maintain an emphasis on card content.
"""

let view () =
    div [] [
        Markdown.view text
        Demo.view textButtonsText "./Buttons/TextButtons.fs" TextButtons.view
    ]