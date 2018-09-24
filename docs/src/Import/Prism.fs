module Import.Prism

open Fable.Core.JsInterop

type Prism =
    abstract highlight: text: string * grammar: obj -> string
    abstract member languages: obj

let prism : Prism = importDefault "prismjs"
