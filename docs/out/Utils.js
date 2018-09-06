import { createObj } from "./fable-core/Util";
import CurriedLambda from "./fable-core/CurriedLambda";
import { join } from "./fable-core/String";
import { choose } from "./fable-core/List";
export function toObj(list) {
  return createObj(list, 1);
}
export const classNames = CurriedLambda($var1 => join(" ", choose(function (tupledArg) {
  return tupledArg[1] ? tupledArg[0] : null;
}, $var1)));