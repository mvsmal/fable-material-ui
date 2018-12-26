module Demos.Buttons.FloatingActionButtons

open Fable.Core.JsInterop
open Fable.Helpers.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Props
module R = Fable.Helpers.React

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Button [ CSSProp.Margin theme.spacing.unit ]
        Styles.Custom ("extendedIcon", [ CSSProp.MarginRight theme.spacing.unit ])
    ]

let fabs (props : IClassesProps) =
    let classes = props?classes
    R.div [] [
        fab [
            MaterialProp.Color ComponentColor.Primary
            HTMLAttr.Class !!classes?button
        ] [ icon [] [ R.str "add_icon" ]]
        fab [
            MaterialProp.Color ComponentColor.Secondary
            HTMLAttr.Class !!classes?button
        ] [ icon [] [ R.str "edit_icon" ]]
        fab [
            FabProp.Variant FabVariant.Extended
            HTMLAttr.Class !!classes?button
        ] [ 
            icon [] [ R.str "navigation_icon" ]
            R.str "Extended"
        ]
        fab [
            HTMLAttr.Disabled true
            HTMLAttr.Class !!classes?button
        ] [ icon [] [ R.str "delete_icon" ]]
    ]

let fabsWithStyles = withStyles<IClassesProps> (StyleType.Func styles) [] fabs

let view () =
    R.from fabsWithStyles createEmpty []