import { createElement } from "react";
import { root as root_1 } from "./Demo";
import { view } from "../AppBar/SimpleAppBar";
export function root(model, dispatch) {
  return createElement("div", {}, createElement("h1", {}, "App Bar"), createElement("h4", {}, "The App Bar displays information and actions relating to the current screen."), createElement("p", {}, "The top App Bar provides content and actions related to the current screen. It’s used for branding, screen titles, navigation, and actions."), createElement("p", {}, "It can transform into a contextual action bar or used as a navbar."), root_1("Simple App Bar", "../../public/index.html", view));
}