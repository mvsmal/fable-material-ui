[<AutoOpen>]
module Fable.MaterialUI.Props

open Fable.Core
open Fable.Helpers.React.Props
open Fable.Import.React
open Fable.MaterialUI.Themes

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
    | DisableGutters of bool
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
    | Placement of PlacementType
    | RowsMax of int
    | [<CompiledName("SelectProps")>] SelectProps of IHTMLProp list
    | Timeout of TransitionDuration
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

type [<StringEnum; RequireQualifiedAccess>] AppBarPosition =
    | Fixed
    | Absolute
    | Sticky
    | Static

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
    | BadgeContent of ReactNode
    interface IHTMLProp

type BottomNavigationProp =
    | OnChange of (obj*obj->unit)
    | ShowLabel of bool
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
    | OnFocusVisible of (FocusEvent->unit)
    | [<CompiledName("TouchRippleProps")>] TouchRippleProps of IHTMLProp list
    | Type of ButtonBaseType
    interface IHTMLProp

type CardProp =
    | Raised of bool
    interface IHTMLProp

type CardActionsProp =
    | DisableActionSpacing of bool
    interface IHTMLProp

type CardHeaderProp =
    | Action of ReactNode
    | Avatar of ReactNode
    | Subheader of ReactNode
    | SubheaderTypographyProps of IHTMLProp list
    | Title of ReactNode
    | TitleTypographyProps of IHTMLProp list
    interface IHTMLProp

type CardMediaProp =
    | Image of string
    interface IHTMLProp

type CheckboxProp =
    | Indeterminate of bool
    | IndeterminateIcon of ReactNode
    interface IHTMLProp
    
type ChipProp =
    | Avatar of ReactElement
    | Clickable of bool
    | DeleteIcon of ReactElement
    | OnDelete of (FormEvent->unit)
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
    | [<CompiledName("ModalProps")>] ModalProps of IHTMLProp list
    | [<CompiledName("SlideProps")>] SlideProps of IHTMLProp list
    | Variant of DrawerVariant
    interface IHTMLProp

type ExpansionPanelProp =
    | Expanded of bool
    | DefaultExpanded of bool
    | OnChange of (obj*bool->unit)
    | [<CompiledName("CollapseProps")>] CollapseProps of IHTMLProp list
    interface IHTMLProp

type ExpansionPanelSummaryProp =
    | ExpandIcon of ReactNode
    | [<CompiledName("IconButtonProps")>] IconButtonProps of IHTMLProp list
    interface IHTMLProp

type [<StringEnum; RequireQualifiedAccess>] FormControlLabelPlacement = End | Start

type FormControlLabelProp =
    | Control of ReactElement
    | LabelPlacement of FormControlLabelPlacement
    | OnChange of (obj*bool->unit)
    interface IHTMLProp

type FormGroupProp =
    | Row of bool
    interface IHTMLProp

type FormLabelProp =
    | Focused of bool
    interface IHTMLProp

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

type GridListCellHeight = U2<int, AutoEnum>
type GridListProp =
    | CellHeight of GridListCellHeight
    | Spacing of int
    interface IHTMLProp

type [<StringEnum; RequireQualifiedAccess>] ActionPosition = Left | Right
type [<StringEnum; RequireQualifiedAccess>] TitlePosition = Top | Bottom

type GridListTileBarProp =
    | ActionIcon of ReactNode
    | ActionPosition of ActionPosition
    | Subtitle of ReactNode
    | Title of ReactNode
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

type [<StringEnum; RequireQualifiedAccess>] InputMargin = None | Dense

type InputProp =
    | DisableUnderline of bool
    | EndAdornment of ReactNode
    | InputComponent of ReactType
    | StartAdornment of ReactNode
    interface IHTMLProp

type [<StringEnum; RequireQualifiedAccess>] InputAdornmentPosition = Start | End

type InputAdornmentProp =
    | Position of InputAdornmentPosition
    interface IHTMLProp

type [<StringEnum; RequireQualifiedAccess>] InputLabelMargin = Dense

type InputLabelProp =
    | DisableAnimation of bool
    | [<CompiledName("FormLabelClasses")>] FormLabelClasses of IStyles list
    | Margin of InputLabelMargin
    | Shrink of bool
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
    | Subheader of ReactElement
    interface IHTMLProp

type ListItemProp = 
    | Button of bool
    | [<CompiledName("ContainerComponent")>] ContainerComponent of ReactType
    | [<CompiledName("ContainerProps")>] ContainerProps of IHTMLProp list
    | Divider of bool
    interface IHTMLProp

type ListItemTextProp =
    | Primary of ReactNode
    | PrimaryTypographyProps of IHTMLProp list
    | Secondary of ReactNode
    | SecondaryTypographyProps of IHTMLProp list
    interface IHTMLProp

type [<StringEnum; RequireQualifiedAccess>] ListSubheaderColor = Default | Primary | Inherit

type ListSubheaderProp =
    | Color of ListSubheaderColor
    | DisableSticky of bool
    interface IHTMLProp

type MenuProp =
    | DisableAutoFocusItem of bool
    | [<CompiledName("MenuListProps")>] MenuListProps of IHTMLProp list
    | [<CompiledName("PopoverClasses")>] PopoperClasses of IClassNames list
    | TransitionDuration of AutoTransitionDuration
    interface IHTMLProp

type [<StringEnum; RequireQualifiedAccess>] MobileStepperPosition = Bottom | Top | Static
type [<StringEnum; RequireQualifiedAccess>] MobileStepperVariant = Text | Dots | Progress

type MobileStepperProp =
    | ActiveStep of int
    | BackButton of ReactElement
    | NextButton of ReactElement
    | Position of MobileStepperPosition
    | [<CompiledName("LinearProgressProps")>] LinearProgressProps of IHTMLProp list
    | Steps of int
    | Variant of MobileStepperVariant
    interface IHTMLProp

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

type PaperProp =
    | Square of bool
    interface IHTMLProp

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

type PopperProp =
    | Modifies of obj
    | PopperOptions of obj
    | Transition of bool
    interface IHTMLProp

type RadioGroupProp =
    | OnChange of (obj*string->unit)
    interface IHTMLProp

type RootRefProp =
    | RootRef of RefProp
    interface IHTMLProp

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

type [<StringEnum; RequireQualifiedAccess>] SlideDirection = Bottom | Up | Left | Right

type SlideProp = 
    | Direction of SlideDirection
    interface IHTMLProp

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

type StepProp =
    | Completed of bool
    interface IHTMLProp

type StepContentProp =
    | TransitionDuration of AutoTransitionDuration
    interface IHTMLProp

type StepLabelProp =
    | [<CompiledName("StepIconProps")>] StepIconProps of IHTMLProp list
    interface IHTMLProp

type [<StringEnum; RequireQualifiedAccess>] StepperOrientation = Vertical | Horizontal

type StepperProp =
    | ActiveStep of int
    | AlternativeLabel of bool
    | Connector of ReactElement
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
    | OnChange of (obj*int->unit)
    | Scrollabel of bool
    | [<CompiledName("ScrollButtonComponent")>] ScrollButtonComponent of ReactType
    | ScrollButtons of ScrollButtonsType
    | [<CompiledName("TabIndicatorProps")>] TabIndicatorProps of IHTMLProp list
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

type TableRowProp =
    | Hover of bool
    interface IHTMLProp

type [<StringEnum; RequireQualifiedAccess>] TableSortDirection = Acs | Desc
type TableSortLabelProp =
    | Direction of TableSortDirection
    interface IHTMLProp

type TextFieldProp =
    | [<CompiledName("FormHelperTextProps")>] FormHelperTextProps of IHTMLProp list
    | HelperText of ReactNode
    | [<CompiledName("InputLabelProps")>] InputLabelProps of IHTMLProp list
    | [<CompiledName("InputProps")>] InputProps of IHTMLProp list
    | Select of bool
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
    | [<CompiledName("PopperProps")>] PopperProps of IHTMLProp list
    | Title of ReactNode
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
    | Display1
    | Display2
    | Display3
    | Display4
    | Headline
    | Title
    | Subheading
    | Body1
    | Body2
    | Caption
    | Button

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

type ThemeTypographyProp =
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
    | MuiToolbar of IStyles list
    | MuiTooltip of IStyles list
    | MuiTouchRipple of IStyles list
    | MuiTypography of IStyles list

// TODO implement breakpoints, mixins, transitions?
type ThemeProp =
    | Direction of TextDirection
    | Palette of PaletteProp list
    | Shadows of string list
    | Shape of ShapeProp list
    | Spacing of SpacingProp list
    | Typography of ThemeTypographyProp list
    | ZIndex of ZIndexProp list
    | Overrides of OverridesProp list

type [<Erase>] ProviderTheme =
    | Theme of ITheme
    | Func of (ITheme->ThemeProp list)

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