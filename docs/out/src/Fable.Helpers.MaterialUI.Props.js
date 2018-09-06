import { setType } from "../fable-core/Symbol";
import _Symbol from "../fable-core/Symbol";
import { Tuple, Unit, Function as _Function, Interface, compareUnions, equals, Any, makeGeneric } from "../fable-core/Util";
import List from "../fable-core/List";
import { Props as Props_1 } from "../fable/Fable.Helpers.React";
import red_1 from "@material-ui/core/colors/red";
import pink_1 from "@material-ui/core/colors/pink";
import purple_1 from "@material-ui/core/colors/purple";
import deepPurple_1 from "@material-ui/core/colors/deepPurple";
import indigo_1 from "@material-ui/core/colors/indigo";
import blue_1 from "@material-ui/core/colors/blue";
import lightBlue_1 from "@material-ui/core/colors/lightBlue";
import cyan_1 from "@material-ui/core/colors/cyan";
import teal_1 from "@material-ui/core/colors/teal";
import green_1 from "@material-ui/core/colors/green";
import lightGreen_1 from "@material-ui/core/colors/lightGreen";
import lime_1 from "@material-ui/core/colors/lime";
import yellow_1 from "@material-ui/core/colors/yellow";
import amber_1 from "@material-ui/core/colors/amber";
import orange_1 from "@material-ui/core/colors/orange";
import deepOrange_1 from "@material-ui/core/colors/deepOrange";
import brown_1 from "@material-ui/core/colors/brown";
import grey_1 from "@material-ui/core/colors/grey";
import blueGrey_1 from "@material-ui/core/colors/blueGrey";
export const Themes = function (__exports) {
  const Styles = __exports.Styles = class Styles {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Themes.Styles",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.MaterialUI.Themes.IStyles"],
        cases: [["Absolute", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Action", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ActionIcon", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ActionIconActionPosLeft", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Actions", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["AlignCenter", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["AlignJistify", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["AlignLeft", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["AlignRight", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["AlternativeLabel", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["AnchorOriginBottomCenter", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["AnchorOriginBottomLeft", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["AnchorOriginBottomRight", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["AnchorOriginTopCenter", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["AnchorOriginTopLeft", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["AnchorOriginTopRight", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Animated", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Asterisk", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Avatar", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["AvatarChildren", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Badge", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Bar", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Bar1Buffer", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Bar1Determinate", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Bar1Indeterminate", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Bar2Buffer", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Bar2Determinate", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Bar2Indeterminate", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["BarColorPrimary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["BarColorSecondary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Body", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Body1", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Body2", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Button", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Caption", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Centered", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Checked", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Child", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ChildLeaving", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ChildPulsate", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Circle", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["CircleIndeterminate", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["CircleStatic", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Clickable", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ColorAction", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ColorDefault", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ColorDisabled", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ColorError", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ColorInherit", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ColorPrimary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ColorSecondary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ColorTextPrimary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ColorTextSecondary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Completed", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Contained", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ContainedPrimary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ContainedSecondary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Container", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Content", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Default", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Deletable", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["DeleteIcon", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Dense", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Disabled", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Display1", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Display2", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Display3", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Display4", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Divider", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Docked", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Dot", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["DotActive", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Dots", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation0", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation1", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation10", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation11", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation12", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation13", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation14", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation15", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation16", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation17", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation18", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation19", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation2", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation20", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation21", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation22", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation23", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation24", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation3", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation4", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation5", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation6", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation7", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation8", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Elevation9", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Entered", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Error", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ExpandIcon", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Expanded", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ExtendedFab", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Fab", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Filled", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Fixed", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Flat", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["FlatPrimary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["FlatSecondary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["FlexContainer", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["FocusVisible", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Focused", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["FontSizeInherit", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Footer", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Form", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["FormControl", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["FullWidth", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["GutterBottom", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Gutters", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Head", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Headline", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Hidden", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Horizontal", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Hover", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Icon", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["IconContainer", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["IconDirectionAsc", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["IconDirectionDesc", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Img", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ImgFullHeight", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ImgFullWidth", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Indeterminate", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Indicator", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Input", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["InputMarginDense", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["InputMultiline", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["InputType", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["InputTypeSearch", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Inset", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Invisible", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Item", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Label", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["LabelContainer", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["LabelIcon", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["LabelPlacementStart", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["LabelWrapped", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Last", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Layout", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Light", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Line", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["LineHorizontal", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["LineVertical", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["MarginDense", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["MarginNormal", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Media", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["MenuItem", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Message", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Mini", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Modal", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Multiline", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["NoWrap", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Numeric", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Outlined", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["OutlinedPrimary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["OutlinedSecondary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Padding", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaddingCheckbox", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaddingDense", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaddingNone", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Paper", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaperAnchorBottom", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaperAnchorDockedBottom", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaperAnchorDockedLeft", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaperAnchorDockedRight", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaperAnchorDockedTop", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaperAnchorLeft", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaperAnchorRight", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaperAnchorTop", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaperFullScreen", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaperFullWidth", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaperScrollBody", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaperScrollPaper", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaperWidthMd", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaperWidthSm", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PaperWidthXs", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Paragraph", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Popper", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PositionAbsolute", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PositionBottom", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PositionEnd", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PositionFixed", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PositionStart", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PositionStatic", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PositionSticky", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["PositionTop", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Primary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Progress", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Raised", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["RaisedPrimary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["RaisedSecondary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Required", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Regular", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Ripple", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["RipplePulsate", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["RippleVisible", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Root", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["RootSubtitle", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Rounded", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Row", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ScrollButtons", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ScrollButtonsAuto", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Scrollable", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Scroller", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Secondary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["SecondaryAction", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Select", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["SelectIcon", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["SelectMenu", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["SelectRoot", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Selected", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Shrink", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["SizeLarge", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["SizeSmall", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Spacer", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Static", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Sticky", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Subheader", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Subheading", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Subtitle", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Svg", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["SwitchBase", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Text", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["TextColorInherit", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["TextColorPrimary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["TextColorSecondary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["TextDense", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["TextPrimary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["TextSecondary", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Tile", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Title", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["TitlePositionBottom", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["TitlePositionTop", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["TitleWrap", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["TitleWrapActionPosLeft", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["TitleWrapActionPosRight", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Toolbar", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Tooltip", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["TooltipPlacementBottom", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["TooltipPlacementLeft", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["TooltipPlacementRight", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["TooltipPlacementTop", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Touch", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["TouchRipple", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Transition", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Underline", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Vertical", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Wrapper", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["WrapperInner", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["ZeroMinWidth", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Align-content-xs-center", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Align-content-xs-flex-end", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Align-content-xs-flex-start", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Align-content-xs-space-around", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Align-content-xs-space-between", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Align-items-xs-baseline", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Align-items-xs-center", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Align-items-xs-flex-end", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Align-items-xs-flex-start", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Direction-xs-column-reverse", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Direction-xs-column", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Direction-xs-row-reverse", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Grid-xs-10", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Grid-xs-11", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Grid-xs-12", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Grid-xs-1", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Grid-xs-2", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Grid-xs-3", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Grid-xs-4", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Grid-xs-5", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Grid-xs-6", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Grid-xs-7", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Grid-xs-8", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Grid-xs-9", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Grid-xs-auto", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Grid-xs-true", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Justify-xs-center", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Justify-xs-flex-end", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Justify-xs-space-around", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Justify-xs-space-between", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Justify-xs-space-evenly", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Spacing-xs-16", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Spacing-xs-24", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Spacing-xs-32", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Spacing-xs-40", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Spacing-xs-8", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Wrap-xs-nowrap", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Wrap-xs-wrap-reverse", makeGeneric(List, {
          T: Props_1.CSSProp
        })], ["Custom", "string", Any]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Themes.Styles", Styles);
  const ClassNames = __exports.ClassNames = class ClassNames {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Themes.ClassNames",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.MaterialUI.Themes.IClassNames"],
        cases: [["Absolute", "string"], ["Action", "string"], ["ActionIcon", "string"], ["ActionIconActionPosLeft", "string"], ["Actions", "string"], ["AlignCenter", "string"], ["AlignJistify", "string"], ["AlignLeft", "string"], ["AlignRight", "string"], ["AlternativeLabel", "string"], ["AnchorOriginBottomCenter", "string"], ["AnchorOriginBottomLeft", "string"], ["AnchorOriginBottomRight", "string"], ["AnchorOriginTopCenter", "string"], ["AnchorOriginTopLeft", "string"], ["AnchorOriginTopRight", "string"], ["Animated", "string"], ["Asterisk", "string"], ["Avatar", "string"], ["AvatarChildren", "string"], ["Badge", "string"], ["Bar", "string"], ["Bar1Buffer", "string"], ["Bar1Determinate", "string"], ["Bar1Indeterminate", "string"], ["Bar2Buffer", "string"], ["Bar2Determinate", "string"], ["Bar2Indeterminate", "string"], ["BarColorPrimary", "string"], ["BarColorSecondary", "string"], ["Body", "string"], ["Body1", "string"], ["Body2", "string"], ["Buffer", "string"], ["Button", "string"], ["Caption", "string"], ["Centered", "string"], ["Checked", "string"], ["Child", "string"], ["ChildLeaving", "string"], ["ChildPulsate", "string"], ["Circle", "string"], ["CircleIndeterminate", "string"], ["CircleStatic", "string"], ["Clickable", "string"], ["ColorAction", "string"], ["ColorDefault", "string"], ["ColorDisabled", "string"], ["ColorError", "string"], ["ColorInherit", "string"], ["ColorPrimary", "string"], ["ColorSecondary", "string"], ["ColorTextPrimary", "string"], ["ColorTextSecondary", "string"], ["Completed", "string"], ["Contained", "string"], ["ContainedPrimary", "string"], ["ContainedSecondary", "string"], ["Container", "string"], ["Content", "string"], ["Dashed", "string"], ["DashedColorPrimary", "string"], ["DashedColorSecondary", "string"], ["Default", "string"], ["Deletable", "string"], ["DeleteIcon", "string"], ["Dense", "string"], ["Disabled", "string"], ["Display1", "string"], ["Display2", "string"], ["Display3", "string"], ["Display4", "string"], ["Divider", "string"], ["Docked", "string"], ["Dot", "string"], ["DotActive", "string"], ["Dots", "string"], ["Elevation0", "string"], ["Elevation1", "string"], ["Elevation10", "string"], ["Elevation11", "string"], ["Elevation12", "string"], ["Elevation13", "string"], ["Elevation14", "string"], ["Elevation15", "string"], ["Elevation16", "string"], ["Elevation17", "string"], ["Elevation18", "string"], ["Elevation19", "string"], ["Elevation2", "string"], ["Elevation20", "string"], ["Elevation21", "string"], ["Elevation22", "string"], ["Elevation23", "string"], ["Elevation24", "string"], ["Elevation3", "string"], ["Elevation4", "string"], ["Elevation5", "string"], ["Elevation6", "string"], ["Elevation7", "string"], ["Elevation8", "string"], ["Elevation9", "string"], ["Entered", "string"], ["Error", "string"], ["ExpandIcon", "string"], ["Expanded", "string"], ["ExtendedFab", "string"], ["Fab", "string"], ["Filled", "string"], ["Fixed", "string"], ["Flat", "string"], ["FlatPrimary", "string"], ["FlatSecondary", "string"], ["FlexContainer", "string"], ["FocusVisible", "string"], ["Focused", "string"], ["FontSizeInherit", "string"], ["Footer", "string"], ["Form", "string"], ["FormControl", "string"], ["FullWidth", "string"], ["GutterBottom", "string"], ["Gutters", "string"], ["Head", "string"], ["Headline", "string"], ["Hidden", "string"], ["Horizontal", "string"], ["Hover", "string"], ["Icon", "string"], ["IconContainer", "string"], ["IconDirectionAsc", "string"], ["IconDirectionDesc", "string"], ["Img", "string"], ["ImgFullHeight", "string"], ["ImgFullWidth", "string"], ["Indeterminate", "string"], ["Indicator", "string"], ["Input", "string"], ["InputMarginDense", "string"], ["InputMultiline", "string"], ["InputType", "string"], ["InputTypeSearch", "string"], ["Inset", "string"], ["Invisible", "string"], ["Item", "string"], ["Label", "string"], ["LabelContainer", "string"], ["LabelIcon", "string"], ["LabelPlacementStart", "string"], ["LabelWrapped", "string"], ["Last", "string"], ["Layout", "string"], ["Light", "string"], ["Line", "string"], ["LineHorizontal", "string"], ["LineVertical", "string"], ["MarginDense", "string"], ["MarginNormal", "string"], ["Media", "string"], ["MenuItem", "string"], ["Message", "string"], ["Mini", "string"], ["Modal", "string"], ["Multiline", "string"], ["NoWrap", "string"], ["Numeric", "string"], ["Outlined", "string"], ["OutlinedPrimary", "string"], ["OutlinedSecondary", "string"], ["Padding", "string"], ["PaddingCheckbox", "string"], ["PaddingDense", "string"], ["PaddingNone", "string"], ["Paper", "string"], ["PaperAnchorBottom", "string"], ["PaperAnchorDockedBottom", "string"], ["PaperAnchorDockedLeft", "string"], ["PaperAnchorDockedRight", "string"], ["PaperAnchorDockedTop", "string"], ["PaperAnchorLeft", "string"], ["PaperAnchorRight", "string"], ["PaperAnchorTop", "string"], ["PaperFullScreen", "string"], ["PaperFullWidth", "string"], ["PaperScrollBody", "string"], ["PaperScrollPaper", "string"], ["PaperWidthMd", "string"], ["PaperWidthSm", "string"], ["PaperWidthXs", "string"], ["Paragraph", "string"], ["Popper", "string"], ["PositionAbsolute", "string"], ["PositionBottom", "string"], ["PositionEnd", "string"], ["PositionFixed", "string"], ["PositionStart", "string"], ["PositionStatic", "string"], ["PositionSticky", "string"], ["PositionTop", "string"], ["Primary", "string"], ["Progress", "string"], ["Query", "string"], ["Raised", "string"], ["RaisedPrimary", "string"], ["RaisedSecondary", "string"], ["Required", "string"], ["Regular", "string"], ["Ripple", "string"], ["RipplePulsate", "string"], ["RippleVisible", "string"], ["Root", "string"], ["RootSubtitle", "string"], ["Rounded", "string"], ["Row", "string"], ["ScrollBody", "string"], ["ScrollButtons", "string"], ["ScrollButtonsAuto", "string"], ["ScrollPaper", "string"], ["Scrollable", "string"], ["Scroller", "string"], ["Secondary", "string"], ["SecondaryAction", "string"], ["Select", "string"], ["SelectIcon", "string"], ["SelectMenu", "string"], ["SelectRoot", "string"], ["Selected", "string"], ["Shrink", "string"], ["SizeLarge", "string"], ["SizeSmall", "string"], ["Spacer", "string"], ["Static", "string"], ["Sticky", "string"], ["Subheader", "string"], ["Subheading", "string"], ["Subtitle", "string"], ["Svg", "string"], ["SwitchBase", "string"], ["Text", "string"], ["TextColorInherit", "string"], ["TextColorPrimary", "string"], ["TextColorSecondary", "string"], ["TextDense", "string"], ["TextPrimary", "string"], ["TextSecondary", "string"], ["Tile", "string"], ["Title", "string"], ["TitlePositionBottom", "string"], ["TitlePositionTop", "string"], ["TitleWrap", "string"], ["TitleWrapActionPosLeft", "string"], ["TitleWrapActionPosRight", "string"], ["Toolbar", "string"], ["Tooltip", "string"], ["TooltipPlacementBottom", "string"], ["TooltipPlacementLeft", "string"], ["TooltipPlacementRight", "string"], ["TooltipPlacementTop", "string"], ["Touch", "string"], ["TouchRipple", "string"], ["Transition", "string"], ["Underline", "string"], ["Vertical", "string"], ["Wrapper", "string"], ["WrapperInner", "string"], ["ZeroMinWidth", "string"], ["Align-content-xs-center", "string"], ["Align-content-xs-flex-end", "string"], ["Align-content-xs-flex-start", "string"], ["Align-content-xs-space-around", "string"], ["Align-content-xs-space-between", "string"], ["Align-items-xs-baseline", "string"], ["Align-items-xs-center", "string"], ["Align-items-xs-flex-end", "string"], ["Align-items-xs-flex-start", "string"], ["Direction-xs-column-reverse", "string"], ["Direction-xs-column", "string"], ["Direction-xs-row-reverse", "string"], ["Grid-xs-10", "string"], ["Grid-xs-11", "string"], ["Grid-xs-12", "string"], ["Grid-xs-1", "string"], ["Grid-xs-2", "string"], ["Grid-xs-3", "string"], ["Grid-xs-4", "string"], ["Grid-xs-5", "string"], ["Grid-xs-6", "string"], ["Grid-xs-7", "string"], ["Grid-xs-8", "string"], ["Grid-xs-9", "string"], ["Grid-xs-auto", "string"], ["Grid-xs-true", "string"], ["Justify-xs-center", "string"], ["Justify-xs-flex-end", "string"], ["Justify-xs-space-around", "string"], ["Justify-xs-space-between", "string"], ["Justify-xs-space-evenly", "string"], ["Spacing-xs-16", "string"], ["Spacing-xs-24", "string"], ["Spacing-xs-32", "string"], ["Spacing-xs-40", "string"], ["Spacing-xs-8", "string"], ["Wrap-xs-nowrap", "string"], ["Wrap-xs-wrap-reverse", "string"], ["Custom", "string", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Themes.ClassNames", ClassNames);
  return __exports;
}({});
export const Colors = function (__exports) {
  const red = __exports.red = red_1;
  const pink = __exports.pink = pink_1;
  const purple = __exports.purple = purple_1;
  const deepPurple = __exports.deepPurple = deepPurple_1;
  const indigo = __exports.indigo = indigo_1;
  const blue = __exports.blue = blue_1;
  const lightBlue = __exports.lightBlue = lightBlue_1;
  const cyan = __exports.cyan = cyan_1;
  const teal = __exports.teal = teal_1;
  const green = __exports.green = green_1;
  const lightGreen = __exports.lightGreen = lightGreen_1;
  const lime = __exports.lime = lime_1;
  const yellow = __exports.yellow = yellow_1;
  const amber = __exports.amber = amber_1;
  const orange = __exports.orange = orange_1;
  const deepOrange = __exports.deepOrange = deepOrange_1;
  const brown = __exports.brown = brown_1;
  const grey = __exports.grey = grey_1;
  const blueGrey = __exports.blueGrey = blueGrey_1;
  return __exports;
}({});
export const Props = function (__exports) {
  const StyleOption = __exports.StyleOption = class StyleOption {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.StyleOption",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable"],
        cases: [["WithTheme", "boolean"], ["Name", "string"], ["Flip", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.StyleOption", StyleOption);
  const TransitionDurationProp = __exports.TransitionDurationProp = class TransitionDurationProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.TransitionDurationProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable"],
        cases: [["Enter", "number"], ["Exit", "number"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.TransitionDurationProp", TransitionDurationProp);
  const MaterialProp = __exports.MaterialProp = class MaterialProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.MaterialProp",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Active", "boolean"], ["AnchorEl", Any], ["CheckedIcon", Any], ["Classes", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IClassNames")
        })], ["Color", "string"], ["Component", Any], ["Container", Any], ["Dense", "boolean"], ["DisableGutters", "boolean"], ["DisablePortal", "boolean"], ["DisableRipple", "boolean"], ["DisableTypography", "boolean"], ["Elevation", "number"], ["Error", "boolean"], ["FullWidth", "boolean"], ["Icon", Any], ["In", "boolean"], ["InputProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["InputRef", Any], ["Inset", "boolean"], ["KeepMounted", "boolean"], ["Label", Any], ["Margin", "string"], ["Multiline", "boolean"], ["Open", "boolean"], ["Optional", Any], ["PaperProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["Placement", "string"], ["RowsMax", "number"], ["SelectProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["Timeout", Any], ["TransitionComponent", Any], ["TransitionDuration", Any], ["TransitionProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["Value", Any], ["OnClose", _Function([Any, Unit])], ["OnEnter", _Function([Any, Unit])], ["OnEntered", _Function([Any, Unit])], ["OnEntering", _Function([Any, Unit])], ["OnExit", _Function([Any, Unit])], ["OnExited", _Function([Any, Unit])], ["OnExiting", _Function([Any, Unit])], ["OnOpen", _Function([Any, Unit])], ["OnRendered", _Function([Any, Unit])]]
      };
    }

  };
  setType("Fable.MaterialUI.Props.MaterialProp", MaterialProp);
  const SelectionControlProp = __exports.SelectionControlProp = class SelectionControlProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.SelectionControlProp",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Color", "string"], ["OnChange", _Function([Tuple([Interface("Fable.Import.React.FormEvent"), "boolean"]), Unit])]]
      };
    }

  };
  setType("Fable.MaterialUI.Props.SelectionControlProp", SelectionControlProp);
  const AppBarProp = __exports.AppBarProp = class AppBarProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.AppBarProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Position", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.AppBarProp", AppBarProp);
  const AvatarProp = __exports.AvatarProp = class AvatarProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.AvatarProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["ImgProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["Sizes", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.AvatarProp", AvatarProp);
  const BackdropProp = __exports.BackdropProp = class BackdropProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.BackdropProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Invisible", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.BackdropProp", BackdropProp);
  const BadgeProp = __exports.BadgeProp = class BadgeProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.BadgeProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Color", "string"], ["BadgeContent", Any]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.BadgeProp", BadgeProp);
  const BottomNavigationProp = __exports.BottomNavigationProp = class BottomNavigationProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.BottomNavigationProp",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["OnChange", _Function([Tuple([Any, Any]), Unit])], ["ShowLabel", "boolean"], ["Value", Any]]
      };
    }

  };
  setType("Fable.MaterialUI.Props.BottomNavigationProp", BottomNavigationProp);
  const BottomNavigationActionProp = __exports.BottomNavigationActionProp = class BottomNavigationActionProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.BottomNavigationActionProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["ShowLabel", "boolean"], ["Value", Any]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.BottomNavigationActionProp", BottomNavigationActionProp);
  const ButtonProp = __exports.ButtonProp = class ButtonProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.ButtonProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["DisableFocusRipple", "boolean"], ["Href", "string"], ["Mini", "boolean"], ["Size", "string"], ["Variant", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.ButtonProp", ButtonProp);
  const ButtonBaseProp = __exports.ButtonBaseProp = class ButtonBaseProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.ButtonBaseProp",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Action", _Function([Interface("Fable.MaterialUI.Props.IButtonBaseActions"), Unit])], ["ButtonRef", Any], ["CenterRipple", "boolean"], ["DisableTouchRipple", "boolean"], ["FocusRipple", "boolean"], ["FocusVisibleClassName", "string"], ["OnFocusVisible", _Function([Interface("Fable.Import.React.FocusEvent"), Unit])], ["TouchRippleProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["Type", "string"]]
      };
    }

  };
  setType("Fable.MaterialUI.Props.ButtonBaseProp", ButtonBaseProp);
  const CardProp = __exports.CardProp = class CardProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.CardProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Raised", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.CardProp", CardProp);
  const CardActionsProp = __exports.CardActionsProp = class CardActionsProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.CardActionsProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["DisableActionSpacing", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.CardActionsProp", CardActionsProp);
  const CardHeaderProp = __exports.CardHeaderProp = class CardHeaderProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.CardHeaderProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Action", Any], ["Avatar", Any], ["Subheader", Any], ["SubheaderTypographyProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["Title", Any], ["TitleTypographyProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.CardHeaderProp", CardHeaderProp);
  const CardMediaProp = __exports.CardMediaProp = class CardMediaProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.CardMediaProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Image", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.CardMediaProp", CardMediaProp);
  const CheckboxProp = __exports.CheckboxProp = class CheckboxProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.CheckboxProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Indeterminate", "boolean"], ["IndeterminateIcon", Any]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.CheckboxProp", CheckboxProp);
  const ChipProp = __exports.ChipProp = class ChipProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.ChipProp",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Avatar", Interface("Fable.Import.React.ReactElement")], ["Clickable", "boolean"], ["DeleteIcon", Interface("Fable.Import.React.ReactElement")], ["OnDelete", _Function([Interface("Fable.Import.React.FormEvent"), Unit])]]
      };
    }

  };
  setType("Fable.MaterialUI.Props.ChipProp", ChipProp);
  const CircularProgressProp = __exports.CircularProgressProp = class CircularProgressProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.CircularProgressProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Size", Any], ["Thickness", "number"], ["Value", "number"], ["Variant", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.CircularProgressProp", CircularProgressProp);
  const ClickAwayListenerProp = __exports.ClickAwayListenerProp = class ClickAwayListenerProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.ClickAwayListenerProp",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["OnClickAway", _Function([Any, Unit])], ["MouseEvent", Any], ["TouchEvent", Any]]
      };
    }

  };
  setType("Fable.MaterialUI.Props.ClickAwayListenerProp", ClickAwayListenerProp);
  const CollapseProp = __exports.CollapseProp = class CollapseProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.CollapseProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["CollapseHeight", "string"], ["Timeout", Any]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.CollapseProp", CollapseProp);
  const DialogProp = __exports.DialogProp = class DialogProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.DialogProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["FullScreen", "boolean"], ["MaxWidth", "string"], ["Scroll", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.DialogProp", DialogProp);
  const DialogActionsProp = __exports.DialogActionsProp = class DialogActionsProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.DialogActionsProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["DisableActionSpacing", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.DialogActionsProp", DialogActionsProp);
  const DividerProp = __exports.DividerProp = class DividerProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.DividerProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Absolute", "boolean"], ["Light", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.DividerProp", DividerProp);
  const DrawerProp = __exports.DrawerProp = class DrawerProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.DrawerProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Anchor", "string"], ["ModalProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["SlideProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["Variant", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.DrawerProp", DrawerProp);
  const ExpansionPanelProp = __exports.ExpansionPanelProp = class ExpansionPanelProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.ExpansionPanelProp",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Expanded", "boolean"], ["DefaultExpanded", "boolean"], ["OnChange", _Function([Tuple([Any, "boolean"]), Unit])], ["CollapseProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })]]
      };
    }

  };
  setType("Fable.MaterialUI.Props.ExpansionPanelProp", ExpansionPanelProp);
  const ExpansionPanelSummaryProp = __exports.ExpansionPanelSummaryProp = class ExpansionPanelSummaryProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.ExpansionPanelSummaryProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["ExpandIcon", Any], ["IconButtonProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.ExpansionPanelSummaryProp", ExpansionPanelSummaryProp);
  const FormControlLabelProp = __exports.FormControlLabelProp = class FormControlLabelProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.FormControlLabelProp",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Control", Interface("Fable.Import.React.ReactElement")], ["LabelPlacement", "string"], ["OnChange", _Function([Tuple([Any, "boolean"]), Unit])]]
      };
    }

  };
  setType("Fable.MaterialUI.Props.FormControlLabelProp", FormControlLabelProp);
  const FormGroupProp = __exports.FormGroupProp = class FormGroupProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.FormGroupProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Row", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.FormGroupProp", FormGroupProp);
  const FormLabelProp = __exports.FormLabelProp = class FormLabelProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.FormLabelProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Focused", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.FormLabelProp", FormLabelProp);
  const GridProp = __exports.GridProp = class GridProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.GridProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["AlignContent", "string"], ["AlignItems", "string"], ["Container", "boolean"], ["Direction", "string"], ["Item", "boolean"], ["Justify", "string"], ["Lg", Any], ["Md", Any], ["Sm", Any], ["Xl", Any], ["Xs", Any], ["Spacing", "number"], ["Wrap", "string"], ["ZeroMinWidth", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.GridProp", GridProp);
  const GridListProp = __exports.GridListProp = class GridListProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.GridListProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["CellHeight", Any], ["Spacing", "number"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.GridListProp", GridListProp);
  const GridListTileBarProp = __exports.GridListTileBarProp = class GridListTileBarProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.GridListTileBarProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["ActionIcon", Any], ["ActionPosition", "string"], ["Subtitle", Any], ["Title", Any], ["TitlePosition", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.GridListTileBarProp", GridListTileBarProp);
  const GrowProp = __exports.GrowProp = class GrowProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.GrowProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Timeout", Any]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.GrowProp", GrowProp);
  const HiddenProp = __exports.HiddenProp = class HiddenProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.HiddenProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Implementation", "string"], ["InitialWidth", "string"], ["LgDown", "boolean"], ["LgUp", "boolean"], ["MdDown", "boolean"], ["MdUp", "boolean"], ["Only", Any], ["SmDown", "boolean"], ["SmUp", "boolean"], ["XlDown", "boolean"], ["XlUp", "boolean"], ["XsDown", "boolean"], ["XsUp", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.HiddenProp", HiddenProp);
  const IconProp = __exports.IconProp = class IconProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.IconProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Color", "string"], ["FontSize", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.IconProp", IconProp);
  const InputProp = __exports.InputProp = class InputProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.InputProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["DisableUnderline", "boolean"], ["EndAdornment", Any], ["InputComponent", Any], ["StartAdornment", Any]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.InputProp", InputProp);
  const InputAdornmentProp = __exports.InputAdornmentProp = class InputAdornmentProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.InputAdornmentProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Position", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.InputAdornmentProp", InputAdornmentProp);
  const InputLabelProp = __exports.InputLabelProp = class InputLabelProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.InputLabelProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["DisableAnimation", "boolean"], ["FormLabelClasses", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["Margin", "string"], ["Shrink", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.InputLabelProp", InputLabelProp);
  const LinearProgressProp = __exports.LinearProgressProp = class LinearProgressProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.LinearProgressProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Color", "string"], ["ValueBuffer", "number"], ["Variant", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.LinearProgressProp", LinearProgressProp);
  const ListProp = __exports.ListProp = class ListProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.ListProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["DisablePadding", "boolean"], ["Subheader", Interface("Fable.Import.React.ReactElement")]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.ListProp", ListProp);
  const ListItemProp = __exports.ListItemProp = class ListItemProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.ListItemProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Button", "boolean"], ["ContainerComponent", Any], ["ContainerProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["Divider", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.ListItemProp", ListItemProp);
  const ListItemTextProp = __exports.ListItemTextProp = class ListItemTextProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.ListItemTextProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Primary", Any], ["PrimaryTypographyProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["Secondary", Any], ["SecondaryTypographyProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.ListItemTextProp", ListItemTextProp);
  const ListSubheaderProp = __exports.ListSubheaderProp = class ListSubheaderProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.ListSubheaderProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Color", "string"], ["DisableSticky", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.ListSubheaderProp", ListSubheaderProp);
  const MenuProp = __exports.MenuProp = class MenuProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.MenuProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["DisableAutoFocusItem", "boolean"], ["MenuListProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["PopoverClasses", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IClassNames")
        })], ["TransitionDuration", Any]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.MenuProp", MenuProp);
  const MobileStepperProp = __exports.MobileStepperProp = class MobileStepperProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.MobileStepperProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["ActiveStep", "number"], ["BackButton", Interface("Fable.Import.React.ReactElement")], ["NextButton", Interface("Fable.Import.React.ReactElement")], ["Position", "string"], ["LinearProgressProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["Steps", "number"], ["Variant", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.MobileStepperProp", MobileStepperProp);
  const ModalProp = __exports.ModalProp = class ModalProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.ModalProp",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["BackdropComponent", Any], ["BackdropProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["DisableAutoFocus", "boolean"], ["DisableBackdropClick", "boolean"], ["DisableEnforceFocus", "boolean"], ["DisableEscapeKeyDown", "boolean"], ["DisableRestoreFocus", "boolean"], ["HideBackdrop", "boolean"], ["Manager", Any], ["OnBackdropClick", _Function([Any, Unit])], ["OnEscapeKeyDown", _Function([Any, Unit])], ["OnClose", _Function([Tuple([Any, "string"]), Unit])]]
      };
    }

  };
  setType("Fable.MaterialUI.Props.ModalProp", ModalProp);
  const PaperProp = __exports.PaperProp = class PaperProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.PaperProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Square", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.PaperProp", PaperProp);
  const PopoverProp = __exports.PopoverProp = class PopoverProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.PopoverProp",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Action", _Function([Interface("Fable.MaterialUI.Props.IPopoverActions"), Unit])], ["AnchorOrigin", Any], ["AnchorPosition", Any], ["AnchorReference", "string"], ["GetContentAnchorEl", _Function([Any, Any])], ["MarginThreshold", "number"], ["TransformOrigin", Any], ["TransitionDuration", Any]]
      };
    }

  };
  setType("Fable.MaterialUI.Props.PopoverProp", PopoverProp);
  const PopperProp = __exports.PopperProp = class PopperProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.PopperProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Modifies", Any], ["PopperOptions", Any], ["Transition", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.PopperProp", PopperProp);
  const RadioGroupProp = __exports.RadioGroupProp = class RadioGroupProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.RadioGroupProp",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["OnChange", _Function([Tuple([Any, "string"]), Unit])]]
      };
    }

  };
  setType("Fable.MaterialUI.Props.RadioGroupProp", RadioGroupProp);
  const RootRefProp = __exports.RootRefProp = class RootRefProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.RootRefProp",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["RootRef", Any]]
      };
    }

  };
  setType("Fable.MaterialUI.Props.RootRefProp", RootRefProp);
  const SelectProp = __exports.SelectProp = class SelectProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.SelectProp",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["AutoWidth", "boolean"], ["DisplayEmpty", "boolean"], ["IconComponent", Any], ["Input", Any], ["MenuProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["Native", "boolean"], ["OnChange", _Function([Tuple([Any, Any]), Unit])], ["RenderValue", _Function([Any, Any])], ["SelectDisplayProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })]]
      };
    }

  };
  setType("Fable.MaterialUI.Props.SelectProp", SelectProp);
  const SlideProp = __exports.SlideProp = class SlideProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.SlideProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Direction", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.SlideProp", SlideProp);
  const SnackbarProp = __exports.SnackbarProp = class SnackbarProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.SnackbarProp",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Action", Interface("Fable.Import.React.ReactElement")], ["AnchorOrigin", Any], ["AutoHideDuration", "number"], ["ContentProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["DisableWidnowBlurListener", "boolean"], ["Message", Interface("Fable.Import.React.ReactElement")], ["OnClose", _Function([Tuple([Any, "string"]), Unit])], ["ResumeHideDuration", "number"]]
      };
    }

  };
  setType("Fable.MaterialUI.Props.SnackbarProp", SnackbarProp);
  const StepProp = __exports.StepProp = class StepProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.StepProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Completed", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.StepProp", StepProp);
  const StepContentProp = __exports.StepContentProp = class StepContentProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.StepContentProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["TransitionDuration", Any]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.StepContentProp", StepContentProp);
  const StepLabelProp = __exports.StepLabelProp = class StepLabelProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.StepLabelProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["StepIconProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.StepLabelProp", StepLabelProp);
  const StepperProp = __exports.StepperProp = class StepperProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.StepperProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["ActiveStep", "number"], ["AlternativeLabel", "boolean"], ["Connector", Interface("Fable.Import.React.ReactElement")], ["NonLinear", "boolean"], ["Orientation", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.StepperProp", StepperProp);
  const SvgIconProp = __exports.SvgIconProp = class SvgIconProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.SvgIconProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["NativeColor", "string"], ["TitleAccess", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.SvgIconProp", SvgIconProp);
  const SwipeableDrawerProp = __exports.SwipeableDrawerProp = class SwipeableDrawerProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.SwipeableDrawerProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["DisableBackdropTransition", "boolean"], ["DisableDiscovery", "boolean"], ["DisableSwipeToOpen", "boolean"], ["SwipeAreaWidth", "number"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.SwipeableDrawerProp", SwipeableDrawerProp);
  const TabsProp = __exports.TabsProp = class TabsProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.TabsProp",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Action", _Function([Interface("Fable.MaterialUI.Props.ITabsActions"), Unit])], ["Centered", "boolean"], ["IndicatorColor", "string"], ["OnChange", _Function([Tuple([Any, "number"]), Unit])], ["Scrollabel", "boolean"], ["ScrollButtonComponent", Any], ["ScrollButtons", "string"], ["TabIndicatorProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["TextColor", "string"]]
      };
    }

  };
  setType("Fable.MaterialUI.Props.TabsProp", TabsProp);
  const TableCellProp = __exports.TableCellProp = class TableCellProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.TableCellProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Numeric", "boolean"], ["Padding", "string"], ["Scope", "string"], ["SortDirection", "string"], ["Variant", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.TableCellProp", TableCellProp);
  const TablePaginationProp = __exports.TablePaginationProp = class TablePaginationProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.TablePaginationProp",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["ActionsComponent", Any], ["BackIconButtonProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["Count", "number"], ["LabelDisplayedRows", _Function([Interface("Fable.MaterialUI.Props.ILabelDisplayedRowsArgs"), Any])], ["LabelRowsPerPage", Any], ["NextIconButtonPropss", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["OnChangePage", _Function([Tuple([Any, "number"]), Unit])], ["OnChangeRowsPerPage", _Function([Any, Unit])], ["Page", "number"], ["RowsPerPage", "number"], ["RowsPerPageOptions", makeGeneric(List, {
          T: "number"
        })]]
      };
    }

  };
  setType("Fable.MaterialUI.Props.TablePaginationProp", TablePaginationProp);
  const TableRowProp = __exports.TableRowProp = class TableRowProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.TableRowProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Hover", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.TableRowProp", TableRowProp);
  const TableSortLabelProp = __exports.TableSortLabelProp = class TableSortLabelProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.TableSortLabelProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Direction", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.TableSortLabelProp", TableSortLabelProp);
  const TextFieldProp = __exports.TextFieldProp = class TextFieldProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.TextFieldProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["FormHelperTextProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["HelperText", Any], ["InputLabelProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["InputProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["Select", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.TextFieldProp", TextFieldProp);
  const ToolbarProp = __exports.ToolbarProp = class ToolbarProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.ToolbarProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Variant", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.ToolbarProp", ToolbarProp);
  const TooltipProp = __exports.TooltipProp = class TooltipProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.TooltipProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["DisableFocusListener", "boolean"], ["DisableHoverListener", "boolean"], ["DisableTouchListener", "boolean"], ["EnterDelay", "number"], ["EnterTouchDelay", "number"], ["LeaveDelay", "number"], ["LeaveTouchDelay", "number"], ["PopperProps", makeGeneric(List, {
          T: Interface("Fable.Helpers.React.Props.IHTMLProp")
        })], ["Title", Any]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.TooltipProp", TooltipProp);
  const TouchRippleProp = __exports.TouchRippleProp = class TouchRippleProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.TouchRippleProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Center", "boolean"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.TouchRippleProp", TouchRippleProp);
  const TypographyProp = __exports.TypographyProp = class TypographyProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.TypographyProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Align", "string"], ["Color", "string"], ["GutterBottom", "boolean"], ["HeadlineMapping", Any], ["NoWrap", "boolean"], ["Paragraph", "boolean"], ["Variant", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.TypographyProp", TypographyProp);
  const PaletteCommonProp = __exports.PaletteCommonProp = class PaletteCommonProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.PaletteCommonProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable"],
        cases: [["Black", "string"], ["White", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.PaletteCommonProp", PaletteCommonProp);
  const PaletteIntentionProp = __exports.PaletteIntentionProp = class PaletteIntentionProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.PaletteIntentionProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable"],
        cases: [["Light", "string"], ["Main", "string"], ["Dark", "string"], ["ContrastText", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.PaletteIntentionProp", PaletteIntentionProp);
  const ColorType = __exports.ColorType = class ColorType {
    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.ColorType",
        properties: {
          ["100"]: "string",
          ["200"]: "string",
          ["300"]: "string",
          ["400"]: "string",
          ["50"]: "string",
          ["500"]: "string",
          ["600"]: "string",
          ["700"]: "string",
          ["800"]: "string",
          ["900"]: "string",
          A100: "string",
          A200: "string",
          A400: "string",
          A700: "string"
        }
      };
    }

    constructor() {}

    static get ["50"]() {
      return "50";
    }

    static get ["100"]() {
      return "100";
    }

    static get ["200"]() {
      return "200";
    }

    static get ["300"]() {
      return "300";
    }

    static get ["400"]() {
      return "400";
    }

    static get ["500"]() {
      return "500";
    }

    static get ["600"]() {
      return "600";
    }

    static get ["700"]() {
      return "700";
    }

    static get ["800"]() {
      return "800";
    }

    static get ["900"]() {
      return "900";
    }

    static get A100() {
      return "A100";
    }

    static get A200() {
      return "A200";
    }

    static get A400() {
      return "A400";
    }

    static get A700() {
      return "A700";
    }

  };
  setType("Fable.MaterialUI.Props.ColorType", ColorType);
  const PaletteTextProp = __exports.PaletteTextProp = class PaletteTextProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.PaletteTextProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable"],
        cases: [["Primary", "string"], ["Secondary", "string"], ["Disabled", "string"], ["Hint", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.PaletteTextProp", PaletteTextProp);
  const PaletteBackgroundProp = __exports.PaletteBackgroundProp = class PaletteBackgroundProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.PaletteBackgroundProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable"],
        cases: [["Paper", "string"], ["Default", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.PaletteBackgroundProp", PaletteBackgroundProp);
  const PaletteActionProp = __exports.PaletteActionProp = class PaletteActionProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.PaletteActionProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable"],
        cases: [["Active", "string"], ["Hover", "string"], ["HoverOpacity", "number"], ["Selected", "string"], ["Disabled", "string"], ["DisabledBackground", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.PaletteActionProp", PaletteActionProp);
  const PaletteProp = __exports.PaletteProp = class PaletteProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.PaletteProp",
        interfaces: ["FSharpUnion", "System.IEquatable"],
        cases: [["Common", makeGeneric(List, {
          T: PaletteCommonProp
        })], ["Type", "string"], ["Primary", makeGeneric(List, {
          T: PaletteIntentionProp
        })], ["Secondary", makeGeneric(List, {
          T: PaletteIntentionProp
        })], ["Error", makeGeneric(List, {
          T: PaletteIntentionProp
        })], ["Grey", makeGeneric(List, {
          T: Tuple(["string", Any])
        })], ["ContrastThreshold", "number"], ["TonalOffset", "number"], ["Text", makeGeneric(List, {
          T: PaletteTextProp
        })], ["Divider", "string"], ["Background", makeGeneric(List, {
          T: PaletteBackgroundProp
        })], ["Action", makeGeneric(List, {
          T: PaletteActionProp
        })]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.PaletteProp", PaletteProp);
  const TextStyleProp = __exports.TextStyleProp = class TextStyleProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.TextStyleProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable"],
        cases: [["FontFamily", "string"], ["Color", "string"], ["FontSize", "string"], ["FontWeight", "string"], ["LetterSpacing", "string"], ["LineHeight", "string"], ["TextTransform", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.TextStyleProp", TextStyleProp);
  const ThemeTypographyProp = __exports.ThemeTypographyProp = class ThemeTypographyProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.ThemeTypographyProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable"],
        cases: [["FontFamily", "string"], ["HtmlFontSize", "string"], ["FontSize", "string"], ["FontWeightLight", "number"], ["FontWeightRegular", "number"], ["FontWeightMedium", "number"], ["Display4", makeGeneric(List, {
          T: TextStyleProp
        })], ["Display3", makeGeneric(List, {
          T: TextStyleProp
        })], ["Display2", makeGeneric(List, {
          T: TextStyleProp
        })], ["Display1", makeGeneric(List, {
          T: TextStyleProp
        })], ["Headline", makeGeneric(List, {
          T: TextStyleProp
        })], ["Title", makeGeneric(List, {
          T: TextStyleProp
        })], ["Subheading", makeGeneric(List, {
          T: TextStyleProp
        })], ["Body2", makeGeneric(List, {
          T: TextStyleProp
        })], ["Body1", makeGeneric(List, {
          T: TextStyleProp
        })], ["Caption", makeGeneric(List, {
          T: TextStyleProp
        })], ["Button", makeGeneric(List, {
          T: TextStyleProp
        })]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.ThemeTypographyProp", ThemeTypographyProp);
  const ShapeProp = __exports.ShapeProp = class ShapeProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.ShapeProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable"],
        cases: [["BorderRadius", "number"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.ShapeProp", ShapeProp);
  const SpacingProp = __exports.SpacingProp = class SpacingProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.SpacingProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable"],
        cases: [["Unit", "number"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.SpacingProp", SpacingProp);
  const ZIndexProp = __exports.ZIndexProp = class ZIndexProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.ZIndexProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable"],
        cases: [["AppBar", "number"], ["Drawer", "number"], ["MobileStepper", "number"], ["Modal", "number"], ["Snackbar", "number"], ["Tooltip", "number"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.ZIndexProp", ZIndexProp);
  const OverridesProp = __exports.OverridesProp = class OverridesProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.OverridesProp",
        interfaces: ["FSharpUnion", "System.IEquatable"],
        cases: [["MuiAppBar", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiAvatar", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiBackdrop", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiBadge", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiBottomNavigation", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiBottomNavigationAction", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiButton", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiButtonBase", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiCard", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiCardActions", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiCardContent", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiCardHeader", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiCardMedia", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiCheckbox", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiChip", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiCircularProgress", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiCollapse", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiCssBaseline", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiDialog", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiDialogActions", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiDialogContent", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiDialogContentText", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiDialogTitle", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiDivider", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiDrawer", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiExpansionPanel", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiExpansionPanelActions", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiExpansionPanelDetails", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiExpansionPanelSummary", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiFormControl", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiFormControlLabel", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiFormGroup", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiFormHelperText", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiFormLabel", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiGrid", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiGridList", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiGridListTile", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiGridListTileBar", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiIcon", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiIconButton", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiInput", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiInputAdornment", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiInputLabel", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiLinearProgress", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiList", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiListItem", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiListItemAvatar", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiListItemIcon", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiListItemSecondaryAction", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiListItemText", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiListSubheader", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiMenu", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiMenuItem", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiMobileStepper", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiModal", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiNativeSelect", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiPaper", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiPopover", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiRadio", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiSelect", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiSnackbar", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiSnackbarContent", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiStep", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiStepButton", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiStepConnector", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiStepContent", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiStepIcon", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiStepLabel", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiStepper", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiSvgIcon", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiSwitch", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiTab", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiTable", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiTableCell", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiTableFooter", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiTablePagination", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiTableRow", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiTableSortLabel", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiTabs", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiToolbar", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiTooltip", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiTouchRipple", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })], ["MuiTypography", makeGeneric(List, {
          T: Interface("Fable.MaterialUI.Themes.IStyles")
        })]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.OverridesProp", OverridesProp);
  const ThemeProp = __exports.ThemeProp = class ThemeProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.ThemeProp",
        interfaces: ["FSharpUnion", "System.IEquatable"],
        cases: [["Direction", "string"], ["Palette", makeGeneric(List, {
          T: PaletteProp
        })], ["Shadows", makeGeneric(List, {
          T: "string"
        })], ["Shape", makeGeneric(List, {
          T: ShapeProp
        })], ["Spacing", makeGeneric(List, {
          T: SpacingProp
        })], ["Typography", makeGeneric(List, {
          T: ThemeTypographyProp
        })], ["ZIndex", makeGeneric(List, {
          T: ZIndexProp
        })], ["Overrides", makeGeneric(List, {
          T: OverridesProp
        })]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.MaterialUI.Props.ThemeProp", ThemeProp);
  const MuiThemeProviderProp = __exports.MuiThemeProviderProp = class MuiThemeProviderProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.MuiThemeProviderProp",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Theme", Any], ["DisableStylesGeneration", "boolean"]]
      };
    }

  };
  setType("Fable.MaterialUI.Props.MuiThemeProviderProp", MuiThemeProviderProp);
  const WithWidthOption = __exports.WithWidthOption = class WithWidthOption {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.MaterialUI.Props.WithWidthOption",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable"],
        cases: [["WithTheme", "boolean"], ["NoSSR", "boolean"], ["InitialWidth", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.MaterialUI.Props.WithWidthOption", WithWidthOption);
  return __exports;
}({});