import { setType } from "../fable-core/Symbol";
import _Symbol from "../fable-core/Symbol";
import { comparePrimitives, compareRecords, equalsRecords, GenericParam, makeGeneric } from "../fable-core/Util";
import { collect, map as map_2, ofArray } from "../fable-core/List";
import List from "../fable-core/List";
import { create, tryFind } from "../fable-core/Map";
import _Map from "../fable-core/Map";
import CurriedLambda from "../fable-core/CurriedLambda";
import Result from "../fable-core/Result";
import { tryParse } from "../fable-core/Int32";
import { makeSome, defaultArg } from "../fable-core/Option";
import { split } from "../fable-core/String";
import { ofFunc, tuple } from "./prelude.1";
import { map as map_3, choose } from "../fable-core/Seq";
import Comparer from "../fable-core/Comparer";
export class State {
  constructor(visited, unvisited, args, value) {
    this.visited = visited;
    this.unvisited = unvisited;
    this.args = args;
    this.value = value;
  }

  [_Symbol.reflection]() {
    return {
      type: "Elmish.Browser.UrlParser.State",
      interfaces: ["FSharpRecord", "System.IEquatable", "System.IComparable"],
      properties: {
        visited: makeGeneric(List, {
          T: "string"
        }),
        unvisited: makeGeneric(List, {
          T: "string"
        }),
        args: makeGeneric(_Map, {
          Key: "string",
          Value: "string"
        }),
        value: GenericParam("v")
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
setType("Elmish.Browser.UrlParser.State", State);
export const StateModule = function (__exports) {
  const mkState = __exports.mkState = function (visited, unvisited, args, value) {
    return new State(visited, unvisited, args, value);
  };

  const map = __exports.map = function (f, _arg1) {
    return new State(_arg1.visited, _arg1.unvisited, _arg1.args, f(_arg1.value));
  };

  return __exports;
}({});
export function custom(tipe, stringToSomething) {
  var inner;
  return CurriedLambda((inner = function (_arg1) {
    if (_arg1.unvisited.tail != null) {
      const matchValue = stringToSomething(_arg1.unvisited.head);

      if (matchValue.tag === 1) {
        return new List();
      } else {
        return ofArray([StateModule.mkState(new List(_arg1.unvisited.head, _arg1.visited), _arg1.unvisited.tail, _arg1.args, _arg1.value(matchValue.data))]);
      }
    } else {
      return new List();
    }
  }, inner));
}
export function str(state) {
  return custom("string", function (arg0) {
    return new Result(0, arg0);
  })(state);
}
export function i32(state) {
  return custom("i32", $var1 => function (_arg1) {
    return _arg1[0] ? new Result(0, _arg1[1]) : new Result(1, "Can't parse int");
  }(function (arg00) {
    return tryParse(arg00, 10, 0);
  }($var1)))(state);
}
export function s(str_1) {
  var inner;
  return CurriedLambda((inner = function (_arg1) {
    return _arg1.unvisited.tail != null ? _arg1.unvisited.head === str_1 ? ofArray([StateModule.mkState(new List(_arg1.unvisited.head, _arg1.visited), _arg1.unvisited.tail, _arg1.args, _arg1.value)]) : new List() : new List();
  }, inner));
}

function map_1(subValue, parse) {
  var inner;
  return CurriedLambda((inner = function (_arg1) {
    return map_2(function (arg10_) {
      return StateModule.map(_arg1.value, arg10_);
    }, parse(new State(_arg1.visited, _arg1.unvisited, _arg1.args, subValue)));
  }, inner));
}

export { map_1 as map };
export function oneOf(parsers, state) {
  return collect(function (parser) {
    return parser(state);
  }, parsers);
}
export function top(state) {
  return ofArray([state]);
}
export function customParam(key, func) {
  var inner;
  return CurriedLambda((inner = function (_arg1) {
    return ofArray([StateModule.mkState(_arg1.visited, _arg1.unvisited, _arg1.args, _arg1.value(func(tryFind(key, _arg1.args))))]);
  }, inner));
}
export function stringParam(name) {
  return customParam(name, function (x) {
    return x;
  });
}
export const intParamHelp = CurriedLambda((() => {
  const binder = function (value) {
    const matchValue = tryParse(value, 10, 0);

    if (matchValue[0]) {
      return matchValue[1];
    } else {
      return null;
    }
  };

  return function (option) {
    return defaultArg(option, null, binder);
  };
})());
export function intParam(name) {
  return customParam(name, intParamHelp);
}
export function parseHelp(states) {
  parseHelp: while (true) {
    if (states.tail != null) {
      const $var2 = states.head.unvisited.tail != null ? states.head.unvisited.head === "" ? states.head.unvisited.tail.tail == null ? [1] : [2] : [2] : [0];

      switch ($var2[0]) {
        case 0:
          return makeSome(states.head.value);

        case 1:
          return makeSome(states.head.value);

        case 2:
          states = states.tail;
          continue parseHelp;
      }
    } else {
      return null;
    }
  }
}
export function splitUrl(url) {
  const matchValue = ofArray(split(url, "/"));
  const $var3 = matchValue.tail != null ? matchValue.head === "" ? [0, matchValue.tail] : [1, matchValue] : [1, matchValue];

  switch ($var3[0]) {
    case 0:
      return $var3[1];

    case 1:
      return $var3[1];
  }
}
export function parse(parser, url, args) {
  return parseHelp(parser(new State(new List(), splitUrl(url), args, function (x) {
    return x;
  })));
}
export function toKeyValuePair(segment) {
  const matchValue = split(segment, "=");

  if (matchValue != null ? matchValue.length === 2 : false) {
    const value = matchValue[1];
    const key = matchValue[0];
    return tuple(ofFunc(decodeURI, key), ofFunc(decodeURI, value));
  } else {
    return null;
  }
}
export function parseParams(querystring) {
  return create(choose(function (x) {
    return x;
  }, function (source) {
    return map_3(toKeyValuePair, source);
  }(split(querystring.substr(1), "&"))), new Comparer(comparePrimitives));
}
export function parsePath(parser, location) {
  return parse(parser, location.pathname, parseParams(location.search));
}
export function parseHash(parser, location) {
  let patternInput;
  const hash = location.hash.substr(1);

  if (hash.indexOf("?") >= 0) {
    const h = hash.substr(0, hash.indexOf("?"));
    patternInput = [h, hash.substr(h.length)];
  } else {
    patternInput = [hash, "?"];
  }

  return parse(parser, patternInput[0], parseParams(patternInput[1]));
}