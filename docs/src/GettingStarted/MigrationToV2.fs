module GettingStarted.MigrationToV2.View

open Fable.Core.JsInterop
open Components

let text = importDefault "./MigrationToV2.md"

let root () =
    Markdown.view text
