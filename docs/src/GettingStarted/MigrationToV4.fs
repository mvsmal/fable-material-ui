module GettingStarted.MigrationToV4.View

open Fable.Core.JsInterop
open Components

let text = importDefault "./MigrationToV4.md"

let root () =
    Markdown.view text