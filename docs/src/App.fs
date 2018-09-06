module App.View

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Core
open Fable.Core.JsInterop
open Types
open App.State
open Global

importAll "../sass/main.sass"

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React

open Fable.MaterialUI.Themes
open Fable.MaterialUI.Props
open Demos
open Utils
open App.Navigation

module Mui = Fable.Helpers.MaterialUI
module MProps = Fable.MaterialUI.Props
module MColors = Fable.MaterialUI.Colors

let theme =
    Mui.createMuiTheme [
        MProps.ThemeProp.Palette [
            MProps.PaletteProp.Type PaletteType.Light
            MProps.PaletteProp.Primary [
                MProps.PaletteIntentionProp.Main MColors.blue.``500``
            ]
            MProps.PaletteProp.Secondary [
                MProps.PaletteIntentionProp.Main
                    (Mui.ColorManipulator.darken (MColors.pink.A400, 0.08))
            ]
        ]
    ]

let githubIcon =
    Mui.svgIcon [] [
        path [
            SVGAttr.D "M12 .3a12 12 0 0 0-3.8 23.4c.6.1.8-.3.8-.6v-2c-3.3.7-4-1.6-4-1.6-.6-1.4-1.4-1.8-1.4-1.8-1-.7.1-.7.1-.7 1.2 0 1.9 1.2 1.9 1.2 1 1.8 2.8 1.3 3.5 1 0-.8.4-1.3.7-1.6-2.7-.3-5.5-1.3-5.5-6 0-1.2.5-2.3 1.3-3.1-.2-.4-.6-1.6 0-3.2 0 0 1-.3 3.4 1.2a11.5 11.5 0 0 1 6 0c2.3-1.5 3.3-1.2 3.3-1.2.6 1.6.2 2.8 0 3.2.9.8 1.3 1.9 1.3 3.2 0 4.6-2.8 5.6-5.5 5.9.5.4.9 1 .9 2.2v3.3c0 .3.1.7.8.6A12 12 0 0 0 12 .3"
        ] []
    ]

[<Pojo>]
type DrawerMenuClasses =
    abstract member drawerRoot: string
    abstract member drawerToolbar: string
    abstract member headerLink: string
    abstract member title: string
    inherit Mui.IClasses

let drawerMenuStyles (theme : ITheme) : IStyles list =
    [
        Styles.Title [
            CSSProp.Color theme.palette.text.secondary
            CSSProp.MarginBottom (theme.spacing.unit / 2)
        ]
        Styles.Custom
            ("drawerRoot", [
                Width 250
            ] |> toObj)
        Styles.Custom
            ("drawerToolbar", [
                Display "flex"
                FlexDirection "column"
                JustifyContent "center"
                CSSProp.AlignItems "flex-start"
            ] |> toObj)
        Styles.Custom
            ("headerLink", [
                CSSProp.Transition "color .2s ease-in-out"
                CSSProp.Custom
                    ("&:hover", [
                        CSSProp.Color theme.palette.primary.main
                        TextDecoration "underline"
                    ] |> toObj)
            ] |> toObj)
    ]
let drawerMenuWithStyles<'a> = Mui.withStyles (StyleType.Func drawerMenuStyles) []
let drawerMenu model dispatch (props : Mui.IClassesProps) =
    let classes = props.classes :?> DrawerMenuClasses
    nav [ Class classes.drawerRoot ] [
        Mui.toolbar [ Class classes.drawerToolbar ] [
            a [
                Class classes.title
                Href ""
                OnClick (fun e -> e.preventDefault(); Navigate Home |> dispatch)
            ] [
                Mui.typography
                    [ MProps.TypographyProp.Variant MProps.TypographyVariant.Title
                      Class classes.headerLink
                      MProps.TypographyProp.Color MProps.TypographyColor.Inherit ]
                    [ str "Fable Material-UI" ]
            ]
            a [
                Target "_blank"
                Rel "noopener noreferrer"
                Href "https://github.com/mvsmal/fable-material-ui/releases"
            ] [
                Mui.typography
                    [ MProps.TypographyProp.Variant MProps.TypographyVariant.Caption
                      Class classes.headerLink ]
                    [ str "v1.2.0" ]
            ]
        ]
        Mui.divider []
        navigationMenu model dispatch
    ]

let menuButton model dispatch =
    match model.isLanding with
    | false -> null
    | _ ->
        Mui.iconButton [
            MProps.IconProp.Color MProps.IconColor.Inherit
            OnClick (fun _ -> ToggleMenu |> dispatch)
        ] [ Mui.icon [] [ str "menu" ] ]

let appBarStyles (theme : ITheme) : IStyles list =
    let mdBreakpoint = theme.breakpoints.up(MProps.MaterialSize.Md |> U2.Case1)
    [
        Styles.Custom
            ("appBar", [
                CSSProp.Custom
                    (mdBreakpoint, [
                        Left 250
                        Width "calc(100% - 250px)"
                     ] |> toObj)
            ] |> toObj)
        Styles.Custom
            ("landingAppBar", [
                Left 0
                Width "100vw"
                BoxShadow "unset"
            ] |> toObj)
    ]
let appBarWithStyles<'a> = Mui.withStyles (StyleType.Func appBarStyles) []
let appBar model dispatch props =
    let classes = props?classes
    Mui.appBar [
        MProps.Position MProps.AppBarPosition.Fixed
        Class (classNames [(!!classes?appBar, true); (!!classes?landingAppBar, model.isLanding)])
    ] [
        Mui.toolbar [] [
            menuButton model dispatch
            div [ Class "flex" ] []
            Mui.tooltip [
                MProps.TooltipProp.Title ((str "Github") |> U2.Case1 |> U3.Case1)
                MProps.TooltipProp.EnterDelay 300
            ] [
                Mui.iconButton [
                    MProps.IconProp.Color MProps.IconColor.Inherit
                    MProps.MaterialProp.Component ("a" |> U3.Case1)
                    Target "_blank"
                    Href "https://github.com/mvsmal/fable-material-ui"
                ] [ githubIcon ]
            ]
        ]
    ]

let drawerStyles : IStyles list =
    [
        Styles.Root [
            Width 250
        ]
    ]

let drawerWithStyles<'a> = Mui.withStyles (StyleType.Styles drawerStyles) []

let drawer model dispatch props =
    Mui.drawer [
        MProps.DrawerProp.Variant
            (if model.isLanding then MProps.DrawerVariant.Temporary else MProps.DrawerVariant.Permanent)
        MProps.MaterialProp.Open model.menuOpen
        MProps.MaterialProp.OnClose (fun _ -> ToggleMenu |> dispatch)
        Class !!props?classes?root
    ] [
        from (drawerMenu model dispatch |> drawerMenuWithStyles) createEmpty []
    ]

let layoutStyles (theme : ITheme) : IStyles list=
    let lgBreakpoint = theme.breakpoints.up(MProps.MaterialSize.Lg |> U2.Case1)
    let smBreakpoint = theme.breakpoints.up(MProps.MaterialSize.Sm |> U2.Case1)
    [
        Styles.Root [
            Display "flex"
        ]
        Styles.Custom
            ("menuButton", [
                MarginLeft -12
                MarginRight 20
            ] |> toObj)
        Styles.Custom
            ("main", [
                PaddingTop 80
                Flex "1 1 100%"
                CSSProp.MaxWidth "100%"
                CSSProp.Margin "0 auto"
                CSSProp.PaddingLeft (theme.spacing.unit * 2)
                CSSProp.PaddingRight (theme.spacing.unit * 2)
                CSSProp.Custom
                    (smBreakpoint, [
                        PaddingLeft (theme.spacing.unit * 4)
                        PaddingRight (theme.spacing.unit * 4)
                    ] |> toObj)
                CSSProp.Custom
                    (lgBreakpoint, [
                        PaddingLeft (theme.spacing.unit * 5)
                        PaddingRight (theme.spacing.unit * 9)
                        CSSProp.MaxWidth "calc(100% - 250px)"
                    ] |> toObj)
            ] |> toObj)
        Styles.Custom
            ("landingMain", [
                CSSProp.Padding 0
                CSSProp.MaxWidth "100vw"
                MarginLeft 0
            ] |> toObj)
        Styles.Content [
            CSSProp.Custom
                (lgBreakpoint, [
                    CSSProp.MaxWidth 960
                    CSSProp.Margin "0 auto"
                ] |> toObj)
        ]
    ]
let layoutWithStyles<'a> = Mui.withStyles (StyleType.Func layoutStyles) []
let layout (model : Model) dispatch props =
    let content = function
        | Page.Home -> Home.View.root model dispatch
        | Page.Installation -> GettingStarted.Installation.View.root model dispatch
        | Page.AppBar -> AppBar.View.root model dispatch
        | Page.Autocomplete -> Autocomplete.View.root model dispatch
        | Page.Avatars -> Avatars.View.root model dispatch
        | Page.Usage -> GettingStarted.Usage.View.root model dispatch

    let classes = props?classes
    let mainClasses =
        [
            (!!classes?main, true)
            (!!classes?landingMain, model.isLanding)
        ] |> classNames
    let contentClasses =
        [
            (!!classes?content, true)
            (!!classes?landingMain, model.isLanding)
        ] |> classNames
    Mui.muiThemeProvider [MProps.MuiThemeProviderProp.Theme (MProps.ProviderTheme.Theme theme) ] [
        div [ Class !!classes?root ] [
            from (appBar model dispatch |> appBarWithStyles) createEmpty []
            from (drawer model dispatch |> drawerWithStyles) createEmpty []
            main [ Class mainClasses ] [ content model.currentPage ]
        ]
    ]

let root (model: Model) dispatch : ReactElement =
    from (layout model dispatch |> layoutWithStyles) createEmpty []

open Elmish.React
open Elmish.Debug
open Elmish.HMR

// App
Program.mkProgram init update root
|> Program.toNavigable (parseHash pageParser) urlUpdate
#if DEBUG
|> Program.withDebugger
|> Program.withHMR
#endif
|> Program.withReact "app"
|> Program.run
