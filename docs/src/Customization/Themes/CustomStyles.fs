module Customization.Themes.CustomStyles

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Helpers.MaterialUI
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
open Fable.MaterialUI

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Root [
            CSSProp.Color theme?status?danger
            CSSProp.Custom ("&$checked", [
                CSSProp.Color theme?status?danger
            ] |> keyValueList CaseRules.LowerFirst)
        ]
        Styles.Checked []
    ]

let customCheckbox (props : IClassesProps) =
    checkbox [
        HTMLAttr.DefaultChecked true
        MaterialProp.Classes [
            ClassNames.Root !!props.classes?root
            ClassNames.Checked !!props.classes?``checked``
        ]
    ]

let customCheckboxWithStyles = withStyles<IClassesProps> (StyleType.Func styles) [] customCheckbox

let theme = createMuiTheme [
                ThemeProp.Typography [
                    ThemeTypographyProp.UseNextVariants true
                ]
                ThemeProp.Custom ("status", [
                    ("danger", Colors.orange.``500``)
                ] |> keyValueList CaseRules.LowerFirst)
            ]

let view () =
    muiThemeProvider [ MuiThemeProviderProp.Theme (ProviderTheme.Theme theme) ] [
        from customCheckboxWithStyles createEmpty []
    ]