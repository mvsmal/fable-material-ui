module Demos.Buttons.FloatingActionButtonZoom

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.MaterialUI
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Props
open Fable.MaterialUI
module R = Fable.Helpers.React

let toObj = keyValueList CaseRules.LowerFirst

let tabContainer children =
    typography [
        MaterialProp.Component ("div" |> U3.Case1)
        Style [ CSSProp.Padding (8 * 3) ]
    ] children

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Root [
            CSSProp.BackgroundColor theme.palette.background.paper
            CSSProp.Width 500
            CSSProp.Position "relative"
            CSSProp.MinHeight 200
        ]
        Styles.Fab [
            CSSProp.Position "absolute"
            CSSProp.Bottom (theme.spacing.unit * 2)
            CSSProp.Right (theme.spacing.unit * 2)
        ]
        Styles.Custom (
            "fabGreen",
            [
                CSSProp.Color theme.palette.common.white
                CSSProp.BackgroundColor Colors.green.``500``
            ] |> toObj
        )
    ]

[<Pojo>]
type Fab = {
    color : ComponentColor
    className : string
    icon : ReactElement
}

[<Pojo>]
type ButtonsProps =
    inherit IClassesProps

[<Pojo>]
type ButtonsState = {
    value : int
}

type FloatingActionButtonZoom (props) as this =
    inherit Component<ButtonsProps,ButtonsState>(props)
    do this.setInitState { value = 0 }

    member __.handleChange _ index =
        this.setState { this.state with value = index }

    override __.render() =
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
                icon = icon [] [ R.str "add_icon" ]
            }
            {
                color = ComponentColor.Secondary
                className = !!classes?fab
                icon = icon [] [ R.str "edit_icon" ]
            }
            {
                color = ComponentColor.Inherit
                className = !!classes?fab + " " + !!classes?fabGreen
                icon = icon [] [ R.str "keyboard_arrow_up_icon" ]
            }
        ]

        R.div [ Class !!classes?root ] [
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
                    tab [ MaterialProp.Label (R.str "Item One" |> U2.Case1 |> U3.Case1)]
                    tab [ MaterialProp.Label (R.str "Item Two" |> U2.Case1 |> U3.Case1)]
                    tab [ MaterialProp.Label (R.str "Item Three" |> U2.Case1 |> U3.Case1)]
                ]
            ]
            yield (match this.state.value with
                   | 1 -> tabContainer [ R.str "Item Two"]
                   | 2 -> tabContainer [ R.str "Item Three"]
                   | _ -> tabContainer [ R.str "Item One" ] )
            yield! fabs |> List.mapi (fun i f ->
                zoom [
                    Key (f.color |> string)
                    MaterialProp.In (this.state.value = i)
                    MaterialProp.Timeout (transitionsDuration |> U2.Case2)
                    Style [
                        CSSProp.TransitionDelay
                            ((if this.state.value = i then transitionExit else 0.) |> sprintf "%.0fms")
                    ]
                    HTMLAttr.Custom ("unmountOnExit", true)
                ] [
                    button [
                        ButtonProp.Variant ButtonVariant.Fab
                        HTMLAttr.Class f.className
                        MaterialProp.Color f.color
                    ] [ f.icon ]
                ])
        ]

let floatingButtonsZoom props =
    R.ofType<FloatingActionButtonZoom,_,_> props []

let floatingButtonsZoomWithStyles<'a> =
    withStyles (StyleType.Func styles) [ StyleOption.WithTheme true ] floatingButtonsZoom

let view () =
    R.from floatingButtonsZoomWithStyles createEmpty []
