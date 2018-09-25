module Layout.Drawer

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

open App.Types
open Global
open Elmish.React.Common

module Mui = Fable.Helpers.MaterialUI

let drawerStyles : IStyles list =
    [
        Styles.Root [
            Width 250
        ]
    ]

[<Pojo>]
type AppDrawerProps =
    abstract member isLanding: bool with get,set
    abstract member currentPage: Page with get,set
    abstract member menuOpen: bool with get,set
    abstract member dispatch: (Msg->unit) with get,set
    inherit Mui.IClassesProps


let drawer (props : AppDrawerProps) =
    nav [] [
        yield Mui.hidden [
            LgUp (not props.isLanding)
            Implementation HiddenImplementation.Js
        ] [
            Mui.swipeableDrawer [
                DrawerProp.Variant DrawerVariant.Temporary
                MaterialProp.Open props.menuOpen
                MaterialProp.OnOpen (fun _ -> OpenMenu true |> props.dispatch)
                MaterialProp.OnClose (fun _ -> OpenMenu false |> props.dispatch)
                ModalProps [ KeepMounted true ]
            ] [ 
                lazyView2 Layout.Menu.view props.currentPage props.dispatch ]
        ]
        if not props.isLanding then
            yield Mui.hidden [
                MdDown true
                Implementation HiddenImplementation.Js
            ] [
                Mui.drawer [
                    DrawerProp.Variant DrawerVariant.Permanent
                    MaterialProp.Open true
                    Class !!props.classes?root
                ] [ 
                    lazyView2 Layout.Menu.view props.currentPage props.dispatch ]
            ]
    ]

let drawerWithStyles = Mui.withStyles (StyleType.Styles drawerStyles) [] drawer

let view (model : Model) dispatch =
    let props = createEmpty<AppDrawerProps>
    props.currentPage <- model.currentPage
    props.isLanding <- model.isLanding
    props.menuOpen <- model.menuOpen
    props.dispatch <- dispatch
    from drawerWithStyles props []