module Components.Code

open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props

open Import.Prism


let code (text : string) (lang : string) =
    let markedCode = prism.highlight (text, prism.languages?(lang))
    div [ Class "code-block"] [
        pre [] [
            code [
                Class ("language-" + lang)
                DangerouslySetInnerHTML { __html = markedCode } ] []
        ]
    ]
