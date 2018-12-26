module Demos.Buttons.IconLabelButtons

open Fable.Core.JsInterop
open Fable.Helpers.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Props
module R = Fable.Helpers.React

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Button [ CSSProp.Margin theme.spacing.unit ]
        Styles.Custom ("leftIcon", [ CSSProp.MarginRight theme.spacing.unit ])
        Styles.Custom ("rightIcon", [ CSSProp.MarginLeft theme.spacing.unit ])
        Styles.Custom ("iconSmall", [ CSSProp.FontSize 20 ])
    ]

let buttons (props : IClassesProps) =
    let classes = props.classes
    R.div [] [
        button [
            ButtonProp.Variant ButtonVariant.Contained
            MaterialProp.Color ComponentColor.Secondary
            HTMLAttr.Class !!classes?button
        ] [
            R.str "Delete"
            icon [ HTMLAttr.Class !!classes?rightIcon ] [ R.str "delete_icon" ]
        ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            MaterialProp.Color ComponentColor.Primary
            HTMLAttr.Class !!classes?button
        ] [
            R.str "Send"
            icon [ HTMLAttr.Class !!classes?rightIcon ] [ R.str "send" ]
        ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            MaterialProp.Color ComponentColor.Default
            HTMLAttr.Class !!classes?button
        ] [
            R.str "Upload"
            icon [ HTMLAttr.Class !!classes?rightIcon ] [ R.str "cloud_up" ]
        ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            MaterialProp.Color ComponentColor.Secondary
            HTMLAttr.Disabled true
            HTMLAttr.Class !!classes?button
        ] [
            icon [ HTMLAttr.Class !!classes?leftIcon ] [ R.str "keyboard_voice" ]
            R.str "Talk"
        ]
        button [
            ButtonProp.Variant ButtonVariant.Contained
            ButtonProp.Size ButtonSize.Small
            HTMLAttr.Class !!classes?button
        ] [
            icon [
                HTMLAttr.Class (!!classes?leftIcon + " " + !!classes?iconSmall)
            ] [ R.str "save" ]
            R.str "Save"
        ]
    ]

let buttonsWithStyles = withStyles<IClassesProps> (StyleType.Func styles) [] buttons

let view () =
    R.from buttonsWithStyles createEmpty []
