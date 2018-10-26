module Api.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Components

[<Emit("require.context($0, true, /\\.md$/);")>]
let inline requireContext (dir: string) = jsNative

let requireWithContext: obj = requireContext "./"

let view comp =
    let path = sprintf "./%s.md" comp
    try
        let text = !!(requireWithContext $ path)
        Markdown.view text
    with
    | e -> div [] [ str "not found" ]