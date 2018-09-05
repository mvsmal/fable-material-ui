module App.Types

open Global

type Msg =
    | Navigate of Page
    | ToggleMenu
    | ToggleMenuItem of string

type Model = {
    currentPage: Page
    isLanding: bool
    menuOpen: bool
    menuSections: Map<string, bool>
}
