import { ofArray } from "./fable-core/List";
import List from "./fable-core/List";
import { toObj } from "./Utils";
import { Props } from "./fable/Fable.Helpers.React";
import { Props as Props_1, Themes } from "./src/Fable.Helpers.MaterialUI.Props";
import CurriedLambda from "./fable-core/CurriedLambda";
import { Button, Typography, materialEl, withStyles } from "./src/Fable.Helpers.MaterialUI";
import { createElement } from "react";
import { Msg } from "./Types";
import { Page } from "./Global";
export function homeStyles(theme) {
  const xsBreakpoint = theme.breakpoints.only("xs");
  const smBreakpoint = theme.breakpoints.only("sm");
  return ofArray([["hero", toObj(ofArray([new Props.CSSProp(250, "80vh"), new Props.CSSProp(133, "0 0 auto"), new Props.CSSProp(125, "flex"), new Props.CSSProp(200, "center"), new Props.CSSProp(1, "center"), new Props.CSSProp(21, theme.palette.background.paper), new Props.CSSProp(103, theme.palette.primary.dark)]))], new Themes.Styles(231, ofArray([new Props.CSSProp(125, "flex"), new Props.CSSProp(136, "column"), new Props.CSSProp(200, "center"), new Props.CSSProp(1, "center")])), new Themes.Styles(239, ofArray([new Props.CSSProp(208, ".7rem"), new Props.CSSProp(343, ".7rem"), new Props.CSSProp(165, theme.typography.fontWeightLight), new Props.CSSProp(391, "nowrap"), [xsBreakpoint, toObj(ofArray([new Props.CSSProp(153, 28)]))]])), new Themes.Styles(120, ofArray([new Props.CSSProp(279, theme.spacing.unit * 4), new Props.CSSProp(280, theme.spacing.unit * 4), new Props.CSSProp(225, theme.spacing.unit), new Props.CSSProp(248, 500), new Props.CSSProp(325, "center")])), new Themes.Styles(58, ofArray([new Props.CSSProp(276, theme.spacing.unit * 8), new Props.CSSProp(281, theme.spacing.unit * 8), [smBreakpoint, toObj(ofArray([new Props.CSSProp(281, theme.spacing.unit * 12)]))]])), new Themes.Styles(33, ofArray([new Props.CSSProp(225, theme.spacing.unit * 3)])), ["logo", toObj(ofArray([new Props.CSSProp(225, theme.spacing.unit * 3), new Props.CSSProp(224, 0), new Props.CSSProp(223, 0), new Props.CSSProp(220, theme.spacing.unit * 4), new Props.CSSProp(394, "100%"), new Props.CSSProp(189, "35vw"), new Props.CSSProp(247, 200)]))]]);
}
export function homeWithStyles() {
  var styles;
  var options;
  return CurriedLambda((styles = homeStyles, options = new List(), function (fn) {
    return withStyles(styles, options, fn);
  }));
}
export function home(dispatch, props) {
  const classes = props.classes;
  return createElement("div", {
    className: classes.hero
  }, createElement("div", {
    className: classes.content
  }, createElement("img", {
    src: "img/fable-material-ui-logo.svg",
    alt: "Fable Material-UI Logo",
    className: classes.logo
  }), createElement("div", {
    className: classes.text
  }, materialEl(Typography, ofArray([new Props_1.TypographyProp(6, "display2"), new Props_1.TypographyProp(0, "center"), new Props_1.MaterialProp(5, "h1"), new Props_1.TypographyProp(1, "inherit"), new Props_1.TypographyProp(2, true), new Props.HTMLAttr(23, classes.title)]), ofArray(["FABLE MATERIAL-UI"])), materialEl(Typography, ofArray([new Props_1.TypographyProp(6, "headline"), new Props_1.MaterialProp(5, "h2"), new Props_1.TypographyProp(1, "inherit"), new Props_1.TypographyProp(2, true), new Props.HTMLAttr(23, classes.headline)]), ofArray(["Fable bindings for Material-UI React components"])), materialEl(Button, ofArray([new Props_1.MaterialProp(5, "a"), new Props.DOMAttr(40, function (e) {
    e.preventDefault();
    dispatch(new Msg(0, new Page(1)));
  }), new Props.HTMLAttr(23, classes.button), new Props_1.ButtonProp(4, "outlined"), new Props_1.MaterialProp(4, "primary")]), ofArray(["Get Started"])))));
}
export function root(_arg1, dispatch) {
  return createElement(homeWithStyles()(function (props) {
    return home(dispatch, props);
  }), {});
}