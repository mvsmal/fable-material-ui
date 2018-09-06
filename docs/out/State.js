import CurriedLambda from "./fable-core/CurriedLambda";
import { collect, ofArray } from "./fable-core/List";
import List from "./fable-core/List";
import { oneOf, s, map } from "./fable/parser";
import { toHash, Page } from "./Global";
import { Model } from "./Types";
import { getValue } from "./fable-core/Option";
import { Navigation } from "./fable/navigation";
import { Cmd } from "./fable/cmd";
export const pageParser = CurriedLambda((() => {
  var parseBefore;
  var parseAfter;
  var parseBefore_1;
  var parseAfter_1;
  var parseBefore_2;
  var parseAfter_2;
  var parseBefore_3;
  var parseAfter_3;
  var parseBefore_4;
  var parseAfter_4;
  const parsers = ofArray([map(new Page(0), s("/")), map(new Page(0), s("home")), map(new Page(1), (parseBefore = s("getting-started"), parseAfter = s("installation"), function (state) {
    return collect(parseAfter, parseBefore(state));
  })), map(new Page(2), (parseBefore_1 = s("getting-started"), parseAfter_1 = s("usage"), function (state_1) {
    return collect(parseAfter_1, parseBefore_1(state_1));
  })), map(new Page(3), (parseBefore_2 = s("demos"), parseAfter_2 = s("app-bar"), function (state_2) {
    return collect(parseAfter_2, parseBefore_2(state_2));
  })), map(new Page(4), (parseBefore_3 = s("demos"), parseAfter_3 = s("autocomplete"), function (state_3) {
    return collect(parseAfter_3, parseBefore_3(state_3));
  })), map(new Page(5), (parseBefore_4 = s("demos"), parseAfter_4 = s("avatars"), function (state_4) {
    return collect(parseAfter_4, parseBefore_4(state_4));
  }))]);
  return function (state_5) {
    return oneOf(parsers, state_5);
  };
})());
export function urlUpdate(result, model) {
  console.log("urlUpdate", result, model);

  if (result != null) {
    return [new Model(getValue(result), getValue(result).Equals(new Page(0)), model.menuOpen), new List()];
  } else {
    console.error("Error parsing url");
    return [model, Navigation.modifyUrl(toHash(model.currentPage))];
  }
}
export function init(result) {
  const patternInput = urlUpdate(result, new Model(new Page(0), true, false));
  return [patternInput[0], Cmd.batch(ofArray([patternInput[1]]))];
}
export function update(msg, model) {
  var menuOpen;
  console.log("udpate", msg, model);
  const result = msg.tag === 1 ? [(menuOpen = !model.menuOpen, new Model(model.currentPage, model.isLanding, menuOpen)), new List()] : [new Model(msg.data, msg.data.Equals(new Page(0)), model.menuOpen), Navigation.newUrl(toHash(msg.data))];
  return result;
}