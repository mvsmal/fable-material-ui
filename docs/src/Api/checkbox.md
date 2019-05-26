# Checkbox

<p class="description">The API documentation of the Checkbox React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.checkbox (props : seq<IHTMLProp>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Color</span> | <span class="prop-type">type&nbsp;ComponentColor&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Default<br>&nbsp;&nbsp;&#124;&nbsp;Primary<br>&nbsp;&nbsp;&#124;&nbsp;Secondary<br></span> | <span class="prop-default">ComponentColor.Secondary</span> | The color of the component. It supports those theme colors that make sense for this component. |
| <span class="prop-name">MaterialProp.CheckedIcon</span> | <span class="prop-type">ReactElement</span> | <span class="prop-default">&lt;CheckBoxIcon /></span> | The icon to display when the component is checked. |
| <span class="prop-name">MaterialProp.DisableRipple</span> | <span class="prop-type">bool</span> |   | If `true`, the ripple effect will be disabled. |
| <span class="prop-name">MaterialProp.Icon</span> | <span class="prop-type">ReactElement</span> | <span class="prop-default">&lt;CheckBoxOutlineBlankIcon /></span> | The icon to display when the component is unchecked. |
| <span class="prop-name">MaterialProp.InputProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the `input` element. |
| <span class="prop-name">MaterialProp.InputRef</span> | <span class="prop-type">type&nbsp;RefProp&lt;'T>&nbsp;=&nbsp;U2&lt;IRefValue&lt;'T>,&nbsp;(ReactElement&#8209;>unit)></span> |   | Use that property to pass a ref callback to the native input component. |
| <span class="prop-name">HTMLAttr.Id</span> | <span class="prop-type">string</span> |   | The id of the `input` element. |
| <span class="prop-name">HTMLAttr.Checked</span> | <span class="prop-type">bool</span> |   | If `true`, the component is checked. |
| <span class="prop-name">HTMLAttr.Disabled</span> | <span class="prop-type">bool</span> |   | If `true`, the switch will be disabled. |
| <span class="prop-name">HTMLAttr.Type</span> | <span class="prop-type">string</span> |   | The input component property `type`. |
| <span class="prop-name">HTMLAttr.Value</span> | <span class="prop-type">string</span> |   | The value of the component. |
| <span class="prop-name">CheckBoxProp.Indeterminate</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the component appears indeterminate. This does not set the native input element to indeterminate due to inconsistent behavior across browsers. However, we set a `data-indeterminate` attribute on the input. |
| <span class="prop-name">CheckBoxProp.IndeterminateIcon</span> | <span class="prop-type">ReactElement</span> | <span class="prop-default">&lt;IndeterminateCheckBoxIcon /></span> | The icon to display when the component is indeterminate. |
| <span class="prop-name">SelectionControlProp.OnChange</span> | <span class="prop-type">Event->bool->unit</span> |   | Callback fired when the state is changed.<br><br>**Signature:**<br>`(event: Event)->(checked: boolean)->unit`<br>*event:* The event source of the callback. You can pull out the new value by accessing `event.target.checked`.<br>*checked:* The `checked` value of the switch |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Checked</span> | Styles applied to the root element if `checked={true}`.
| <span class="prop-name">ClassNames.Disabled</span> | Styles applied to the root element if `disabled={true}`.
| <span class="prop-name">ClassNames.Indeterminate</span> | Styles applied to the root element if `indeterminate={true}`.
| <span class="prop-name">ClassNames.ColorPrimary</span> | Styles applied to the root element if `color="primary"`.
| <span class="prop-name">ClassNames.ColorSecondary</span> | Styles applied to the root element if `color="secondary"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Checkbox/Checkbox.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiCheckbox`.

<!--## Demos-->

<!--- [Selection Controls](/demos/selection-controls/)-->

