module Demos.Buttons.TextButtons

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.MaterialUI
open Fable.Helpers.React.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
module R = Fable.Helpers.React

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Button [
            CSSProp.Margin theme.spacing.unit
        ]
        Styles.Input [
            Display "none"
        ]
    ]
let textButtons (props : IClassesProps) =
    let classes = props.classes
    R.div [] [
        button [ Class !!classes?button ] [ R.str "Default" ]
        button [
            MaterialProp.Color ComponentColor.Primary
            Class !!classes?button
        ] [ R.str "Primary" ]
        button [
            MaterialProp.Color ComponentColor.Secondary
            Class !!classes?button
        ] [ R.str "Secondary" ]
        button [
            HTMLAttr.Disabled true
            Class !!classes?button
        ] [ R.str "Disabled" ]
        button [
            Href "#/demos/buttons"
            Class !!classes?button
        ] [ R.str "Link" ]
        R.input [
            Accept "image/*"
            Class !!classes?input
            Id "flat-button-file"
            Multiple true
            HTMLAttr.Type "file"
        ]
        R.label [
            HtmlFor "flat-button-file"
        ] [
            button [
                MaterialProp.Component ("span" |> U3.Case1)
                Class !!classes?button
            ] [ R.str "Upload" ]
        ]
    ]

let textButtonsWithStyles<'a> = withStyles (StyleType.Func styles) [] textButtons

let view () =
    R.from textButtonsWithStyles createEmpty []