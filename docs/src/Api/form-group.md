# FormGroup

<p class="description">The API documentation of the FormGroup React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.formGroup (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

`FormGroup` wraps controls such as `Checkbox` and `Switch`.
It provides compact row layout.
For the `Radio`, you should be using the `RadioGroup` component instead of this one.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">children</span> | <span class="prop-type">node</span> |   | The content of the component. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">FormGroupProp.Row</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Display group of elements in a compact row. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Row</span> | Styles applied to the root element if `row={true}`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/FormGroup/FormGroup.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiFormGroup`.

<!--## Demos-->

<!--- [Selection Controls](/demos/selection-controls/)-->

