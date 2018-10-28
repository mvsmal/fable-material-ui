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
| <span class="prop-name">numeric</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, content will align to the right. |
| <span class="prop-name">padding</span> | <span class="prop-type">enum:&nbsp;"default"&nbsp;&#124;<br>&nbsp;"checkbox"&nbsp;&#124;<br>&nbsp;"dense"&nbsp;&#124;<br>&nbsp;"none"<br></span> |   | Sets the padding applied to the cell. By default, the Table parent component set the value. |
| <span class="prop-name">scope</span> | <span class="prop-type">string</span> |   | Set scope attribute. |
| <span class="prop-name">sortDirection</span> | <span class="prop-type">enum:&nbsp;"asc"&nbsp;&#124;<br>&nbsp;"desc"&nbsp;&#124;<br>&nbsp;false<br></span> |   | Set aria-sort direction. |
| <span class="prop-name">variant</span> | <span class="prop-type">enum:&nbsp;"head"&nbsp;&#124;<br>&nbsp;"body"&nbsp;&#124;<br>&nbsp;"footer"<br></span> |   | Specify the cell type. By default, the TableHead, TableBody or TableFooter parent component set the value. |

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

## Demos

- [Tables](/demos/tables/)

