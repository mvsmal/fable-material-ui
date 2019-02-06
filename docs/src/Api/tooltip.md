# Tooltip

<p class="description">The API documentation of the Tooltip React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.tooltip (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.OnClose</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the tooltip requests to be closed.<br><br>**Signature:**<br>`(event : obj) -> unit`<br>*event:* The event source of the callback |
| <span class="prop-name">MaterialProp.OnOpen</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the tooltip requests to be open.<br><br>**Signature:**<br>`(event : obj) -> unit`<br>*event:* The event source of the callback |
| <span class="prop-name">MaterialProp.Open</span> | <span class="prop-type">bool</span> |   | If `true`, the tooltip is shown. |
| <span class="prop-name">MaterialProp.Placement</span> | <span class="prop-type">type&nbsp;PlacementType&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;BottomEnd<br>&nbsp;&nbsp;&#124;&nbsp;BottomStart<br>&nbsp;&nbsp;&#124;&nbsp;Bottom<br>&nbsp;&nbsp;&#124;&nbsp;LeftEnd<br>&nbsp;&nbsp;&#124;&nbsp;LeftStart<br>&nbsp;&nbsp;&#124;&nbsp;Left<br>&nbsp;&nbsp;&#124;&nbsp;RightEnd<br>&nbsp;&nbsp;&#124;&nbsp;RightStart<br>&nbsp;&nbsp;&#124;&nbsp;Right<br>&nbsp;&nbsp;&#124;&nbsp;TopEnd<br>&nbsp;&nbsp;&#124;&nbsp;TopStart<br>&nbsp;&nbsp;&#124;&nbsp;Top<br></span> | <span class="prop-default">PlacementType.Bottom</span> | Tooltip placement. |
| <span class="prop-name">HTMLAttr.Id</span> | <span class="prop-type">string</span> |   | The relationship between the tooltip and the wrapper component is not clear from the DOM. This property is used with aria-describedby to solve the accessibility issue. If you don't provide this property. It fallback to a random generated id. |
| <span class="prop-name">TooltipProp.DisableFocusListener</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Do not respond to focus events. |
| <span class="prop-name">TooltipProp.DisableHoverListener</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Do not respond to hover events. |
| <span class="prop-name">TooltipProp.DisableTouchListener</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Do not respond to long press touch events. |
| <span class="prop-name">TooltipProp.EnterDelay</span> | <span class="prop-type">int</span> | <span class="prop-default">0</span> | The number of milliseconds to wait before showing the tooltip. This property won't impact the enter touch delay (`enterTouchDelay`). |
| <span class="prop-name">TooltipProp.EnterTouchDelay</span> | <span class="prop-type">int</span> | <span class="prop-default">1000</span> | The number of milliseconds a user must touch the element before showing the tooltip. |
| <span class="prop-name">TooltipProp.LeaveDelay</span> | <span class="prop-type">int</span> | <span class="prop-default">0</span> | The number of milliseconds to wait before hiding the tooltip. This property won't impact the leave touch delay (`leaveTouchDelay`). |
| <span class="prop-name">TooltipProp.LeaveTouchDelay</span> | <span class="prop-type">int</span> | <span class="prop-default">1500</span> | The number of milliseconds after the user stops touching an element before hiding the tooltip. |
| <span class="prop-name required">TooltipProp.Title *</span> | <span class="prop-type">ReactNode</span> |   | Tooltip title. Zero-length titles string are never displayed. |
| <span class="prop-name">ChildrenProp.PopperProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the [`Popper`](#/api/popper) element. |
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

<!--## Demos-->

<!--- [Tooltips](/demos/tooltips/)-->

