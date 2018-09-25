module Demos.AppBar.SimpleAppBar

open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Helpers.MaterialUI
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

let styles : IStyles list =
    [ Styles.Root [ CSSProp.FlexGrow 1 ] ]

let appBar props =
    div [ Class !!props?classes?root ] [
        appBar [
            AppBarProp.Position AppBarPosition.Static
            MaterialProp.Color ComponentColor.Default
        ] [
            toolbar [] [
                typography [
                    TypographyProp.Variant TypographyVariant.Title
                    MaterialProp.Color ComponentColor.Inherit
                ] [ str "Photos" ]
            ]
        ]
    ]

let appBarWithStyles<'a> = withStyles (StyleType.Styles styles) [] appBar

let view () =
    from appBarWithStyles createEmpty []