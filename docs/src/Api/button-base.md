# ButtonBase

<p class="description">The API documentation of the ButtonBase React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.buttonBase (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

`ButtonBase` contains as few styles as possible.
It aims to be a simple building block for creating a button.
It contains a load of style reset and some focus/ripple logic.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"button"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">MaterialProp.DisableRipple</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the ripple effect will be disabled. |
| <span class="prop-name">HTMLAttr.Disabled</span> | <span class="prop-type">bool</span> |   | If `true`, the base button will be disabled. |
| <span class="prop-name">ButtonBaseProp.Action</span> | <span class="prop-type">IButtonBaseActions->unit<br><br>type&nbsp;IButtonBaseActions&nbsp;=<br>&nbsp;&nbsp;abstract&nbsp;focusVisible:&nbsp;unit&nbsp;&#8209;&gt;&nbsp;bool</span> |   | Callback fired when the component mounts. This is useful when you want to trigger an action programmatically. It currently only supports `focusVisible()` action.<br><br>**Signature:**<br>`(actions:IButtonBaseActions)->unit`<br>*actions:* This object contains all possible actions that can be triggered programmatically. |
| <span class="prop-name">ButtonBaseProp.ButtonRef</span> | <span class="prop-type">type&nbsp;RefProp&nbsp;=&nbsp;U2&lt;obj,(ReactInstance&#8209;>unit)></span> |   | Use that property to pass a ref callback to the native button component. |
| <span class="prop-name">ButtonBaseProp.CenterRipple</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the ripples will be centered. They won't start at the cursor interaction position. |
| <span class="prop-name">ButtonBaseProp.DisableTouchRipple</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the touch ripple effect will be disabled. |
| <span class="prop-name">ButtonBaseProp.FocusRipple</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the base button will have a keyboard focus ripple. `disableRipple` must also be `false`. |
| <span class="prop-name">ButtonBaseProp.FocusVisibleClassName</span> | <span class="prop-type">string</span> |   | This property can help a person know which element has the keyboard focus. The class name will be applied when the element gain the focus through a keyboard interaction. It's a polyfill for the [CSS :focus-visible feature](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rational for using this feature [is explain here](https://github.com/WICG/focus-visible/blob/master/explainer.md). |
| <span class="prop-name">ButtonBaseProp.OnFocusVisible</span> | <span class="prop-type">FocusEvent->unit</span> |   | Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too. |
| <span class="prop-name">ButtonBaseProp.Type</span> | <span class="prop-type">type&nbsp;ButtonBaseType&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Button<br>&nbsp;&nbsp;&#124;&nbsp;Submit<br>&nbsp;&nbsp;&#124;&nbsp;Reset<br></span> | <span class="prop-default">ButtonBaseType.Button</span> | Used to control the button's purpose. This property passes the value to the `type` attribute of the native button component. Valid property values include `button`, `submit`, and `reset`. |
| <span class="prop-name">ChildrenProp.TouchRippleProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the `TouchRipple` element. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Disabled</span> | Styles applied to the root element if `disabled={true}`.
| <span class="prop-name">ClassNames.FocusVisible</span> | Styles applied to the root element if keyboard focused.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/ButtonBase/ButtonBase.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiButtonBase`.

## Demos

- [Buttons](#/demos/buttons/)

