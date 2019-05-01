module Layout.AppBar

open Elmish.React
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

open App.Types
open Global
open Utils

module MProps = Fable.MaterialUI.Props

let githubIcon =
    svgIcon [] [
        path [
            SVGAttr.D "M12 .3a12 12 0 0 0-3.8 23.4c.6.1.8-.3.8-.6v-2c-3.3.7-4-1.6-4-1.6-.6-1.4-1.4-1.8-1.4-1.8-1-.7.1-.7.1-.7 1.2 0 1.9 1.2 1.9 1.2 1 1.8 2.8 1.3 3.5 1 0-.8.4-1.3.7-1.6-2.7-.3-5.5-1.3-5.5-6 0-1.2.5-2.3 1.3-3.1-.2-.4-.6-1.6 0-3.2 0 0 1-.3 3.4 1.2a11.5 11.5 0 0 1 6 0c2.3-1.5 3.3-1.2 3.3-1.2.6 1.6.2 2.8 0 3.2.9.8 1.3 1.9 1.3 3.2 0 4.6-2.8 5.6-5.5 5.9.5.4.9 1 .9 2.2v3.3c0 .3.1.7.8.6A12 12 0 0 0 12 .3"
        ] []
    ]

let menuButton model dispatch =
    let button =
        iconButton [
            IconProp.Color IconColor.Inherit
            OnClick (fun _ -> OpenMenu true |> dispatch)
        ] [ icon [] [ str "menu" ] ]
    match model.isLanding with
    | false -> hidden [ LgUp true ] [ button ]
    | _ -> button

let appBarStyles (theme : ITheme) : IStyles list =
    let lgBreakpoint = theme.breakpoints.up(MaterialSize.Lg |> U2.Case1)
    [
        Styles.Custom ("appBar", [
            customCss lgBreakpoint [
                Left 250
                Width "calc(100% - 250px)"
            ]
        ])
        Styles.Custom ("landingAppBar", [
            Left 0
            Width "100vw"
            BoxShadow "unset"
        ])
    ]


type AppBarClasses =
    abstract member appBar : string
    abstract member landingAppBar : string

let appBar (props : AppProps) =
    let classes : AppBarClasses = !!props.classes
    appBar [
        MProps.Position AppBarPosition.Fixed
        Class ([(classes.appBar, true); (classes.landingAppBar, props.model.isLanding)] |> classNames)
    ] [
        toolbar [] [
            lazyView2 menuButton props.model props.dispatch
            typography [
                TypographyProp.Variant TypographyVariant.H6
                MaterialProp.Color ComponentColor.Inherit
            ] [ props.model.currentPage |> toTitle |> str ]
            div [ Class "flex" ] []
            tooltip [
                TooltipProp.Title (str "Github")
                TooltipProp.EnterDelay 300
            ] [
                iconButton [
                    IconProp.Color IconColor.Inherit
                    MaterialProp.Component ("a" |> ReactElementType.ofHtmlElement)
                    Target "_blank"
                    Href "https://github.com/mvsmal/fable-material-ui"
                ] [ githubIcon ]
            ]
        ]
    ]

let appBarWithStyles = withStyles (StyleType.Func appBarStyles) [] appBar

let view model dispatch =
    let props = createEmpty<AppProps>
    props.model <- model
    props.dispatch <- dispatch
    ReactElementType.create appBarWithStyles props []
