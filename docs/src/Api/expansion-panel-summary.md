# ExpansionPanelSummary

<p class="description">The API documentation of the ExpansionPanelSummary React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.expansionPanelSummary (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">ExpansionPanelSummaryProp.ExpandIcon</span> | <span class="prop-type">ReactNode</span> |   | The icon to display as the expand indicator. |
| <span class="prop-name">ChildrenProp.IconButtonProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the `TouchRipple` element wrapping the expand icon. |

Any other properties supplied will be spread to the root element ([ButtonBase](#/api/button-base)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Expanded</span> | Styles applied to the root element if `expanded={true}`.
| <span class="prop-name">ClassNames.Focused</span> | Styles applied to the root and children wrapper elements when focused.
| <span class="prop-name">ClassNames.Disabled</span> | Styles applied to the root element if `disabled={true}`.
| <span class="prop-name">ClassNames.Content</span> | Styles applied to the children wrapper element.
| <span class="prop-name">ClassNames.ExpandIcon</span> | Styles applied to the `IconButton` component when `expandIcon` is supplied.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/ExpansionPanelSummary/ExpansionPanelSummary.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiExpansionPanelSummary`.

## Inheritance

The properties of the [ButtonBase](#/api/button-base) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [Expansion Panels](/demos/expansion-panels/)-->

