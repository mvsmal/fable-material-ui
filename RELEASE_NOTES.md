## New in 3.0.0
* [BREAKING CHANGE] Move `Fable.Helpers.MaterialUI` module to `Fable.MaterialUI.Core`
* [BREAKING CHANGE] Remove all imported _PascalCased_ `ComponentClass<'P>` components, keep only `reactElement (props : IHTMLProp list) (children : ReactElement list)` elements
* [BREAKING CHANGE] Change signature of `ITransitions.create` method to `create: props : U2<string, string[]> * ?options: ITransitionOptions -> string`

## New in 2.6.0
* [Dialog] Add `ChildrenProp.PaperComponent` prop
* [Menu] Add `MenuProp.OnClose` prop with `MenuCloseReason`
* [TableCell] Add `TableCell.Align` prop and deprecate `TableCell.Numeric`

## New in 2.5.0
* Change Fable.MaterialUI to be a namespace, not module
* [Fab] Add `Fab` component
* [Button] Deprecate variants `Fab` and `ExtendedFab`
* [Divider] Add `DividerVariant` prop
* [Dialog] Add `MaxWidth.Xl`

## New in 2.4.2
* Fix quoted styles #44

## New in 2.4.1
* [Badge] Add `Invisible` prop

## New in 2.4.0
* [SvgIcon] Add `ShapeRendering` prop
* [SvgIcon] Add missing `ViewBox` prop
* [FormControlLabel] Add `Top` and `Bottom` `LabelPlacement` property variants
* [CircularProgress] Add `DisableShrink` prop

## New in 2.3.0
* [Avatar] `AvatarProp.Sizes` marked as deprecated. Use `HTMLAttr.Sizes` instead
* [BottomNavigation] `BottomNavigationProp.Value` and `BottomNavigationActionProp.Value` are marked as deprecated. Use `MaterialProp.Value` instead
* [FormHelperText] Add `Filled`, `Focused` and `Variant` props
* [FormLabel] Add `Filled` prop
* [LinearProgress] Add `Value`(of int) prop
* [MuiThemeProvider] Add `SheetsManager` prop
* [NativeSelect] Add `NativeSelectProp`: `Variant` and `Input`
* [TableSortlabel] Add `HideSortIcon` prop
* [InputBase] Add `InputBaseProp`
* [InputLabel] Add `Focused` prop
* [OutlinedInput] Add `LabelWidth`, `InputComponent`, `StartAdornment` and `EndAdornment` props
* [Typography] Add `HeadlineMapping` and `InternalDeprecationVariant` props
* Add `MaterialProp.DefaultValue` (of obj) prop

## New in 2.2.1
* [Theme] Added missing typography props for `ITheme.typography` obj

## New in 2.2.0
* **BREAKING CHANGE** [WithStyles] `StyleOption.Flip` is now `bool option`
* **BREAKING CHANGE** [ProviderTheme.Func] is now `ITheme->ITheme`. `unbox` can be used
* [WithStyles] Added `StyleOption.Custom`
* [Theme] Added `ThemeProp.Props` for overriding of props for the whole theme

## New in 2.1.1
* [Tabs] `TabsProp.Scrollable` typo fix

## New in 2.1.0
* [FilledInput] Added `FilledInput` component
* [InputBase] Added `InputBase` component
* [FormControl] Added `FormControlProp` DU

## New in 2.0.2
* Fixed Fable 2 support

## New in 2.0.1
* Fixed `Styles.Completed`

## New in 2.0.0
* Support Fable 2 (required version of dotnet-fable: 2.0.6)
* BREAKING CHANGE: `Styles.Custom` has new signature: `string * CSSProp list -> Styles`
* BREAKING CHANGE: Predefined `Styles` props for class keys need qualified access, e.g. `Styles.Root` or `open Fable.MaterialUI.Themes.Styles`
* BREAKING CHANGE: `MenuProp.TransitionDuration`, `PopoverProp.TransitionDuration`, `StepContentProp.TransitionDuration` are moved to `MaterialProp.TransitionDurationAuto`

## New in 1.4.0
* [Theme] Fixed Overrides prop (PascalCase issue)
* [Theme] Added `transitions` and `mixins` properties
* [Theme] Added `withTheme` HOC
* [Styles] Added `isWidthUp`, `isWidthDown` helpers
* [Typography] Added V2 Typography variants
* [Transitions] Added `TransitionProp`
* [Buttons] `Flat` and `Raised` variants are deprecated
* [OutlinedInput] Added `OutlinedInput` component
* [Select] Added Variant prop
* [InputLabel] Added Variant prop
* [InputAdornment] Added Variant prop
* [StepLabel] Added StepIconComponent prop

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