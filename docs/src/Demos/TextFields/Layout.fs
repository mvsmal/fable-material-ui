module Demos.TextFields.Layout

open Fable.Core
open Fable.Helpers.React
open Fable.Core.JsInterop
open Fable.Helpers.MaterialUI
open Fable.Helpers.React.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Container [
            CSSProp.Display "flex"
            CSSProp.FlexWrap "wrap"
        ]
        Styles.Custom ("textField", [
            CSSProp.MarginLeft theme.spacing.unit
            CSSProp.MarginRight theme.spacing.unit
            CSSProp.Width 200
        ])
    ]

let layoutTextFields (props : IClassesProps) =
    let classes = props?classes

    div [ Class !!classes?container ] [
        textField [
            HTMLAttr.Label "None"
            HTMLAttr.Id "margin-none"
            HTMLAttr.DefaultValue "Default value"
            HTMLAttr.Class !!classes?textField
            TextFieldProp.HelperText ("Some important text" |> str |> U2.Case1 |> U3.Case1)
        ] []
        textField [
            HTMLAttr.Label "Dense"
            HTMLAttr.Id "margin-dense"
            HTMLAttr.DefaultValue "Default value"
            HTMLAttr.Class !!classes?textField
            TextFieldProp.HelperText ("Some important text" |> str |> U2.Case1 |> U3.Case1)
            MaterialProp.Margin FormControlMargin.Dense
        ] []
        textField [
            HTMLAttr.Label "Normal"
            HTMLAttr.Id "margin-normal"
            HTMLAttr.DefaultValue "Default value"
            HTMLAttr.Class !!classes?textField
            TextFieldProp.HelperText ("Some important text" |> str |> U2.Case1 |> U3.Case1)
            MaterialProp.Margin FormControlMargin.Normal
        ] []
    ]

let textFieldsWithStyles = withStyles (StyleType.Func styles) [] layoutTextFields

let view () =
    from textFieldsWithStyles createEmpty<IClassesProps> []
