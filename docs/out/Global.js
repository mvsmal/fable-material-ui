import { setType } from "./fable-core/Symbol";
import _Symbol from "./fable-core/Symbol";
import { compareRecords, equalsRecords, Option, makeGeneric, comparePrimitives } from "./fable-core/Util";
import List from "./fable-core/List";
export class Page {
  constructor(tag) {
    this.tag = tag | 0;
  }

  [_Symbol.reflection]() {
    return {
      type: "Global.Page",
      interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable"],
      cases: [["Home"], ["Installation"], ["Usage"], ["AppBar"], ["Autocomplete"], ["Avatars"]]
    };
  }

  Equals(other) {
    return this.tag === other.tag;
  }

  CompareTo(other) {
    return comparePrimitives(this.tag, other.tag);
  }

}
setType("Global.Page", Page);
export class NavItem {
  constructor(title, children, href) {
    this.Title = title;
    this.Children = children;
    this.Href = href;
  }

  [_Symbol.reflection]() {
    return {
      type: "Global.NavItem",
      interfaces: ["FSharpRecord", "System.IEquatable", "System.IComparable"],
      properties: {
        Title: "string",
        Children: makeGeneric(List, {
          T: NavItem
        }),
        Href: Option(Page)
      }
    };
  }

  Equals(other) {
    return equalsRecords(this, other);
  }

  CompareTo(other) {
    return compareRecords(this, other) | 0;
  }

}
setType("Global.NavItem", NavItem);
export function toHash(page) {
  switch (page.tag) {
    case 1:
      return "#/getting-started/installation";

    case 2:
      return "#/getting-started/usage";

    case 3:
      return "#/demos/app-bar";

    case 4:
      return "#/demos/autocomplete";

    case 5:
      return "#/demos/avatars";

    default:
      return "#/home";
  }
}