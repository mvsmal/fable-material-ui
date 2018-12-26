# Chip

<p class="description">The API documentation of the Chip React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.chip (props : IHTMLProp list) : ReactElement
```

Chips represent complex entities in small blocks, such as a contact.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Color</span> | <span class="prop-type">type&nbsp;ComponentColor&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Default<br>&nbsp;&nbsp;&#124;&nbsp;Primary<br>&nbsp;&nbsp;&#124;&nbsp;Secondary<br></span> | <span class="prop-default">ComponentColor.Default</span> | The color of the component. It supports those theme colors that make sense for this component. |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"div"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">MaterialProp.Icon</span> | <span class="prop-type">ReactNode</span> |   | Icon element. |
| <span class="prop-name">MaterialProp.Label</span> | <span class="prop-type">ReactNode</span> |   | The content of the label. |
| <span class="prop-name">ChipProp.Avatar</span> | <span class="prop-type">ReactElement</span> |   | Avatar element. |
| <span class="prop-name">ChipProp.Clickable</span> | <span class="prop-type">bool</span> |   | If true, the chip will appear clickable, and will raise when pressed, even if the onClick property is not defined. If false, the chip will not be clickable, even if onClick peoperty is defined. This can be used, for example, along with the component property to indicate an anchor Chip is clickable. |
| <span class="prop-name">ChipProp.DeleteIcon</span> | <span class="prop-type">ReactElement</span> |   | Override the default delete icon element. Shown only if `onDelete` is set. |
| <span class="prop-name">ChipProp.OnDelete</span> | <span class="prop-type">FormEvent->unit</span> |   | Callback function fired when the delete icon is clicked. If set, the delete icon will be shown. |
| <span class="prop-name">ChipProp.Variant</span> | <span class="prop-type">type&nbsp;ChipVariant&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Default<br>&nbsp;&nbsp;&#124;&nbsp;Outlined<br></span> | <span class="prop-default">ChipVariant.Default</span> | The variant to use. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.ColorPrimary</span> | Styles applied to the root element if `color="primary"`.
| <span class="prop-name">ClassNames.ColorSecondary</span> | Styles applied to the root element if `color="secondary"`.
| <span class="prop-name">ClassNames.Clickable</span> | Styles applied to the root element if `onClick` is defined or `clickable={true}`.
| <span class="prop-name">ClassNames.ClickableColorPrimary</span> | 
| <span class="prop-name">ClassNames.ClickableColorSecondary</span> | 
| <span class="prop-name">ClassNames.Deletable</span> | Styles applied to the root element if `onDelete` is defined.
| <span class="prop-name">ClassNames.DeletableColorPrimary</span> | Styles applied to the root element if `onDelete` and `color="primary"` is defined.
| <span class="prop-name">ClassNames.DeletableColorSecondary</span> | Styles applied to the root element if `onDelete` and `color="secondary"` is defined.
| <span class="prop-name">ClassNames.Outlined</span> | Styles applied to the root element if `variant="outlined"`.
| <span class="prop-name">ClassNames.OutlinedPrimary</span> | Styles applied to the root element if `variant="outlined"` and `color="primary"`.
| <span class="prop-name">ClassNames.OutlinedSecondary</span> | Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
| <span class="prop-name">ClassNames.Avatar</span> | Styles applied to the `avatar` element.
| <span class="prop-name">ClassNames.AvatarColorPrimary</span> | Styles applied to the `avatar` element if `color="primary"`
| <span class="prop-name">ClassNames.AvatarColorSecondary</span> | Styles applied to the `avatar` element if `color="secondary"`
| <span class="prop-name">ClassNames.AvatarChildren</span> | Styles applied to the `avatar` elements children.
| <span class="prop-name">ClassNames.Icon</span> | Styles applied to the `icon` element.
| <span class="prop-name">ClassNames.IconColorPrimary</span> | Styles applied to the `icon` element if `color="primary"`
| <span class="prop-name">ClassNames.IconColorSecondary</span> | Styles applied to the `icon` element if `color="secondary"`
| <span class="prop-name">ClassNames.Label</span> | Styles applied to the label `span` element`.
| <span class="prop-name">ClassNames.DeleteIcon</span> | Styles applied to the `deleteIcon` element.
| <span class="prop-name">ClassNames.DeleteIconColorPrimary</span> | Styles applied to the deleteIcon element if `color="primary"` and `variant="default"`.
| <span class="prop-name">ClassNames.DeleteIconColorSecondary</span> | Styles applied to the deleteIcon element if `color="secondary"` and `variant="default"`.
| <span class="prop-name">ClassNames.DeleteIconOutlinedColorPrimary</span> | Styles applied to the deleteIcon element if `color="primary"` and `variant="outlined"`.
| <span class="prop-name">ClassNames.DeleteIconOutlinedColorSecondary</span> | Styles applied to the deleteIcon element if `color="secondary"` and `variant="outlined"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Chip/Chip.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiChip`.

<!--## Demos-->

<!--- [Chips](/demos/chips/)-->

