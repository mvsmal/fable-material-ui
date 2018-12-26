# Default Theme

You can find the default theme in [Material-UI documentation](https://material-ui.com/customization/default-theme/)

Fable.MaterialUI exposes theme with the following types:

```fsharp
type IPaletteIntention =
    abstract light: string with get,set
    abstract main: string with get,set
    abstract dark: string with get,set
    abstract contrastText: string with get,set

type [<StringEnum; RequireQualifiedAccess>] PaletteType = Dark | Light

type IPaletteCommon =
    abstract black: string with get,set
    abstract white: string with get,set

type IPaletteAction =
    abstract active: string with get,set
    abstract hover: string with get,set
    abstract hoverOpacity: float with get,set
    abstract selected: string with get,set
    abstract disabled: string with get,set
    abstract disabledBackground: string with get,set

type IPaletteBackground =
    abstract paper: string with get,set
    abstract ``default``: string with get,set

type IPaletteText =
    abstract primary: string with get,set
    abstract secondary: string with get,set
    abstract disabled: string with get,set
    abstract hint: string with get,set

type IColor =
    abstract ``50``: string with get,set
    abstract ``100``: string with get,set
    abstract ``200``: string with get,set
    abstract ``300``: string with get,set
    abstract ``400``: string with get,set
    abstract ``500``: string with get,set
    abstract ``600``: string with get,set
    abstract ``700``: string with get,set
    abstract ``800``: string with get,set
    abstract ``900``: string with get,set
    abstract A100: string with get,set
    abstract A200: string with get,set
    abstract A400: string with get,set
    abstract A700: string with get,set

type IPalette =
    abstract common: IPaletteCommon with get,set
    abstract ``type``: PaletteType with get,set
    abstract primary: IPaletteIntention with get,set
    abstract secondary: IPaletteIntention with get,set
    abstract error: IPaletteIntention with get,set
    abstract grey: IColor with get,set
    abstract contrastThreshold: int with get,set
    abstract getContrastText: background: string -> string
    abstract augmentColor: color: IPaletteIntention * mainShade : U2<int, string> * lightShade : U2<int, string> * darkShade : U2<int, string> -> unit
    abstract tonalOffset: float with get,set
    abstract text: IPaletteText with get,set
    abstract divider: string with get,set
    abstract background: IPaletteBackground with get,set
    abstract action: IPaletteAction with get,set

type [<StringEnum; RequireQualifiedAccess>] TextDirection = Ltr | Rtl

type IShape =
    abstract borderRadius: int with get,set

type ISpacing =
    abstract ``unit``: int with get,set

type IZIndex =
    abstract mobileStepper: int with get,set
    abstract appBar: int with get,set
    abstract drawer: int with get,set
    abstract modal: int with get,set
    abstract snackbar: int with get,set
    abstract tooltip: int with get,set

type ITypography =
    abstract fontSize: string with get,set
    abstract fontWeight: int with get,set
    abstract fontFamily: string with get,set
    abstract letterSpacing: string with get,set
    abstract lineHeight: string with get,set
    abstract marginLeft: string with get,set
    abstract color: string with get,set
    abstract textTransform: string with get,set

type IThemeTypography =
    abstract round: px: float -> float
    abstract pxToRem: px: float -> string
    abstract fontFamily: string with get,set
    abstract fontSize: string with get,set
    abstract fontWeightLight: int with get,set
    abstract fontWeightRegular: int with get,set
    abstract fontWeightMedium: int with get,set
    abstract h1: ITypography with get,set
    abstract h2: ITypography with get,set
    abstract h3: ITypography with get,set
    abstract h4: ITypography with get,set
    abstract h5: ITypography with get,set
    abstract h6: ITypography with get,set
    abstract subtitle1: ITypography with get,set
    abstract subtitle2: ITypography with get,set
    abstract overline: ITypography with get,set
    abstract srOnly: ITypography with get,set
    abstract body2: ITypography with get,set
    abstract body1: ITypography with get,set
    abstract caption: ITypography with get,set
    abstract button: ITypography with get,set
    // Deprecated
    [<Obsolete("Material-UI@3.2.0: Typography type `display1` is deprecated. Please use `h4` instead")>]
    abstract display1: ITypography with get,set
    [<Obsolete("Material-UI@3.2.0: Typography type `display2` is deprecated. Please use `h3` instead")>]
    abstract display2: ITypography with get,set
    [<Obsolete("Material-UI@3.2.0: Typography type `display3` is deprecated. Please use `h2` instead")>]
    abstract dispaly3: ITypography with get,set
    [<Obsolete("Material-UI@3.2.0: Typography type `display4` is deprecated. Please use `h1` instead")>]
    abstract display4: ITypography with get,set
    [<Obsolete("Material-UI@3.2.0: Typography type `headline` is deprecated. Please use `h5` instead")>]
    abstract headline: ITypography with get,set
    [<Obsolete("Material-UI@3.2.0: Typography type `title` is deprecated. Please use `h6` instead")>]
    abstract title: ITypography with get,set
    [<Obsolete("Material-UI@3.2.0: Typography type `subheading` is deprecated. Please use `subtitle1` instead")>]
    abstract subheading: ITypography with get,set

type IBreakpointValues =
    abstract xs: int with get,set
    abstract sm: int with get,set
    abstract md: int with get,set
    abstract lg: int with get,set
    abstract xl: int with get,set

type IBreakpoints =
    abstract keys: Props.MaterialSize list with get,set
    abstract values: IBreakpointValues with get,set
    abstract up: key: U2<Props.MaterialSize, int> -> string
    abstract down: key: U2<Props.MaterialSize, int> -> string
    abstract only: key: Props.MaterialSize -> string
    abstract between: start: Props.MaterialSize * ``end``: Props.MaterialSize -> string
    abstract width: key: Props.MaterialSize -> int

type IMixins =
    abstract gutters: ?styles : CSSProperties -> CSSProperties
    abstract toolbar: CSSProperties with get,set

type IEasing =
    abstract easeInOut: string with get,set
    abstract easeOut: string with get,set
    abstract easeIn: string with get,set
    abstract sharp: string with get,set

type IDuration =
    abstract shortest: float with get,set
    abstract shorter: float with get,set
    abstract short: float with get,set
    abstract standard: float with get,set
    abstract complex: float with get,set
    abstract enteringScreen: float with get,set
    abstract leavingScreen: float with get,set

type ITransitionOptions =
    abstract duration: U2<float, string> with get,set
    abstract easing: string with get,set
    abstract delay: U2<float, string> with get,set

type ITransitions =
    abstract easing: IEasing with get,set
    abstract duration: IDuration with get,set
    abstract create: props : U2<string, string list> * ?options: ITransitionOptions -> string
    abstract getAutoHeightDuration: height : int -> int

type ITheme =
    abstract breakpoints: IBreakpoints with get,set
    abstract direction: TextDirection with get,set
    abstract overrides: obj with get,set
    abstract palette: IPalette with get,set
    abstract props: obj with get,set
    abstract shadows: string list with get,set
    abstract typography: IThemeTypography with get,set
    abstract shape: IShape with get,set
    abstract spacing: ISpacing with get,set
    abstract zIndex: IZIndex with get,set
    abstract mixins: IMixins with get,set
    abstract transitions: ITransitions with get,set
```

You can find the definions on [GitHub](https://github.com/mvsmal/fable-material-ui/blob/master/src/Fable.MaterialUI.Props.fs#L1711-L1962)