# StepButton

<p class="description">The API documentation of the StepButton React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.stepButton (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Icon</span> | <span class="prop-type">ReactNode</span> |   | The icon displayed by the step label. |
| <span class="prop-name">MaterialProp.Optional</span> | <span class="prop-type">ReactNode</span> |   | The optional node to display. |

Any other properties supplied will be spread to the root element ([ButtonBase](#/api/button-base)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Horizontal</span> | Styles applied to the root element if `orientation="horizontal"`.
| <span class="prop-name">ClassNames.Vertical</span> | Styles applied to the root element if `orientation="vertical"`.
| <span class="prop-name">ClassNames.TouchRipple</span> | Styles applied to the `ButtonBase` touch-ripple.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/StepButton/StepButton.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiStepButton`.

## Inheritance

The properties of the [ButtonBase](#/api/button-base) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [Steppers](/demos/steppers/)-->

