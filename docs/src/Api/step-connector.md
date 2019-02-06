# StepConnector

<p class="description">The API documentation of the StepConnector React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.stepConnector (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Horizontal</span> | Styles applied to the root element if `orientation="horizontal"`.
| <span class="prop-name">ClassNames.Vertical</span> | Styles applied to the root element if `orientation="vertical"`.
| <span class="prop-name">ClassNames.AlternativeLabel</span> | Styles applied to the root element if `alternativeLabel={true}`.
| <span class="prop-name">ClassNames.Active</span> | Styles applied to the root element if `active={true}`.
| <span class="prop-name">ClassNames.Completed</span> | Styles applied to the root element if `completed={true}`.
| <span class="prop-name">ClassNames.Disabled</span> | Styles applied to the root element if `disabled={true}`.
| <span class="prop-name">ClassNames.Line</span> | Styles applied to the line element.
| <span class="prop-name">ClassNames.LineHorizontal</span> | Styles applied to the root element if `orientation="horizontal"`.
| <span class="prop-name">ClassNames.LineVertical</span> | Styles applied to the root element if `orientation="vertical"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/StepConnector/StepConnector.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiStepConnector`.

<!--## Demos-->

<!--- [Steppers](/demos/steppers/)-->

