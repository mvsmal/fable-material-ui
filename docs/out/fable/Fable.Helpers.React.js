import { setType } from "../fable-core/Symbol";
import _Symbol from "../fable-core/Symbol";
import { extendInfo, Any, Unit, Interface, Function as _Function, compareUnions, equals } from "../fable-core/Util";
import { Component, createElement as createElement_1 } from "react";
import { fold } from "../fable-core/Seq";
export const Props = function (__exports) {
  const FragmentProp = __exports.FragmentProp = class FragmentProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.Helpers.React.Props.FragmentProp",
        interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable", "Fable.Helpers.React.Props.IFragmentProp"],
        cases: [["Key", "string"]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

    CompareTo(other) {
      return compareUnions(this, other) | 0;
    }

  };
  setType("Fable.Helpers.React.Props.FragmentProp", FragmentProp);
  const Prop = __exports.Prop = class Prop {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.Helpers.React.Props.Prop",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["Key", "string"], ["Ref", _Function([Interface("Fable.Import.Browser.Element"), Unit])]]
      };
    }

  };
  setType("Fable.Helpers.React.Props.Prop", Prop);
  const DOMAttr = __exports.DOMAttr = class DOMAttr {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.Helpers.React.Props.DOMAttr",
        interfaces: ["FSharpUnion", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["DangerouslySetInnerHTML", Any], ["OnCut", _Function([Interface("Fable.Import.React.ClipboardEvent"), Unit])], ["OnPaste", _Function([Interface("Fable.Import.React.ClipboardEvent"), Unit])], ["OnCompositionEnd", _Function([Interface("Fable.Import.React.CompositionEvent"), Unit])], ["OnCompositionStart", _Function([Interface("Fable.Import.React.CompositionEvent"), Unit])], ["OnCopy", _Function([Interface("Fable.Import.React.ClipboardEvent"), Unit])], ["OnCompositionUpdate", _Function([Interface("Fable.Import.React.CompositionEvent"), Unit])], ["OnFocus", _Function([Interface("Fable.Import.React.FocusEvent"), Unit])], ["OnBlur", _Function([Interface("Fable.Import.React.FocusEvent"), Unit])], ["OnChange", _Function([Interface("Fable.Import.React.FormEvent"), Unit])], ["OnInput", _Function([Interface("Fable.Import.React.FormEvent"), Unit])], ["OnSubmit", _Function([Interface("Fable.Import.React.FormEvent"), Unit])], ["OnReset", _Function([Interface("Fable.Import.React.FormEvent"), Unit])], ["OnLoad", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnError", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnKeyDown", _Function([Interface("Fable.Import.React.KeyboardEvent"), Unit])], ["OnKeyPress", _Function([Interface("Fable.Import.React.KeyboardEvent"), Unit])], ["OnKeyUp", _Function([Interface("Fable.Import.React.KeyboardEvent"), Unit])], ["OnAbort", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnCanPlay", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnCanPlayThrough", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnDurationChange", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnEmptied", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnEncrypted", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnEnded", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnLoadedData", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnLoadedMetadata", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnLoadStart", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnPause", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnPlay", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnPlaying", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnProgress", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnRateChange", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnSeeked", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnSeeking", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnStalled", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnSuspend", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnTimeUpdate", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnVolumeChange", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnWaiting", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnClick", _Function([Interface("Fable.Import.React.MouseEvent"), Unit])], ["OnContextMenu", _Function([Interface("Fable.Import.React.MouseEvent"), Unit])], ["OnDoubleClick", _Function([Interface("Fable.Import.React.MouseEvent"), Unit])], ["OnDrag", _Function([Interface("Fable.Import.React.DragEvent"), Unit])], ["OnDragEnd", _Function([Interface("Fable.Import.React.DragEvent"), Unit])], ["OnDragEnter", _Function([Interface("Fable.Import.React.DragEvent"), Unit])], ["OnDragExit", _Function([Interface("Fable.Import.React.DragEvent"), Unit])], ["OnDragLeave", _Function([Interface("Fable.Import.React.DragEvent"), Unit])], ["OnDragOver", _Function([Interface("Fable.Import.React.DragEvent"), Unit])], ["OnDragStart", _Function([Interface("Fable.Import.React.DragEvent"), Unit])], ["OnDrop", _Function([Interface("Fable.Import.React.DragEvent"), Unit])], ["OnMouseDown", _Function([Interface("Fable.Import.React.MouseEvent"), Unit])], ["OnMouseEnter", _Function([Interface("Fable.Import.React.MouseEvent"), Unit])], ["OnMouseLeave", _Function([Interface("Fable.Import.React.MouseEvent"), Unit])], ["OnMouseMove", _Function([Interface("Fable.Import.React.MouseEvent"), Unit])], ["OnMouseOut", _Function([Interface("Fable.Import.React.MouseEvent"), Unit])], ["OnMouseOver", _Function([Interface("Fable.Import.React.MouseEvent"), Unit])], ["OnMouseUp", _Function([Interface("Fable.Import.React.MouseEvent"), Unit])], ["OnSelect", _Function([Interface("Fable.Import.React.SyntheticEvent"), Unit])], ["OnTouchCancel", _Function([Interface("Fable.Import.React.TouchEvent"), Unit])], ["OnTouchEnd", _Function([Interface("Fable.Import.React.TouchEvent"), Unit])], ["OnTouchMove", _Function([Interface("Fable.Import.React.TouchEvent"), Unit])], ["OnTouchStart", _Function([Interface("Fable.Import.React.TouchEvent"), Unit])], ["OnScroll", _Function([Interface("Fable.Import.React.UIEvent"), Unit])], ["OnWheel", _Function([Interface("Fable.Import.React.WheelEvent"), Unit])], ["OnAnimationStart", _Function([Interface("Fable.Import.React.AnimationEvent"), Unit])], ["OnAnimationEnd", _Function([Interface("Fable.Import.React.AnimationEvent"), Unit])], ["OnAnimationIteration", _Function([Interface("Fable.Import.React.AnimationEvent"), Unit])], ["OnTransitionEnd", _Function([Interface("Fable.Import.React.TransitionEvent"), Unit])]]
      };
    }

  };
  setType("Fable.Helpers.React.Props.DOMAttr", DOMAttr);
  const SVGAttr = __exports.SVGAttr = class SVGAttr {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.Helpers.React.Props.SVGAttr",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IProp"],
        cases: [["ClipPath", "string"], ["Cx", Any], ["Cy", Any], ["D", "string"], ["Dx", Any], ["Dy", Any], ["Fill", "string"], ["FillOpacity", Any], ["FontFamily", "string"], ["FontSize", Any], ["Fx", Any], ["Fy", Any], ["GradientTransform", "string"], ["GradientUnits", "string"], ["Height", Any], ["MarkerEnd", "string"], ["MarkerMid", "string"], ["MarkerStart", "string"], ["Offset", Any], ["Opacity", Any], ["PatternContentUnits", "string"], ["PatternUnits", "string"], ["Points", "string"], ["PreserveAspectRatio", "string"], ["R", Any], ["Rx", Any], ["Ry", Any], ["SpreadMethod", "string"], ["StopColor", "string"], ["StopOpacity", Any], ["Stroke", "string"], ["StrokeDasharray", "string"], ["StrokeLinecap", "string"], ["StrokeMiterlimit", "string"], ["StrokeOpacity", Any], ["StrokeWidth", Any], ["TextAnchor", "string"], ["Transform", "string"], ["Version", "string"], ["ViewBox", "string"], ["Width", Any], ["X1", Any], ["X2", Any], ["X", Any], ["XlinkActuate", "string"], ["XlinkArcrole", "string"], ["XlinkHref", "string"], ["XlinkRole", "string"], ["XlinkShow", "string"], ["XlinkTitle", "string"], ["XlinkType", "string"], ["XmlBase", "string"], ["XmlLang", "string"], ["XmlSpace", "string"], ["Y1", Any], ["Y2", Any], ["Y", Any], ["Custom", "string", Any]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.Helpers.React.Props.SVGAttr", SVGAttr);
  const HTMLAttr = __exports.HTMLAttr = class HTMLAttr {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.Helpers.React.Props.HTMLAttr",
        interfaces: ["FSharpUnion", "System.IEquatable", "Fable.Helpers.React.Props.IHTMLProp"],
        cases: [["DefaultChecked", "boolean"], ["DefaultValue", "string"], ["Accept", "string"], ["AcceptCharset", "string"], ["AccessKey", "string"], ["Action", "string"], ["AllowFullScreen", "boolean"], ["AllowTransparency", "boolean"], ["Alt", "string"], ["aria-haspopup", "boolean"], ["aria-expanded", "boolean"], ["Async", "boolean"], ["AutoComplete", "string"], ["AutoFocus", "boolean"], ["AutoPlay", "boolean"], ["Capture", "boolean"], ["CellPadding", Any], ["CellSpacing", Any], ["CharSet", "string"], ["Challenge", "string"], ["Checked", "boolean"], ["ClassID", "string"], ["ClassName", "string"], ["className", "string"], ["Cols", "number"], ["ColSpan", "number"], ["Content", "string"], ["ContentEditable", "boolean"], ["ContextMenu", "string"], ["Controls", "boolean"], ["Coords", "string"], ["CrossOrigin", "string"], ["data-toggle", "string"], ["DateTime", "string"], ["Default", "boolean"], ["Defer", "boolean"], ["Dir", "string"], ["Disabled", "boolean"], ["Download", Any], ["Draggable", "boolean"], ["EncType", "string"], ["Form", "string"], ["FormAction", "string"], ["FormEncType", "string"], ["FormMethod", "string"], ["FormNoValidate", "boolean"], ["FormTarget", "string"], ["FrameBorder", Any], ["Headers", "string"], ["Height", Any], ["Hidden", "boolean"], ["High", "number"], ["Href", "string"], ["HrefLang", "string"], ["HtmlFor", "string"], ["HttpEquiv", "string"], ["Icon", "string"], ["Id", "string"], ["InputMode", "string"], ["Integrity", "string"], ["Is", "string"], ["KeyParams", "string"], ["KeyType", "string"], ["Kind", "string"], ["Label", "string"], ["Lang", "string"], ["List", "string"], ["Loop", "boolean"], ["Low", "number"], ["Manifest", "string"], ["MarginHeight", "number"], ["MarginWidth", "number"], ["Max", Any], ["MaxLength", "number"], ["Media", "string"], ["MediaGroup", "string"], ["Method", "string"], ["Min", Any], ["MinLength", "number"], ["Multiple", "boolean"], ["Muted", "boolean"], ["Name", "string"], ["NoValidate", "boolean"], ["Open", "boolean"], ["Optimum", "number"], ["Pattern", "string"], ["Placeholder", "string"], ["Poster", "string"], ["Preload", "string"], ["RadioGroup", "string"], ["ReadOnly", "boolean"], ["Rel", "string"], ["Required", "boolean"], ["Role", "string"], ["Rows", "number"], ["RowSpan", "number"], ["Sandbox", "string"], ["Scope", "string"], ["Scoped", "boolean"], ["Scrolling", "string"], ["Seamless", "boolean"], ["Selected", "boolean"], ["Shape", "string"], ["Size", "number"], ["Sizes", "string"], ["Span", "number"], ["SpellCheck", "boolean"], ["Src", "string"], ["SrcDoc", "string"], ["SrcLang", "string"], ["SrcSet", "string"], ["Start", "number"], ["Step", Any], ["Summary", "string"], ["TabIndex", "number"], ["Target", "string"], ["Title", "string"], ["Type", "string"], ["UseMap", "string"], ["Value", "string"], ["Width", Any], ["Wmode", "string"], ["Wrap", "string"], ["About", "string"], ["Datatype", "string"], ["Inlist", Any], ["Prefix", "string"], ["Property", "string"], ["Resource", "string"], ["Typeof", "string"], ["Vocab", "string"], ["AutoCapitalize", "string"], ["AutoCorrect", "string"], ["AutoSave", "string"], ["ItemProp", "string"], ["ItemScope", "boolean"], ["ItemType", "string"], ["ItemID", "string"], ["ItemRef", "string"], ["Results", "number"], ["Security", "string"], ["Unselectable", "boolean"], ["Custom", "string", Any]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.Helpers.React.Props.HTMLAttr", HTMLAttr);
  const CSSProp = __exports.CSSProp = class CSSProp {
    constructor(tag, data) {
      this.tag = tag | 0;
      this.data = data;
    }

    [_Symbol.reflection]() {
      return {
        type: "Fable.Helpers.React.Props.CSSProp",
        interfaces: ["FSharpUnion", "System.IEquatable"],
        cases: [["AlignContent", Any], ["AlignItems", Any], ["AlignSelf", Any], ["AlignmentAdjust", Any], ["AlignmentBaseline", Any], ["All", Any], ["Animation", Any], ["AnimationDelay", Any], ["AnimationDirection", Any], ["AnimationDuration", Any], ["AnimationFillMode", Any], ["AnimationIterationCount", Any], ["AnimationName", Any], ["AnimationPlayState", Any], ["AnimationTimingFunction", Any], ["Appearance", Any], ["BackfaceVisibility", Any], ["Background", Any], ["BackgroundAttachment", Any], ["BackgroundBlendMode", Any], ["BackgroundClip", Any], ["BackgroundColor", Any], ["BackgroundComposite", Any], ["BackgroundImage", Any], ["BackgroundOrigin", Any], ["BackgroundPosition", Any], ["BackgroundPositionX", Any], ["BackgroundPositionY", Any], ["BackgroundRepeat", Any], ["BackgroundSize", Any], ["BaselineShift", Any], ["Behavior", Any], ["BlockSize", Any], ["Border", Any], ["BorderBlockEnd", Any], ["BorderBlockEndColor", Any], ["BorderBlockEndStyle", Any], ["BorderBlockEndWidth", Any], ["BorderBlockStart", Any], ["BorderBlockStartColor", Any], ["BorderBlockStartStyle", Any], ["BorderBlockStartWidth", Any], ["BorderBottom", Any], ["BorderBottomColor", Any], ["BorderBottomLeftRadius", Any], ["BorderBottomRightRadius", Any], ["BorderBottomStyle", Any], ["BorderBottomWidth", Any], ["BorderCollapse", Any], ["BorderColor", Any], ["BorderCornerShape", Any], ["BorderImage", Any], ["BorderImageOutset", Any], ["BorderImageRepeat", Any], ["BorderImageSlice", Any], ["BorderImageSource", Any], ["BorderImageWidth", Any], ["BorderInlineEnd", Any], ["BorderInlineEndColor", Any], ["BorderInlineEndStyle", Any], ["BorderInlineEndWidth", Any], ["BorderInlineStart", Any], ["BorderInlineStartColor", Any], ["BorderInlineStartStyle", Any], ["BorderInlineStartWidth", Any], ["BorderLeft", Any], ["BorderLeftColor", Any], ["BorderLeftStyle", Any], ["BorderLeftWidth", Any], ["BorderRadius", Any], ["BorderRight", Any], ["BorderRightColor", Any], ["BorderRightStyle", Any], ["BorderRightWidth", Any], ["BorderSpacing", Any], ["BorderStyle", Any], ["BorderTop", Any], ["BorderTopColor", Any], ["BorderTopLeftRadius", Any], ["BorderTopRightRadius", Any], ["BorderTopStyle", Any], ["BorderTopWidth", Any], ["BorderWidth", Any], ["Bottom", Any], ["BoxAlign", Any], ["BoxDecorationBreak", Any], ["BoxDirection", Any], ["BoxFlex", Any], ["BoxFlexGroup", Any], ["BoxLineProgression", Any], ["BoxLines", Any], ["BoxOrdinalGroup", Any], ["BoxShadow", Any], ["BoxSizing", Any], ["BreakAfter", Any], ["BreakBefore", Any], ["BreakInside", Any], ["CaptionSide", Any], ["CaretColor", Any], ["Clear", Any], ["Clip", Any], ["ClipPath", Any], ["ClipRule", Any], ["Color", Any], ["ColorInterpolation", Any], ["ColorInterpolationFilters", Any], ["ColorProfile", Any], ["ColorRendering", Any], ["ColumnCount", Any], ["ColumnFill", Any], ["ColumnGap", Any], ["ColumnRule", Any], ["ColumnRuleColor", Any], ["ColumnRuleStyle", Any], ["ColumnRuleWidth", Any], ["ColumnSpan", Any], ["ColumnWidth", Any], ["Columns", Any], ["Content", Any], ["CounterIncrement", Any], ["CounterReset", Any], ["Cue", Any], ["CueAfter", Any], ["Cursor", Any], ["Direction", Any], ["Display", Any], ["DominantBaseline", Any], ["EmptyCells", Any], ["EnableBackground", Any], ["Fill", Any], ["FillOpacity", Any], ["FillRule", Any], ["Filter", Any], ["Flex", Any], ["FlexAlign", Any], ["FlexBasis", Any], ["FlexDirection", Any], ["FlexFlow", Any], ["FlexGrow", Any], ["FlexItemAlign", Any], ["FlexLinePack", Any], ["FlexOrder", Any], ["FlexShrink", Any], ["FlexWrap", Any], ["Float", Any], ["FloodColor", Any], ["FloodOpacity", Any], ["FlowFrom", Any], ["Font", Any], ["FontFamily", Any], ["FontFeatureSettings", Any], ["FontKerning", Any], ["FontLanguageOverride", Any], ["FontSize", Any], ["FontSizeAdjust", Any], ["FontStretch", Any], ["FontStyle", Any], ["FontSynthesis", Any], ["FontVariant", Any], ["FontVariantAlternates", Any], ["FontVariantCaps", Any], ["FontVariantEastAsian", Any], ["FontVariantLigatures", Any], ["FontVariantNumeric", Any], ["FontVariantPosition", Any], ["FontWeight", Any], ["GlyphOrientationHorizontal", Any], ["GlyphOrientationVertical", Any], ["Grid", Any], ["GridArea", Any], ["GridAutoColumns", Any], ["GridAutoFlow", Any], ["GridAutoRows", Any], ["GridColumn", Any], ["GridColumnEnd", Any], ["GridColumnGap", Any], ["GridColumnStart", Any], ["GridGap", Any], ["GridRow", Any], ["GridRowEnd", Any], ["GridRowGap", Any], ["GridRowPosition", Any], ["GridRowSpan", Any], ["GridRowStart", Any], ["GridTemplate", Any], ["GridTemplateAreas", Any], ["GridTemplateColumns", Any], ["GridTemplateRows", Any], ["HangingPunctuation", Any], ["Height", Any], ["HyphenateLimitChars", Any], ["HyphenateLimitLines", Any], ["HyphenateLimitZone", Any], ["Hyphens", Any], ["ImageOrientation", Any], ["ImageRendering", Any], ["ImageResolution", Any], ["ImeMode", Any], ["InlineSize", Any], ["Isolation", Any], ["JustifyContent", Any], ["Kerning", Any], ["LayoutGrid", Any], ["LayoutGridChar", Any], ["LayoutGridLine", Any], ["LayoutGridMode", Any], ["LayoutGridType", Any], ["Left", Any], ["LetterSpacing", Any], ["LightingColor", Any], ["LineBreak", Any], ["LineClamp", Any], ["LineHeight", Any], ["ListStyle", Any], ["ListStyleImage", Any], ["ListStylePosition", Any], ["ListStyleType", Any], ["Margin", Any], ["MarginBlockEnd", Any], ["MarginBlockStart", Any], ["MarginBottom", Any], ["MarginInlineEnd", Any], ["MarginInlineStart", Any], ["MarginLeft", Any], ["MarginRight", Any], ["MarginTop", Any], ["MarkerEnd", Any], ["MarkerMid", Any], ["MarkerStart", Any], ["MarqueeDirection", Any], ["MarqueeStyle", Any], ["Mask", Any], ["MaskBorder", Any], ["MaskBorderRepeat", Any], ["MaskBorderSlice", Any], ["MaskBorderSource", Any], ["MaskBorderWidth", Any], ["MaskClip", Any], ["MaskComposite", Any], ["MaskImage", Any], ["MaskMode", Any], ["MaskOrigin", Any], ["MaskPosition", Any], ["MaskRepeat", Any], ["MaskSize", Any], ["MaskType", Any], ["MaxFontSize", Any], ["MaxHeight", Any], ["MaxWidth", Any], ["MinBlockSize", Any], ["MinHeight", Any], ["MinInlineSize", Any], ["MinWidth", Any], ["MixBlendMode", Any], ["ObjectFit", Any], ["ObjectPosition", Any], ["OffsetBlockEnd", Any], ["OffsetBlockStart", Any], ["OffsetInlineEnd", Any], ["OffsetInlineStart", Any], ["Opacity", Any], ["Order", Any], ["Orphans", Any], ["Outline", Any], ["OutlineColor", Any], ["OutlineOffset", Any], ["OutlineStyle", Any], ["OutlineWidth", Any], ["Overflow", Any], ["OverflowStyle", Any], ["OverflowWrap", Any], ["OverflowX", Any], ["OverflowY", Any], ["Padding", Any], ["PaddingBlockEnd", Any], ["PaddingBlockStart", Any], ["PaddingBottom", Any], ["PaddingInlineEnd", Any], ["PaddingInlineStart", Any], ["PaddingLeft", Any], ["PaddingRight", Any], ["PaddingTop", Any], ["PageBreakAfter", Any], ["PageBreakBefore", Any], ["PageBreakInside", Any], ["Pause", Any], ["PauseAfter", Any], ["PauseBefore", Any], ["Perspective", Any], ["PerspectiveOrigin", Any], ["PointerEvents", Any], ["Position", Any], ["PunctuationTrim", Any], ["Quotes", Any], ["RegionFragment", Any], ["Resize", Any], ["RestAfter", Any], ["RestBefore", Any], ["Right", Any], ["RubyAlign", Any], ["RubyMerge", Any], ["RubyPosition", Any], ["ScrollBehavior", Any], ["ScrollSnapCoordinate", Any], ["ScrollSnapDestination", Any], ["ScrollSnapType", Any], ["ShapeImageThreshold", Any], ["ShapeInside", Any], ["ShapeMargin", Any], ["ShapeOutside", Any], ["ShapeRendering", Any], ["Speak", Any], ["SpeakAs", Any], ["StopColor", Any], ["StopOpacity", Any], ["Stroke", Any], ["StrokeDasharray", Any], ["StrokeDashoffset", Any], ["StrokeLinecap", Any], ["StrokeLinejoin", Any], ["StrokeMiterlimit", Any], ["StrokeOpacity", Any], ["StrokeWidth", Any], ["TabSize", Any], ["TableLayout", Any], ["TextAlign", Any], ["TextAlignLast", Any], ["TextAnchor", Any], ["TextCombineUpright", Any], ["TextDecoration", Any], ["TextDecorationColor", Any], ["TextDecorationLine", Any], ["TextDecorationLineThrough", Any], ["TextDecorationNone", Any], ["TextDecorationOverline", Any], ["TextDecorationSkip", Any], ["TextDecorationStyle", Any], ["TextDecorationUnderline", Any], ["TextEmphasis", Any], ["TextEmphasisColor", Any], ["TextEmphasisPosition", Any], ["TextEmphasisStyle", Any], ["TextHeight", Any], ["TextIndent", Any], ["TextJustify", Any], ["TextJustifyTrim", Any], ["TextKashidaSpace", Any], ["TextLineThrough", Any], ["TextLineThroughColor", Any], ["TextLineThroughMode", Any], ["TextLineThroughStyle", Any], ["TextLineThroughWidth", Any], ["TextOrientation", Any], ["TextOverflow", Any], ["TextOverline", Any], ["TextOverlineColor", Any], ["TextOverlineMode", Any], ["TextOverlineStyle", Any], ["TextOverlineWidth", Any], ["TextRendering", Any], ["TextScript", Any], ["TextShadow", Any], ["TextTransform", Any], ["TextUnderlinePosition", Any], ["TextUnderlineStyle", Any], ["Top", Any], ["TouchAction", Any], ["Transform", Any], ["TransformBox", Any], ["TransformOrigin", Any], ["TransformOriginZ", Any], ["TransformStyle", Any], ["Transition", Any], ["TransitionDelay", Any], ["TransitionDuration", Any], ["TransitionProperty", Any], ["TransitionTimingFunction", Any], ["UnicodeBidi", Any], ["UnicodeRange", Any], ["UserFocus", Any], ["UserInput", Any], ["VerticalAlign", Any], ["Visibility", Any], ["VoiceBalance", Any], ["VoiceDuration", Any], ["VoiceFamily", Any], ["VoicePitch", Any], ["VoiceRange", Any], ["VoiceRate", Any], ["VoiceStress", Any], ["VoiceVolume", Any], ["WhiteSpace", Any], ["WhiteSpaceTreatment", Any], ["Widows", Any], ["Width", Any], ["WillChange", Any], ["WordBreak", Any], ["WordSpacing", Any], ["WordWrap", Any], ["WrapFlow", Any], ["WrapMargin", Any], ["WrapOption", Any], ["WritingMode", Any], ["ZIndex", Any], ["Zoom", Any], ["Custom", "string", Any]]
      };
    }

    Equals(other) {
      return this === other || this.tag === other.tag && equals(this.data, other.data);
    }

  };
  setType("Fable.Helpers.React.Props.CSSProp", CSSProp);
  return __exports;
}({});
export const createElement = createElement_1;
export function classBaseList(std, classes) {
  var folder;
  return new Props.HTMLAttr(22, (folder = function (complete, _arg1) {
    return _arg1[1] ? complete + " " + _arg1[0] : complete;
  }, function (list) {
    return fold(folder, std, list);
  })(classes));
}
export function classList(classes) {
  return classBaseList("", classes);
}

function FormEvent_get_Value() {
  return this.target.value;
}

export { FormEvent_get_Value as FormEvent$2E$get_Value };
export class ReactiveCom extends Component {
  [_Symbol.reflection]() {
    return extendInfo(ReactiveCom, {
      type: "Fable.Helpers.React.ReactiveCom",
      interfaces: [],
      properties: {}
    });
  }

  constructor(initProps) {
    super(initProps);
    this.state = {
      value: initProps.init(initProps.props)
    };
  }

  render() {
    const model = {
      props: this.props.props,
      state: this.state.value,
      children: Array.prototype.concat(this.props.children || [])
    };
    return this.props.view(model, msg => {
      const newState = this.props.update(msg, this.state.value);
      this.setState({
        value: newState
      });
    });
  }

}
setType("Fable.Helpers.React.ReactiveCom", ReactiveCom);
export function reactiveCom(init, update, view, key, props, children) {
  return createElement_1(ReactiveCom, {
    key: key,
    props: props,
    update: update,
    view: view,
    init: init
  }, ...children);
}