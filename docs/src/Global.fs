module Global

let [<Literal>] libVersion = "v4.1.0"

type StaticPage =
    | Installation
    | Usage
    | MigrationToV2
    | MigrationToV3
    | MigrationToV4
    | DefaultTheme

type Page =
    | Home
    | AppBar
    | Avatars
    | Buttons
    | Popper
    | TextFields
    | SignIn
    | Overrides
    | Themes
    | CssInJs
    | Api of string
    | StaticPage of StaticPage
    // TODO Add other demos

type NavItem = {
    Title : string
    Children : NavItem list
    Href : Page option
}

let toHash page =
    match page with
    | Home -> "#/home"    
    | AppBar -> "#/demos/app-bar"
    | Avatars -> "#/demos/avatars"
    | Buttons -> "#/demos/buttons"
    | Popper -> "#/demos/popper"
    | TextFields -> "#/demos/text-fields"
    | SignIn -> "#/pagelayout/signin"
    | Overrides -> "#/customization/overrides"
    | Themes -> "#/customization/themes"
    | CssInJs -> "#/customization/css-in-js"
    | Api comp -> "#/api/" + comp
    | StaticPage page ->
        match page with
        | Installation -> "#/getting-started/installation"
        | Usage -> "#/getting-started/usage"
        | MigrationToV2 -> "#/getting-started/migration-to-v2"
        | MigrationToV3 -> "#/getting-started/migration-to-v3"
        | MigrationToV4 -> "#/getting-started/migration-to-v4"
        | DefaultTheme -> "#/customization/default-theme"


let toCamelCase (s : string) =
    s |> String.mapi (fun i c ->
        if i = 0 || s.[i - 1] = '-' then System.Char.ToUpper c
        else c)


let toTitle = function
            | Home -> ""
            | AppBar -> "App Bar"
            | Avatars -> "Avatars"
            | Buttons -> "Buttons"
            | Popper -> "Popper"
            | TextFields -> "Text Fields"
            | SignIn -> "Sign-in"
            | Overrides -> "Overrides"
            | Themes -> "Themes"
            | CssInJs -> "Css in JS (F#)"
            | Api comp -> (toCamelCase comp).Replace("-", "")
            | StaticPage page ->
                match page with
                | Installation -> "Installation"
                | Usage -> "Usage"
                | MigrationToV2 -> "Migration to version 2"
                | MigrationToV3 -> "Migration to version 3"
                | MigrationToV4 -> "Migration to version 4"
                | DefaultTheme -> "Default Theme"
