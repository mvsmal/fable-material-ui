module Demos.TextFields.Input

open Fable.Helpers.React
open Fable.Core.JsInterop
open Fable.Helpers.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Container [
            CSSProp.Display "flex"
            CSSProp.FlexWrap "wrap"
        ]
        Styles.Input [
            CSSProp.Margin theme.spacing.unit
        ]
    ]

let inputTextFields (props : IClassesProps) =
    let classes = props.classes

    div [ Class !!classes?container ] [
        input [
            HTMLAttr.DefaultValue "Hello world"
            HTMLAttr.Class !!classes?input
            MaterialProp.InputProps [
                HTMLAttr.Custom ("aria-label", "Description")
            ]
        ]
        input [
            HTMLAttr.Placeholder "Placeholder"
            HTMLAttr.Class !!classes?input
            MaterialProp.InputProps [
                HTMLAttr.Custom ("aria-label", "Description")
            ]
        ]
        input [
            HTMLAttr.Value "Disabled"
            HTMLAttr.Class !!classes?input
            HTMLAttr.Disabled true
            MaterialProp.InputProps [
                HTMLAttr.Custom ("aria-label", "Description")
            ]
        ]
        input [
            HTMLAttr.DefaultValue "Error"
            HTMLAttr.Class !!classes?input
            MaterialProp.Error true
            MaterialProp.InputProps [
                HTMLAttr.Custom ("aria-label", "Description")
            ]
        ]
    ]

let textFieldsWithStyles = withStyles (StyleType.Func styles) [] inputTextFields

let view () =
    from textFieldsWithStyles createEmpty<IClassesProps> []