# ExpansionPanel

<p class="description">The API documentation of the ExpansionPanel React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.expansionPanel (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">HTMLAttr.Disabled</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the panel will be displayed in a disabled state. |
| <span class="prop-name">ExpansionPanelProp.DefaultExpanded</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, expands the panel by default. |
| <span class="prop-name">ExpansionPanelProp.Expanded</span> | <span class="prop-type">bool</span> |   | If `true`, expands the panel, otherwise collapse it. Setting this prop enables control over the panel. |
| <span class="prop-name">ExpansionPanelProp.OnChange</span> | <span class="prop-type">obj->bool->unit</span> |   | Callback fired when the expand/collapse state is changed.<br><br>**Signature:**<br>`(event: obj)->(expanded: bool)->unit`<br>*event:* The event source of the callback<br>*expanded:* The `expanded` state of the panel |
| <span class="prop-name">ChildrenProp.CollapseProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the [`Collapse`](#/api/collapse) element. |

Any other properties supplied will be spread to the root element ([Paper](#/api/paper)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Expanded</span> | Styles applied to the root element if `expanded={true}`.
| <span class="prop-name">ClassNames.Disabled</span> | Styles applied to the root element if `disabled={true}`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/ExpansionPanel/ExpansionPanel.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiExpansionPanel`.

## Inheritance

The properties of the [Paper](#/api/paper) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [Expansion Panels](/demos/expansion-panels/)-->

