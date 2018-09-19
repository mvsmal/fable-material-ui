module App.Types

open Global

type Msg =
    | ToggleMenu
    | OpenMenu of bool

type Model = {
    currentPage: Page
    isLanding: bool
    menuOpen: bool
}
