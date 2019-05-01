module Layout.Menu

open Elmish.React.Common
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

open App.Types
open Global
open Utils

type MenuClasses =
    abstract member root: string
    abstract member toolbar: string
    abstract member headerLink: string
    abstract member title: string
    inherit IClasses


type MenuProps =
    abstract member currentPage : Page with get, set
    abstract member dispatch : (Msg->unit) with get,set
    inherit IClassesProps

let menuStyles (theme : ITheme) : IStyles list =
    [
        Styles.Title [
            CSSProp.Color theme.palette.text.secondary
            CSSProp.MarginBottom (theme.spacing.unit / 2)
        ]
        Styles.Custom ("toolbar", [
            Display DisplayOptions.Flex
            FlexDirection "column"
            JustifyContent "center"
            CSSProp.AlignItems AlignItemsOptions.FlexStart
        ])
        Styles.Custom ("headerLink", [
            CSSProp.Transition "color .2s ease-in-out"
            customCss "&:hover" [
                CSSProp.Color theme.palette.primary.main
                TextDecoration "underline"
            ]
        ])
    ]
let menu (props : MenuProps) =
    let classes : MenuClasses = !!props.classes
    div [] [
        toolbar [ Class classes.toolbar ] [
            a [
                Class classes.title
                Href (toHash Home)
                OnClick (fun _ -> OpenMenu false |> props.dispatch)
            ] [
                typography
                    [ TypographyProp.Variant TypographyVariant.H6
                      Class classes.headerLink
                      TypographyProp.Color TypographyColor.Inherit ]
                    [ str "Fable Material-UI" ]
            ]
            a [
                Target "_blank"
                Rel "noopener noreferrer"
                Href "https://github.com/mvsmal/fable-material-ui/releases"
            ] [
                typography
                    [ TypographyProp.Variant TypographyVariant.Caption
                      Class classes.headerLink ]
                    [ str libVersion ]
            ]
        ]
        divider []
        lazyView2 Layout.Navigation.view props.currentPage props.dispatch
    ]

let menuWithStyles<'a> = withStyles (StyleType.Func menuStyles) [] menu

let view currentPage dispatch =
    let props = createEmpty<MenuProps>
    props.currentPage <- currentPage
    props.dispatch <- dispatch
    ReactElementType.create menuWithStyles props []
