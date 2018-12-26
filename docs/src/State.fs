module App.State

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Import.Browser
open Fable.Import
open Global
open Types

let pageParser: Parser<Page->Page,Page> =
    oneOf [
        map Home (s "/")
        map Home (s "home")
        map Installation (s "getting-started" </> s "installation")
        map Usage (s "getting-started" </> s "usage")
        map MigrationToV2 (s "getting-started" </> s "migration-to-v2")
        map MigrationToV3 (s "getting-started" </> s "migration-to-v3")
        map AppBar (s "demos" </> s "app-bar")
        map Avatars (s "demos" </> s "avatars")
        map Buttons (s "demos" </> s "buttons")
        map TextFields (s "demos" </> s "text-fields")
        map SignIn (s "pagelayout" </> s "signin")
        map Overrides (s "customization" </> s "overrides")
        map Themes (s "customization" </> s "themes")
        map CssInJs (s "customization" </> s "css-in-js")
        map DefaultTheme (s "customization" </> s "default-theme")
        map Api (s "api" </> str)
    ]

let urlUpdate (result: Option<Page>) model =
    match result with
    | None ->
        model,Navigation.modifyUrl (toHash model.currentPage)
    | Some page ->
        { model with currentPage = page; isLanding = (page = Home) }, [fun _ -> Browser.window.scroll(0.,0.) ]

let init result =
    let (model, cmd) =
        urlUpdate result
           { currentPage = Home
             isLanding = true
             menuOpen = false
           }
    model, Cmd.batch [ cmd ]

let update (msg: Msg) model =
    match msg with
    | OpenMenu o->
        { model with menuOpen = o}, Cmd.Empty
