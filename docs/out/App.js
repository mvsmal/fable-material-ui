import * as main_sass from "./sass/main.sass";
import { MuiThemeProvider, Drawer, Tooltip, AppBar, Icon, IconButton, Divider, Typography, Toolbar, withStyles, SvgIcon, materialEl, ColorManipulator, createMuiTheme } from "./src/Fable.Helpers.MaterialUI";
import { ofArray } from "./fable-core/List";
import List from "./fable-core/List";
import { Themes, Colors, Props } from "./src/Fable.Helpers.MaterialUI.Props";
import { createElement } from "react";
import { Props as Props_1 } from "./fable/Fable.Helpers.React";
import { classNames, toObj } from "./Utils";
import CurriedLambda from "./fable-core/CurriedLambda";
import { Msg } from "./Types";
import { Page } from "./Global";
import { navigationMenu } from "./Navigation";
import { root as root_1 } from "./GettingStarted/Installation";
import { root as root_2 } from "./Demos/AppBar";
import { root as root_3 } from "./Demos/Autocomplete";
import { root as root_4 } from "./Demos/Avatars";
import { root as root_5 } from "./GettingStarted/Usage";
import { root as root_6 } from "./Home";
import { ProgramModule } from "./fable/program";
import { Program } from "./fable/react";
import { ProgramModule as ProgramModule_1 } from "./fable/navigation";
import { parseHash } from "./fable/parser";
import { update, init, urlUpdate, pageParser } from "./State";
main_sass;
export const theme = createMuiTheme(ofArray([new Props.ThemeProp(1, ofArray([new Props.PaletteProp(1, "light"), new Props.PaletteProp(2, ofArray([new Props.PaletteIntentionProp(1, Colors.blue["500"])])), new Props.PaletteProp(3, ofArray([new Props.PaletteIntentionProp(1, ColorManipulator.darken(Colors.pink.A400, 0.08))]))]))]));
export const githubIcon = materialEl(SvgIcon, new List(), ofArray([createElement("path", {
  d: "M12 .3a12 12 0 0 0-3.8 23.4c.6.1.8-.3.8-.6v-2c-3.3.7-4-1.6-4-1.6-.6-1.4-1.4-1.8-1.4-1.8-1-.7.1-.7.1-.7 1.2 0 1.9 1.2 1.9 1.2 1 1.8 2.8 1.3 3.5 1 0-.8.4-1.3.7-1.6-2.7-.3-5.5-1.3-5.5-6 0-1.2.5-2.3 1.3-3.1-.2-.4-.6-1.6 0-3.2 0 0 1-.3 3.4 1.2a11.5 11.5 0 0 1 6 0c2.3-1.5 3.3-1.2 3.3-1.2.6 1.6.2 2.8 0 3.2.9.8 1.3 1.9 1.3 3.2 0 4.6-2.8 5.6-5.5 5.9.5.4.9 1 .9 2.2v3.3c0 .3.1.7.8.6A12 12 0 0 0 12 .3"
})]));
export function drawerMenuStyles(theme_1) {
  return ofArray([new Themes.Styles(239, ofArray([new Props_1.CSSProp(103, theme_1.palette.text.secondary), new Props_1.CSSProp(220, ~~(theme_1.spacing.unit / 2))])), ["drawerRoot", toObj(ofArray([new Props_1.CSSProp(394, 250)]))], ["drawerToolbar", toObj(ofArray([new Props_1.CSSProp(125, "flex"), new Props_1.CSSProp(136, "column"), new Props_1.CSSProp(200, "center"), new Props_1.CSSProp(1, "flex-start")]))], ["headerLink", toObj(ofArray([new Props_1.CSSProp(372, "color .2s ease-in-out"), ["&:hover", toObj(ofArray([new Props_1.CSSProp(103, theme_1.palette.primary.main), new Props_1.CSSProp(329, "underline")]))]]))]]);
}
export function drawerMenuWithStyles() {
  var styles;
  var options;
  return CurriedLambda((styles = drawerMenuStyles, options = new List(), function (fn) {
    return withStyles(styles, options, fn);
  }));
}
export function drawerMenu(model, dispatch, props) {
  const classes = props.classes;
  return createElement("div", {
    className: classes.drawerRoot
  }, materialEl(Toolbar, ofArray([new Props_1.HTMLAttr(23, classes.drawerToolbar)]), ofArray([createElement("a", {
    className: classes.title,
    href: "",
    onClick: function (e) {
      e.preventDefault();
      dispatch(new Msg(0, new Page(0)));
    }
  }, materialEl(Typography, ofArray([new Props.TypographyProp(6, "title"), new Props_1.HTMLAttr(23, classes.headerLink), new Props.TypographyProp(1, "inherit")]), ofArray(["Fable Material-UI"]))), createElement("a", {
    target: "_blank",
    rel: "noopener noreferrer",
    href: "https://github.com/mvsmal/fable-material-ui/releases"
  }, materialEl(Typography, ofArray([new Props.TypographyProp(6, "caption"), new Props_1.HTMLAttr(23, classes.headerLink)]), ofArray(["v1.2.0"])))])), materialEl(Divider, new List(), new List()), navigationMenu(model, dispatch));
}
export function menuButton(model, dispatch) {
  if (model.isLanding) {
    return materialEl(IconButton, ofArray([new Props.IconProp(0, "inherit"), new Props_1.DOMAttr(40, function (_arg1) {
      dispatch(new Msg(1));
    })]), ofArray([materialEl(Icon, new List(), ofArray(["menu"]))]));
  } else {
    return null;
  }
}
export function appBarStyles(theme_1) {
  const mdBreakpoint = theme_1.breakpoints.up("md");
  return ofArray([["appBar", toObj(ofArray([[mdBreakpoint, toObj(ofArray([new Props_1.CSSProp(207, 250), new Props_1.CSSProp(394, "calc(100% - 250px)")]))]]))], ["landingAppBar", toObj(ofArray([new Props_1.CSSProp(207, 0), new Props_1.CSSProp(394, "100vw"), new Props_1.CSSProp(92, "unset")]))]]);
}
export function appBarWithStyles() {
  var styles;
  var options;
  return CurriedLambda((styles = appBarStyles, options = new List(), function (fn) {
    return withStyles(styles, options, fn);
  }));
}
export function appBar(model, dispatch, props) {
  const classes = props.classes;
  return materialEl(AppBar, ofArray([new Props.AppBarProp(0, "fixed"), new Props_1.HTMLAttr(23, classNames(ofArray([[classes.appBar, true], [classes.landingAppBar, model.isLanding]])))]), ofArray([materialEl(Toolbar, new List(), ofArray([menuButton(model, dispatch), createElement("div", {
    className: "flex"
  }), materialEl(Tooltip, ofArray([new Props.TooltipProp(8, "Github"), new Props.TooltipProp(3, 300)]), ofArray([materialEl(IconButton, ofArray([new Props.IconProp(0, "inherit"), new Props.MaterialProp(5, "a"), new Props_1.HTMLAttr(115, "_blank"), new Props.ButtonProp(1, "https://github.com/mvsmal/fable-material-ui")]), ofArray([githubIcon]))]))]))]));
}
export function drawer(model, dispatch) {
  return materialEl(Drawer, ofArray([new Props.DrawerProp(3, model.isLanding ? "temporary" : "permanent"), new Props.MaterialProp(24, model.menuOpen), new Props.MaterialProp(35, function (_arg1) {
    dispatch(new Msg(1));
  })]), ofArray([createElement(drawerMenuWithStyles()(function (props) {
    return drawerMenu(model, dispatch, props);
  }), {})]));
}
export function layoutStyles(theme_1) {
  const mdBreakpoint = theme_1.breakpoints.up("md");
  const lgBreakpoint = theme_1.breakpoints.up("lg");
  return ofArray([["menuButton", toObj(ofArray([new Props_1.CSSProp(223, -12), new Props_1.CSSProp(224, 20)]))], ["main", toObj(ofArray([new Props_1.CSSProp(225, 55), new Props_1.CSSProp(273, 20), new Props_1.CSSProp(250, "calc(100vh - 55px)"), [mdBreakpoint, toObj(ofArray([new Props_1.CSSProp(225, 64), new Props_1.CSSProp(250, "calc(100vh - 64px)"), new Props_1.CSSProp(223, 250)]))]]))], ["landingMain", toObj(ofArray([new Props_1.CSSProp(273, 0), new Props_1.CSSProp(248, "100vw"), new Props_1.CSSProp(223, 0)]))], new Themes.Styles(58, ofArray([[lgBreakpoint, toObj(ofArray([new Props_1.CSSProp(248, 960), new Props_1.CSSProp(217, "0 auto")]))]]))]);
}
export function layoutWithStyles() {
  var styles;
  var options;
  return CurriedLambda((styles = layoutStyles, options = new List(), function (fn) {
    return withStyles(styles, options, fn);
  }));
}
export function layout(model, dispatch, props) {
  const content = function (_arg1) {
    switch (_arg1.tag) {
      case 1:
        return root_1(model, dispatch);

      case 3:
        return root_2(model, dispatch);

      case 4:
        return root_3(model, dispatch);

      case 5:
        return root_4(model, dispatch);

      case 2:
        return root_5(model, dispatch);

      default:
        return root_6(model, dispatch);
    }
  };

  const classes = props.classes;
  const mainClasses = classNames(ofArray([[classes.main, true], [classes.landingMain, model.isLanding]]));
  const contentClasses = classNames(ofArray([[classes.content, true], [classes.landingMain, model.isLanding]]));
  return materialEl(MuiThemeProvider, ofArray([new Props.MuiThemeProviderProp(0, theme)]), ofArray([createElement(appBarWithStyles()(function (props_1) {
    return appBar(model, dispatch, props_1);
  }), {}), drawer(model, dispatch), createElement("main", {
    className: mainClasses
  }, createElement("div", {
    className: contentClasses
  }, content(model.currentPage)))]));
}
export function root(model, dispatch) {
  return createElement(layoutWithStyles()(function (props) {
    return layout(model, dispatch, props);
  }), {});
}
ProgramModule.run(Program.withReact("app", ProgramModule_1.toNavigable(function (location) {
  return parseHash(pageParser, location);
}, urlUpdate, ProgramModule.mkProgram(init, update, root))));