module Customization.Themes.OverrideProperties

open Fable.React
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props

let theme = createMuiTheme [
                ThemeProp.Typography [
                    ThemeTypographyProp.UseNextVariants true
                ]
                ThemeProp.Props [
                    // Name of the component ⚛️
                    ThemePropsProp.MuiButtonBase [
                        // The properties to apply
                        MaterialProp.DisableRipple true // No more ripple, on the whole application 💣!
                    ]
                ]
            ]

let view () =
    muiThemeProvider [ MuiThemeProviderProp.Theme (ProviderTheme.Theme theme) ] [
        button [] [ str "Override properties" ]
    ]

