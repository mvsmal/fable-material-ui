module Demos.Buttons.IconButtons

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
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
        iconButton [
            HTMLAttr.Custom ("aria-label", "Delete")
            HTMLAttr.Class !!classes?button
        ] [ icon [] [ str "delete_icon" ] ]
        iconButton [
            MaterialProp.Color ComponentColor.Primary
            HTMLAttr.Disabled true
            HTMLAttr.Custom ("aria-label", "Delete")
            HTMLAttr.Class !!classes?button
        ] [ icon [] [ str "delete_icon" ] ]
        iconButton [
            MaterialProp.Color ComponentColor.Secondary
            HTMLAttr.Custom ("aria-label", "Add an alarm")
            HTMLAttr.Class !!classes?button
        ] [ icon [] [ str "alarm_icon" ] ]
        iconButton [
            MaterialProp.Color ComponentColor.Primary
            HTMLAttr.Custom ("aria-label", "Add to shopping cart")
            HTMLAttr.Class !!classes?button
        ] [ icon [] [ str "add_shopping_cart_icon" ] ]
        Standard.input [
            HTMLAttr.Accept "image/*"
            HTMLAttr.Class !!classes?input
            HTMLAttr.Id "icon-button-file"
            HTMLAttr.Type "file"
        ]
        label [ HTMLAttr.HtmlFor "icon-button-file" ] [
            iconButton [
                MaterialProp.Color ComponentColor.Primary
                MaterialProp.Component ("span" |> ReactElementType.ofHtmlElement)
                HTMLAttr.Class !!classes?button
            ] [ icon [] [ str "photo_camera_icon" ] ]
        ]
    ]

let buttonsWithStyles<'a> = withStyles (StyleType.Func styles) [] buttons

let view () =
    ReactElementType.create buttonsWithStyles createEmpty []
