# NativeSelect

<p class="description">The API documentation of the NativeSelect React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.nativeSelect (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

An alternative to `<Select native />` with a much smaller bundle size footprint.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">children</span> | <span class="prop-type">node</span> |   | The option elements to populate the select with. Can be some `<option>` elements. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.InputProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Attributes applied to the `select` element. |
| <span class="prop-name">MaterialProp.Value</span> | <span class="prop-type">obj</span> |   | The input value. |
| <span class="prop-name">DOMAttr.OnChange</span> | <span class="prop-type">FormEvent->unit</span> |   | Callback function fired when a menu item is selected.<br><br>**Signature:**<br>`(event : FormEvent) -> unit`<br>*event:* The event source of the callback. You can pull out the new value by accessing `event.target.value`. |
| <span class="prop-name">NativeSelectProp.Input</span> | <span class="prop-type">ReactNode</span> | <span class="prop-default">&lt;Input /></span> | An `Input` element; does not have to be a material-ui specific `Input`. |
| <span class="prop-name">NativeSelectProp.Variant</span> | <span class="prop-type">type&nbsp;SelectVariant&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Standard<br>&nbsp;&nbsp;&#124;&nbsp;Outlined<br>&nbsp;&nbsp;&#124;&nbsp;Filled<br></span> |   | The variant to use. |
| <span class="prop-name">ChildrenProp.IconComponent</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">ArrowDropDownIcon</span> | The icon that displays the arrow. |

Any other properties supplied will be spread to the root element ([Input](#/api/input)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the `Input` component `root` class.
| <span class="prop-name">ClassNames.Select</span> | Styles applied to the `Input` component `select` class.
| <span class="prop-name">ClassNames.Filled</span> | Styles applied to the `Input` component if `variant="filled"`.
| <span class="prop-name">ClassNames.Outlined</span> | Styles applied to the `Input` component if `variant="outlined"`.
| <span class="prop-name">ClassNames.SelectMenu</span> | Styles applied to the `Input` component `selectMenu` class.
| <span class="prop-name">ClassNames.Disabled</span> | Styles applied to the `Input` component `disabled` class.
| <span class="prop-name">ClassNames.Icon</span> | Styles applied to the `Input` component `icon` class.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/NativeSelect/NativeSelect.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiNativeSelect`.

## Inheritance

The properties of the [Input](#/api/input) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [Selects](/demos/selects/)-->

