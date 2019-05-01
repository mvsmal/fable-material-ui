module Demos.Buttons.CustomizedButtons

open Fable.Core
open Fable.Core.JsInterop
open Fable.MaterialUI.Core
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Props
open Fable.MaterialUI

let toObj = keyValueList CaseRules.LowerFirst

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Container [
            CSSProp.Display DisplayOptions.Flex
            CSSProp.FlexWrap "wrap"
        ]
        Styles.Custom ("margin", [ CSSProp.Margin theme.spacing.unit])
        Styles.Custom
            ("cssRoot", [
                CSSProp.Color (theme.palette.getContrastText(Colors.purple.``500``))
                CSSProp.BackgroundColor Colors.purple.``500``
                CSSProp.Custom
                    ("&:hover", [ CSSProp.BackgroundColor Colors.purple.``700`` ] |> toObj)
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
                    ] |> toObj)
                CSSProp.Custom
                    ("&:active", [
                        CSSProp.BoxShadow "none"
                        CSSProp.BackgroundColor "#0062cc"
                        CSSProp.BorderColor "#0062cc"
                    ] |> toObj)
                CSSProp.Custom
                    ("&:focus", [
                        CSSProp.BoxShadow "0 0 0 0.2rem rgba(0,123,255,.5)"
                    ] |> toObj)
            ])
    ]

let theme = createMuiTheme [
                Typography [
                    // Needed until Material-UI v4 to avoid deprecation warning: https://material-ui.com/style/typography#migration-to-typography-v2
                    UseNextVariants true
                ]
                ThemeProp.Palette [
                    PaletteProp.Primary [ PaletteIntentionProp.Main Colors.green.``500`` ]
                ]
            ]


let buttons (props : IClassesProps) =
    let classes = props.classes
    div [ HTMLAttr.Class !!classes?container ] [
        button [
            ButtonProp.Variant ButtonVariant.Contained
            MaterialProp.Color ComponentColor.Primary
            HTMLAttr.Class ([!!classes?margin; !!classes?cssRoot] |> String.concat " ")
        ] [ str "Custom CSS" ]
        muiThemeProvider [ MuiThemeProviderProp.Theme (ProviderTheme.Theme theme) ] [
            button [
                ButtonProp.Variant ButtonVariant.Contained
                MaterialProp.Color ComponentColor.Primary
                HTMLAttr.Class !!classes?margin
            ] [ str "MuiThemeProvider" ]
        ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            MaterialProp.Color ComponentColor.Primary
            MaterialProp.DisableRipple true
            HTMLAttr.Class ([!!classes?margin; !!classes?bootstrapRoot] |> String.concat " ")
        ] [ str "Bootstrap" ]
    ]

let buttonsWithStyles = withStyles<IClassesProps> (StyleType.Func styles) [] buttons

let view () =
    ReactElementType.create buttonsWithStyles createEmpty []
