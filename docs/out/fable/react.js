import { getValue } from "../fable-core/Option";
import { hydrate, render } from "react-dom";
import { Common } from "./common";
import { Program as Program_1 } from "./program";
export const Program = function (__exports) {
  const withReact = __exports.withReact = function (placeholderId, program) {
    let lastRequest = null;

    const setState = function (model, dispatch) {
      if (lastRequest != null) {
        const r = getValue(lastRequest);
        window.cancelAnimationFrame(r);
      }

      lastRequest = window.requestAnimationFrame(function (_arg1) {
        render(Common.lazyView2With(function (x, y) {
          return x === y;
        }, program.view, model, dispatch), document.getElementById(placeholderId));
      });
    };

    return new Program_1(program.init, program.update, program.subscribe, program.view, setState, program.onError);
  };

  const withReactUnoptimized = __exports.withReactUnoptimized = function (placeholderId, program) {
    const setState = function (model, dispatch) {
      render(Common.lazyView2With(function (x, y) {
        return x === y;
      }, program.view, model, dispatch), document.getElementById(placeholderId));
    };

    return new Program_1(program.init, program.update, program.subscribe, program.view, setState, program.onError);
  };

  const withReactHydrate = __exports.withReactHydrate = function (placeholderId, program) {
    const setState = function (model, dispatch) {
      hydrate(Common.lazyView2With(function (x, y) {
        return x === y;
      }, program.view, model, dispatch), document.getElementById(placeholderId));
    };

    return new Program_1(program.init, program.update, program.subscribe, program.view, setState, program.onError);
  };

  return __exports;
}({});