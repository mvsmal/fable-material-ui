# Grid

<p class="description">The API documentation of the Grid React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.grid (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"div"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">GridProp.AlignContent</span> | <span class="prop-type">type&nbsp;GridAlignContent&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Stretch<br>&nbsp;&nbsp;&#124;&nbsp;Center<br>&nbsp;&nbsp;&#124;&nbsp;FlexStart<br>&nbsp;&nbsp;&#124;&nbsp;FlexEnd<br>&nbsp;&nbsp;&#124;&nbsp;SpaceBetween<br>&nbsp;&nbsp;&#124;&nbsp;SpaceAround<br></span> | <span class="prop-default">GridAlignContent.Stretch</span> | Defines the `align-content` style property. It's applied for all screen sizes. |
| <span class="prop-name">GridProp.AlignItems</span> | <span class="prop-type">type&nbsp;GridAlignItems&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Stretch<br>&nbsp;&nbsp;&#124;&nbsp;Center<br>&nbsp;&nbsp;&#124;&nbsp;BaseLine<br>&nbsp;&nbsp;&#124;&nbsp;FlexStart<br>&nbsp;&nbsp;&#124;&nbsp;FlexEnd<br></span> | <span class="prop-default">GridAlignItems.Stretch</span> | Defines the `align-items` style property. It's applied for all screen sizes. |
| <span class="prop-name">GridProp.Container</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the component will have the flex *container* behavior. You should be wrapping *items* with a *container*. |
| <span class="prop-name">GridProp.Direction</span> | <span class="prop-type">type&nbsp;GridDirection&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Row<br>&nbsp;&nbsp;&#124;&nbsp;Column<br>&nbsp;&nbsp;&#124;&nbsp;RowReverse<br>&nbsp;&nbsp;&#124;&nbsp;ColumnReverse<br></span> | <span class="prop-default">GridDirection.Row</span> | Defines the `flex-direction` style property. It is applied for all screen sizes. |
| <span class="prop-name">GridProp.Item</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the component will have the flex *item* behavior. You should be wrapping *items* with a *container*. |
| <span class="prop-name">GridProp.Justify</span> | <span class="prop-type">type&nbsp;GridJustify&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Center<br>&nbsp;&nbsp;&#124;&nbsp;FlexStart<br>&nbsp;&nbsp;&#124;&nbsp;FlexEnd<br>&nbsp;&nbsp;&#124;&nbsp;SpaceBetween<br>&nbsp;&nbsp;&#124;&nbsp;SpaceAround<br>&nbsp;&nbsp;&#124;&nbsp;SpaceEvenly<br></span> | <span class="prop-default">GridJustify.FlexStart</span> | Defines the `justify-content` style property. It is applied for all screen sizes. |
| <span class="prop-name">GridProp.Lg</span> | <span class="prop-type">type&nbsp;GridSize&nbsp;=&nbsp;U3&lt;bool,&nbsp;AutoEnum,&nbsp;GridSizeNum&gt;<br><br>type&nbsp;GridSizeNum&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;1&#96;&#96;&nbsp;=&nbsp;1<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;2&#96;&#96;&nbsp;=&nbsp;2<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;3&#96;&#96;&nbsp;=&nbsp;3<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;4&#96;&#96;&nbsp;=&nbsp;4<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;5&#96;&#96;&nbsp;=&nbsp;5<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;6&#96;&#96;&nbsp;=&nbsp;6<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;7&#96;&#96;&nbsp;=&nbsp;7<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;8&#96;&#96;&nbsp;=&nbsp;8<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;9&#96;&#96;&nbsp;=&nbsp;9<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;10&#96;&#96;&nbsp;=&nbsp;10<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;11&#96;&#96;&nbsp;=&nbsp;11<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;12&#96;&#96;&nbsp;=&nbsp;12<br></span> | <span class="prop-default">false</span> | Defines the number of grids the component is going to use. It's applied for the `lg` breakpoint and wider screens if not overridden. |
| <span class="prop-name">GridProp.Md</span> | <span class="prop-type">type&nbsp;GridSize&nbsp;=&nbsp;U3&lt;bool,&nbsp;AutoEnum,&nbsp;GridSizeNum&gt;<br><br>type&nbsp;GridSizeNum&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;1&#96;&#96;&nbsp;=&nbsp;1<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;2&#96;&#96;&nbsp;=&nbsp;2<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;3&#96;&#96;&nbsp;=&nbsp;3<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;4&#96;&#96;&nbsp;=&nbsp;4<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;5&#96;&#96;&nbsp;=&nbsp;5<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;6&#96;&#96;&nbsp;=&nbsp;6<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;7&#96;&#96;&nbsp;=&nbsp;7<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;8&#96;&#96;&nbsp;=&nbsp;8<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;9&#96;&#96;&nbsp;=&nbsp;9<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;10&#96;&#96;&nbsp;=&nbsp;10<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;11&#96;&#96;&nbsp;=&nbsp;11<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;12&#96;&#96;&nbsp;=&nbsp;12<br></span> | <span class="prop-default">false</span> | Defines the number of grids the component is going to use. It's applied for the `md` breakpoint and wider screens if not overridden. |
| <span class="prop-name">GridProp.Sm</span> | <span class="prop-type">type&nbsp;GridSize&nbsp;=&nbsp;U3&lt;bool,&nbsp;AutoEnum,&nbsp;GridSizeNum&gt;<br><br>type&nbsp;GridSizeNum&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;1&#96;&#96;&nbsp;=&nbsp;1<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;2&#96;&#96;&nbsp;=&nbsp;2<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;3&#96;&#96;&nbsp;=&nbsp;3<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;4&#96;&#96;&nbsp;=&nbsp;4<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;5&#96;&#96;&nbsp;=&nbsp;5<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;6&#96;&#96;&nbsp;=&nbsp;6<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;7&#96;&#96;&nbsp;=&nbsp;7<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;8&#96;&#96;&nbsp;=&nbsp;8<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;9&#96;&#96;&nbsp;=&nbsp;9<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;10&#96;&#96;&nbsp;=&nbsp;10<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;11&#96;&#96;&nbsp;=&nbsp;11<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;12&#96;&#96;&nbsp;=&nbsp;12<br></span> | <span class="prop-default">false</span> | Defines the number of grids the component is going to use. It's applied for the `sm` breakpoint and wider screens if not overridden. |
| <span class="prop-name">GridProp.Spacing</span> | <span class="prop-type">type&nbsp;GridSpacing&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;0&#96;&#96;&nbsp;=&nbsp;0<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;8&#96;&#96;&nbsp;=&nbsp;8<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;16&#96;&#96;&nbsp;=&nbsp;16<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;24&#96;&#96;&nbsp;=&nbsp;24<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;32&#96;&#96;&nbsp;=&nbsp;32<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;40&#96;&#96;&nbsp;=&nbsp;40<br></span> | <span class="prop-default">0</span> | Defines the space between the type `item` component. It can only be used on a type `container` component. |
| <span class="prop-name">GridProp.Wrap</span> | <span class="prop-type">type&nbsp;GridWrap&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Nowrap<br>&nbsp;&nbsp;&#124;&nbsp;Wrap<br>&nbsp;&nbsp;&#124;&nbsp;WrapReverse<br></span> | <span class="prop-default">GridWrap.Wrap</span> | Defines the `flex-wrap` style property. It's applied for all screen sizes. |
| <span class="prop-name">GridProp.Xl</span> | <span class="prop-type">type&nbsp;GridSize&nbsp;=&nbsp;U3&lt;bool,&nbsp;AutoEnum,&nbsp;GridSizeNum&gt;<br><br>type&nbsp;GridSizeNum&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;1&#96;&#96;&nbsp;=&nbsp;1<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;2&#96;&#96;&nbsp;=&nbsp;2<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;3&#96;&#96;&nbsp;=&nbsp;3<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;4&#96;&#96;&nbsp;=&nbsp;4<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;5&#96;&#96;&nbsp;=&nbsp;5<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;6&#96;&#96;&nbsp;=&nbsp;6<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;7&#96;&#96;&nbsp;=&nbsp;7<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;8&#96;&#96;&nbsp;=&nbsp;8<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;9&#96;&#96;&nbsp;=&nbsp;9<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;10&#96;&#96;&nbsp;=&nbsp;10<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;11&#96;&#96;&nbsp;=&nbsp;11<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;12&#96;&#96;&nbsp;=&nbsp;12<br></span> | <span class="prop-default">false</span> | Defines the number of grids the component is going to use. It's applied for the `xl` breakpoint and wider screens. |
| <span class="prop-name">GridProp.Xs</span> | <span class="prop-type">type&nbsp;GridSize&nbsp;=&nbsp;U3&lt;bool,&nbsp;AutoEnum,&nbsp;GridSizeNum&gt;<br><br>type&nbsp;GridSizeNum&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;1&#96;&#96;&nbsp;=&nbsp;1<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;2&#96;&#96;&nbsp;=&nbsp;2<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;3&#96;&#96;&nbsp;=&nbsp;3<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;4&#96;&#96;&nbsp;=&nbsp;4<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;5&#96;&#96;&nbsp;=&nbsp;5<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;6&#96;&#96;&nbsp;=&nbsp;6<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;7&#96;&#96;&nbsp;=&nbsp;7<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;8&#96;&#96;&nbsp;=&nbsp;8<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;9&#96;&#96;&nbsp;=&nbsp;9<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;10&#96;&#96;&nbsp;=&nbsp;10<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;11&#96;&#96;&nbsp;=&nbsp;11<br>&nbsp;&nbsp;&#124;&nbsp;&#96;&#96;12&#96;&#96;&nbsp;=&nbsp;12<br></span> | <span class="prop-default">false</span> | Defines the number of grids the component is going to use. It's applied for all the screen sizes with the lowest priority. |
| <span class="prop-name">GridProp.ZeroMinWidth</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, it sets `min-width: 0` on the item. Refer to the limitations section of the documentation to better understand the use case. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Container</span> | Styles applied to the root element if `container={true}`.
| <span class="prop-name">ClassNames.Item</span> | Styles applied to the root element if `item={true}`.
| <span class="prop-name">ClassNames.ZeroMinWidth</span> | Styles applied to the root element if `zeroMinWidth={true}`.
| <span class="prop-name">ClassNames.&#96;&#96;Direction-xs-column&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Direction-xs-column-reverse&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Direction-xs-row-reverse&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Wrap-xs-nowrap&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Wrap-xs-wrap-reverse&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Align-items-xs-center&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Align-items-xs-flex-start&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Align-items-xs-flex-end&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Align-items-xs-baseline&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Align-content-xs-center&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Align-content-xs-flex-start&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Align-content-xs-flex-end&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Align-content-xs-space-between&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Align-content-xs-space-around&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Justify-xs-center&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Justify-xs-flex-end&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Justify-xs-space-between&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Justify-xs-space-around&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Justify-xs-space-evenly&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Spacing-xs-8&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Spacing-xs-16&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Spacing-xs-24&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Spacing-xs-32&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Spacing-xs-40&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Grid-xs-auto&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Grid-xs-true&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Grid-xs-1&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Grid-xs-2&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Grid-xs-3&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Grid-xs-4&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Grid-xs-5&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Grid-xs-6&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Grid-xs-7&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Grid-xs-8&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Grid-xs-9&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Grid-xs-10&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Grid-xs-11&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Grid-xs-12&#96;&#96;</span> | 

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Grid/Grid.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiGrid`.

<!--## Demos-->

<!--- [Grid](/layout/grid/)-->

