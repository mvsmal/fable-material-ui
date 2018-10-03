module Layout.NavigationItem

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Props

open App.Types
open Global
open Utils

module Mui = Fable.Helpers.MaterialUI

let subNavStyles (theme: ITheme) : IStyles list =
    [
        Styles.Button [
            JustifyContent "flex-start"
            CSSProp.PaddingLeft 24
            CSSProp.TextTransform "none"
            CSSProp.Width "100%"
            CSSProp.FontWeight theme.typography.fontWeightMedium
        ]
        customStyle "collapse" [
            CSSProp.Padding 0
            CSSProp.Margin 0
        ]
    ]

[<Pojo>]
type SubNavProps =
    abstract member title: string with get, set
    abstract member opened: bool with get, set
    abstract member childItems: ReactElement list with get, set
    inherit Mui.IClassesProps

[<Pojo>]
type SubNavState = {
    opened: bool
}

type SubNav (p) as this =
    inherit PureComponent<SubNavProps,SubNavState>(p)
    do
        this.setInitState { opened = p.opened }
    let toggle = this.Toggle
    member this.Toggle e =
        let newState = { this.state with opened = not this.state.opened }
        this.setState newState

    override this.render() =
        let classes = this.props.classes
        fragment [] [
            Mui.button [
                OnClick toggle
                Classes [ ClassNames.Root !!classes?button ]
            ] [ str this.props.title ]
            Mui.collapse [
                In this.state.opened
                UnmountOnExit true
                Class !!classes?collapse
            ] [
                Mui.list [] this.props.childItems ]
        ]

let subNav props =
    ofType<SubNav, SubNavProps, SubNavState> props []
let subNavWithStyles<'a> = Mui.withStyles (StyleType.Func subNavStyles) [] subNav

let navItemStyles (theme: ITheme) : IStyles list =
    [
        customStyle "listItem" [
            CSSProp.Display "block"
            PaddingTop 0
            PaddingBottom 0
        ]
        customStyle "bold" [
            CSSProp.FontWeight 500
        ]
        Styles.Button [
            JustifyContent "flex-start"
            CSSProp.TextTransform "none"
            CSSProp.Width "100%"
            CSSProp.FontWeight theme.typography.fontWeightRegular
        ]
        Styles.Selected [
            CSSProp.Color theme.palette.primary.main
            CSSProp.FontWeight theme.typography.fontWeightMedium
        ]
    ]

[<Pojo>]
type NavItemProps =
    abstract member title : string with get,set
    abstract member href : Page option with get,set
    abstract member depth : int with get,set
    abstract member currentPage : Page with get,set
    abstract member opened : bool with get,set
    abstract member childItems : ReactElement list with get,set
    abstract member dispatch : (Msg->unit) with get,set
    inherit Mui.IClassesProps

let navItem (props : NavItemProps) =
    let style = [ CSSProp.PaddingLeft (8 * (3 + 2 * props.depth)) ]
    match props.href with
    | Some page ->
        let buttonClasses =
            [ (!!props.classes?selected, props.currentPage = page) ] |> classNames
        Mui.listItem [
            DisableGutters true
            Class !!props.classes?listItem
        ] [
            Mui.button [
                DisableRipple true
                MaterialProp.Component ("a" |> U3.Case1)
                Style style
                Class buttonClasses
                Classes [ ClassNames.Root !!props.classes?button ]
                Href ((toHash page))
                OnClick (fun _ -> OpenMenu false |> props.dispatch)
            ] [ str props.title ]
        ]
    | None ->
        let subNavProps = createEmpty<SubNavProps>
        subNavProps.opened <- props.opened
        subNavProps.title <- props.title
        subNavProps.childItems <- props.childItems
        Mui.listItem [
            DisableGutters true
            Class !!props.classes?listItem
        ] [ from subNavWithStyles subNavProps [] ]

let navItemWithStyles = Mui.withStyles (StyleType.Func navItemStyles) [] navItem

let view item depth opened currentPage childItems dispatch =
    let props = createEmpty<NavItemProps>
    props.title <- item.Title
    props.href <- item.Href
    props.depth <- depth
    props.currentPage <- currentPage
    props.opened <- opened
    props.childItems <- childItems
    props.dispatch <- dispatch
    from navItemWithStyles props []
