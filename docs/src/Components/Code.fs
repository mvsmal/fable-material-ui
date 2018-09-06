module Components.Code

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props

type Prism =
    abstract highlight: text: string * grammar: obj -> string
    abstract member languages: obj

let prism : Prism = importDefault "prismjs"

let code text lang =
    let markedCode = prism.highlight (text, prism.languages?(lang))
    div [ Class "code-block"] [
        pre [] [
            code [
                Class ("language-" + lang)
                DangerouslySetInnerHTML { __html = markedCode } ] []
        ]
    ]
