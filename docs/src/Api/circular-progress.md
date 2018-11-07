# CircularProgress

<p class="description">The API documentation of the CircularProgress React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.circularProgress (props : IHTMLProp list) : ReactElement
```

## ARIA

If the progress bar is describing the loading progress of a particular region of a page,
you should use `aria-describedby` to point to the progress bar, and set the `aria-busy`
attribute to `true` on that region until it has finished loading.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Color</span> | <span class="prop-type">type&nbsp;ComponentColor&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Inherit<br>&nbsp;&nbsp;&#124;&nbsp;Primary<br>&nbsp;&nbsp;&#124;&nbsp;Secondary<br></span> | <span class="prop-default">ComponentColor.Primary</span> | The color of the component. It supports those theme colors that make sense for this component. |
| <span class="prop-name">CircularProgresProp.Size</span> | <span class="prop-type">type&nbsp;CircularProgressSize&nbsp;=&nbsp;U2&lt;int,&nbsp;string&gt;</span> | <span class="prop-default">40</span> | The size of the circle. |
| <span class="prop-name">CircularProgresProp.Thickness</span> | <span class="prop-type">float</span> | <span class="prop-default">3.6</span> | The thickness of the circle. |
| <span class="prop-name">CircularProgresProp.Value</span> | <span class="prop-type">int</span> | <span class="prop-default">0</span> | The value of the progress indicator for the determinate and static variants. Value between 0 and 100. |
| <span class="prop-name">CircularProgresProp.Variant</span> | <span class="prop-type">type&nbsp;CircularProgressVariant&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Determinate<br>&nbsp;&nbsp;&#124;&nbsp;Indeterminate<br>&nbsp;&nbsp;&#124;&nbsp;Static<br></span> | <span class="prop-default">CircularProgressVariant.Indeterminate</span> | The variant to use. Use indeterminate when there is no progress value. |
| <span class="prop-name">CircularProgresProp.DisableShrink</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the shrink animation is disabled. This only works if variant is `indeterminate`. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Static</span> | Styles applied to the root element if `variant="static"`.
| <span class="prop-name">ClassNames.Indeterminate</span> | Styles applied to the root element if `variant="indeterminate"`.
| <span class="prop-name">ClassNames.ColorPrimary</span> | Styles applied to the root element if `color="primary"`.
| <span class="prop-name">ClassNames.ColorSecondary</span> | Styles applied to the root element if `color="secondary"`.
| <span class="prop-name">ClassNames.Svg</span> | Styles applied to the `svg` element.
| <span class="prop-name">ClassNames.Circle</span> | Styles applied to the `circle` svg path.
| <span class="prop-name">ClassNames.CircleStatic</span> | Styles applied to the `circle` svg path if `variant="static"`.
| <span class="prop-name">ClassNames.CircleIndeterminate</span> | Styles applied to the `circle` svg path if `variant="indeterminate"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/CircularProgress/CircularProgress.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiCircularProgress`.

<!--## Demos-->

<!--- [Progress](/demos/progress/)-->

