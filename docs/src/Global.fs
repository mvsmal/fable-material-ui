module Global

let [<Literal>] libVersion = "v2.1.1"

type Page =
    | Home
    | Installation
    | Usage
    | MigrationToV2
    | AppBar
    | Avatars
    | Buttons
    | TextFields
    | SignIn
    | Overrides
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
    | TextFields -> "#/demos/text-fields"
    | SignIn -> "#/pagelayout/signin"
    | Overrides -> "#/customization/overrides"

let toTitle = function
    | Home -> ""
    | Installation -> "Installation"
    | Usage -> "Usage"
    | MigrationToV2 -> "Migration to version 2"
    | AppBar -> "App Bar"
    | Avatars -> "Avatars"
    | Buttons -> "Buttons"
    | TextFields -> "Text Fields"
    | SignIn -> "Sign-in"
    | Overrides -> "Overrides"
