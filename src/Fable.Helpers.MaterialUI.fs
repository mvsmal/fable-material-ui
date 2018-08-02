module Fable.Helpers.MaterialUI

open Fable.Core
open Fable.Import
open Fable.Import.React
open Fable.Core.JsInterop
open React.Props

[<AutoOpen>]
module Props =
    //#region Themes
    type IPaletteIntention =
        abstract member light: string
        abstract member main: string
        abstract member dark: string
        abstract member contrastText: string

    [<StringEnum>]
    type PaletteType =
        | Dark
        | Light

    type IPaletteCommon =
        abstract member black: string
        abstract member white: string

    type IPaletteAction =
        abstract member active: string
        abstract member hover: string
        abstract member hoverOpacity: float
        abstract member selected: string
        abstract member disabled: string
        abstract member disabledBackground: string

    type IPaletteBackground =
        abstract member paper: string
        abstract member ``default``: string

    type IPaletteText =
        abstract member primary: string
        abstract member secondary: string
        abstract member disabled: string
        abstract member hint: string

    type IColor =
        abstract member ``50``: string
        abstract member ``100``: string
        abstract member ``200``: string
        abstract member ``300``: string
        abstract member ``400``: string
        abstract member ``500``: string
        abstract member ``600``: string
        abstract member ``700``: string
        abstract member ``800``: string
        abstract member ``900``: string
        abstract member A100: string
        abstract member A200: string
        abstract member A400: string
        abstract member A700: string

    type IPalette =
        abstract member common: IPaletteCommon
        abstract member ``type``: PaletteType
        abstract member primary: IPaletteIntention
        abstract member secondary: IPaletteIntention
        abstract member error: IPaletteIntention
        abstract member grey: IColor
        abstract member contrastThreshold: int
        abstract member getContrastText: (string->string)
        abstract member augmentColor: (IPaletteIntention->unit)
        abstract member tonalOffset: float
        abstract member text: IPaletteText
        abstract member divider: string
        abstract member background: IPaletteBackground
        abstract member action: IPaletteAction

    [<StringEnum>]
    type TextDirection =
        | Ltr
        | Rtl

    type IShape =
        abstract member borderRadius: int

    type ISpacing =
        abstract member ``unit``: int

    type ZIndex =
        abstract member mobileStepper: int
        abstract member appBar: int
        abstract member drawer: int
        abstract member modal: int
        abstract member snackbar: int
        abstract member tooltip: int

    type ITypography =
        abstract member fontSize: string
        abstract member fontWeight: int
        abstract member fontFamily: string
        abstract member letterSpacing: string
        abstract member lineHeight: string
        abstract member marginLeft: string
        abstract member color: string
        abstract member textTransform: string

    type IThemeTypography =
        abstract member round: (float->float)
        abstract member pxToRem: (float->string)
        abstract member fontFamily: string
        abstract member fontSize: string
        abstract member fontWeightLight: int
        abstract member fontWeightRegular: int
        abstract member fontWeightMedium: int
        abstract member display4: ITypography
        abstract member dispaly3: ITypography
        abstract member display2: ITypography
        abstract member display1: ITypography
        abstract member headline: ITypography
        abstract member title: ITypography
        abstract member subheading: ITypography
        abstract member body2: ITypography
        abstract member body1: ITypography
        abstract member caption: ITypography
        abstract member button: ITypography

    type ITheme =
        abstract member direction: TextDirection
        abstract member overrides: obj
        abstract member palette: IPalette
        abstract member props: obj
        abstract member shadows: string list
        abstract member typography: ITypography
        abstract member shape: IShape
        abstract member spacing: ISpacing
        abstract member zIndex: ZIndex
    //#endregion

    type IStyles = interface end

    type Styles =
        | Root of CSSProp list
        | ColorDefault of CSSProp list
        | Img of CSSProp list
        | Rounded of CSSProp list
        | Elevation0 of CSSProp list
        | Elevation1 of CSSProp list
        | Elevation2 of CSSProp list
        | Elevation3 of CSSProp list
        | Elevation4 of CSSProp list
        | Elevation5 of CSSProp list
        | Elevation6 of CSSProp list
        | Elevation7 of CSSProp list
        | Elevation8 of CSSProp list
        | Elevation9 of CSSProp list
        | Elevation10 of CSSProp list
        | Elevation11 of CSSProp list
        | Elevation12 of CSSProp list
        | Elevation13 of CSSProp list
        | Elevation14 of CSSProp list
        | Elevation15 of CSSProp list
        | Elevation16 of CSSProp list
        | Elevation17 of CSSProp list
        | Elevation18 of CSSProp list
        | Elevation19 of CSSProp list
        | Elevation20 of CSSProp list
        | Elevation21 of CSSProp list
        | Elevation22 of CSSProp list
        | Elevation23 of CSSProp list
        | Elevation24 of CSSProp list
        | Invisible of CSSProp list
        | Badge of CSSProp list
        | ColorPrimary of CSSProp list
        | ColorSecondary of CSSProp list
        | ColorError of CSSProp list
        | Label of CSSProp list
        | Text of CSSProp list
        | TextPrimary of CSSProp list
        | TextSecondary of CSSProp list
        | Flat of CSSProp list
        | FlatPrimary of CSSProp list
        | FlatSecondary of CSSProp list
        | Outlined of CSSProp list
        | OutlinedPrimary of CSSProp list
        | OutlinedSecondary of CSSProp list
        | Contained of CSSProp list
        | ContainedPrimary of CSSProp list
        | ContainedSecondary of CSSProp list
        | Raised of CSSProp list
        | RaisedPrimary of CSSProp list
        | RaisedSecondary of CSSProp list
        | Fab of CSSProp list
        | ExtendedFab of CSSProp list
        | FocusVisible of CSSProp list
        | Disabled of CSSProp list
        | ColorInherit of CSSProp list
        | Mini of CSSProp list
        | SizeSmall of CSSProp list
        | SizeLarge of CSSProp list
        | FullWidth of CSSProp list
        | PositionFixed of CSSProp list
        | PositionAbsolute of CSSProp list
        | PositionSticky of CSSProp list
        | PositionStatic of CSSProp list
        | Action of CSSProp list
        | Avatar of CSSProp list
        | Content of CSSProp list
        | Title of CSSProp list
        | Subheader of CSSProp list
        | Media of CSSProp list
        | Checked of CSSProp list
        | Clickable of CSSProp list
        | Deletable of CSSProp list
        | AvatarChildren of CSSProp list
        | DeleteIcon of CSSProp list
        | Static of CSSProp list
        | Indeterminate of CSSProp list
        | Svg of CSSProp list
        | Circle of CSSProp list
        | CircleStatic of CSSProp list
        | CircleIndeterminate of CSSProp list
        | Container of CSSProp list
        | Entered of CSSProp list
        | Wrapper of CSSProp list
        | WrapperInner of CSSProp list
        | Paper of CSSProp list
        | PaperScrollPaper of CSSProp list
        | PaperScrollBody of CSSProp list
        | PaperWidthXs of CSSProp list
        | PaperWidthSm of CSSProp list
        | PaperWidthMd of CSSProp list
        | PaperFullWidth of CSSProp list
        | PaperFullScreen of CSSProp list
        | Absolute of CSSProp list
        | Inset of CSSProp list
        | Light of CSSProp list
        | Docked of CSSProp list
        | PaperAnchorLeft of CSSProp list
        | PaperAnchorRight of CSSProp list
        | PaperAnchorTop of CSSProp list
        | PaperAnchorBottom of CSSProp list
        | PaperAnchorDockedLeft of CSSProp list
        | PaperAnchorDockedRight of CSSProp list
        | PaperAnchorDockedTop of CSSProp list
        | PaperAnchorDockedBottom of CSSProp list
        | Modal of CSSProp list
        | Expanded of CSSProp list
        | Focused of CSSProp list
        | ExpandIcon of CSSProp list
        interface IStyles

    [<Erase>]
    [<RequireQualifiedAccess>]
    type StyleType =
        | Styles of IStyles list
        | Func of (ITheme->IStyles list)

    type IClassNames = interface end

    type ClassNames =
        | Root of string
        | ColorDefault of string
        | Img of string
        | Rounded of string
        | Elevation0 of string
        | Elevation1 of string
        | Elevation2 of string
        | Elevation3 of string
        | Elevation4 of string
        | Elevation5 of string
        | Elevation6 of string
        | Elevation7 of string
        | Elevation8 of string
        | Elevation9 of string
        | Elevation10 of string
        | Elevation11 of string
        | Elevation12 of string
        | Elevation13 of string
        | Elevation14 of string
        | Elevation15 of string
        | Elevation16 of string
        | Elevation17 of string
        | Elevation18 of string
        | Elevation19 of string
        | Elevation20 of string
        | Elevation21 of string
        | Elevation22 of string
        | Elevation23 of string
        | Elevation24 of string
        | Invisible of string
        | Badge of string
        | ColorPrimary of string
        | ColorSecondary of string
        | ColorError of string
        | Text of string
        | TextPrimary of string
        | TextSecondary of string
        | Flat of string
        | FlatPrimary of string
        | FlatSecondary of string
        | Outlined of string
        | OutlinedPrimary of string
        | OutlinedSecondary of string
        | Contained of string
        | ContainedPrimary of string
        | ContainedSecondary of string
        | Raised of string
        | RaisedPrimary of string
        | RaisedSecondary of string
        | Fab of string
        | ExtendedFab of string
        | FocusVisible of string
        | Disabled of string
        | ColorInherit of string
        | Mini of string
        | SizeSmall of string
        | SizeLarge of string
        | FullWidth of string
        | PositionFixed of string
        | PositionAbsolute of string
        | PositionSticky of string
        | PositionStatic of string
        | Action of string
        | Avatar of string
        | Content of string
        | Title of string
        | Subheader of string
        | Media of string
        | Checked of string
        | Clickable of string
        | Deletable of string
        | AvatarChildren of string
        | Label of string
        | DeleteIcon of string
        | Static of string
        | Indeterminate of string
        | Svg of string
        | Circle of string
        | CircleStatic of string
        | CircleIndeterminate of string
        | Container of string
        | Entered of string
        | Wrapper of string
        | WrapperInner of string
        | ScrollPaper of string
        | ScrollBody of string
        | Paper of string
        | PaperScrollPaper of string
        | PaperScrollBody of string
        | PaperWidthXs of string
        | PaperWidthSm of string
        | PaperWidthMd of string
        | PaperFullWidth of string
        | PaperFullScreen of string
        | Absolute of string
        | Inset of string
        | Light of string
        | Docked of string
        | PaperAnchorLeft of string
        | PaperAnchorRight of string
        | PaperAnchorTop of string
        | PaperAnchorBottom of string
        | PaperAnchorDockedLeft of string
        | PaperAnchorDockedRight of string
        | PaperAnchorDockedTop of string
        | PaperAnchorDockedBottom of string
        | Modal of string
        | Expanded of string
        | Focused of string
        | ExpandIcon of string
        interface IClassNames

    type ClassesProp =
    | Classes of IClassNames list
        interface IHTMLProp
        
    [<Erase>]
    type ComponentProp<'a> =
        | Str of string
        | Func of ('a -> ReactElement)
        // ? Doesn't work with for example with Chip
        // | El of ReactElement 
    
    [<StringEnum>]
    type ComponentColor =
        | Default
        | Inherit
        | Primary
        | Secondary

    type TransitionDurationProp = 
        | Enter of float
        | Exit of float

    [<Erase>]
    type TransitionDuration =
        | Num of float
        | Custom of TransitionDurationProp list
    
    type MaterialProp<'a> =
        | Component of ComponentProp<'a>
        | Color of ComponentColor
        | DisableRipple of bool
        | Icon of ReactElement
        | DisableTypography of bool
        | PaperProps of IHTMLProp list
        | Open of bool
        | TransitionDuration of TransitionDuration
        interface IHTMLProp

    type StyleOption =
        | WithTheme of bool
        | Name of string
        | Flip of bool
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type MouseEvent =
        | OnClick
        | OnMouseDown
        | OnMouseUp

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type TouchEvent =
        | OnTouchStart
        | OnTouchEnd

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type MaterialSize =
        | Xs
        | Sm
        | Md
        | [<CompiledName("")>] False

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type Anchor =
        | Left
        | Top
        | Right
        | Bottom

module Colors =
    let red = importDefault<Props.IColor> "@material-ui/core/colors/red";
    let pink = importDefault<Props.IColor> "@material-ui/core/colors/pink";
    let purple = importDefault<Props.IColor> "@material-ui/core/colors/purple";
    let deepPurple = importDefault<Props.IColor> "@material-ui/core/colors/deepPurple";
    let indigo = importDefault<Props.IColor> "@material-ui/core/colors/indigo";
    let blue = importDefault<Props.IColor> "@material-ui/core/colors/blue";
    let lightBlue = importDefault<Props.IColor> "@material-ui/core/colors/lightBlue";
    let cyan = importDefault<Props.IColor> "@material-ui/core/colors/cyan";
    let teal = importDefault<Props.IColor> "@material-ui/core/colors/teal";
    let green = importDefault<Props.IColor> "@material-ui/core/colors/green";
    let lightGreen = importDefault<Props.IColor> "@material-ui/core/colors/lightGreen";
    let lime = importDefault<Props.IColor> "@material-ui/core/colors/lime";
    let yellow = importDefault<Props.IColor> "@material-ui/core/colors/yellow";
    let amber = importDefault<Props.IColor> "@material-ui/core/colors/amber";
    let orange = importDefault<Props.IColor> "@material-ui/core/colors/orange";
    let deepOrange = importDefault<Props.IColor> "@material-ui/core/colors/deepOrange";
    let brown = importDefault<Props.IColor> "@material-ui/core/colors/brown";
    let grey = importDefault<Props.IColor> "@material-ui/core/colors/grey";
    let blueGrey = importDefault<Props.IColor> "@material-ui/core/colors/blueGrey";

open Props

let firstCharUpper s =
    s |> String.mapi
        (fun i c -> match i with
                    | 0 -> c |> System.Char.ToUpper
                    | _ -> c)

let propertyToPascalCase (prop : string) o =
    let newProp = prop |> firstCharUpper
    o?(newProp) <- o?(prop)
    JS.Reflect.deleteProperty (o, U3.Case1 prop) |> ignore
    o

let materialElPropsList<[<Pojo>]'P when 'P :> IHTMLProp>
    (a:ComponentClass<'P>) (b: IHTMLProp list) c =
    Fable.Helpers.React.from a (keyValueList CaseRules.LowerFirst b |> unbox) c

let materialElPropsObj<[<Pojo>]'P when 'P :> IHTMLProp>
    (a:ComponentClass<'P>) b c =
    Fable.Helpers.React.from a b c

// #region AppBar
[<StringEnum>]
type AppBarPosition =
    | Fixed
    | Absolute
    | Sticky
    | Static

type AppBarProps = 
    | Position of AppBarPosition
    interface IHTMLProp

let AppBar = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/AppBar"
let inline appBar b c = materialElPropsList AppBar b c
// #endregion

// #region Avatar
type AvatarProp =
    | Alt of string
    | ImgProps of IHTMLProp list
    | Sizes of string
    | Src of string
    | SrcSet of string
    interface IHTMLProp

let Avatar = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Avatar"
let inline avatar b c = materialElPropsList Avatar b c
// #endregion

// #region Backdrop
type BackdropProp =
    | Invisible of bool
    interface IHTMLProp

let Backdrop = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Backdrop"
let inline backdrop b = materialElPropsList Backdrop b []
// #endregion

// #region Badge
[<StringEnum>]
type BadgeColor =
    | [<CompiledName("default")>]Default
    | [<CompiledName("primary")>]Primary
    | [<CompiledName("secondary")>]Secondary
    | [<CompiledName("error")>]Error

type BadgeProp =
    | Color of BadgeColor
    | BadgeContent of ReactElement
    interface IHTMLProp

let Badge = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Badge"
let inline badge b c = materialElPropsList Badge b c
// #endregion

// #region BottomNavigation
type BottomNavigationProp =
    | OnChange of (obj*obj->unit)
    | ShowLabel of bool
    | Value of obj
    interface IHTMLProp

let BottomNavigation = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/BottomNavigation"
let inline bottomNavigation b c = materialElPropsList BottomNavigation b c
// #endregion

// #region BottomNavigationAction
type BottomNavigationActionProp =
    | Label of ReactElement
    | ShowLabel of bool
    | Value of obj
    interface IHTMLProp

let BottomNavigationAction =
    importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/BottomNavigationAction"
let inline bottomNavigationAction b = materialElPropsList BottomNavigationAction b []
// #endregion

// #region Button
[<StringEnum>]
type ButtonSize =
    | Small
    | Medium
    | Large

[<StringEnum>]
type ButtonVariant =
    | Text
    | Flat
    | Outlined
    | Contained
    | Raised
    | Fab
    | ExtendedFab

type ButtonProp =
    | DisableFocusRipple of bool
    | FullWidth of bool
    | Href of string
    | Mini of bool
    | Size of ButtonSize // TODO make generic
    | Variant of ButtonVariant
    interface IHTMLProp

let Button = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Button"
let inline button b c = materialElPropsList Button b c
// #endregion

// #region ButtonBase
[<StringEnum>]
type ButtonBaseType =
    | Button
    | Submit
    | Reset

type ButtonBaseProp =
    | Action of (obj->unit) // TODO add static typing
    // ? | ButtonRef of object|func DO WE NEED REFS AT ALL?
    | CenterRipple of bool
    | DisableTouchRipple of bool
    | FocusRipple of bool
    | FocusVisibleClassName of string
    | OnFocusVisible of (obj->unit) // TODO add static typing
    | TouchRippleProps of IHTMLProp list
    | Type of ButtonBaseType
    interface IHTMLProp

let ButtonBase = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ButtonBase"
let inline buttonBase (b: IHTMLProp list) c =
    let props = keyValueList CaseRules.LowerFirst b
    let newProps = props |> propertyToPascalCase "touchRippleProps" |> unbox
    materialElPropsObj ButtonBase newProps c
// #endregion

// #region Card
type CardProp =
    | Raised of bool
    interface IHTMLProp

let Card = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Card"
let inline card b c = materialElPropsList Card b c
// #endregion

// #region CardActions
type CardActionsProp =
    | DisableActionSpacing of bool
    interface IHTMLProp

let CardActions = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/CardActions"
let inline cardActions b c = materialElPropsList CardActions b c
// #endregion

// #region CardContent
let CardContent = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/CardContent"
let cardContent b c = materialElPropsList CardContent b c
// #endregion

// #region CardHeader
type CardHeaderProp =
    | Action of ReactElement
    | Avatar of ReactElement
    | Subheader of ReactElement
    | SubheaderTypographyProps of IHTMLProp list
    | Title of ReactElement
    | TitleTypographyProps of IHTMLProp list
    interface IHTMLProp

let CardHeader = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/CardHeader"
let inline cardHeader b c = materialElPropsList CardHeader b c
// #endregion

// #region CardMedia
type CardMediaProp =
    | Image of string
    | Src of string
    interface IHTMLProp

let CardMedia = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/CardMedia"
let inline cardMedia b = materialElPropsList CardMedia b []
// #endregion

// #region Checkbox
type CheckboxProps =
    | Checked of bool
    | CheckedIcon of ReactElement
    | Indeterminate of bool
    | IndeterminateIcon of ReactElement
    | InputProps of IHTMLProp list
    // | InputRef of Func|Object
    | OnChange of (React.FormEvent*bool -> unit)
    | Type of string
    | Value of string
    interface IHTMLProp
    
let Checkbox = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Checkbox"
let inline checkbox b = materialElPropsList Checkbox b []
// #endregion

// #region Chip
[<Erase>]
type ChipLabel =
    | El of ReactElement
    | Str of string

type ChipProp =
    | Avatar of ReactElement
    | Clickable of bool
    | DeleteIcon of ReactElement
    | Label of ChipLabel
    | OnDelete of (React.FormEvent->unit)
    interface IHTMLProp

let Chip = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Chip"
let inline chip b = materialElPropsList Chip b []
// #endregion

// #region CircularProgress
[<Erase>]
type CircularProgressSize =
    | Px of int
    | Str of string

[<StringEnum>]
type CircularProgressVariant =
    | Determinate
    | Indeterminate
    | Static

type CircularProgressProp =
    | Size of CircularProgressSize
    | Thickness of float
    | Value of int // TODO validate for 0 to 100
    | Variant of CircularProgressVariant
    interface IHTMLProp

let CircularProgress = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/CircularProgress"
let inline circularProgress b = materialElPropsList CircularProgress b []
// #endregion

// #region ClickAwayListener
[<Erase>]
type ClickAwayListenerMouseEvent =
    | Event of MouseEvent
    | False

[<Erase>]
type ClickAwayListenerTouchEvent =
    | Event of TouchEvent
    | False

type ClickAwayListenerProp =
    | OnClickAway of (unit->unit)
    | MouseEvent of ClickAwayListenerMouseEvent
    | TouchEvent of ClickAwayListenerTouchEvent
    interface IHTMLProp

let ClickAwayListener =
    importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ClickAwayListener"
let inline clickAwayListener b c = materialElPropsList ClickAwayListener b c
// #endregion

// #region Collapse
[<StringEnum>]
type CollapseTimeoutEnum =
    | Auto

[<Erase>]
type CollapseTransitionDuration =
    | Num of float
    | Custom of TransitionDurationProp list
    | Enum of CollapseTimeoutEnum

type CollapseProp = 
    | CollapseHeight of string
    | In of bool
    | Timeout of CollapseTransitionDuration
    interface IHTMLProp

let Collapse = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Collapse"

let inline collapse b c = materialElPropsList Collapse b c
// #endregion

// #region CssBaseline
let CssBaseline = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/CssBaseline"
let inline cssBaseline b = materialElPropsList CssBaseline b []
// #endregion

// #region Dialog
[<StringEnum>]
type DialogScroll =
    | Body
    | Paper

type DialogProp<'a> =
    | DisableBackdropClick of bool
    | DisableEscapeKeyDown of bool
    | FullScreen of bool
    | FullWidth of bool
    | MaxWidth of MaterialSize
    | OnBackdropClick of (obj->unit)
    | OnClose of (obj->unit)
    | OnEnter of (obj->unit)
    | OnEntered of (obj->unit)
    | OnEntering of (obj->unit)
    | OnEscapeKeyDown of (obj->unit)
    | OnExit of (obj->unit)
    | OnExited of (obj->unit)
    | OnExiting of (obj->unit)
    | Scroll of DialogScroll
    | TransitionComponent of ComponentProp<'a>
    | TransitionProps of IHTMLProp list
    interface IHTMLProp

let Dialog = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Dialog"
let inline dialog (b: IHTMLProp list) c =
    let props = keyValueList CaseRules.LowerFirst b
    let newProps =
        props
        |> propertyToPascalCase "paperProps"
        |> propertyToPascalCase "transitionProps"
        |> unbox
    materialElPropsObj Dialog newProps c
// #endregion

// #region DialogActions
type DialogActionsProp =
    | DisableActionSpacing of bool
    interface IHTMLProp

let DialogActions = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/DialogActions"
let inline dialogActions b c = materialElPropsList DialogActions b c
// #endregion

// #region DialogContent
let DialogContent = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/DialogContent"
let inline dialogContent b c = materialElPropsList DialogContent b c
// #endregion

// #region DialogContentText
let DialogContentText =
    importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/DialogContentText"
let inline dialogContentText b c = materialElPropsList DialogContentText b c
// #endregion

// #region DialogTitle
let DialogTitle = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/DialogTitle"
let inline dialogTitle b c = materialElPropsList DialogTitle b c
// #endregion

// #region Divider
type DividerProp =
    | Absolute of bool
    | Inset of bool
    | Light of bool
    interface IHTMLProp

let Divider = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Divider"
let inline divider b = materialElPropsList Divider b []
// #endregion

// #region Drawer
[<StringEnum>]
type DrawerVariant =
    | Permanent
    | Persistent
    | Temporary

type DrawerProp =
    | Anchor of Anchor
    | ModalProps of IHTMLProp list
    | OnClose of (obj->unit)
    | SlideProps of IHTMLProp list
    | Variant of DrawerVariant
    interface IHTMLProp

let Drawer = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Drawer"
let inline drawer (b: IHTMLProp list) c =
    let props = keyValueList CaseRules.LowerFirst b
    let newProps =
        props
        |> propertyToPascalCase "paperProps"
        |> propertyToPascalCase "slideProps"
        |> propertyToPascalCase "modalProps"
        |> unbox
    materialElPropsObj Drawer newProps c
// #endregion

// #region ExpansionPanel
type ExpansionPanelProp =
    | Expanded of bool
    | DefaultExpanded of bool
    | OnChange of (obj*bool->unit)
    | CollapseProps of IHTMLProp list
    interface IHTMLProp

let ExpansionPanel = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ExpansionPanel"
let inline expansionPanel (b: IHTMLProp list) c =
    let props = keyValueList CaseRules.LowerFirst b
    let newProps =
        props |> propertyToPascalCase "collapseProps" |> unbox
    materialElPropsObj ExpansionPanel newProps c
// #endregion

// #region ExpansionPanelActions
let ExpansionPanelActions =
    importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ExpansionPanelActions"
let inline expansionPanelActions b c = materialElPropsList ExpansionPanelActions b c
// #endregion

// #region ExpansionPanelDetails
let ExpansionPanelDetails =
    importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ExpansionPanelDetails"
let inline expansionPanelDetails b c = materialElPropsList ExpansionPanelDetails b c
// #endregion

// #region ExpansionPanelSummary
type ExpansionPanelSummaryProp =
    | ExpandIcon of ReactElement
    | IconButtonProps of IHTMLProp list
    interface IHTMLProp

let ExpansionPanelSummary =
    importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ExpansionPanelSummary"
let inline expansionPanelSummary (b: IHTMLProp list) c =
    let props = keyValueList CaseRules.LowerFirst b
    let newProps =
        props |> propertyToPascalCase "iconButtonProps" |> unbox
    materialElPropsObj ExpansionPanelSummary newProps c
// #endregion

// #region Paper
type PaperProp =
    | Elevation of int
    | Square of bool
    interface IHTMLProp
let Paper = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Paper"
let inline paper b c = materialElPropsList Paper b c
// #endregion

// #region withStyles
[<Import("withStyles", "@material-ui/core/styles")>]
let private withStyles'<'S, [<Pojo>]'P, [<Pojo>]'O>
    (styles: 'S) (options: 'O) : (('P->ReactElement)->ComponentClass<'P>) = jsNative

let withStyles<[<Pojo>]'P, 'S>
    (styles : StyleType)
    (options: StyleOption list)
    (fn : 'P -> ReactElement)
    (props : IHTMLProp list)
    children =
    let styles' =
        match styles with
        | StyleType.Styles styles -> (keyValueList CaseRules.LowerFirst styles |> unbox)
        | StyleType.Func func -> func >> keyValueList CaseRules.LowerFirst
    Fable.Helpers.React.from 
        (withStyles' styles' (keyValueList CaseRules.LowerFirst options |> unbox) fn)
        (keyValueList CaseRules.LowerFirst props |> unbox)
        children
// #endregion

// #region ThemeProvider
type PaletteCommonProp =
    | Black of string
    | White of string

type PaletteIntentionProp =
    | Light of string
    | Main of string
    | Dark of string
    | ContrastText of string

type ColorType () =
    static member ``50`` = "50"
    static member ``100`` = "100"
    static member ``200`` = "200"
    static member ``300`` = "300"
    static member ``400`` = "400"
    static member ``500`` = "500"
    static member ``600`` = "600"
    static member ``700`` = "700"
    static member ``800`` = "800"
    static member ``900`` = "900"
    static member A100 = "A100"
    static member A200 = "A200"
    static member A400 = "A400"
    static member A700 = "A700"

type PaletteTextProp =
    | Primary of string
    | Secondary of string
    | Disabled of string
    | Hint of string

type PaletteBackgroundProp =
    | Paper of string
    | Default of string

type PaletteActionProp =
    | Active of string
    | Hover of string
    | HoverOpacity of float
    | Selected of string
    | Disabled of string
    | DisabledBackground of string

type PaletteProp =
    | Common of PaletteCommonProp list
    | Type of PaletteType
    | Primary of PaletteIntentionProp list
    | Secondary of PaletteIntentionProp list
    | Error of PaletteIntentionProp list
    | Grey of (string*obj) list
    | ContrastThreshold of int
    | TonalOffset of float
    | Text of PaletteTextProp list
    | Divider of string
    | Background of PaletteBackgroundProp list
    | Action of PaletteActionProp list

type TextStyleProp =
    | FontFamily of string
    | Color of string
    | FontSize of string
    | FontWeight of string
    | LetterSpacing of string
    | LineHeight of string
    | TextTransform of string

type TypographyProp =
    | FontFamily of string
    | HtmlFontSize of string
    | FontSize of string
    | FontWeightLight of int
    | FontWeightRegular of int
    | FontWeightMedium of int
    | Display4 of TextStyleProp list
    | Display3 of TextStyleProp list
    | Display2 of TextStyleProp list
    | Display1 of TextStyleProp list
    | Headline of TextStyleProp list
    | Title of TextStyleProp list
    | Subheading of TextStyleProp list
    | Body2 of TextStyleProp list
    | Body1 of TextStyleProp list
    | Caption of TextStyleProp list
    | Button of TextStyleProp list

type ShapeProp =
    | BorderRadius of int

type SpacingProp =
    | Unit of int

type ZIndexProp =
    | AppBar of int
    | Drawer of int
    | MobileStepper of int
    | Modal of int
    | Snackbar of int
    | Tooltip of int

// TODO keep the list up to date with the implemented components
type OverridesProp =
    | MuiAppBar of IStyles list
    | MuiAvatar of IStyles list
    | MuiBackdrop of IStyles list
    | MuiBadge of IStyles list
    | MuiBottomNavigation of IStyles list
    | MuiBottomNavigationAction of IStyles list
    | MuiButton of IStyles list
    | MuiButtonBase of IStyles list
    | MuiCard of IStyles list
    | MuiCardActions of IStyles list
    | MuiCardContent of IStyles list
    | MuiCardHeader of IStyles list
    | MuiCardMedia of IStyles list
    | MuiCheckbox of IStyles list
    | MuiChip of IStyles list
    | MuiCircularProgress of IStyles list
    | MuiCollapse of IStyles list
    | MuiDialog of IStyles list
    | MuiDialogActions of IStyles list
    | MuiDialogContent of IStyles list
    | MuiDialogContentText of IStyles list
    | MuiDivider of IStyles list
    | MuiDrawer of IStyles list
    | MuiExpansionPanel of IStyles list
    | MuiExpansionPanelActions of IStyles list
    | MuiExpansionPanelDetails of IStyles list
    | MuiExpansionPanelSummary of IStyles list
    | MuiPaper of IStyles list

// TODO implement breakpoints, mixins, transitions?
type ThemeProp =
    | Direction of TextDirection
    | Palette of PaletteProp list
    | Shadows of string list
    | Shape of ShapeProp list
    | Spacing of SpacingProp list
    | Typography of TypographyProp list
    | ZIndex of ZIndexProp list
    | Overrides of OverridesProp list

[<Erase>]
type ProviderTheme =
    | Theme of ITheme
    | Func of (ITheme->ThemeProp list)

type MuiThemeProviderProp =
    | Theme of ProviderTheme
    | DisableStylesGeneration of bool
    interface IHTMLProp

let MuiThemeProvider = importMember<ComponentClass<IHTMLProp>> "@material-ui/core/styles"
let inline muiThemeProvider b c = materialElPropsList MuiThemeProvider b c

[<Import("createMuiTheme", "@material-ui/core/styles")>]
let private createMuiTheme'<[<Pojo>]'O> (options: 'O) : ITheme = jsNative

let createMuiTheme (options: ThemeProp list) =
    let op = (keyValueList CaseRules.LowerFirst options |> unbox)
    let result = createMuiTheme' op
    result
// #endregion







