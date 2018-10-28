# Typography

<p class="description">The API documentation of the Typography React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.typography (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">align</span> | <span class="prop-type">enum:&nbsp;"inherit", "left", "center", "right", "justify"<br></span> | <span class="prop-default">"inherit"</span> | Set the text-align on the component. |
| <span class="prop-name">children</span> | <span class="prop-type">node</span> |   | The content of the component. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">color</span> | <span class="prop-type">enum:&nbsp;"default", "error", "inherit", "primary", "secondary", "textPrimary", "textSecondary"<br></span> | <span class="prop-default">"default"</span> | The color of the component. It supports those theme colors that make sense for this component. |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> |   | The component used for the root node. Either a string to use a DOM element or a component. By default, it maps the variant to a good default headline component. |
| <span class="prop-name">gutterBottom</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the text will have a bottom margin. |
| <span class="prop-name">headlineMapping</span> | <span class="prop-type">IHTMLProp list</span> | <span class="prop-default">{  h1: "h1",  h2: "h2",  h3: "h3",  h4: "h4",  h5: "h5",  h6: "h6",  subtitle1: "h6",  subtitle2: "h6",  body1: "p",  body2: "p",  // deprecated  display4: "h1",  display3: "h1",  display2: "h1",  display1: "h1",  headline: "h1",  title: "h2",  subheading: "h3",}</span> | We are empirically mapping the variant property to a range of different DOM element types. For instance, subtitle1 to `<h6>`. If you wish to change that mapping, you can provide your own. Alternatively, you can use the `component` property. The default mapping is the following: |
| <span class="prop-name">internalDeprecatedVariant</span> | <span class="prop-type">bool</span> |   | A deprecated variant is used from an internal component. Users don't need a deprecation warning here if they switched to the v2 theme. They already get the mapping that will be applied in the next major release. |
| <span class="prop-name">noWrap</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the text will not wrap, but instead will truncate with an ellipsis. |
| <span class="prop-name">paragraph</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the text will have a bottom margin. |
| <span class="prop-name">variant</span> | <span class="prop-type">enum:&nbsp;"h1", "h2", "h3", "h4", "h5", "h6", "subtitle1", "subtitle2", "body1", "body2", "caption", "button", "overline", "srOnly", "inherit", "display4", "display3", "display2", "display1", "headline", "title", "subheading"<br></span> |   | Applies the theme typography styles. Use `body1` as the default value with the legacy implementation and `body2` with the new one. |

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

## Demos

- [Typography](/style/typography/)

