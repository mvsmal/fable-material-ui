# GridList

<p class="description">The API documentation of the GridList React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.gridList (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name required">children *</span> | <span class="prop-type">node</span> |   | Grid Tiles that will be in Grid List. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"ul"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">HTMLAttr.Cols</span> | <span class="prop-type">float</span> | <span class="prop-default">2</span> | Number of columns. |
| <span class="prop-name">GridListProp.CellHeight</span> | <span class="prop-type">U2&lt;int,&nbsp;AutoEnum&gt;<br>type&nbsp;AutoEnum&nbsp;=&nbsp;Auto<br></span> | <span class="prop-default">180</span> | Number of px for one cell height. You can set `AutoEnum.Auto` if you want to let the children determine the height. |
| <span class="prop-name">GridListProp.Spacing</span> | <span class="prop-type">int</span> | <span class="prop-default">4</span> | Number of px for the spacing between tiles. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/GridList/GridList.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiGridList`.

<!--## Demos-->

<!--- [Grid List](/demos/grid-list/)-->

