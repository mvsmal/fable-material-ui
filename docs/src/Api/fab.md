# Fab

<p class="description">The API documentation of the Fab React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.fab (props : IHTMLProp list) (children : ReactElement list) : ReactElement
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
| <span class="prop-name">FabProp.DisableFocusRipple</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the  keyboard focus ripple will be disabled. `MaterialProp.DisableRipple` must also be true. |
| <span class="prop-name">FabProp.Size</span> | <span class="prop-type">type&nbsp;FabSize&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Small<br>&nbsp;&nbsp;&#124;&nbsp;Medium<br>&nbsp;&nbsp;&#124;&nbsp;Large<br></span> | <span class="prop-default">FabSize.Large</span> | The size of the button. `Small` is equivalent to the dense button styling. |
| <span class="prop-name">FabProp.Variant</span> | <span class="prop-type">type&nbsp;FabVariant&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Round<br>&nbsp;&nbsp;&#124;&nbsp;Extended<br> | <span class="prop-default">FabVariant.Round</span> | The variant to use. 

Any other properties supplied will be spread to the root element ([ButtonBase](#/api/button-base)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Label</span> | Styles applied to the span element that wraps the children.
| <span class="prop-name">ClassNames.Primary</span> | Styles applied to the root element if `color="primary"`.
| <span class="prop-name">ClassNames.Secondary</span> | Styles applied to the root element if `color="secondary"`.
| <span class="prop-name">ClassNames.Extended</span> | Styles applied to the root element if `variant="extended"`.
| <span class="prop-name">ClassNames.FocusVisible</span> | Styles applied to the ButtonBase root element if the button is keyboard focused.
| <span class="prop-name">ClassNames.Disabled</span> | Styles applied to the root element if `disabled={true}`.
| <span class="prop-name">ClassNames.ColorInherit</span> | Styles applied to the root element if `color="inherit"`.
| <span class="prop-name">ClassNames.SizeSmall</span> | Styles applied to the root element if `size="small"`.
| <span class="prop-name">ClassNames.SizeMedium</span> | Styles applied to the root element if `size="medium"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Fab/Fab.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiFab`.

## Inheritance

The properties of the [ButtonBase](#/api/button-base) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

## Demos

- [Buttons](#/demos/buttons/)

