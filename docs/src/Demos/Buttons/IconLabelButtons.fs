module Demos.Buttons.IconLabelButtons

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Props

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Button [ CSSProp.Margin theme.spacing.unit ]
        Styles.Custom ("leftIcon", [ CSSProp.MarginRight theme.spacing.unit ])
        Styles.Custom ("rightIcon", [ CSSProp.MarginLeft theme.spacing.unit ])
        Styles.Custom ("iconSmall", [ CSSProp.FontSize 20 ])
    ]

let buttons (props : IClassesProps) =
    let classes = props.classes
    div [] [
        button [
            ButtonProp.Variant ButtonVariant.Contained
            MaterialProp.Color ComponentColor.Secondary
            HTMLAttr.Class !!classes?button
        ] [
            str "Delete"
            icon [ HTMLAttr.Class !!classes?rightIcon ] [ str "delete_icon" ]
        ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            MaterialProp.Color ComponentColor.Primary
            HTMLAttr.Class !!classes?button
        ] [
            str "Send"
            icon [ HTMLAttr.Class !!classes?rightIcon ] [ str "send" ]
        ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            MaterialProp.Color ComponentColor.Default
            HTMLAttr.Class !!classes?button
        ] [
            str "Upload"
            icon [ HTMLAttr.Class !!classes?rightIcon ] [ str "cloud_up" ]
        ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            MaterialProp.Color ComponentColor.Secondary
            HTMLAttr.Disabled true
            HTMLAttr.Class !!classes?button
        ] [
            icon [ HTMLAttr.Class !!classes?leftIcon ] [ str "keyboard_voice" ]
            str "Talk"
        ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            ButtonProp.Size ButtonSize.Small
            HTMLAttr.Class !!classes?button
        ] [
            icon [
                HTMLAttr.Class (!!classes?leftIcon + " " + !!classes?iconSmall)
            ] [ str "save" ]
            str "Save"
        ]
    ]

let buttonsWithStyles = withStyles<IClassesProps> (StyleType.Func styles) [] buttons

let view () =
    ReactElementType.create buttonsWithStyles createEmpty []
