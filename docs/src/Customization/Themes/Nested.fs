module Customization.Themes.Nested

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Helpers.MaterialUI
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
open Fable.MaterialUI

let styles (theme : ITheme) : IStyles list = [
    Styles.Root [
        CSSProp.Color theme.palette.primary.main
        CSSProp.Custom ("&$checked", [
            CSSProp.Color theme.palette.primary.main
        ] |> keyValueList CaseRules.LowerFirst)
    ]
    Styles.Checked []
]

let nestedCheckBox (props : IClassesProps) =
    checkbox [
        HTMLAttr.DefaultChecked true
        MaterialProp.Classes [
            ClassNames.Root !!props.classes?root
            ClassNames.Checked !!props.classes?``checked``
        ]
    ]

let nestedWithStyles = withStyles<IClassesProps> (StyleType.Func styles) [] nestedCheckBox

let theme1 = createMuiTheme [
                ThemeProp.Palette [
                    PaletteProp.Primary [
                        PaletteIntentionProp.Main Colors.green.``500``
                    ]
                ]
            ]

let theme2 = createMuiTheme [
                ThemeProp.Palette [
                    PaletteProp.Primary [
                        PaletteIntentionProp.Main Colors.orange.``500``
                    ]
                ]
            ]

let view () =
    div [] []
