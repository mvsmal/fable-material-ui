module Demos.DemoWrapper
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
open Fable.Helpers.MaterialUI
open Utils
let demoStyles (theme : ITheme) : IStyles list =
    [
        Styles.Root [
            CSSProp.FontFamily theme.typography.fontFamily
            CSSProp.FontSize 16
            CSSProp.Color theme.palette.text.primary
            CSSProp.Custom
                ("& p, & ul, & ol", [
                    CSSProp.LineHeight 1.6
                ] |> toObj)
        ]
        Styles.Custom
            ("h1", [
                CSSProp.Color theme.palette.text.secondary
                CSSProp.Margin "32px 0 16px"
            ] |> toObj)
        Styles.Custom
            ("description", [
                CSSProp.Margin "0 0 40px"
            ] |> toObj)
        Styles.Custom
            ("h2", [
                CSSProp.Color theme.palette.text.secondary
                CSSProp.Margin "32px 0 24px"
            ] |> toObj)
    ]

let demoWithStyles<'a> = withStyles (StyleType.Func demoStyles) []

let wrapper child props =
    child !!props?classes

let root child =
    from (wrapper child |> demoWithStyles) createEmpty []