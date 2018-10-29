# Tooltip

<p class="description">The API documentation of the Tooltip React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.tooltip (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name required">children *</span> | <span class="prop-type">element</span> |   | Tooltip reference element. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">disableFocusListener</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Do not respond to focus events. |
| <span class="prop-name">disableHoverListener</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Do not respond to hover events. |
| <span class="prop-name">disableTouchListener</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Do not respond to long press touch events. |
| <span class="prop-name">enterDelay</span> | <span class="prop-type">number</span> | <span class="prop-default">0</span> | The number of milliseconds to wait before showing the tooltip. This property won't impact the enter touch delay (`enterTouchDelay`). |
| <span class="prop-name">enterTouchDelay</span> | <span class="prop-type">number</span> | <span class="prop-default">1000</span> | The number of milliseconds a user must touch the element before showing the tooltip. |
| <span class="prop-name">HTMLAttr.Id</span> | <span class="prop-type">string</span> |   | The relationship between the tooltip and the wrapper component is not clear from the DOM. This property is used with aria-describedby to solve the accessibility issue. If you don't provide this property. It fallback to a random generated id. |
| <span class="prop-name">leaveDelay</span> | <span class="prop-type">number</span> | <span class="prop-default">0</span> | The number of milliseconds to wait before hiding the tooltip. This property won't impact the leave touch delay (`leaveTouchDelay`). |
| <span class="prop-name">leaveTouchDelay</span> | <span class="prop-type">number</span> | <span class="prop-default">1500</span> | The number of milliseconds after the user stops touching an element before hiding the tooltip. |
| <span class="prop-name">MaterialProp.OnClose</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the tooltip requests to be closed.<br><br>**Signature:**<br>`(event : obj) -> unit`<br>*event:* The event source of the callback |
| <span class="prop-name">onOpen</span> | <span class="prop-type">func</span> |   | Callback fired when the tooltip requests to be open.<br><br>**Signature:**<br>`(event : obj) -> unit`<br>*event:* The event source of the callback |
| <span class="prop-name">MaterialProp.Open</span> | <span class="prop-type">bool</span> |   | If `true`, the tooltip is shown. |
| <span class="prop-name">placement</span> | <span class="prop-type">enum:&nbsp;"bottom-end", "bottom-start", "bottom", "left-end", "left-start", "left", "right-end", "right-start", "right", "top-end", "top-start", "top"<br></span> | <span class="prop-default">"bottom"</span> | Tooltip placement. |
| <span class="prop-name">ChildrenProp.PopperProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the [`Popper`](#/api/popper) element. |
| <span class="prop-name required">title *</span> | <span class="prop-type">node</span> |   | Tooltip title. Zero-length titles string are never displayed. |
| <span class="prop-name">ChildrenProp.TransitionComponent</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">Grow</span> | Transition component. |
| <span class="prop-name">ChildrenProp.TransitionProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the `Transition` element. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Popper</span> | Styles applied to the Popper component.
| <span class="prop-name">ClassNames.Tooltip</span> | Styles applied to the tooltip (label wrapper) element.
| <span class="prop-name">ClassNames.Touch</span> | Styles applied to the tooltip (label wrapper) element if the tooltip is opened by touch.
| <span class="prop-name">ClassNames.TooltipPlacementLeft</span> | Styles applied to the tooltip (label wrapper) element if `placement` contains "left".
| <span class="prop-name">ClassNames.TooltipPlacementRight</span> | Styles applied to the tooltip (label wrapper) element if `placement` contains "right".
| <span class="prop-name">ClassNames.TooltipPlacementTop</span> | Styles applied to the tooltip (label wrapper) element if `placement` contains "top".
| <span class="prop-name">ClassNames.TooltipPlacementBottom</span> | Styles applied to the tooltip (label wrapper) element if `placement` contains "bottom".

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Tooltip/Tooltip.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiTooltip`.

## Demos

- [Tooltips](/demos/tooltips/)

