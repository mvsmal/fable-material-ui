module Demos.Buttons.OutlinedButtons

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Props
module R = Fable.Helpers.React


let styles (theme : ITheme) : IStyles list =
    [
        Styles.Button [ CSSProp.Margin theme.spacing.unit ]
        Styles.Input [ CSSProp.Display "none" ]
    ]

let buttons props =
    let classes = props?classes
    R.div [] [
        button [
            ButtonProp.Variant ButtonVariant.Outlined
            HTMLAttr.Class !!classes?button
        ] [ R.str "Default" ]
        button [
            ButtonProp.Variant ButtonVariant.Outlined
            MaterialProp.Color ComponentColor.Primary
            HTMLAttr.Class !!classes?button
        ] [ R.str "Primary" ]
        button [
            ButtonProp.Variant ButtonVariant.Outlined
            MaterialProp.Color ComponentColor.Secondary
            HTMLAttr.Class !!classes?button
        ] [ R.str "Secondary" ]
        button [
            ButtonProp.Variant ButtonVariant.Outlined
            HTMLAttr.Disabled true
            HTMLAttr.Class !!classes?button
        ] [ R.str "Disabled" ]
        button [
            ButtonProp.Variant ButtonVariant.Outlined
            HTMLAttr.Href "#/demos/buttons"
            HTMLAttr.Class !!classes?button
        ] [ R.str "Link" ]
        R.input [
            HTMLAttr.Accept "image/*"
            HTMLAttr.Class !!classes?input
            HTMLAttr.Id "outlined-button-file"
            HTMLAttr.Multiple true
            HTMLAttr.Type "file"
        ]
        R.label [ HTMLAttr.HtmlFor "outlined-button-file" ] [
            button [
                ButtonProp.Variant ButtonVariant.Outlined
                MaterialProp.Component ("span" |> U3.Case1)
                HTMLAttr.Class !!classes?button
            ] [ R.str "Upload" ]
        ]
    ]

let buttonsWithStyles<'a> = withStyles (StyleType.Func styles) [] buttons

let view () =
    R.from buttonsWithStyles createEmpty []