module Components.StaticPage.View

open Fable.Core
open Fable.Core.JsInterop
open Global
open Components


[<Emit("require.context($0, true, /\\.md$/);")>]
let inline requireContext (dir: string) = jsNative

let staticPageContext: obj = requireContext "../"

let private staticPageToUrl =
    function
    | Usage -> "./GettingStarted/Usage.md"
    | Installation -> "./GettingStarted/Installation.md"
    | MigrationToV2 -> "./GettingStarted/MigrationToV2.md"
    | MigrationToV3 -> "./GettingStarted/MigrationToV3.md"
    | MigrationToV4 -> "./GettingStarted/MigrationToV4.md"
    | DefaultTheme -> "./Customization/DefaultTheme.md"

let root page =
    let text = !!(staticPageContext $ (staticPageToUrl page))
    Markdown.view text