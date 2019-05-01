module Demos.Buttons.TextButtons

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Button [
            CSSProp.Margin theme.spacing.unit
        ]
        Styles.Input [
            Display DisplayOptions.None
        ]
    ]
let textButtons (props : IClassesProps) =
    let classes = props.classes
    div [] [
        button [ Class !!classes?button ] [ str "Default" ]
        button [
            MaterialProp.Color ComponentColor.Primary
            Class !!classes?button
        ] [ str "Primary" ]
        button [
            MaterialProp.Color ComponentColor.Secondary
            Class !!classes?button
        ] [ str "Secondary" ]
        button [
            HTMLAttr.Disabled true
            Class !!classes?button
        ] [ str "Disabled" ]
        button [
            Href "#/demos/buttons"
            Class !!classes?button
        ] [ str "Link" ]
        Standard.input [
            Accept "image/*"
            Class !!classes?input
            Id "flat-button-file"
            Multiple true
            HTMLAttr.Type "file"
        ]
        label [
            HtmlFor "flat-button-file"
        ] [
            button [
                MaterialProp.Component ("span" |> ReactElementType.ofHtmlElement)
                Class !!classes?button
            ] [ str "Upload" ]
        ]
    ]

let textButtonsWithStyles<'a> = withStyles (StyleType.Func styles) [] textButtons

let view () =
    ReactElementType.create textButtonsWithStyles createEmpty []