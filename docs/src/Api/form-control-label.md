# FormControlLabel

<p class="description">The API documentation of the FormControlLabel React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.formControlLabel (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

Drop in replacement of the `Radio`, `Switch` and `Checkbox` component.
Use this component if you want to display an extra label.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.InputRef</span> | <span class="prop-type">RefProp<br><br>type&nbsp;RefProp&nbsp;=&nbsp;U2&lt;obj,(ReactInstance&#8209;>unit)></span> |   | Use that property to pass a ref callback to the native input component. |
| <span class="prop-name">MaterialProp.Label</span> | <span class="prop-type">ReactNode</span> |   | The text to be used in an enclosing label element. |
| <span class="prop-name">HTMLAttr.Checked</span> | <span class="prop-type">bool</span> |   | If `true`, the component appears selected. |
| <span class="prop-name">HTMLAttr.Disabled</span> | <span class="prop-type">bool</span> |   | If `true`, the control will be disabled. |
| <span class="prop-name">HTMLAttr.Name</span> | <span class="prop-type">string</span> |   |  |
| <span class="prop-name">HTMLAttr.Value</span> | <span class="prop-type">string</span> |   | The value of the component. |
| <span class="prop-name">FormControlLabelProp.Control</span> | <span class="prop-type">ReactElement</span> |   | A control element. For instance, it can be be a `Radio`, a `Switch` or a `Checkbox`. |
| <span class="prop-name">FormControlLabelProp.LabelPlacement</span> | <span class="prop-type">type&nbsp;FormControlLabelPlacement&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;End<br>&nbsp;&nbsp;&#124;&nbsp;Start<br></span> | <span class="prop-default">End</span> | The position of the label. |
| <span class="prop-name">FormControlLabelProp.OnChange</span> | <span class="prop-type">obj->bool->unit</span> |   | Callback fired when the state is changed.<br><br>**Signature:**<br>`(event: object)->(checked: boolean)->unit`<br>*event:* The event source of the callback. You can pull out the new value by accessing `event.target.checked`.<br>*checked:* The `checked` value of the switch |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.LabelPlacementStart</span> | Styles applied to the root element if `labelPlacement="start"`.
| <span class="prop-name">ClassNames.Disabled</span> | Styles applied to the root element if `disabled={true}`.
| <span class="prop-name">ClassNames.Label</span> | Styles applied to the label's Typography component.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/FormControlLabel/FormControlLabel.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiFormControlLabel`.

<!--## Demos-->

<!--- [Selection Controls](/demos/selection-controls/)-->

