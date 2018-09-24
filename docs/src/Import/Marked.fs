module Import.Marked
open Fable.Core

type MarkedOptions =
    abstract member baseUrl : string with get,set
    abstract member breaks : bool with get,set
    abstract member gfm : bool with get,set
    abstract member headerIds : bool with get,set
    abstract member highlight : (string->string->string) with get,set
    abstract member langPrefix : string with get,set
    abstract member mangle : bool with get,set
    abstract member pedantic : bool with get,set
    abstract member renderer : obj with get,set
    abstract member sanitize : bool with get,set
    abstract member santitizer : (string->string) with get,set
    abstract member silent : bool with get,set
    abstract member smartLists : bool with get,set
    abstract member smartypants : bool with get,set
    abstract member tables : bool with get,set
    abstract member xhtml : bool with get,set

type [<AbstractClass>] Marked =
    [<Import("default", "marked")>]
    static member marked ((markdownString : string), (?options : MarkedOptions), (?callback : (string->obj->unit))) : string =
        jsNative


