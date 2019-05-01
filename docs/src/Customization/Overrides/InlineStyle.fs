module Customization.Overrides.InlineStyle

open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core

// We can use inline style
let style = [
    CSSProp.Background "linear-gradient(45deg, #FE6B8B 30%, #FF8E53 90%)"
    CSSProp.BorderRadius 3
    CSSProp.Border 0
    CSSProp.Color "white"
    CSSProp.Height 48
    CSSProp.Padding "0 30px"
    CSSProp.BoxShadow "0 3px 5px 2px rgba(255, 105, 135, .3)"
]

let view () =
    button [ Style style ] [ str "inline-style" ]