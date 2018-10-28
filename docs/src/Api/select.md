# Select

<p class="description">The API documentation of the Select React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.select (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">autoWidth</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, the width of the popover will automatically be set according to the items inside the menu, otherwise it will be at least the width of the select input. |
| <span class="prop-name">children</span> | <span class="prop-type">node</span> |   | The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">displayEmpty</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the selected item is displayed even if its value is empty. You can only use it when the `native` property is `false` (default). |
| <span class="prop-name">IconComponent</span> | <span class="prop-type">union:&nbsp;string&nbsp;&#124;<br>&nbsp;func&nbsp;&#124;<br>&nbsp;object<br></span> | <span class="prop-default">ArrowDropDownIcon</span> | The icon that displays the arrow. |
| <span class="prop-name">input</span> | <span class="prop-type">element</span> | <span class="prop-default">&lt;Input /></span> | An `Input` element; does not have to be a material-ui specific `Input`. |
| <span class="prop-name">inputProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Attributes applied to the `input` element. When `native` is `true`, the attributes are applied on the `select` element. |
| <span class="prop-name">ChildrenProp.MenuProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the [`Menu`](#/api/menu) element. |
| <span class="prop-name">multiple</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, `value` must be an array and the menu will support multiple selections. You can only use it when the `native` property is `false` (default). |
| <span class="prop-name">native</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the component will be using a native `select` element. |
| <span class="prop-name">onChange</span> | <span class="prop-type">func</span> |   | Callback function fired when a menu item is selected.<br><br>**Signature:**<br>`function(event: object, child?: object) => void`<br>*event:* The event source of the callback. You can pull out the new value by accessing `event.target.value`.<br>*child:* The react element that was selected when `native` is `false` (default). |
| <span class="prop-name">onClose</span> | <span class="prop-type">func</span> |   | Callback fired when the component requests to be closed. Use in controlled mode (see open).<br><br>**Signature:**<br>`(event : obj) -> unit`<br>*event:* The event source of the callback |
| <span class="prop-name">onOpen</span> | <span class="prop-type">func</span> |   | Callback fired when the component requests to be opened. Use in controlled mode (see open).<br><br>**Signature:**<br>`(event : obj) -> unit`<br>*event:* The event source of the callback |
| <span class="prop-name">MaterialProp.Open</span> | <span class="prop-type">bool</span> |   | Control `select` open state. You can only use it when the `native` property is `false` (default). |
| <span class="prop-name">renderValue</span> | <span class="prop-type">func</span> |   | Render the selected value. You can only use it when the `native` property is `false` (default).<br><br>**Signature:**<br>`function(value: any) => ReactElement`<br>*value:* The `value` provided to the component. |
| <span class="prop-name">ChildrenProp.SelectDisplayProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the clickable div element. |
| <span class="prop-name">value</span> | <span class="prop-type">union:&nbsp;string&nbsp;&#124;<br>&nbsp;number&nbsp;&#124;<br>&nbsp;bool&nbsp;&#124;<br>&nbsp;arrayOf<br></span> |   | The input value. This property is required when the `native` property is `false` (default). |
| <span class="prop-name">variant</span> | <span class="prop-type">enum:&nbsp;"standard"&nbsp;&#124;<br>&nbsp;"outlined"&nbsp;&#124;<br>&nbsp;"filled"<br></span> |   | The variant to use. |

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
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Select/Select.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiSelect`.

## Inheritance

The properties of the [Input](#/api/input) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

## Demos

- [Selects](/demos/selects/)

