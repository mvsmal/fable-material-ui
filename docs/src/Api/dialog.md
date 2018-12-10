# Dialog

<p class="description">The API documentation of the Dialog React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.dialog (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

Dialogs are overlaid modal paper based components with a backdrop.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name required">MaterialProp.Open *</span> | <span class="prop-type">bool</span> |   | If `true`, the Dialog is open. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.FullWidth</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the dialog stretches to `maxWidth`. |
| <span class="prop-name">MaterialProp.OnEnter</span> | <span class="prop-type">obj->unit</span> |   | Callback fired before the dialog enters. |
| <span class="prop-name">MaterialProp.OnEntering</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the dialog is entering. |
| <span class="prop-name">MaterialProp.OnEntered</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the dialog has entered. |
| <span class="prop-name">MaterialProp.OnClose</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the component requests to be closed.<br><br>**Signature:**<br>`(event : obj) -> unit`<br>*event:* The event source of the callback |
| <span class="prop-name">MaterialProp.OnExit</span> | <span class="prop-type">obj->unit</span> |   | Callback fired before the dialog exits. |
| <span class="prop-name">MaterialProp.OnExited</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the dialog has exited. |
| <span class="prop-name">MaterialProp.OnExiting</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the dialog is exiting. |
| <span class="prop-name">MaterialProp.TransitionDuration</span> | <span class="prop-type">U2&lt;float,&nbsp;TransitionDurationProp&nbsp;list&gt;<br><br>type&nbsp;TransitionDurationProp&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Enter&nbsp;of&nbsp;float<br>&nbsp;&nbsp;&#124;&nbsp;Exit&nbsp;of&nbsp;float<br></span> | <span class="prop-default">{ enter: duration.enteringScreen, exit: duration.leavingScreen }</span> | The duration for the transition, in milliseconds. You may specify a single timeout for all transitions, or individually with an object. |
| <span class="prop-name">ModalProp.DisableBackdropClick</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, clicking the backdrop will not fire the `onClose` callback. |
| <span class="prop-name">ModalProp.DisableEscapeKeyDown</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, hitting escape will not fire the `onClose` callback. |
| <span class="prop-name">ModalProp.OnBackdropClick</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the backdrop is clicked. |
| <span class="prop-name">ModalProp.OnEscapeKeyDown</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the escape key is pressed, `disableKeyboard` is false and the modal is in focus. |
| <span class="prop-name">DialogProp.FullScreen</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the dialog will be full-screen |
| <span class="prop-name">DialogProp.MaxWidth</span> | <span class="prop-type">type&nbsp;DialogMaxWidth&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Xs<br>&nbsp;&nbsp;&#124;&nbsp;Sm<br>&nbsp;&nbsp;&#124;&nbsp;Md<br>&nbsp;&nbsp;&#124;&nbsp;Lg<br>&nbsp;&nbsp;&#124;&nbsp;Xl&nbsp;&nbsp;&#124;&nbsp;False<br></span> | <span class="prop-default">DialogMaxWidth.Sm</span> | Determine the max width of the dialog. The dialog width grows with the size of the screen, this property is useful on the desktop where you might need some coherent different width size across your application. Set to `false` to disable `maxWidth`. |
| <span class="prop-name">DialogProp.Scroll</span> | <span class="prop-type">type&nbsp;DialogScroll&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Body<br>&nbsp;&nbsp;&#124;&nbsp;Paper<br></span> | <span class="prop-default">DialogScroll.Paper</span> | Determine the container for scrolling the dialog. |
| <span class="prop-name">ChildrenProp.PaperProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the [`Paper`](#/api/paper) element. |
| <span class="prop-name">ChildrenProp.TransitionComponent</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">Fade</span> | Transition component. |
| <span class="prop-name">ChildrenProp.TransitionProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the `Transition` element. |

Any other properties supplied will be spread to the root element ([Modal](#/api/modal)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.ScrollPaper</span> | Styles applied to the root element if `scroll="paper"`.
| <span class="prop-name">ClassNames.ScrollBody</span> | Styles applied to the root element if `scroll="body"`.
| <span class="prop-name">ClassNames.Paper</span> | Styles applied to the `Paper` component.
| <span class="prop-name">ClassNames.PaperScrollPaper</span> | Styles applied to the `Paper` component if `scroll="paper"`.
| <span class="prop-name">ClassNames.PaperScrollBody</span> | Styles applied to the `Paper` component if `scroll="body"`.
| <span class="prop-name">ClassNames.PaperWidthXs</span> | Styles applied to the `Paper` component if `maxWidth="xs"`.
| <span class="prop-name">ClassNames.PaperWidthSm</span> | Styles applied to the `Paper` component if `maxWidth="sm"`.
| <span class="prop-name">ClassNames.PaperWidthMd</span> | Styles applied to the `Paper` component if `maxWidth="md"`.
| <span class="prop-name">ClassNames.PaperWidthLg</span> | Styles applied to the `Paper` component if `maxWidth="lg"`.
| <span class="prop-name">ClassNames.PaperFullWidth</span> | Styles applied to the `Paper` component if `fullWidth={true}`.
| <span class="prop-name">ClassNames.PaperFullScreen</span> | Styles applied to the `Paper` component if `fullScreen={true}`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Dialog/Dialog.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiDialog`.

## Inheritance

The properties of the [Modal](#/api/modal) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [Dialogs](/demos/dialogs/)-->

