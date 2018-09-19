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
        map AppBar (s "demos" </> s "app-bar")
        map Avatars (s "demos" </> s "avatars")
    ]

let urlUpdate (result: Option<Page>) model =
    match result with
    | None ->
        console.error("Error parsing url")
        model,Navigation.modifyUrl (toHash model.currentPage)
    | Some page ->
        { model with currentPage = page; isLanding = (page = Home) }, []

let init result =
    let (model, cmd) =
        urlUpdate result
           { currentPage = Home
             isLanding = true
             menuOpen = false
           }
    model, Cmd.batch [ cmd ]

let update (msg: Msg) model =
    Browser.console.log ("update", msg)
    match msg with
    | ToggleMenu ->
        { model with menuOpen = not model.menuOpen }, Cmd.Empty
    | OpenMenu o->
        { model with menuOpen = o}, Cmd.Empty
