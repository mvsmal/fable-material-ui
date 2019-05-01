module Layout.NavigationItem

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Props

open App.Types
open Global
open Utils

let subNavStyles (theme: ITheme) : IStyles list =
    [
        Styles.Button [
            CSSProp.JustifyContent "flex-start"
            CSSProp.LetterSpacing 0
            CSSProp.PaddingLeft 24
            CSSProp.TextTransform "none"
            CSSProp.Width "100%"
            CSSProp.FontWeight theme.typography.fontWeightMedium
        ]
        Styles.Custom ("collapse", [
            CSSProp.Padding 0
            CSSProp.Margin 0
        ])
    ]


type SubNavProps =
    abstract member title: string with get, set
    abstract member opened: bool with get, set
    abstract member childItems: ReactElement list with get, set
    inherit IClassesProps


type SubNavState = {
    opened: bool
}

type SubNav (p) =
    inherit PureComponent<SubNavProps,SubNavState>(p)
    do
        base.setInitState { opened = p.opened }
    member this.Toggle _ =
        this.setState (fun s p -> { s with opened = not s.opened })

    override this.render() =
        let classes = this.props.classes
        fragment [] [
            button [
                OnClick this.Toggle
                MaterialProp.Classes [ ClassNames.Root !!classes?button ]
            ] [ str this.props.title ]
            collapse [
                In this.state.opened
                UnmountOnExit true
                Class !!classes?collapse
            ] [
                list [] this.props.childItems ]
        ]

let subNav props =
    ofType<SubNav, SubNavProps, SubNavState> props []
let subNavWithStyles<'a> = withStyles (StyleType.Func subNavStyles) [] subNav

let navItemStyles (theme: ITheme) : IStyles list =
    [
        Styles.Custom ("listItem", [
            CSSProp.Display DisplayOptions.Block
            CSSProp.PaddingTop 0
            CSSProp.PaddingBottom 0
        ])
        Styles.Custom ("bold", [
            CSSProp.FontWeight 500
        ])
        Styles.Button [
            CSSProp.JustifyContent "flex-start"
            CSSProp.LetterSpacing 0
            CSSProp.TextTransform "none"
            CSSProp.Width "100%"
            CSSProp.FontWeight theme.typography.fontWeightRegular
        ]
        Styles.Selected [
            CSSProp.Color theme.palette.primary.main
            CSSProp.FontWeight theme.typography.fontWeightMedium
        ]
    ]


type NavItemProps =
    abstract member title : string with get,set
    abstract member href : Page option with get,set
    abstract member depth : int with get,set
    abstract member currentPage : Page with get,set
    abstract member opened : bool with get,set
    abstract member childItems : ReactElement list with get,set
    abstract member dispatch : (Msg->unit) with get,set
    inherit IClassesProps

let navItem (props : NavItemProps) =
    let style = [ CSSProp.PaddingLeft (8 * (3 + 2 * props.depth)) ]
    match props.href with
    | Some page ->
        let buttonClasses =
            [ (!!props.classes?selected, props.currentPage = page) ] |> classNames
        listItem [
            DisableGutters true
            Class !!props.classes?listItem
        ] [
            button [
                DisableRipple true
                MaterialProp.Component ("a" |> ReactElementType.ofHtmlElement)
                Style style
                Class buttonClasses
                MaterialProp.Classes [ ClassNames.Root !!props.classes?button ]
                HTMLAttr.Href (toHash page)
                OnClick (fun _ -> OpenMenu false |> props.dispatch)
            ] [ str props.title ]
        ]
    | None ->
        let subNavProps = createEmpty<SubNavProps>
        subNavProps.opened <- props.opened
        subNavProps.title <- props.title
        subNavProps.childItems <- props.childItems
        listItem [
            DisableGutters true
            Class !!props.classes?listItem
        ] [ ReactElementType.create subNavWithStyles subNavProps [] ]

let navItemWithStyles = withStyles (StyleType.Func navItemStyles) [] navItem

let view item depth opened currentPage childItems dispatch =
    let props = createEmpty<NavItemProps>
    props.title <- item.Title
    props.href <- item.Href
    props.depth <- depth
    props.currentPage <- currentPage
    props.opened <- opened
    props.childItems <- childItems
    props.dispatch <- dispatch
    ReactElementType.create navItemWithStyles props []
