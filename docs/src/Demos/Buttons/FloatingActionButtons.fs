module Demos.Buttons.FloatingActionButtons

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.MaterialUI
open Fable.Helpers.React.Props
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Props
module R = Fable.Helpers.React

let toObj = keyValueList CaseRules.LowerFirst

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Button [ CSSProp.Margin theme.spacing.unit ]
        Styles.Custom ("extendedIcon", [ CSSProp.MarginRight theme.spacing.unit ] |> toObj)
    ]

let buttons props =
    let classes = props?classes
    R.div [] [
        button [
            ButtonProp.Variant ButtonVariant.Fab
            MaterialProp.Color ComponentColor.Primary
            HTMLAttr.Class !!classes?button
        ] [ icon [] [ R.str "add_icon" ]]
        button [
            ButtonProp.Variant ButtonVariant.Fab
            MaterialProp.Color ComponentColor.Secondary
            HTMLAttr.Class !!classes?button
        ] [ icon [] [ R.str "edit_icon" ]]
        button [
            ButtonProp.Variant ButtonVariant.ExtendedFab
            HTMLAttr.Class !!classes?button
        ] [ 
            icon [] [ R.str "navigation_icon" ]
            R.str "Extended"
        ]
        button [
            ButtonProp.Variant ButtonVariant.Fab
            HTMLAttr.Disabled true
            HTMLAttr.Class !!classes?button
        ] [ icon [] [ R.str "delete_icon" ]]
    ]

let buttonsWithStyles<'a> = withStyles (StyleType.Func styles) [] buttons

let view () =
    R.from buttonsWithStyles createEmpty []