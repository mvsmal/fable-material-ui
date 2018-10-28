# InputAdornment

<p class="description">The API documentation of the InputAdornment React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.inputAdornment (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name required">children *</span> | <span class="prop-type">node</span> |   | The content of the component, normally an `IconButton` or string. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"div"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">disableTypography</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If children is a string then disable wrapping in a Typography component. |
| <span class="prop-name">position</span> | <span class="prop-type">enum:&nbsp;"start"&nbsp;&#124;<br>&nbsp;"end"<br></span> |   | The position this adornment should appear relative to the `Input`. |
| <span class="prop-name">variant</span> | <span class="prop-type">enum:&nbsp;"standard"&nbsp;&#124;<br>&nbsp;"outlined"&nbsp;&#124;<br>&nbsp;"filled"<br></span> |   | The variant to use. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Filled</span> | Styles applied to the root element if `variant="filled"`
| <span class="prop-name">ClassNames.PositionStart</span> | Styles applied to the root element if `position="start"`.
| <span class="prop-name">ClassNames.PositionEnd</span> | Styles applied to the root element if `position="end"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/InputAdornment/InputAdornment.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiInputAdornment`.

## Demos

- [Text Fields](/demos/text-fields/)

