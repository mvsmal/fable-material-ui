# InputLabel

<p class="description">The API documentation of the InputLabel React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.inputLabel (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">children</span> | <span class="prop-type">node</span> |   | The contents of the `InputLabel`. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">disableAnimation</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the transition animation is disabled. |
| <span class="prop-name">HTMLAttr.Disabled</span> | <span class="prop-type">bool</span> |   | If `true`, apply disabled class. |
| <span class="prop-name">error</span> | <span class="prop-type">bool</span> |   | If `true`, the label will be displayed in an error state. |
| <span class="prop-name">focused</span> | <span class="prop-type">bool</span> |   | If `true`, the input of this label is focused. |
| <span class="prop-name">FormLabelClasses</span> | <span class="prop-type">IHTMLProp list</span> |   | `classes` property applied to the [`FormLabel`](#/api/form-label) element. |
| <span class="prop-name">margin</span> | <span class="prop-type">enum:&nbsp;"dense"<br></span> |   | If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl. |
| <span class="prop-name">required</span> | <span class="prop-type">bool</span> |   | if `true`, the label will indicate that the input is required. |
| <span class="prop-name">shrink</span> | <span class="prop-type">bool</span> |   | If `true`, the label is shrunk. |
| <span class="prop-name">variant</span> | <span class="prop-type">enum:&nbsp;"standard"&nbsp;&#124;<br>&nbsp;"outlined"&nbsp;&#124;<br>&nbsp;"filled"<br></span> |   | The variant to use. |

Any other properties supplied will be spread to the root element ([FormLabel](#/api/form-label)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.FormControl</span> | Styles applied to the root element if the component is a descendant of `FormControl`.
| <span class="prop-name">ClassNames.MarginDense</span> | Styles applied to the root element if `margin="dense"`.
| <span class="prop-name">ClassNames.Shrink</span> | Styles applied to the `input` element if `shrink={true}`.
| <span class="prop-name">ClassNames.Animated</span> | Styles applied to the `input` element if `disableAnimation={false}`.
| <span class="prop-name">ClassNames.Filled</span> | Styles applied to the root element if `variant="filled"`.
| <span class="prop-name">ClassNames.Outlined</span> | Styles applied to the root element if `variant="outlined"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/InputLabel/InputLabel.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiInputLabel`.

## Inheritance

The properties of the [FormLabel](#/api/form-label) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

## Demos

- [Text Fields](/demos/text-fields/)

