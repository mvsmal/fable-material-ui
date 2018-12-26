# Backdrop

<p class="description">The API documentation of the Backdrop React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.backdrop (props : IHTMLProp list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span>  |   | Override or extend the styles applied to the component. See [CSS API](#css-api) below for more details. |
| <span class="prop-name required">MaterialProp.Open *</span> | <span class="prop-type">bool</span>  |   | If `true`, the backdrop is open. |
| <span class="prop-name">MaterialProp.TransitionDuration</span> | <span class="prop-type">U2&lt;float,&nbsp;TransitionDurationProp&nbsp;list&gt;<br><br>type&nbsp;TransitionDurationProp&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Enter&nbsp;of&nbsp;float<br>&nbsp;&nbsp;&#124;&nbsp;Exit&nbsp;of&nbsp;float<br></span>  |   | The duration for the transition, in milliseconds. You may specify a single timeout for all transitions, or individually with an list of `TransitionDurationProp`. |
| <span class="prop-name">BackdropProp.Invisible</span> | <span class="prop-type">bool</span>  | <span class="prop-default">false</span> | If `true`, the backdrop is invisible. It can be used when rendering a popover or a custom select component. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Invisible</span> | Styles applied to the root element if `Invisible = true`.

Have a look at [overriding with classes](/customization/overrides/#overriding-with-classes) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Backdrop/Backdrop.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](/customization/themes/#customizing-all-instances-of-a-component-type),
you need to use the following style sheet name: `MuiBackdrop`.

