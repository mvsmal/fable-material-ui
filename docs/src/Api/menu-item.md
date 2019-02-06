# MenuItem

<p class="description">The API documentation of the MenuItem React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.menuItem (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"li"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">MaterialProp.DisableGutters</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, the left and right padding is removed. |

Any other properties supplied will be spread to the root element ([ListItem](#/api/list-item)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Gutters</span> | Styles applied to the root element if `disableGutters={false}`.
| <span class="prop-name">ClassNames.Selected</span> | Styles applied to the root element if `selected={true}`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/MenuItem/MenuItem.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiMenuItem`.

## Inheritance

The properties of the [ListItem](#/api/list-item) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [Autocomplete](/demos/autocomplete/)-->
<!--- [Menus](/demos/menus/)-->

