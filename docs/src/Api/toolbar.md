# Toolbar

<p class="description">The API documentation of the Toolbar React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.toolbar (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.DisableGutters</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, disables gutter padding. |
| <span class="prop-name">ToolbarProp.Variant</span> | <span class="prop-type">type&nbsp;ToolbarVariant&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Regular<br>&nbsp;&nbsp;&#124;&nbsp;Dense<br></span> | <span class="prop-default">ToolbarVariant.Regular</span> | The variant to use. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Gutters</span> | Styles applied to the root element if `disableGutters={false}`.
| <span class="prop-name">ClassNames.Regular</span> | Styles applied to the root element if `variant="regular"`.
| <span class="prop-name">ClassNames.Dense</span> | Styles applied to the root element if `variant="dense"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Toolbar/Toolbar.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiToolbar`.

<!--## Demos-->

<!--- [App Bar](/demos/app-bar/)-->

