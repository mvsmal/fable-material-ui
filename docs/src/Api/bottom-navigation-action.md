# BottomNavigationAction

<p class="description">The API documentation of the BottomNavigationAction React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.bottomNavigationAction (props : IHTMLProp list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Icon</span> | <span class="prop-type">ReactNode</span> |   | The icon element. |
| <span class="prop-name">MaterialProp.Label</span> | <span class="prop-type">ReactNode</span> |   | The label element. |
| <span class="prop-name">BottomNavigationActionProp.ShowLabel</span> | <span class="prop-type">bool</span> |   | If `true`, the `BottomNavigationAction` will show its label. By default, only the selected `BottomNavigationAction` inside `BottomNavigation` will show its label. |
| <span class="prop-name">BottomNavigationActionProp.Value</span> | <span class="prop-type">obj</span> |   | You can provide your own value. Otherwise, we fallback to the child position index. |

Any other properties supplied will be spread to the root element ([ButtonBase](#/api/button-base)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Selected</span> | Styles applied to the root element if selected.
| <span class="prop-name">ClassNames.IconOnly</span> | Styles applied to the root element if `showLabel={false}` and not selected.
| <span class="prop-name">ClassNames.Wrapper</span> | Styles applied to the span element that wraps the icon and label.
| <span class="prop-name">ClassNames.Label</span> | Styles applied to the label's span element.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/BottomNavigationAction/BottomNavigationAction.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiBottomNavigationAction`.

## Inheritance

The properties of the [ButtonBase](#/api/button-base) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [Bottom Navigation](/demos/bottom-navigation/)-->

