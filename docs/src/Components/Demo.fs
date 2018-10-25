module Components.Demo

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.MaterialUI
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

open Utils
open Components

[<Emit("require.context('!!raw-loader!' + $0, true, /\\.fs$/);")>]
let inline requireContext (dir: string) = jsNative

let demosContext: obj = requireContext "../"

let demoStyles (theme : ITheme) : IStyles list =
    let smBreakpoint = theme.breakpoints.up(MaterialSize.Sm |> U2.Case1)
    let demoStyle = 
            theme.mixins.gutters(
                !!([
                        CSSProp.BorderRadius theme.shape.borderRadius
                        CSSProp.BackgroundColor theme.palette.grey.``200``
                        CSSProp.Display "flex"
                        CSSProp.JustifyContent "center"
                        CSSProp.PaddingTop (theme.spacing.unit * 2)
                        CSSProp.PaddingBottom (theme.spacing.unit * 2)
                        customCss smBreakpoint [
                            CSSProp.PaddingLeft (theme.spacing.unit * 3)
                            CSSProp.PaddingRight (theme.spacing.unit * 3)
                            CSSProp.PaddingTop (theme.spacing.unit * 6)
                            CSSProp.PaddingBottom (theme.spacing.unit * 3)
                        ]
                    ] |> toObj))
    [
        Styles.Root [
            CSSProp.Position "relative"
            CSSProp.MarginBottom 40
            CSSProp.MarginLeft (-theme.spacing.unit * 2)
            CSSProp.MarginRight (-theme.spacing.unit * 2)
            customCss smBreakpoint [
                CSSProp.Padding (sprintf "0 %ipx" theme.spacing.unit)
                CSSProp.MarginLeft 0
                CSSProp.MarginRight 0
            ]
        ]
        Styles.Custom' ("demo", demoStyle)
        Styles.Custom ("header", [
            CSSProp.Display "none"
            customCss smBreakpoint [
                CSSProp.Display "flex"
                CSSProp.Custom ("flip", false)
                CSSProp.Position "absolute"
                CSSProp.Top 0
                CSSProp.Right theme.spacing.unit
            ]
        ])
        Styles.Custom ("code", [
            CSSProp.Display "none"
            CSSProp.Padding 0
            CSSProp.Margin 0
            customCss smBreakpoint [
                CSSProp.Display "block"
            ]
            customCss "& pre" [
                CSSProp.Overflow "auto"
                CSSProp.Margin "0px !important"
                CSSProp.BorderRadius "0px !important"
            ]
        ])
    ]


type DemoProps =
    abstract member demoPath: string with get,set
    abstract member title: string with get,set
    abstract member demoElement: (unit->ReactElement) with get,set
    inherit IClassesProps


type DemoClasses =
    abstract member root : string
    abstract member header : string
    abstract member demo : string
    abstract member code : string
    // abstract member sourceButton : string
    inherit IClasses


type DemoState = {
    expanded: bool
}

let wrapWithFsharp text =
    text |> sprintf "
```fsharp
%s
```
    "

type DemoComponent(p) =
    inherit PureComponent<DemoProps,DemoState>(p)
    do
        base.setInitState { expanded = false }

    member this.ToggleSource _ =
        this.setState (fun s _ -> { s with expanded = not s.expanded })

    override this.render() =
        let demo = !!(demosContext $ this.props.demoPath)
        let classes : DemoClasses = !!this.props.classes
        fragment [] [
            Markdown.view this.props.title
            div [ Class classes.root ] [
                div [] [
                    div [ Class classes.header ] [
                        tooltip [
                            Placement PlacementType.Top
                            TooltipProp.Title
                                (if this.state.expanded
                                 then (str "Hide source" |> U2.Case1 |> U3.Case1)
                                 else (str "Show source" |> U2.Case1 |> U3.Case1))
                        ] [
                            iconButton [
                                HTMLAttr.Custom ("aria-label", "Source of demo")
                                OnClick this.ToggleSource
                            ] [ icon [] [ str "code" ]]
                        ]
                    ]
                    collapse [
                        In this.state.expanded
                        TransitionProp.UnmountOnExit true
                    ] [
                        div [ Class classes.code ] [ Markdown.view (demo |> wrapWithFsharp) ]
                    ]
                ]
                div [ Class classes.demo ] [ this.props.demoElement () ]
            ]
        ]

let demoComponent props =
    ofType<DemoComponent,_,_> props []

let demoWithStyles = withStyles (StyleType.Func demoStyles) [] demoComponent

/// Renders the `demoElement` with `title` rendered as Markdown 
/// and shows the code loaded from `demoPath` (relative to `src/`)
let view title demoPath demoElement =
    let props = createEmpty<DemoProps>
    props.demoPath <- demoPath
    props.title <- title
    props.demoElement <- demoElement

    from demoWithStyles props []
