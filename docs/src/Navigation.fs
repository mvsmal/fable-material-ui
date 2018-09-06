module App.Navigation

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.MaterialUI.Themes

open Utils
open Global
open App.Types
open Fable.Import
open Fable.Import.React
module Mui = Fable.Helpers.MaterialUI
module MProps = Fable.MaterialUI.Props
module MColors = Fable.MaterialUI.Colors

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
                { Title = "Avatars"; Href = Some Page.Avatars; Children = [] }
            ]
    }
]

let subNavStyles (theme: ITheme) : IStyles list =
    [
        Styles.Button [
            JustifyContent "flex-start"
            CSSProp.TextTransform "none"
            CSSProp.Width "100%"
            CSSProp.FontWeight theme.typography.fontWeightMedium
        ]
        Styles.Custom
            ("collapse", [
                CSSProp.Padding 0
                CSSProp.Margin 0
            ] |> toObj)
    ]

[<Pojo>]
type SubNavProps =
    abstract member opened: bool with get, set
    abstract member childItems: ReactElement list with get, set
    abstract member classes: obj with get, set
    abstract member style: CSSProp list with get, set
    abstract member title: string with get, set
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
    member __.Toggle (_) =
        this.setState(fun s _ -> { opened = not s.opened })
    override __.render() =
        fragment [] [
            Mui.button [
                OnClick toggle
                Style this.props.style
                MProps.Classes [ ClassNames.Root !!this.props.classes?button ]
            ] [ str this.props.title ]
            Mui.collapse [
                MProps.In this.state.opened
                HTMLAttr.Custom ("unmountOnExit", true)
                MProps.Component ("ul" |> U3.Case1)
                Class !!this.props.classes?collapse
            ] this.props.childItems
        ]
let subNav props =
    ofType<SubNav, SubNavProps, SubNavState> props []
let subNavWithStyles<'a> = Mui.withStyles (StyleType.Func subNavStyles) []

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
            CSSProp.FontWeight theme.typography.fontWeightRegular
        ]
        Styles.Selected [
            CSSProp.Color theme.palette.primary.main
            CSSProp.FontWeight theme.typography.fontWeightMedium
        ]
    ]
let navItemWithStyles<'a> = Mui.withStyles (StyleType.Func navItemStyles) []
let navItem title depth href opened model childItems dispatch props =
    Browser.console.log("navItem", title, href)
    let style =
        [
            CSSProp.PaddingLeft (8 * (3 + 2 * depth))
        ]
    match href with
    | Some page ->
        let buttonClasses =
            [ (!!props?classes?selected, model.currentPage = page) ] |> classNames
        Mui.listItem [
            MProps.DisableGutters true
            Class !!props?classes?listItem
        ] [
            Mui.button [
                MProps.DisableRipple true
                MProps.Component ("a" |> U3.Case1)
                Style style
                Class buttonClasses
                MProps.Classes [ ClassNames.Root !!props?classes?button ]
                OnClick (fun _ -> Navigate page |> dispatch)
            ] [ str title ]
        ]
    | None ->
        let subNavProps = createEmpty<SubNavProps>
        subNavProps.opened <- opened
        subNavProps.title <- title
        subNavProps.style <- style
        subNavProps.childItems <- childItems
        Mui.listItem [
            MProps.DisableGutters true
            Class !!props?classes?listItem
        ] [ from (subNav |> subNavWithStyles) subNavProps [] ]

let rec mapNavigation (model: Model) dispatch (depth: int) =
    fun item ->
        let opened =
            if not (item.Children |> List.isEmpty)
            then item.Children |> List.exists (fun i -> i.Href = Some model.currentPage)
            else false
        let childItems = item.Children |> List.map (mapNavigation model dispatch (depth + 1))
        from
            ((navItem item.Title depth item.Href opened model childItems dispatch) |> navItemWithStyles)
            createEmpty []

let navigationMenu model dispatch =
    Mui.list
        [ MProps.MaterialProp.Component ("nav" |> U3.Case1) ]
        (navItems |> List.map (mapNavigation model dispatch 0))

