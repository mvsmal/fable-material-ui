module Customization.Themes.DarkTheme

open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

let theme = createMuiTheme [
                ThemeProp.Palette [
                    PaletteProp.Type PaletteType.Dark
                ]
                ThemeProp.Typography [
                    ThemeTypographyProp.UseNextVariants true
                ]
            ]

let darkThemeView (props : IThemeProps) =
    let theme = props.theme
    let primaryText = theme.palette.text.primary
    let primaryColor = theme.palette.primary.main
    
    let primaryTextStyles = [
        CSSProp.BackgroundColor theme.palette.background.``default``
        CSSProp.Padding "8px 16px"
        CSSProp.Color primaryText
    ]
    let primaryColorStyles = [
        CSSProp.BackgroundColor primaryColor
        CSSProp.Padding "8px 16px"
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
    muiThemeProvider [ MuiThemeProviderProp.Theme (ProviderTheme.Theme theme) ] [
        from withTheme createEmpty<IThemeProps> []
    ]
