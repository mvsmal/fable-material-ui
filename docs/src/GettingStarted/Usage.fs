module GettingStarted.Usage.View

open Fable.Core.JsInterop
open Components

let text = importDefault "./Usage.md"

let root () =
    Markdown.view text
