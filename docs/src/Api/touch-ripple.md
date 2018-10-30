# TouchRipple

<p class="description">The API documentation of the TouchRipple React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.touchRipple (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">TouchRippleProp.Center</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the ripple starts at the center of the component rather than at the point of interaction. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Ripple</span> | Styles applied to the internal `Ripple` components `ripple` class.
| <span class="prop-name">ClassNames.RippleVisible</span> | Styles applied to the internal `Ripple` components `rippleVisible` class.
| <span class="prop-name">ClassNames.RipplePulsate</span> | Styles applied to the internal `Ripple` components `ripplePulsate` class.
| <span class="prop-name">ClassNames.Child</span> | Styles applied to the internal `Ripple` components `child` class.
| <span class="prop-name">ClassNames.ChildLeaving</span> | Styles applied to the internal `Ripple` components `childLeaving` class.
| <span class="prop-name">ClassNames.ChildPulsate</span> | Styles applied to the internal `Ripple` components `childPulsate` class.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/ButtonBase/TouchRipple.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiTouchRipple`.

