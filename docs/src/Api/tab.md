# Tab

<p class="description">The API documentation of the Tab React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.tab (props : seq<IHTMLProp>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Icon</span> | <span class="prop-type">ReactNode</span> |   | The icon element. |
| <span class="prop-name">MaterialProp.Label</span> | <span class="prop-type">ReactNode</span> |   | The label element. |
| <span class="prop-name">HTMLAttr.Disabled</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the tab will be disabled. |
| <span class="prop-name">MaterialProp.Value</span> | <span class="prop-type">obj</span> |   | You can provide your own value. Otherwise, we fallback to the child position index. |

Any other properties supplied will be spread to the root element ([ButtonBase](#/api/button-base)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.LabelIcon</span> | Styles applied to the root element if both `icon` and `label` are provided.
| <span class="prop-name">ClassNames.TextColorInherit</span> | Styles applied to the root element if `textColor="inherit"`.
| <span class="prop-name">ClassNames.TextColorPrimary</span> | Styles applied to the root element if `textColor="primary"`.
| <span class="prop-name">ClassNames.TextColorSecondary</span> | Styles applied to the root element if `textColor="secondary"`.
| <span class="prop-name">ClassNames.Selected</span> | Styles applied to the root element if `selected={true}` (controlled by the Tabs component).
| <span class="prop-name">ClassNames.Disabled</span> | Styles applied to the root element if `disabled={true}` (controlled by the Tabs component).
| <span class="prop-name">ClassNames.FullWidth</span> | Styles applied to the root element if `fullWidth={true}` (controlled by the Tabs component).
| <span class="prop-name">ClassNames.Wrapper</span> | Styles applied to the `icon` and `label`'s wrapper element.
| <span class="prop-name">ClassNames.LabelContainer</span> | Styles applied to the label container element if `label` is provided.
| <span class="prop-name">ClassNames.Label</span> | Styles applied to the label wrapper element if `label` is provided.
| <span class="prop-name">ClassNames.LabelWrapped</span> | Styles applied to the label wrapper element if `label` is provided and the text is wrapped.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Tab/Tab.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiTab`.

## Inheritance

The properties of the [ButtonBase](#/api/button-base) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [Tabs](/demos/tabs/)-->

