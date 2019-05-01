module App.View

open Elmish
open Elmish.Navigation
open Elmish.UrlParser
open Fable.Core.JsInterop
open Fable.React

open App.State
open Types

importAll "../sass/main.sass"

let root (model: Model) dispatch =
    Layout.Layout.view model dispatch


open Elmish.React
open Elmish.Debug
open Elmish.HMR

// App
Program.mkProgram init update root
|> Program.toNavigable (parseHash pageParser) urlUpdate
#if DEBUG
|> Program.withDebugger
#endif
|> Program.withReactBatched "app"
|> Program.run
