module Demos.Buttons.CustomizedButtons

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.MaterialUI
open Fable.Helpers.React.Props
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Props
open Fable.MaterialUI
module R = Fable.Helpers.React

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Container [
            CSSProp.Display "flex"
            CSSProp.FlexWrap "wrap"
        ]
        Styles.Custom ("margin", [ CSSProp.Margin theme.spacing.unit])
        Styles.Custom
            ("cssRoot", [
                CSSProp.Color (theme.palette.getContrastText(Colors.purple.``500``))
                CSSProp.BackgroundColor Colors.purple.``500``
                CSSProp.Custom
                    ("&:hover", [ CSSProp.BackgroundColor Colors.purple.``700`` ])
            ])
        Styles.Custom
            ("boostrapRoot", [
                CSSProp.BoxShadow "none"
                CSSProp.TextTransform "none"
                CSSProp.FontSize 16
                CSSProp.Padding "6px 12px"
                CSSProp.Border "1px solid"
                CSSProp.BackgroundColor "#007bff"
                CSSProp.BorderColor "#007bff"
                CSSProp.FontFamily
                    ([ "-apple-system"
                       "BlinkMacSystemFont"
                       @"""Segoe UI"""
                       "Roboto"
                       @"""Helvetica Neue"""
                       "Arial"
                       "sans-serif"
                       @"""Apple Color Emoji"""
                       @"""Segoe UI Emoji"""
                       @"""Segoe UI Symbol"""] |> String.concat ",")
                CSSProp.Custom
                    ("&:hover", [
                        CSSProp.BackgroundColor "#0069d9"
                        CSSProp.BorderColor "#0069d9"
                    ])
                CSSProp.Custom
                    ("&:active", [
                        CSSProp.BoxShadow "none"
                        CSSProp.BackgroundColor "#0062cc"
                        CSSProp.BorderColor "#0062cc"
                    ])
                CSSProp.Custom
                    ("&:focus", [
                        CSSProp.BoxShadow "0 0 0 0.2rem rgba(0,123,255,.5)"
                    ])
            ])
    ]

let theme = createMuiTheme [
                ThemeProp.Palette [
                    PaletteProp.Primary [ PaletteIntentionProp.Main Colors.green.``500`` ]
                ]
            ]


let buttons (props : IClassesProps) =
    let classes = props.classes
    R.div [ HTMLAttr.Class !!classes?container ] [
        button [
            ButtonProp.Variant ButtonVariant.Contained
            MaterialProp.Color ComponentColor.Primary
            HTMLAttr.Class ([!!classes?margin; !!classes?cssRoot] |> String.concat " ")
        ] [ R.str "Custom CSS" ]
        muiThemeProvider [ MuiThemeProviderProp.Theme (ProviderTheme.Theme theme) ] [
            button [
                ButtonProp.Variant ButtonVariant.Contained
                MaterialProp.Color ComponentColor.Primary
                HTMLAttr.Class !!classes?margin
            ] [ R.str "MuiThemeProvider" ]
        ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            MaterialProp.Color ComponentColor.Primary
            MaterialProp.DisableRipple true
            HTMLAttr.Class ([!!classes?margin; !!classes?bootstrapRoot] |> String.concat " ")
        ] [ R.str "Bootstrap" ]
    ]

let buttonsWithStyles = withStyles<IClassesProps> (StyleType.Func styles) [] buttons

let view () =
    R.from buttonsWithStyles createEmpty []
