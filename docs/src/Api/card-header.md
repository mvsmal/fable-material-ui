# CardHeader

<p class="description">The API documentation of the CardHeader React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.cardHeader (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactElementType</span> | <span class="prop-default">"div"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">MaterialProp.DisableTypography</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the children won't be wrapped by a Typography component. This can be useful to render an alternative Typography variant by wrapping the `title` text, and optional `subheader` text with the Typography component. |
| <span class="prop-name">CardHeaderProp.Action</span> | <span class="prop-type">ReactElement</span> |   | The action to display in the card header. |
| <span class="prop-name">CardHeaderProp.Avatar</span> | <span class="prop-type">ReactElement</span> |   | The Avatar for the Card Header. |
| <span class="prop-name">CardHeaderProp.Subheader</span> | <span class="prop-type">ReactElement</span> |   | The content of the component. |
| <span class="prop-name">CardHeaderProp.SubheaderTypographyProps</span> | <span class="prop-type">IHTMLProp list</span> |   | These props will be forwarded to the subheader (as long as disableTypography is not `true`). |
| <span class="prop-name">CardHeaderProp.Title</span> | <span class="prop-type">ReactElement</span> |   | The content of the Card Title. |
| <span class="prop-name">CardHeaderProp.TitleTypographyProps</span> | <span class="prop-type">IHTMLProp list</span> |   | These props will be forwarded to the title (as long as disableTypography is not `true`). |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Avatar</span> | Styles applied to the avatar element.
| <span class="prop-name">ClassNames.Action</span> | Styles applied to the action element.
| <span class="prop-name">ClassNames.Content</span> | Styles applied to the content wrapper element.
| <span class="prop-name">ClassNames.Title</span> | Styles applied to the title Typography element.
| <span class="prop-name">ClassNames.Subheader</span> | Styles applied to the subheader Typography element.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/CardHeader/CardHeader.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiCardHeader`.

<!--## Demos-->

<!--- [Cards](/demos/cards/)-->

