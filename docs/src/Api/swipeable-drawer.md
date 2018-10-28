# SwipeableDrawer

<p class="description">The API documentation of the SwipeableDrawer React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.swipeableDrawer (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">disableBackdropTransition</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Disable the backdrop transition. This can improve the FPS on low-end devices. |
| <span class="prop-name">disableDiscovery</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, touching the screen near the edge of the drawer will not slide in the drawer a bit to promote accidental discovery of the swipe gesture. |
| <span class="prop-name">disableSwipeToOpen</span> | <span class="prop-type">bool</span> | <span class="prop-default">typeof navigator !== "undefined" && /iPad\|iPhone\|iPod/.test(navigator.userAgent)</span> | If `true`, swipe to open is disabled. This is useful in browsers where swiping triggers navigation actions. Swipe to open is disabled on iOS browsers by default. |
| <span class="prop-name">hysteresis</span> | <span class="prop-type">number</span> | <span class="prop-default">0.55</span> | Affects how far the drawer must be opened/closed to change his state. Specified as percent (0-1) of the width of the drawer |
| <span class="prop-name">minFlingVelocity</span> | <span class="prop-type">number</span> | <span class="prop-default">400</span> | Defines, from which (average) velocity on, the swipe is defined as complete although hysteresis isn't reached. Good threshold is between 250 - 1000 px/s |
| <span class="prop-name required">onClose *</span> | <span class="prop-type">func</span> |   | Callback fired when the component requests to be closed.<br><br>**Signature:**<br>`(event : obj) -> unit`<br>*event:* The event source of the callback |
| <span class="prop-name required">onOpen *</span> | <span class="prop-type">func</span> |   | Callback fired when the component requests to be opened.<br><br>**Signature:**<br>`(event : obj) -> unit`<br>*event:* The event source of the callback |
| <span class="prop-name required">MaterialProp.Open *</span> | <span class="prop-type">bool</span> |   | If `true`, the drawer is open. |
| <span class="prop-name">swipeAreaWidth</span> | <span class="prop-type">number</span> | <span class="prop-default">20</span> | The width of the left most (or right most) area in pixels where the drawer can be swiped open from. |
| <span class="prop-name">MaterialProp.TransitionDuration</span> | <span class="prop-type">U2&lt;float,&nbsp;TransitionDurationProp&nbsp;list&gt;<br><br>type&nbsp;TransitionDurationProp&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Enter&nbsp;of&nbsp;float<br>&nbsp;&nbsp;&#124;&nbsp;Exit&nbsp;of&nbsp;float<br></span> | <span class="prop-default">{ enter: duration.enteringScreen, exit: duration.leavingScreen }</span> | The duration for the transition, in milliseconds. You may specify a single timeout for all transitions, or individually with an object. |

Any other properties supplied will be spread to the root element ([Drawer](#/api/drawer)).

## Inheritance

The properties of the [Drawer](#/api/drawer) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

## Demos

- [Drawers](/demos/drawers/)

