# Link

<p class="description">The API documentation of the Link React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.link (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list |   | Override or extend the styles applied to the component. |
| <span class="prop-name">HTMLAttr.Target</span> | <span class="prop-type">string:&nbsp;"_self"&nbsp;&#124; &nbsp;"_blank"&nbsp;&#124; &nbsp;"_parent"&nbsp;&#124; &nbsp;"_top" </span> | <span class="prop-default">"_self"</span> | The target of the link. You can read about this property on the [MDN Web Docs](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/a#Attributes) |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">'a'</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">LinkProp.Block</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Controls whether the link is inline or not. When `block` is true the link is not inline  when `block` is false it is. |
| <span class="prop-name">LinkProp.Color</span> | <span class="prop-type">type&nbsp;LinkColor&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Inherit<br>&nbsp;&nbsp;&#124;&nbsp;Error<br>&nbsp;&nbsp;&#124;&nbsp;Primary<br>&nbsp;&nbsp;&#124;&nbsp;Secondary<br>&nbsp;&nbsp;&#124;&nbsp;TextPrimary<br>&nbsp;&nbsp;&#124;&nbsp;TextSecondary<br></span> | <span class="prop-default">LinkColor.Primary</span> | The color of the link. |
| <span class="prop-name">LinkProp.Underline</span> | <span class="prop-type">type&nbsp;LinkUnderline&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;None<br>&nbsp;&nbsp;&#124;&nbsp;Hover<br>&nbsp;&nbsp;&#124;&nbsp;Always<br></span> | <span class="prop-default">LinkUnderline.Hover</span> | Controls when the link should have an underline. |
| <span class="prop-name">TypographyProp.Variant</span> | <span class="prop-type">type&nbsp;TypographyVariant&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;H1<br>&nbsp;&nbsp;&#124;&nbsp;H2<br>&nbsp;&nbsp;&#124;&nbsp;H3<br>&nbsp;&nbsp;&#124;&nbsp;H4<br>&nbsp;&nbsp;&#124;&nbsp;H5<br>&nbsp;&nbsp;&#124;&nbsp;H6<br>&nbsp;&nbsp;&#124;&nbsp;Subtitle1<br>&nbsp;&nbsp;&#124;&nbsp;Subtitle2<br>&nbsp;&nbsp;&#124;&nbsp;Overline<br>&nbsp;&nbsp;&#124;&nbsp;SrOnly<br>&nbsp;&nbsp;&#124;&nbsp;Body1<br>&nbsp;&nbsp;&#124;&nbsp;Body2<br>&nbsp;&nbsp;&#124;&nbsp;Caption<br>&nbsp;&nbsp;&#124;&nbsp;Button<br>&nbsp;&nbsp;&#124;&nbsp;Inherit<br>&nbsp;&nbsp;//&nbsp;Deprecated<br>&nbsp;&nbsp;&#124;&nbsp;Display1<br>&nbsp;&nbsp;&#124;&nbsp;Display2<br>&nbsp;&nbsp;&#124;&nbsp;Display3<br>&nbsp;&nbsp;&#124;&nbsp;Display4<br>&nbsp;&nbsp;&#124;&nbsp;Headline<br>&nbsp;&nbsp;&#124;&nbsp;Title<br>&nbsp;&nbsp;&#124;&nbsp;Subheading<br><br></span> | <span class="prop-default">TypographyVariant.Inherit</span> | Applies the theme typography styles. |
| <span class="prop-name">ChildrenProps.TypographyClasses</span> | <span class="prop-type">ClassNames list</span> |   | `classes` property applied to the [`Typography`](#/api/typography/) element. |

Any other properties supplied will be spread to the root element ([Typography](#/api/typography/)).

## CSS

You can override all the class names injected by Material-UI thanks to the `classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.UnderlineNone</span> | Styles applied to the root element if `underline="none"`
| <span class="prop-name">ClassNames.UnderlineHover</span> | Styles applied to the root element if `underline="hover"`
| <span class="prop-name">ClassNames.UnderlineAlways</span> | Styles applied to the root element if `underline="always"`
| <span class="prop-name">ClassNames.Button</span> | Styles applied to the root element if `component="button"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/blob/master/packages/material-ui/src/Link/Link.js)
for more detail.

If using the `overrides` [key of the theme](#/customization/themes/#css),
you need to use the following style sheet name: `OverridesProp.MuiLink`.

## Inheritance

The properties of the [Typography](#/api/typography/) component are also available.
<!--You can take advantage of this behavior to [target nested components](/guides/api/#spread).

## Demos

- [Links](/style/links/) -->

