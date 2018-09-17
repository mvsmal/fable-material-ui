module GettingStarted.Usage.View
open Fable.Helpers.React
open Fable.Helpers.React.Props
module R = Fable.Helpers.React
open Components.Typography
open Components.Code

let root () =
    div [] [
        title "Usage"
        description "How to use the bindings"
        p [] [
            str "Simply open Fable.Helpers.MaterialUI and Props module"
        ]
        code "open Fable.Helpers.MaterialUI\nopen Fable.MaterialUI.Props" "fsharp"
        p [] [
            str "There are several components, such as "
            R.code [] [ str "button" ]
            str ", which are also present in "
            R.code [] [ str "Fable.Helpers.React" ]
            str ". To avoid conflicts you can assign module names:"
            code "module R = Fable.Helpers.React\nmodule Mui = Fable.Helpers.MaterialUI" "fsharp"
        ]

        display1 "Minimal example"
        code "module R = Fable.Helpers.React
module Mui = Fable.Helpers.MaterialUI
open Fable.MaterialUI.Props

let view =
    Mui.button [
        ButtonProp.Variant ButtonVariant.Contained
    ] [ R.str \"Hello world!\" ]" "fsharp"
    ]
