# RadioGroup

<p class="description">The API documentation of the RadioGroup React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.radioGroup (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">children</span> | <span class="prop-type">node</span> |   | The content of the component. |
| <span class="prop-name">HTMLAttr.Name</span> | <span class="prop-type">string</span> |   | The name used to reference the value of the control. |
| <span class="prop-name">RadioGroupProp.OnChange</span> | <span class="prop-type">obj->string->unit</span> |   | Callback fired when a radio button is selected.<br><br>**Signature:**<br>`(event: obj) -> (value: string) -> unit`<br>*event:* The event source of the callback. You can pull out the new value by accessing `event.target.value`.<br>*value:* The `value` of the selected radio button |
| <span class="prop-name">MaterialProp.Value</span> | <span class="prop-type">obj</span> |   | Value of the selected radio button. |

Any other properties supplied will be spread to the root element ([FormGroup](#/api/form-group)).

## Inheritance

The properties of the [FormGroup](#/api/form-group) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [Selection Controls](/demos/selection-controls/)-->

