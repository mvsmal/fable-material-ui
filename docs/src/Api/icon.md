# Icon

<p class="description">The API documentation of the Icon React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.icon (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"span"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">IconProp.Color</span> | <span class="prop-type">type&nbsp;IconColor&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Inherit<br>&nbsp;&nbsp;&#124;&nbsp;Primary<br>&nbsp;&nbsp;&#124;&nbsp;Secondary<br>&nbsp;&nbsp;&#124;&nbsp;Action<br>&nbsp;&nbsp;&#124;&nbsp;Error<br>&nbsp;&nbsp;&#124;&nbsp;Disabled<br></span> | <span class="prop-default">IconColor.Inherit</span> | The color of the component. It supports those theme colors that make sense for this component. |
| <span class="prop-name">IconProp.FontSize</span> | <span class="prop-type">type&nbsp;IconFontSize&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Inherit<br>&nbsp;&nbsp;&#124;&nbsp;Default<br>&nbsp;&nbsp;&#124;&nbsp;Small<br>&nbsp;&nbsp;&#124;&nbsp;Large<br></span> | <span class="prop-default">IconFontSize.Default</span> | The fontSize applied to the icon. Defaults to 24px, but can be configure to inherit font size. |

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
| <span class="prop-name">ClassNames.FontSizeInherit</span> | Styles applied to the root element if `fontSize="inherit"`.
| <span class="prop-name">ClassNames.FontSizeSmall</span> | Styles applied to the root element if `fontSize="small"`.
| <span class="prop-name">ClassNames.FontSizeLarge</span> | Styles applied to the root element if `fontSize="large"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Icon/Icon.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiIcon`.

<!--## Demos-->

<!--- [Icons](/style/icons/)-->

