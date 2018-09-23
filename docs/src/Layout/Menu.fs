module Layout.Menu

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

open Global
open Utils
open Fable.Import
open App.Types
open Elmish.React.Common

module Mui = Fable.Helpers.MaterialUI

[<Pojo>]
type MenuClasses =
    abstract member root: string
    abstract member toolbar: string
    abstract member headerLink: string
    abstract member title: string
    inherit Mui.IClasses

[<Pojo>]
type MenuProps =
    abstract member currentPage : Page with get, set
    abstract member dispatch : (Msg->unit) with get,set
    inherit Mui.IClassesProps

let menuStyles (theme : ITheme) : IStyles list =
    [
        Styles.Title [
            CSSProp.Color theme.palette.text.secondary
            CSSProp.MarginBottom (theme.spacing.unit / 2)
        ]
        Styles.Root [ Width 250 ]
        customStyle "toolbar" [
            Display "flex"
            FlexDirection "column"
            JustifyContent "center"
            CSSProp.AlignItems "flex-start"
        ]
        customStyle "headerLink" [
            CSSProp.Transition "color .2s ease-in-out"
            customCss "&:hover" [
                CSSProp.Color theme.palette.primary.main
                TextDecoration "underline"
            ]
        ]
    ]
let menu (props : MenuProps) =
    Browser.console.log("menu render")
    let classes : MenuClasses = !!props.classes
    div [ Class classes.root ] [
        Mui.toolbar [ Class classes.toolbar ] [
            a [
                Class classes.title
                Href ("/" + toHash Home)
                OnClick (fun _ -> OpenMenu false |> props.dispatch)
            ] [
                Mui.typography
                    [ TypographyProp.Variant TypographyVariant.Title
                      Class classes.headerLink
                      TypographyProp.Color TypographyColor.Inherit ]
                    [ str "Fable Material-UI" ]
            ]
            a [
                Target "_blank"
                Rel "noopener noreferrer"
                Href "https://github.com/mvsmal/fable-material-ui/releases"
            ] [
                Mui.typography
                    [ TypographyProp.Variant TypographyVariant.Caption
                      Class classes.headerLink ]
                    [ str "v1.3.2" ]
            ]
        ]
        Mui.divider []
        lazyView2 Layout.Navigation.view props.currentPage props.dispatch
    ]

let menuWithStyles<'a> = Mui.withStyles (StyleType.Func menuStyles) [] menu

let view currentPage dispatch =
    let props = createEmpty<MenuProps>
    props.currentPage <- currentPage
    props.dispatch <- dispatch
    from menuWithStyles props []