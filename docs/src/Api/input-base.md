# InputBase

<p class="description">The API documentation of the InputBase React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.inputBase (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

`InputBase` contains as few styles as possible.
It aims to be a simple building block for creating an input.
It contains a load of style reset and some state logic.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.DefaultValue</span> | <span class="prop-type">obj</span> |   | The default input value, useful when not controlling the component. |
| <span class="prop-name">MaterialProp.Error</span> | <span class="prop-type">bool</span> |   | If `true`, the input will indicate an error. This is normally obtained via context from FormControl. |
| <span class="prop-name">MaterialProp.FullWidth</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the input will take up the full width of its container. |
| <span class="prop-name">MaterialProp.InputProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Attributes applied to the `input` element. |
| <span class="prop-name">MaterialProp.InputRef</span> | <span class="prop-type">type&nbsp;RefProp&nbsp;=&nbsp;U2&lt;obj,(ReactInstance&#8209;>unit)></span> |   | Use that property to pass a ref callback to the native input component. |
| <span class="prop-name">MaterialProp.Margin</span> | <span class="prop-type">type&nbsp;FormControlMargin&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;None<br>&nbsp;&nbsp;&#124;&nbsp;Dense<br>&nbsp;&nbsp;&#124;&nbsp;Normal<br></span> |   | If `Dense`, will adjust vertical spacing. This is normally obtained via context from FormControl. |
| <span class="prop-name">MaterialProp.RowsMax</span> | <span class="prop-type">int</span> |   | Maximum number of rows to display when multiline option is set to true. |
| <span class="prop-name">MaterialProp.Value</span> | <span class="prop-type">obj</span> |   | The input value, required for a controlled component. |
| <span class="prop-name">HTMLAttr.AutoComplete</span> | <span class="prop-type">string</span> |   | This property helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it here: https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill |
| <span class="prop-name">HTMLAttr.AutoFocus</span> | <span class="prop-type">bool</span> |   | If `true`, the input will be focused during the first mount. |
| <span class="prop-name">HTMLAttr.ClassName</span> | <span class="prop-type">string</span> |   | The CSS class name of the wrapper element. |
| <span class="prop-name">HTMLAttr.Disabled</span> | <span class="prop-type">bool</span> |   | If `true`, the input will be disabled. |
| <span class="prop-name">HTMLAttr.Id</span> | <span class="prop-type">string</span> |   | The id of the `input` element. |
| <span class="prop-name">HTMLAttr.Multiline</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, a textarea element will be rendered. |
| <span class="prop-name">HTMLAttr.Name</span> | <span class="prop-type">string</span> |   | Name attribute of the `input` element. |
| <span class="prop-name">HTMLAttr.Placeholder</span> | <span class="prop-type">string</span> |   | The short hint displayed in the input before the user enters a value. |
| <span class="prop-name">HTMLAttr.ReadOnly</span> | <span class="prop-type">bool</span> |   | It prevents the user from changing the value of the field (not from interacting with the field). |
| <span class="prop-name">HTMLAttr.Required</span> | <span class="prop-type">bool</span> |   | If `true`, the input will be required. |
| <span class="prop-name">HTMLAttr.Rows</span> | <span class="prop-type">float</span> |   | Number of rows to display when multiline option is set to true. |
| <span class="prop-name">HTMLAttr.Type</span> | <span class="prop-type">string</span> | <span class="prop-default">"text"</span> | Type of the input element. It should be a valid HTML5 input type. |
| <span class="prop-name">DOMAttr.OnChange</span> | <span class="prop-type">FormEvent->unit</span> |   | Callback fired when the value is changed.<br><br>**Signature:**<br>`(event : FormEvent) -> unit`<br>*event:* The event source of the callback. You can pull out the new value by accessing `event.target.value`. |
| <span class="prop-name">InputBaseProp.StartAdornment</span> | <span class="prop-type">ReactNode</span> |   | Start `InputAdornment` for this component. |
| <span class="prop-name">InputBaseProp.EndAdornment</span> | <span class="prop-type">ReactNode</span> |   | End `InputAdornment` for this component. |
| <span class="prop-name">InputBaseProp.InputComponent</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"input"</span> | The component used for the native input. Either a string to use a DOM element or a component. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.FormControl</span> | Styles applied to the root element if the component is a descendant of `FormControl`.
| <span class="prop-name">ClassNames.Focused</span> | Styles applied to the root element if the component is focused.
| <span class="prop-name">ClassNames.Disabled</span> | Styles applied to the root element if `disabled={true}`.
| <span class="prop-name">ClassNames.AdornedStart</span> | Styles applied to the root element if `startAdornment` is provided.
| <span class="prop-name">ClassNames.AdornedEnd</span> | Styles applied to the root element if `endAdornment` is provided.
| <span class="prop-name">ClassNames.Error</span> | Styles applied to the root element if `error={true}`.
| <span class="prop-name">ClassNames.MarginDense</span> | Styles applied to the `input` element if `margin="dense"`.
| <span class="prop-name">ClassNames.Multiline</span> | Styles applied to the root element if `multiline={true}`.
| <span class="prop-name">ClassNames.FullWidth</span> | Styles applied to the root element if `fullWidth={true}`.
| <span class="prop-name">ClassNames.Input</span> | Styles applied to the `input` element.
| <span class="prop-name">ClassNames.InputMarginDense</span> | Styles applied to the `input` element if `margin="dense"`.
| <span class="prop-name">ClassNames.InputMultiline</span> | Styles applied to the `input` element if `multiline={true}`.
| <span class="prop-name">ClassNames.InputType</span> | Styles applied to the `input` element if `type` is not "text"`.
| <span class="prop-name">ClassNames.InputTypeSearch</span> | Styles applied to the `input` element if `type="search"`.
| <span class="prop-name">ClassNames.InputAdornedStart</span> | Styles applied to the `input` element if `startAdornment` is provided.
| <span class="prop-name">ClassNames.InputAdornedEnd</span> | Styles applied to the `input` element if `endAdornment` is provided.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/InputBase/InputBase.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiInputBase`.

## Demos

- [Text Fields](/demos/text-fields/)

