module App.View

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Core.JsInterop
open Fable.Import.React

open App.State
open Types

importAll "../sass/main.sass"

let root (model: Model) dispatch : ReactElement =
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
|> Program.withReact "app"
|> Program.run
