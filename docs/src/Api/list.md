# List

<p class="description">The API documentation of the List React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.list (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactElementType</span> | <span class="prop-default">"ul"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">MaterialProp.Dense</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, compact vertical padding designed for keyboard and mouse input will be used for the list and list items. The property is available to descendant components as the `dense` context. |
| <span class="prop-name">ListProp.DisablePadding</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, vertical padding will be removed from the list. |
| <span class="prop-name">ListProp.Subheader</span> | <span class="prop-type">ReactElement</span> |   | The content of the subheader, normally `ListSubheader`. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Padding</span> | Styles applied to the root element if `disablePadding={false}`.
| <span class="prop-name">ClassNames.Dense</span> | Styles applied to the root element if `dense={true}` & `disablePadding={false}`.
| <span class="prop-name">ClassNames.Subheader</span> | Styles applied to the root element if a `subheader` is provided.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/List/List.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiList`.

<!--## Demos-->

<!--- [Lists](/demos/lists/)-->

