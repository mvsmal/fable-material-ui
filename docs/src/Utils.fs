module Utils

open Fable.Core
open Fable.Core.JsInterop

let toObj list =
    keyValueList CaseRules.LowerFirst list

let classNames =
    List.choose (fun (txt,add) -> if add then Some txt else None)
    >> String.concat " "
