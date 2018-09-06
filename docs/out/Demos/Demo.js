import prismjs from "prismjs";
import { Fragment, createElement } from "react";
export const prism = prismjs;
export function code(text) {
  const markedCode = prism.highlight(text, prism.languages.fsharp);
  return createElement("div", {}, createElement("pre", {}, createElement("code", {
    dangerouslySetInnerHTML: {
      __html: markedCode
    }
  })));
}
export function root(title, demoPath, demoElement) {
  const d = require(demoPath);

  return createElement(Fragment, {}, createElement("h2", {}, title), code(d), demoElement);
}