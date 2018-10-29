# TableSortLabel

<p class="description">The API documentation of the TableSortLabel React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.tableSortLabel (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

A button based label for placing inside `TableCell` for column sorting.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">children</span> | <span class="prop-type">node</span> |   | Label contents, the arrow will be appended automatically. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Active</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the label will have the active styling (should be true for the sorted column). |
| <span class="prop-name">TableSortLabelProp.Direction</span> | <span class="prop-type">type&nbsp;TableSortDirection&nbsp;=&nbsp;Asc&nbsp;&#124;&nbsp;Desc<br></span> | <span class="prop-default">Desc</span> | The current sort direction. |
| <span class="prop-name">TableSortLabelProp.HideSortIcon</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Hide sort icon when active is false. |
| <span class="prop-name">ChildrenProp.IconComponent</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">ArrowDownwardIcon</span> | Sort icon to use. |

Any other properties supplied will be spread to the root element ([ButtonBase](#/api/button-base)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Active</span> | Styles applied to the root element if `active={true}`.
| <span class="prop-name">ClassNames.Icon</span> | Styles applied to the icon component.
| <span class="prop-name">ClassNames.IconDirectionDesc</span> | Styles applied to the icon component if `direction="desc"`.
| <span class="prop-name">ClassNames.IconDirectionAsc</span> | Styles applied to the icon component if `direction="asc"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/TableSortLabel/TableSortLabel.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiTableSortLabel`.

## Inheritance

The properties of the [ButtonBase](#/api/button-base) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [Tables](/demos/tables/)-->

