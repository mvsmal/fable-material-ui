module Global

let [<Literal>] libVersion = "v3.1.0"

type Page =
    | Home
    | Installation
    | Usage
    | MigrationToV2
    | MigrationToV3
    | AppBar
    | Avatars
    | Buttons
    | Popper
    | TextFields
    | SignIn
    | Overrides
    | Themes
    | CssInJs
    | DefaultTheme
    | Api of string
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
    | MigrationToV3 -> "#/getting-started/migration-to-v3"
    | AppBar -> "#/demos/app-bar"
    | Avatars -> "#/demos/avatars"
    | Buttons -> "#/demos/buttons"
    | Popper -> "#/demos/popper"
    | TextFields -> "#/demos/text-fields"
    | SignIn -> "#/pagelayout/signin"
    | Overrides -> "#/customization/overrides"
    | Themes -> "#/customization/themes"
    | CssInJs -> "#/customization/css-in-js"
    | DefaultTheme -> "#/customization/default-theme"
    | Api comp -> "#/api/" + comp

let toCamelCase (s : string) =
    s |> String.mapi (fun i c ->
        if i = 0 || s.[i - 1] = '-' then System.Char.ToUpper c
        else c)


let toTitle = function
            | Home -> ""
            | Installation -> "Installation"
            | Usage -> "Usage"
            | MigrationToV2 -> "Migration to version 2"
            | MigrationToV3 -> "Migration to version 3"
            | AppBar -> "App Bar"
            | Avatars -> "Avatars"
            | Buttons -> "Buttons"
            | Popper -> "Popper"
            | TextFields -> "Text Fields"
            | SignIn -> "Sign-in"
            | Overrides -> "Overrides"
            | Themes -> "Themes"
            | CssInJs -> "Css in JS (F#)"
            | DefaultTheme -> "Default Theme"
            | Api comp -> (toCamelCase comp).Replace("-", "")
