# Icon

<p class="description">The API documentation of the Icon React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.icon (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">children</span> | <span class="prop-type">node</span> |   | The name of the icon font ligature. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">color</span> | <span class="prop-type">enum:&nbsp;"inherit", "primary", "secondary", "action", "error", "disabled"<br></span> | <span class="prop-default">"inherit"</span> | The color of the component. It supports those theme colors that make sense for this component. |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"span"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">fontSize</span> | <span class="prop-type">enum:&nbsp;"inherit"&nbsp;&#124;<br>&nbsp;"default"&nbsp;&#124;<br>&nbsp;"small"&nbsp;&#124;<br>&nbsp;"large"<br></span> | <span class="prop-default">"default"</span> | The fontSize applied to the icon. Defaults to 24px, but can be configure to inherit font size. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.ColorPrimary</span> | Styles applied to the root element if `color="primary"`.
| <span class="prop-name">ClassNames.ColorSecondary</span> | Styles applied to the root element if `color="secondary"`.
| <span class="prop-name">ClassNames.ColorAction</span> | Styles applied to the root element if `color="action"`.
| <span class="prop-name">ClassNames.ColorError</span> | Styles applied to the root element if `color="error"`.
| <span class="prop-name">ClassNames.ColorDisabled</span> | Styles applied to the root element if `color="disabled"`.
| <span class="prop-name">ClassNames.&#96;&#96;FontSizeInherit&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.FontSizeSmall</span> | Styles applied to the root element if `fontSize="small"`.
| <span class="prop-name">ClassNames.FontSizeLarge</span> | Styles applied to the root element if `fontSize="large"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Icon/Icon.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiIcon`.

## Demos

- [Icons](/style/icons/)

