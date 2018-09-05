module App.View

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.Browser
open Types
open App.State
open Global

importAll "../sass/main.sass"

open Fable.Helpers.React
open Fable.Helpers.React.Props
module Mui = Fable.Helpers.MaterialUI
module MProps = Fable.MaterialUI.Props
module MColors = Fable.MaterialUI.Colors
module MTheme = Fable.MaterialUI.Themes
open Fable.Import.React

let theme =
    Mui.createMuiTheme [
        MProps.ThemeProp.Palette [
            MProps.PaletteProp.Primary [
                MProps.PaletteIntentionProp.Main MColors.blue.``500``
            ]
        ]
    ]

let root model dispatch : ReactElement =
    Mui.appBar [ MProps.Position MProps.AppBarPosition.Fixed ] [
        Mui.toolbar [] [
            Mui.iconButton [ MProps.IconProp.Color MProps.IconColor.Inherit ] [
                Mui.icon [] [ str "menu" ]
            ]
        ]
    ]

open Elmish.React
open Elmish.Debug
open Elmish.HMR

// App
Program.mkProgram init update root
|> Program.toNavigable (parsePath pageParser) urlUpdate
#if DEBUG
|> Program.withDebugger
|> Program.withHMR
#endif
|> Program.withReact "app"
|> Program.run
