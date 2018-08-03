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

    [<StringEnum; RequireQualifiedAccess>]
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

    [<StringEnum; RequireQualifiedAccess>]
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
        | ColorInherit of CSSProp list
        | ColorPrimary of CSSProp list
        | ColorSecondary of CSSProp list
        | ColorAction of CSSProp list
        | ColorError of CSSProp list
        | ColorDisabled of CSSProp list
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
        | MarginNormal of CSSProp list
        | MarginDense of CSSProp list
        | LabelPlacementStart of CSSProp list
        | Row of CSSProp list
        | Error of CSSProp list
        | Asterisk of CSSProp list
        | Item of CSSProp list
        | ZeroMinWidth of CSSProp list
        | ``Direction-xs-column`` of CSSProp list
        | ``Direction-xs-column-reverse`` of CSSProp list
        | ``Direction-xs-row-reverse`` of CSSProp list
        | ``Wrap-xs-nowrap`` of CSSProp list
        | ``Wrap-xs-wrap-reverse`` of CSSProp list
        | ``Align-items-xs-center`` of CSSProp list
        | ``Align-items-xs-flex-start`` of CSSProp list
        | ``Align-items-xs-flex-end`` of CSSProp list
        | ``Align-items-xs-baseline`` of CSSProp list
        | ``Align-content-xs-center`` of CSSProp list
        | ``Align-content-xs-flex-start`` of CSSProp list
        | ``Align-content-xs-flex-end`` of CSSProp list
        | ``Align-content-xs-space-between`` of CSSProp list
        | ``Align-content-xs-space-around`` of CSSProp list
        | ``Justify-xs-center`` of CSSProp list
        | ``Justify-xs-flex-end`` of CSSProp list
        | ``Justify-xs-space-between`` of CSSProp list
        | ``Justify-xs-space-around`` of CSSProp list
        | ``Justify-xs-space-evenly`` of CSSProp list
        | ``Spacing-xs-8`` of CSSProp list
        | ``Spacing-xs-16`` of CSSProp list
        | ``Spacing-xs-24`` of CSSProp list
        | ``Spacing-xs-32`` of CSSProp list
        | ``Spacing-xs-40`` of CSSProp list
        | ``Grid-xs-auto`` of CSSProp list
        | ``Grid-xs-true`` of CSSProp list
        | ``Grid-xs-1`` of CSSProp list
        | ``Grid-xs-2`` of CSSProp list
        | ``Grid-xs-3`` of CSSProp list
        | ``Grid-xs-4`` of CSSProp list
        | ``Grid-xs-5`` of CSSProp list
        | ``Grid-xs-6`` of CSSProp list
        | ``Grid-xs-7`` of CSSProp list
        | ``Grid-xs-8`` of CSSProp list
        | ``Grid-xs-9`` of CSSProp list
        | ``Grid-xs-10`` of CSSProp list
        | ``Grid-xs-11`` of CSSProp list
        | ``Grid-xs-12`` of CSSProp list
        | Tile of CSSProp list
        | ImgFullHeight of CSSProp list
        | ImgFullWidth of CSSProp list
        | TitlePositionBottom of CSSProp list
        | TitlePositionTop of CSSProp list
        | RootSubtitle of CSSProp list
        | TitleWrap of CSSProp list
        | TitleWrapActionPosLeft of CSSProp list
        | TitleWrapActionPosRight of CSSProp list
        | Subtitle of CSSProp list
        | ActionIcon of CSSProp list
        | ActionIconActionPosLeft of CSSProp list
        | FontSizeInherit of CSSProp list
        | FormControl of CSSProp list
        | Underline of CSSProp list
        | Multiline of CSSProp list
        | Input of CSSProp list
        | InputMarginDense of CSSProp list
        | InputMultiline of CSSProp list
        | InputType of CSSProp list
        | InputTypeSearch of CSSProp list
        | PositionStart of CSSProp list
        | PositionEnd of CSSProp list
        | Shrink of CSSProp list
        | Animated of CSSProp list
        | Bar of CSSProp list
        | BarColorPrimary of CSSProp list
        | BarColorSecondary of CSSProp list
        | Bar1Indeterminate of CSSProp list
        | Bar1Determinate of CSSProp list
        | Bar1Buffer of CSSProp list
        | Bar2Indeterminate of CSSProp list
        | Bar2Determinate of CSSProp list
        | Bar2Buffer of CSSProp list
        | Padding of CSSProp list
        | Dense of CSSProp list
        | Default of CSSProp list
        | Divider of CSSProp list
        | Gutters of CSSProp list
        | Button of CSSProp list
        | SecondaryAction of CSSProp list
        | Icon of CSSProp list
        | Primary of CSSProp list
        | Secondary of CSSProp list
        | TextDense of CSSProp list
        | Sticky of CSSProp list
        | Selected of CSSProp list
        interface IStyles

    [<Erase; RequireQualifiedAccess>]
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
        | ColorInherit of string
        | ColorPrimary of string
        | ColorSecondary of string
        | ColorAction of string
        | ColorError of string
        | ColorDisabled of string
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
        | MarginNormal of string
        | MarginDense of string
        | LabelPlacementStart of string
        | Row of string
        | Error of string
        | Asterisk of string
        | Item of string
        | ZeroMinWidth of string
        | ``Direction-xs-column`` of string
        | ``Direction-xs-column-reverse`` of string
        | ``Direction-xs-row-reverse`` of string
        | ``Wrap-xs-nowrap`` of string
        | ``Wrap-xs-wrap-reverse`` of string
        | ``Align-items-xs-center`` of string
        | ``Align-items-xs-flex-start`` of string
        | ``Align-items-xs-flex-end`` of string
        | ``Align-items-xs-baseline`` of string
        | ``Align-content-xs-center`` of string
        | ``Align-content-xs-flex-start`` of string
        | ``Align-content-xs-flex-end`` of string
        | ``Align-content-xs-space-between`` of string
        | ``Align-content-xs-space-around`` of string
        | ``Justify-xs-center`` of string
        | ``Justify-xs-flex-end`` of string
        | ``Justify-xs-space-between`` of string
        | ``Justify-xs-space-around`` of string
        | ``Justify-xs-space-evenly`` of string
        | ``Spacing-xs-8`` of string
        | ``Spacing-xs-16`` of string
        | ``Spacing-xs-24`` of string
        | ``Spacing-xs-32`` of string
        | ``Spacing-xs-40`` of string
        | ``Grid-xs-auto`` of string
        | ``Grid-xs-true`` of string
        | ``Grid-xs-1`` of string
        | ``Grid-xs-2`` of string
        | ``Grid-xs-3`` of string
        | ``Grid-xs-4`` of string
        | ``Grid-xs-5`` of string
        | ``Grid-xs-6`` of string
        | ``Grid-xs-7`` of string
        | ``Grid-xs-8`` of string
        | ``Grid-xs-9`` of string
        | ``Grid-xs-10`` of string
        | ``Grid-xs-11`` of string
        | ``Grid-xs-12`` of string
        | Tile of string
        | ImgFullHeight of string
        | ImgFullWidth of string
        | TitlePositionBottom of string
        | TitlePositionTop of string
        | RootSubtitle of string
        | TitleWrap of string
        | TitleWrapActionPosLeft of string
        | TitleWrapActionPosRight of string
        | Subtitle of string
        | ActionIcon of string
        | ActionIconActionPosLeft of string
        | FontSizeInherit of string
        | FormControl of string
        | Underline of string
        | Multiline of string
        | Input of string
        | InputMarginDense of string
        | InputMultiline of string
        | InputType of string
        | InputTypeSearch of string
        | PositionStart of string
        | PositionEnd of string
        | Shrink of string
        | Animated of string
        | Buffer of string
        | Query of string
        | Dashed of string
        | DashedColorPrimary of string
        | DashedColorSecondary of string
        | Bar of string
        | BarColorPrimary of string
        | BarColorSecondary of string
        | Bar1Indeterminate of string
        | Bar1Determinate of string
        | Bar1Buffer of string
        | Bar2Indeterminate of string
        | Bar2Determinate of string
        | Bar2Buffer of string
        | Padding of string
        | Dense of string
        | Default of string
        | Divider of string
        | Gutters of string
        | Button of string
        | SecondaryAction of string
        | Icon of string
        | Primary of string
        | Secondary of string
        | TextDense of string
        | Sticky of string
        | Selected of string
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
    
    [<StringEnum; RequireQualifiedAccess>]
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
    
    [<StringEnum; RequireQualifiedAccess>]
    type FormControlMargin =
        | None
        | Dense
        | Normal

    type MaterialProp<'a> =
        | Component of ComponentProp<'a>
        | Color of ComponentColor
        | DisableRipple of bool
        | Icon of ReactElement
        | DisableTypography of bool
        | [<CompiledName("PaperProps")>] PaperProps of IHTMLProp list
        | Open of bool
        | TransitionDuration of TransitionDuration
        | In of bool
        | FullWidth of bool
        | Label of ReactElement
        | Error of bool
        | Margin of FormControlMargin
        | Dense of bool
        | Inset of bool
        | OnClose of (obj->unit)
        | OnEnter of (obj->unit)
        | OnEntered of (obj->unit)
        | OnEntering of (obj->unit)
        | OnExit of (obj->unit)
        | OnExited of (obj->unit)
        | OnExiting of (obj->unit)
        interface IHTMLProp

    type StyleOption =
        | WithTheme of bool
        | Name of string
        | Flip of bool
    
    [<StringEnum; RequireQualifiedAccess>]
    type MouseEvent =
        | OnClick
        | OnMouseDown
        | OnMouseUp

    [<StringEnum; RequireQualifiedAccess>]
    type TouchEvent =
        | OnTouchStart
        | OnTouchEnd

    [<StringEnum; RequireQualifiedAccess>]
    type MaterialSize =
        | Xs
        | Sm
        | Md
        | Lg
        | Xl

    [<StringEnum; RequireQualifiedAccess>]
    type Anchor =
        | Left
        | Top
        | Right
        | Bottom
    
    [<StringEnum; RequireQualifiedAccess>]
    type AutoEnum =
        | Auto

    type AutoTransitionDuration = U3<float, TransitionDuration list, AutoEnum>

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
open System.Runtime.InteropServices

let materialEl<[<Pojo>]'P when 'P :> IHTMLProp>
    (a:ComponentClass<'P>) (b: IHTMLProp list) c =
    Fable.Helpers.React.from a (keyValueList CaseRules.LowerFirst b |> unbox) c

// #region AppBar
[<StringEnum; RequireQualifiedAccess>]
type AppBarPosition =
    | Fixed
    | Absolute
    | Sticky
    | Static

type AppBarProp = 
    | Position of AppBarPosition
    interface IHTMLProp

let AppBar = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/AppBar"
let inline appBar b c = materialEl AppBar b c
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
let inline avatar b c = materialEl Avatar b c
// #endregion

// #region Backdrop
type BackdropProp =
    | Invisible of bool
    interface IHTMLProp

let Backdrop = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Backdrop"
let inline backdrop b = materialEl Backdrop b []
// #endregion

// #region Badge
[<StringEnum; RequireQualifiedAccess>]
type BadgeColor =
    | Default
    | Primary
    | Secondary
    | Error

type BadgeProp =
    | Color of BadgeColor
    | BadgeContent of ReactElement
    interface IHTMLProp

let Badge = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Badge"
let inline badge b c = materialEl Badge b c
// #endregion

// #region BottomNavigation
type BottomNavigationProp =
    | OnChange of (obj*obj->unit)
    | ShowLabel of bool
    | Value of obj
    interface IHTMLProp

let BottomNavigation = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/BottomNavigation"
let inline bottomNavigation b c = materialEl BottomNavigation b c
// #endregion

// #region BottomNavigationAction
type BottomNavigationActionProp =
    | ShowLabel of bool
    | Value of obj
    interface IHTMLProp

let BottomNavigationAction =
    importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/BottomNavigationAction"
let inline bottomNavigationAction b = materialEl BottomNavigationAction b []
// #endregion

// #region Button
[<StringEnum; RequireQualifiedAccess>]
type ButtonSize =
    | Small
    | Medium
    | Large

[<StringEnum; RequireQualifiedAccess>]
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
    | Href of string
    | Mini of bool
    | Size of ButtonSize // TODO make generic
    | Variant of ButtonVariant
    interface IHTMLProp

let Button = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Button"
let inline button b c = materialEl Button b c
// #endregion

// #region ButtonBase
[<StringEnum; RequireQualifiedAccess>]
type ButtonBaseType =
    | Button
    | Submit
    | Reset

type ButtonBaseProp =
    | Action of (obj->unit) // TODO add static typing
    | ButtonRef of (obj->unit)
    | CenterRipple of bool
    | DisableTouchRipple of bool
    | FocusRipple of bool
    | FocusVisibleClassName of string
    | OnFocusVisible of (obj->unit) // TODO add static typing
    | [<CompiledName("TouchRippleProps")>] TouchRippleProps of IHTMLProp list
    | Type of ButtonBaseType
    interface IHTMLProp

let ButtonBase = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ButtonBase"
let inline buttonBase b c = materialEl ButtonBase b c
// #endregion

// #region Card
type CardProp =
    | Raised of bool
    interface IHTMLProp

let Card = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Card"
let inline card b c = materialEl Card b c
// #endregion

// #region CardActions
type CardActionsProp =
    | DisableActionSpacing of bool
    interface IHTMLProp

let CardActions = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/CardActions"
let inline cardActions b c = materialEl CardActions b c
// #endregion

// #region CardContent
let CardContent = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/CardContent"
let cardContent b c = materialEl CardContent b c
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
let inline cardHeader b c = materialEl CardHeader b c
// #endregion

// #region CardMedia
type CardMediaProp =
    | Image of string
    | Src of string
    interface IHTMLProp

let CardMedia = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/CardMedia"
let inline cardMedia b = materialEl CardMedia b []
// #endregion

// #region Checkbox
type CheckboxProp =
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
let inline checkbox b = materialEl Checkbox b []
// #endregion

// #region Chip
type ChipProp =
    | Avatar of ReactElement
    | Clickable of bool
    | DeleteIcon of ReactElement
    | OnDelete of (React.FormEvent->unit)
    interface IHTMLProp

let Chip = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Chip"
let inline chip b = materialEl Chip b []
// #endregion

// #region CircularProgress
[<Erase>]
type CircularProgressSize =
    | Px of int
    | Str of string

[<StringEnum; RequireQualifiedAccess>]
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
let inline circularProgress b = materialEl CircularProgress b []
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
let inline clickAwayListener b c = materialEl ClickAwayListener b c
// #endregion

// #region Collapse
type CollapseProp = 
    | CollapseHeight of string
    | Timeout of AutoTransitionDuration
    interface IHTMLProp

let Collapse = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Collapse"

let inline collapse b c = materialEl Collapse b c
// #endregion

// #region CssBaseline
let CssBaseline = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/CssBaseline"
let inline cssBaseline b = materialEl CssBaseline b []
// #endregion

// #region Dialog
[<StringEnum; RequireQualifiedAccess>]
type DialogScroll =
    | Body
    | Paper

[<StringEnum; RequireQualifiedAccess>]
type DialogMaxWidth =
    | Xs
    | Sm
    | Md
    | [<CompiledName("")>] False

type DialogProp<'a> =
    | DisableBackdropClick of bool
    | DisableEscapeKeyDown of bool
    | FullScreen of bool
    | MaxWidth of DialogMaxWidth
    | OnBackdropClick of (obj->unit)
    | OnEscapeKeyDown of (obj->unit)
    | Scroll of DialogScroll
    | [<CompiledName("TransitionComponent")>] TransitionComponent of ComponentProp<'a>
    | [<CompiledName("TransitionProps")>] TransitionProps of IHTMLProp list
    interface IHTMLProp

let Dialog = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Dialog"
let inline dialog b c = materialEl Dialog b c
// #endregion

// #region DialogActions
type DialogActionsProp =
    | DisableActionSpacing of bool
    interface IHTMLProp

let DialogActions = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/DialogActions"
let inline dialogActions b c = materialEl DialogActions b c
// #endregion

// #region DialogContent
let DialogContent = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/DialogContent"
let inline dialogContent b c = materialEl DialogContent b c
// #endregion

// #region DialogContentText
let DialogContentText =
    importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/DialogContentText"
let inline dialogContentText b c = materialEl DialogContentText b c
// #endregion

// #region DialogTitle
let DialogTitle = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/DialogTitle"
let inline dialogTitle b c = materialEl DialogTitle b c
// #endregion

// #region Divider
type DividerProp =
    | Absolute of bool
    | Light of bool
    interface IHTMLProp

let Divider = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Divider"
let inline divider b = materialEl Divider b []
// #endregion

// #region Drawer
[<StringEnum; RequireQualifiedAccess>]
type DrawerVariant =
    | Permanent
    | Persistent
    | Temporary

type DrawerProp =
    | Anchor of Anchor
    | [<CompiledName("ModalProps")>] ModalProps of IHTMLProp list
    | [<CompiledName("SlideProps")>] SlideProps of IHTMLProp list
    | Variant of DrawerVariant
    interface IHTMLProp

let Drawer = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Drawer"
let inline drawer b c = materialEl Drawer b c
// #endregion

// #region ExpansionPanel
type ExpansionPanelProp =
    | Expanded of bool
    | DefaultExpanded of bool
    | OnChange of (obj*bool->unit)
    | [<CompiledName("CollapseProps")>] CollapseProps of IHTMLProp list
    interface IHTMLProp

let ExpansionPanel = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ExpansionPanel"
let inline expansionPanel b c = materialEl b c
// #endregion

// #region ExpansionPanelActions
let ExpansionPanelActions =
    importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ExpansionPanelActions"
let inline expansionPanelActions b c = materialEl ExpansionPanelActions b c
// #endregion

// #region ExpansionPanelDetails
let ExpansionPanelDetails =
    importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ExpansionPanelDetails"
let inline expansionPanelDetails b c = materialEl ExpansionPanelDetails b c
// #endregion

// #region ExpansionPanelSummary
type ExpansionPanelSummaryProp =
    | ExpandIcon of ReactElement
    | [<CompiledName("IconButtonProps")>] IconButtonProps of IHTMLProp list
    interface IHTMLProp

let ExpansionPanelSummary =
    importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ExpansionPanelSummary"
let inline expansionPanelSummary b c = materialEl ExpansionPanelSummary b c
// #endregion

// #region Fade
type FadeProp =
    | Timeout of TransitionDuration
    interface IHTMLProp

let Fade = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Fade"
let inline fade b c = materialEl Fade b c
// #endregion

// #region FormControl
let FormControl = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/FormControl"
let inline formControl b c = materialEl FormControl b c
// #endregion

// #region FormControlLabel
[<StringEnum; RequireQualifiedAccess>]
type FormControlLabelPlacement =
    | End
    | Start

type FormControlLabelProp =
    | Control of ReactElement
    | LabelPlacement of FormControlLabelPlacement
    | OnChange of (obj*bool->unit)
    interface IHTMLProp

let FormControlLabel = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/FormControlLabel"
let inline formControlLabel b c = materialEl FormControlLabel b c
// #endregion

// #region FormGroup
type FormGroupProp =
    | Row of bool
    interface IHTMLProp

let FormGroup = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/FormGroup"
let inline formGroup b c = materialEl FormGroup b c
// #endregion

// #region FormHelperText
let FormHelperText = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/FormHelperText"
let inline formHelperText b c = materialEl FormHelperText b c
// #endregion

// #region FormLabel
type FormLabelProp =
    | Focused of bool
    interface IHTMLProp

let FormLabel = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/FormLabel"
let inline formLabel b c = materialEl FormLabel b c
// #endregion

// #region Grid
[<StringEnum; RequireQualifiedAccess>]
type AlignContent =
    | Stretch
    | Center
    | [<CompiledName("flex-start")>] FlexStart
    | [<CompiledName("flex-end")>] FlexEnd
    | [<CompiledName("space-between")>] SpaceBetween
    | [<CompiledName("space-around")>] SpaceAround

[<StringEnum; RequireQualifiedAccess>]
type Justify =
    | Center
    | [<CompiledName("flex-start")>] FlexStart
    | [<CompiledName("flex-end")>] FlexEnd
    | [<CompiledName("space-between")>] SpaceBetween
    | [<CompiledName("space-around")>] SpaceAround
    | [<CompiledName("space-evenly")>] SpaceEvenly

[<StringEnum; RequireQualifiedAccess>]
type AlignItems =
    | Stretch
    | Center
    | BaseLine
    | [<CompiledName("flex-start")>] FlexStart
    | [<CompiledName("flex-end")>] FlexEnd

[<StringEnum; RequireQualifiedAccess>]
type Direction =
    | Row
    | Column
    | [<CompiledName("row-reverse")>] RowReverse
    | [<CompiledName("column-reverse")>] ColumnReverse

[<RequireQualifiedAccess>]
type Spacing =
    | ``0`` = 0
    | ``8`` = 8
    | ``16`` = 16
    | ``24`` = 24
    | ``32`` = 32
    | ``40`` = 40

[<StringEnum; RequireQualifiedAccess>]
type Wrap =
    | Nowrap
    | Wrap
    | [<CompiledName("wrap-reverse")>] WrapReverse

[<RequireQualifiedAccess>]
type GridSizeNum =
    | ``1`` = 1
    | ``2`` = 2
    | ``3`` = 3
    | ``4`` = 4
    | ``5`` = 5
    | ``6`` = 6
    | ``7`` = 7
    | ``8`` = 8
    | ``9`` = 9
    | ``10`` = 10
    | ``11`` = 11
    | ``12`` = 12

type GridSize = U3<bool, AutoEnum, GridSizeNum>

type GridProp =
    | AlignContent of AlignContent
    | AlignItems of AlignItems
    | Container of bool
    | Direction of Direction
    | Item of bool
    | Justify of Justify
    | Lg of GridSize
    | Md of GridSize
    | Sm of GridSize
    | Xl of GridSize
    | Xs of GridSize
    | Spacing of Spacing
    | Wrap of Wrap
    | ZeroMinWidth of bool
    interface IHTMLProp

let Grid = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Grid"
let inline grid b c = materialEl Grid b c
// #endregion

// #region GridList
type GridListCellHeight = U2<int, AutoEnum>
type GridListProp =
    | CellHeight of GridListCellHeight
    | Spacing of int
    interface IHTMLProp

let GridList = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/GridList"
let inline gridList b c = materialEl GridList b c
// #endregion

// #region GridListTile
let GridListTile = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/GridListTile"
let inline gridListTile b c = materialEl GridListTile b c
// #endregion

// #region GridListTileBar
[<StringEnum; RequireQualifiedAccess>]
type ActionPosition =
    | Left
    | Right

[<StringEnum; RequireQualifiedAccess>]
type TitlePosition =
    | Top
    | Bottom

type GridListTileBarProp =
    | ActionIcon of ReactElement
    | ActionPosition of ActionPosition
    | Subtitle of ReactElement
    | Title of ReactElement
    | TitlePosition of TitlePosition
    interface IHTMLProp

let GridListTileBar = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/GridListTileBar"
let inline gridListTileBar b c = materialEl GridListTileBar b c 
// #endregion

// #region Grow
type GrowProp =
    | Timeout of AutoTransitionDuration
    interface IHTMLProp

let Grow = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Grow"
let inline grow b c = materialEl Grow b c
// #endregion

// #region Hidden
[<StringEnum; RequireQualifiedAccess>]
type HiddenImplementation =
    | Js
    | Css

type HiddenOnly = U2<MaterialSize, MaterialSize list>

type HiddenProp =
    | Implementation of HiddenImplementation
    | InitialWidth of MaterialSize
    | LgDown of bool
    | LgUp of bool
    | MdDown of bool
    | MdUp of bool
    | Only of HiddenOnly
    | SmDown of bool
    | SmUp of bool
    | XlDown of bool
    | XlUp of bool
    | XsDown of bool
    | XsUp of bool
    interface IHTMLProp

let Hidden = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Hidden"
let inline hidden b c = materialEl Hidden b c
// #endregion

// #region Icon
[<StringEnum; RequireQualifiedAccess>]
type IconColor =
    | Inherit
    | Primary
    | Secondary
    | Action
    | Error
    | Disabled

[<StringEnum; RequireQualifiedAccess>]
type IconFontSize =
    | Inherit
    | Default

type IconProp =
    | Color of IconColor
    | FontSize of IconFontSize
    interface IHTMLProp

let Icon = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Icon"
let inline icon b c = materialEl Icon b c
// #endregion

// #region IconButton
let IconButton = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/IconButton"
let inline iconButton b c = materialEl IconButton b c
// #endregion

// #region Input
[<StringEnum; RequireQualifiedAccess>]
type InputMargin =
    | None
    | Dense

type InputProp<'a> =
    | DisableUnderline of bool
    | EndAdornment of ReactElement
    | InputComponent of ComponentProp<'a>
    | InputProps of IHTMLProp list
    // TODO | InputRef
    | Multiline of bool
    | RowsMax of int
    | StartAdornment of ReactElement
    interface IHTMLProp

let Input = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Input"
let inline input b = materialEl Input b []
// #endregion

// #region InputAdornment
[<StringEnum; RequireQualifiedAccess>]
type InputAdornmentPosition =
    | Start
    | End

type InputAdornmentProp =
    | Position of InputAdornmentPosition
    interface IHTMLProp

let InputAdornment = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/InputAdornment"
let inline inputAdornment b c = materialEl InputAdornment b c
// #endregion

// #region InputLabel
[<StringEnum; RequireQualifiedAccess>]
type InputLabelMargin =
    | Dense

type InputLabelProp =
    | DisableAnimation of bool
    | [<CompiledName("FormLabelClasses")>] FormLabelClasses of IStyles list
    | Margin of InputLabelMargin
    | Shrink of bool
    interface IHTMLProp

let InputLabel = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/InputLabel"
let inline inputLabel b c = materialEl InputLabel b c
// #endregion

// #region LinearProgress
[<StringEnum; RequireQualifiedAccess>]
type LinearProgressColor =
    | Primary
    | Secondary

[<StringEnum; RequireQualifiedAccess>]
type LinearProgressVariant =
    | Determinate
    | Indeterminate
    | Buffer
    | Query

type LinearProgressProp =
    | Color of LinearProgressColor
    | ValueBuffer of int
    | Variant of LinearProgressVariant
    interface IHTMLProp

let LinearProgress = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/LinearProgress"
let inline linearProgress b = materialEl LinearProgress b []
// #endregion

// #region List
type ListProp =
    | DisablePadding of bool
    | Subheader of ReactElement
    interface IHTMLProp

let List = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/List"
let inline list b c = materialEl List b c
// #endregion

// #region ListItem
type ListItemProp<'a> = 
    | Button of bool
    | [<CompiledName("ContainerComponent")>] ContainerComponent of ComponentProp<'a>
    | [<CompiledName("ContainerProps")>] ContainerProps of IHTMLProp list
    | DisableGutters of bool
    | Divider of bool
    interface IHTMLProp

let ListItem = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ListItem"
let inline listItem b c = materialEl ListItem b c
// #endregion

// #region ListItemAvatar
let ListItemAvatar = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ListItemAvatar"
let inline listItemAvatar b c = materialEl ListItemAvatar b c
// #endregion

// #region ListItemIcon
let ListItemIcon = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ListItemIcon"
let inline listItemIcon b c = materialEl ListItemIcon b c
// #endregion

// #region ListItemSecondaryAction
let ListItemSecondaryAction =
    importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ListItemSecondaryAction"
let inline listItemSecondaryAction b c = materialEl ListItemSecondaryAction b c
// #endregion

// #region ListItemText
type ListItemTextProp =
    | Primary of ReactElement
    | PrimaryTypographyProps of IHTMLProp list
    | Secondary of ReactElement
    | SecondaryTypographyProps of IHTMLProp list
    interface IHTMLProp

let ListItemText = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ListItemText"
let inline listItemText b c = materialEl ListItemText b c
// #endregion

// #region ListSubheader
[<StringEnum; RequireQualifiedAccess>]
type ListSubheaderColor =
    | Default
    | Primary
    | Inherit

type ListSubheaderProp =
    | Color of ListSubheaderColor
    | DisableSticky of bool
    interface IHTMLProp

let ListSubheader = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ListSubheader"
let inline listSubheader b c = materialEl ListSubheader b c
// #endregion

// #region Menu
type MenuProp =
    | AnchorEl of obj
    | DisableAutoFocusItem of bool
    | [<CompiledName("MenuListProps")>] MenuListProps of IHTMLProp list
    | [<CompiledName("PopoverClasses")>] PopoperClasses of IClassNames list
    | TransitionDuration of AutoTransitionDuration
    interface IHTMLProp

let Menu = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Menu"
let inline menu b c = materialEl Menu b c
// #endregion

// #region MenuItem
type MenuItemProp =
    | Selected of bool
    interface IHTMLProp

let MenuItem = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/MenuItem"
let inline menuItem b c = materialEl MenuItem b c
// #endregion

// #region MenuList
let MenuList = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/MenuList"
let inline menuList b c = materialEl MenuList b c
// #endregion

// #region Paper
type PaperProp =
    | Elevation of int
    | Square of bool
    interface IHTMLProp
let Paper = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Paper"
let inline paper b c = materialEl Paper b c
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
    | MuiFormControl of IStyles list
    | MuiFormControlLabel of IStyles list
    | MuiFormGroup of IStyles list
    | MuiFormHelperText of IStyles list
    | MuiFormLabel of IStyles list
    | MuiGrid of IStyles list
    | MuiGridList of IStyles list
    | MuiGridListTile of IStyles list
    | MuiGridListTileBar of IStyles list
    | MuiIcon of IStyles list
    | MuiIconButton of IStyles list
    | MuiInput of IStyles list
    | MuiInputAdornment of IStyles list
    | MuiInputLabel of IStyles list
    | MuiLinearProgress of IStyles list
    | MuiList of IStyles list
    | MuiListItem of IStyles list
    | MuiListItemAvatar of IStyles list
    | MuiListItemIcon of IStyles list
    | MuiListItemSecondaryAction of IStyles list
    | MuiListItemText of IStyles list
    | MuiListSubheader of IStyles list
    | MuiMenu of IStyles list
    | MuiMenuItem of IStyles list
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
let inline muiThemeProvider b c = materialEl MuiThemeProvider b c

[<Import("createMuiTheme", "@material-ui/core/styles")>]
let private createMuiTheme'<[<Pojo>]'O> (options: 'O) : ITheme = jsNative

let createMuiTheme (options: ThemeProp list) =
    let op = (keyValueList CaseRules.LowerFirst options |> unbox)
    let result = createMuiTheme' op
    result
// #endregion







