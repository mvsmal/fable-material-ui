# Menu

<p class="description">The API documentation of the Menu React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.menu (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">children</span> | <span class="prop-type">node</span> |   | Menu contents, normally `MenuItem`s. |
| <span class="prop-name">MaterialProp.AnchorEl</span> | <span class="prop-type">ReactInstance</span> |   | The DOM element used to set the position of the menu. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.OnClose</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the component requests to be closed.<br><br>**Signature:**<br>`(event : obj) -> unit`<br>*event:* The event source of the callback |
| <span class="prop-name">MaterialProp.OnEnter</span> | <span class="prop-type">obj->unit</span> |   | Callback fired before the Menu enters. |
| <span class="prop-name">MaterialProp.OnEntered</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the Menu has entered. |
| <span class="prop-name">MaterialProp.OnEntering</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the Menu is entering. |
| <span class="prop-name">MaterialProp.OnExit</span> | <span class="prop-type">obj->unit</span> |   | Callback fired before the Menu exits. |
| <span class="prop-name">MaterialProp.OnExited</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the Menu has exited. |
| <span class="prop-name">MaterialProp.OnExiting</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when the Menu is exiting. |
| <span class="prop-name required">MaterialProp.Open *</span> | <span class="prop-type">bool</span> |   | If `true`, the menu is visible. |
| <span class="prop-name">MaterialProp.TransitionDuration</span> | <span class="prop-type">U3&lt;float,&nbsp;TransitionDuration&nbsp;list,&nbsp;AutoEnum&gt;<br><br>type&nbsp;TransitionDurationProp&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Enter&nbsp;of&nbsp;float<br>&nbsp;&nbsp;&#124;&nbsp;Exit&nbsp;of&nbsp;float<br><br>type&nbsp;AutoEnum&nbsp;=&nbsp;Auto<br></span> | <span class="prop-default">AutoEnum.Auto</span> | The length of the transition in `ms`, or `Auto` |
| <span class="prop-name">MenuProp.DisableAutoFocusItem</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the selected / first menu item will not be auto focused. |
| <span class="prop-name">ChildrenProp.MenuListProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the [`MenuList`](#/api/menu-list) element. |
| <span class="prop-name">ChildrenProp.PopoverClasses</span> | <span class="prop-type">ClassNames list</span> |   | `classes` property applied to the [`Popover`](#/api/popover) element. |

Any other properties supplied will be spread to the root element ([Popover](#/api/popover)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Paper</span> | Styles applied to the `Paper` component.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Menu/Menu.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiMenu`.

## Inheritance

The properties of the [Popover](#/api/popover) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [App Bar](/demos/app-bar/)-->
<!--- [Menus](/demos/menus/)-->

