module Demos.AppBar.AppBarWithButtons

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Helpers.MaterialUI
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
module Mui = Fable.Helpers.MaterialUI

let toObj = keyValueList CaseRules.LowerFirst

let styles : IStyles list =
    [
        Styles.Root [
            FlexGrow 1
        ]
        Styles.Custom
            ("flex", [
                FlexGrow 1
            ] |> toObj)
        Styles.Custom
            ("menuButton", [
                CSSProp.MarginLeft -12
                CSSProp.MarginRight 20
            ] |> toObj)
    ]

let appBar props =
    let classes = props?classes
    div [ Class !!classes?root ] [
        appBar [
            AppBarProp.Position AppBarPosition.Static
        ] [
            toolbar [] [
                iconButton [
                    Class !!classes?menuButton
                    MaterialProp.Color ComponentColor.Inherit
                    HTMLAttr.Custom ("aria-label", "Menu")
                ] [ icon [] [ str "menu" ] ]
                typography [
                    Class !!classes?flex
                    TypographyProp.Variant TypographyVariant.Title
                    MaterialProp.Color ComponentColor.Inherit
                ] [ str "News" ]
                button [
                    MaterialProp.Color ComponentColor.Inherit
                ] [ str "Login" ]
            ]
        ]
    ]

let appBarWithStyles<'a> = Mui.withStyles (StyleType.Styles styles) [] appBar

let view () =
    from appBarWithStyles createEmpty []