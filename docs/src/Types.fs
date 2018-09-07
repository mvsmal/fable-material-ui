module App.Types

open Global

type Msg =
    | Navigate of Page
    | ToggleMenu
    | OpenMenu of bool

type Model = {
    currentPage: Page
    isLanding: bool
    menuOpen: bool
}
