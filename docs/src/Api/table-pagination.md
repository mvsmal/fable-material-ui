# TablePagination

<p class="description">The API documentation of the TablePagination React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.tablePagination (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

A `TableCell` based component for placing inside `TableFooter` for pagination.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">ActionsComponent</span> | <span class="prop-type">union:&nbsp;string&nbsp;&#124;<br>&nbsp;func&nbsp;&#124;<br>&nbsp;object<br></span> | <span class="prop-default">TablePaginationActions</span> | The component used for displaying the actions. Either a string to use a DOM element or a component. |
| <span class="prop-name">backIconButtonProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the back arrow [`IconButton`](#/api/icon-button) component. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">TableCell</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name required">count *</span> | <span class="prop-type">number</span> |   | The total number of rows. |
| <span class="prop-name">labelDisplayedRows</span> | <span class="prop-type">func</span> | <span class="prop-default">({ from, to, count }) => `${from}-${to} of ${count}`</span> | Customize the displayed rows label. |
| <span class="prop-name">labelRowsPerPage</span> | <span class="prop-type">node</span> | <span class="prop-default">'Rows per page:'</span> | Customize the rows per page label. Invoked with a `{ from, to, count, page }` object. |
| <span class="prop-name">nextIconButtonProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the next arrow [`IconButton`](#/api/icon-button) element. |
| <span class="prop-name required">onChangePage *</span> | <span class="prop-type">func</span> |   | Callback fired when the page is changed.<br><br>**Signature:**<br>`function(event: object, page: number) => void`<br>*event:* The event source of the callback<br>*page:* The page selected |
| <span class="prop-name">onChangeRowsPerPage</span> | <span class="prop-type">func</span> |   | Callback fired when the number of rows per page is changed.<br><br>**Signature:**<br>`(event : obj) -> unit`<br>*event:* The event source of the callback |
| <span class="prop-name required">page *</span> | <span class="prop-type">number</span> |   | The zero-based index of the current page. |
| <span class="prop-name required">rowsPerPage *</span> | <span class="prop-type">number</span> |   | The number of rows per page. |
| <span class="prop-name">rowsPerPageOptions</span> | <span class="prop-type">array</span> | <span class="prop-default">[5, 10, 25]</span> | Customizes the options of the rows per page select field. If less than two options are available, no select field will be displayed. |
| <span class="prop-name">ChildrenProp.SelectProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the rows per page [`Select`](#/api/select) element. |

Any other properties supplied will be spread to the root element ([TableCell](#/api/table-cell)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Toolbar</span> | Styles applied to the Toolbar component.
| <span class="prop-name">ClassNames.Spacer</span> | Styles applied to the spacer element.
| <span class="prop-name">ClassNames.Caption</span> | Styles applied to the caption Typography components if `variant="caption"`.
| <span class="prop-name">ClassNames.SelectRoot</span> | Styles applied to the Select component `root` class.
| <span class="prop-name">ClassNames.Select</span> | Styles applied to the Select component `select` class.
| <span class="prop-name">ClassNames.SelectIcon</span> | Styles applied to the Select component `icon` class.
| <span class="prop-name">ClassNames.Input</span> | Styles applied to the `InputBase` component.
| <span class="prop-name">ClassNames.MenuItem</span> | Styles applied to the MenuItem component.
| <span class="prop-name">ClassNames.Actions</span> | Styles applied to the internal `TablePaginationActions` component.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/TablePagination/TablePagination.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiTablePagination`.

## Inheritance

The properties of the [TableCell](#/api/table-cell) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

## Demos

- [Tables](/demos/tables/)

