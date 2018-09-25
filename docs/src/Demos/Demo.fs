module Demos.Demo

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

let demosContext: obj = requireContext "./"

let demoStyles (theme : ITheme) : IStyles list =
    [
        customStyle "sourceButton" [
            CSSProp.Position "absolute"
            CSSProp.Top 10
            CSSProp.Right 10
        ]
        customStyle "wrapper" [
            CSSProp.Position "relative"
        ]
        Styles.Container [
            CSSProp.BackgroundColor "#ffffff"
        ]
        customStyle "content" [
            CSSProp.BackgroundColor theme.palette.grey.``200``
            CSSProp.Padding 20
            CSSProp.PaddingTop 70
            customCss "&-below" [
                CSSProp.PaddingTop 20
            ]
        ]
    ]

[<Pojo>]
type DemoProps =
    abstract member demoPath: string with get,set
    abstract member title: string with get,set
    abstract member demoElement: ReactElement with get,set
    inherit IClassesProps

[<Pojo>]
type DemoClasses =
    abstract member sourceButton : string
    abstract member wrapper : string
    abstract member content : string
    abstract member container : string
    inherit IClasses

[<Pojo>]
type DemoState = {
    expanded: bool
}

let wrapWithFsharp text =
    text |> sprintf "
```fsharp
%s
```
    "

type DemoComponent(p) as this =
    inherit PureComponent<DemoProps,DemoState>(p)
    do
        this.setInitState { expanded = false }

    let toggleSource = this.ToggleSource

    member __.ToggleSource _ =
        this.setState (fun s _ -> { s with expanded = not s.expanded })

    override __.render() =
        let demo = !!(demosContext $ this.props.demoPath)
        let classes : DemoClasses = !!this.props.classes
        let contentClassNames =
            [(classes.content, true)
             (classes.content + "-below", this.state.expanded)]
            |> classNames
        fragment [] [
            Markdown.view this.props.title
            div [ Class classes.wrapper ] [
                tooltip [
                    Placement PlacementType.Top
                    TooltipProp.Title
                        (if this.state.expanded
                         then (str "Hide source" |> U2.Case1 |> U3.Case1)
                         else (str "Show source" |> U2.Case1 |> U3.Case1))
                ] [
                    iconButton [
                        Class classes.sourceButton
                        OnClick toggleSource
                    ] [ icon [] [ str "code" ]]
                ]
                collapse [
                    Class classes.container
                    MaterialProp.In this.state.expanded
                ] [ Markdown.view (demo |> wrapWithFsharp) ]
                div [ Class contentClassNames ] [ this.props.demoElement ]
            ]
        ]

let demoComponent props =
    ofType<DemoComponent,_,_> props []

let demoWithStyles = withStyles (StyleType.Func demoStyles) [] demoComponent

let view title demoPath demoElement =
    let props = createEmpty<DemoProps>
    props.demoPath <- demoPath
    props.title <- title
    props.demoElement <- demoElement
        
    from demoWithStyles props []