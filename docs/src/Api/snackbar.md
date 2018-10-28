# Snackbar

<p class="description">The API documentation of the Snackbar React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.snackbar (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">action</span> | <span class="prop-type">node</span> |   | The action to display. |
| <span class="prop-name">anchorOrigin</span> | <span class="prop-type">{ horizontal: enum:&nbsp;"left"&nbsp;&#124;<br>&nbsp;"center"&nbsp;&#124;<br>&nbsp;"right"<br>, vertical: enum:&nbsp;"top"&nbsp;&#124;<br>&nbsp;"bottom"<br> }</span> | <span class="prop-default">{  vertical: "bottom",  horizontal: "center",}</span> | The anchor of the `Snackbar`. |
| <span class="prop-name">autoHideDuration</span> | <span class="prop-type">number</span> |   | The number of milliseconds to wait before automatically calling the `onClose` function. `onClose` should then set the state of the `open` prop to hide the Snackbar. This behavior is disabled by default with the `null` value. |
| <span class="prop-name">children</span> | <span class="prop-type">element</span> |   | If you wish the take control over the children of the component you can use this property. When used, you replace the `SnackbarContent` component with the children. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">ChildrenProp.ClickAwayListenerProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the `ClickAwayListener` element. |
| <span class="prop-name">ChildrenProp.ContentProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the [`SnackbarContent`](#/api/snackbar-content) element. |
| <span class="prop-name">disableWindowBlurListener</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the `autoHideDuration` timer will expire even if the window is not focused. |
| <span class="prop-name">key</span> | <span class="prop-type">any</span> |   | When displaying multiple consecutive Snackbars from a parent rendering a single &lt;Snackbar/>, add the key property to ensure independent treatment of each message. e.g. &lt;Snackbar key={message} />, otherwise, the message may update-in-place and features such as autoHideDuration may be canceled. |
| <span class="prop-name">message</span> | <span class="prop-type">node</span> |   | The message to display. |
| <span class="prop-name">onClose</span> | <span class="prop-type">func</span> |   | Callback fired when the component requests to be closed. Typically `onClose` is used to set state in the parent component, which is used to control the `Snackbar` `open` prop. The `reason` parameter can optionally be used to control the response to `onClose`, for example ignoring `clickaway`.<br><br>**Signature:**<br>`function(event: object, reason: string) => void`<br>*event:* The event source of the callback<br>*reason:* Can be:`"timeout"` (`autoHideDuration` expired) or: `"clickaway"` |
| <span class="prop-name">onEnter</span> | <span class="prop-type">func</span> |   | Callback fired before the transition is entering. |
| <span class="prop-name">onEntered</span> | <span class="prop-type">func</span> |   | Callback fired when the transition has entered. |
| <span class="prop-name">onEntering</span> | <span class="prop-type">func</span> |   | Callback fired when the transition is entering. |
| <span class="prop-name">onExit</span> | <span class="prop-type">func</span> |   | Callback fired before the transition is exiting. |
| <span class="prop-name">onExited</span> | <span class="prop-type">func</span> |   | Callback fired when the transition has exited. |
| <span class="prop-name">onExiting</span> | <span class="prop-type">func</span> |   | Callback fired when the transition is exiting. |
| <span class="prop-name">MaterialProp.Open</span> | <span class="prop-type">bool</span> |   | If true, `Snackbar` is open. |
| <span class="prop-name">resumeHideDuration</span> | <span class="prop-type">number</span> |   | The number of milliseconds to wait before dismissing after user interaction. If `autoHideDuration` property isn't specified, it does nothing. If `autoHideDuration` property is specified but `resumeHideDuration` isn't, we default to `autoHideDuration / 2` ms. |
| <span class="prop-name">ChildrenProp.TransitionComponent</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">Slide</span> | Transition component. |
| <span class="prop-name">MaterialProp.TransitionDuration</span> | <span class="prop-type">U2&lt;float,&nbsp;TransitionDurationProp&nbsp;list&gt;<br><br>type&nbsp;TransitionDurationProp&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Enter&nbsp;of&nbsp;float<br>&nbsp;&nbsp;&#124;&nbsp;Exit&nbsp;of&nbsp;float<br></span> | <span class="prop-default">{  enter: duration.enteringScreen,  exit: duration.leavingScreen,}</span> | The duration for the transition, in milliseconds. You may specify a single timeout for all transitions, or individually with an object. |
| <span class="prop-name">ChildrenProp.TransitionProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the `Transition` element. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.AnchorOriginTopCenter</span> | Styles applied to the root element if `anchorOrigin={{ "top", "center" }}`.
| <span class="prop-name">ClassNames.AnchorOriginBottomCenter</span> | Styles applied to the root element if `anchorOrigin={{ "bottom", "center" }}`.
| <span class="prop-name">ClassNames.AnchorOriginTopRight</span> | Styles applied to the root element if `anchorOrigin={{ "top", "right" }}`.
| <span class="prop-name">ClassNames.AnchorOriginBottomRight</span> | Styles applied to the root element if `anchorOrigin={{ "bottom", "right" }}`.
| <span class="prop-name">ClassNames.AnchorOriginTopLeft</span> | Styles applied to the root element if `anchorOrigin={{ "top", "left" }}`.
| <span class="prop-name">ClassNames.AnchorOriginBottomLeft</span> | Styles applied to the root element if `anchorOrigin={{ "bottom", "left" }}`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Snackbar/Snackbar.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiSnackbar`.

## Demos

- [Snackbars](/demos/snackbars/)

