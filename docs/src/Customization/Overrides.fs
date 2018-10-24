module Customization.Overrides.View

open Fable.Core.JsInterop
open Fable.Helpers.React

open Customization.Overrides
open Components

let text = importDefault "./Overrides.md"

let classNamesText = """
### Overriding with class names

The first way to override the style of a component is to use **class names**.
Every component provides a `className` property which is always applied to the root element.

In this example, we are using the [`withStyles()`](#/customization/css-in-js) higher-order
component to inject custom styles into the DOM, and to pass the class name to the `ClassNames` component via
its `classes` prop. You can choose any other styling solution, or even plain CSS to create the styles, but be sure to
consider the [CSS injection order](#/customization/css-in-js), as the CSS injected into the DOM
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
"""
let view () =
    div [] [
        Markdown.view text
        Demo.view classNamesText "./Customization/Overrides/ClassNames.fs" ClassNames.view
        Demo.view classNestingText "./Customization/Overrides/ClassNesting.fs" ClassNesting.view
        Demo.view shortlandText "./Customization/Overrides/ShortlandClasses.fs" ShortlandClasses.view
    ]
