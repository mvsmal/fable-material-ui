module Components.Typography

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Helpers.MaterialUI
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
open Utils

let titleStyles (theme: ITheme) : IStyles list =
    [
        Styles.Custom
            ("h1", [
                CSSProp.Color theme.palette.text.secondary
                CSSProp.Margin "32px 0 16px"
            ] |> toObj)
    ]

let titleWithProps text props =
    typography [
        TypographyProp.Variant TypographyVariant.Display2
        Class !!props?classes?h1
    ] [ str text ]

let title text =
    from (titleWithProps text |> withStyles (StyleType.Func titleStyles) []) createEmpty []

let descriptionStyles (_: ITheme) : IStyles list =
    [
        Styles.Custom
            ("description", [
                CSSProp.Margin "0 0 40px"
            ] |> toObj)
    ]

let descriptionWithProps text props =
        typography [
            TypographyProp.Variant TypographyVariant.Headline
            Class !!props?classes?description
        ] [ str text ]

let description text =
    from (descriptionWithProps text |> withStyles (StyleType.Func descriptionStyles) []) createEmpty [] 

let display1Styles (theme: ITheme) : IStyles list =
    [
        Styles.Custom
            ("h2", [
                CSSProp.Color theme.palette.text.secondary
                CSSProp.Margin "32px 0 24px"
            ] |> toObj)
    ]
let display1WithProps text props =
    typography [
        TypographyProp.Variant TypographyVariant.Display1
        Class !!props?classes?h2
    ] [ str text ]

let display1 text =
    from (display1WithProps text |> withStyles (StyleType.Func display1Styles) []) createEmpty []