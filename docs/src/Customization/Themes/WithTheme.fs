module Customization.Themes.WithTheme

open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.MaterialUI.Core

let darkThemeView (props : IThemeProps) =
    let theme = props.theme
    let primaryText = theme.palette.text.primary
    let primaryColor = theme.palette.primary.main
    
    let primaryTextStyles = [
        CSSProp.BackgroundColor theme.palette.background.``default``
        CSSProp.Padding ((theme.spacing.unit, theme.spacing.unit * 2) ||> sprintf "%dpx %dpx")
        CSSProp.Color primaryText
    ]
    let primaryColorStyles = [
        CSSProp.BackgroundColor primaryColor
        CSSProp.Padding ((theme.spacing.unit, theme.spacing.unit * 2) ||> sprintf "%dpx %dpx")
        CSSProp.Color theme.palette.common.white
    ]

    div [ Style [ Width 300 ] ] [
        typography [ Style primaryColorStyles ] [
            str ("Primary color " + primaryColor)
        ]
        typography [ Style primaryTextStyles ] [
            str ("Primary text " + primaryText)
        ]
    ]

let withTheme = withTheme darkThemeView


let view () =
    from withTheme createEmpty<IThemeProps> []