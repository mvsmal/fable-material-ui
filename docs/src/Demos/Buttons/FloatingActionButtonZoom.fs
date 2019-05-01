module Demos.Buttons.FloatingActionButtonZoom

open Fable.Core
open Fable.Core.JsInterop
open Fable.React.Props
open Fable.React
open Fable.MaterialUI.Core
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Props
open Fable.MaterialUI

let tabContainer children =
    typography [
        MaterialProp.Component ("div" |> ReactElementType.ofHtmlElement)
        Style [ CSSProp.Padding (8 * 3) ]
    ] children

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Root [
            CSSProp.BackgroundColor theme.palette.background.paper
            CSSProp.Width 500
            CSSProp.Position PositionOptions.Relative
            CSSProp.MinHeight 200
        ]
        Styles.Fab [
            CSSProp.Position PositionOptions.Relative
            CSSProp.Bottom (theme.spacing.unit * 2)
            CSSProp.Right (theme.spacing.unit * 2)
        ]
        Styles.Custom (
            "fabGreen",
            [
                CSSProp.Color theme.palette.common.white
                CSSProp.BackgroundColor Colors.green.``500``
            ]
        )
    ]

type Fab = {
    color : ComponentColor
    className : string
    icon : ReactElement
}


type ButtonsProps =
    inherit IClassesProps


type ButtonsState = {
    value : int
}

type FloatingActionButtonZoom (props) =
    inherit Component<ButtonsProps,ButtonsState>(props)
    do base.setInitState { value = 0 }

    member this.handleChange _ index =
        this.setState (fun s _ -> { s with value = index })

    override this.render() =
        let classes = this.props.classes
        let theme : ITheme = !!this.props?theme
        let transitionExit = theme.transitions.duration.leavingScreen
        let transitionsDuration = [
            TransitionDurationProp.Enter theme.transitions.duration.enteringScreen
            TransitionDurationProp.Exit transitionExit
        ]
        let fabs = [
            {
                color = ComponentColor.Primary
                className = !!classes?fab
                icon = icon [] [ str "add_icon" ]
            }
            {
                color = ComponentColor.Secondary
                className = !!classes?fab
                icon = icon [] [ str "edit_icon" ]
            }
            {
                color = ComponentColor.Inherit
                className = !!classes?fab + " " + !!classes?fabGreen
                icon = icon [] [ str "keyboard_arrow_up_icon" ]
            }
        ]

        div [ Class !!classes?root ] [
            yield appBar [
                AppBarProp.Position AppBarPosition.Static
                MaterialProp.Color ComponentColor.Default
            ] [
                tabs [
                    MaterialProp.Value this.state.value
                    TabsProp.OnChange this.handleChange
                    TabsProp.IndicatorColor TabsIndicatorColor.Primary
                    TabsProp.TextColor TabsTextColor.Primary
                    MaterialProp.FullWidth true
                ] [
                    tab [ MaterialProp.Label (str "Item One")]
                    tab [ MaterialProp.Label (str "Item Two")]
                    tab [ MaterialProp.Label (str "Item Three")]
                ]
            ]
            yield (match this.state.value with
                   | 1 -> tabContainer [ str "Item Two"]
                   | 2 -> tabContainer [ str "Item Three"]
                   | _ -> tabContainer [ str "Item One" ] )
            yield! fabs |> List.mapi (fun i f ->
                zoom [
                    Key (f.color |> string)
                    MaterialProp.In (this.state.value = i)
                    MaterialProp.Timeout (transitionsDuration |> U2.Case2)
                    Style [
                        CSSProp.TransitionDelay
                            ((if this.state.value = i then transitionExit else 0.) |> sprintf "%.0fms")
                    ]
                    TransitionProp.UnmountOnExit true
                ] [
                    fab [
                        HTMLAttr.Class f.className
                        MaterialProp.Color f.color
                    ] [ f.icon ]
                ])
        ]

let floatingButtonsZoom props =
    ofType<FloatingActionButtonZoom,_,_> props []

let floatingButtonsZoomWithStyles =
    withStyles<ButtonsProps> (StyleType.Func styles) [ StyleOption.WithTheme true ] floatingButtonsZoom

let view () =
    ReactElementType.create floatingButtonsZoomWithStyles createEmpty []
