# Badge

<p class="description">The API documentation of the Badge React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.badge (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name required">children *</span> | <span class="prop-type">node</span> |   | The badge will be added relative to this node. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"span"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name required">BadgeProp.BadgeContent *</span> | <span class="prop-type">ReactNode</span> |   | The content rendered within the badge. |
| <span class="prop-name">BadgeProp.Color</span> | <span class="prop-type">type&nbsp;BadgeColor&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Default<br>&nbsp;&nbsp;&#124;&nbsp;Primary<br>&nbsp;&nbsp;&#124;&nbsp;Secondary<br>&nbsp;&nbsp;&#124;&nbsp;Error<br></span> | <span class="prop-default">BadgeColor.Default</span> | The color of the component. It supports those theme colors that make sense for this component. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Badge</span> | Styles applied to the badge `span` element.
| <span class="prop-name">ClassNames.ColorPrimary</span> | Styles applied to the root element if `color="primary"`.
| <span class="prop-name">ClassNames.ColorSecondary</span> | Styles applied to the root element if `color="secondary"`.
| <span class="prop-name">ClassNames.ColorError</span> | Styles applied to the root element if `color="error"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Badge/Badge.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiBadge`.

<!--## Demos-->

<!--- [Badges](/demos/badges/)-->

