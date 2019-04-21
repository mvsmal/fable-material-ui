namespace Fable.MaterialUI
open Fable.Core
open Fable.Core.JsInterop

module Core =
    open Fable.React
    open Fable.React.Props
    open Fable.MaterialUI.Props
    open Fable.MaterialUI.Themes

    let toObj p = keyValueList CaseRules.LowerFirst p

    let inline appBar (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/AppBar" (toObj b) c
    let inline avatar (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Avatar" (toObj b) c
    let inline backdrop (b : seq<IHTMLProp>) : ReactElement = ofImport "default" "@material-ui/core/Backdrop" (toObj b) []
    let inline badge (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Badge" (toObj b) c
    let inline bottomNavigation (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/BottomNavigation" (toObj b) c
    let inline bottomNavigationAction (b : seq<IHTMLProp>) : ReactElement = ofImport "default" "@material-ui/core/BottomNavigationAction" (toObj b) []
    let inline button (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Button" (toObj b) c
    let inline buttonBase (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/ButtonBase" (toObj b) c
    let inline card (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Card" (toObj b) c
    let inline cardActionArea (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/CardActionArea" (toObj b) c
    let inline cardActions (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/CardActions" (toObj b) c
    let inline cardContent (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/CardContent" (toObj b) c
    let inline cardHeader (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/CardHeader" (toObj b) c
    let inline cardMedia (b : seq<IHTMLProp>) : ReactElement = ofImport "default" "@material-ui/core/CardMedia" (toObj b) []
    let inline checkbox (b : seq<IHTMLProp>) : ReactElement = ofImport "default" "@material-ui/core/Checkbox" (toObj b) []
    let inline chip (b : seq<IHTMLProp>) : ReactElement = ofImport "default" "@material-ui/core/Chip" (toObj b) []
    let inline circularProgress (b : seq<IHTMLProp>) : ReactElement = ofImport "default" "@material-ui/core/CircularProgress" (toObj b) []
    let inline clickAwayListener (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/ClickAwayListener" (toObj b) c
    let inline collapse (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Collapse" (toObj b) c
    let inline cssBaseline (b : seq<IHTMLProp>) : ReactElement = ofImport "default" "@material-ui/core/CssBaseline" (toObj b) []
    let inline dialog (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Dialog" (toObj b) c
    let inline dialogActions (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/DialogActions" (toObj b) c
    let inline dialogContent (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/DialogContent" (toObj b) c
    let inline dialogContentText (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/DialogContentText" (toObj b) c
    let inline dialogTitle (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/DialogTitle" (toObj b) c
    let inline divider (b : seq<IHTMLProp>) : ReactElement = ofImport "default" "@material-ui/core/Divider" (toObj b) []
    let inline drawer (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Drawer" (toObj b) c
    let inline expansionPanel (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/ExpansionPanel" (toObj b) c
    let inline expansionPanelActions (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/ExpansionPanelActions" (toObj b) c
    let inline expansionPanelDetails (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/ExpansionPanelDetails" (toObj b) c
    let inline expansionPanelSummary (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/ExpansionPanelSummary" (toObj b) c
    let inline fab (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Fab" (toObj b) c
    let inline fade (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Fade" (toObj b) c
    let inline filledInput (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/FilledInput" (toObj b) c
    let inline formControl (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/FormControl" (toObj b) c
    let inline formControlLabel (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/FormControlLabel" (toObj b) c
    let inline formGroup (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/FormGroup" (toObj b) c
    let inline formHelperText (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/FormHelperText" (toObj b) c
    let inline formLabel (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/FormLabel" (toObj b) c
    let inline grid (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Grid" (toObj b) c
    let inline gridList (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/GridList" (toObj b) c
    let inline gridListTile (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/GridListTile" (toObj b) c
    let inline gridListTileBar (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/GridListTileBar" (toObj b) c
    let inline grow (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Grow" (toObj b) c
    let inline hidden (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Hidden" (toObj b) c
    let inline icon (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Icon" (toObj b) c
    let inline iconButton (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/IconButton" (toObj b) c
    let inline input (b : seq<IHTMLProp>) : ReactElement = ofImport "default" "@material-ui/core/Input" (toObj b) []
    let inline inputAdornment (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/InputAdornment" (toObj b) c
    let inline inputBase (b : seq<IHTMLProp>) : ReactElement = ofImport "default" "@material-ui/core/InputBase" (toObj b) []
    let inline inputLabel (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/InputLabel" (toObj b) c
    let inline linearProgress (b : seq<IHTMLProp>) : ReactElement = ofImport "default" "@material-ui/core/LinearProgress" (toObj b) []
    let inline link (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Link" (toObj b) c
    let inline list (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/List" (toObj b) c
    let inline listItem (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/ListItem" (toObj b) c
    let inline listItemAvatar (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/ListItemAvatar" (toObj b) c
    let inline listItemIcon (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/ListItemIcon" (toObj b) c
    let inline listItemSecondaryAction (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/ListItemSecondaryAction" (toObj b) c
    let inline listItemText (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/ListItemText" (toObj b) c
    let inline listSubheader (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/ListSubheader" (toObj b) c
    let inline menu (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Menu" (toObj b) c
    let inline menuItem (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/MenuItem" (toObj b) c
    let inline menuList (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/MenuList" (toObj b) c
    let inline mobileStepper (b : seq<IHTMLProp>) : ReactElement = ofImport "default" "@material-ui/core/MobileStepper" (toObj b) []
    let inline modal (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Modal" (toObj b) c
    let inline nativeSelect (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/NativeSelect" (toObj b) c
    let inline outlinedInput (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/OutlinedInput" (toObj b) c
    let inline paper (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Paper" (toObj b) c
    let inline popover (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Popover" (toObj b) c
    let inline popper (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Popper" (toObj b) c
    let inline portal (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Portal" (toObj b) c
    let inline radio (b : seq<IHTMLProp>) : ReactElement = ofImport "default" "@material-ui/core/Radio" (toObj b) []
    let inline radioGroup (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/RadioGroup" (toObj b) c
    let inline rootRef (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/RootRef" (toObj b) c
    let inline select (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Select" (toObj b) c
    let inline slide (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Slide" (toObj b) c
    let inline snackbar (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Snackbar" (toObj b) c
    let inline snackbarContent (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/SnackbarContent" (toObj b) c
    let inline step (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Step" (toObj b) c
    let inline stepButton (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/StepButton" (toObj b) c
    let inline stepConnector (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/StepConnector" (toObj b) c
    let inline stepContent (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/StepContent" (toObj b) c
    let inline stepIcon (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/StepIcon" (toObj b) c
    let inline stepLabel (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/StepLabel" (toObj b) c
    let inline stepper (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Stepper" (toObj b) c
    let inline svgIcon (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/SvgIcon" (toObj b) c
    let inline swipeableDrawer (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/SwipeableDrawer" (toObj b) c
    let inline switch (b : seq<IHTMLProp>) : ReactElement = ofImport "default" "@material-ui/core/Switch" (toObj b) []
    let inline tab (b : seq<IHTMLProp>) : ReactElement = ofImport "default" "@material-ui/core/Tab" (toObj b) []
    let inline tabs (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Tabs" (toObj b) c
    let inline table (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Table" (toObj b) c
    let inline tableBody (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/TableBody" (toObj b) c
    let inline tableCell (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/TableCell" (toObj b) c
    let inline tableFooter (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/TableFooter" (toObj b) c
    let inline tableHead (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/TableHead" (toObj b) c
    let inline tablePagination (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/TablePagination" (toObj b) c
    let inline tableRow (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/TableRow" (toObj b) c
    let inline tableSortLabel (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/TableSortLabel" (toObj b) c
    let inline textField (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/TextField" (toObj b) c
    let inline toolbar (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Toolbar" (toObj b) c
    let inline tooltip (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Tooltip" (toObj b) c
    let inline touchRipple (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/ButtonBase/TouchRipple" (toObj b) c
    let inline typography (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Typography" (toObj b) c
    let inline zoom (b : seq<IHTMLProp>) c : ReactElement = ofImport "default" "@material-ui/core/Zoom" (toObj b) c

    type IClasses = interface end
    type IClassesProps =
        abstract member classes: IClasses

    let withStyles'<'P, 'O when 'P :> IClassesProps>
        styles (options: 'O) (fn : 'P->Fable.React.ReactElement) : Fable.React.ReactElementType<'P> =
        !!((import "withStyles" "@material-ui/core/styles") $ (styles, options) $ fn)

    let withStyles<'P when 'P :> IClassesProps>
        (styles : StyleType)
        (options: StyleOption list)
        (fn : 'P -> Fable.React.ReactElement) =
        let styles' =
            match styles with
            | StyleType.Styles styles -> (keyValueList CaseRules.LowerFirst styles |> unbox)
            | StyleType.Func func -> func >> keyValueList CaseRules.LowerFirst
        withStyles' styles' (keyValueList CaseRules.LowerFirst options) fn

    let inline muiThemeProvider (b : seq<IHTMLProp>) c = ofImport "MuiThemeProvider" "@material-ui/core/styles" (toObj b) c

    [<Import("createMuiTheme", "@material-ui/core/styles")>]
    let private createMuiTheme'<'O> (options: 'O) : ITheme = jsNative

    let createMuiTheme (options: ThemeProp list) =
        options
        |> keyValueList CaseRules.LowerFirst
        |> unbox
        |> createMuiTheme'

    type IThemeProps =
        abstract member theme : ITheme

    [<Import("withTheme", "@material-ui/core/styles")>]
    let withTheme' : obj = jsNative

    let withTheme<'P when 'P :> IThemeProps>
        (fn : 'P->Fable.React.ReactElement) : Fable.React.ReactElementType<'P> =
        !!(withTheme' $ () $ fn)

    let withWidth'<'O, 'P>
        (options: 'O)
        (fn : 'P->Fable.React.ReactElement) : Fable.React.ReactElementType<'P> =
        !!((importDefault "@material-ui/core/withWidth") $ options $ fn)

    let withWidth<'P>
        (options: WithWidthOption list)
        (fn: ('P -> Fable.React.ReactElement)) =
        withWidth' (keyValueList CaseRules.LowerFirst options |> unbox) fn

    type IWidthProps =
        abstract member width : Breakpoint

    let isWidthUp (breakpoint : Breakpoint) (screenWidth : Breakpoint) (inclusive : bool) =
        importMember "@material-ui/core/withWidth"

    let isWidthDown (breakpoint : Breakpoint) (screenWidth : Breakpoint) (inclusive : bool) =
        importMember "@material-ui/core/withWidth"

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
