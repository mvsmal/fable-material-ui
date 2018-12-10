# Divider

<p class="description">The API documentation of the Divider React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.divider (props : IHTMLProp list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"hr"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">MaterialProp.Inset</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the divider will be indented. |
| <span class="prop-name">DividerProp.Absolute</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> |  |
| <span class="prop-name">DividerProp.Light</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the divider will have a lighter color. |
| <span class="prop-name">DividerProp.Variant</span> | <span class="prop-type">type&nbsp;DividerVariant&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;FullWidth<br>&nbsp;&nbsp;&#124;&nbsp;Inset<br>&nbsp;&nbsp;&#124;&nbsp;Middle<br> | <span class="prop-default">DividerProp.FullWidth</span> | The variant to use. 

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Absolute</span> | Styles applied to the root element if `absolute={true}`.
| <span class="prop-name">ClassNames.Inset</span> | Styles applied to the root element if `inset={true}`.
| <span class="prop-name">ClassNames.Light</span> | Styles applied to the root element if `light={true}`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Divider/Divider.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiDivider`.

<!--## Demos-->

<!--- [Dividers](/demos/dividers/)-->
<!--- [Lists](/demos/lists/)-->

