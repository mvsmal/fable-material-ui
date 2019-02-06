# ListItem

<p class="description">The API documentation of the ListItem React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.listItem (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> |   | The component used for the root node. Either a string to use a DOM element or a component. By default, it's a `li` when `Button` is `false` and a `div` when `Button` is `true`. |
| <span class="prop-name">MaterialProp.Dense</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, compact vertical padding designed for keyboard and mouse input will be used. |
| <span class="prop-name">MaterialProp.DisableGutters</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the left and right padding is removed. |
| <span class="prop-name">HTMLAttr.Selected</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Use to apply selected styling. |
| <span class="prop-name">HTMLAttr.Disabled</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the list item will be disabled. |
| <span class="prop-name">ListItemProp.Button</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the list item will be a button (using `ButtonBase`). |
| <span class="prop-name">ListItemProp.Divider</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, a 1px light border is added to the bottom of the list item. |
| <span class="prop-name">ChildrenProp.ContainerComponent</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"li"</span> | The container component used when a `ListItemSecondaryAction` is rendered. |
| <span class="prop-name">ChildrenProp.ContainerProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the container element when the component is used to display a `ListItemSecondaryAction`. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the (normally root) `component` element. May be wrapped by a `container`.
| <span class="prop-name">ClassNames.Container</span> | Styles applied to the `container` element if `children` includes `ListItemSecondaryAction`.
| <span class="prop-name">ClassNames.FocusVisible</span> | Styles applied to the `component`'s `focusVisibleClassName` property if `button={true}`.
| <span class="prop-name">ClassNames.Default</span> | Legacy styles applied to the root element. Use `root` instead.
| <span class="prop-name">ClassNames.Dense</span> | Styles applied to the `component` element if `dense={true}` or `children` includes `Avatar`.
| <span class="prop-name">ClassNames.Disabled</span> | Styles applied to the inner `component` element if `disabled={true}`.
| <span class="prop-name">ClassNames.Divider</span> | Styles applied to the inner `component` element if `divider={true}`.
| <span class="prop-name">ClassNames.Gutters</span> | Styles applied to the inner `component` element if `disableGutters={false}`.
| <span class="prop-name">ClassNames.Button</span> | Styles applied to the inner `component` element if `button={true}`.
| <span class="prop-name">ClassNames.SecondaryAction</span> | Styles applied to the `component` element if `children` includes `ListItemSecondaryAction`.
| <span class="prop-name">ClassNames.Selected</span> | Styles applied to the root element if `selected={true}`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/ListItem/ListItem.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiListItem`.

<!--## Demos-->

<!--- [Lists](/demos/lists/)-->

