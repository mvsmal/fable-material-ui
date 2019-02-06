# SnackbarContent

<p class="description">The API documentation of the SnackbarContent React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.snackbarContent (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">SnackbarProp.Action</span> | <span class="prop-type">ReactElement</span> |   | The action to display. |
| <span class="prop-name">SnackbarProp.Message</span> | <span class="prop-type">ReactElement</span> |   | The message to display. |

Any other properties supplied will be spread to the root element ([Paper](#/api/paper)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Message</span> | Styles applied to the message wrapper element.
| <span class="prop-name">ClassNames.Action</span> | Styles applied to the action wrapper element if `action` is provided.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/SnackbarContent/SnackbarContent.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiSnackbarContent`.

## Inheritance

The properties of the [Paper](#/api/paper) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [Snackbars](/demos/snackbars/)-->

