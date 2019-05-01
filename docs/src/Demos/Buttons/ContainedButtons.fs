module Demos.Buttons.ContainedButtons

open Fable.Core
open Fable.Core.JsInterop
open Fable.MaterialUI.Core
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Props


let styles (theme : ITheme) : IStyles list =
    [
        Styles.Button [ CSSProp.Margin theme.spacing.unit ]
        Styles.Input [ CSSProp.Display DisplayOptions.None ]
    ]

let buttons props =
    let classes = props?classes
    div [] [
        button [
            ButtonProp.Variant ButtonVariant.Contained
            HTMLAttr.Class !!classes?button
        ] [ str "Default" ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            MaterialProp.Color ComponentColor.Primary
            HTMLAttr.Class !!classes?button
        ] [ str "Primary" ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            MaterialProp.Color ComponentColor.Secondary
            HTMLAttr.Class !!classes?button
        ] [ str "Secondary" ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            HTMLAttr.Disabled true
            HTMLAttr.Class !!classes?button
        ] [ str "Disabled" ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            HTMLAttr.Href "#/demos/buttons"
            HTMLAttr.Class !!classes?button
        ] [ str "Link" ]
        Standard.input [
            HTMLAttr.Accept "image/*"
            HTMLAttr.Class !!classes?input
            HTMLAttr.Id "contained-button-file"
            HTMLAttr.Multiple true
            HTMLAttr.Type "file"
        ]
        Standard.label [ HTMLAttr.HtmlFor "contained-button-file" ] [
            button [
                ButtonProp.Variant ButtonVariant.Contained
                MaterialProp.Component ("span" |> ReactElementType.ofHtmlElement)
                HTMLAttr.Class !!classes?button
            ] [ str "Upload" ]
        ]
    ]

let buttonsWithStyles<'a> = withStyles (StyleType.Func styles) [] buttons

let view () =
    ReactElementType.create buttonsWithStyles createEmpty []