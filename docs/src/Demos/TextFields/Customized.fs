module Demos.TextFields.Customized

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
open Fable.MaterialUI

let toObj props = keyValueList CaseRules.LowerFirst props

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Container [
            CSSProp.Display DisplayOptions.Flex
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
        Styles.Custom ("bootstrapRoot", [
            CSSProp.Custom ("label + &", [
                CSSProp.MarginTop (theme.spacing.unit * 3)
            ] |> toObj)
        ])
        Styles.Custom ("bootstrapInput", [
            CSSProp.BorderRadius 4
            CSSProp.BackgroundColor theme.palette.common.white
            CSSProp.Border "1px solid #ced4da"
            CSSProp.FontSize 16
            CSSProp.Padding "10px 12px"
            CSSProp.Transition (theme.transitions.create([|"border-color"; "box-shadow"|] |> U2.Case2))
            CSSProp.FontFamily (
                [ "-apple-system"
                  "BlinkMacSystemFont"
                  "\"Segou UI\""
                  "Roboto"
                  "\"Helvetica Neue\""
                  "Arial"
                  "sans-serif"
                  "\"Apple Color Emoji\""
                  "\"Segoe UI Emoji\""
                  "\"Segoe UI Symbol\"" ] |> String.concat(","))
            CSSProp.Custom ("&:focus", [
                CSSProp.BorderColor "#80bdff"
                CSSProp.BoxShadow "0 0 0 0.2rem rgba(0,123,255,.25)"
            ] |> toObj)
        ])
        Styles.Custom ("bootstrapFormLabel", [
            CSSProp.FontSize 18
        ])
    ]

let theme = createMuiTheme([
                ThemeProp.Typography [
                    ThemeTypographyProp.UseNextVariants true
                ]
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
        formControl [ Class !!classes?margin ] [
            inputLabel [
                InputLabelProp.Shrink true
                HTMLAttr.HtmlFor "bootstrap-input"
                HTMLAttr.Class !!classes?bootstrapFormLabel
            ] [ str "Bootstrap" ]
            inputBase [
                HTMLAttr.Id "bootstrap-input"
                HTMLAttr.DefaultValue "react-bootstrap"
                MaterialProp.Classes [
                    ClassNames.Root !!classes?bootstrapRoot
                    ClassNames.Input !!classes?bootstrapInput
                ]
            ]
        ]
        inputBase [
            HTMLAttr.Class !!classes?margin
            HTMLAttr.DefaultValue "Naked input"
        ]
    ]

let textFieldsWithStyles = withStyles (StyleType.Func styles) [] customizedInputs

let view () =
    ReactElementType.create textFieldsWithStyles createEmpty<IClassesProps> []
