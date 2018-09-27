module GettingStarted.Installation.View

open Fable.Core.JsInterop
open Components

let text = importDefault "./Installation.md"

let root () =
    Markdown.view text