module Demos.Popper.SimplePopper

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Themes
open Fable.MaterialUI.Props
open Browser.Types

let styles (theme : ITheme) : IStyles list =
    [ Styles.Custom("typography", [ CSSProp.Padding theme.spacing.unit ]) ]

type SimplePopperState =
    { anchorEl : EventTarget
      opened : bool }

type SimplePopper (props) =
    inherit Component<IClassesProps,SimplePopperState>(props)
    do
        base.setInitState { anchorEl = null; opened = false }

    member private this.handleClick (event: Event) =
        let currentTarget = event.currentTarget
        this.setState(fun s _ ->
            { anchorEl = currentTarget
              opened = not s.opened })

    override this.render() =
        let id = if this.state.opened then Some "simple-popper" else None
        let popperChildren (props : PopperProps) =
            fade [
                yield! props.TransitionProps.ToHTMLAttrList()
                yield MaterialProp.Timeout (350. |> U2.Case1)
            ] [
                paper [] [
                    typography [ HTMLAttr.Class !!this.props.classes?typography ] [
                        str "The content of the popper"
                    ]
                ] 
            ]
        div [] [
            button [
                ButtonProp.Variant ButtonVariant.Contained
                DOMAttr.OnClick this.handleClick
            ] [ str "Toggle Popper" ]
            popper [ 
                HTMLAttr.Id (Option.defaultValue null id)
                MaterialProp.Open this.state.opened
                MaterialProp.AnchorEl (this.state.anchorEl |> U2.Case1)
                PopperProp.Transition true
            ] (popperChildren |> U2.Case2) 
        ]

let simplePopper props =
    ofType<SimplePopper,_,_> props []

let simplePopperWithStyles = withStyles (StyleType.Func styles) [] simplePopper

let view () =
    ReactElementType.create simplePopperWithStyles createEmpty<IClassesProps> []