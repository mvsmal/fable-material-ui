# Modal

<p class="description">The API documentation of the Modal React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.modal (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

This component shares many concepts with [react-overlays](https://react-bootstrap.github.io/react-overlays/#modals).

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Container</span> | <span class="prop-type">ReactInstance</span> |   | A node, component instance, or function that returns either. The `container` will have the portal children appended to it. |
| <span class="prop-name">MaterialProp.KeepMounted</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Always keep the children in the DOM. This property can be useful in SEO situation or when you want to maximize the responsiveness of the Modal. |
| <span class="prop-name">MaterialProp.OnClose</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the component requests to be closed. The `reason` parameter can optionally be used to control the response to `onClose`.<br><br>**Signature:**<br>`(event: obj) -> (reason: ModalCloseReason) -> unit`<br>*event:* The event source of the callback<br>*reason:* `type ModalCloseReason = EscapeKeyDown \| BackdropClick` |
| <span class="prop-name">MaterialProp.OnRendered</span> | <span class="prop-type">obj->unit</span> |   | Callback fired once the children has been mounted into the `container`. It signals that the `open={true}` property took effect. |
| <span class="prop-name required">MaterialProp.Open *</span> | <span class="prop-type">bool</span> |   | If `true`, the modal is open. |
| <span class="prop-name">MaterialProp.DisablePortal</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Disable the portal behavior. The children stay within it's parent DOM hierarchy. |
| <span class="prop-name">ModalProp.DisableAutoFocus</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the modal will not automatically shift focus to itself when it opens, and replace it to the last focused element when it closes. This also works correctly with any modal children that have the `disableAutoFocus` prop.<br>Generally this should never be set to `true` as it makes the modal less accessible to assistive technologies, like screen readers. |
| <span class="prop-name">ModalProp.DisableBackdropClick</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, clicking the backdrop will not fire any callback. |
| <span class="prop-name">ModalProp.DisableEnforceFocus</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the modal will not prevent focus from leaving the modal while open.<br>Generally this should never be set to `true` as it makes the modal less accessible to assistive technologies, like screen readers. |
| <span class="prop-name">ModalProp.DisableEscapeKeyDown</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, hitting escape will not fire any callback. |
| <span class="prop-name">ModalProp.DisableRestoreFocus</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the modal will not restore focus to previously focused element once modal is hidden. |
| <span class="prop-name">ModalProp.HideBackdrop</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the backdrop is not rendered. |
| <span class="prop-name">ModalProp.Manager</span> | <span class="prop-type">obj</span> | <span class="prop-default">new ModalManager()</span> | A modal manager used to track and manage the state of open Modals. This enables customizing how modals interact within a container. |
| <span class="prop-name">ModalProp.OnBackdropClick</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the backdrop is clicked. |
| <span class="prop-name">ModalProp.OnEscapeKeyDown</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the escape key is pressed, `disableEscapeKeyDown` is false and the modal is in focus. |
| <span class="prop-name">ChildrenProp.BackdropComponent</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">Backdrop</span> | A backdrop component. This property enables custom backdrop rendering. |
| <span class="prop-name">ChildrenProp.BackdropProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the [`Backdrop`](#/api/backdrop) element. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Hidden</span> | Styles applied to the root element if the `Modal` has exited.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Modal/Modal.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiModal`.

<!--## Demos-->

<!--- [Modal](/utils/modal/)-->

