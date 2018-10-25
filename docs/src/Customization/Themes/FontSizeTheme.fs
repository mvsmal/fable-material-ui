module Customization.Themes.FontSizeTheme

open Fable.Helpers.React
open Fable.Helpers.MaterialUI
open Fable.MaterialUI.Props

let theme = createMuiTheme [
                ThemeProp.Typography [
                    ThemeTypographyProp.UseNextVariants true
                    ThemeTypographyProp.HtmlFontSize "10"
                ]
            ]

let view () =
    muiThemeProvider [ MuiThemeProviderProp.Theme (ProviderTheme.Theme theme) ] [
        typography [] [ str "body1" ]
    ]
