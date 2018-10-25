module Customization.Overrides.ClassNesting

open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Helpers.MaterialUI
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

let styles : IStyles list = [
    Styles.Root [
        CSSProp.Background "linear-gradient(45deg, #FE6B8B 30%, #FF8E53 90%)"
        CSSProp.BorderRadius 3
        CSSProp.Border 0
        CSSProp.Color "white"
        CSSProp.Height 48
        CSSProp.Padding "0 30px"
        CSSProp.BoxShadow "0 3px 5px 2px rgba(255, 105, 135, .3)"
    ]
    Styles.Label [
        CSSProp.TextTransform "capitalize"
    ]
]

let classNesting (props : IClassesProps) =
    button [
        MaterialProp.Classes [
            ClassNames.Root !!props.classes?root
            ClassNames.Label !!props.classes?label
        ]
    ] [ str "classes nesting" ]

let withStyles = withStyles (StyleType.Styles styles) [] classNesting

let view () =
    from withStyles createEmpty<IClassesProps> []