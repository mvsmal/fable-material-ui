module Customization.Overrides.InternalState

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
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

        // $disabled is a reference to the local disabled
        // rule within the same style sheet
        // By using &, we increase the specificity
        CSSProp.Custom ("&$disabled", [
            CSSProp.Background "rgba(0,0,0,0.12)"
            CSSProp.Color "white"
            CSSProp.BoxShadow "none"
        ] |> keyValueList CaseRules.LowerFirst)
    ]
    Styles.Disabled []
]

let classNesting (props : IClassesProps) =
    button [
        HTMLAttr.Disabled true
        MaterialProp.Classes [
            ClassNames.Root !!props.classes?root // class name, e.g. `classes-state-root-x`
            ClassNames.Disabled !!props.classes?disabled // class name, e.g. `classes-state-disabled-x`
        ]
    ] [ str "classes state" ]

let withStyles = withStyles (StyleType.Styles styles) [] classNesting

let view () =
    from withStyles createEmpty<IClassesProps> []

