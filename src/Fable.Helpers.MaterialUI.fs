module Fable.Helpers.MaterialUI

open Fable.Core
open Fable.Import
open Fable.Import.React
open Fable.Core.JsInterop
open React.Props

[<AutoOpen>]
module Props =
    //#region Themes
    type PaletteIntention = {
        light: string
        main: string
        dark: string
        contrastText: string
    }

    [<StringEnum>]
    type PaletteType =
        | Dark
        | Light

    type PaletteCommon = {
        black: string
        white: string
    }

    type PaletteAction = {
        active: string
        hover: string
        hoverOpacity: float
        selected: string
        disabled: string
        disabledBackground: string
    }

    type PaletteBackground = {
        paper: string
        ``default``: string
    }

    type PaletteText = {
        primary: string
        secondary: string
        disabled: string
        hint: string
    }

    type Color = {
        ``50``: string
        ``100``: string
        ``200``: string
        ``300``: string
        ``400``: string
        ``500``: string
        ``600``: string
        ``700``: string
        ``800``: string
        ``900``: string
        A100: string
        A200: string
        A400: string
        A700: string
    }

    type Palette = {
        common: PaletteCommon
        ``type``: PaletteType
        primary: PaletteIntention
        secondary: PaletteIntention
        error: PaletteIntention
        grey: Color
        contrastThreshold: int
        getContrastText: (string->string)
        augmentColor: (PaletteIntention->unit)
        tonalOffset: float
        text: PaletteText
        divider: string
        background: PaletteBackground
        action: PaletteAction
    }

    [<StringEnum>]
    type TextDirection =
        | Ltr
        | Rtl

    type Shape = {
        borderRadius: int
    }

    type Spacing = {
        ``unit``: int
    }

    type ZIndex = {
        mobileStepper: int
        appBar: int
        drawer: int
        modal: int
        snackbar: int
        tooltip: int
    }
    type Typography = {
        fontSize: string
        fontWeight: int
        fontFamily: string
        letterSpacing: string
        lineHeight: string
        marginLeft: string
        color: string
        textTransform: string
    }

    type ThemeTypography = {
        round: (float->float)
        pxToRem: (float->string)
        fontFamily: string
        fontSize: string
        fontWeightLight: int
        fontWeightRegular: int
        fontWeightMedium: int
        display4: Typography
        dispaly3: Typography
        display2: Typography
        display1: Typography
        headline: Typography
        title: Typography
        subheading: Typography
        body2: Typography
        body1: Typography
        caption: Typography
        button: Typography
    }

    type Theme = {
        direction: TextDirection
        overrides: obj
        palette: Palette
        props: obj
        shadows: string list
        typography: Typography
        shape: Shape
        spacing: Spacing
        zIndex: ZIndex
    }
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
        interface IStyles

    [<Erase>]
    [<RequireQualifiedAccess>]
    type StyleType =
        | Styles of IStyles list
        | Func of (Theme->IStyles list)

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

        interface IClassNames

    type ClassesProp =
        | Classes of IClassNames list
        interface IHTMLProp
        
    [<Erase>]
    type ComponentProp<'a> =
        | Str of string
        | Func of ('a -> ReactElement)
        | El of ReactElement
    
    [<StringEnum>]
    type ComponentColor =
        | Default
        | Inherit
        | Primary
        | Secondary

    type MaterialProp<'a> =
        | Component of ComponentProp<'a>
        | Color of ComponentColor
        | Disabled of bool
        | DisableRipple of bool
        | Icon of ReactElement
        | Id of string
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

    type TransitionDurationProp = 
        | Enter of float
        | Exit of float

    [<Erase>]
    type TransitionDuration =
        | Num of float
        | Custom of TransitionDurationProp list
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type MaterialSize =
        | Xs
        | Sm
        | Md
        | [<CompiledName("")>] False

module Colors =
    let red = importDefault<Props.Color> "@material-ui/core/colors/red";
    let pink = importDefault<Props.Color> "@material-ui/core/colors/pink";
    let purple = importDefault<Props.Color> "@material-ui/core/colors/purple";
    let deepPurple = importDefault<Props.Color> "@material-ui/core/colors/deepPurple";
    let indigo = importDefault<Props.Color> "@material-ui/core/colors/indigo";
    let blue = importDefault<Props.Color> "@material-ui/core/colors/blue";
    let lightBlue = importDefault<Props.Color> "@material-ui/core/colors/lightBlue";
    let cyan = importDefault<Props.Color> "@material-ui/core/colors/cyan";
    let teal = importDefault<Props.Color> "@material-ui/core/colors/teal";
    let green = importDefault<Props.Color> "@material-ui/core/colors/green";
    let lightGreen = importDefault<Props.Color> "@material-ui/core/colors/lightGreen";
    let lime = importDefault<Props.Color> "@material-ui/core/colors/lime";
    let yellow = importDefault<Props.Color> "@material-ui/core/colors/yellow";
    let amber = importDefault<Props.Color> "@material-ui/core/colors/amber";
    let orange = importDefault<Props.Color> "@material-ui/core/colors/orange";
    let deepOrange = importDefault<Props.Color> "@material-ui/core/colors/deepOrange";
    let brown = importDefault<Props.Color> "@material-ui/core/colors/brown";
    let grey = importDefault<Props.Color> "@material-ui/core/colors/grey";
    let blueGrey = importDefault<Props.Color> "@material-ui/core/colors/blueGrey";

open Props

let materialEl<[<Pojo>]'P when 'P :> IHTMLProp> (a:ComponentClass<'P>) (b: IHTMLProp list) c =
    Fable.Helpers.React.from a (keyValueList CaseRules.LowerFirst b |> unbox) c

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
    | Open of bool
    | TransitionDuration of TransitionDuration
    interface IHTMLProp

let Backdrop = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Backdrop"
let inline backdrop b = materialEl Backdrop b []
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
    | Label of ReactElement
    | ShowLabel of bool
    | Value of obj
    interface IHTMLProp

let BottomNavigationAction =
    importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/BottomNavigationAction"
let inline bottomNavigationAction b = materialEl BottomNavigationAction b []
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
let inline button b c = materialEl Button b c
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
    | DisableTypography of bool
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
let inline checkbox b = materialEl Checkbox b []
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
let inline chip b = materialEl Chip b []
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

let inline collapse b c = materialEl Collapse b c
// #endregion

// #region CssBaseline
let CssBaseline = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/CssBaseline"
let cssBaseline b = materialEl CssBaseline b []
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
    | Theme of Theme
    | Func of (Theme->ThemeProp list)

type MuiThemeProviderProp =
    | Theme of ProviderTheme
    | DisableStylesGeneration of bool
    interface IHTMLProp

let MuiThemeProvider = importMember<ComponentClass<IHTMLProp>> "@material-ui/core/styles"
let inline muiThemeProvider b c = materialEl MuiThemeProvider b c

[<Import("createMuiTheme", "@material-ui/core/styles")>]
let private createMuiTheme'<[<Pojo>]'O> (options: 'O) : Theme = jsNative

let createMuiTheme (options: ThemeProp list) =
    let op = (keyValueList CaseRules.LowerFirst options |> unbox)
    let result = createMuiTheme' op
    result
// #endregion











