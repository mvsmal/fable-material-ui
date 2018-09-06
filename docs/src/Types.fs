module App.Types

open Global

type Msg =
    | Navigate of Page
    | ToggleMenu

type Model = {
    currentPage: Page
    isLanding: bool
    menuOpen: bool
}
