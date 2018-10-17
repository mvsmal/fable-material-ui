module Layout.Layout

open Elmish.React
open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Props

open App.Types
open Global
open Utils

module Mui = Fable.Helpers.MaterialUI
module MColors = Fable.MaterialUI.Colors

let theme =
    Mui.createMuiTheme [
        ThemeProp.Palette [
            PaletteProp.Type PaletteType.Light
            PaletteProp.Primary [
                PaletteIntentionProp.Main MColors.blue.``500``
            ]
            PaletteProp.Secondary [
                PaletteIntentionProp.Main
                    (Mui.ColorManipulator.darken (MColors.pink.A400, 0.08))
            ]
        ]
    ]

let layoutStyles (theme : ITheme) : IStyles list=
    let lgBreakpoint = theme.breakpoints.up(MaterialSize.Lg |> U2.Case1)
    let smBreakpoint = theme.breakpoints.up(MaterialSize.Sm |> U2.Case1)
    [
        Styles.Root [
            Display "flex"
        ]
        Styles.Custom ("menuButton", [
            MarginLeft -12
            MarginRight 20
        ])
        Styles.Custom ("main", [
            PaddingTop 80
            Flex "1 1 100%"
            CSSProp.MaxWidth "100%"
            CSSProp.Margin "0 auto"
            CSSProp.PaddingLeft (theme.spacing.unit * 2)
            CSSProp.PaddingRight (theme.spacing.unit * 2)
            CSSProp.FontFamily theme.typography.fontFamily
            CSSProp.FontSize 16
            CSSProp.Color theme.palette.text.primary
            customCss smBreakpoint [
                PaddingLeft (theme.spacing.unit * 4)
                PaddingRight (theme.spacing.unit * 4)
            ]
            customCss lgBreakpoint [
                PaddingLeft (theme.spacing.unit * 5)
                PaddingRight (theme.spacing.unit * 9)
                CSSProp.MaxWidth "calc(100% - 250px)"
            ]
        ])
        Styles.Custom ("landingMain", [
            CSSProp.Padding 0
            CSSProp.MaxWidth "100vw"
            MarginLeft 0
        ])
]

type LayoutClasses =
    abstract member main : string
    abstract member landingMain : string
    abstract member root : string
    inherit Mui.IClasses

let layout (props : AppProps) =
    let content = function
        | Page.Home -> Home.View.root props.dispatch
        | Page.Installation -> GettingStarted.Installation.View.root ()
        | Page.Usage -> GettingStarted.Usage.View.root ()
        | Page.AppBar -> Demos.AppBar.View.view ()
        | Page.Avatars -> Demos.Avatars.View.root ()
        | Page.Buttons -> Demos.Buttons.View.view ()
        | Page.SignIn -> PageLayoutDemos.SignIn.root ()

    let classes : LayoutClasses = !!props.classes
    let mainClasses =
        [
            (classes.main, true)
            (classes.landingMain, props.model.isLanding)
        ] |> classNames
    Mui.muiThemeProvider [MuiThemeProviderProp.Theme (ProviderTheme.Theme theme) ] [
        div [ Class classes.root ] [
            lazyView2 Layout.AppBar.view props.model props.dispatch
            lazyView2 Layout.Drawer.view props.model props.dispatch
            main [ Class mainClasses ] [ content props.model.currentPage ]
        ]
    ]

let layoutWithStyles = Mui.withStyles (StyleType.Func layoutStyles) [] layout

let view model dispatch =
    let props = createEmpty<AppProps>
    props.model <- model
    props.dispatch <- dispatch
    from layoutWithStyles props []
