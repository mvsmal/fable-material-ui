module Customization.CssInJs.Example

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import.React
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Helpers.MaterialUI
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

// 1. We define the styles
let styles (theme : ITheme) : IStyles list = [
    Styles.Root [
        CSSProp.Color "inherit"
        CSSProp.TextDecoration "inherit"
        CSSProp.Custom ("&:hover", [
            CSSProp.TextDecoration "underline"
        ] |> keyValueList CaseRules.LowerFirst)
    ]
    Styles.Primary [
        CSSProp.Color theme.palette.primary.main
    ]
]
[<StringEnum; RequireQualifiedAccess>]
type MyLinkVariant = | Primary

type MyLinkProps =
    abstract children : ReactElement list with get,set
    abstract variant : MyLinkVariant with get,set
    abstract className : string with get,set
    abstract href : string with get,set
    inherit IClassesProps

let myLink (props : MyLinkProps) =
    a [
        classList [!!props.classes?root, true
                   !!props.classes?primary, props.variant = MyLinkVariant.Primary
                   props.className, true]
        Href props.href
    ] props.children

let myLinkStyled = withStyles<MyLinkProps> (StyleType.Func styles) [] myLink

let view () =
    let props1 = createEmpty<MyLinkProps>
    props1.href <- "#/customization/css-in-js"

    let props2 = createEmpty<MyLinkProps>
    props2.href <- "#/customization/css-in-js"
    props2.variant <- MyLinkVariant.Primary

    typography [ TypographyProp.Variant TypographyVariant.Subtitle1 ] [
        from myLinkStyled props1 [ str "MyLink" ]
        str " - "
        from myLinkStyled props2 [ str "primary" ]
    ]