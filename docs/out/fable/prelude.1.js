import { makeSome, getValue } from "../fable-core/Option";
export function tuple(a, b) {
  const matchValue = [a, b];
  const $var1 = matchValue[0] != null ? matchValue[1] != null ? [0, getValue(matchValue[0]), getValue(matchValue[1])] : [1] : [1];

  switch ($var1[0]) {
    case 0:
      return [$var1[1], $var1[2]];

    case 1:
      return null;
  }
}
export function ofFunc(f, arg) {
  try {
    return makeSome(f(arg));
  } catch (matchValue) {
    return null;
  }
}