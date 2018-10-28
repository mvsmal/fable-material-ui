# Switch

<p class="description">The API documentation of the Switch React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.switch (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">checked</span> | <span class="prop-type">union:&nbsp;bool&nbsp;&#124;<br>&nbsp;string<br></span> |   | If `true`, the component is checked. |
| <span class="prop-name">checkedIcon</span> | <span class="prop-type">node</span> |   | The icon to display when the component is checked. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">color</span> | <span class="prop-type">enum:&nbsp;"primary"&nbsp;&#124;<br>&nbsp;"secondary"&nbsp;&#124;<br>&nbsp;"default"<br></span> | <span class="prop-default">"secondary"</span> | The color of the component. It supports those theme colors that make sense for this component. |
| <span class="prop-name">HTMLAttr.Disabled</span> | <span class="prop-type">bool</span> |   | If `true`, the switch will be disabled. |
| <span class="prop-name">disableRipple</span> | <span class="prop-type">bool</span> |   | If `true`, the ripple effect will be disabled. |
| <span class="prop-name">icon</span> | <span class="prop-type">node</span> |   | The icon to display when the component is unchecked. |
| <span class="prop-name">HTMLAttr.Id</span> | <span class="prop-type">string</span> |   | The id of the `input` element. |
| <span class="prop-name">inputProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Attributes applied to the `input` element. |
| <span class="prop-name">inputRef</span> | <span class="prop-type">union:&nbsp;func&nbsp;&#124;<br>&nbsp;object<br></span> |   | Use that property to pass a ref callback to the native input component. |
| <span class="prop-name">onChange</span> | <span class="prop-type">func</span> |   | Callback fired when the state is changed.<br><br>**Signature:**<br>`function(event: object, checked: boolean) => void`<br>*event:* The event source of the callback. You can pull out the new value by accessing `event.target.checked`.<br>*checked:* The `checked` value of the switch |
| <span class="prop-name">type</span> | <span class="prop-type">string</span> |   | The input component property `type`. |
| <span class="prop-name">value</span> | <span class="prop-type">union:&nbsp;string&nbsp;&#124;<br>&nbsp;number&nbsp;&#124;<br>&nbsp;bool<br></span> |   | The value of the component. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Icon</span> | Styles used to create the `icon` passed to the internal `SwitchBase` component `icon` prop.
| <span class="prop-name">ClassNames.IconChecked</span> | Styles applied the icon element component if `checked={true}`.
| <span class="prop-name">ClassNames.SwitchBase</span> | Styles applied to the internal `SwitchBase` component's `root` class.
| <span class="prop-name">ClassNames.Checked</span> | Styles applied to the internal `SwitchBase` component's `checked` class.
| <span class="prop-name">ClassNames.ColorPrimary</span> | Styles applied to the internal SwitchBase component's root element if `color="primary"`.
| <span class="prop-name">ClassNames.ColorSecondary</span> | Styles applied to the internal SwitchBase component's root element if `color="secondary"`.
| <span class="prop-name">ClassNames.Disabled</span> | Styles applied to the internal SwitchBase component's disabled class.
| <span class="prop-name">ClassNames.Bar</span> | Styles applied to the bar element.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Switch/Switch.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiSwitch`.

## Demos

- [Selection Controls](/demos/selection-controls/)

