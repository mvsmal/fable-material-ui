# Drawer

<p class="description">The API documentation of the Drawer React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.drawer (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

The properties of the [Modal](#/api/modal) component are available
when `DrawerProp.Variant = Temporary` is set.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">children</span> | <span class="prop-type">node</span> |   | The contents of the drawer. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Elevation</span> | <span class="prop-type">int</span> | <span class="prop-default">16</span> | The elevation of the drawer. |
| <span class="prop-name">MaterialProp.Open</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the drawer is open. |
| <span class="prop-name">MaterialProp.OnClose</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the component requests to be closed.<br><br>**Signature:**<br>`(event : obj) -> unit`<br>*event:* The event source of the callback |
| <span class="prop-name">MaterialProp.TransitionDuration</span> | <span class="prop-type">U2&lt;float,&nbsp;TransitionDurationProp&nbsp;list&gt;<br><br>type&nbsp;TransitionDurationProp&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Enter&nbsp;of&nbsp;float<br>&nbsp;&nbsp;&#124;&nbsp;Exit&nbsp;of&nbsp;float<br></span> | <span class="prop-default">{ enter: duration.enteringScreen, exit: duration.leavingScreen }</span> | The duration for the transition, in milliseconds. You may specify a single timeout for all transitions, or individually with an object. |
| <span class="prop-name">ChildrenProp.ModalProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the [`Modal`](#/api/modal) element. |
| <span class="prop-name">ChildrenProp.PaperProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the [`Paper`](#/api/paper) element. |
| <span class="prop-name">ChildrenProp.SlideProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the [`Slide`](#/api/slide) element. |
| <span class="prop-name">DrawerProp.Anchor</span> | <span class="prop-type">type&nbsp;Anchor&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Left<br>&nbsp;&nbsp;&#124;&nbsp;Top<br>&nbsp;&nbsp;&#124;&nbsp;Right<br>&nbsp;&nbsp;&#124;&nbsp;Bottom<br></span> | <span class="prop-default">Left</span> | Side from which the drawer will appear. |
| <span class="prop-name">DrawerProp.Variant</span> | <span class="prop-type">type&nbsp;DrawerVariant&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Permanent<br>&nbsp;&nbsp;&#124;&nbsp;Persistent<br>&nbsp;&nbsp;&#124;&nbsp;Temporary<br></span> | <span class="prop-default">Temporary</span> | The variant to use. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Docked</span> | Styles applied to the root element if `variant="permanent or persistent"`.
| <span class="prop-name">ClassNames.Paper</span> | Styles applied to the `Paper` component.
| <span class="prop-name">ClassNames.PaperAnchorLeft</span> | Styles applied to the `Paper` component if `anchor="left"`.
| <span class="prop-name">ClassNames.PaperAnchorRight</span> | Styles applied to the `Paper` component if `anchor="right"`.
| <span class="prop-name">ClassNames.PaperAnchorTop</span> | Styles applied to the `Paper` component if `anchor="top"`.
| <span class="prop-name">ClassNames.PaperAnchorBottom</span> | Styles applied to the `Paper` component if `anchor="bottom"`.
| <span class="prop-name">ClassNames.PaperAnchorDockedLeft</span> | Styles applied to the `Paper` component if `anchor="left"` & `variant` is not "temporary".
| <span class="prop-name">ClassNames.PaperAnchorDockedTop</span> | Styles applied to the `Paper` component if `anchor="top"` & `variant` is not "temporary".
| <span class="prop-name">ClassNames.PaperAnchorDockedRight</span> | Styles applied to the `Paper` component if `anchor="right"` & `variant` is not "temporary".
| <span class="prop-name">ClassNames.PaperAnchorDockedBottom</span> | Styles applied to the `Paper` component if `anchor="bottom"` & `variant` is not "temporary".
| <span class="prop-name">ClassNames.Modal</span> | Styles applied to the `Modal` component.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Drawer/Drawer.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiDrawer`.

<!--## Demos-->

<!--- [Drawers](/demos/drawers/)-->

