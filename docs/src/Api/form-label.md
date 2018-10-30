# FormLabel

<p class="description">The API documentation of the FormLabel React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.formLabel (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"label"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">MaterialProp.Error</span> | <span class="prop-type">bool</span> |   | If `true`, the label should be displayed in an error state. |
| <span class="prop-name">HTMLAttr.Disabled</span> | <span class="prop-type">bool</span> |   | If `true`, the label should be displayed in a disabled state. |
| <span class="prop-name">HTMLAttr.Required</span> | <span class="prop-type">bool</span> |   | If `true`, the label will indicate that the input is required. |
| <span class="prop-name">FormLabelProp.Filled</span> | <span class="prop-type">bool</span> |   | If `true`, the label should use filled classes key. |
| <span class="prop-name">FormLabelProp.Focused</span> | <span class="prop-type">bool</span> |   | If `true`, the input of this label is focused (used by `FormGroup` components). |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Focused</span> | Styles applied to the root element if `focused={true}`.
| <span class="prop-name">ClassNames.Disabled</span> | Styles applied to the root element if `disabled={true}`.
| <span class="prop-name">ClassNames.Error</span> | Styles applied to the root element if `error={true}`.
| <span class="prop-name">ClassNames.Filled</span> | Styles applied to the root element if `filled={true}`.
| <span class="prop-name">ClassNames.Required</span> | Styles applied to the root element if `required={true}`.
| <span class="prop-name">ClassNames.Asterisk</span> | 

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/FormLabel/FormLabel.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiFormLabel`.

<!--## Demos-->

<!--- [Selection Controls](/demos/selection-controls/)-->

