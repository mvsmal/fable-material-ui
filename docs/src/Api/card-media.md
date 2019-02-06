# CardMedia

<p class="description">The API documentation of the CardMedia React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.cardMedia (props : seq<IHTMLProp>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"div"</span> | Component for rendering image. Either a string to use a DOM element or a component. |
| <span class="prop-name">HTMLAttr.Src</span> | <span class="prop-type">string</span> |   | An alias for `image` property. Available only with media components. Media components: `video`, `audio`, `picture`, `iframe`, `img`. |
| <span class="prop-name">CardMediaProp.Image</span> | <span class="prop-type">string</span> |   | Image to be displayed as a background image. Either `image` or `src` prop must be specified. Note that caller must specify height otherwise the image will not be visible. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Media</span> | Styles applied to the root element if `component="video, audio, picture, iframe, or img"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/CardMedia/CardMedia.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiCardMedia`.

<!--## Demos-->

<!--- [Cards](/demos/cards/)-->

