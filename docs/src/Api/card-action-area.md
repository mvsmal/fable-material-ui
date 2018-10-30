# CardActionArea

<p class="description">The API documentation of the CardActionArea React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.cardActionArea (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |

Any other properties supplied will be spread to the root element ([ButtonBase](#/api/button-base)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.FocusVisible</span> | Styles applied to the ButtonBase root element if the action area is keyboard focused.
| <span class="prop-name">ClassNames.FocusHighlight</span> | Styles applied to the overlay that covers the action area when it is keyboard focused.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/CardActionArea/CardActionArea.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiCardActionArea`.

## Inheritance

The properties of the [ButtonBase](#/api/button-base) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [Cards](/demos/cards/)-->

