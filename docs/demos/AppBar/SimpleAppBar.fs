module Demos.AppBar.SimpleAppBar

open Fable.Helpers.React
open Fable.Helpers.MaterialUI
open Fable.MaterialUI.Props

let view =
    div [] [
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