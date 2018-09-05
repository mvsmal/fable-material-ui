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
        map Home (s "/home")
        map Installation (s "/getting-started/installation")
        map Usage (s "/getting-started/usage")
        map AppBar (s "/demos/app-bar")
        map Autocomplete (s "/demos/autocomplete")
        map Avatars (s "/demos/avatars")
    ]

let urlUpdate (result: Option<Page>) model =
    match result with
    | None ->
        console.error("Error parsing url")
        model,Navigation.modifyUrl (toPath model.currentPage)
    | Some page ->
        { model with currentPage = page }, []

let init result =
    let (model, cmd) =
        urlUpdate result
           { currentPage = Home
             isLanding = true
             menuOpen = false
             menuSections = Map.ofList [] }
    model, Cmd.batch [ cmd ]

let update msg model =
    let result =
        match msg with
        | Navigate page ->
            { model with
                currentPage = page
                isLanding = (page = Home)
            }, Navigation.newUrl (toPath page)
        | ToggleMenu ->
            { model with menuOpen = not model.menuOpen }, Cmd.Empty
        | ToggleMenuItem title ->
            let newMap =
                model.menuSections |>
                match model.menuSections.TryFind title with
                | Some i -> Map.add title (not i)
                | None -> Map.add title true
            { model with menuSections = newMap }, Cmd.Empty
    result
