module Demos.Buttons.ContainedButtons

open Fable.Core
open Fable.Core.JsInterop
open Fable.MaterialUI.Core
open Fable.Helpers.React.Props
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
            ButtonProp.Variant ButtonVariant.Contained
            HTMLAttr.Class !!classes?button
        ] [ R.str "Default" ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            MaterialProp.Color ComponentColor.Primary
            HTMLAttr.Class !!classes?button
        ] [ R.str "Primary" ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            MaterialProp.Color ComponentColor.Secondary
            HTMLAttr.Class !!classes?button
        ] [ R.str "Secondary" ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            HTMLAttr.Disabled true
            HTMLAttr.Class !!classes?button
        ] [ R.str "Disabled" ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            HTMLAttr.Href "#/demos/buttons"
            HTMLAttr.Class !!classes?button
        ] [ R.str "Link" ]
        R.input [
            HTMLAttr.Accept "image/*"
            HTMLAttr.Class !!classes?input
            HTMLAttr.Id "contained-button-file"
            HTMLAttr.Multiple true
            HTMLAttr.Type "file"
        ]
        R.label [ HTMLAttr.HtmlFor "contained-button-file" ] [
            button [
                ButtonProp.Variant ButtonVariant.Contained
                MaterialProp.Component ("span" |> U3.Case1)
                HTMLAttr.Class !!classes?button
            ] [ R.str "Upload" ]
        ]
    ]

let buttonsWithStyles<'a> = withStyles (StyleType.Func styles) [] buttons

let view () =
    R.from buttonsWithStyles createEmpty []