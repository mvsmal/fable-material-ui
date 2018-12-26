module GettingStarted.MigrationToV3.View

open Fable.Core.JsInterop
open Components

let text = importDefault "./MigrationToV3.md"

let root () =
    Markdown.view text
