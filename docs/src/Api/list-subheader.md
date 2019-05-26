# ListSubheader

<p class="description">The API documentation of the ListSubheader React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.listSubheader (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactElementType</span> | <span class="prop-default">"li"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">MaterialProp.DisableGutters</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the List Subheader will not have gutters. |
| <span class="prop-name">MaterialProp.Inset</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the List Subheader will be indented. |
| <span class="prop-name">ListSubheaderProp.Color</span> | <span class="prop-type">type&nbsp;ListSubheaderColor&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Default<br>&nbsp;&nbsp;&#124;&nbsp;Primary<br>&nbsp;&nbsp;&#124;&nbsp;Inherit<br></span> | <span class="prop-default">ListSubheaderColor.Default</span> | The color of the component. It supports those theme colors that make sense for this component. |
| <span class="prop-name">ListSubheaderProp.DisableSticky</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the List Subheader will not stick to the top during scroll. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.ColorPrimary</span> | Styles applied to the root element if `color="primary"`.
| <span class="prop-name">ClassNames.ColorInherit</span> | Styles applied to the root element if `color="inherit"`.
| <span class="prop-name">ClassNames.Gutters</span> | Styles applied to the inner `component` element if `disableGutters={false}`.
| <span class="prop-name">ClassNames.Inset</span> | Styles applied to the root element if `inset={true}`.
| <span class="prop-name">ClassNames.Sticky</span> | Styles applied to the root element if `disableSticky={false}`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/ListSubheader/ListSubheader.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiListSubheader`.

<!--## Demos-->

<!--- [Grid List](/demos/grid-list/)-->
<!--- [Lists](/demos/lists/)-->

