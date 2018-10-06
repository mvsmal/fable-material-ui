module Fable.Helpers.MaterialUI

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

let inline materialEl<'P when 'P :> IHTMLProp>
    (a:Fable.Import.React.ComponentClass<'P>) (b: IHTMLProp list) c : Fable.Import.React.ReactElement =
    Fable.Helpers.React.from a (keyValueList CaseRules.LowerFirst b |> unbox) c

let AppBar = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/AppBar"
let inline appBar b c = materialEl AppBar b c

let Avatar = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Avatar"
let inline avatar b c = materialEl Avatar b c

let Backdrop = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Backdrop"
let inline backdrop b = materialEl Backdrop b []

let Badge = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Badge"
let inline badge b c = materialEl Badge b c

let BottomNavigation = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/BottomNavigation"
let inline bottomNavigation b c = materialEl BottomNavigation b c

let BottomNavigationAction =
    importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/BottomNavigationAction"
let inline bottomNavigationAction b = materialEl BottomNavigationAction b []

let Button = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Button"
let inline button b c = materialEl Button b c

let ButtonBase = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/ButtonBase"
let inline buttonBase b c = materialEl ButtonBase b c

let Card = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Card"
let inline card b c = materialEl Card b c

let CardActionArea = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/CardActionArea"
let inline cardActionArea b c = materialEl CardActionArea b c

let CardActions = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/CardActions"
let inline cardActions b c = materialEl CardActions b c

let CardContent = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/CardContent"
let inline cardContent b c = materialEl CardContent b c

let CardHeader = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/CardHeader"
let inline cardHeader b c = materialEl CardHeader b c

let CardMedia = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/CardMedia"
let inline cardMedia b = materialEl CardMedia b []

let Checkbox = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Checkbox"
let inline checkbox b = materialEl Checkbox b []

let Chip = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Chip"
let inline chip b = materialEl Chip b []

let CircularProgress = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/CircularProgress"
let inline circularProgress b = materialEl CircularProgress b []

let ClickAwayListener =
    importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/ClickAwayListener"
let inline clickAwayListener b c = materialEl ClickAwayListener b c

let Collapse = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Collapse"
let inline collapse b c = materialEl Collapse b c

let CssBaseline = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/CssBaseline"
let inline cssBaseline b = materialEl CssBaseline b []

let Dialog = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Dialog"
let inline dialog b c = materialEl Dialog b c

let DialogActions = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/DialogActions"
let inline dialogActions b c = materialEl DialogActions b c

let DialogContent = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/DialogContent"
let inline dialogContent b c = materialEl DialogContent b c

let DialogContentText =
    importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/DialogContentText"
let inline dialogContentText b c = materialEl DialogContentText b c

let DialogTitle = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/DialogTitle"
let inline dialogTitle b c = materialEl DialogTitle b c

let Divider = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Divider"
let inline divider b = materialEl Divider b []

let Drawer = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Drawer"
let inline drawer b c = materialEl Drawer b c

let ExpansionPanel = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/ExpansionPanel"
let inline expansionPanel b c = materialEl ExpansionPanel b c

let ExpansionPanelActions =
    importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/ExpansionPanelActions"
let inline expansionPanelActions b c = materialEl ExpansionPanelActions b c

let ExpansionPanelDetails =
    importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/ExpansionPanelDetails"
let inline expansionPanelDetails b c = materialEl ExpansionPanelDetails b c

let ExpansionPanelSummary =
    importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/ExpansionPanelSummary"
let inline expansionPanelSummary b c = materialEl ExpansionPanelSummary b c

let Fade = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Fade"
let inline fade b c = materialEl Fade b c

let FormControl = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/FormControl"
let inline formControl b c = materialEl FormControl b c

let FormControlLabel = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/FormControlLabel"
let inline formControlLabel b c = materialEl FormControlLabel b c

let FormGroup = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/FormGroup"
let inline formGroup b c = materialEl FormGroup b c

let FormHelperText = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/FormHelperText"
let inline formHelperText b c = materialEl FormHelperText b c

let FormLabel = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/FormLabel"
let inline formLabel b c = materialEl FormLabel b c

let Grid = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Grid"
let inline grid b c = materialEl Grid b c

let GridList = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/GridList"
let inline gridList b c = materialEl GridList b c

let GridListTile = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/GridListTile"
let inline gridListTile b c = materialEl GridListTile b c

let GridListTileBar = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/GridListTileBar"
let inline gridListTileBar b c = materialEl GridListTileBar b c

let Grow = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Grow"
let inline grow b c = materialEl Grow b c

let Hidden = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Hidden"
let inline hidden b c = materialEl Hidden b c

let Icon = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Icon"
let inline icon b c = materialEl Icon b c

let IconButton = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/IconButton"
let inline iconButton b c = materialEl IconButton b c

let Input = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Input"
let inline input b = materialEl Input b []

let InputAdornment = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/InputAdornment"
let inline inputAdornment b c = materialEl InputAdornment b c

let InputLabel = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/InputLabel"
let inline inputLabel b c = materialEl InputLabel b c

let LinearProgress = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/LinearProgress"
let inline linearProgress b = materialEl LinearProgress b []

let List = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/List"
let inline list b c = materialEl List b c

let ListItem = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/ListItem"
let inline listItem b c = materialEl ListItem b c

let ListItemAvatar = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/ListItemAvatar"
let inline listItemAvatar b c = materialEl ListItemAvatar b c

let ListItemIcon = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/ListItemIcon"
let inline listItemIcon b c = materialEl ListItemIcon b c

let ListItemSecondaryAction =
    importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/ListItemSecondaryAction"
let inline listItemSecondaryAction b c = materialEl ListItemSecondaryAction b c

let ListItemText = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/ListItemText"
let inline listItemText b c = materialEl ListItemText b c

let ListSubheader = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/ListSubheader"
let inline listSubheader b c = materialEl ListSubheader b c

let Menu = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Menu"
let inline menu b c = materialEl Menu b c

let MenuItem = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/MenuItem"
let inline menuItem b c = materialEl MenuItem b c

let MenuList = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/MenuList"
let inline menuList b c = materialEl MenuList b c

let MobileStepper = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/MobileStepper"
let inline mobileStepper b = materialEl MobileStepper b []

let Modal = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Modal"
let inline modal b c = materialEl Modal b c

let NativeSelect = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/NativeSelect"
let inline nativeSelect b c = materialEl NativeSelect b c

let Paper = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Paper"
let inline paper b c = materialEl Paper b c

let Popover = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Popover"
let inline popover b c = materialEl Popover b c

let Popper = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Popper"
let inline popper b c = materialEl Popper b c

let Portal = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Portal"
let inline portal b c = materialEl Portal b c

let Radio = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Radio"
let inline radio b = materialEl Radio b []

let RadioGroup = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/RadioGroup"
let inline radioGroup b c = materialEl RadioGroup b c

let RootRef = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/RootRef"
let inline rootRef b c = materialEl RootRef b c

let Select = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Select"
let inline select b c = materialEl Select b c

let Slide = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Slide"
let inline slide b c = materialEl Slide b c

let Snackbar = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Snackbar"
let inline snackbar b c = materialEl Snackbar b c

let SnackbarContent = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/SnackbarContent"
let inline snackbarContent b c = materialEl SnackbarContent b c

let Step = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Step"
let inline step b c = materialEl Step b c

let StepButton = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/StepButton"
let inline stepButton b c = materialEl StepButton b c

let StepConnector = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/StepConnector"
let inline stepConnector b c = materialEl StepConnector b c

let StepContent = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/StepContent"
let inline stepContent b c = materialEl StepContent b c

let StepIcon = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/StepIcon"
let inline stepIcon b c = materialEl StepIcon b c

let StepLabel = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/StepLabel"
let inline stepLabel b c = materialEl StepLabel b c

let Stepper = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Stepper"
let inline stepper b c = materialEl Stepper b c

let SvgIcon = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/SvgIcon"
let inline svgIcon b c = materialEl SvgIcon b c

let SwipeableDrawer =
    importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/SwipeableDrawer"
let inline swipeableDrawer b c = materialEl SwipeableDrawer b c

let Switch = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Switch"
let inline switch b = materialEl Switch b []

let Tab = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Tab"
let inline tab b = materialEl Tab b []

let Tabs = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Tabs"
let inline tabs b c = materialEl Tabs b c

let Table = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Table"
let inline table b c = materialEl Table b c

let TableBody = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/TableBody"
let inline tableBody b c = materialEl TableBody b c

let TableCell = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/TableCell"
let inline tableCell b c = materialEl TableCell b c

let TableFooter = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/TableFooter"
let inline tableFooter b c = materialEl TableFooter b c

let TableHead = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/TableHead"
let inline tableHead b c = materialEl TableHead b c

let TablePagination = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/TablePagination"
let inline tablePagination b c = materialEl TablePagination b c

let TableRow = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/TableRow"
let inline tableRow b c = materialEl TableRow b c

let TableSortLabel = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/TableSortLabel"
let inline tableSortLabel b c = materialEl TableSortLabel b c

let TextField = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/TextField"
let inline textField b c = materialEl TextField b c

let Toolbar = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Toolbar"
let inline toolbar b c = materialEl Toolbar b c

let Tooltip = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Tooltip"
let inline tooltip b c = materialEl Tooltip b c

let TouchRipple =
    importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/ButtonBase/TouchRipple"
let inline touchRipple b c = materialEl TouchRipple b c

let Typography = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Typography"
let inline typography b c = materialEl Typography b c

let Zoom = importDefault<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/Zoom"
let inline zoom b c = materialEl Zoom b c

type IClasses = interface end
type IClassesProps =
    abstract member classes: IClasses

let withStyles'<'P, 'O when 'P :> IClassesProps>
    styles (options: 'O) (fn : 'P->Fable.Import.React.ReactElement) : Fable.Import.React.ComponentClass<'P> =
    !!((import "withStyles" "@material-ui/core/styles") $ (styles, options) $ fn)

let withStyles<'P when 'P :> IClassesProps>
    (styles : StyleType)
    (options: StyleOption list)
    (fn : 'P -> Fable.Import.React.ReactElement) =
    let styles' =
        match styles with
        | StyleType.Styles styles -> (keyValueList CaseRules.LowerFirst styles |> unbox)
        | StyleType.Func func -> func >> keyValueList CaseRules.LowerFirst
    withStyles' styles' (keyValueList CaseRules.LowerFirst options) fn

let MuiThemeProvider = importMember<Fable.Import.React.ComponentClass<IHTMLProp>> "@material-ui/core/styles"
let inline muiThemeProvider b c = materialEl MuiThemeProvider b c

[<Import("createMuiTheme", "@material-ui/core/styles")>]
let private createMuiTheme'<'O> (options: 'O) : ITheme = jsNative

let createMuiTheme (options: ThemeProp list) =
    options
    |> keyValueList CaseRules.LowerFirst
    |> unbox
    |> createMuiTheme'

let withWidth'<'O, 'P>
    (options: 'O)
    (fn : 'P->Fable.Import.React.ReactElement) : Fable.Import.React.ComponentClass<'P> =
    !!((importDefault "@material-ui/core/withWidth") $ options $ fn)

let withWidth<'P>
    (options: WithWidthOption list)
    (fn: ('P -> Fable.Import.React.ReactElement)) =
    withWidth' (keyValueList CaseRules.LowerFirst options |> unbox) fn

module ColorManipulator =

    [<StringEnum; RequireQualifiedAccess>]
    type ColorFormat = Rgb | Rgba | Hsl | Hsla

    type ColorObject =
        abstract member ``type``: ColorFormat
        abstract member values: float array

    let recomposeColor (color: ColorObject): string =
        import "recomposeColor" "@material-ui/core/styles/colorManipulator"

    let convertHexToRGB (hex: string): string =
        import "convertHexToRGB" "@material-ui/core/styles/colorManipulator"

    let rbgToHex (color: string): string =
        import "rbgToHex" "@material-ui/core/styles/colorManipulator"

    let decomposeColor (color: string): ColorObject =
        import "decomposeColor" "@material-ui/core/styles/colorManipulator"

    let getContrastRatio ((foreground: string), (background: string)): float =
        import "getContrastRatio" "@material-ui/core/styles/colorManipulator"

    let getLuminance (color: string) =
        import "getLuminance" "@material-ui/core/styles/colorManipulator"

    let emphasize ((color: string), (coefficient: float)): string =
        import "emphasize" "@material-ui/core/styles/colorManipulator"

    let fade ((color: string), (value: float)): string =
        import "fade" "@material-ui/core/styles/colorManipulator"

    let darken ((color: string), (coefficient: float)): string =
        import "darken" "@material-ui/core/styles/colorManipulator"

    let lighten ((color: string), (coefficient: float)): string =
        import "lighten" "@material-ui/core/styles/colorManipulator"
