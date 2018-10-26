module Customization.Themes.Palette

open Fable.Helpers.React
open Fable.Helpers.MaterialUI
open Fable.MaterialUI.Props
open Fable.MaterialUI

let theme = createMuiTheme [
                ThemeProp.Typography [
                    ThemeTypographyProp.UseNextVariants true
                ]
                ThemeProp.Palette [
                    PaletteProp.Primary [
                        PaletteIntentionProp.Main Colors.purple.``500``
                    ]
                    PaletteProp.Secondary [
                        PaletteIntentionProp.Main "#11cb5f"
                    ]
                ]
            ]

let view () =
    muiThemeProvider [
        MuiThemeProviderProp.Theme (ProviderTheme.Theme theme)
    ] [
        button [ MaterialProp.Color ComponentColor.Primary ] [ str "Primary" ]
        button [ MaterialProp.Color ComponentColor.Secondary ] [ str "Secondary" ]
    ]