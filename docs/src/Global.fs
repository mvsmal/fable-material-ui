module Global

type Page =
    | Home
    | Installation
    | Usage
    | AppBar
    | Autocomplete
    | Avatars
    // TODO Add other demos

type NavItem = {
    Title : string
    Children : NavItem list
    Href : Page option
}

let toPath page =
    match page with
    | Home -> "/home"
    | Installation -> "/getting-started/installation"
    | Usage -> "/getting-started/usage"
    | AppBar -> "/demos/app-bar"
    | Autocomplete -> "/demos/autocomplete"
    | Avatars -> "/demos/avatars"
