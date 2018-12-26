# TextField

<p class="description">The API documentation of the TextField React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.textField (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

The `TextField` is a convenience wrapper for the most common cases (80%).
It cannot be all things to all people, otherwise the API would grow out of control.

## Advanced Configuration

It's important to understand that the text field is a simple abstraction
on top of the following components:
- [FormControl](#/api/form-control)
- [InputLabel](#/api/input-label)
- [Input](#/api/input)
- [FormHelperText](#/api/form-helper-text)


## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.DefaultValue</span> | <span class="prop-type">obj</span> |   | The default value of the `Input` element. |
| <span class="prop-name">MaterialProp.Error</span> | <span class="prop-type">bool</span> |   | If `true`, the label will be displayed in an error state. |
| <span class="prop-name">MaterialProp.FullWidth</span> | <span class="prop-type">bool</span> |   | If `true`, the input will take up the full width of its container. |
| <span class="prop-name">MaterialProp.InputProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Attributes applied to the native `input` element. |
| <span class="prop-name">MaterialProp.InputRef</span> | <span class="prop-type">type&nbsp;RefProp&nbsp;=&nbsp;U2&lt;obj,(ReactInstance&#8209;>unit)></span> |   | Use that property to pass a ref callback to the native input component. |
| <span class="prop-name">MaterialProp.Label</span> | <span class="prop-type">ReactNode</span> |   | The label content. |
| <span class="prop-name">MaterialProp.Margin</span> | <span class="prop-type">type&nbsp;FormControlMargin&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;None<br>&nbsp;&nbsp;&#124;&nbsp;Dense<br>&nbsp;&nbsp;&#124;&nbsp;Normal<br></span> |   | If `dense` or `normal`, will adjust vertical spacing of this and contained components. |
| <span class="prop-name">MaterialProp.RowsMax</span> | <span class="prop-type">int</span> |   | Maximum number of rows to display when multiline option is set to true. |
| <span class="prop-name">MaterialProp.Value</span> | <span class="prop-type">obj</span> |   | The value of the `Input` element, required for a controlled component. |
| <span class="prop-name">HTMLAttr.AutoComplete</span> | <span class="prop-type">string</span> |   | This property helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it here: https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill |
| <span class="prop-name">HTMLAttr.AutoFocus</span> | <span class="prop-type">bool</span> |   | If `true`, the input will be focused during the first mount. |
| <span class="prop-name">HTMLAttr.Disabled</span> | <span class="prop-type">bool</span> |   | If `true`, the input will be disabled. |
| <span class="prop-name">HTMLAttr.Id</span> | <span class="prop-type">string</span> |   | The id of the `input` element. Use that property to make `label` and `helperText` accessible for screen readers. |
| <span class="prop-name">HTMLAttr.Multiline</span> | <span class="prop-type">bool</span> |   | If `true`, a textarea element will be rendered instead of an input. |
| <span class="prop-name">HTMLAttr.Name</span> | <span class="prop-type">string</span> |   | Name attribute of the `input` element. |
| <span class="prop-name">HTMLAttr.Placeholder</span> | <span class="prop-type">string</span> |   | The short hint displayed in the input before the user enters a value. |
| <span class="prop-name">HTMLAttr.Required</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the label is displayed as required and the input will be required. |
| <span class="prop-name">HTMLAttr.Rows</span> | <span class="prop-type">float</span> |   | Number of rows to display when multiline option is set to true. |
| <span class="prop-name">HTMLAttr.Type</span> | <span class="prop-type">string</span> |   | Type attribute of the `Input` element. It should be a valid HTML5 input type. |
| <span class="prop-name">DOMAttr.OnChange</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the value is changed.<br><br>**Signature:**<br>`(event : obj) -> unit`<br>*event:* The event source of the callback. You can pull out the new value by accessing `event.target.value`. |
| <span class="prop-name">TextFieldProp.HelperText</span> | <span class="prop-type">ReactNode</span> |   | The helper text content. |
| <span class="prop-name">TextFieldProp.Select</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Render a `Select` element while passing the `Input` element to `Select` as `input` parameter. If this option is set you must pass the options of the select as children. |
| <span class="prop-name">TextFieldProp.Variant</span> | <span class="prop-type">type&nbsp;TextFieldVariant&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Standard<br>&nbsp;&nbsp;&#124;&nbsp;Outlined<br>&nbsp;&nbsp;&#124;&nbsp;Filled<br></span> | <span class="prop-default">TextFieldVariant.Standard</span> | The variant to use. |
| <span class="prop-name">ChildrenProp.FormHelperTextProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the [`FormHelperText`](#/api/form-helper-text) element. |
| <span class="prop-name">ChildrenProp.InputLabelProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the [`InputLabel`](#/api/input-label) element. |
| <span class="prop-name">ChildrenProp.InputProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the `Input` element. |
| <span class="prop-name">ChildrenProp.SelectProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the [`Select`](#/api/select) element. |

Any other properties supplied will be spread to the root element ([FormControl](#/api/form-control)).

## Inheritance

The properties of the [FormControl](#/api/form-control) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

## Demos

<!--- [Autocomplete](/demos/autocomplete/)-->
<!--- [Pickers](/demos/pickers/)-->
- [Text Fields](/demos/text-fields/)

