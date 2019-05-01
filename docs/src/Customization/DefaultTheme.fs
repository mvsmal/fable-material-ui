module Customization.DefaultTheme.View

open Fable.Core.JsInterop
open Fable.React

open Components

let text = importDefault "./DefaultTheme.md"

let view () =
    div [] [
        Markdown.view text
    ]