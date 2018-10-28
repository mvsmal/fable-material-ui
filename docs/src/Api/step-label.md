# StepLabel

<p class="description">The API documentation of the StepLabel React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.stepLabel (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">children</span> | <span class="prop-type">node</span> |   | In most cases will simply be a string containing a title for the label. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">HTMLAttr.Disabled</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Mark the step as disabled, will also disable the button if `StepLabelButton` is a child of `StepLabel`. Is passed to child components. |
| <span class="prop-name">error</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Mark the step as failed. |
| <span class="prop-name">icon</span> | <span class="prop-type">node</span> |   | Override the default icon. |
| <span class="prop-name">optional</span> | <span class="prop-type">node</span> |   | The optional node to display. |
| <span class="prop-name">StepIconComponent</span> | <span class="prop-type">union:&nbsp;string&nbsp;&#124;<br>&nbsp;func&nbsp;&#124;<br>&nbsp;object<br></span> |   | The component to render in place of the [`StepIcon`](#/api/step-icon). |
| <span class="prop-name">ChildrenProp.StepIconProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the [`StepIcon`](#/api/step-icon) element. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Horizontal</span> | Styles applied to the root element if `orientation="horiizontal".
| <span class="prop-name">ClassNames.Vertical</span> | Styles applied to the root element if `orientation="vertical".
| <span class="prop-name">ClassNames.Label</span> | Styles applied to the `Typography` component which wraps `children`.
| <span class="prop-name">ClassNames.Active</span> | Styles applied to the `Typography` component if `active={true}`.
| <span class="prop-name">ClassNames.Completed</span> | Styles applied to the `Typography` component if `completed={true}`.
| <span class="prop-name">ClassNames.Error</span> | Styles applied to the root element and `Typography` component if `error={true}`.
| <span class="prop-name">ClassNames.Disabled</span> | Styles applied to the root element and `Typography` component if `disabled={true}`.
| <span class="prop-name">ClassNames.IconContainer</span> | Styles applied to the `icon` container element.
| <span class="prop-name">ClassNames.AlternativeLabel</span> | Styles applied to the root & icon container and `Typography` if `alternativeLabel={true}`.
| <span class="prop-name">ClassNames.LabelContainer</span> | Styles applied to the container element which wraps `Typography` and `optional`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/StepLabel/StepLabel.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiStepLabel`.

## Demos

- [Steppers](/demos/steppers/)

