# Stepper

<p class="description">The API documentation of the Stepper React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.stepper (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">StepperProp.ActiveStep</span> | <span class="prop-type">int</span> | <span class="prop-default">0</span> | Set the active step (zero based index). |
| <span class="prop-name">StepperProp.AlternativeLabel</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If set to "true" and orientation is horizontal, then the step label will be positioned under the icon. |
| <span class="prop-name">StepperProp.Connector</span> | <span class="prop-type">ReactElement</span> | <span class="prop-default">&lt;StepConnector /></span> | A component to be placed between each step. |
| <span class="prop-name">StepperProp.NonLinear</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If set the `Stepper` will not assist in controlling steps for linear flow. |
| <span class="prop-name">StepperProp.Orientation</span> | <span class="prop-type">type&nbsp;StepperOrientation&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Vertical<br>&nbsp;&nbsp;&#124;&nbsp;Horizontal<br></span> | <span class="prop-default">Horizontal</span> | The stepper orientation (layout flow direction). |

Any other properties supplied will be spread to the root element ([Paper](#/api/paper)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Horizontal</span> | Styles applied to the root element if `orientation="horizontal"`.
| <span class="prop-name">ClassNames.Vertical</span> | Styles applied to the root element if `orientation="vertical"`.
| <span class="prop-name">ClassNames.AlternativeLabel</span> | Styles applied to the root element if `alternativeLabel={true}`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Stepper/Stepper.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiStepper`.

## Inheritance

The properties of the [Paper](#/api/paper) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [Steppers](/demos/steppers/)-->

