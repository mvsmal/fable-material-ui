# Button

<p class="description">The API documentation of the Button React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.button (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Color</span> | <span class="prop-type">type&nbsp;ComponentColor&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Default<br>&nbsp;&nbsp;&#124;&nbsp;Inherit<br>&nbsp;&nbsp;&#124;&nbsp;Primary<br>&nbsp;&nbsp;&#124;&nbsp;Secondary<br></span> | <span class="prop-default">ComponentColor.Default</span> | The color of the component. It supports those theme colors that make sense for this component. |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"button"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">MaterialProp.DisableRipple</span> | <span class="prop-type">bool</span> |   | If `true`, the ripple effect will be disabled. |
| <span class="prop-name">MaterialProp.FullWidth</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the button will take up the full width of its container. |
| <span class="prop-name">HTMLAttr.Href</span> | <span class="prop-type">string</span> |   | The URL to link to when the button is clicked. If defined, an `a` element will be used as the root node. |
| <span class="prop-name">HTMLAttr.Disabled</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the button will be disabled. |
| <span class="prop-name">ButtonProp.DisableFocusRipple</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the  keyboard focus ripple will be disabled. `MaterialProp.DisableRipple` must also be true. |
| <span class="prop-name">ButtonProp.Mini</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, and `Variant` is `Fab`, will use mini floating action button styling. |
| <span class="prop-name">ButtonProp.Size</span> | <span class="prop-type">type&nbsp;ButtonSize&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Small<br>&nbsp;&nbsp;&#124;&nbsp;Medium<br>&nbsp;&nbsp;&#124;&nbsp;Large<br></span> | <span class="prop-default">ButtonSize.Medium</span> | The size of the button. `Small` is equivalent to the dense button styling. |
| <span class="prop-name">ButtonProp.Variant</span> | <span class="prop-type">type&nbsp;ButtonVariant&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Text<br>&nbsp;&nbsp;&#124;&nbsp;Flat<br>&nbsp;&nbsp;&#124;&nbsp;Outlined<br>&nbsp;&nbsp;&#124;&nbsp;Contained<br>&nbsp;&nbsp;&#124;&nbsp;Raised<br>&nbsp;&nbsp;&#124;&nbsp;Fab<br>&nbsp;&nbsp;&#124;&nbsp;ExtendedFab<br></span> | <span class="prop-default">ButtonVariant.Text</span> | The variant to use. __WARNING__: `Flat` and `Raised` are deprecated. Instead use `Text` and `Contained` respectively. |

Any other properties supplied will be spread to the root element ([ButtonBase](#/api/button-base)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Label</span> | Styles applied to the span element that wraps the children.
| <span class="prop-name">ClassNames.Text</span> | Styles applied to the root element if `variant="text"`.
| <span class="prop-name">ClassNames.TextPrimary</span> | Styles applied to the root element if `variant="text"` and `color="primary"`.
| <span class="prop-name">ClassNames.TextSecondary</span> | Styles applied to the root element if `variant="text"` and `color="secondary"`.
| <span class="prop-name">ClassNames.Flat</span> | Styles applied to the root element for backwards compatibility with legacy variant naming.
| <span class="prop-name">ClassNames.FlatPrimary</span> | Styles applied to the root element for backwards compatibility with legacy variant naming.
| <span class="prop-name">ClassNames.FlatSecondary</span> | Styles applied to the root element for backwards compatibility with legacy variant naming.
| <span class="prop-name">ClassNames.Outlined</span> | Styles applied to the root element if `variant="outlined"`.
| <span class="prop-name">ClassNames.OutlinedPrimary</span> | Styles applied to the root element if `variant="outlined"` and `color="primary"`.
| <span class="prop-name">ClassNames.OutlinedSecondary</span> | Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
| <span class="prop-name">ClassNames.Contained</span> | Styles applied to the root element if `variant="[contained \| fab]"`.
| <span class="prop-name">ClassNames.ContainedPrimary</span> | Styles applied to the root element if `variant="[contained \| fab]"` and `color="primary"`.
| <span class="prop-name">ClassNames.ContainedSecondary</span> | Styles applied to the root element if `variant="[contained \| fab]"` and `color="secondary"`.
| <span class="prop-name">ClassNames.Raised</span> | Styles applied to the root element for backwards compatibility with legacy variant naming.
| <span class="prop-name">ClassNames.RaisedPrimary</span> | Styles applied to the root element for backwards compatibility with legacy variant naming.
| <span class="prop-name">ClassNames.RaisedSecondary</span> | Styles applied to the root element for backwards compatibility with legacy variant naming.
| <span class="prop-name">ClassNames.Fab</span> | Styles applied to the root element if `variant="[fab \| extendedFab]"`.
| <span class="prop-name">ClassNames.ExtendedFab</span> | Styles applied to the root element if `variant="extendedFab"`.
| <span class="prop-name">ClassNames.FocusVisible</span> | Styles applied to the ButtonBase root element if the button is keyboard focused.
| <span class="prop-name">ClassNames.Disabled</span> | Styles applied to the root element if `disabled={true}`.
| <span class="prop-name">ClassNames.ColorInherit</span> | Styles applied to the root element if `color="inherit"`.
| <span class="prop-name">ClassNames.Mini</span> | Styles applied to the root element if `size="mini"` & `variant="[fab \| extendedFab]"`.
| <span class="prop-name">ClassNames.SizeSmall</span> | Styles applied to the root element if `size="small"`.
| <span class="prop-name">ClassNames.SizeLarge</span> | Styles applied to the root element if `size="large"`.
| <span class="prop-name">ClassNames.FullWidth</span> | Styles applied to the root element if `fullWidth={true}`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Button/Button.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiButton`.

## Inheritance

The properties of the [ButtonBase](#/api/button-base) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

## Demos

- [Buttons](#/demos/buttons/)

