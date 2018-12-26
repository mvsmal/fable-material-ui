module App.Types

open Fable.MaterialUI.Core
open Global

type Msg =
    | OpenMenu of bool

type Model = {
    currentPage: Page
    isLanding: bool
    menuOpen: bool
}


type AppProps =
    abstract member model : Model with get,set
    abstract member dispatch : (Msg->unit) with get,set
    inherit IClassesProps
