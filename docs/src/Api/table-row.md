# TableRow

<p class="description">The API documentation of the TableRow React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.tableRow (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```

Will automatically set dynamic row height
based on the material table element parent (head, body, etc).

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"tr"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">HTMLAttr.Selected</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the table row will have the selected shading. |
| <span class="prop-name">TableRowProp.Hover</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the table row will shade on hover. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Selected</span> | Styles applied to the root element if `selected={true}`.
| <span class="prop-name">ClassNames.Hover</span> | Styles applied to the root element if `hover={true}`.
| <span class="prop-name">ClassNames.Head</span> | Styles applied to the root element if table variant = "head".
| <span class="prop-name">ClassNames.Footer</span> | Styles applied to the root element if table variant = "footer".

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/TableRow/TableRow.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiTableRow`.

<!--## Demos-->

<!--- [Tables](/demos/tables/)-->

