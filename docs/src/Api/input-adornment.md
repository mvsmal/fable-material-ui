# InputAdornment

<p class="description">The API documentation of the InputAdornment React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.inputAdornment (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactElementType</span> | <span class="prop-default">"div"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">MaterialProp.DisableTypography</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If children is a string then disable wrapping in a Typography component. |
| <span class="prop-name">InputAdornmentProp.DisablePointerEvents</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Disable pointer events on the root. This allows for the content of the adornment to focus the input on click. |
| <span class="prop-name">InputAdornmentProp.Position</span> | <span class="prop-type">type&nbsp;InputAdornmentPosition&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Start<br>&nbsp;&nbsp;&#124;&nbsp;End<br></span> |   | The position this adornment should appear relative to the `Input`. |
| <span class="prop-name">InputAdornmentProp.Variant</span> | <span class="prop-type">type&nbsp;InputAdornmentVariant&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Standard<br>&nbsp;&nbsp;&#124;&nbsp;Outlined<br>&nbsp;&nbsp;&#124;&nbsp;Filled<br></span> |   | The variant to use. |

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
| <span class="prop-name">ClassNames.DisablePointerEvents</span> | Styles applied to the root element if `disablePointerEvents=true`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/InputAdornment/InputAdornment.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiInputAdornment`.

## Demos

- [Text Fields](/demos/text-fields/)

