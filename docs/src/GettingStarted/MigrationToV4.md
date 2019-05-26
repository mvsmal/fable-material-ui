# Migration to version 4

## Requirements

Version 4 requires 
* `Fable.Core >= 3.0.0`
* `Fable.React >= 5.2.1`
* `fable-compiler >= 2.3.5`.

## Breaking changes

* Popper new signature: `seq<IHTMLProp> -> U2<ReactElement list, (PopperProps->ReactElement)> -> ReactElement`
* `MaterialProp.AnchorEl` has new type: `type AnchorElProp = U2<EventTarget,unit->EventTarget>`
* `MaterialProp.AddEndListener` became of type `(HTMLElement->(unit->unit)->unit)`
* Functions in `IMixins` use `obj` instead of `CSSProperties`
* All `ReactNode` and `ReactInstance` types became `ReactElement`
* All `ReactType` and `ComponentClass` types became `ReactElementType`
* `RefProp` became of type `U2<IRefValue<'T>,(ReactElement->unit)>`

## More info

https://fable.io/blog/Announcing-2-2.html

https://fable.io/blog/Announcing-Fable-React-5.html