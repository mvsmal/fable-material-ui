# Popover

<p class="description">The API documentation of the Popover React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.Popover (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.AnchorEl</span> | <span class="prop-type">type&nbsp;AnchorElProp&nbsp;=&nbsp;U2&lt;EventTarget,&nbsp;unit&#8209;>EventTarget></span> |   | This is the DOM element, or a function that returns the DOM element, that may be used to set the position of the popover. |
| <span class="prop-name">MaterialProp.Container</span> | <span class="prop-type">ReactElementType</span> |   | A node, component instance, or function that returns either. The `container` will passed to the Modal component. By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time. |
| <span class="prop-name">MaterialProp.Elevation</span> | <span class="prop-type">int</span> | <span class="prop-default">8</span> | The elevation of the popover. |
| <span class="prop-name">MaterialProp.OnClose</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the component requests to be closed.<br><br>**Signature:**<br>`(event : obj) -> unit`<br>*event:* The event source of the callback. |
| <span class="prop-name">MaterialProp.OnEnter</span> | <span class="prop-type">obj->unit</span> |   | Callback fired before the component is entering. |
| <span class="prop-name">MaterialProp.OnEntered</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the component has entered. |
| <span class="prop-name">MaterialProp.OnEntering</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the component is entering. |
| <span class="prop-name">MaterialProp.OnExit</span> | <span class="prop-type">obj->unit</span> |   | Callback fired before the component is exiting. |
| <span class="prop-name">MaterialProp.OnExited</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the component has exited. |
| <span class="prop-name">MaterialProp.OnExiting</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the component is exiting. |
| <span class="prop-name required">MaterialProp.Open *</span> | <span class="prop-type">bool</span> |   | If `true`, the popover is visible. |
| <span class="prop-name">MaterialProp.TransitionDuration</span> | <span class="prop-type">U3&lt;float,&nbsp;TransitionDuration&nbsp;list,&nbsp;AutoEnum&gt;<br><br>type&nbsp;TransitionDurationProp&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Enter&nbsp;of&nbsp;float<br>&nbsp;&nbsp;&#124;&nbsp;Exit&nbsp;of&nbsp;float<br><br>type&nbsp;AutoEnum&nbsp;=&nbsp;Auto<br></span> | <span class="prop-default">AutoEnum.Auto</span> | Set to "auto" to automatically calculate transition time based on height. |
| <span class="prop-name">PopoverProp.Action</span> | <span class="prop-type">(IPopoverActions->unit)<br><br>type&nbsp;IPopoverActions&nbsp;=<br>&nbsp;&nbsp;abstract&nbsp;updatePosition:&nbsp;unit&nbsp;-&gt;&nbsp;unit<br></span> |   | This is callback property. It's called by the component on mount. This is useful when you want to trigger an action programmatically. It currently only supports updatePosition() action.<br><br>**Signature:**<br>`(actions: IPopoverActions) -> unit`<br>*actions:* This object contains all posible actions that can be triggered programmatically. |
| <span class="prop-name">PopoverProp.AnchorOrigin</span> | <span class="prop-type">type&nbsp;PopoverOrigin&nbsp;=<br>&nbsp;&nbsp;{&nbsp;horizontal:&nbsp;PopoverHorizontalOrigin<br>&nbsp;&nbsp;&nbsp;&nbsp;vertical:&nbsp;PopoverVerticalOrigin&nbsp;}<br><br>type&nbsp;PopoverHorizontalOrigin&nbsp;=&nbsp;U2&lt;int,PopoverHorizontalPosition&gt;<br>type&nbsp;PopoverVerticalOrigin&nbsp;=&nbsp;U2&lt;int,PopoverVerticalPosition&gt;<br><br>type&nbsp;PopoverHorizontalPosition&nbsp;=&nbsp;Left&nbsp;&#124;&nbsp;Center&nbsp;&#124;&nbsp;Right<br>type&nbsp;PopoverVerticalPosition&nbsp;=&nbsp;Top&nbsp;&#124;&nbsp;Center&nbsp;&#124;&nbsp;Bottom<br></span> | <span class="prop-default">{  vertical: "top",  horizontal: "left",}</span> | This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is "anchorPosition".<br>Options: vertical: [top, center, bottom]; horizontal: [left, center, right]. |
| <span class="prop-name">PopoverProp.AnchorPosition</span> | <span class="prop-type">type&nbsp;AnchorPosition&nbsp;=<br>&nbsp;&nbsp;{&nbsp;left:&nbsp;int<br>&nbsp;&nbsp;&nbsp;&nbsp;top:&nbsp;int&nbsp;}<br></span> |   | This is the position that may be used to set the position of the popover. The coordinates are relative to the application's client area. |
| <span class="prop-name">PopoverProp.AnchorReference</span> | <span class="prop-type">type&nbsp;AnchorReference&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;AnchorEl<br>&nbsp;&nbsp;&#124;&nbsp;AnchorPosition<br>&nbsp;&nbsp;&#124;&nbsp;None<br></span> | <span class="prop-default">AnchorReference.AnchorEl</span> |  |
| <span class="prop-name">PopoverProp.GetContentAnchorEl</span> | <span class="prop-type">obj->obj</span> |   | This function is called in order to retrieve the content anchor element. It's the opposite of the `anchorEl` property. The content anchor element should be an element inside the popover. It's used to correctly scroll and set the position of the popover. The positioning strategy tries to make the content anchor element just above the anchor element. |
| <span class="prop-name">PopoverProp.MarginThreshold</span> | <span class="prop-type">int</span> | <span class="prop-default">16</span> | Specifies how close to the edge of the window the popover can appear. |
| <span class="prop-name">PopoverProp.TransformOrigin</span> | <span class="prop-type">type&nbsp;PopoverOrigin&nbsp;=<br>&nbsp;&nbsp;{&nbsp;horizontal:&nbsp;PopoverHorizontalOrigin<br>&nbsp;&nbsp;&nbsp;&nbsp;vertical:&nbsp;PopoverVerticalOrigin&nbsp;}<br><br>type&nbsp;PopoverHorizontalOrigin&nbsp;=&nbsp;U2&lt;int,PopoverHorizontalPosition&gt;<br>type&nbsp;PopoverVerticalOrigin&nbsp;=&nbsp;U2&lt;int,PopoverVerticalPosition&gt;<br><br>type&nbsp;PopoverHorizontalPosition&nbsp;=&nbsp;Left&nbsp;&#124;&nbsp;Center&nbsp;&#124;&nbsp;Right<br>type&nbsp;PopoverVerticalPosition&nbsp;=&nbsp;Top&nbsp;&#124;&nbsp;Center&nbsp;&#124;&nbsp;Bottom<br></span> | <span class="prop-default">{  vertical: "top",  horizontal: "left",}</span> | This is the point on the popover which will attach to the anchor's origin.<br>Options: vertical: [top, center, bottom, x(px)]; horizontal: [left, center, right, x(px)]. |
| <span class="prop-name">ChildrenProp.ModalClasses</span> | <span class="prop-type">ClassNames list</span> |   | `classes` property applied to the [`Modal`](#/api/modal) element. |
| <span class="prop-name">ChildrenProp.PaperProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the [`Paper`](#/api/paper) element. |
| <span class="prop-name">ChildrenProp.TransitionComponent</span> | <span class="prop-type">ReactElementType</span> | <span class="prop-default">Grow</span> | Transition component. |
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

<!--## Demos-->

<!--- [Menus](/demos/menus/)-->
<!--- [Popover](/utils/popover/)-->

