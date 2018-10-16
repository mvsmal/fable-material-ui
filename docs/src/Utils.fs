module Utils

open Fable.Core
open Fable.Core.JsInterop
open Fable.MaterialUI.Themes
open Fable.Helpers.React.Props

let toObj list =
    keyValueList CaseRules.LowerFirst list

let classNames =
    List.choose (fun (txt,add) -> if add then Some txt else None)
    >> String.concat " "

let customCss name styles =
    CSSProp.Custom (name, styles |> toObj)

let customAttr name props =
    HTMLAttr.Custom (name, props |> toObj)