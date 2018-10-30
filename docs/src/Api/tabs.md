# Tabs

<p class="description">The API documentation of the Tabs React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.tabs (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"div"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">MaterialProp.FullWidth</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the tabs will grow to use all the available space. This property is intended for small views, like on mobile. |
| <span class="prop-name">MaterialProp.Value</span> | <span class="prop-type">obj</span> |   | The value of the currently selected `Tab`. If you don't want any selected `Tab`, you can set this property to `false`. |
| <span class="prop-name">TabsProp.Action</span> | <span class="prop-type">ITabsActions->unit<br><br>type&nbsp;ITabsActions&nbsp;=<br>&nbsp;&nbsp;abstract&nbsp;updateIndicator:&nbsp;unit&nbsp;-&gt;&nbsp;unit<br></span> |   | Callback fired when the component mounts. This is useful when you want to trigger an action programmatically. It currently only supports `updateIndicator()` action.<br><br>**Signature:**<br>`(actions: ITabsActions) -> unit`<br>*actions:* This object contains all possible actions that can be triggered programmatically. |
| <span class="prop-name">TabsProp.Centered</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the tabs will be centered. This property is intended for large views. |
| <span class="prop-name">TabsProp.IndicatorColor</span> | <span class="prop-type">type&nbsp;TabsIndicatorColor&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Primary<br>&nbsp;&nbsp;&#124;&nbsp;Secondary<br></span> | <span class="prop-default">IndicatorColor.Secondary</span> | Determines the color of the indicator. |
| <span class="prop-name">TabsProp.OnChange</span> | <span class="prop-type">obj->int->unit</span> |   | Callback fired when the value changes.<br><br>**Signature:**<br>`(event: obj) -> (value: int) -> unit`<br>*event:* The event source of the callback<br>*value:* We default to the index of the child |
| <span class="prop-name">TabsProp.Scrollable</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | True invokes scrolling properties and allow for horizontally scrolling (or swiping) the tab bar. |
| <span class="prop-name">TabsProp.ScrollButtons</span> | <span class="prop-type">type&nbsp;ScrollButtonsType&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Auto<br>&nbsp;&nbsp;&#124;&nbsp;On<br>&nbsp;&nbsp;&#124;&nbsp;Off<br></span> | <span class="prop-default">ScrollButtonsThype.Auto</span> | Determine behavior of scroll buttons when tabs are set to scroll `auto` will only present them on medium and larger viewports `on` will always present them `off` will never present them |
| <span class="prop-name">TabsProp.TextColor</span> | <span class="prop-type">type&nbsp;TabsTextColor&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Primary<br>&nbsp;&nbsp;&#124;&nbsp;Secondary<br>&nbsp;&nbsp;&#124;&nbsp;Inherit<br></span> | <span class="prop-default">TabsTextColor.Inherit</span> | Determines the color of the `Tab`. |
| <span class="prop-name">ChildrenProp.ScrollButtonComponent</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">TabScrollButton</span> | The component used to render the scroll buttons. |
| <span class="prop-name">ChildrenProp.TabIndicatorProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the `TabIndicator` element. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.FlexContainer</span> | Styles applied to the flex container element.
| <span class="prop-name">ClassNames.Centered</span> | Styles applied to the flex container element if `centered={true}` & `scrollable={false}`.
| <span class="prop-name">ClassNames.Scroller</span> | Styles applied to the tablist element.
| <span class="prop-name">ClassNames.Fixed</span> | Styles applied to the tablist element if `scrollable={false}`.
| <span class="prop-name">ClassNames.Scrollable</span> | Styles applied to the tablist element if `scrollable={true}`.
| <span class="prop-name">ClassNames.ScrollButtons</span> | Styles applied to the `ScrollButtonComponent` component.
| <span class="prop-name">ClassNames.ScrollButtonsAuto</span> | Styles applied to the `ScrollButtonComponent` component if `scrollButtons="auto"`.
| <span class="prop-name">ClassNames.Indicator</span> | Styles applied to the `TabIndicator` component.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Tabs/Tabs.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiTabs`.

<!--## Demos-->

<!--- [Tabs](/demos/tabs/)-->

