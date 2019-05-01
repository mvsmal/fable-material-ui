module Demos.TextFields.Layout

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Container [
            CSSProp.Display DisplayOptions.Flex
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
            TextFieldProp.HelperText ("Some important text" |> str)
        ] []
        textField [
            HTMLAttr.Label "Dense"
            HTMLAttr.Id "margin-dense"
            HTMLAttr.DefaultValue "Default value"
            HTMLAttr.Class !!classes?textField
            TextFieldProp.HelperText ("Some important text" |> str)
            MaterialProp.Margin FormControlMargin.Dense
        ] []
        textField [
            HTMLAttr.Label "Normal"
            HTMLAttr.Id "margin-normal"
            HTMLAttr.DefaultValue "Default value"
            HTMLAttr.Class !!classes?textField
            TextFieldProp.HelperText ("Some important text" |> str)
            MaterialProp.Margin FormControlMargin.Normal
        ] []
    ]

let textFieldsWithStyles = withStyles (StyleType.Func styles) [] layoutTextFields

let view () =
    ReactElementType.create textFieldsWithStyles createEmpty<IClassesProps> []
