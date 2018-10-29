# FormControl

<p class="description">The API documentation of the FormControl React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.formControl (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

Provides context such as filled/focused/error/required for form inputs.
Relying on the context provides high flexibilty and ensures that the state always stays
consistent across the children of the `FormControl`.
This context is used by the following components:
 - FormLabel
 - FormHelperText
 - Input
 - InputLabel

⚠️ Only one input can be used within a FormControl.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">children</span> | <span class="prop-type">node</span> |   | The contents of the form control. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"div"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">MaterialProp.Error</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the label should be displayed in an error state. |
| <span class="prop-name">MaterialProp.FullWidth</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the component will take up the full width of its container. |
| <span class="prop-name">MaterialProp.Margin</span> | <span class="prop-type">type&nbsp;FormControlMargin&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;None<br>&nbsp;&nbsp;&#124;&nbsp;Dense<br>&nbsp;&nbsp;&#124;&nbsp;Normal<br></span> | <span class="prop-default">FormControlMargin.None</span> | If `dense` or `normal`, will adjust vertical spacing of this and contained components. |
| <span class="prop-name">HTMLAttr.Disabled</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the label, input and helper text should be displayed in a disabled state. |
| <span class="prop-name">HTMLAttr.Required</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the label will indicate that the input is required. |
| <span class="prop-name">FormControlProp.Variant</span> | <span class="prop-type">type&nbsp;FormControlVariant&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Standard<br>&nbsp;&nbsp;&#124;&nbsp;Outlined<br>&nbsp;&nbsp;&#124;&nbsp;Filled<br></span> | <span class="prop-default">Standard</span> | The variant to use. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.MarginNormal</span> | Styles applied to the root element if `margin="normal"`.
| <span class="prop-name">ClassNames.MarginDense</span> | Styles applied to the root element if `margin="dense"`.
| <span class="prop-name">ClassNames.FullWidth</span> | Styles applied to the root element if `fullWidth={true}`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/FormControl/FormControl.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiFormControl`.

## Demos

<!--- [Selection Controls](/demos/selection-controls/)-->
- [Text Fields](#/demos/text-fields/)

