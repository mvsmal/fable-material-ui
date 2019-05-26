# Avatar

<p class="description">The API documentation of the Avatar React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.avatar (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component. See [CSS API](#css-api) below for more details. |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactElementType</span> | <span class="prop-default">"div"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">AvatarProp.ImgProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Attributes applied to the `img` element if the component is used to display an image. |
| <span class="prop-name">HTMLAttr.Alt</span> | <span class="prop-type">string</span> |   | Used in combination with `src` or `srcSet` to provide an alt attribute for the rendered `img` element. |
| <span class="prop-name">HTMLAttr.Sizes</span> | <span class="prop-type">string</span> |   | The `sizes` attribute for the `img` element. |
| <span class="prop-name">HTMLAttr.Src</span> | <span class="prop-type">string</span> |   | The `src` attribute for the `img` element. |
| <span class="prop-name">HTMLAttr.SrcSet</span> | <span class="prop-type">string</span> |   | The `srcSet` attribute for the `img` element. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.ColorDefault</span> | Styles applied to the root element if `Color = Default`.
| <span class="prop-name">ClassNames.Img</span> | Styles applied to the img element if either `Src` or `SrcSet` is defined.

Have a look at [overriding with classes](/customization/overrides/#overriding-with-classes) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Avatar/Avatar.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](/customization/themes/#customizing-all-instances-of-a-component-type),
you need to use the following style sheet name: `MuiAvatar`.

<!--## Demos-->

<!--- [Avatars](/demos/avatars/)-->

