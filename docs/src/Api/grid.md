# Grid

<p class="description">The API documentation of the Grid React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.grid (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">children</span> | <span class="prop-type">node</span> |   | The content of the component. |
| <span class="prop-name">alignContent</span> | <span class="prop-type">enum:&nbsp;"stretch", "center", "flex-start", "flex-end", "space-between", "space-around"<br></span> | <span class="prop-default">"stretch"</span> | Defines the `align-content` style property. It's applied for all screen sizes. |
| <span class="prop-name">alignItems</span> | <span class="prop-type">enum:&nbsp;"flex-start", "center", "flex-end", "stretch", "baseline"<br></span> | <span class="prop-default">"stretch"</span> | Defines the `align-items` style property. It's applied for all screen sizes. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"div"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">container</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the component will have the flex *container* behavior. You should be wrapping *items* with a *container*. |
| <span class="prop-name">direction</span> | <span class="prop-type">enum:&nbsp;"row"&nbsp;&#124;<br>&nbsp;"row-reverse"&nbsp;&#124;<br>&nbsp;"column"&nbsp;&#124;<br>&nbsp;"column-reverse"<br></span> | <span class="prop-default">"row"</span> | Defines the `flex-direction` style property. It is applied for all screen sizes. |
| <span class="prop-name">item</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the component will have the flex *item* behavior. You should be wrapping *items* with a *container*. |
| <span class="prop-name">justify</span> | <span class="prop-type">enum:&nbsp;"flex-start", "center", "flex-end", "space-between", "space-around", "space-evenly"<br></span> | <span class="prop-default">"flex-start"</span> | Defines the `justify-content` style property. It is applied for all screen sizes. |
| <span class="prop-name">lg</span> | <span class="prop-type">enum:&nbsp;false, "auto", true, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12<br></span> | <span class="prop-default">false</span> | Defines the number of grids the component is going to use. It's applied for the `lg` breakpoint and wider screens if not overridden. |
| <span class="prop-name">md</span> | <span class="prop-type">enum:&nbsp;false, "auto", true, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12<br></span> | <span class="prop-default">false</span> | Defines the number of grids the component is going to use. It's applied for the `md` breakpoint and wider screens if not overridden. |
| <span class="prop-name">sm</span> | <span class="prop-type">enum:&nbsp;false, "auto", true, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12<br></span> | <span class="prop-default">false</span> | Defines the number of grids the component is going to use. It's applied for the `sm` breakpoint and wider screens if not overridden. |
| <span class="prop-name">spacing</span> | <span class="prop-type">enum:&nbsp;0, 8, 16, 24, 32, 40<br></span> | <span class="prop-default">0</span> | Defines the space between the type `item` component. It can only be used on a type `container` component. |
| <span class="prop-name">wrap</span> | <span class="prop-type">enum:&nbsp;"nowrap"&nbsp;&#124;<br>&nbsp;"wrap"&nbsp;&#124;<br>&nbsp;"wrap-reverse"<br></span> | <span class="prop-default">"wrap"</span> | Defines the `flex-wrap` style property. It's applied for all screen sizes. |
| <span class="prop-name">xl</span> | <span class="prop-type">enum:&nbsp;false, "auto", true, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12<br></span> | <span class="prop-default">false</span> | Defines the number of grids the component is going to use. It's applied for the `xl` breakpoint and wider screens. |
| <span class="prop-name">xs</span> | <span class="prop-type">enum:&nbsp;false, "auto", true, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12<br></span> | <span class="prop-default">false</span> | Defines the number of grids the component is going to use. It's applied for all the screen sizes with the lowest priority. |
| <span class="prop-name">zeroMinWidth</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, it sets `min-width: 0` on the item. Refer to the limitations section of the documentation to better understand the use case. |

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

## Demos

- [Grid](/layout/grid/)

