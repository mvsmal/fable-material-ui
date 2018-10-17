[<AutoOpen>]
module rec Fable.MaterialUI
open System
open Fable.Core

[<AutoOpen>]
module Themes =
    open Fable.Core
    open Fable.Import.React
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
        abstract getContrastText: background: string -> string
        abstract augmentColor: color: IPaletteIntention * mainShade : U2<int, string> * lightShade : U2<int, string> * darkShade : U2<int, string> -> unit
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
        abstract round: px: float -> float
        abstract pxToRem: px: float -> string
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

    type IBreakpointValues =
        abstract member xs: int
        abstract member sm: int
        abstract member md: int
        abstract member lg: int
        abstract member xl: int

    type IBreakpoints =
        abstract member keys: Props.MaterialSize list
        abstract member values: IBreakpointValues
        abstract up: key: U2<Props.MaterialSize, int> -> string
        abstract down: key: U2<Props.MaterialSize, int> -> string
        abstract only: key: Props.MaterialSize -> string
        abstract between: start: Props.MaterialSize * ``end``: Props.MaterialSize -> string
        abstract width: key: Props.MaterialSize -> int

    type IMixins =
        abstract gutters: ?styles : CSSProperties -> CSSProperties
        abstract toolbar: CSSProperties

    type IEasing =
        abstract member easeInOut: string
        abstract member easeOut: string
        abstract member easeIn: string
        abstract member sharp: string

    type IDuration =
        abstract member shortest: float
        abstract member shorter: float
        abstract member short: float
        abstract member standard: float
        abstract member complex: float
        abstract member enteringScreen: float
        abstract member leavingScreen: float

    type ITransitionOptions =
        abstract member duration: U2<float, string> with get,set
        abstract member easing: string with get,set
        abstract member delay: U2<float, string> with get,set

    type ITransitions =
        abstract member easing: IEasing
        abstract member duration: IDuration
        abstract create: props : U2<string, string list> * ?options: ITransitionOptions -> string
        abstract getAutoHeightDuration: height : int -> int

    type ITheme =
        abstract member breakpoints: IBreakpoints
        abstract member direction: TextDirection
        abstract member overrides: obj
        abstract member palette: IPalette
        abstract member props: obj
        abstract member shadows: string list
        abstract member typography: IThemeTypography
        abstract member shape: IShape
        abstract member spacing: ISpacing
        abstract member zIndex: IZIndex
        abstract member mixins: IMixins
        abstract member transitions: ITransitions

    type IStyles = interface end

    type Styles =
        | [<Erase>] Custom' of string * obj
        interface IStyles
    
    module Styles =
        open Fable.Core.JsInterop

        let Custom (key, (props : CSSProp list)) =
            Styles.Custom' (key, props |> keyValueList CaseRules.LowerFirst)

        let AdornedStart props = Custom ("adornedStart", props)
        let AdornedEnd props = Custom ("adornedEnd", props)
        let NotchedOutline props = Custom ("notchedOutline", props)
        let InputAdornedStart props = Custom ("inputAdornedStart", props)
        let InputAdornedEnd props = Custom ("inputAdornedEnd", props)
        let Absolute props = Custom ("absolute", props)
        let Action props = Custom ("action", props)
        let ActionIcon props = Custom ("actionIcon", props)
        let ActionIconActionPosLeft props = Custom ("actionIconActionPosLeft", props)
        let Actions props = Custom ("actions", props)
        let AlignCenter props = Custom ("alignCenter", props)
        let AlignJistify props = Custom ("alignJistify", props)
        let AlignLeft props = Custom ("alignLeft", props)
        let AlignRight props = Custom ("alignRight", props)
        let AlternativeLabel props = Custom ("alternativeLabel", props)
        let AnchorOriginBottomCenter props = Custom ("anchorOriginBottomCenter", props)
        let AnchorOriginBottomLeft props = Custom ("anchorOriginBottomLeft", props)
        let AnchorOriginBottomRight props = Custom ("anchorOriginBottomRight", props)
        let AnchorOriginTopCenter props = Custom ("anchorOriginTopCenter", props)
        let AnchorOriginTopLeft props = Custom ("anchorOriginTopLeft", props)
        let AnchorOriginTopRight props = Custom ("anchorOriginTopRight", props)
        let Animated props = Custom ("animated", props)
        let Asterisk props = Custom ("asterisk", props)
        let Avatar props = Custom ("avatar", props)
        let AvatarChildren props = Custom ("avatarChildren", props)
        let Badge props = Custom ("badge", props)
        let Bar props = Custom ("bar", props)
        let Bar1Buffer props = Custom ("bar1Buffer", props)
        let Bar1Determinate props = Custom ("bar1Determinate", props)
        let Bar1Indeterminate props = Custom ("bar1Indeterminate", props)
        let Bar2Buffer props = Custom ("bar2Buffer", props)
        let Bar2Determinate props = Custom ("bar2Determinate", props)
        let Bar2Indeterminate props = Custom ("bar2Indeterminate", props)
        let BarColorPrimary props = Custom ("barColorPrimary", props)
        let BarColorSecondary props = Custom ("barColorSecondary", props)
        let Body props = Custom ("body", props)
        let Body1 props = Custom ("body1", props)
        let Body2 props = Custom ("body2", props)
        let Button props = Custom ("button", props)
        let Caption props = Custom ("caption", props)
        let Centered props = Custom ("centered", props)
        let Checked props = Custom ("checked", props)
        let Child props = Custom ("child", props)
        let ChildLeaving props = Custom ("childLeaving", props)
        let ChildPulsate props = Custom ("childPulsate", props)
        let Circle props = Custom ("circle", props)
        let CircleIndeterminate props = Custom ("circleIndeterminate", props)
        let CircleStatic props = Custom ("circleStatic", props)
        let Clickable props = Custom ("clickable", props)
        let ColorAction props = Custom ("colorAction", props)
        let ColorDefault props = Custom ("colorDefault", props)
        let ColorDisabled props = Custom ("colorDisabled", props)
        let ColorError props = Custom ("colorError", props)
        let ColorInherit props = Custom ("colorInherit", props)
        let ColorPrimary props = Custom ("colorPrimary", props)
        let ColorSecondary props = Custom ("colorSecondary", props)
        let ColorTextPrimary props = Custom ("colorTextPrimary", props)
        let ColorTextSecondary props = Custom ("colorTextSecondary", props)
        let Completed props = Custom ("completed", props)
        let Contained props = Custom ("contained", props)
        let ContainedPrimary props = Custom ("containedPrimary", props)
        let ContainedSecondary props = Custom ("containedSecondary", props)
        let Container props = Custom ("container", props)
        let Content props = Custom ("content", props)
        let Default props = Custom ("default", props)
        let Deletable props = Custom ("deletable", props)
        let DeleteIcon props = Custom ("deleteIcon", props)
        let Dense props = Custom ("dense", props)
        let Disabled props = Custom ("disabled", props)
        let Display1 props = Custom ("display1", props)
        let Display2 props = Custom ("display2", props)
        let Display3 props = Custom ("display3", props)
        let Display4 props = Custom ("display4", props)
        let Divider props = Custom ("divider", props)
        let Docked props = Custom ("docked", props)
        let Dot props = Custom ("dot", props)
        let DotActive props = Custom ("dotActive", props)
        let Dots props = Custom ("dots", props)
        let Elevation0 props = Custom ("elevation0", props)
        let Elevation1 props = Custom ("elevation1", props)
        let Elevation10 props = Custom ("elevation10", props)
        let Elevation11 props = Custom ("elevation11", props)
        let Elevation12 props = Custom ("elevation12", props)
        let Elevation13 props = Custom ("elevation13", props)
        let Elevation14 props = Custom ("elevation14", props)
        let Elevation15 props = Custom ("elevation15", props)
        let Elevation16 props = Custom ("elevation16", props)
        let Elevation17 props = Custom ("elevation17", props)
        let Elevation18 props = Custom ("elevation18", props)
        let Elevation19 props = Custom ("elevation19", props)
        let Elevation2 props = Custom ("elevation2", props)
        let Elevation20 props = Custom ("elevation20", props)
        let Elevation21 props = Custom ("elevation21", props)
        let Elevation22 props = Custom ("elevation22", props)
        let Elevation23 props = Custom ("elevation23", props)
        let Elevation24 props = Custom ("elevation24", props)
        let Elevation3 props = Custom ("elevation3", props)
        let Elevation4 props = Custom ("elevation4", props)
        let Elevation5 props = Custom ("elevation5", props)
        let Elevation6 props = Custom ("elevation6", props)
        let Elevation7 props = Custom ("elevation7", props)
        let Elevation8 props = Custom ("elevation8", props)
        let Elevation9 props = Custom ("elevation9", props)
        let Entered props = Custom ("entered", props)
        let Error props = Custom ("error", props)
        let ExpandIcon props = Custom ("expandIcon", props)
        let Expanded props = Custom ("expanded", props)
        let ExtendedFab props = Custom ("extendedFab", props)
        let Fab props = Custom ("fab", props)
        let Filled props = Custom ("filled", props)
        let Fixed props = Custom ("fixed", props)
        let Flat props = Custom ("flat", props)
        let FlatPrimary props = Custom ("flatPrimary", props)
        let FlatSecondary props = Custom ("flatSecondary", props)
        let FlexContainer props = Custom ("flexContainer", props)
        let FocusVisible props = Custom ("focusVisible", props)
        let FocusHiglight props = Custom ("focusHiglight", props)
        let Focused props = Custom ("focused", props)
        let FontSizeInherit props = Custom ("fontSizeInherit", props)
        let Footer props = Custom ("footer", props)
        let Form props = Custom ("form", props)
        let FormControl props = Custom ("formControl", props)
        let FullWidth props = Custom ("fullWidth", props)
        let GutterBottom props = Custom ("gutterBottom", props)
        let Gutters props = Custom ("gutters", props)
        let H1 props = Custom ("h1", props)
        let H2 props = Custom ("h2", props)
        let H3 props = Custom ("h3", props)
        let H4 props = Custom ("h4", props)
        let H5 props = Custom ("h5", props)
        let H6 props = Custom ("h6", props)
        let Subtitle1 props = Custom ("subtitle1", props)
        let Subtitle2 props = Custom ("subtitle2", props)
        let Overline props = Custom ("overline", props)
        let SrOnly props = Custom ("srOnly", props)
        let Head props = Custom ("head", props)
        let Headline props = Custom ("headline", props)
        let Hidden props = Custom ("hidden", props)
        let Horizontal props = Custom ("horizontal", props)
        let Hover props = Custom ("hover", props)
        let Icon props = Custom ("icon", props)
        let IconContainer props = Custom ("iconContainer", props)
        let IconDirectionAsc props = Custom ("iconDirectionAsc", props)
        let IconDirectionDesc props = Custom ("iconDirectionDesc", props)
        let Img props = Custom ("img", props)
        let ImgFullHeight props = Custom ("imgFullHeight", props)
        let ImgFullWidth props = Custom ("imgFullWidth", props)
        let Indeterminate props = Custom ("indeterminate", props)
        let Indicator props = Custom ("indicator", props)
        let Input props = Custom ("input", props)
        let InputMarginDense props = Custom ("inputMarginDense", props)
        let InputMultiline props = Custom ("inputMultiline", props)
        let InputType props = Custom ("inputType", props)
        let InputTypeSearch props = Custom ("inputTypeSearch", props)
        let Inset props = Custom ("inset", props)
        let Invisible props = Custom ("invisible", props)
        let Item props = Custom ("item", props)
        let Label props = Custom ("label", props)
        let LabelContainer props = Custom ("labelContainer", props)
        let LabelIcon props = Custom ("labelIcon", props)
        let LabelPlacementStart props = Custom ("labelPlacementStart", props)
        let LabelWrapped props = Custom ("labelWrapped", props)
        let Last props = Custom ("last", props)
        let Layout props = Custom ("layout", props)
        let Light props = Custom ("light", props)
        let Line props = Custom ("line", props)
        let LineHorizontal props = Custom ("lineHorizontal", props)
        let LineVertical props = Custom ("lineVertical", props)
        let MarginDense props = Custom ("marginDense", props)
        let MarginNormal props = Custom ("marginNormal", props)
        let Media props = Custom ("media", props)
        let MenuItem props = Custom ("menuItem", props)
        let Message props = Custom ("message", props)
        let Mini props = Custom ("mini", props)
        let Modal props = Custom ("modal", props)
        let Multiline props = Custom ("multiline", props)
        let NoWrap props = Custom ("noWrap", props)
        let Numeric props = Custom ("numeric", props)
        let Outlined props = Custom ("outlined", props)
        let OutlinedPrimary props = Custom ("outlinedPrimary", props)
        let OutlinedSecondary props = Custom ("outlinedSecondary", props)
        let Padding props = Custom ("padding", props)
        let PaddingCheckbox props = Custom ("paddingCheckbox", props)
        let PaddingDense props = Custom ("paddingDense", props)
        let PaddingNone props = Custom ("paddingNone", props)
        let Paper props = Custom ("paper", props)
        let PaperAnchorBottom props = Custom ("paperAnchorBottom", props)
        let PaperAnchorDockedBottom props = Custom ("paperAnchorDockedBottom", props)
        let PaperAnchorDockedLeft props = Custom ("paperAnchorDockedLeft", props)
        let PaperAnchorDockedRight props = Custom ("paperAnchorDockedRight", props)
        let PaperAnchorDockedTop props = Custom ("paperAnchorDockedTop", props)
        let PaperAnchorLeft props = Custom ("paperAnchorLeft", props)
        let PaperAnchorRight props = Custom ("paperAnchorRight", props)
        let PaperAnchorTop props = Custom ("paperAnchorTop", props)
        let PaperFullScreen props = Custom ("paperFullScreen", props)
        let PaperFullWidth props = Custom ("paperFullWidth", props)
        let PaperScrollBody props = Custom ("paperScrollBody", props)
        let PaperScrollPaper props = Custom ("paperScrollPaper", props)
        let PaperWidthMd props = Custom ("paperWidthMd", props)
        let PaperWidthSm props = Custom ("paperWidthSm", props)
        let PaperWidthXs props = Custom ("paperWidthXs", props)
        let Paragraph props = Custom ("paragraph", props)
        let Popper props = Custom ("popper", props)
        let PositionAbsolute props = Custom ("positionAbsolute", props)
        let PositionBottom props = Custom ("positionBottom", props)
        let PositionEnd props = Custom ("positionEnd", props)
        let PositionFixed props = Custom ("positionFixed", props)
        let PositionStart props = Custom ("positionStart", props)
        let PositionStatic props = Custom ("positionStatic", props)
        let PositionSticky props = Custom ("positionSticky", props)
        let PositionTop props = Custom ("positionTop", props)
        let Primary props = Custom ("primary", props)
        let Progress props = Custom ("progress", props)
        let Raised props = Custom ("raised", props)
        let RaisedPrimary props = Custom ("raisedPrimary", props)
        let RaisedSecondary props = Custom ("raisedSecondary", props)
        let Required props = Custom ("required", props)
        let Regular props = Custom ("regular", props)
        let Ripple props = Custom ("ripple", props)
        let RipplePulsate props = Custom ("ripplePulsate", props)
        let RippleVisible props = Custom ("rippleVisible", props)
        let Root props = Custom ("root", props)
        let RootSubtitle props = Custom ("rootSubtitle", props)
        let Rounded props = Custom ("rounded", props)
        let Row props = Custom ("row", props)
        let ScrollButtons props = Custom ("scrollButtons", props)
        let ScrollButtonsAuto props = Custom ("scrollButtonsAuto", props)
        let Scrollable props = Custom ("scrollable", props)
        let Scroller props = Custom ("scroller", props)
        let Secondary props = Custom ("secondary", props)
        let SecondaryAction props = Custom ("secondaryAction", props)
        let Select props = Custom ("select", props)
        let SelectIcon props = Custom ("selectIcon", props)
        let SelectMenu props = Custom ("selectMenu", props)
        let SelectRoot props = Custom ("selectRoot", props)
        let Selected props = Custom ("selected", props)
        let Shrink props = Custom ("shrink", props)
        let SizeLarge props = Custom ("sizeLarge", props)
        let SizeSmall props = Custom ("sizeSmall", props)
        let Spacer props = Custom ("spacer", props)
        let Static props = Custom ("static", props)
        let Sticky props = Custom ("sticky", props)
        let Subheader props = Custom ("subheader", props)
        let Subheading props = Custom ("subheading", props)
        let Subtitle props = Custom ("subtitle", props)
        let Svg props = Custom ("svg", props)
        let SwitchBase props = Custom ("switchBase", props)
        let Text props = Custom ("text", props)
        let TextColorInherit props = Custom ("textColorInherit", props)
        let TextColorPrimary props = Custom ("textColorPrimary", props)
        let TextColorSecondary props = Custom ("textColorSecondary", props)
        let TextDense props = Custom ("textDense", props)
        let TextPrimary props = Custom ("textPrimary", props)
        let TextSecondary props = Custom ("textSecondary", props)
        let Tile props = Custom ("tile", props)
        let Title props = Custom ("title", props)
        let TitlePositionBottom props = Custom ("titlePositionBottom", props)
        let TitlePositionTop props = Custom ("titlePositionTop", props)
        let TitleWrap props = Custom ("titleWrap", props)
        let TitleWrapActionPosLeft props = Custom ("titleWrapActionPosLeft", props)
        let TitleWrapActionPosRight props = Custom ("titleWrapActionPosRight", props)
        let Toolbar props = Custom ("toolbar", props)
        let Tooltip props = Custom ("tooltip", props)
        let TooltipPlacementBottom props = Custom ("tooltipPlacementBottom", props)
        let TooltipPlacementLeft props = Custom ("tooltipPlacementLeft", props)
        let TooltipPlacementRight props = Custom ("tooltipPlacementRight", props)
        let TooltipPlacementTop props = Custom ("tooltipPlacementTop", props)
        let Touch props = Custom ("touch", props)
        let TouchRipple props = Custom ("touchRipple", props)
        let Transition props = Custom ("transition", props)
        let Underline props = Custom ("underline", props)
        let Vertical props = Custom ("vertical", props)
        let Wrapper props = Custom ("wrapper", props)
        let WrapperInner props = Custom ("wrapperInner", props)
        let ZeroMinWidth props = Custom ("zeroMinWidth", props)
        let ``Align-content-xs-center`` props = Custom ("align-content-xs-center``", props)
        let ``Align-content-xs-flex-end`` props = Custom ("align-content-xs-flex-end``", props)
        let ``Align-content-xs-flex-start`` props = Custom ("align-content-xs-flex-start``", props)
        let ``Align-content-xs-space-around`` props = Custom ("align-content-xs-space-around``", props)
        let ``Align-content-xs-space-between`` props = Custom ("align-content-xs-space-between``", props)
        let ``Align-items-xs-baseline`` props = Custom ("align-items-xs-baseline``", props)
        let ``Align-items-xs-center`` props = Custom ("align-items-xs-center``", props)
        let ``Align-items-xs-flex-end`` props = Custom ("align-items-xs-flex-end``", props)
        let ``Align-items-xs-flex-start`` props = Custom ("align-items-xs-flex-start``", props)
        let ``Direction-xs-column-reverse`` props = Custom ("direction-xs-column-reverse``", props)
        let ``Direction-xs-column`` props = Custom ("direction-xs-column``", props)
        let ``Direction-xs-row-reverse`` props = Custom ("direction-xs-row-reverse``", props)
        let ``Grid-xs-10`` props = Custom ("grid-xs-10``", props)
        let ``Grid-xs-11`` props = Custom ("grid-xs-11``", props)
        let ``Grid-xs-12`` props = Custom ("grid-xs-12``", props)
        let ``Grid-xs-1`` props = Custom ("grid-xs-1``", props)
        let ``Grid-xs-2`` props = Custom ("grid-xs-2``", props)
        let ``Grid-xs-3`` props = Custom ("grid-xs-3``", props)
        let ``Grid-xs-4`` props = Custom ("grid-xs-4``", props)
        let ``Grid-xs-5`` props = Custom ("grid-xs-5``", props)
        let ``Grid-xs-6`` props = Custom ("grid-xs-6``", props)
        let ``Grid-xs-7`` props = Custom ("grid-xs-7``", props)
        let ``Grid-xs-8`` props = Custom ("grid-xs-8``", props)
        let ``Grid-xs-9`` props = Custom ("grid-xs-9``", props)
        let ``Grid-xs-auto`` props = Custom ("grid-xs-auto``", props)
        let ``Grid-xs-true`` props = Custom ("grid-xs-true``", props)
        let ``Justify-xs-center`` props = Custom ("justify-xs-center``", props)
        let ``Justify-xs-flex-end`` props = Custom ("justify-xs-flex-end``", props)
        let ``Justify-xs-space-around`` props = Custom ("justify-xs-space-around``", props)
        let ``Justify-xs-space-between`` props = Custom ("justify-xs-space-between``", props)
        let ``Justify-xs-space-evenly`` props = Custom ("justify-xs-space-evenly``", props)
        let ``Spacing-xs-16`` props = Custom ("spacing-xs-16``", props)
        let ``Spacing-xs-24`` props = Custom ("spacing-xs-24``", props)
        let ``Spacing-xs-32`` props = Custom ("spacing-xs-32``", props)
        let ``Spacing-xs-40`` props = Custom ("spacing-xs-40``", props)
        let ``Spacing-xs-8`` props = Custom ("spacing-xs-8``", props)
        let ``Wrap-xs-nowrap`` props = Custom ("wrap-xs-nowrap``", props)
        let ``Wrap-xs-wrap-reverse`` props = Custom ("wrap-xs-wrap-reverse``", props)

    type [<Erase; RequireQualifiedAccess>] StyleType =
        | Styles of IStyles list
        | Func of (ITheme->IStyles list)

    type IClassNames = interface end

    type ClassNames =
        | AdornedStart of string
        | AdornedEnd of string
        | NotchedOutline of string
        | InputAdornedStart of string
        | InputAdornedEnd of string
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
        | FocusHiglight of string
        | Focused of string
        | FontSizeInherit of string
        | Footer of string
        | Form of string
        | FormControl of string
        | FullWidth of string
        | GutterBottom of string
        | Gutters of string
        | H1 of string
        | H2 of string
        | H3 of string
        | H4 of string
        | H5 of string
        | H6 of string
        | Subtitle1 of string
        | Subtitle2 of string
        | Overline of string
        | SrOnly of string
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
        | [<Erase>] Custom of string * string
        interface IClassNames

[<AutoOpen>]
module Colors =
    open Fable.Core.JsInterop
    open Themes
    let red = importDefault<IColor> "@material-ui/core/colors/red"
    let pink = importDefault<IColor> "@material-ui/core/colors/pink"
    let purple = importDefault<IColor> "@material-ui/core/colors/purple"
    let deepPurple = importDefault<IColor> "@material-ui/core/colors/deepPurple"
    let indigo = importDefault<IColor> "@material-ui/core/colors/indigo"
    let blue = importDefault<IColor> "@material-ui/core/colors/blue"
    let lightBlue = importDefault<IColor> "@material-ui/core/colors/lightBlue"
    let cyan = importDefault<IColor> "@material-ui/core/colors/cyan"
    let teal = importDefault<IColor> "@material-ui/core/colors/teal"
    let green = importDefault<IColor> "@material-ui/core/colors/green"
    let lightGreen = importDefault<IColor> "@material-ui/core/colors/lightGreen"
    let lime = importDefault<IColor> "@material-ui/core/colors/lime"
    let yellow = importDefault<IColor> "@material-ui/core/colors/yellow"
    let amber = importDefault<IColor> "@material-ui/core/colors/amber"
    let orange = importDefault<IColor> "@material-ui/core/colors/orange"
    let deepOrange = importDefault<IColor> "@material-ui/core/colors/deepOrange"
    let brown = importDefault<IColor> "@material-ui/core/colors/brown"
    let grey = importDefault<IColor> "@material-ui/core/colors/grey"
    let blueGrey = importDefault<IColor> "@material-ui/core/colors/blueGrey"

[<AutoOpen>]
module Props =
    open Fable.Core
    open Fable.Helpers.React.Props

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

    type [<StringEnum; RequireQualifiedAccess>] PlacementType =
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

    type StyleOption =
        | WithTheme of bool
        | Name of string
        | Flip of bool

    type TransitionDurationProp =
        | Enter of float
        | Exit of float

    type TransitionDuration = U2<float, TransitionDurationProp list>
    type AutoTransitionDuration = U3<float, TransitionDuration list, AutoEnum>
    type RefProp = U2<obj,(Fable.Import.React.ReactInstance->unit)>

    type MaterialProp =
        | Active of bool
        | AnchorEl of Fable.Import.React.ReactInstance
        | CheckedIcon of Fable.Import.React.ReactNode
        | Color of ComponentColor
        | Component of Fable.Import.React.ReactType
        | Container of Fable.Import.React.ReactInstance
        | Dense of bool
        | DisableGutters of bool
        | DisablePortal of bool
        | DisableRipple of bool
        | DisableTypography of bool
        | Elevation of int
        | Error of bool
        | FullWidth of bool
        | Icon of Fable.Import.React.ReactNode
        | In of bool
        | InputProps of IHTMLProp list
        | InputRef of RefProp
        | Inset of bool
        | KeepMounted of bool
        | Label of Fable.Import.React.ReactNode
        | Margin of FormControlMargin
        | Multiline of bool
        | Open of bool
        | Optional of Fable.Import.React.ReactNode
        | Placement of PlacementType
        | RowsMax of int
        | Timeout of TransitionDuration
        | TransitionDuration of TransitionDuration
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
    
    module MaterialProp =
        open Fable.Core.JsInterop
        let inline Classes (classNames : IClassNames list) = HTMLAttr.Custom("classes", classNames |> keyValueList CaseRules.LowerFirst)

    type TransitionProp =
        | MountOnEnter of bool
        | UnmountOnExit of bool
        | Appear of bool
        | Enter of bool
        | Exit of bool
        | AddEndListener of (obj->(obj->unit)->unit)
        interface IHTMLProp

    type SelectionControlProp =
        | Color of SelectionControlColor
        | OnChange of (Fable.Import.React.FormEvent->bool->unit)
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] AppBarPosition =
        | Fixed
        | Absolute
        | Sticky
        | Static
        | Relative

    type AppBarProp =
        | Position of AppBarPosition
        interface IHTMLProp

    type AvatarProp =
        | ImgProps of IHTMLProp list
        | Sizes of string
        interface IHTMLProp

    type BackdropProp =
        | Invisible of bool
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] BadgeColor = Default | Primary | Secondary | Error

    type BadgeProp =
        | Color of BadgeColor
        | BadgeContent of Fable.Import.React.ReactNode
        interface IHTMLProp

    type BottomNavigationProp =
        | OnChange of (obj->obj->unit)
        | ShowLabels of bool
        | Value of obj
        interface IHTMLProp

    type BottomNavigationActionProp =
        | ShowLabel of bool
        | Value of obj
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] ButtonSize =
        | Small
        | Medium
        | Large

    type [<StringEnum; RequireQualifiedAccess>] ButtonVariant =
        | Text
        | [<Obsolete("Material-UI@3.2.0: The `flat` Button variant will be removed in the next major release of Material-UI. `text` is equivalent and should be used instead.")>]
            Flat
        | Outlined
        | Contained
        | [<Obsolete("Material-UI@3.2.0: The `raised` Button variant will be removed in the next major release of Material-UI. `contained` is equivalent and should be used instead.")>]
            Raised
        | Fab
        | ExtendedFab

    type ButtonProp =
        | DisableFocusRipple of bool
        | Href of string
        | Mini of bool
        | Size of ButtonSize
        | Variant of ButtonVariant
        interface IHTMLProp

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
        | OnFocusVisible of (Fable.Import.React.FocusEvent->unit)
        | Type of ButtonBaseType
        interface IHTMLProp

    type CardProp =
        | Raised of bool
        interface IHTMLProp

    type CardActionsProp =
        | DisableActionSpacing of bool
        interface IHTMLProp

    type CardHeaderProp =
        | Action of Fable.Import.React.ReactNode
        | Avatar of Fable.Import.React.ReactNode
        | Subheader of Fable.Import.React.ReactNode
        | SubheaderTypographyProps of IHTMLProp list
        | Title of Fable.Import.React.ReactNode
        | TitleTypographyProps of IHTMLProp list
        interface IHTMLProp

    type CardMediaProp =
        | Image of string
        interface IHTMLProp

    type CheckboxProp =
        | Indeterminate of bool
        | IndeterminateIcon of Fable.Import.React.ReactNode
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] ChipVariant = Default | Outlined
    type ChipProp =
        | Avatar of Fable.Import.React.ReactElement
        | Clickable of bool
        | DeleteIcon of Fable.Import.React.ReactElement
        | OnDelete of (Fable.Import.React.FormEvent->unit)
        | Variant of ChipVariant
        interface IHTMLProp

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

    type CollapseProp =
        | CollapseHeight of string
        | Timeout of AutoTransitionDuration
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] DialogScroll = Body | Paper
    type [<StringEnum; RequireQualifiedAccess>] DialogMaxWidth =
        | Xs
        | Sm
        | Md
        | Lg
        | [<CompiledName("")>] False

    type DialogProp =
        | FullScreen of bool
        | MaxWidth of DialogMaxWidth
        | Scroll of DialogScroll
        interface IHTMLProp

    type DialogActionsProp =
        | DisableActionSpacing of bool
        interface IHTMLProp

    type DividerProp =
        | Absolute of bool
        | Light of bool
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] DrawerVariant = Permanent | Persistent | Temporary

    type DrawerProp =
        | Anchor of Anchor
        | Variant of DrawerVariant
        interface IHTMLProp

    type ExpansionPanelProp =
        | Expanded of bool
        | DefaultExpanded of bool
        | OnChange of (obj->bool->unit)
        interface IHTMLProp

    type ExpansionPanelSummaryProp =
        | ExpandIcon of Fable.Import.React.ReactNode
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] FormControlLabelPlacement = End | Start

    type FormControlLabelProp =
        | Control of Fable.Import.React.ReactElement
        | LabelPlacement of FormControlLabelPlacement
        | OnChange of (obj->bool->unit)
        interface IHTMLProp

    type FormGroupProp =
        | Row of bool
        interface IHTMLProp

    type FormLabelProp =
        | Focused of bool
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] GridAlignContent =
        | Stretch
        | Center
        | [<CompiledName("flex-start")>] FlexStart
        | [<CompiledName("flex-end")>] FlexEnd
        | [<CompiledName("space-between")>] SpaceBetween
        | [<CompiledName("space-around")>] SpaceAround

    type [<StringEnum; RequireQualifiedAccess>] GridJustify =
        | Center
        | [<CompiledName("flex-start")>] FlexStart
        | [<CompiledName("flex-end")>] FlexEnd
        | [<CompiledName("space-between")>] SpaceBetween
        | [<CompiledName("space-around")>] SpaceAround
        | [<CompiledName("space-evenly")>] SpaceEvenly

    type [<StringEnum; RequireQualifiedAccess>] GridAlignItems =
        | Stretch
        | Center
        | BaseLine
        | [<CompiledName("flex-start")>] FlexStart
        | [<CompiledName("flex-end")>] FlexEnd

    type [<StringEnum; RequireQualifiedAccess>] GridDirection =
        | Row
        | Column
        | [<CompiledName("row-reverse")>] RowReverse
        | [<CompiledName("column-reverse")>] ColumnReverse

    type [<RequireQualifiedAccess>] GridSpacing =
        | ``0`` = 0
        | ``8`` = 8
        | ``16`` = 16
        | ``24`` = 24
        | ``32`` = 32
        | ``40`` = 40

    type [<StringEnum; RequireQualifiedAccess>] GridWrap =
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
        | AlignContent of GridAlignContent
        | AlignItems of GridAlignItems
        | Container of bool
        | Direction of GridDirection
        | Item of bool
        | Justify of GridJustify
        | Lg of GridSize
        | Md of GridSize
        | Sm of GridSize
        | Xl of GridSize
        | Xs of GridSize
        | Spacing of GridSpacing
        | Wrap of GridWrap
        | ZeroMinWidth of bool
        interface IHTMLProp

    type GridListCellHeight = U2<int, AutoEnum>
    type GridListProp =
        | CellHeight of GridListCellHeight
        | Spacing of int
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] ActionPosition = Left | Right
    type [<StringEnum; RequireQualifiedAccess>] TitlePosition = Top | Bottom

    type GridListTileBarProp =
        | ActionIcon of Fable.Import.React.ReactNode
        | ActionPosition of ActionPosition
        | Subtitle of Fable.Import.React.ReactNode
        | Title of Fable.Import.React.ReactNode
        | TitlePosition of TitlePosition
        interface IHTMLProp

    type GrowProp =
        | Timeout of AutoTransitionDuration
        interface IHTMLProp

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

    type [<StringEnum; RequireQualifiedAccess>] IconFontSize =
        | Inherit
        | Default
        | Small
        | Large

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

    type [<StringEnum; RequireQualifiedAccess>] InputMargin = None | Dense

    type InputProp =
        | DisableUnderline of bool
        | EndAdornment of Fable.Import.React.ReactNode
        | InputComponent of Fable.Import.React.ReactType
        | StartAdornment of Fable.Import.React.ReactNode
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] InputAdornmentPosition = Start | End
    type [<StringEnum; RequireQualifiedAccess>] InputAdornmentVariant = Standard | Outlined | Filled

    type InputAdornmentProp =
        | Position of InputAdornmentPosition
        | Variant of InputAdornmentVariant
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] InputLabelMargin = Dense
    type [<StringEnum; RequireQualifiedAccess>] InputLabelVariant = Standard | Outlined | Filled

    type InputLabelProp =
        | DisableAnimation of bool
        | Margin of InputLabelMargin
        | Shrink of bool
        | Variant of InputLabelVariant
        interface IHTMLProp

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

    type ListProp =
        | DisablePadding of bool
        | Subheader of Fable.Import.React.ReactElement
        interface IHTMLProp

    type ListItemProp =
        | Button of bool
        | Divider of bool
        interface IHTMLProp

    type ListItemTextProp =
        | Primary of Fable.Import.React.ReactNode
        | PrimaryTypographyProps of IHTMLProp list
        | Secondary of Fable.Import.React.ReactNode
        | SecondaryTypographyProps of IHTMLProp list
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] ListSubheaderColor = Default | Primary | Inherit

    type ListSubheaderProp =
        | Color of ListSubheaderColor
        | DisableSticky of bool
        interface IHTMLProp

    type MenuProp =
        | DisableAutoFocusItem of bool
        | TransitionDuration of AutoTransitionDuration
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] MobileStepperPosition = Bottom | Top | Static
    type [<StringEnum; RequireQualifiedAccess>] MobileStepperVariant = Text | Dots | Progress

    type MobileStepperProp =
        | ActiveStep of int
        | BackButton of Fable.Import.React.ReactElement
        | NextButton of Fable.Import.React.ReactElement
        | Position of MobileStepperPosition
        | Steps of int
        | Variant of MobileStepperVariant
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] ModalCloseReason = EscapeKeyDown | BackdropClick

    type ModalProp =
        | DisableAutoFocus of bool
        | DisableBackdropClick of bool
        | DisableEnforceFocus of bool
        | DisableEscapeKeyDown of bool
        | DisableRestoreFocus of bool
        | HideBackdrop of bool
        | Manager of obj // TODO check static type for ModalManager
        | OnBackdropClick of (obj->unit)
        | OnEscapeKeyDown of (obj->unit)
        | OnClose of (obj->ModalCloseReason->unit)
        interface IHTMLProp

    type OutlinedInputProp =
        | Notched of bool
        interface IHTMLProp

    type PaperProp =
        | Square of bool
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] PopoverHorizontalPosition = Left | Center | Right
    type [<StringEnum; RequireQualifiedAccess>] PopoverVerticalPosition = Top | Center | Bottom
    type [<StringEnum; RequireQualifiedAccess>] AnchorReference = AnchorEl | AnchorPosition | None
    and  AnchorPosition = {
        left: int
        top: int
    }

    type PopoverHorizontalOrigin = U2<int,PopoverHorizontalPosition>
    type PopoverVerticalOrigin = U2<int,PopoverVerticalPosition>
    type  PopoverOrigin = {
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

    type PopperProp =
        | Modifies of obj
        | PopperOptions of obj
        | Transition of bool
        interface IHTMLProp

    type RadioGroupProp =
        | OnChange of (obj->string->unit)
        interface IHTMLProp

    type RootRefProp =
        | RootRef of RefProp
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] SelectVariant = Standard | Outlined | Filled
    type SelectProp =
        | AutoWidth of bool
        | DisplayEmpty of bool
        | Input of Fable.Import.React.ReactNode
        | Native of bool
        | OnChange of (obj->obj->unit)
        | RenderValue of (obj->Fable.Import.React.ReactNode)
        | Variant of SelectVariant
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] SlideDirection = Bottom | Up | Left | Right

    type SlideProp =
        | Direction of SlideDirection
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] SnackbarHorizontalOrigin = Left | Center | Right
    type [<StringEnum; RequireQualifiedAccess>] SnackbarVerticalOrigin = Top | Center | Bottom
    type [<StringEnum; RequireQualifiedAccess>] SnackbarCloseReason = Timeout | Clickaway

    type  SnackbarOrigin = {
        vertical: SnackbarVerticalOrigin
        horizontal: SnackbarHorizontalOrigin
    }

    type SnackbarProp =
        | Action of Fable.Import.React.ReactElement
        | AnchorOrigin of SnackbarOrigin
        | AutoHideDuration of int
        | DisableWidnowBlurListener of bool
        | Message of Fable.Import.React.ReactElement
        | OnClose of (obj->SnackbarCloseReason->unit)
        | ResumeHideDuration of int
        interface IHTMLProp

    type StepProp =
        | Completed of bool
        interface IHTMLProp

    type StepContentProp =
        | TransitionDuration of AutoTransitionDuration
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] StepperOrientation = Vertical | Horizontal

    type StepperProp =
        | ActiveStep of int
        | AlternativeLabel of bool
        | Connector of Fable.Import.React.ReactElement
        | NonLinear of bool
        | Orientation of StepperOrientation
        interface IHTMLProp

    type SvgIconProp =
        | NativeColor of string
        | TitleAccess of string
        interface IHTMLProp

    type SwipeableDrawerProp =
        | DisableBackdropTransition of bool
        | DisableDiscovery of bool
        | DisableSwipeToOpen of bool
        | SwipeAreaWidth of int
        | Hysteresis of float
        | MinFlingVelocity of int
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] TabsIndicatorColor = Primary | Secondary
    type [<StringEnum; RequireQualifiedAccess>] TabsTextColor = Primary | Secondary | Inherit
    type [<StringEnum; RequireQualifiedAccess>] ScrollButtonsType = Auto | On | Off

    type ITabsActions =
        abstract member updateIndicator: unit -> unit

    type TabsProp =
        | Action of (ITabsActions->unit)
        | Centered of bool
        | IndicatorColor of TabsIndicatorColor
        | OnChange of (obj->int->unit)
        | Scrollabel of bool
        | ScrollButtons of ScrollButtonsType
        | TextColor of TabsTextColor
        interface IHTMLProp

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

    type ILabelDisplayedRowsArgs =
        abstract member from: int
        abstract member ``to``: int
        abstract member count: int
        abstract member page: int

    type TablePaginationProp =
        | BackIconButtonProps of IHTMLProp list
        | Count of int
        | LabelDisplayedRows of (ILabelDisplayedRowsArgs->Fable.Import.React.ReactNode)
        | LabelRowsPerPage of Fable.Import.React.ReactNode
        | NextIconButtonPropss of IHTMLProp list
        | OnChangePage of (obj->int->unit)
        | OnChangeRowsPerPage of (obj->unit)
        | Page of int
        | RowsPerPage of int
        | RowsPerPageOptions of int list
        interface IHTMLProp

    type TableRowProp =
        | Hover of bool
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] TableSortDirection = Asc | Desc
    type TableSortLabelProp =
        | Direction of TableSortDirection
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] TextFieldVariant =
        | Standard
        | Outlined
        | Filled

    type TextFieldProp =
        | HelperText of Fable.Import.React.ReactNode
        | Select of bool
        | Variant of TextFieldVariant
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] ToolbarVariant = Regular | Dense
    type ToolbarProp =
        | Variant of ToolbarVariant
        interface IHTMLProp

    type TooltipProp =
        | DisableFocusListener of bool
        | DisableHoverListener of bool
        | DisableTouchListener of bool
        | EnterDelay of int
        | EnterTouchDelay of int
        | LeaveDelay of int
        | LeaveTouchDelay of int
        | Title of Fable.Import.React.ReactNode
        interface IHTMLProp

    type TouchRippleProp =
        | Center of bool
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] TypographyAlign =
        | Inherit
        | Left
        | Center
        | Right
        | Justify

    type [<StringEnum; RequireQualifiedAccess>] TypographyColor =
        | Default
        | Error
        | Inherit
        | Primary
        | Secondary
        | TextPrimary
        | TextSecondary

    type [<StringEnum; RequireQualifiedAccess>] TypographyVariant =
        | H1
        | H2
        | H3
        | H4
        | H5
        | H6
        | Subtitle1
        | Subtitle2
        | Overline
        | SrOnly
        | Body1
        | Body2
        | Caption
        | Button
        | Inherit
        // Depreceted
        | [<Obsolete("Material-UI@3.2.0: Typography type `Display1` is deprecated. Please use `H4` instead")>] Display1
        | [<Obsolete("Material-UI@3.2.0: Typography type `Display2` is deprecated. Please use `H3` instead")>] Display2
        | [<Obsolete("Material-UI@3.2.0: Typography type `Display3` is deprecated. Please use `H2` instead")>] Display3
        | [<Obsolete("Material-UI@3.2.0: Typography type `Display4` is deprecated. Please use `H1` instead")>] Display4
        | [<Obsolete("Material-UI@3.2.0: Typography type `Headline` is deprecated. Please use `H5` instead")>] Headline
        | [<Obsolete("Material-UI@3.2.0: Typography type `Title` is deprecated. Please use `H6` instead")>] Title
        | [<Obsolete("Material-UI@3.2.0: Typography type `Subheading` is deprecated. Please use `Subtitle1` instead")>] Subheading

    type TypographyProp =
        | Align of TypographyAlign
        | Color of TypographyColor
        | GutterBottom of bool
        | HeadlineMapping of obj // TODO strong type
        | NoWrap of bool
        | Paragraph of bool
        | Variant of TypographyVariant
        interface IHTMLProp

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
        | Type of Themes.PaletteType
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

    type ThemeTypographyProp =
        | FontFamily of string
        | FontSize of string
        | FontWeightLight of int
        | FontWeightRegular of int
        | FontWeightMedium of int
        | HtmlFontSize of string
        | AllVariants of CSSProp list
        | UseNextVariants of bool

        | H1 of TextStyleProp list
        | H2 of TextStyleProp list
        | H3 of TextStyleProp list
        | H4 of TextStyleProp list
        | H5 of TextStyleProp list
        | H6 of TextStyleProp list
        | Subtitle1 of TextStyleProp list
        | Subtitle2 of TextStyleProp list
        | Overline of TextStyleProp list

        | Body2 of TextStyleProp list
        | Body1 of TextStyleProp list
        | Caption of TextStyleProp list
        | Button of TextStyleProp list
        | [<Obsolete("Material-UI@3.2.0: Typography type `Display1` is deprecated. Please use `H4` instead")>] Display1 of TextStyleProp list
        | [<Obsolete("Material-UI@3.2.0: Typography type `Display2` is deprecated. Please use `H3` instead")>] Display2 of TextStyleProp list
        | [<Obsolete("Material-UI@3.2.0: Typography type `Display3` is deprecated. Please use `H2` instead")>] Display3 of TextStyleProp list
        | [<Obsolete("Material-UI@3.2.0: Typography type `Display4` is deprecated. Please use `H1` instead")>] Display4 of TextStyleProp list
        | [<Obsolete("Material-UI@3.2.0: Typography type `Headline` is deprecated. Please use `H5` instead")>] Headline of TextStyleProp list
        | [<Obsolete("Material-UI@3.2.0: Typography type `Title` is deprecated. Please use `H6` instead")>] Title of TextStyleProp list
        | [<Obsolete("Material-UI@3.2.0: Typography type `Subheading` is deprecated. Please use `Subtitle1` instead")>] Subheading of TextStyleProp list

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

    type IOverridesProp = interface end
    type OverridesProp =
        | [<Erase>] Custom of string * obj
        interface IOverridesProp

    [<AutoOpen>]
    module OverridesProp =
        open Fable.Core.JsInterop
        let inline private pascalCaseProp (name : string) (props : Themes.IStyles list) =
            OverridesProp.Custom (name, props |> keyValueList CaseRules.LowerFirst)

        let MuiAppBar styles = pascalCaseProp "MuiAppBar" styles
        let MuiAvatar styles = pascalCaseProp "MuiAvatar" styles
        let MuiBackdrop styles = pascalCaseProp "MuiBackdrop" styles
        let MuiBadge styles = pascalCaseProp "MuiBadge" styles
        let MuiBottomNavigation styles = pascalCaseProp "MuiBottomNavigation" styles
        let MuiBottomNavigationAction styles = pascalCaseProp "MuiBottomNavigationAction" styles
        let MuiButton styles = pascalCaseProp "MuiButton" styles
        let MuiButtonBase styles = pascalCaseProp "MuiButtonBase" styles
        let MuiCard styles = pascalCaseProp "MuiCard" styles
        let MuiCardActionArea styles = pascalCaseProp "MuiCardActionArea" styles
        let MuiCardActions styles = pascalCaseProp "MuiCardActions" styles
        let MuiCardContent styles = pascalCaseProp "MuiCardContent" styles
        let MuiCardHeader styles = pascalCaseProp "MuiCardHeader" styles
        let MuiCardMedia styles = pascalCaseProp "MuiCardMedia" styles
        let MuiCheckbox styles = pascalCaseProp "MuiCheckbox" styles
        let MuiChip styles = pascalCaseProp "MuiChip" styles
        let MuiCircularProgress styles = pascalCaseProp "MuiCircularProgress" styles
        let MuiCollapse styles = pascalCaseProp "MuiCollapse" styles
        let MuiCssBaseline styles = pascalCaseProp "MuiCssBaseline" styles
        let MuiDialog styles = pascalCaseProp "MuiDialog" styles
        let MuiDialogActions styles = pascalCaseProp "MuiDialogActions" styles
        let MuiDialogContent styles = pascalCaseProp "MuiDialogContent" styles
        let MuiDialogContentText styles = pascalCaseProp "MuiDialogContentText" styles
        let MuiDialogTitle styles = pascalCaseProp "MuiDialogTitle" styles
        let MuiDivider styles = pascalCaseProp "MuiDivider" styles
        let MuiDrawer styles = pascalCaseProp "MuiDrawer" styles
        let MuiExpansionPanel styles = pascalCaseProp "MuiExpansionPanel" styles
        let MuiExpansionPanelActions styles = pascalCaseProp "MuiExpansionPanelActions" styles
        let MuiExpansionPanelDetails styles = pascalCaseProp "MuiExpansionPanelDetails" styles
        let MuiExpansionPanelSummary styles = pascalCaseProp "MuiExpansionPanelSummary" styles
        let MuiFormControl styles = pascalCaseProp "MuiFormControl" styles
        let MuiFormControlLabel styles = pascalCaseProp "MuiFormControlLabel" styles
        let MuiFormGroup styles = pascalCaseProp "MuiFormGroup" styles
        let MuiFormHelperText styles = pascalCaseProp "MuiFormHelperText" styles
        let MuiFormLabel styles = pascalCaseProp "MuiFormLabel" styles
        let MuiGrid styles = pascalCaseProp "MuiGrid" styles
        let MuiGridList styles = pascalCaseProp "MuiGridList" styles
        let MuiGridListTile styles = pascalCaseProp "MuiGridListTile" styles
        let MuiGridListTileBar styles = pascalCaseProp "MuiGridListTileBar" styles
        let MuiIcon styles = pascalCaseProp "MuiIcon" styles
        let MuiIconButton styles = pascalCaseProp "MuiIconButton" styles
        let MuiInput styles = pascalCaseProp "MuiInput" styles
        let MuiInputAdornment styles = pascalCaseProp "MuiInputAdornment" styles
        let MuiInputLabel styles = pascalCaseProp "MuiInputLabel" styles
        let MuiLinearProgress styles = pascalCaseProp "MuiLinearProgress" styles
        let MuiList styles = pascalCaseProp "MuiList" styles
        let MuiListItem styles = pascalCaseProp "MuiListItem" styles
        let MuiListItemAvatar styles = pascalCaseProp "MuiListItemAvatar" styles
        let MuiListItemIcon styles = pascalCaseProp "MuiListItemIcon" styles
        let MuiListItemSecondaryAction styles = pascalCaseProp "MuiListItemSecondaryAction" styles
        let MuiListItemText styles = pascalCaseProp "MuiListItemText" styles
        let MuiListSubheader styles = pascalCaseProp "MuiListSubheader" styles
        let MuiMenu styles = pascalCaseProp "MuiMenu" styles
        let MuiMenuItem styles = pascalCaseProp "MuiMenuItem" styles
        let MuiMobileStepper styles = pascalCaseProp "MuiMobileStepper" styles
        let MuiModal styles = pascalCaseProp "MuiModal" styles
        let MuiNativeSelect styles = pascalCaseProp "MuiNativeSelect" styles
        let MuiOutlinedInput styles = pascalCaseProp "MuiOutlinedInput" styles
        let MuiPaper styles = pascalCaseProp "MuiPaper" styles
        let MuiPopover styles = pascalCaseProp "MuiPopover" styles
        let MuiRadio styles = pascalCaseProp "MuiRadio" styles
        let MuiSelect styles = pascalCaseProp "MuiSelect" styles
        let MuiSnackbar styles = pascalCaseProp "MuiSnackbar" styles
        let MuiSnackbarContent styles = pascalCaseProp "MuiSnackbarContent" styles
        let MuiStep styles = pascalCaseProp "MuiStep" styles
        let MuiStepButton styles = pascalCaseProp "MuiStepButton" styles
        let MuiStepConnector styles = pascalCaseProp "MuiStepConnector" styles
        let MuiStepContent styles = pascalCaseProp "MuiStepContent" styles
        let MuiStepIcon styles = pascalCaseProp "MuiStepIcon" styles
        let MuiStepLabel styles = pascalCaseProp "MuiStepLabel" styles
        let MuiStepper styles = pascalCaseProp "MuiStepper" styles
        let MuiSvgIcon styles = pascalCaseProp "MuiSvgIcon" styles
        let MuiSwitch styles = pascalCaseProp "MuiSwitch" styles
        let MuiTab styles = pascalCaseProp "MuiTab" styles
        let MuiTable styles = pascalCaseProp "MuiTable" styles
        let MuiTableCell styles = pascalCaseProp "MuiTableCell" styles
        let MuiTableFooter styles = pascalCaseProp "MuiTableFooter" styles
        let MuiTablePagination styles = pascalCaseProp "MuiTablePagination" styles
        let MuiTableRow styles = pascalCaseProp "MuiTableRow" styles
        let MuiTableSortLabel styles = pascalCaseProp "MuiTableSortLabel" styles
        let MuiTabs styles = pascalCaseProp "MuiTabs" styles
        let MuiToolbar styles = pascalCaseProp "MuiToolbar" styles
        let MuiTooltip styles = pascalCaseProp "MuiTooltip" styles
        let MuiTouchRipple styles = pascalCaseProp "MuiTouchRipple" styles
        let MuiTypography styles = pascalCaseProp "MuiTypography" styles

    // TODO implement breakpoints, mixins, transitions?
    type ThemeProp =
        | Direction of Themes.TextDirection
        | Palette of PaletteProp list
        | Shadows of string list
        | Shape of ShapeProp list
        | Spacing of SpacingProp list
        | Typography of ThemeTypographyProp list
        | ZIndex of ZIndexProp list
        | Overrides of IOverridesProp list

    type [<Erase>] ProviderTheme =
        | Theme of Themes.ITheme
        | Func of (Themes.ITheme->ThemeProp list)

    type MuiThemeProviderProp =
        | Theme of ProviderTheme
        | DisableStylesGeneration of bool
        interface IHTMLProp

    type [<StringEnum; RequireQualifiedAccess>] Breakpoint = Xs | Sm | Md | Lg | Xl
    type [<AllowNullLiteral>] IWithWidthProps =
        abstract member width: Breakpoint

    type WithWidthOption =
        | WithTheme of bool
        | NoSSR of bool
        | InitialWidth of Breakpoint

    [<AutoOpen>]
    module ChildrenProp =
        open Fable.Core.JsInterop

        let inline private pascalCaseProp<'a> (name : string) (props : 'a list) =
            HTMLAttr.Custom (name, props |> keyValueList CaseRules.LowerFirst)
        let inline private htmlAttrPascalCaseProp (name : string) (props : IHTMLProp list) =
            pascalCaseProp<IHTMLProp> name props

        let PaperProps props = htmlAttrPascalCaseProp "PaperProps" props
        let BackdropProps props = htmlAttrPascalCaseProp "BackdropProps" props
        let SelectProps props = htmlAttrPascalCaseProp "SelectProps" props
        let TransitionProps props = htmlAttrPascalCaseProp "TransitionProps" props
        let TouchRippleProps props = htmlAttrPascalCaseProp "TouchRippleProps" props
        let ModalProps props = htmlAttrPascalCaseProp "ModalProps" props
        let SlideProps props = htmlAttrPascalCaseProp "SlideProps" props
        let CollapseProps props = htmlAttrPascalCaseProp "CollapseProps" props
        let PopperProps props = htmlAttrPascalCaseProp "PopperProps" props
        let InputProps props = htmlAttrPascalCaseProp "InputProps" props
        let InputLabelProps props = htmlAttrPascalCaseProp "InputLabelProps" props
        let FormHelperTextProps props = htmlAttrPascalCaseProp "FormHelperTextProps" props
        let TabIndicatorProps props = htmlAttrPascalCaseProp "TabIndicatorProps" props
        let StepIconProps props = htmlAttrPascalCaseProp "StepIconProps" props
        let ContentProps props = htmlAttrPascalCaseProp "ContentProps" props
        let SelectDisplayProps props = htmlAttrPascalCaseProp "SelectDisplayProps" props
        let MenuProps props = htmlAttrPascalCaseProp "MenuProps" props
        let LinearProgressProps props = htmlAttrPascalCaseProp "LinearProgressProps" props
        let MenuListProps props = htmlAttrPascalCaseProp "MenuListProps" props
        let ContainerProps props = htmlAttrPascalCaseProp "ContainerProps" props
        let IconButtonProps props = htmlAttrPascalCaseProp "IconButtonProps" props
        let ClickAwayListenerProps props = htmlAttrPascalCaseProp "ClickAwayListenerProps" props
        let PopoverClasses classes = pascalCaseProp<Themes.IClassNames> "PopoverClasses" classes
        let FormLabelClasses classes = pascalCaseProp<Themes.IClassNames> "FormLabelClasses" classes
        let ActionsComponent (comp : Fable.Import.React.ReactType) =
            HTMLAttr.Custom("ActionsComponent", comp)
        let ScrollButtonComponent (comp : Fable.Import.React.ReactType) =
            HTMLAttr.Custom("ScrollButtonComponent", comp)
        let StepIconComponent (comp : Fable.Import.React.ReactType) =
            HTMLAttr.Custom("StepIconComponent", comp)
        let IconComponent (comp : Fable.Import.React.ReactType) =
            HTMLAttr.Custom("IconComponent", comp)
        let BackdropComponent (comp : Fable.Import.React.ReactType) =
            HTMLAttr.Custom("BackdropComponent", comp)
        let ContainerComponent (comp : Fable.Import.React.ReactType) =
            HTMLAttr.Custom("ContainerComponent", comp)
        let TransitionComponent (comp : Fable.Import.React.ReactType) =
            HTMLAttr.Custom("TransitionComponent", comp)
