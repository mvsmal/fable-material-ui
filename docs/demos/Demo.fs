module Demos.Demo
open Fable.Helpers.React
open Fable.MaterialUI.Props
open Fable.Helpers.MaterialUI
open Fable.MaterialUI.Themes
open Fable.Core
open Fable.Core.JsInterop
open Utils
open Fable.Import.React
open Fable.Helpers.React.Props

[<Emit("require.context($0)")>]
let inline requireContext (dir: string) = jsNative

let demosContext: obj = requireContext "../../demos"

type Prism =
    abstract highlight: text: string * grammar: obj -> string
    abstract member languages: obj

let prism : Prism = importDefault "prismjs"

let code text =
    let markedCode = prism.highlight (text, prism.languages?("fsharp"))
    div [ Class "code-block"] [
        pre [] [
            code [
                Class "language-fsharp"
                DangerouslySetInnerHTML { __html = markedCode } ] []
        ]
    ]


let demoStyles (theme : ITheme) : IStyles list =
    [
        Styles.Custom
            ("h2", [
                CSSProp.Color theme.palette.text.secondary
                CSSProp.Margin "32px 0 24px"
            ] |> toObj)
        Styles.Custom
            ("sourceButton", [
                CSSProp.Position "absolute"
                CSSProp.Top 10
                CSSProp.Right 10
            ] |> toObj)
        Styles.Custom
            ("wrapper", [
                CSSProp.Position "relative"
            ] |> toObj)
        Styles.Custom
            ("content", [
                CSSProp.BackgroundColor theme.palette.grey.``200``
                CSSProp.Padding 20
                CSSProp.PaddingTop 70
                CSSProp.Custom
                    ("&-below", [
                        CSSProp.PaddingTop 20
                    ] |> toObj)
            ] |> toObj)
    ]

let demoWithStyles<'a> = withStyles (StyleType.Func demoStyles) []

[<Pojo>]
type DemoProps = {
    demoPath: string
    title: string
    demoElement: ReactElement
    classes: obj
}
[<Pojo>]
type DemoState = {
    expanded: bool
}
type DemoComponent(p) as this =
    inherit PureComponent<DemoProps,DemoState>(p)
    do
        this.setInitState { expanded = false }

    let toggleSource = this.ToggleSource

    member __.ToggleSource (e: MouseEvent) =
        this.setState (fun s _ -> { s with expanded = not s.expanded })

    override __.render() =
        let d : string = !!(demosContext $ this.props.demoPath)
        let contentClassNames =
            [(!!this.props.classes?content, true)
             ((!!this.props.classes?content + "-below"), this.state.expanded)]
            |> classNames
        fragment [] [
            typography [
                TypographyProp.Variant TypographyVariant.Display1
                Class !!this.props.classes?h2
            ] [ str this.props.title ]
            div [ Class !!this.props.classes?wrapper ] [
                tooltip [
                    Placement PlacementType.Top
                    TooltipProp.Title
                        (if this.state.expanded
                         then (str "Hide source" |> U2.Case1 |> U3.Case1)
                         else (str "Show source" |> U2.Case1 |> U3.Case1))
                ] [
                    iconButton [
                        Class !!this.props.classes?sourceButton
                        OnClick toggleSource
                    ] [ icon [] [ str "code" ]]
                ]
                collapse [
                    MaterialProp.In this.state.expanded
                ] [ code d ]
                div [
                    Class contentClassNames
                ] [
                    this.props.demoElement
                ]
            ]
        ]

let demoComponent title demoPath demoElement props =
    ofType<DemoComponent, DemoProps, DemoState>
        {
            demoPath = demoPath
            title = title
            demoElement = demoElement
            classes = !!props?classes
        } []


let root title demoPath demoElement =
    from (demoComponent title demoPath demoElement |> demoWithStyles) createEmpty []