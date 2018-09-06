import { map, ofArray } from "./fable-core/List";
import List from "./fable-core/List";
import { Page, NavItem } from "./Global";
import { Props as Props_1, Themes } from "./src/Fable.Helpers.MaterialUI.Props";
import { Props } from "./fable/Fable.Helpers.React";
import { classNames, toObj } from "./Utils";
import { Fragment, createElement, PureComponent } from "react";
import { setType } from "./fable-core/Symbol";
import _Symbol from "./fable-core/Symbol";
import { equals, createObj, extendInfo } from "./fable-core/Util";
import { List as List_1, ListItem, withStyles, Collapse, Button, materialEl } from "./src/Fable.Helpers.MaterialUI";
import CurriedLambda from "./fable-core/CurriedLambda";
import { getValue } from "./fable-core/Option";
import { Msg } from "./Types";
import { exists } from "./fable-core/Seq";
export const navItems = ofArray([(() => {
  var Href_1;
  var Href_2;
  const Href = null;
  return new NavItem("Getting Started", ofArray([(Href_1 = new Page(1), new NavItem("Installation", new List(), Href_1)), (Href_2 = new Page(2), new NavItem("Usage", new List(), Href_2))]), Href);
})(), (() => {
  var Href_4;
  var Href_5;
  var Href_6;
  const Href_3 = null;
  return new NavItem("Component demos", ofArray([(Href_4 = new Page(3), new NavItem("App Bar", new List(), Href_4)), (Href_5 = new Page(4), new NavItem("Autocomplete", new List(), Href_5)), (Href_6 = new Page(5), new NavItem("Avatars", new List(), Href_6))]), Href_3);
})()]);
export function subNavStyles(theme) {
  return ofArray([new Themes.Styles(33, ofArray([new Props.CSSProp(200, "flex-start"), new Props.CSSProp(362, "none"), new Props.CSSProp(394, "100%"), new Props.CSSProp(165, theme.typography.fontWeightMedium)])), ["collapse", toObj(ofArray([new Props.CSSProp(273, 0), new Props.CSSProp(217, 0)]))]]);
}
export class SubNav extends PureComponent {
  [_Symbol.reflection]() {
    return extendInfo(SubNav, {
      type: "App.Navigation.SubNav",
      interfaces: [],
      properties: {}
    });
  }

  constructor(p) {
    super(p);
    this.state = {
      opened: p.opened
    };
    const objectArg = this;

    this.toggle = arg00 => {
      objectArg.Toggle(arg00);
    };

    this["init@67-9"] = 1;
  }

  Toggle(_arg1) {
    this.setState((s, _arg1_1) => ({
      opened: !s.opened
    }));
  }

  render() {
    var $var4;
    var $var3;
    var $var2;
    var $var1;
    var $var6;
    var $var5;
    const $var7 = ofArray([($var4 = ofArray([($var2 = this.props.title, $var2)]), $var3 = ofArray([new Props.DOMAttr(40, this.toggle), ($var1 = this.props.style, ["style", createObj($var1, 1)]), new Props_1.MaterialProp(3, ofArray([new Themes.ClassNames(210, this.props.classes.button)]))]), materialEl(Button, $var3, $var4)), ($var6 = this.props.childItems, $var5 = ofArray([new Props_1.MaterialProp(16, this.state.opened), ["unmountOnExit", true], new Props_1.MaterialProp(5, "ul"), new Props.HTMLAttr(23, this.props.classes.collapse)]), materialEl(Collapse, $var5, $var6))]);
    return createElement(Fragment, {}, ...$var7);
  }

}
setType("App.Navigation.SubNav", SubNav);
export function subNav(props) {
  return createElement(SubNav, props);
}
export function subNavWithStyles() {
  var styles;
  var options;
  return CurriedLambda((styles = subNavStyles, options = new List(), function (fn) {
    return withStyles(styles, options, fn);
  }));
}
export function navItemStyles(theme) {
  return ofArray([["listItem", toObj(ofArray([new Props.CSSProp(125, "block"), new Props.CSSProp(281, 0), new Props.CSSProp(276, 0)]))], ["bold", toObj(ofArray([new Props.CSSProp(165, 500)]))], new Themes.Styles(33, ofArray([new Props.CSSProp(200, "flex-start"), new Props.CSSProp(362, "none"), new Props.CSSProp(394, "100%"), new Props.CSSProp(165, theme.typography.fontWeightRegular)])), new Themes.Styles(219, ofArray([new Props.CSSProp(103, theme.palette.primary.main), new Props.CSSProp(165, theme.typography.fontWeightMedium)]))]);
}
export function navItemWithStyles() {
  var styles;
  var options;
  return CurriedLambda((styles = navItemStyles, options = new List(), function (fn) {
    return withStyles(styles, options, fn);
  }));
}
export function navItem(title, depth, href, opened, model, childItems, dispatch, props) {
  console.log("navItem", title, href);
  const style = ofArray([new Props.CSSProp(279, 8 * (3 + 2 * depth))]);

  if (href == null) {
    const subNavProps = {};
    subNavProps.opened = opened;
    subNavProps.title = title;
    subNavProps.style = style;
    subNavProps.childItems = childItems;
    return materialEl(ListItem, ofArray([new Props_1.MaterialProp(8, true), new Props.HTMLAttr(23, props.classes.listItem)]), ofArray([createElement(subNavWithStyles()(subNav), subNavProps)]));
  } else {
    const buttonClasses = classNames(ofArray([[props.classes.selected, model.currentPage.Equals(getValue(href))]]));
    return materialEl(ListItem, ofArray([new Props_1.MaterialProp(8, true), new Props.HTMLAttr(23, props.classes.listItem)]), ofArray([materialEl(Button, ofArray([new Props_1.MaterialProp(10, true), new Props_1.MaterialProp(5, "a"), ["style", createObj(style, 1)], new Props.HTMLAttr(23, buttonClasses), new Props_1.MaterialProp(3, ofArray([new Themes.ClassNames(210, props.classes.button)])), new Props.DOMAttr(40, function (_arg1) {
      dispatch(new Msg(0, getValue(href)));
    })]), ofArray([title]))]));
  }
}
export function mapNavigation(model, dispatch, depth, item) {
  var depth_1;
  const opened = !(item.Children.tail == null) ? exists(function (i) {
    return equals(i.Href, model.currentPage);
  }, item.Children) : false;
  const childItems = map((depth_1 = depth + 1 | 0, function (item_1) {
    return mapNavigation(model, dispatch, depth_1, item_1);
  }), item.Children);
  return createElement(navItemWithStyles()(function (props) {
    return navItem(item.Title, depth, item.Href, opened, model, childItems, dispatch, props);
  }), {});
}
export function navigationMenu(model, dispatch) {
  return materialEl(List_1, ofArray([new Props_1.MaterialProp(5, "nav")]), map(function (item) {
    return mapNavigation(model, dispatch, 0, item);
  }, navItems));
}