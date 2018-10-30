# TableCell

<p class="description">The API documentation of the TableCell React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.tableCell (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">children</span> | <span class="prop-type">node</span> |   | The table cell contents. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> |   | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">TableCellProp.Numeric</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, content will align to the right. |
| <span class="prop-name">TableCellProp.Padding</span> | <span class="prop-type">type&nbsp;TableCellPadding&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Default<br>&nbsp;&nbsp;&#124;&nbsp;Checkbox<br>&nbsp;&nbsp;&#124;&nbsp;Dense<br>&nbsp;&nbsp;&#124;&nbsp;None<br></span> |   | Sets the padding applied to the cell. By default, the Table parent component set the value. |
| <span class="prop-name">TableCellProp.Scope</span> | <span class="prop-type">string</span> |   | Set scope attribute. |
| <span class="prop-name">TableCellProp.SortDirection</span> | <span class="prop-type">type&nbsp;TableCellSortDirection&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Asc<br>&nbsp;&nbsp;&#124;&nbsp;Desc<br>&nbsp;&nbsp;&#124;&nbsp;False<br></span> |   | Set aria-sort direction. |
| <span class="prop-name">TableCellProp.Variant</span> | <span class="prop-type">type&nbsp;TableCellVariant&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Head<br>&nbsp;&nbsp;&#124;&nbsp;Body<br>&nbsp;&nbsp;&#124;&nbsp;Footer<br></span> |   | Specify the cell type. By default, the TableHead, TableBody or TableFooter parent component set the value. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Head</span> | Styles applied to the root element if `variant="head"` or `context.table.head`.
| <span class="prop-name">ClassNames.Body</span> | Styles applied to the root element if `variant="body"` or `context.table.body`.
| <span class="prop-name">ClassNames.Footer</span> | Styles applied to the root element if `variant="footer"` or `context.table.footer`.
| <span class="prop-name">ClassNames.Numeric</span> | Styles applied to the root element if `numeric={true}`.
| <span class="prop-name">ClassNames.PaddingDense</span> | Styles applied to the root element if `padding="dense"`.
| <span class="prop-name">ClassNames.PaddingCheckbox</span> | Styles applied to the root element if `padding="checkbox"`.
| <span class="prop-name">ClassNames.PaddingNone</span> | Styles applied to the root element if `padding="none"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/TableCell/TableCell.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiTableCell`.

<!--## Demos-->

<!--- [Tables](/demos/tables/)-->

