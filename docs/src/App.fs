module App.View

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
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
open Elmish.React.Common

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

let menuButton model dispatch =
    let button = 
        Mui.iconButton [
            MProps.IconProp.Color MProps.IconColor.Inherit
            OnClick (fun _ -> ToggleMenu |> dispatch)
        ] [ Mui.icon [] [ str "menu" ] ]
    match model.isLanding with
    | false ->
        Mui.hidden [ MProps.LgUp true ] [
            button
        ]
    | _ -> button

let appBarStyles (theme : ITheme) : IStyles list =
    let lgBreakpoint = theme.breakpoints.up(MProps.MaterialSize.Lg |> U2.Case1)
    [
        Styles.Custom
            ("appBar", [
                CSSProp.Custom
                    (lgBreakpoint, [
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
            Mui.typography [
                MProps.TypographyProp.Variant MProps.TypographyVariant.Title
                MProps.MaterialProp.Color MProps.ComponentColor.Inherit
            ] [ model.currentPage |> toTitle |> str ]
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
let drawerMenu (props : Mui.IClassesProps) =
    let classes = props.classes :?> DrawerMenuClasses
    div [ Class classes.drawerRoot ] [
        Mui.toolbar [ Class classes.drawerToolbar ] [
            a [
                Class classes.title
                Href ("/" + toHash Home)
                OnClick (fun _ -> !!props?closeDrawer())
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
                    [ str "v1.2.1" ]
            ]
        ]
        Mui.divider []
        navigationMenu !!props?currentPage !!props?closeDrawer
    ]

let drawerStyles : IStyles list =
    [
        Styles.Root [
            Width 250
        ]
    ]
[<Pojo>]
type AppDrawerProps =
    abstract member isLanding: bool with get,set
    abstract member currentPage: Page with get,set
    abstract member classes: obj with get,set
    inherit Mui.IClassesProps

[<Pojo>]
type AppDrawerState = {
    opened: bool
}

let drawerWithStyles<'a> = Mui.withStyles (StyleType.Styles drawerStyles) []
type AppDrawer(p) as this =
    inherit PureComponent<AppDrawerProps, AppDrawerState>(p)
    do this.setInitState { opened = false }
    let closeDrawer = this.CloseDrawer
    let openDrawer = this.OpenDrawer

    member this.CloseDrawer(_) =
        this.setState { this.state with opened = false }
    
    member this.OpenDrawer(_) =
        this.setState { this.state with opened = true }

    override this.render() =
        let menuProps =
            createObj [
                "closeDrawer" ==> closeDrawer
                "currentPage" ==> this.props.currentPage ]
        let innerDrawer = from (drawerMenu |> drawerMenuWithStyles) !!menuProps []
        nav [] [
            Mui.hidden [
                MProps.LgUp (not this.props.isLanding)
                MProps.Implementation MProps.HiddenImplementation.Js
            ] [
                Mui.swipeableDrawer [
                    MProps.DrawerProp.Variant MProps.DrawerVariant.Temporary
                    MProps.MaterialProp.Open this.state.opened
                    MProps.MaterialProp.OnOpen openDrawer
                    MProps.MaterialProp.OnClose closeDrawer
                    HTMLAttr.Custom
                        ("ModalProps", [
                            MProps.KeepMounted true
                        ] |> toObj)
                ] [ innerDrawer ]
            ]
            (if this.props.isLanding then null else
                Mui.hidden [
                    MProps.MdDown true
                    MProps.Implementation MProps.HiddenImplementation.Js
                ] [
                    Mui.drawer [
                        MProps.DrawerProp.Variant MProps.DrawerVariant.Permanent
                        MProps.MaterialProp.Open true
                        Class !!this.props.classes?root
                    ] [ innerDrawer ]
                ])
        ]

let drawer props =  
    ofType<AppDrawer,_,_> props []

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

                CSSProp.FontFamily theme.typography.fontFamily
                CSSProp.FontSize 16
                CSSProp.Color theme.palette.text.primary
                CSSProp.Custom
                    ("& p, & ul, & ol", [
                        CSSProp.LineHeight 1.6
                        CSSProp.Custom
                            ("&.low", [
                                CSSProp.LineHeight 1
                                CSSProp.MarginTop ".5em"
                                CSSProp.MarginBottom ".5em"
                            ] |> toObj)
                    ] |> toObj)
                CSSProp.Custom
                    ("& pre", [
                        CSSProp.Margin "24px 0"
                        CSSProp.Padding "12px 18px"
                        CSSProp.BackgroundColor theme.palette.background.paper
                        CSSProp.BorderRadius theme.shape.borderRadius
                        CSSProp.Overflow "auto"
                        CSSProp.Width "100%"
                    ] |> toObj)
                CSSProp.Custom
                    ("& code:not([class*=language])", [
                        CSSProp.LineHeight 1.6
                        CSSProp.Color theme.palette.secondary.main
                        CSSProp.BackgroundColor theme.palette.background.paper
                        CSSProp.Display "inline-block"
                        CSSProp.FontFamily "Consolas, 'Liberation Mono', Menlo, Courier, monospace"
                        CSSProp.Padding "3px 6px"
                        CSSProp.FontSize 14
                    ] |> toObj)
                CSSProp.Custom
                    ("& a", [
                        CSSProp.Color theme.palette.secondary.main
                        CSSProp.TextDecoration "none"
                        CSSProp.Custom
                            ("&:hover", [
                                CSSProp.TextDecoration "underline"
                            ])
                    ] |> toObj)

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
    ]

let layoutWithStyles<'a> = Mui.withStyles (StyleType.Func layoutStyles) []
let layout (model : Model) dispatch props =
    let content = function
        | Page.Home -> Home.View.root dispatch
        | Page.Installation -> GettingStarted.Installation.View.root ()
        | Page.Usage -> GettingStarted.Usage.View.root ()
        | Page.AppBar -> AppBar.View.root ()
        | Page.Avatars -> Avatars.View.root ()

    let classes = props?classes
    let mainClasses =
        [
            (!!classes?main, true)
            (!!classes?landingMain, model.isLanding)
        ] |> classNames
    let drProps = createEmpty<AppDrawerProps>
    drProps.currentPage <- model.currentPage
    drProps.isLanding <- model.isLanding
    Mui.muiThemeProvider [MProps.MuiThemeProviderProp.Theme (MProps.ProviderTheme.Theme theme) ] [
        div [ Class !!classes?root ] [
            from (appBar model dispatch |> appBarWithStyles) createEmpty []
            from (drawer |> drawerWithStyles) drProps []
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
