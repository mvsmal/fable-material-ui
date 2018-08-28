[<AutoOpen>]
module Fable.MaterialUI.Themes

open Fable.Core
open Fable.Helpers.React.Props

type IPaletteIntention =
    abstract member light: string
    abstract member main: string
    abstract member dark: string
    abstract member contrastText: string

type [<StringEnum; RequireQualifiedAccess>] PaletteType = Dark | Light

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

type [<StringEnum; RequireQualifiedAccess>] TextDirection = Ltr | Rtl

type IShape =
    abstract member borderRadius: int

type ISpacing =
    abstract member ``unit``: int

type IZIndex =
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
    abstract member zIndex: IZIndex

type IStyles = interface end

type Styles =
    | Absolute of CSSProp list
    | Action of CSSProp list
    | ActionIcon of CSSProp list
    | ActionIconActionPosLeft of CSSProp list
    | Actions of CSSProp list
    | AlignCenter of CSSProp list
    | AlignJistify of CSSProp list
    | AlignLeft of CSSProp list
    | AlignRight of CSSProp list
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
    | Body of CSSProp list
    | Body1 of CSSProp list
    | Body2 of CSSProp list
    | Button of CSSProp list
    | Caption of CSSProp list
    | Centered of CSSProp list
    | Checked of CSSProp list
    | Child of CSSProp list
    | ChildLeaving of CSSProp list
    | ChildPulsate of CSSProp list
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
    | ColorTextPrimary of CSSProp list
    | ColorTextSecondary of CSSProp list
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
    | Display1 of CSSProp list
    | Display2 of CSSProp list
    | Display3 of CSSProp list
    | Display4 of CSSProp list
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
    | Filled of CSSProp list
    | Fixed of CSSProp list
    | Flat of CSSProp list
    | FlatPrimary of CSSProp list
    | FlatSecondary of CSSProp list
    | FlexContainer of CSSProp list
    | FocusVisible of CSSProp list
    | Focused of CSSProp list
    | FontSizeInherit of CSSProp list
    | Footer of CSSProp list
    | FormControl of CSSProp list
    | FullWidth of CSSProp list
    | GutterBottom of CSSProp list
    | Gutters of CSSProp list
    | Head of CSSProp list
    | Headline of CSSProp list
    | Hidden of CSSProp list
    | Horizontal of CSSProp list
    | Hover of CSSProp list
    | Icon of CSSProp list
    | IconContainer of CSSProp list
    | IconDirectionAsc of CSSProp list
    | IconDirectionDesc of CSSProp list
    | Img of CSSProp list
    | ImgFullHeight of CSSProp list
    | ImgFullWidth of CSSProp list
    | Indeterminate of CSSProp list
    | Indicator of CSSProp list
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
    | Layout of CSSProp list
    | Light of CSSProp list
    | Line of CSSProp list
    | LineHorizontal of CSSProp list
    | LineVertical of CSSProp list
    | MarginDense of CSSProp list
    | MarginNormal of CSSProp list
    | Media of CSSProp list
    | MenuItem of CSSProp list
    | Message of CSSProp list
    | Mini of CSSProp list
    | Modal of CSSProp list
    | Multiline of CSSProp list
    | NoWrap of CSSProp list
    | Numeric of CSSProp list
    | Outlined of CSSProp list
    | OutlinedPrimary of CSSProp list
    | OutlinedSecondary of CSSProp list
    | Padding of CSSProp list
    | PaddingCheckbox of CSSProp list
    | PaddingDense of CSSProp list
    | PaddingNone of CSSProp list
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
    | Paragraph of CSSProp list
    | Popper of CSSProp list
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
    | Required of CSSProp list
    | Regular of CSSProp list
    | Ripple of CSSProp list
    | RipplePulsate of CSSProp list
    | RippleVisible of CSSProp list
    | Root of CSSProp list
    | RootSubtitle of CSSProp list
    | Rounded of CSSProp list
    | Row of CSSProp list
    | ScrollButtons of CSSProp list
    | ScrollButtonsAuto of CSSProp list
    | Scrollable of CSSProp list
    | Scroller of CSSProp list
    | Secondary of CSSProp list
    | SecondaryAction of CSSProp list
    | Select of CSSProp list
    | SelectIcon of CSSProp list
    | SelectMenu of CSSProp list
    | SelectRoot of CSSProp list
    | Selected of CSSProp list
    | Shrink of CSSProp list
    | SizeLarge of CSSProp list
    | SizeSmall of CSSProp list
    | Spacer of CSSProp list
    | Static of CSSProp list
    | Sticky of CSSProp list
    | Subheader of CSSProp list
    | Subheading of CSSProp list
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
    | Toolbar of CSSProp list
    | Tooltip of CSSProp list
    | TooltipPlacementBottom of CSSProp list
    | TooltipPlacementLeft of CSSProp list
    | TooltipPlacementRight of CSSProp list
    | TooltipPlacementTop of CSSProp list
    | Touch of CSSProp list
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
    | Actions of string
    | AlignCenter of string
    | AlignJistify of string
    | AlignLeft of string
    | AlignRight of string
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
    | Body of string
    | Body1 of string
    | Body2 of string
    | Buffer of string
    | Button of string
    | Caption of string
    | Centered of string
    | Checked of string
    | Child of string
    | ChildLeaving of string
    | ChildPulsate of string
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
    | ColorTextPrimary of string
    | ColorTextSecondary of string
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
    | Display1 of string
    | Display2 of string
    | Display3 of string
    | Display4 of string
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
    | Filled of string
    | Fixed of string
    | Flat of string
    | FlatPrimary of string
    | FlatSecondary of string
    | FlexContainer of string
    | FocusVisible of string
    | Focused of string
    | FontSizeInherit of string
    | Footer of string
    | FormControl of string
    | FullWidth of string
    | GutterBottom of string
    | Gutters of string
    | Head of string
    | Headline of string
    | Hidden of string
    | Horizontal of string
    | Hover of string
    | Icon of string
    | IconContainer of string
    | IconDirectionAsc of string
    | IconDirectionDesc of string
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
    | Layout of string
    | Light of string
    | Line of string
    | LineHorizontal of string
    | LineVertical of string
    | MarginDense of string
    | MarginNormal of string
    | Media of string
    | MenuItem of string
    | Message of string
    | Mini of string
    | Modal of string
    | Multiline of string
    | NoWrap of string
    | Numeric of string
    | Outlined of string
    | OutlinedPrimary of string
    | OutlinedSecondary of string
    | Padding of string
    | PaddingCheckbox of string
    | PaddingDense of string
    | PaddingNone of string
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
    | Paragraph of string
    | Popper of string
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
    | Required of string
    | Regular of string
    | Ripple of string
    | RipplePulsate of string
    | RippleVisible of string
    | Root of string
    | RootSubtitle of string
    | Rounded of string
    | Row of string
    | ScrollBody of string
    | ScrollButtons of string
    | ScrollButtonsAuto of string
    | ScrollPaper of string
    | Scrollable of string
    | Scroller of string
    | Secondary of string
    | SecondaryAction of string
    | Select of string
    | SelectIcon of string
    | SelectMenu of string
    | SelectRoot of string
    | Selected of string
    | Shrink of string
    | SizeLarge of string
    | SizeSmall of string
    | Spacer of string
    | Static of string
    | Sticky of string
    | Subheader of string
    | Subheading of string
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
    | Toolbar of string
    | Tooltip of string
    | TooltipPlacementBottom of string
    | TooltipPlacementLeft of string
    | TooltipPlacementRight of string
    | TooltipPlacementTop of string
    | Touch of string
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
    interface IClassNames
