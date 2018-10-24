module Demos.Buttons.View

open Fable.Core.JsInterop
open Fable.Helpers.React

open Demos.Buttons
open Components

let text = importDefault "./Buttons.md"

let textButtonsText = """
## Text Buttons

[Text buttons](https://material.io/design/components/buttons.html#text-button)
are typically used for less-pronounced actions, including those located:

- In dialogs
- In cards

In cards, text buttons help maintain an emphasis on card content.
"""

let outlinedButtonsText = """
## Outlined Buttons

[Outlined buttons](https://material.io/design/components/buttons.html#outlined-button)
are medium-emphasis buttons. They contain actions that are important,
but aren’t the primary action in an app.

### Alternatives

Outlined buttons are also a lower emphasis alternative to contained buttons,
or a higher emphasis alternative to text buttons.
"""

let containedButtonsText = """
## Contained Buttons

[Contained buttons](https://material.io/design/components/buttons.html#contained-button)
are high-emphasis, distinguished by their use of elevation and fill.
They contain actions that are primary to your app.

The last example of this demo show how to use an upload button.
"""

let floatingButtonsText = """
## Floating Action Buttons

A [floating action button](https://material.io/design/components/buttons-floating-action-button.html)
(FAB) performs the primary, or most common, action on a screen.
It appears in front of all screen content, typically as a circular shape with an icon in its center.
FABs come in three types: regular, mini, and extended.

Only use a FAB if it is the most suitable way to present a screen’s primary action.

Only one floating action button is recommended per screen to represent the most common action.
"""

let floatingButtonZoomText = """
The floating action button animates onto the screen as an expanding piece of material, by default.

A floating action button that spans multiple lateral screens (such as tabbed screens) should briefly disappear,
then reappear if its action changes.

The Zoom transition can be used to achieve this. Note that since both the exiting and entering
animations are triggered at the same time, we use `enterDelay` to allow the outgoing Floating Action Button's
animation to finish before the new one enters.
"""

let buttonSizesText = """
## Sizes

Fancy larger or smaller buttons? Use the `ButtonProp.Size` or the `ButtonProp.Mini` property.
"""

let iconButtonsText = """
## Icon Buttons

Icon buttons are commonly found in app bars and toolbars.

Icons are also appropriate for toggle buttons that allow a single choice to be selected or
deselected, such as adding or removing a star to an item.
"""

let iconLabelButtonsText = """
### Buttons with icons and label

Sometimes you might want to have icons for certain button to enhance the UX of the application as we recognize logos more easily than plain text. For example, if you have a delete button you can label it with a dustbin icon.
"""

let customizedButtonsText = """
## Customized Buttons

If you have been reading the [overrides documentation page](#/customization/overrides)
but you are not confident jumping in,
here are examples of how you can change the main color of a Button using classes,
and using a theme; and of a Bootstrap style Button.
"""

let complexButtonsText = """
## Complex Buttons

The Text Buttons, Contained Buttons, Floating Action Buttons and Icon Buttons are built on top of the same component: the `ButtonBase`.
You can take advantage of this lower level component to build custom interactions.
"""

let view () =
    div [] [
        Markdown.view text
        Demo.view textButtonsText "./Demos/Buttons/TextButtons.fs" TextButtons.view
        Demo.view outlinedButtonsText "./Demos/Buttons/OutlinedButtons.fs" OutlinedButtons.view
        Demo.view containedButtonsText "./Demos/Buttons/ContainedButtons.fs" ContainedButtons.view
        Demo.view floatingButtonsText "./Demos/Buttons/FloatingActionButtons.fs" FloatingActionButtons.view
        Demo.view floatingButtonZoomText "./Demos/Buttons/FloatingActionButtonZoom.fs" FloatingActionButtonZoom.view
        Demo.view buttonSizesText "./Demos/Buttons/ButtonSizes.fs" ButtonSizes.view
        Demo.view iconButtonsText "./Demos/Buttons/IconButtons.fs" IconButtons.view
        Demo.view iconLabelButtonsText "./Demos/Buttons/IconLabelButtons.fs" IconLabelButtons.view
        Demo.view customizedButtonsText "./Demos/Buttons/CustomizedButtons.fs" CustomizedButtons.view
    ]
