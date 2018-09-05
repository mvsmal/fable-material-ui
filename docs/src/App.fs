module App.View

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.Browser
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
module Mui = Fable.Helpers.MaterialUI
module MProps = Fable.MaterialUI.Props
module MColors = Fable.MaterialUI.Colors

let toObj list =
    keyValueList CaseRules.LowerFirst list

let classNames =
    List.choose (fun (txt,add) -> if add then Some txt else None)
    >> String.concat " "

let theme =
    Mui.createMuiTheme [
        MProps.ThemeProp.Palette [
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

let navItems = [
    {
        Title = "Getting Started"
        Href = None
        Children =
            [
                { Title = "Installation"; Href = Some Page.Installation; Children = [] }
                { Title = "Usage"; Href = Some Page.Usage; Children = [] }
            ]
    }
    {
        Title = "Component demos"
        Href = None
        Children =
            [
                { Title = "App Bar"; Href = Some Page.AppBar; Children = [] }
                { Title = "Autocomplete"; Href = Some Page.Autocomplete; Children = [] }
                { Title = "Avatars"; Href = Some Page.Avatars; Children = [] }
            ]
    }
]

let navItemStyles (theme: ITheme) : IStyles list =
    [
        Styles.Custom
            ("listItem", [
                CSSProp.Display "block"
                PaddingTop 0
                PaddingBottom 0
            ] |> toObj)
        Styles.Custom
            ("bold", [
                CSSProp.FontWeight 500
            ] |> toObj)
        Styles.Button [
            JustifyContent "flex-start"
            CSSProp.TextTransform "none"
            CSSProp.Width "100%"
            CSSProp.FontSize theme.typography.body1.fontSize
            CSSProp.FontWeight theme.typography.body1.fontWeight
            CSSProp.FontFamily theme.typography.body1.fontFamily
            CSSProp.LineHeight theme.typography.body1.lineHeight
            CSSProp.Color theme.typography.body1.color
        ]
        Styles.Selected [
            CSSProp.Color theme.palette.primary.main
            CSSProp.FontWeight 500
        ]
        Styles.Custom
            ("collapse", [
                CSSProp.Padding 0
                CSSProp.Margin 0
            ] |> toObj)
    ]


let navItemWithStyles<'a> = Mui.withStyles (StyleType.Func navItemStyles) []

let navItem title depth href opened childItems model dispatch props =
    let style =
        [
            CSSProp.PaddingLeft ((depth + 1) * 16)
            CSSProp.FontWeight (if depth = 0 then 500 else 400)
        ]
    match href with
    | Some page ->
        Mui.listItem [
            MProps.DisableGutters true
            Class !!props?classes?listItem
        ] [
            Mui.button [
                MProps.DisableRipple true
                MProps.Component ("a" |> U3.Case1)
                Style style
                Class ([(!!props?classes?selected, model.currentPage = page)] |> classNames)
                MProps.Classes [ ClassNames.Root !!props?classes?button ]
                OnClick (fun _ -> Navigate page |> dispatch)
            ] [ str title ]
        ]
    | None ->
        Mui.listItem [
            MProps.DisableGutters true
            Class !!props?classes?listItem
        ] [
            Mui.button [
                OnClick (fun _ -> ToggleMenuItem title |> dispatch)
                Style style
                MProps.Classes [ ClassNames.Root !!props?classes?button ]
            ] [ str title ]
            Mui.collapse [
                MProps.In
                    (match model.menuSections.TryFind title with
                    | Some o -> o
                    | None -> false)
                HTMLAttr.Custom ("unmountOnExit", true)
                MProps.Component ("ul" |> U3.Case1)
                Class !!props?classes?collapse
            ] childItems
        ]

let rec mapNavigation (model: Model) dispatch (depth: int) =
    fun item ->
        let opened =
            if not (item.Children |> List.isEmpty)
            then item.Children |> List.exists (fun i -> i.Href = Some model.currentPage)
            else false
        let childItems = item.Children |> List.map (mapNavigation model dispatch (depth + 1))
        from
            ((navItem item.Title depth item.Href opened childItems model dispatch) |> navItemWithStyles)
            createEmpty []

let navigationMenu model dispatch =
    Mui.list
        [ MProps.MaterialProp.Component ("nav" |> U3.Case1) ]
        (navItems |> List.map (mapNavigation model dispatch 0))

let drawerMenuStyles (theme : ITheme) : IStyles list =
    [
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
                        CSSProp.Color theme.palette.primary.dark
                        TextDecoration "underline"
                    ] |> toObj)
            ] |> toObj)
    ]
let drawerWithStyles<'a> = Mui.withStyles (StyleType.Func drawerMenuStyles) []

let drawerMenu model dispatch props =
    let classes = props?classes
    div [ Class !!classes?drawerRoot ] [
        Mui.toolbar [ Class !!classes?drawerToolbar ] [
            a [
                Href ""
                OnClick (fun _ -> Navigate Home |> dispatch)
            ] [
                Mui.typography
                    [ MProps.TypographyProp.Variant MProps.TypographyVariant.Subheading
                      Class !!classes?headerLink ]
                    [ str "Fable Material-UI" ]
            ]
            a [
                Target "_blank"
                Rel "noopener noreferrer"
                Href "https://github.com/mvsmal/fable-material-ui/releases"
            ] [
                Mui.typography
                    [ MProps.TypographyProp.Variant MProps.TypographyVariant.Caption
                      Class !!classes?headerLink ]
                    [ str "v1.2.0" ]
            ]
        ]
        Mui.divider []
        navigationMenu model dispatch
    ]

let mainStyles (theme : ITheme) : IStyles list=
    let mdBreakpoint = theme.breakpoints.up(MProps.MaterialSize.Md |> U2.Case1)
    let lgBreakpoint = theme.breakpoints.up(MProps.MaterialSize.Lg |> U2.Case1)
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
        Styles.Custom
            ("menuButton", [
                MarginLeft -12
                MarginRight 20
            ] |> toObj)
        Styles.Custom
            ("main", [
                MarginTop 55
                CSSProp.Padding 20
                MinHeight "calc(100vh - 55px)"
                CSSProp.Custom
                    (mdBreakpoint, [
                        MarginTop 64
                        MinHeight "calc(100vh - 64px)"
                        MarginLeft 250
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

let menuButton model dispatch =
    match model.isLanding with
    | false -> null
    | _ ->
        Mui.iconButton [
            MProps.IconProp.Color MProps.IconColor.Inherit
            OnClick (fun _ -> ToggleMenu |> dispatch)
        ] [ Mui.icon [] [ str "menu" ] ]

let layout (model : Model) dispatch props =
    let content = function
        | Page.Home -> Home.View.root model dispatch
        | Page.Installation -> GettingStarted.Installation.View.root model dispatch
        | Page.AppBar -> AppBar.View.root model dispatch
        | Page.Autocomplete -> Autocomplete.View.root model dispatch
        | Page.Avatars -> Avatars.View.root model dispatch
        | Page.Usage -> GettingStarted.Usage.View.root model dispatch

    let classes = props?classes
    Mui.muiThemeProvider [MProps.MuiThemeProviderProp.Theme (MProps.ProviderTheme.Theme theme) ] [
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
        Mui.drawer [
            MProps.DrawerProp.Variant
                (if model.isLanding then MProps.DrawerVariant.Temporary else MProps.DrawerVariant.Permanent)
            MProps.MaterialProp.Open model.menuOpen
            MProps.MaterialProp.OnClose (fun _ -> ToggleMenu |> dispatch)
        ] [
            from (drawerMenu model dispatch |> drawerWithStyles) createEmpty []
        ]

        main [ Class ([(!!classes?main, true); (!!classes?landingMain, model.isLanding)] |> classNames) ] [
            div
                [ Class ([(!!classes?content, true); (!!classes?landingMain, model.isLanding)] |> classNames) ]
                [ content model.currentPage ]
        ]
    ]


let layoutStyles<'a> = Mui.withStyles (StyleType.Func mainStyles) []

let root (model: Model) dispatch : ReactElement =
    from (layout model dispatch |> layoutStyles) createEmpty []

open Elmish.React
open Elmish.Debug
open Elmish.HMR

// App
Program.mkProgram init update root
|> Program.toNavigable (parsePath pageParser) urlUpdate
#if DEBUG
|> Program.withDebugger
|> Program.withHMR
#endif
|> Program.withReact "app"
|> Program.run
