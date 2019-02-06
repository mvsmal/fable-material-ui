# Typography

<p class="description">The API documentation of the Typography React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.typography (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> |   | The component used for the root node. Either a string to use a DOM element or a component. By default, it maps the variant to a good default headline component. |
| <span class="prop-name">TypographyProp.Align</span> | <span class="prop-type">type&nbsp;TypographyAlign&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Inherit<br>&nbsp;&nbsp;&#124;&nbsp;Left<br>&nbsp;&nbsp;&#124;&nbsp;Center<br>&nbsp;&nbsp;&#124;&nbsp;Right<br>&nbsp;&nbsp;&#124;&nbsp;Justify<br></span> | <span class="prop-default">TypographyAlign.Inherit</span> | Set the text-align on the component. |
| <span class="prop-name">TypographyProp.Color</span> | <span class="prop-type">type&nbsp;TypographyColor&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Default<br>&nbsp;&nbsp;&#124;&nbsp;Error<br>&nbsp;&nbsp;&#124;&nbsp;Inherit<br>&nbsp;&nbsp;&#124;&nbsp;Primary<br>&nbsp;&nbsp;&#124;&nbsp;Secondary<br>&nbsp;&nbsp;&#124;&nbsp;TextPrimary<br>&nbsp;&nbsp;&#124;&nbsp;TextSecondary<br></span> | <span class="prop-default">TypographyColor.Default</span> | The color of the component. It supports those theme colors that make sense for this component. |
| <span class="prop-name">TypographyProp.GutterBottom</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the text will have a bottom margin. |
| <span class="prop-name">TypographyProp.HeadlineMapping</span> | <span class="prop-type">type TypographyHeadlineMapping =<br>&nbsp;&nbsp;{ h1 : string<br>&nbsp;&nbsp;&nbsp;&nbsp;h2 : string<br>&nbsp;&nbsp;&nbsp;&nbsp;h3 : string<br>&nbsp;&nbsp;&nbsp;&nbsp;h4 : string<br>&nbsp;&nbsp;&nbsp;&nbsp;h5 : string<br>&nbsp;&nbsp;&nbsp;&nbsp;h6 : string<br>&nbsp;&nbsp;&nbsp;&nbsp;subtitle1 : string<br>&nbsp;&nbsp;&nbsp;&nbsp;subtitle2 : string<br>&nbsp;&nbsp;&nbsp;&nbsp;body1 : string<br>&nbsp;&nbsp;&nbsp;&nbsp;body2 : string<br>&nbsp;&nbsp;&nbsp;&nbsp;dispalay4 : string<br>&nbsp;&nbsp;&nbsp;&nbsp;display3 : string<br>&nbsp;&nbsp;&nbsp;&nbsp;display2 : string<br>&nbsp;&nbsp;&nbsp;&nbsp;display1 : string<br>&nbsp;&nbsp;&nbsp;&nbsp;headline : string<br>&nbsp;&nbsp;&nbsp;&nbsp;title : string<br>&nbsp;&nbsp;&nbsp;&nbsp;subheading : string }</span> | <span class="prop-default">{ h1 = "h1"<br>&nbsp;&nbsp;h2 = "h2"<br>&nbsp;&nbsp;h3 = "h3"<br>&nbsp;&nbsp;h4 = "h4"<br>&nbsp;&nbsp;h5 = "h5"<br>&nbsp;&nbsp;h6 = "h6"<br>&nbsp;&nbsp;subtitle1 = "h6"<br>&nbsp;&nbsp;subtitle2 = "h6"<br>&nbsp;&nbsp;body1 = "p"<br>&nbsp;&nbsp;body2 = "p"<br>&nbsp;&nbsp;display4 = "h1"<br>&nbsp;&nbsp;display3 = "h1"<br>&nbsp;&nbsp;display2 = "h1"<br>&nbsp;&nbsp;display1 = "h1"<br>&nbsp;&nbsp;headline = "h1"<br>&nbsp;&nbsp;title = "h2"<br>&nbsp;&nbsp;subheading = "h3" }</span> | We are empirically mapping the variant property to a range of different DOM element types. For instance, subtitle1 to `<h6>`. If you wish to change that mapping, you can provide your own. Alternatively, you can use the `component` property. The default mapping is the following: |
| <span class="prop-name">TypographyProp.InternalDeprecatedVariant</span> | <span class="prop-type">bool</span> |   | A deprecated variant is used from an internal component. Users don't need a deprecation warning here if they switched to the v2 theme. They already get the mapping that will be applied in the next major release. |
| <span class="prop-name">TypographyProp.NoWrap</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the text will not wrap, but instead will truncate with an ellipsis. |
| <span class="prop-name">TypographyProp.Paragraph</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the text will have a bottom margin. |
| <span class="prop-name">TypographyProp.Variant</span> | <span class="prop-type">type&nbsp;TypographyVariant&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;H1<br>&nbsp;&nbsp;&#124;&nbsp;H2<br>&nbsp;&nbsp;&#124;&nbsp;H3<br>&nbsp;&nbsp;&#124;&nbsp;H4<br>&nbsp;&nbsp;&#124;&nbsp;H5<br>&nbsp;&nbsp;&#124;&nbsp;H6<br>&nbsp;&nbsp;&#124;&nbsp;Subtitle1<br>&nbsp;&nbsp;&#124;&nbsp;Subtitle2<br>&nbsp;&nbsp;&#124;&nbsp;Overline<br>&nbsp;&nbsp;&#124;&nbsp;SrOnly<br>&nbsp;&nbsp;&#124;&nbsp;Body1<br>&nbsp;&nbsp;&#124;&nbsp;Body2<br>&nbsp;&nbsp;&#124;&nbsp;Caption<br>&nbsp;&nbsp;&#124;&nbsp;Button<br>&nbsp;&nbsp;&#124;&nbsp;Inherit<br>&nbsp;&nbsp;//&nbsp;Deprecated<br>&nbsp;&nbsp;&#124;&nbsp;Display1<br>&nbsp;&nbsp;&#124;&nbsp;Display2<br>&nbsp;&nbsp;&#124;&nbsp;Display3<br>&nbsp;&nbsp;&#124;&nbsp;Display4<br>&nbsp;&nbsp;&#124;&nbsp;Headline<br>&nbsp;&nbsp;&#124;&nbsp;Title<br>&nbsp;&nbsp;&#124;&nbsp;Subheading<br><br></span> |   | Applies the theme typography styles. Use `body1` as the default value with the legacy implementation and `body2` with the new one. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Display4</span> | Styles applied to the root element if `variant="display4"`.
| <span class="prop-name">ClassNames.Display3</span> | Styles applied to the root element if `variant="display3"`.
| <span class="prop-name">ClassNames.Display2</span> | Styles applied to the root element if `variant="display2"`.
| <span class="prop-name">ClassNames.Display1</span> | Styles applied to the root element if `variant="display1"`.
| <span class="prop-name">ClassNames.Headline</span> | Styles applied to the root element if `variant="headline"`.
| <span class="prop-name">ClassNames.Title</span> | Styles applied to the root element if `variant="title"`.
| <span class="prop-name">ClassNames.Subheading</span> | Styles applied to the root element if `variant="subheading"`.
| <span class="prop-name">ClassNames.Body2</span> | Styles applied to the root element if `variant="body2"`.
| <span class="prop-name">ClassNames.Body1</span> | Styles applied to the root element if `variant="body1"`.
| <span class="prop-name">ClassNames.Caption</span> | Styles applied to the root element if `variant="caption"`.
| <span class="prop-name">ClassNames.Button</span> | Styles applied to the root element if `variant="button"`.
| <span class="prop-name">ClassNames.H1</span> | Styles applied to the root element if `variant="h1"`.
| <span class="prop-name">ClassNames.H2</span> | Styles applied to the root element if `variant="h2"`.
| <span class="prop-name">ClassNames.H3</span> | Styles applied to the root element if `variant="h3"`.
| <span class="prop-name">ClassNames.H4</span> | Styles applied to the root element if `variant="h4"`.
| <span class="prop-name">ClassNames.H5</span> | Styles applied to the root element if `variant="h5"`.
| <span class="prop-name">ClassNames.H6</span> | Styles applied to the root element if `variant="h6"`.
| <span class="prop-name">ClassNames.Subtitle1</span> | Styles applied to the root element if `variant="subtitle1"`.
| <span class="prop-name">ClassNames.Subtitle2</span> | Styles applied to the root element if `variant="subtitle2"`.
| <span class="prop-name">ClassNames.Overline</span> | Styles applied to the root element if `variant="overline"`.
| <span class="prop-name">ClassNames.SrOnly</span> | Styles applied to the root element if `variant="srOnly"`. Only accessible to screen readers.
| <span class="prop-name">ClassNames.AlignLeft</span> | Styles applied to the root element if `align="left"`.
| <span class="prop-name">ClassNames.AlignCenter</span> | Styles applied to the root element if `align="center"`.
| <span class="prop-name">ClassNames.AlignRight</span> | Styles applied to the root element if `align="right"`.
| <span class="prop-name">ClassNames.AlignJustify</span> | Styles applied to the root element if `align="justify"`.
| <span class="prop-name">ClassNames.NoWrap</span> | Styles applied to the root element if `align="nowrap"`.
| <span class="prop-name">ClassNames.GutterBottom</span> | Styles applied to the root element if `gutterBottom={true}`.
| <span class="prop-name">ClassNames.Paragraph</span> | Styles applied to the root element if `paragraph={true}`.
| <span class="prop-name">ClassNames.ColorInherit</span> | Styles applied to the root element if `color="inherit"`.
| <span class="prop-name">ClassNames.ColorPrimary</span> | Styles applied to the root element if `color="primary"`.
| <span class="prop-name">ClassNames.ColorSecondary</span> | Styles applied to the root element if `color="secondary"`.
| <span class="prop-name">ClassNames.ColorTextPrimary</span> | Styles applied to the root element if `color="textPrimary"`.
| <span class="prop-name">ClassNames.ColorTextSecondary</span> | Styles applied to the root element if `color="textSecondary"`.
| <span class="prop-name">ClassNames.ColorError</span> | Styles applied to the root element if `color="error"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Typography/Typography.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiTypography`.

<!--## Demos-->

<!--- [Typography](/style/typography/)-->

