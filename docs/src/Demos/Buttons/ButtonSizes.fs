module Demos.Buttons.ButtonSizes

open Fable.Core.JsInterop
open Fable.Helpers.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Props
module R = Fable.Helpers.React

let styles (theme : ITheme) : IStyles list =
    [ Styles.Button [ CSSProp.Margin theme.spacing.unit ] ]

let buttons props =
    let classes = props?classes
    R.div [] [
        R.div [] [
            button [
                ButtonProp.Size ButtonSize.Small
                HTMLAttr.Class !!classes?button
            ] [ R.str "Small" ]
            button [
                ButtonProp.Size ButtonSize.Medium
                HTMLAttr.Class !!classes?button
            ] [ R.str "Medium" ]
            button [
                ButtonProp.Size ButtonSize.Large
                HTMLAttr.Class !!classes?button
            ] [ R.str "Large" ]
        ]
        R.div [] [
            button [
                ButtonProp.Size ButtonSize.Small
                ButtonProp.Variant ButtonVariant.Outlined
                MaterialProp.Color ComponentColor.Primary
                HTMLAttr.Class !!classes?button
            ] [ R.str "Small" ]
            button [
                ButtonProp.Size ButtonSize.Medium
                ButtonProp.Variant ButtonVariant.Outlined
                MaterialProp.Color ComponentColor.Primary
                HTMLAttr.Class !!classes?button
            ] [ R.str "Medium" ]
            button [
                ButtonProp.Size ButtonSize.Large
                ButtonProp.Variant ButtonVariant.Outlined
                MaterialProp.Color ComponentColor.Primary
                HTMLAttr.Class !!classes?button
            ] [ R.str "Large" ]
        ]
        R.div [] [
            button [
                ButtonProp.Size ButtonSize.Small
                ButtonProp.Variant ButtonVariant.Contained
                MaterialProp.Color ComponentColor.Primary
                HTMLAttr.Class !!classes?button
            ] [ R.str "Small" ]
            button [
                ButtonProp.Size ButtonSize.Medium
                ButtonProp.Variant ButtonVariant.Contained
                MaterialProp.Color ComponentColor.Primary
                HTMLAttr.Class !!classes?button
            ] [ R.str "Medium" ]
            button [
                ButtonProp.Size ButtonSize.Large
                ButtonProp.Variant ButtonVariant.Contained
                MaterialProp.Color ComponentColor.Primary
                HTMLAttr.Class !!classes?button
            ] [ R.str "Large" ]
        ]
        R.div [] [
            fab [
                FabProp.Size FabSize.Small
                MaterialProp.Color ComponentColor.Secondary
                HTMLAttr.Class !!classes?button
                HTMLAttr.Custom ("aria-label", "Add")
            ] [ icon [] [ R.str "add_icon" ]]
            fab [
                FabProp.Size FabSize.Medium
                MaterialProp.Color ComponentColor.Secondary
                HTMLAttr.Class !!classes?button
                HTMLAttr.Custom ("aria-label", "Add")
            ] [ icon [] [ R.str "add_icon" ]]
            fab [
                FabProp.Size FabSize.Large
                MaterialProp.Color ComponentColor.Secondary
                HTMLAttr.Class !!classes?button
                HTMLAttr.Custom ("aria-label", "Add")
            ] [ icon [] [ R.str "add_icon" ]]
        ]
    ]

let buttonsWithStyles<'a> = withStyles (StyleType.Func styles) [] buttons

let view () =
    R.from buttonsWithStyles createEmpty []
