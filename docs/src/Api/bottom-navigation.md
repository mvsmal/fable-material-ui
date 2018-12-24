# BottomNavigation

<p class="description">The API documentation of the BottomNavigation React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.bottomNavigation (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"div"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">BottomNavigationProp.OnChange</span> | <span class="prop-type">obj->obj->unit</span> |   | Callback fired when the value changes.<br><br>**Signature:**<br>`(event:obj)->(value:obj)->unit`<br>*event:* The event source of the callback<br>*value:* We default to the index of the child |
| <span class="prop-name">BottomNavigationProp.ShowLabels</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, all `BottomNavigationAction`s will show their labels. By default, only the selected `BottomNavigationAction` will show its label. |
| <span class="prop-name">BottomNavigationProp.Value</span> | <span class="prop-type">obj</span> |   | The value of the currently selected `BottomNavigationAction`. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/BottomNavigation/BottomNavigation.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiBottomNavigation`.

<!--## Demos-->

<!--- [Bottom Navigation](/demos/bottom-navigation/)-->

