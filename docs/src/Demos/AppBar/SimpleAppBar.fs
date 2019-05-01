module Demos.AppBar.SimpleAppBar

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

let styles : IStyles list =
    [ Styles.Root [ CSSProp.FlexGrow 1 ] ]

let appBar (props : IClassesProps) =
    div [ Class !!props.classes?root ] [
        appBar [
            AppBarProp.Position AppBarPosition.Static
            MaterialProp.Color ComponentColor.Default
        ] [
            toolbar [] [
                typography [
                    TypographyProp.Variant TypographyVariant.H6
                    MaterialProp.Color ComponentColor.Inherit
                ] [ str "Photos" ]
            ]
        ]
    ]

let appBarWithStyles = withStyles<IClassesProps> (StyleType.Styles styles) [] appBar

let view () =
    ReactElementType.create appBarWithStyles createEmpty []