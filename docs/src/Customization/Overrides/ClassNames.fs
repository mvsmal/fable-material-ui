module Customization.Overrides.ClassNames

open Fable.Core.JsInterop
open Fable.Import.React
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Helpers.MaterialUI
open Fable.MaterialUI.Themes

// We can inject some CSS into the DOM
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
]

type ClassNamesProps =
    abstract className : string with get,set
    abstract children : ReactElement list with get,set
    inherit IClassesProps

let classNames (props : ClassNamesProps) =
    button
        [ classList [ !!props.classes?root, true
                      props.className,      true ] ]
        props.children

let withStyles = withStyles<ClassNamesProps> (StyleType.Styles styles) [] classNames

let view () =
    from withStyles createEmpty [ str "class names" ]