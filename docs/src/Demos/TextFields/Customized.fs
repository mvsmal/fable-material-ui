module Demos.TextFields.Customized

open Fable.Core
open Fable.Helpers.React
open Fable.Core.JsInterop
open Fable.Helpers.MaterialUI
open Fable.Helpers.React.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
open Fable.MaterialUI

let toObj props = keyValueList CaseRules.LowerFirst props

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Container [
            CSSProp.Display "flex"
            CSSProp.FlexWrap "wrap"
        ]
        Styles.Custom ("margin", [
            CSSProp.Margin theme.spacing.unit
        ])
        Styles.Custom ("cssLabel", [
            CSSProp.Custom ("&$cssFocused",
                [
                    CSSProp.Color Colors.purple.``500``
                ] |> toObj)
        ])
        Styles.Custom ("cssFocused", [])
        Styles.Custom ("cssUnderline", [
            CSSProp.Custom ("&:after", [
                CSSProp.BorderBottomColor Colors.purple.``500``
            ] |> toObj)
        ])
    ]

let theme = createMuiTheme([
                ThemeProp.Palette [
                    PaletteProp.Primary [
                        PaletteIntentionProp.Main Colors.green.``500``
                    ]
                ]
            ])

let customizedInputs (props : IClassesProps) =
    let classes = props.classes

    div [ Class !!classes?container ] [
        formControl [ Class !!classes?margin ] [
            inputLabel [
                HTMLAttr.HtmlFor "custom-css-input"
                ChildrenProp.FormLabelClasses [
                    ClassNames.Root !!classes?cssLabel
                    ClassNames.Focused !!classes?cssFocused
                ]
            ] [ str "Custom CSS" ]
            input [
                HTMLAttr.Id "custom-css-input"
                MaterialProp.Classes [
                    ClassNames.Underline !!classes?cssUnderline
                ]
            ]
        ]
        muiThemeProvider [ MuiThemeProviderProp.Theme (ProviderTheme.Theme theme) ] [
            textField [
                HTMLAttr.Class !!classes?margin
                HTMLAttr.Label "MuiThemeProvider"
                HTMLAttr.Id "mui-theme-provider-input"
            ] []
        ]
    ]

let textFieldsWithStyles = withStyles (StyleType.Func styles) [] customizedInputs

let view () =
    from textFieldsWithStyles createEmpty<IClassesProps> []
