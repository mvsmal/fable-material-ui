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

    type [<StringEnum; RequireQualifiedAccess>] PaletteType =
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

    type [<StringEnum; RequireQualifiedAccess>] TextDirection =
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
        | Absolute of CSSProp list
        | Action of CSSProp list
        | ActionIcon of CSSProp list
        | ActionIconActionPosLeft of CSSProp list
        | AlternativeLabel of CSSProp list
        | AnchorOriginBottomCenter of CSSProp list
        | AnchorOriginBottomLeft of CSSProp list
        | AnchorOriginBottomRight of CSSProp list
        | AnchorOriginTopCenter of CSSProp list
        | AnchorOriginTopLeft of CSSProp list
        | AnchorOriginTopRight of CSSProp list
        | Animated of CSSProp list
        | Asterisk of CSSProp list
        | Avatar of CSSProp list
        | AvatarChildren of CSSProp list
        | Badge of CSSProp list
        | Bar of CSSProp list
        | Bar1Buffer of CSSProp list
        | Bar1Determinate of CSSProp list
        | Bar1Indeterminate of CSSProp list
        | Bar2Buffer of CSSProp list
        | Bar2Determinate of CSSProp list
        | Bar2Indeterminate of CSSProp list
        | BarColorPrimary of CSSProp list
        | BarColorSecondary of CSSProp list
        | Button of CSSProp list
        | Centered of string
        | Checked of CSSProp list
        | Circle of CSSProp list
        | CircleIndeterminate of CSSProp list
        | CircleStatic of CSSProp list
        | Clickable of CSSProp list
        | ColorAction of CSSProp list
        | ColorDefault of CSSProp list
        | ColorDisabled of CSSProp list
        | ColorError of CSSProp list
        | ColorInherit of CSSProp list
        | ColorPrimary of CSSProp list
        | ColorSecondary of CSSProp list
        | Completed of CSSProp list
        | Contained of CSSProp list
        | ContainedPrimary of CSSProp list
        | ContainedSecondary of CSSProp list
        | Container of CSSProp list
        | Content of CSSProp list
        | Default of CSSProp list
        | Deletable of CSSProp list
        | DeleteIcon of CSSProp list
        | Dense of CSSProp list
        | Disabled of CSSProp list
        | Divider of CSSProp list
        | Docked of CSSProp list
        | Dot of CSSProp list
        | DotActive of CSSProp list
        | Dots of CSSProp list
        | Elevation0 of CSSProp list
        | Elevation1 of CSSProp list
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
        | Elevation2 of CSSProp list
        | Elevation20 of CSSProp list
        | Elevation21 of CSSProp list
        | Elevation22 of CSSProp list
        | Elevation23 of CSSProp list
        | Elevation24 of CSSProp list
        | Elevation3 of CSSProp list
        | Elevation4 of CSSProp list
        | Elevation5 of CSSProp list
        | Elevation6 of CSSProp list
        | Elevation7 of CSSProp list
        | Elevation8 of CSSProp list
        | Elevation9 of CSSProp list
        | Entered of CSSProp list
        | Error of CSSProp list
        | ExpandIcon of CSSProp list
        | Expanded of CSSProp list
        | ExtendedFab of CSSProp list
        | Fab of CSSProp list
        | Fixed of string
        | Flat of CSSProp list
        | FlatPrimary of CSSProp list
        | FlatSecondary of CSSProp list
        | FlexContainer of string
        | FocusVisible of CSSProp list
        | Focused of CSSProp list
        | FontSizeInherit of CSSProp list
        | FormControl of CSSProp list
        | FullWidth of CSSProp list
        | Gutters of CSSProp list
        | Hidden of CSSProp list
        | Horizontal of CSSProp list
        | Icon of CSSProp list
        | IconContainer of CSSProp list
        | Img of CSSProp list
        | ImgFullHeight of CSSProp list
        | ImgFullWidth of CSSProp list
        | Indeterminate of CSSProp list
        | Indicator of string
        | Input of CSSProp list
        | InputMarginDense of CSSProp list
        | InputMultiline of CSSProp list
        | InputType of CSSProp list
        | InputTypeSearch of CSSProp list
        | Inset of CSSProp list
        | Invisible of CSSProp list
        | Item of CSSProp list
        | Label of CSSProp list
        | LabelContainer of CSSProp list
        | LabelIcon of CSSProp list
        | LabelPlacementStart of CSSProp list
        | LabelWrapped of CSSProp list
        | Last of CSSProp list
        | Light of CSSProp list
        | Line of CSSProp list
        | LineHorizontal of CSSProp list
        | LineVertical of CSSProp list
        | MarginDense of CSSProp list
        | MarginNormal of CSSProp list
        | Media of CSSProp list
        | Message of CSSProp list
        | Mini of CSSProp list
        | Modal of CSSProp list
        | Multiline of CSSProp list
        | Outlined of CSSProp list
        | OutlinedPrimary of CSSProp list
        | OutlinedSecondary of CSSProp list
        | Padding of CSSProp list
        | Paper of CSSProp list
        | PaperAnchorBottom of CSSProp list
        | PaperAnchorDockedBottom of CSSProp list
        | PaperAnchorDockedLeft of CSSProp list
        | PaperAnchorDockedRight of CSSProp list
        | PaperAnchorDockedTop of CSSProp list
        | PaperAnchorLeft of CSSProp list
        | PaperAnchorRight of CSSProp list
        | PaperAnchorTop of CSSProp list
        | PaperFullScreen of CSSProp list
        | PaperFullWidth of CSSProp list
        | PaperScrollBody of CSSProp list
        | PaperScrollPaper of CSSProp list
        | PaperWidthMd of CSSProp list
        | PaperWidthSm of CSSProp list
        | PaperWidthXs of CSSProp list
        | PositionAbsolute of CSSProp list
        | PositionBottom of CSSProp list
        | PositionEnd of CSSProp list
        | PositionFixed of CSSProp list
        | PositionStart of CSSProp list
        | PositionStatic of CSSProp list
        | PositionSticky of CSSProp list
        | PositionTop of CSSProp list
        | Primary of CSSProp list
        | Progress of CSSProp list
        | Raised of CSSProp list
        | RaisedPrimary of CSSProp list
        | RaisedSecondary of CSSProp list
        | Root of CSSProp list
        | RootSubtitle of CSSProp list
        | Rounded of CSSProp list
        | Row of CSSProp list
        | ScrollButtons of string
        | ScrollButtonsAuto of string
        | Scrollable of string
        | Scroller of string
        | Secondary of CSSProp list
        | SecondaryAction of CSSProp list
        | Select of CSSProp list
        | SelectMenu of CSSProp list
        | Selected of CSSProp list
        | Shrink of CSSProp list
        | SizeLarge of CSSProp list
        | SizeSmall of CSSProp list
        | Static of CSSProp list
        | Sticky of CSSProp list
        | Subheader of CSSProp list
        | Subtitle of CSSProp list
        | Svg of CSSProp list
        | SwitchBase of CSSProp list
        | Text of CSSProp list
        | TextColorInherit of CSSProp list
        | TextColorPrimary of CSSProp list
        | TextColorSecondary of CSSProp list
        | TextDense of CSSProp list
        | TextPrimary of CSSProp list
        | TextSecondary of CSSProp list
        | Tile of CSSProp list
        | Title of CSSProp list
        | TitlePositionBottom of CSSProp list
        | TitlePositionTop of CSSProp list
        | TitleWrap of CSSProp list
        | TitleWrapActionPosLeft of CSSProp list
        | TitleWrapActionPosRight of CSSProp list
        | TouchRipple of CSSProp list
        | Transition of CSSProp list
        | Underline of CSSProp list
        | Vertical of CSSProp list
        | Wrapper of CSSProp list
        | WrapperInner of CSSProp list
        | ZeroMinWidth of CSSProp list
        | ``Align-content-xs-center`` of CSSProp list
        | ``Align-content-xs-flex-end`` of CSSProp list
        | ``Align-content-xs-flex-start`` of CSSProp list
        | ``Align-content-xs-space-around`` of CSSProp list
        | ``Align-content-xs-space-between`` of CSSProp list
        | ``Align-items-xs-baseline`` of CSSProp list
        | ``Align-items-xs-center`` of CSSProp list
        | ``Align-items-xs-flex-end`` of CSSProp list
        | ``Align-items-xs-flex-start`` of CSSProp list
        | ``Direction-xs-column-reverse`` of CSSProp list
        | ``Direction-xs-column`` of CSSProp list
        | ``Direction-xs-row-reverse`` of CSSProp list
        | ``Grid-xs-10`` of CSSProp list
        | ``Grid-xs-11`` of CSSProp list
        | ``Grid-xs-12`` of CSSProp list
        | ``Grid-xs-1`` of CSSProp list
        | ``Grid-xs-2`` of CSSProp list
        | ``Grid-xs-3`` of CSSProp list
        | ``Grid-xs-4`` of CSSProp list
        | ``Grid-xs-5`` of CSSProp list
        | ``Grid-xs-6`` of CSSProp list
        | ``Grid-xs-7`` of CSSProp list
        | ``Grid-xs-8`` of CSSProp list
        | ``Grid-xs-9`` of CSSProp list
        | ``Grid-xs-auto`` of CSSProp list
        | ``Grid-xs-true`` of CSSProp list
        | ``Justify-xs-center`` of CSSProp list
        | ``Justify-xs-flex-end`` of CSSProp list
        | ``Justify-xs-space-around`` of CSSProp list
        | ``Justify-xs-space-between`` of CSSProp list
        | ``Justify-xs-space-evenly`` of CSSProp list
        | ``Spacing-xs-16`` of CSSProp list
        | ``Spacing-xs-24`` of CSSProp list
        | ``Spacing-xs-32`` of CSSProp list
        | ``Spacing-xs-40`` of CSSProp list
        | ``Spacing-xs-8`` of CSSProp list
        | ``Wrap-xs-nowrap`` of CSSProp list
        | ``Wrap-xs-wrap-reverse`` of CSSProp list
        | Head of CSSProp list
        | Body of CSSProp list
        | Footer of CSSProp list
        | Numeric of CSSProp list
        | PaddingDense of CSSProp list
        | PaddingCheckbox of CSSProp list
        | PaddingNone of CSSProp list
        | Toolbar of CSSProp list
        | Spacer of CSSProp list
        | Caption of CSSProp list
        | SelectRoot of CSSProp list
        | SelectIcon of CSSProp list
        | MenuItem of CSSProp list
        | Actions of CSSProp list
        | Hover of CSSProp list
        | IconDirectionAsc of CSSProp list
        | IconDirectionDesc of CSSProp list
        interface IStyles

    type [<Erase; RequireQualifiedAccess>] StyleType =
        | Styles of IStyles list
        | Func of (ITheme->IStyles list)

    type IClassNames = interface end

    type ClassNames =
        | Absolute of string
        | Action of string
        | ActionIcon of string
        | ActionIconActionPosLeft of string
        | AlternativeLabel of string
        | AnchorOriginBottomCenter of string
        | AnchorOriginBottomLeft of string
        | AnchorOriginBottomRight of string
        | AnchorOriginTopCenter of string
        | AnchorOriginTopLeft of string
        | AnchorOriginTopRight of string
        | Animated of string
        | Asterisk of string
        | Avatar of string
        | AvatarChildren of string
        | Badge of string
        | Bar of string
        | Bar1Buffer of string
        | Bar1Determinate of string
        | Bar1Indeterminate of string
        | Bar2Buffer of string
        | Bar2Determinate of string
        | Bar2Indeterminate of string
        | BarColorPrimary of string
        | BarColorSecondary of string
        | Buffer of string
        | Button of string
        | Centered of string
        | Checked of string
        | Circle of string
        | CircleIndeterminate of string
        | CircleStatic of string
        | Clickable of string
        | ColorAction of string
        | ColorDefault of string
        | ColorDisabled of string
        | ColorError of string
        | ColorInherit of string
        | ColorPrimary of string
        | ColorSecondary of string
        | Completed of string
        | Contained of string
        | ContainedPrimary of string
        | ContainedSecondary of string
        | Container of string
        | Content of string
        | Dashed of string
        | DashedColorPrimary of string
        | DashedColorSecondary of string
        | Default of string
        | Deletable of string
        | DeleteIcon of string
        | Dense of string
        | Disabled of string
        | Divider of string
        | Docked of string
        | Dot of string
        | DotActive of string
        | Dots of string
        | Elevation0 of string
        | Elevation1 of string
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
        | Elevation2 of string
        | Elevation20 of string
        | Elevation21 of string
        | Elevation22 of string
        | Elevation23 of string
        | Elevation24 of string
        | Elevation3 of string
        | Elevation4 of string
        | Elevation5 of string
        | Elevation6 of string
        | Elevation7 of string
        | Elevation8 of string
        | Elevation9 of string
        | Entered of string
        | Error of string
        | ExpandIcon of string
        | Expanded of string
        | ExtendedFab of string
        | Fab of string
        | Fixed of string
        | Flat of string
        | FlatPrimary of string
        | FlatSecondary of string
        | FlexContainer of string
        | FocusVisible of string
        | Focused of string
        | FontSizeInherit of string
        | FormControl of string
        | FullWidth of string
        | Gutters of string
        | Hidden of string
        | Horizontal of string
        | Icon of string
        | IconContainer of string
        | Img of string
        | ImgFullHeight of string
        | ImgFullWidth of string
        | Indeterminate of string
        | Indicator of string
        | Input of string
        | InputMarginDense of string
        | InputMultiline of string
        | InputType of string
        | InputTypeSearch of string
        | Inset of string
        | Invisible of string
        | Item of string
        | Label of string
        | LabelContainer of string
        | LabelIcon of string
        | LabelPlacementStart of string
        | LabelWrapped of string
        | Last of string
        | Light of string
        | Line of string
        | LineHorizontal of string
        | LineVertical of string
        | MarginDense of string
        | MarginNormal of string
        | Media of string
        | Message of string
        | Mini of string
        | Modal of string
        | Multiline of string
        | Outlined of string
        | OutlinedPrimary of string
        | OutlinedSecondary of string
        | Padding of string
        | Paper of string
        | PaperAnchorBottom of string
        | PaperAnchorDockedBottom of string
        | PaperAnchorDockedLeft of string
        | PaperAnchorDockedRight of string
        | PaperAnchorDockedTop of string
        | PaperAnchorLeft of string
        | PaperAnchorRight of string
        | PaperAnchorTop of string
        | PaperFullScreen of string
        | PaperFullWidth of string
        | PaperScrollBody of string
        | PaperScrollPaper of string
        | PaperWidthMd of string
        | PaperWidthSm of string
        | PaperWidthXs of string
        | PositionAbsolute of string
        | PositionBottom of string
        | PositionEnd of string
        | PositionFixed of string
        | PositionStart of string
        | PositionStatic of string
        | PositionSticky of string
        | PositionTop of string
        | Primary of string
        | Progress of string
        | Query of string
        | Raised of string
        | RaisedPrimary of string
        | RaisedSecondary of string
        | Root of string
        | RootSubtitle of string
        | Rounded of string
        | Row of string
        | Scrollable of string
        | ScrollBody of string
        | ScrollButtons of string
        | ScrollButtonsAuto of string
        | Scroller of string
        | ScrollPaper of string
        | Secondary of string
        | SecondaryAction of string
        | Select of string
        | SelectMenu of string
        | Selected of string
        | Shrink of string
        | SizeLarge of string
        | SizeSmall of string
        | Static of string
        | Sticky of string
        | Subheader of string
        | Subtitle of string
        | Svg of string
        | SwitchBase of string
        | Text of string
        | TextColorInherit of string
        | TextColorPrimary of string
        | TextColorSecondary of string
        | TextDense of string
        | TextPrimary of string
        | TextSecondary of string
        | Tile of string
        | Title of string
        | TitlePositionBottom of string
        | TitlePositionTop of string
        | TitleWrap of string
        | TitleWrapActionPosLeft of string
        | TitleWrapActionPosRight of string
        | TouchRipple of string
        | Transition of string
        | Underline of string
        | Vertical of string
        | Wrapper of string
        | WrapperInner of string
        | ZeroMinWidth of string
        | ``Align-content-xs-center`` of string
        | ``Align-content-xs-flex-end`` of string
        | ``Align-content-xs-flex-start`` of string
        | ``Align-content-xs-space-around`` of string
        | ``Align-content-xs-space-between`` of string
        | ``Align-items-xs-baseline`` of string
        | ``Align-items-xs-center`` of string
        | ``Align-items-xs-flex-end`` of string
        | ``Align-items-xs-flex-start`` of string
        | ``Direction-xs-column-reverse`` of string
        | ``Direction-xs-column`` of string
        | ``Direction-xs-row-reverse`` of string
        | ``Grid-xs-10`` of string
        | ``Grid-xs-11`` of string
        | ``Grid-xs-12`` of string
        | ``Grid-xs-1`` of string
        | ``Grid-xs-2`` of string
        | ``Grid-xs-3`` of string
        | ``Grid-xs-4`` of string
        | ``Grid-xs-5`` of string
        | ``Grid-xs-6`` of string
        | ``Grid-xs-7`` of string
        | ``Grid-xs-8`` of string
        | ``Grid-xs-9`` of string
        | ``Grid-xs-auto`` of string
        | ``Grid-xs-true`` of string
        | ``Justify-xs-center`` of string
        | ``Justify-xs-flex-end`` of string
        | ``Justify-xs-space-around`` of string
        | ``Justify-xs-space-between`` of string
        | ``Justify-xs-space-evenly`` of string
        | ``Spacing-xs-16`` of string
        | ``Spacing-xs-24`` of string
        | ``Spacing-xs-32`` of string
        | ``Spacing-xs-40`` of string
        | ``Spacing-xs-8`` of string
        | ``Wrap-xs-nowrap`` of string
        | ``Wrap-xs-wrap-reverse`` of string
        | Head of string
        | Body of string
        | Footer of string
        | Numeric of string
        | PaddingDense of string
        | PaddingCheckbox of string
        | PaddingNone of string
        | Toolbar of string
        | Spacer of string
        | Caption of string
        | SelectRoot of string
        | SelectIcon of string
        | MenuItem of string
        | Actions of string
        | Hover of string
        | IconDirectionAsc of string
        | IconDirectionDesc of string
        interface IClassNames

    type [<StringEnum; RequireQualifiedAccess>] MouseEvent = OnClick | OnMouseDown | OnMouseUp
    type [<StringEnum; RequireQualifiedAccess>] TouchEvent = OnTouchStart | OnTouchEnd
    type [<StringEnum; RequireQualifiedAccess>] MaterialSize = Xs | Sm | Md | Lg | Xl
    type [<StringEnum; RequireQualifiedAccess>] Anchor = Left | Top | Right | Bottom
    type [<StringEnum; RequireQualifiedAccess>] AutoEnum = Auto
    type [<StringEnum; RequireQualifiedAccess>] FormControlMargin = None | Dense | Normal
    type [<StringEnum; RequireQualifiedAccess>] SelectionControlColor =
        | Primary
        | Secondary
        | Default
    type [<StringEnum; RequireQualifiedAccess>] ComponentColor =
        | Default
        | Inherit
        | Primary
        | Secondary

    type StyleOption =
        | WithTheme of bool
        | Name of string
        | Flip of bool
    
    type TransitionDurationProp = 
        | Enter of float
        | Exit of float

    type TransitionDuration = U2<float, TransitionDurationProp list>
    type AutoTransitionDuration = U3<float, TransitionDuration list, AutoEnum>
    type RefProp = U2<obj,(ReactInstance->unit)>

    type MaterialProp =
        | Active of bool
        | AnchorEl of ReactInstance
        | CheckedIcon of ReactNode
        | Classes of IClassNames list
        | Color of ComponentColor
        | Component of ReactType
        | Container of ReactInstance
        | Dense of bool
        | DisablePortal of bool
        | DisableRipple of bool
        | DisableTypography of bool
        | Elevation of int
        | Error of bool
        | FullWidth of bool
        | Icon of ReactNode
        | In of bool
        | InputProps of IHTMLProp list
        | InputRef of RefProp
        | Inset of bool
        | KeepMounted of bool
        | Label of ReactNode
        | Margin of FormControlMargin
        | Multiline of bool
        | Open of bool
        | Optional of ReactNode
        | [<CompiledName("PaperProps")>] PaperProps of IHTMLProp list
        | RowsMax of int
        | [<CompiledName("SelectProps")>] SelectProps of IHTMLProp list
        | [<CompiledName("TransitionComponent")>] TransitionComponent of ReactType
        | TransitionDuration of TransitionDuration
        | [<CompiledName("TransitionProps")>] TransitionProps of IHTMLProp list
        | Value of obj // ? Should it be strongly typed? Like U{N}<string, int, float, decimal, arrays...>

        | OnClose of (obj->unit)
        | OnEnter of (obj->unit)
        | OnEntered of (obj->unit)
        | OnEntering of (obj->unit)
        | OnExit of (obj->unit)
        | OnExited of (obj->unit)
        | OnExiting of (obj->unit)
        | OnOpen of (obj->unit)
        | OnRendered of (obj->unit)
        interface IHTMLProp

    type SelectionControlProp =
        | Color of SelectionControlColor
        | OnChange of (FormEvent*bool->unit)
        interface IHTMLProp

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

let materialEl<[<Pojo>]'P when 'P :> IHTMLProp>
    (a:ComponentClass<'P>) (b: IHTMLProp list) c =
    Fable.Helpers.React.from a (keyValueList CaseRules.LowerFirst b |> unbox) c

// #region AppBar
type [<StringEnum; RequireQualifiedAccess>] AppBarPosition =
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
    | ImgProps of IHTMLProp list
    | Sizes of string
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
type [<StringEnum; RequireQualifiedAccess>] BadgeColor = Default | Primary | Secondary | Error

type BadgeProp =
    | Color of BadgeColor
    | BadgeContent of ReactNode
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
type [<StringEnum; RequireQualifiedAccess>] ButtonSize =
    | Small
    | Medium
    | Large

type [<StringEnum; RequireQualifiedAccess>] ButtonVariant =
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
    | Size of ButtonSize
    | Variant of ButtonVariant
    interface IHTMLProp

let Button = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Button"
let inline button b c = materialEl Button b c
// #endregion

// #region ButtonBase
type IButtonBaseActions =
    abstract member focusVisible: unit -> bool

type [<StringEnum; RequireQualifiedAccess>] ButtonBaseType =
    | Button
    | Submit
    | Reset

type ButtonBaseProp =
    | Action of (IButtonBaseActions->unit)
    | ButtonRef of RefProp
    | CenterRipple of bool
    | DisableTouchRipple of bool
    | FocusRipple of bool
    | FocusVisibleClassName of string
    | OnFocusVisible of (React.FocusEvent->unit)
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
    | Action of ReactNode
    | Avatar of ReactNode
    | Subheader of ReactNode
    | SubheaderTypographyProps of IHTMLProp list
    | Title of ReactNode
    | TitleTypographyProps of IHTMLProp list
    interface IHTMLProp

let CardHeader = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/CardHeader"
let inline cardHeader b c = materialEl CardHeader b c
// #endregion

// #region CardMedia
type CardMediaProp =
    | Image of string
    interface IHTMLProp

let CardMedia = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/CardMedia"
let inline cardMedia b = materialEl CardMedia b []
// #endregion

// #region Checkbox
type CheckboxProp =
    | Indeterminate of bool
    | IndeterminateIcon of ReactNode
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
type CircularProgressSize = U2<int, string>

type [<StringEnum; RequireQualifiedAccess>] CircularProgressVariant =
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
type [<Erase>] ClickAwayListenerMouseEvent =
    | Event of MouseEvent
    | False

type [<Erase>] ClickAwayListenerTouchEvent =
    | Event of TouchEvent
    | False

type ClickAwayListenerProp =
    | OnClickAway of (obj->unit)
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
type [<StringEnum; RequireQualifiedAccess>] DialogScroll = Body | Paper
type [<StringEnum; RequireQualifiedAccess>] DialogMaxWidth =
    | Xs
    | Sm
    | Md
    | [<CompiledName("")>] False

type DialogProp =
    | FullScreen of bool
    | MaxWidth of DialogMaxWidth
    | Scroll of DialogScroll
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
type [<StringEnum; RequireQualifiedAccess>] DrawerVariant = Permanent | Persistent | Temporary

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
    | ExpandIcon of ReactNode
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
type [<StringEnum; RequireQualifiedAccess>] FormControlLabelPlacement = End | Start

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
type [<StringEnum; RequireQualifiedAccess>] AlignContent =
    | Stretch
    | Center
    | [<CompiledName("flex-start")>] FlexStart
    | [<CompiledName("flex-end")>] FlexEnd
    | [<CompiledName("space-between")>] SpaceBetween
    | [<CompiledName("space-around")>] SpaceAround

type [<StringEnum; RequireQualifiedAccess>] Justify =
    | Center
    | [<CompiledName("flex-start")>] FlexStart
    | [<CompiledName("flex-end")>] FlexEnd
    | [<CompiledName("space-between")>] SpaceBetween
    | [<CompiledName("space-around")>] SpaceAround
    | [<CompiledName("space-evenly")>] SpaceEvenly

type [<StringEnum; RequireQualifiedAccess>] AlignItems =
    | Stretch
    | Center
    | BaseLine
    | [<CompiledName("flex-start")>] FlexStart
    | [<CompiledName("flex-end")>] FlexEnd

type [<StringEnum; RequireQualifiedAccess>] Direction =
    | Row
    | Column
    | [<CompiledName("row-reverse")>] RowReverse
    | [<CompiledName("column-reverse")>] ColumnReverse

type [<RequireQualifiedAccess>] Spacing =
    | ``0`` = 0
    | ``8`` = 8
    | ``16`` = 16
    | ``24`` = 24
    | ``32`` = 32
    | ``40`` = 40

type [<StringEnum; RequireQualifiedAccess>] Wrap =
    | Nowrap
    | Wrap
    | [<CompiledName("wrap-reverse")>] WrapReverse

type [<RequireQualifiedAccess>] GridSizeNum =
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
type [<StringEnum; RequireQualifiedAccess>] ActionPosition = Left | Right
type [<StringEnum; RequireQualifiedAccess>] TitlePosition = Top | Bottom

type GridListTileBarProp =
    | ActionIcon of ReactNode
    | ActionPosition of ActionPosition
    | Subtitle of ReactNode
    | Title of ReactNode
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
type [<StringEnum; RequireQualifiedAccess>] HiddenImplementation = Js | Css
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
type [<StringEnum; RequireQualifiedAccess>] IconFontSize = Inherit | Default
type [<StringEnum; RequireQualifiedAccess>] IconColor =
    | Inherit
    | Primary
    | Secondary
    | Action
    | Error
    | Disabled

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
type [<StringEnum; RequireQualifiedAccess>] InputMargin = None | Dense

type InputProp =
    | DisableUnderline of bool
    | EndAdornment of ReactNode
    | InputComponent of ReactType
    | StartAdornment of ReactNode
    interface IHTMLProp

let Input = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Input"
let inline input b = materialEl Input b []
// #endregion

// #region InputAdornment
type [<StringEnum; RequireQualifiedAccess>] InputAdornmentPosition = Start | End

type InputAdornmentProp =
    | Position of InputAdornmentPosition
    interface IHTMLProp

let InputAdornment = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/InputAdornment"
let inline inputAdornment b c = materialEl InputAdornment b c
// #endregion

// #region InputLabel
type [<StringEnum; RequireQualifiedAccess>] InputLabelMargin = Dense

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
type [<StringEnum; RequireQualifiedAccess>] LinearProgressColor = Primary | Secondary
type [<StringEnum; RequireQualifiedAccess>] LinearProgressVariant =
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
type ListItemProp = 
    | Button of bool
    | [<CompiledName("ContainerComponent")>] ContainerComponent of ReactType
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
    | Primary of ReactNode
    | PrimaryTypographyProps of IHTMLProp list
    | Secondary of ReactNode
    | SecondaryTypographyProps of IHTMLProp list
    interface IHTMLProp

let ListItemText = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ListItemText"
let inline listItemText b c = materialEl ListItemText b c
// #endregion

// #region ListSubheader
type [<StringEnum; RequireQualifiedAccess>] ListSubheaderColor = Default | Primary | Inherit

type ListSubheaderProp =
    | Color of ListSubheaderColor
    | DisableSticky of bool
    interface IHTMLProp

let ListSubheader = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/ListSubheader"
let inline listSubheader b c = materialEl ListSubheader b c
// #endregion

// #region Menu
type MenuProp =
    | DisableAutoFocusItem of bool
    | [<CompiledName("MenuListProps")>] MenuListProps of IHTMLProp list
    | [<CompiledName("PopoverClasses")>] PopoperClasses of IClassNames list
    | TransitionDuration of AutoTransitionDuration
    interface IHTMLProp

let Menu = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Menu"
let inline menu b c = materialEl Menu b c
// #endregion

// #region MenuItem
let MenuItem = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/MenuItem"
let inline menuItem b c = materialEl MenuItem b c
// #endregion

// #region MenuList
let MenuList = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/MenuList"
let inline menuList b c = materialEl MenuList b c
// #endregion

// #region MobileStepper
type [<StringEnum; RequireQualifiedAccess>] MobileStepperPosition = Bottom | Top | Static
type [<StringEnum; RequireQualifiedAccess>] MobileStepperVariant = Text | Dots | Progress

type MobileStepperProp =
    | ActiveStep of int
    | BackButton of ReactElement
    | NextButton of ReactElement
    | Position of MobileStepperPosition
    | Steps of int
    | Variant of MobileStepperVariant
    interface IHTMLProp

let MobileStepper = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/MobileStepper"
let inline mobileStepper b = materialEl MobileStepper b []
// #endregion

// #region Modal
type [<StringEnum; RequireQualifiedAccess>] ModalCloseReason = EscapeKeyDown | BackdropClick

type ModalProp =
    | [<CompiledName("BackdropComponent")>] BackdropComponent of ReactType
    | [<CompiledName("BackdropProps")>] BackdropProps of IHTMLProp list
    | DisableAutoFocus of bool
    | DisableBackdropClick of bool
    | DisableEnforceFocus of bool
    | DisableEscapeKeyDown of bool
    | DisableRestoreFocus of bool
    | HideBackdrop of bool
    | Manager of obj // TODO check static type for ModalManager
    | OnBackdropClick of (obj->unit)
    | OnEscapeKeyDown of (obj->unit)
    | OnClose of (obj*ModalCloseReason->unit)
    interface IHTMLProp

let Modal = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Modal"
let inline modal b c = materialEl Modal b c
// #endregion

// #region NativeSelect
let NativeSelect = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/NativeSelect"
let inline nativeSelect b c = materialEl NativeSelect b c
// #endregion

// #region Paper
type PaperProp =
    | Square of bool
    interface IHTMLProp
let Paper = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Paper"
let inline paper b c = materialEl Paper b c
// #endregion

// #region Popover
type [<StringEnum; RequireQualifiedAccess>] PopoverHorizontalPosition = Left | Center | Right
type [<StringEnum; RequireQualifiedAccess>] PopoverVerticalPosition = Top | Center | Bottom
type [<StringEnum; RequireQualifiedAccess>] AnchorReference = AnchorEl | AnchorPosition | None
and [<Pojo>] AnchorPosition = {
    left: int
    top: int
}

type PopoverHorizontalOrigin = U2<int,PopoverHorizontalPosition>
type PopoverVerticalOrigin = U2<int,PopoverVerticalPosition>
type [<Pojo>] PopoverOrigin = {
    horizontal: PopoverHorizontalOrigin
    vertical: PopoverVerticalOrigin
}

type IPopoverActions =
    abstract member updatePosition: unit -> unit

type PopoverProp =
    | Action of (IPopoverActions->unit)
    | AnchorOrigin of PopoverOrigin
    | AnchorPosition of AnchorPosition
    | AnchorReference of AnchorReference
    | GetContentAnchorEl of (obj->obj)
    | MarginThreshold of int
    | TransformOrigin of PopoverOrigin
    | TransitionDuration of AutoTransitionDuration
    interface IHTMLProp

let Popover = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Popover"
let inline popover b c = materialEl Popover b c
// #endregion

// #region Popper
type [<StringEnum; RequireQualifiedAccess>] PopperPlacementType =
    | [<CompiledName "bottom-end">] BottomEnd
    | [<CompiledName "bottom-start">] BottomStart
    | Bottom
    | [<CompiledName "left-end">] LeftEnd
    | [<CompiledName "left-start">] LeftStart
    | Left
    | [<CompiledName "right-end">] RightEnd
    | [<CompiledName "right-start">] RightStart
    | Right
    | [<CompiledName "top-end">] TopEnd
    | [<CompiledName "top-start">] TopStart
    | Top

type PopperProp =
    | Modifies of obj
    | Placement of PopperPlacementType
    | PopperOptions of obj
    | Transition of bool
    interface IHTMLProp

let Popper = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Popper"
let inline popper b c = materialEl Popper b c
// #endregion

// #region Portal
let Portal = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Portal"
let inline portal b c = materialEl Portal b c
// #endregion

// #region Radio
let Radio = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Radio"
let inline radio b = materialEl Radio b []
// #endregion

// #region RadioGroup
type RadioGroupProp =
    | OnChange of (obj*string->unit)
    interface IHTMLProp

let RadioGroup = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/RadioGroup"
let inline radioGroup b c = materialEl RadioGroup b c
// #endregion

// #region RootRef
type RootRefProp =
    | RootRef of RefProp
    interface IHTMLProp

let RootRef = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/RootRef"
let inline rootRef b c = materialEl RootRef b c
// #endregion

// #region Select
type SelectProp =
    | AutoWidth of bool
    | DisplayEmpty of bool
    | [<CompiledName("IconComponent")>] IconComponent of ReactType
    | Input of ReactNode
    | [<CompiledName("MenuProps")>] MenuProps of IHTMLProp list
    | Native of bool
    | OnChange of (obj*obj->unit)
    | RenderValue of (obj->ReactNode)
    | [<CompiledName("SelectDisplayProps")>] SelectDisplayProps of IHTMLProp list
    interface IHTMLProp

let Select = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Select"
let inline select b c = materialEl Select b c
// #endregion

// #region Slide
type [<StringEnum; RequireQualifiedAccess>] SlideDirection = Bottom | Up | Left | Right

type SlideProp = 
    | Timeout of TransitionDuration
    | Direction of SlideDirection
    interface IHTMLProp

let Slide = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Slide"
let inline slide b c = materialEl Slide b c
// #endregion

// #region Snackbar
type [<StringEnum; RequireQualifiedAccess>] SnackbarHorizontalOrigin = Left | Center | Right
type [<StringEnum; RequireQualifiedAccess>] SnackbarVerticalOrigin = Top | Center | Bottom
type [<StringEnum; RequireQualifiedAccess>] SnackbarCloseReason = Timeout | Clickaway

type [<Pojo>] SnackbarOrigin = {
    vertical: SnackbarVerticalOrigin
    horizontal: SnackbarHorizontalOrigin
}

type SnackbarProp =
    | Action of ReactElement
    | AnchorOrigin of SnackbarOrigin
    | AutoHideDuration of int
    | [<CompiledName("ContentProps")>] ContentProps of IHTMLProp list
    | DisableWidnowBlurListener of bool
    | Message of ReactElement
    | OnClose of (SyntheticEvent*SnackbarCloseReason->unit)
    | ResumeHideDuration of int
    interface IHTMLProp

let Snackbar = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Snackbar"
let inline snackbar b c = materialEl Snackbar b c
// #endregion

// #region SnackbarContent
let SnackbarContent = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/SnackbarContent"
let inline snackbarContent b c = materialEl SnackbarContent b c
// #endregion

// #region Step
type StepProp =
    | Completed of bool
    interface IHTMLProp

let Step = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Step"
let inline step b c = materialEl Step b c
// #endregion

// #region StepButton
let StepButton = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/StepButton"
let inline stepButton b c = materialEl StepButton b c
// #endregion

// #region StepConnector
let StepConnector = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/StepConnector"
let inline stepConnector b c = materialEl StepConnector b c
// #endregion

// #region StepContent
type StepContentProp =
    | TransitionDuration of AutoTransitionDuration
    interface IHTMLProp

let StepContent = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/StepContent"
let inline stepContent b c = materialEl StepContent b c
// #endregion

// #region StepIcon
let StepIcon = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/StepIcon"
let inline stepIcon b c = materialEl StepIcon b c
// #endregion

// #region StepLabel
type StepLabelProp =
    | [<CompiledName("StepIconProps")>] StepIconProps of IHTMLProp list
    interface IHTMLProp

let StepLabel = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/StepLabel"
let inline stepLabel b c = materialEl StepLabel b c
// #endregion

// #region Stepper
type [<StringEnum; RequireQualifiedAccess>] StepperOrientation = Vertical | Horizontal

type StepperProp =
    | ActiveStep of int
    | AlternativeLabel of bool
    | Connector of ReactElement
    | NonLinear of bool
    | Orientation of StepperOrientation
    interface IHTMLProp

let Stepper = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Stepper"
let inline stepper b c = materialEl Stepper b c
// #endregion

// #region SvgIcon
type SvgIconProp =
    | NativeColor of string
    | TitleAccess of string
    interface IHTMLProp

let SvgIcon = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/SvgIcon"
let inline svgIcon b c = materialEl SvgIcon b c
// #endregion

// #region SwipeableDrawer
type SwipeableDrawerProp =
    | DisableBackdropTransition of bool
    | DisableDiscovery of bool
    | DisableSwipeToOpen of bool
    | SwipeAreaWidth of int
    interface IHTMLProp

let SwipeableDrawer =
    importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/SwipeableDrawerProp"
let inline swipeableDrawer b c = materialEl SwipeableDrawer b c
// #endregion

// #region Switch
let Switch = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Switch"
let inline switch b = materialEl Switch b []
// #endregion

// #region Tab
let Tab = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Tab"
let inline tab b = materialEl Tab b []
// #endregion

// #region Tabs
type [<StringEnum; RequireQualifiedAccess>] TabsIndicatorColor = Primary | Secondary
type [<StringEnum; RequireQualifiedAccess>] TabsTextColor = Primary | Secondary | Inherit
type [<StringEnum; RequireQualifiedAccess>] ScrollButtonsType = Auto | On | Off

type ITabsActions =
    abstract member updateIndicator: unit -> unit

type TabsProp =
    | Action of (ITabsActions->unit)
    | Centered of bool
    | IndicatorColor of TabsIndicatorColor
    | OnChange of (obj*int->unit)
    | Scrollabel of bool
    | [<CompiledName("ScrollButtonComponent")>] ScrollButtonComponent of ReactType
    | ScrollButtons of ScrollButtonsType
    | [<CompiledName("TabIndicatorProps")>] TabIndicatorProps of IHTMLProp list
    | TextColor of TabsTextColor
    interface IHTMLProp

let Tabs = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Tabs"
let inline tabs b c = materialEl Tabs b c
// #endregion

// #region Table
let Table = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/Table"
let inline table b c = materialEl Table b c
// #endregion

// #region TableBody
let TableBody = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/TableBody"
let inline tableBody b c = materialEl TableBody b c
// #endregion

// #region TableCell
type [<StringEnum; RequireQualifiedAccess>] TableCellPadding = Default | Checkbox | Dense | None
type [<StringEnum; RequireQualifiedAccess>] TableCellVariant = Head | Body | Footer
type [<StringEnum; RequireQualifiedAccess>] TableCellSortDirection =
    | Asc
    | Desc
    | [<CompiledName("")>] False

type TableCellProp =
    | Numeric of bool
    | Padding of TableCellPadding
    | Scope of string
    | SortDirection of TableCellSortDirection
    | Variant of TableCellVariant
    interface IHTMLProp

let TableCell = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/TableCell"
let inline tableCell b c = materialEl TableCell b c
// #endregion

// #region TableFooter
let TableFooter = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/TableFooter"
let inline tableFooter b c = materialEl TableFooter b c
// #endregion

// #region TableHead
let TableHead = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/TableHead"
let inline tableHead b c = materialEl TableHead b c
// #endregion

// #region TablePagination
type ILabelDisplayedRowsArgs =
    abstract member from: int
    abstract member ``to``: int
    abstract member count: int
    abstract member page: int

type TablePaginationProp =
    | [<CompiledName("ActionsComponent")>] ActionsComponent of ReactType
    | BackIconButtonProps of IHTMLProp list
    | Count of int
    | LabelDisplayedRows of (ILabelDisplayedRowsArgs->ReactNode)
    | LabelRowsPerPage of ReactNode
    | NextIconButtonPropss of IHTMLProp list
    | OnChangePage of (obj*int->unit)
    | OnChangeRowsPerPage of (obj->unit)
    | Page of int
    | RowsPerPage of int
    | RowsPerPageOptions of int list
    interface IHTMLProp

let TablePagination = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/TablePagination"
let inline tablePagination b c = materialEl TablePagination b c
// #endregion

// #region TableRow
type TableRowProp =
    | Hover of bool
    interface IHTMLProp

let TableRow = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/TableRow"
let inline tableRow b c = materialEl TableRow b c
// #endregion

// #region TableSortLabel
type [<StringEnum; RequireQualifiedAccess>] TableSortDirection = Acs | Desc
type TableSortLabelProp =
    | Direction of TableSortDirection
    interface IHTMLProp

let TableSortLabel = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/TableSortLabel"
let inline tableSortLabel b c = materialEl TableSortLabel b c
// #endregion

// #region TextField
type TextFieldProp =
    | [<CompiledName("FormHelperTextProps")>] FormHelperTextProps of IHTMLProp list
    | HelperText of ReactNode
    | [<CompiledName("InputLabelProps")>] InputLabelProps of IHTMLProp list
    | [<CompiledName("InputProps")>] InputProps of IHTMLProp list
    | Select of bool
    interface IHTMLProp

let TextField = importDefault<ComponentClass<IHTMLProp>> "@material-ui/core/TextField"
let inline textField b c = materialEl TextField b c
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
    | MuiCssBaseline of IStyles list
    | MuiDialog of IStyles list
    | MuiDialogActions of IStyles list
    | MuiDialogContent of IStyles list
    | MuiDialogContentText of IStyles list
    | MuiDialogTitle of IStyles list
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
    | MuiMobileStepper of IStyles list
    | MuiModal of IStyles list
    | MuiNativeSelect of IStyles list
    | MuiPaper of IStyles list
    | MuiPopover of IStyles list
    | MuiRadio of IStyles list
    | MuiSelect of IStyles list
    | MuiSnackbar of IStyles list
    | MuiSnackbarContent of IStyles list
    | MuiStep of IStyles list
    | MuiStepButton of IStyles list
    | MuiStepConnector of IStyles list
    | MuiStepContent of IStyles list
    | MuiStepIcon of IStyles list
    | MuiStepLabel of IStyles list
    | MuiStepper of IStyles list
    | MuiSvgIcon of IStyles list
    | MuiSwitch of IStyles list
    | MuiTab of IStyles list
    | MuiTable of IStyles list
    | MuiTableCell of IStyles list
    | MuiTableFooter of IStyles list
    | MuiTablePagination of IStyles list
    | MuiTableRow of IStyles list
    | MuiTableSortLabel of IStyles list
    | MuiTabs of IStyles list

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

type [<Erase>] ProviderTheme =
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
    options
    |> keyValueList CaseRules.LowerFirst
    |> unbox
    |> createMuiTheme'
// #endregion







