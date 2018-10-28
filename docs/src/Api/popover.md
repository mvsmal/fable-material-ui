# Popover

<p class="description">The API documentation of the Popover React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.Popover (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">action</span> | <span class="prop-type">func</span> |   | This is callback property. It's called by the component on mount. This is useful when you want to trigger an action programmatically. It currently only supports updatePosition() action.<br><br>**Signature:**<br>`function(actions: object) => void`<br>*actions:* This object contains all posible actions that can be triggered programmatically. |
| <span class="prop-name">anchorEl</span> | <span class="prop-type">union:&nbsp;object&nbsp;&#124;<br>&nbsp;func<br></span> |   | This is the DOM element, or a function that returns the DOM element, that may be used to set the position of the popover. |
| <span class="prop-name">anchorOrigin</span> | <span class="prop-type">{ horizontal: union:&nbsp;number&nbsp;&#124;<br>&nbsp;enum:&nbsp;"left"&nbsp;&#124;<br>&nbsp;"center"&nbsp;&#124;<br>&nbsp;"right"<br><br>, vertical: union:&nbsp;number&nbsp;&#124;<br>&nbsp;enum:&nbsp;"top"&nbsp;&#124;<br>&nbsp;"center"&nbsp;&#124;<br>&nbsp;"bottom"<br><br> }</span> | <span class="prop-default">{  vertical: "top",  horizontal: "left",}</span> | This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is "anchorPosition".<br>Options: vertical: [top, center, bottom]; horizontal: [left, center, right]. |
| <span class="prop-name">anchorPosition</span> | <span class="prop-type">{ left: number, top: number }</span> |   | This is the position that may be used to set the position of the popover. The coordinates are relative to the application's client area. |
| <span class="prop-name">anchorReference</span> | <span class="prop-type">enum:&nbsp;"anchorEl"&nbsp;&#124;<br>&nbsp;"anchorPosition"&nbsp;&#124;<br>&nbsp;"none"<br></span> | <span class="prop-default">"anchorEl"</span> |  |
| <span class="prop-name">children</span> | <span class="prop-type">node</span> |   | The content of the component. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">container</span> | <span class="prop-type">union:&nbsp;object&nbsp;&#124;<br>&nbsp;func<br></span> |   | A node, component instance, or function that returns either. The `container` will passed to the Modal component. By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time. |
| <span class="prop-name">elevation</span> | <span class="prop-type">number</span> | <span class="prop-default">8</span> | The elevation of the popover. |
| <span class="prop-name">getContentAnchorEl</span> | <span class="prop-type">func</span> |   | This function is called in order to retrieve the content anchor element. It's the opposite of the `anchorEl` property. The content anchor element should be an element inside the popover. It's used to correctly scroll and set the position of the popover. The positioning strategy tries to make the content anchor element just above the anchor element. |
| <span class="prop-name">marginThreshold</span> | <span class="prop-type">number</span> | <span class="prop-default">16</span> | Specifies how close to the edge of the window the popover can appear. |
| <span class="prop-name">ModalClasses</span> | <span class="prop-type">IHTMLProp list</span> |   | `classes` property applied to the [`Modal`](#/api/modal) element. |
| <span class="prop-name">onClose</span> | <span class="prop-type">func</span> |   | Callback fired when the component requests to be closed.<br><br>**Signature:**<br>`(event : obj) -> unit`<br>*event:* The event source of the callback. |
| <span class="prop-name">onEnter</span> | <span class="prop-type">func</span> |   | Callback fired before the component is entering. |
| <span class="prop-name">onEntered</span> | <span class="prop-type">func</span> |   | Callback fired when the component has entered. |
| <span class="prop-name">onEntering</span> | <span class="prop-type">func</span> |   | Callback fired when the component is entering. |
| <span class="prop-name">onExit</span> | <span class="prop-type">func</span> |   | Callback fired before the component is exiting. |
| <span class="prop-name">onExited</span> | <span class="prop-type">func</span> |   | Callback fired when the component has exited. |
| <span class="prop-name">onExiting</span> | <span class="prop-type">func</span> |   | Callback fired when the component is exiting. |
| <span class="prop-name required">MaterialProp.Open *</span> | <span class="prop-type">bool</span> |   | If `true`, the popover is visible. |
| <span class="prop-name">ChildrenProp.PaperProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the [`Paper`](#/api/paper) element. |
| <span class="prop-name">transformOrigin</span> | <span class="prop-type">{ horizontal: union:&nbsp;number&nbsp;&#124;<br>&nbsp;enum:&nbsp;"left"&nbsp;&#124;<br>&nbsp;"center"&nbsp;&#124;<br>&nbsp;"right"<br><br>, vertical: union:&nbsp;number&nbsp;&#124;<br>&nbsp;enum:&nbsp;"top"&nbsp;&#124;<br>&nbsp;"center"&nbsp;&#124;<br>&nbsp;"bottom"<br><br> }</span> | <span class="prop-default">{  vertical: "top",  horizontal: "left",}</span> | This is the point on the popover which will attach to the anchor's origin.<br>Options: vertical: [top, center, bottom, x(px)]; horizontal: [left, center, right, x(px)]. |
| <span class="prop-name">ChildrenProp.TransitionComponent</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">Grow</span> | Transition component. |
| <span class="prop-name">transitionDuration</span> | <span class="prop-type">union:&nbsp;number&nbsp;&#124;<br>&nbsp;{ enter?: number, exit?: number }&nbsp;&#124;<br>&nbsp;enum:&nbsp;"auto"<br><br></span> | <span class="prop-default">"auto"</span> | Set to "auto" to automatically calculate transition time based on height. |
| <span class="prop-name">ChildrenProp.TransitionProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the `Transition` element. |

Any other properties supplied will be spread to the root element ([Modal](#/api/modal)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Paper</span> | Styles applied to the `Paper` component.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Popover/Popover.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiPopover`.

## Inheritance

The properties of the [Modal](#/api/modal) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

## Demos

- [Menus](/demos/menus/)
- [Popover](/utils/popover/)

