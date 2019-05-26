module Layout.Navigation

open Global
open Fable.MaterialUI.Core

let navItems = [
    {
        Title = "Getting Started"
        Href = None
        Children =
            [
                { Title = "Installation"; Href = Some (Page.StaticPage Installation); Children = [] }
                { Title = "Usage"; Href = Some (Page.StaticPage Usage); Children = [] }
                { Title = "Migration to version 2"; Href = Some (Page.StaticPage MigrationToV2); Children = [] }
                { Title = "Migration to version 3"; Href = Some (Page.StaticPage MigrationToV3); Children = [] }
                { Title = "Migration to version 4"; Href = Some (Page.StaticPage MigrationToV4); Children = [] }
            ]
    }
    {
        Title = "Component demos"
        Href = None
        Children =
            [
                { Title = "App Bar"; Href = Some Page.AppBar; Children = [] }
                { Title = "Buttons"; Href = Some Page.Buttons; Children = [] }
                { Title = "Popper"; Href = Some Page.Popper; Children = [] }
                { Title = "Text Fields"; Href = Some Page.TextFields; Children = [] }
                // { Title = "Avatars"; Href = Some Page.Avatars; Children = [] }
            ]
    }
    {
        Title = "Customization"
        Href = None
        Children =
            [
                { Title = "Themes"; Href = Some Page.Themes; Children = [] }
                { Title = "Overrides"; Href = Some Page.Overrides; Children = [] }
                { Title = "CSS in JS (F#)"; Href = Some Page.CssInJs; Children = [] }
                { Title = "Default Theme"; Href = Some (Page.StaticPage DefaultTheme); Children = [] }
            ]
    }
    {
        Title = "Components API"
        Href = None
        Children =
            [
                { Title = "AppBar"; Href = Some (Page.Api "app-bar"); Children = [] }
                { Title = "Avatar"; Href = Some (Page.Api "avatar"); Children = [] }
                { Title = "Backdrop"; Href = Some (Page.Api "backdrop"); Children = [] }
                { Title = "Badge"; Href = Some (Page.Api "badge"); Children = [] }
                { Title = "BottomNavigation"; Href = Some (Page.Api "bottom-navigation"); Children = [] }
                { Title = "BottomNavigationAction"; Href = Some (Page.Api "bottom-navigation-action"); Children = [] }
                { Title = "Button"; Href = Some (Page.Api "button"); Children = [] }
                { Title = "ButtonBase"; Href = Some (Page.Api "button-base"); Children = [] }
                { Title = "Card"; Href = Some (Page.Api "card"); Children = [] }
                { Title = "CardActionArea"; Href = Some (Page.Api "card-action-area"); Children = [] }
                { Title = "CardActions"; Href = Some (Page.Api "card-actions"); Children = [] }
                { Title = "CardContent"; Href = Some (Page.Api "card-content"); Children = [] }
                { Title = "CardHeader"; Href = Some (Page.Api "card-header"); Children = [] }
                { Title = "CardMedia"; Href = Some (Page.Api "card-media"); Children = [] }
                { Title = "Checkbox"; Href = Some (Page.Api "checkbox"); Children = [] }
                { Title = "Chip"; Href = Some (Page.Api "chip"); Children = [] }
                { Title = "CircularProgress"; Href = Some (Page.Api "circular-progress"); Children = [] }
                { Title = "ClickAwayListener"; Href = Some (Page.Api "click-away-listener"); Children = [] }
                { Title = "Collapse"; Href = Some (Page.Api "collapse"); Children = [] }
                { Title = "CssBaseline"; Href = Some (Page.Api "css-baseline"); Children = [] }
                { Title = "Dialog"; Href = Some (Page.Api "dialog"); Children = [] }
                { Title = "DialogActions"; Href = Some (Page.Api "dialog-actions"); Children = [] }
                { Title = "DialogContentText"; Href = Some (Page.Api "dialog-content-text"); Children = [] }
                { Title = "DialogContent"; Href = Some (Page.Api "dialog-content"); Children = [] }
                { Title = "DialogTitle"; Href = Some (Page.Api "dialog-title"); Children = [] }
                { Title = "Divider"; Href = Some (Page.Api "divider"); Children = [] }
                { Title = "Drawer"; Href = Some (Page.Api "drawer"); Children = [] }
                { Title = "ExpansionPanel"; Href = Some (Page.Api "expansion-panel"); Children = [] }
                { Title = "ExpansionPanelActions"; Href = Some (Page.Api "expansion-panel-actions"); Children = [] }
                { Title = "ExpansionPanelDetails"; Href = Some (Page.Api "expansion-panel-details"); Children = [] }
                { Title = "ExpansionPanelSummary"; Href = Some (Page.Api "expansion-panel-summary"); Children = [] }
                { Title = "Fab"; Href = Some (Page.Api "fab"); Children = [] }
                { Title = "Fade"; Href = Some (Page.Api "fade"); Children = [] }
                { Title = "FilledInput"; Href = Some (Page.Api "filled-input"); Children = [] }
                { Title = "FormControl"; Href = Some (Page.Api "form-control"); Children = [] }
                { Title = "FormControlLabel"; Href = Some (Page.Api "form-control-label"); Children = [] }
                { Title = "FormGroup"; Href = Some (Page.Api "form-group"); Children = [] }
                { Title = "FormHelperText"; Href = Some (Page.Api "form-helper-text"); Children = [] }
                { Title = "FormLabel"; Href = Some (Page.Api "form-label"); Children = [] }
                { Title = "Grid"; Href = Some (Page.Api "grid"); Children = [] }
                { Title = "GridList"; Href = Some (Page.Api "grid-list"); Children = [] }
                { Title = "GridListTile"; Href = Some (Page.Api "grid-list-tile"); Children = [] }
                { Title = "GridListTileBar"; Href = Some (Page.Api "grid-list-tile-bar"); Children = [] }
                { Title = "Grow"; Href = Some (Page.Api "grow"); Children = [] }
                { Title = "Hidden"; Href = Some (Page.Api "hidden"); Children = [] }
                { Title = "Icon"; Href = Some (Page.Api "icon"); Children = [] }
                { Title = "IconButton"; Href = Some (Page.Api "icon-button"); Children = [] }
                { Title = "Input"; Href = Some (Page.Api "input"); Children = [] }
                { Title = "InputAdornment"; Href = Some (Page.Api "input-adornment"); Children = [] }
                { Title = "InputBase"; Href = Some (Page.Api "input-base"); Children = [] }
                { Title = "InputLabel"; Href = Some (Page.Api "input-label"); Children = [] }
                { Title = "LinearProgress"; Href = Some (Page.Api "linear-progress"); Children = [] }
                { Title = "Link"; Href = Some (Page.Api "link"); Children = [] }
                { Title = "List"; Href = Some (Page.Api "list"); Children = [] }
                { Title = "ListItem"; Href = Some (Page.Api "list-item"); Children = [] }
                { Title = "ListItemAvatar"; Href = Some (Page.Api "list-item-avatar"); Children = [] }
                { Title = "ListItemIcon"; Href = Some (Page.Api "list-item-icon"); Children = [] }
                { Title = "ListItemSecondaryAction"; Href = Some (Page.Api "list-item-secondary-action"); Children = [] }
                { Title = "ListItemText"; Href = Some (Page.Api "list-item-text"); Children = [] }
                { Title = "ListSubheader"; Href = Some (Page.Api "list-subheader"); Children = [] }
                { Title = "Menu"; Href = Some (Page.Api "menu"); Children = [] }
                { Title = "MenuItem"; Href = Some (Page.Api "menu-item"); Children = [] }
                { Title = "MenuList"; Href = Some (Page.Api "menu-list"); Children = [] }
                { Title = "MobileStepper"; Href = Some (Page.Api "mobile-stepper"); Children = [] }
                { Title = "Modal"; Href = Some (Page.Api "modal"); Children = [] }
                { Title = "MuiThemeProvider"; Href = Some (Page.Api "mui-theme-provider"); Children = [] }
                { Title = "NativeSelect"; Href = Some (Page.Api "native-select"); Children = [] }
                { Title = "OutlinedInput"; Href = Some (Page.Api "outlined-input"); Children = [] }
                { Title = "Paper"; Href = Some (Page.Api "paper"); Children = [] }
                { Title = "Popover"; Href = Some (Page.Api "popover"); Children = [] }
                { Title = "Popper"; Href = Some (Page.Api "popper"); Children = [] }
                { Title = "Portal"; Href = Some (Page.Api "portal"); Children = [] }
                { Title = "Radio"; Href = Some (Page.Api "radio"); Children = [] }
                { Title = "RadioGroup"; Href = Some (Page.Api "radio-group"); Children = [] }
                // { Title = "RootRef"; Href = Some (Page.Api "root-ref"); Children = [] }
                { Title = "Select"; Href = Some (Page.Api "select"); Children = [] }
                { Title = "Slide"; Href = Some (Page.Api "slide"); Children = [] }
                { Title = "Snackbar"; Href = Some (Page.Api "snackbar"); Children = [] }
                { Title = "SnackbarContent"; Href = Some (Page.Api "snackbar-content"); Children = [] }
                { Title = "Step"; Href = Some (Page.Api "step"); Children = [] }
                { Title = "StepButton"; Href = Some (Page.Api "step-button"); Children = [] }
                { Title = "StepConnector"; Href = Some (Page.Api "step-connector"); Children = [] }
                { Title = "StepContent"; Href = Some (Page.Api "step-content"); Children = [] }
                { Title = "StepIcon"; Href = Some (Page.Api "step-icon"); Children = [] }
                { Title = "StepLabel"; Href = Some (Page.Api "step-label"); Children = [] }
                { Title = "Stepper"; Href = Some (Page.Api "stepper"); Children = [] }
                { Title = "SvgIcon"; Href = Some (Page.Api "svg-icon"); Children = [] }
                { Title = "SwipeableDrawer"; Href = Some (Page.Api "swipeable-drawer"); Children = [] }
                { Title = "Switch"; Href = Some (Page.Api "switch"); Children = [] }
                { Title = "Tab"; Href = Some (Page.Api "tab"); Children = [] }
                { Title = "Table"; Href = Some (Page.Api "table"); Children = [] }
                { Title = "TableBody"; Href = Some (Page.Api "table-body"); Children = [] }
                { Title = "TableCell"; Href = Some (Page.Api "table-cell"); Children = [] }
                { Title = "TableFooter"; Href = Some (Page.Api "table-footer"); Children = [] }
                { Title = "TableHead"; Href = Some (Page.Api "table-head"); Children = [] }
                { Title = "TablePagination"; Href = Some (Page.Api "table-pagination"); Children = [] }
                { Title = "TableRow"; Href = Some (Page.Api "table-row"); Children = [] }
                { Title = "TableSortLabel"; Href = Some (Page.Api "table-sort-label"); Children = [] }
                { Title = "Tabs"; Href = Some (Page.Api "tabs"); Children = [] }
                { Title = "TextField"; Href = Some (Page.Api "text-field"); Children = [] }
                { Title = "Toolbar"; Href = Some (Page.Api "toolbar"); Children = [] }
                { Title = "Tooltip"; Href = Some (Page.Api "tooltip"); Children = [] }
                { Title = "TouchRipple"; Href = Some (Page.Api "touch-ripple"); Children = [] }
                { Title = "Typography"; Href = Some (Page.Api "typography"); Children = [] }
                { Title = "Zoom"; Href = Some (Page.Api "zoom"); Children = [] }            ]
    }
    {
        Title = "Page layout demos"
        Href = None
        Children =
            [
                { Title = "Sign-in"; Href = Some Page.SignIn; Children = [] }
            ]
    }
]

let rec mapNavigation currentPage dispatch (depth: int) =
    fun item ->
        let opened =
            if not (item.Children |> List.isEmpty)
            then item.Children |> List.exists (fun i -> i.Href = Some currentPage)
            else false
        let childItems = item.Children |> List.map (mapNavigation currentPage dispatch (depth + 1))
        Layout.NavigationItem.view item depth opened currentPage childItems dispatch

let view currentPage dispatch =
    list [] (navItems |> List.map (mapNavigation currentPage dispatch 0))

