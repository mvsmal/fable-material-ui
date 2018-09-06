import { setType } from "./fable-core/Symbol";
import _Symbol from "./fable-core/Symbol";
import { Page } from "./Global";
import { compareRecords, equalsRecords, compareUnions, equals } from "./fable-core/Util";
export class Msg {
  constructor(tag, data) {
    this.tag = tag | 0;
    this.data = data;
  }

  [_Symbol.reflection]() {
    return {
      type: "App.Types.Msg",
      interfaces: ["FSharpUnion", "System.IEquatable", "System.IComparable"],
      cases: [["Navigate", Page], ["ToggleMenu"]]
    };
  }

  Equals(other) {
    return this === other || this.tag === other.tag && equals(this.data, other.data);
  }

  CompareTo(other) {
    return compareUnions(this, other) | 0;
  }

}
setType("App.Types.Msg", Msg);
export class Model {
  constructor(currentPage, isLanding, menuOpen) {
    this.currentPage = currentPage;
    this.isLanding = isLanding;
    this.menuOpen = menuOpen;
  }

  [_Symbol.reflection]() {
    return {
      type: "App.Types.Model",
      interfaces: ["FSharpRecord", "System.IEquatable", "System.IComparable"],
      properties: {
        currentPage: Page,
        isLanding: "boolean",
        menuOpen: "boolean"
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
setType("App.Types.Model", Model);