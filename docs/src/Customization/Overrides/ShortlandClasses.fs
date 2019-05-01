module Customization.Overrides.ShortlandClasses

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Themes

let styles : IStyles list = [
    Styles.Root [
        CSSProp.Background "linear-gradient(45deg, #FE6B8B 30%, #FF8E53 90%)"
        CSSProp.BorderRadius 3
        CSSProp.Border 0
        CSSProp.Color "white"
        CSSProp.Height 48
        CSSProp.Padding "0 30px"
        CSSProp.BoxShadow "0 3px 5px 2px rgba(255, 105, 135, .3)"
    ]
    Styles.Label [
        CSSProp.TextTransform "capitalize"
    ]
]

let Button : obj = importDefault "@material-ui/core/Button"
let styledButton = withStyles (StyleType.Styles styles) [] !!Button

let view () =
    ReactElementType.create styledButton createEmpty<IClassesProps> [ str "Classes Shortland" ]
