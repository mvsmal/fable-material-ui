module Global

let [<Literal>] libVersion = "v2.0.0"

type Page =
    | Home
    | Installation
    | Usage
    | MigrationToV2
    | AppBar
    | Avatars
    | Buttons
    | SignIn
    // TODO Add other demos

type NavItem = {
    Title : string
    Children : NavItem list
    Href : Page option
}

let toHash page =
    match page with
    | Home -> "#/home"
    | Installation -> "#/getting-started/installation"
    | Usage -> "#/getting-started/usage"
    | MigrationToV2 -> "#/getting-started/migration-to-v2"
    | AppBar -> "#/demos/app-bar"
    | Avatars -> "#/demos/avatars"
    | Buttons -> "#/demos/buttons"
    | SignIn -> "#/pagelayout/signin"

let toTitle = function
    | Home -> ""
    | Installation -> "Installation"
    | Usage -> "Usage"
    | MigrationToV2 -> "Migration to version 2"
    | AppBar -> "App Bar"
    | Avatars -> "Avatars"
    | Buttons -> "Buttons"
    | SignIn -> "Sign-in"
