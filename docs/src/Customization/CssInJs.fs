module Customization.CssInJs.View

open Fable.Core.JsInterop
open Fable.Helpers.React

open Components

let text = importDefault "./CssInJs.md"

let cssInJsText = """
## Material-UI's styling solution

In previous versions, Material-UI has used LESS, then a custom inline-style solution to write the style of the
components, but these approaches have proven to be limited. Most recently, Material-UI has [moved toward](https://github.com/oliviertassinari/a-journey-toward-better-style)
a *CSS-in-JS* solution. It **unlocks many great features** (theme nesting, dynamic styles, self-support, etc.).
We think that it's the future:
- [A Unified Styling Language](https://medium.com/seek-blog/a-unified-styling-language-d0c208de2660)
- [The future of component-based styling](https://medium.freecodecamp.org/css-in-javascript-the-future-of-component-based-styling-70b161a79a32)
- [Convert SCSS (Sass) to CSS-in-JS](https://egghead.io/courses/convert-scss-sass-to-css-in-js)

So, you may have noticed in the demos what *CSS-in-JS* looks like.
We use the higher-order component created by `withStyles`
to inject an array of styles into the DOM as CSS, using JSS. Here's an example:
"""

let jssText = """
## JSS

Material-UI's styling solution uses [JSS](https://github.com/cssinjs/jss) at its core.
It's a [high performance](https://github.com/cssinjs/jss/blob/master/docs/performance.md) JS to CSS compiler which works at runtime and server-side.
It is about 8 kB (minified and gzipped) and is extensible via a [plugins](https://github.com/cssinjs/jss/blob/master/docs/plugins.md) API.

If you end up using this styling solution in your codebase, you're going to need to *learn the API*.
The best place to start is by looking at the features that each [plugin](http://cssinjs.org/plugins/) provides. Material-UI uses few of them (see below)
You can always add new plugins if needed with the [`JssProvider`](https://github.com/cssinjs/react-jss#custom-setup) helper.

If you wish to build your own instance of `jss` **and** support *rtl* make sure you also include the [jss-rtl](https://github.com/alitaheri/jss-rtl) plugin.
Check the jss-rtl [readme](https://github.com/alitaheri/jss-rtl#simple-usage) to learn how.

⚠️*There are no helpers of JssProvider in this library since it's not part of Material-UI. You would need to import it manually with* `Fable.Core.JsInterop` *helpers*
"""

let classNamesText = """
## Class names

You may have noticed that the class names generated by our styling solution are **non-deterministic**,
so you can't rely on them to stay the same. The following CSS won't work:
```css
.MuiAppBar-root-12 {
  opacity: 0.6
}
```

Instead, you have to use the `classes` property of a component to override them.
On the other hand, thanks to the non-deterministic nature of our class names, we
can implement optimizations for development and production.
They are easy to debug in development and as short as possible in production:

- development: `.MuiAppBar-root-12`
- production: `.jss12`

If you don't like this default behavior, you can change it.
JSS relies on the concept of [class name generator](http://cssinjs.org/js-api/#generate-your-own-class-names).
"""

let pluginsText = """
## Plugins

JSS uses the concept of plugins to extend its core, allowing people to cherry-pick the features they need.
You pay the performance overhead for only what's you are using.
Given `withStyles` is Material-UI's internal styling solution, all the plugins aren't available by default. The following list is used:
- [jss-global](http://cssinjs.org/jss-global/)
- [jss-nested](http://cssinjs.org/jss-nested/)
- [jss-camel-case](http://cssinjs.org/jss-camel-case/)
- [jss-default-unit](http://cssinjs.org/jss-default-unit/)
- [jss-vendor-prefixer](http://cssinjs.org/jss-vendor-prefixer/)
- [jss-props-sort](http://cssinjs.org/jss-props-sort/)

It's a subset of [jss-preset-default](http://cssinjs.org/jss-preset-default/).
"""

let withStylesApiText = """
## API

### `withStyles<'P when 'P :> IClassesProps> (styles : StyleType) (options: StyleOption list) (fn : 'P -> ReactElement) : ComponentClass<'P>`

Link a style sheet with a component.
It does not modify the component passed to it; instead, it returns a new component with a `classes` property.
This `classes` object contains the name of the class names injected in the DOM.

Some implementation details that might be interesting to being aware of:
- It adds a `classes` property so you can override the injected class names from the outside.
- It adds an `innerRef` property so you can get a reference to the wrapped component. The usage of `innerRef` is identical to `ref`.
- It forwards *non React static* properties so this HOC is more "transparent".

#### Arguments

1. `styles : StyleType`: A function generating the styles or a list of styles options.
  - `StyleType.Func of (ITheme->IStyles list)`: Use this version if you need to have access to the theme. It's provided as the argument
  - `StyleType.Styles of IStyles list`: Use this option to pass a static list of styles
It will be linked to the component.
2. `options : StyleOption list`: All options are optional, so you can pass an empty list
  - `StyleOption.WithTheme of bool`: Defaults to `false`. Provide the `theme` object to the component as a property.
  - `StyleOption.Name of string`: The name of the style sheet. Useful for debugging.
    If the value isn't provided, it will try to fallback to the name of the component.
  - `StyleOption.Flip of bool option`: When set to `Some false`, this sheet will opt-out the `rtl` transformation. When set to `Some true`, the styles are inversed. When set to `None`, it follows `theme.direction`.
  - The other keys (`StyleOption.Custom of string*obj`) are forwarded to the options argument of [jss.createStyleSheet([styles], [options])](http://cssinjs.org/js-api/#create-style-sheet).
3. `fn : 'P -> ReactElement`: A function which renders a ReactElement with an argument of type `'P` (has to inherit IClassesProps)
```fsharp
type IClasses = interface end
type IClassesProps =
    abstract member classes: IClasses
```

#### Returns

`ClassComponent<'P>`: Should be used with `Fable.Helpers.React.from`

#### Example
```fsharp
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Helpers.MaterialUI
open Fable.MaterialUI.Props

let styles : IStyles list = [
    Styles.Root [
        CSSProp.BackgroundColor "red"
    ]
]

let myFun (props : IClassesProps) =
    div [ HTMLAttr.Class !!props.classes?root ] []

let withStylesFun = withStyles<IClassesProps> (StyleType.Styles styles) [] myFun

let view () =
    from withStylesFun createEmpty []
```
"""

let view () =
    div [] [
        Markdown.view text
        Demo.view cssInJsText "./Customization/CssInJs/CssInJs.fs" Example.view
        Markdown.view jssText
        Markdown.view pluginsText
        Markdown.view withStylesApiText
    ]

