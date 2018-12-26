# FormHelperText

<p class="description">The API documentation of the FormHelperText React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.formHelperText (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"p"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">MaterialProp.Error</span> | <span class="prop-type">bool</span> |   | If `true`, helper text should be displayed in an error state. |
| <span class="prop-name">MaterialProp.Margin</span> | <span class="prop-type">type&nbsp;FormControlMargin&nbsp;=&nbsp;Dense<br></span> |   | If `Dense`, will adjust vertical spacing. This is normally obtained via context from FormControl. |
| <span class="prop-name">HTMLAttr.Disabled</span> | <span class="prop-type">bool</span> |   | If `true`, the helper text should be displayed in a disabled state. |
| <span class="prop-name">HTMLAttr.Required</span> | <span class="prop-type">bool</span> |   | If `true`, the helper text should use required classes key. |
| <span class="prop-name">FormHelperTextProp.Filled</span> | <span class="prop-type">bool</span> |   | If `true`, the helper text should use filled classes key. |
| <span class="prop-name">FormHelperTextProp.Variant</span> | <span class="prop-type">type&nbsp;FormHelperTextVariant&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Standard<br>&nbsp;&nbsp;&#124;&nbsp;Outlined<br>&nbsp;&nbsp;&#124;&nbsp;Filled<br></span> |   | The variant to use. |
| <span class="prop-name">FormHelperTextProp.Focused</span> | <span class="prop-type">bool</span> |   | If `true`, the helper text should use focused classes key. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Error</span> | Styles applied to the root element if `error={true}`.
| <span class="prop-name">ClassNames.Disabled</span> | Styles applied to the root element if `disabled={true}`.
| <span class="prop-name">ClassNames.MarginDense</span> | Styles applied to the root element if `margin="dense"`.
| <span class="prop-name">ClassNames.Contained</span> | Styles applied to the root element if `variant="filled"` or `variant="outlined"`.
| <span class="prop-name">ClassNames.Focused</span> | Styles applied to the root element if `focused={true}`.
| <span class="prop-name">ClassNames.Filled</span> | Styles applied to the root element if `filled={true}`.
| <span class="prop-name">ClassNames.Required</span> | Styles applied to the root element if `required={true}`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/FormHelperText/FormHelperText.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiFormHelperText`.

## Demos

- [Text Fields](#/demos/text-fields/)

