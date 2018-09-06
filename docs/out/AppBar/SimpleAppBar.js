import { createElement } from "react";
import { Typography, Toolbar, AppBar, materialEl } from "../src/Fable.Helpers.MaterialUI";
import { ofArray } from "../fable-core/List";
import List from "../fable-core/List";
import { Props } from "../src/Fable.Helpers.MaterialUI.Props";
export const view = createElement("div", {}, materialEl(AppBar, ofArray([new Props.AppBarProp(0, "static"), new Props.MaterialProp(4, "default")]), ofArray([materialEl(Toolbar, new List(), ofArray([materialEl(Typography, ofArray([new Props.TypographyProp(6, "title"), new Props.MaterialProp(4, "inherit")]), ofArray(["Photos"]))]))])));