module Customization.Overrides.View

open Fable.Core.JsInterop
open Fable.React

open Components

let text = importDefault "./Overrides.md"

let classNamesText = """
### Overriding with class names

The first way to override the style of a component is to use **class names**.
Every component provides a `className` property which is always applied to the root element.

In this example, we are using the [`withStyles()`](#/customization/css-in-js) higher-order
component to inject custom styles into the DOM, and to pass the class name to the `ClassNames` component via
its `classes` prop. You can choose any other styling solution, or even plain CSS to create the styles, but be sure to
consider the [CSS injection order](https://material-ui.com/customization/css-in-js/#css-injection-order), as the CSS injected into the DOM
by Material-UI to style a component has the highest specificity possible since the `<link>` is injected at the bottom
of the `<head />` to ensure the components always render correctly.
"""

let classNestingText = """
### Overriding with classes

When the `className` property isn't enough, and you need to access deeper elements, you can take advantage of the `classes` property to customize all the CSS injected by Material-UI for a given component.
The list of  classes for each
component is documented in the **Component API** section.

This example also uses `withStyles()` (see above), but here, `ClassesNesting` is using `Button`'s `classes` prop to
provide an object that maps the **names of classes to override** (keys) to the **CSS class names to apply** (values).
The component's existing classes will continue to be injected, so it is only necessary to provide the specific styles
you wish to add or override.

Notice that in addition to the button styling, the button label's capitalization has been changed:
"""

let shortlandText = """
#### Shorthand

The above code example can be condensed by using **the same CSS API** as the child component.
In this example, the `withStyles()` higher-order component is injecting a `classes` property that is used by the `Button` component.
```fsharp
let styles : IStyles list = [
    Styles.Root [
        CSSProp.Background "linear-gradient(45deg, #FE6B8B 30%, #FF8E53 90%)"
        CSSProp.BorderRadius 3
        CSSProp.Border 0
        CSSProp.Color "white"
        CSSProp.Height 48
        CSSProp.Padding "0 30px"
        CSSProp.BoxShadow "0 3px 5px 2px rgba(255, 105, 135, .3)"
    ]
    Styles.Label [
        CSSProp.TextTransform "capitalize"
    ]
]

let styledButton = withStyles (StyleType.Styles styles) [] !!MaterialUI.Button
```
"""

let internalStateText = """
#### Internal states

Aside from accessing nested elements, the `classes` property can be used to customize the internal states of Material-UI components.
The components internal states, like `:hover`, `:focus`, `disabled` and `selected`, are styled with a higher CSS specificity.
[Specificity is a weight](https://developer.mozilla.org/en-US/docs/Web/CSS/Specificity) that is applied to a given CSS declaration.
In order to override the components internal states, **you need to increase specificity**.
Here is an example with the `disable` state and the button component:

```css
.classes-state-root {
  /* ... */
}
.classes-state-root.disabled {
  color: white;
}
```

```fsharp

button [
    HTMLAttr.Disabled true
    MaterialProp.Classes [
        ClassNames.Root "classes-state-root"
        ClassNames.Disabled "disabled"
    ]
] []

```

#### Use `$ruleName` to reference a local rule within the same style sheet

The [jss-nested](https://github.com/cssinjs/jss-nested) plugin (available by default) can make the process of increasing specificity easier.

```fsharp
let styles : IStyles list = [
    Styles.Root [
        CSSProp.Custom ("&$disabled", [
            CSSProp.Color "white"
        ] |> keyValueList CaseRules.LowerFirst)
    ]
    Styles.Disabled []
]
```

compiles to:

```css
.root-x.disable-x {
  color: white;
}
```
"""

let inlineStyleText = """
### Overriding with inline-style

The second way to override the style of a component is to use the **inline-style** approach.
Every component provides a `style` property.
These properties are always applied to the root element.

You don't have to worry about CSS specificity as the inline-style takes precedence over the regular CSS.
"""

let materialDesignVariations = """
## 2. Material Design variations

The Material Design specification documents different variations of certain components, such as how buttons come in different shapes: [text](https://material.io/design/components/buttons.html#text-button) (formerly "flat"), [contained](https://material.io/design/components/buttons.html#contained-button) (formerly "raised"), [FAB](https://material.io/design/components/buttons-floating-action-button.html) and more.

Material-UI attempts to implement all of these variations.
"""

let globalThemeVariationText = """
## 3. Global theme variation

### Theme variables

In order to promote consistency between components, and manage the user interface appearance as a whole, Material-UI provides a mechanism to apply global changes by adjusting the [theme configuration variables](#/customization/themes).

### Global theme override

Do you want to customize **all the instances** of a component type?

When the configuration variables aren't powerful enough,
you can take advantage of the `overrides` key of the `theme` to potentially change every single style injected by Material-UI into the DOM.
Learn more about it in the [themes section](#/customization/themes) of the documentation.

### Global CSS override

You can also customize all instances of a component with CSS.
We expose a `dangerouslyUseGlobalCSS` option to do so.
Learn more about it in the [CSS in JS section](#/customization/css-in-js) of the documentation. It's very similar to how you would customize Bootstrap.
"""
let view () =
    div [] [
        Markdown.view text
        Demo.view classNamesText "./Customization/Overrides/ClassNames.fs" ClassNames.view
        Demo.view classNestingText "./Customization/Overrides/ClassNesting.fs" ClassNesting.view
        Demo.view shortlandText "./Customization/Overrides/ShortlandClasses.fs" ShortlandClasses.view
        Demo.view internalStateText "./Customization/Overrides/InternalState.fs" InternalState.view
        Demo.view inlineStyleText "./Customization/Overrides/InlineStyle.fs" InlineStyle.view
        Markdown.view "[When should I use inline-style vs classes?](https://material-ui.com/getting-started/faq/#when-should-i-use-inline-style-vs-classes-)"
        Markdown.view materialDesignVariations
        Markdown.view globalThemeVariationText
    ]
