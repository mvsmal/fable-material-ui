# Step

<p class="description">The API documentation of the Step React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.step (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Active</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Sets the step as active. Is passed to child components. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">HTMLAttr.Disabled</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Mark the step as disabled, will also disable the button if `StepButton` is a child of `Step`. Is passed to child components. |
| <span class="prop-name">StepProp.Completed</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Mark the step as completed. Is passed to child components. |

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
| <span class="prop-name">ClassNames.Completed</span> | Styles applied to the root element if `completed={true}`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Step/Step.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiStep`.

<!--## Demos-->

<!--- [Steppers](/demos/steppers/)-->

