module Demos.Buttons.FloatingActionButtons

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Props

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Button [ CSSProp.Margin theme.spacing.unit ]
        Styles.Custom ("extendedIcon", [ CSSProp.MarginRight theme.spacing.unit ])
    ]

let fabs (props : IClassesProps) =
    let classes = props?classes
    div [] [
        fab [
            MaterialProp.Color ComponentColor.Primary
            HTMLAttr.Class !!classes?button
        ] [ icon [] [ str "add_icon" ]]
        fab [
            MaterialProp.Color ComponentColor.Secondary
            HTMLAttr.Class !!classes?button
        ] [ icon [] [ str "edit_icon" ]]
        fab [
            FabProp.Variant FabVariant.Extended
            HTMLAttr.Class !!classes?button
        ] [ 
            icon [] [ str "navigation_icon" ]
            str "Extended"
        ]
        fab [
            HTMLAttr.Disabled true
            HTMLAttr.Class !!classes?button
        ] [ icon [] [ str "delete_icon" ]]
    ]

let fabsWithStyles = withStyles<IClassesProps> (StyleType.Func styles) [] fabs

let view () =
    ReactElementType.create fabsWithStyles createEmpty []