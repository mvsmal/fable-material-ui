## New in 1.3.2
* [BottomNavigation] Fixed typo in `ShowLabels`
* [BottomNavigation] Fixed `OnChange` to be `obj->obj->unit`
* [Tabs] Fixed `OnChange` to be `obj->int->unit`
* [ExpansionPanel] Fixed `OnChange` to be `obj->bool->unit`
* [FormControlLabel] Fixed `OnChange` to be `obj->bool->unit`
* [Modal] Fixed `OnClose` to be `obj->ModalCloseReason->unit`
* [RadioGroup] Fixed `OnChange` to be `obj->string->unit`
* [Select] Fixed `OnChange` to be `obj->obj->unit`
* [Snackbar] Fixed `OnClose` to be `obj->SnackbarCloseReason->unit`
* [TablePagination] Fixed `OnChangePage` to be `obj->int->unit`
* [Checkbox/Radio/Switch] Fixed `OnChange` to be `FormEvent->bool->unit`

## New in 1.3.1
* [Table] Fixed typo in TableSortDirection @toburger

## New in 1.3.0
* [TextField] Added TextFieldVariant enum and Variant to TextFieldProp
* [Typography] Added Inherit case to TypographyVariant enum
* [Icon/SvgIcon] Added Small and Large cases to IconFontSize enum
* [AppBar] Added Relative case to AppBarPosition enum
* [Snackbar] Added ClickAwayListenerProps
* [SwipeableDrawer] Added Hysteresis and MinFlingVelocity props
* [Chip] Added Variant prop
* [Dialog] Added Lg case for DialogMaxWidth enum
* [CardActionArea] Added cardActionArea component

## New in 1.2.2
* Fixed PascalCase props
* materialEl is inline now

## New in 1.2.1
* Fixed `typography` property in Theme

## New in 1.2.0
* Bindings for ColorManipulator

## New in 1.1.0
* Breaking Change: `withStyles` doesn't accept `props` and `children` anymore, you have to create a ReactElement with `from` helper
* Breaking Change: `withWidth` doesn't accept `props` and `children` anymore, you have to create a ReactElement with `from` helper

## New in 1.0.9
* Fixed `ExpansionPanel`

## New in 1.0.8
* Fixed `Styles.Custom` case to be `(string * obj)`

## New in 1.0.7
* Added `Custom` ClassKey to ClassNames

## New in 1.0.6
* Added breakpoints to theme
* Added `Custom` ClassKey
* Added `Form` ClassKey

## New in 1.0.5
* Added `Layout` ClassKey

## New in 1.0.4
* Fixed naming of Grid enums (AlignContent, AlignItems, Justify, Wrap, Direction). Now they have `Grid` prefix

## New in 1.0.3 
* Fixed naming of GridSpacing enum. Now it is called GridSpacing instead of Spacing

## New in 1.0.2
* Fixed import issues

## New in 1.0.1
* Added binding for `withWidth` HOC

## New in 1.0.0
* This is the first version of bindings with all components covered