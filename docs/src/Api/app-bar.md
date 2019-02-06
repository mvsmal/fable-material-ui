# AppBar

<p class="description">The API documentation of the AppBar React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.appBar (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list |   | Override or extend the styles applied to the component. <!--See [CSS API](#css-api) below for more details.--> |
| <span class="prop-name">MaterialProp.Color</span> | <span class="prop-type">type&nbsp;ComponentColor&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Default<br>&nbsp;&nbsp;&#124;&nbsp;Inherit<br>&nbsp;&nbsp;&#124;&nbsp;Primary<br>&nbsp;&nbsp;&#124;&nbsp;Secondary<br></span> | <span class="prop-default">ComponentColor.Primary</span> | The color of the component. It supports those theme colors that make sense for this component. |
| <span class="prop-name">AppBarProp.Position</span> | <span class="prop-type">type&nbsp;AppBarPosition&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Fixed<br>&nbsp;&nbsp;&#124;&nbsp;Absolute<br>&nbsp;&nbsp;&#124;&nbsp;Sticky<br>&nbsp;&nbsp;&#124;&nbsp;Static<br>&nbsp;&nbsp;&#124;&nbsp;Relative<br></span> | <span class="prop-default">AppBarPosition.Fixed</span> | The positioning type. The behavior of the different options is described [here](https://developer.mozilla.org/en-US/docs/Learn/CSS/CSS_layout/Positioning). Note: `Sticky` is not universally supported and will fall back to `Static` when unavailable. |

Any other properties supplied will be spread to the root element ([Paper](#/api/paper/)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.PositionFixed</span> | Styles applied to the root element if `position = Fixed`.
| <span class="prop-name">ClassNames.PositionAbsolute</span> | Styles applied to the root element if `position = Absolute`.
| <span class="prop-name">ClassNames.PositionSticky</span> | Styles applied to the root element if `position = Sticky`.
| <span class="prop-name">ClassNames.PositionStatic</span> | Styles applied to the root element if `position = Static`.
| <span class="prop-name">ClassNames.PositionRelative</span> | Styles applied to the root element if `position = Relative`.
| <span class="prop-name">ClassNames.ColorDefault</span> | Styles applied to the root element if `color = Default`.
| <span class="prop-name">ClassNames.ColorPrimary</span> | Styles applied to the root element if `color = Primary`.
| <span class="prop-name">ClassNames.ColorSecondary</span> | Styles applied to the root element if `color = Secondary`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/AppBar/AppBar.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiAppBar`.

## Inheritance

The properties of the [Paper](#/api/paper) component are also available.

## Demos

- [App Bar](#/demos/app-bar)

