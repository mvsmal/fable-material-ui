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
        map Autocomplete (s "demos" </> s "autocomplete")
        map Avatars (s "demos" </> s "avatars")
    ]

let urlUpdate (result: Option<Page>) model =
    Browser.console.log ("urlUpdate", result, model)
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

let update msg model =
    Browser.console.log ("udpate", msg, model)
    let result =
        match msg with
        | Navigate page ->
            { model with
                currentPage = page
                isLanding = (page = Home)
            }, Navigation.newUrl (toHash page)
        | ToggleMenu ->
            { model with menuOpen = not model.menuOpen }, Cmd.Empty
    result
