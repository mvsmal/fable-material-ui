# ListItemText

<p class="description">The API documentation of the ListItemText React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.listItemText (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.DisableTypography</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the children won't be wrapped by a Typography component. This can be useful to render an alternative Typography variant by wrapping the `children` (or `primary`) text, and optional `secondary` text with the Typography component. |
| <span class="prop-name">MaterialProp.Inset</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the children will be indented. This should be used if there is no left avatar or left icon. |
| <span class="prop-name">ListItemTextProp.Primary</span> | <span class="prop-type">ReactNode</span> |   | The main content element. |
| <span class="prop-name">ListItemTextProp.Secondary</span> | <span class="prop-type">ReactNode</span> |   | The secondary content element. |
| <span class="prop-name">ListItemTextProp.PrimaryTypographyProps</span> | <span class="prop-type">IHTMLProp list</span> |   | These props will be forwarded to the primary typography component (as long as disableTypography is not `true`). |
| <span class="prop-name">ListItemTextProp.SecondaryTypographyProps</span> | <span class="prop-type">IHTMLProp list</span> |   | These props will be forwarded to the secondary typography component (as long as disableTypography is not `true`). |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Inset</span> | Styles applied to the root element if `inset={true}`.
| <span class="prop-name">ClassNames.Dense</span> | Styles applied to the root element if `context.dense` is `true`.
| <span class="prop-name">ClassNames.Primary</span> | Styles applied to the primary `Typography` component.
| <span class="prop-name">ClassNames.Secondary</span> | Styles applied to the secondary `Typography` component.
| <span class="prop-name">ClassNames.TextDense</span> | Styles applied to the `Typography` components if `context.dense` is `true`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/ListItemText/ListItemText.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiListItemText`.

<!--## Demos-->

<!--- [Lists](/demos/lists/)-->

