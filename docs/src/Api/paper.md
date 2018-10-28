# Paper

<p class="description">The API documentation of the Paper React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.Paper (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">children</span> | <span class="prop-type">node</span> |   | The content of the component. |
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"div"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">elevation</span> | <span class="prop-type">number</span> | <span class="prop-default">2</span> | Shadow depth, corresponds to `dp` in the spec. It's accepting values between 0 and 24 inclusive. |
| <span class="prop-name">square</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, rounded corners are disabled. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Rounded</span> | Styles applied to the root element if `square={false}`.
| <span class="prop-name">ClassNames.&#96;&#96;Elevation0&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation1&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation2&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation3&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation4&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation5&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation6&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation7&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation8&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation9&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation10&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation11&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation12&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation13&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation14&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation15&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation16&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation17&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation18&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation19&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation20&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation21&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation22&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation23&#96;&#96;</span> | 
| <span class="prop-name">ClassNames.&#96;&#96;Elevation24&#96;&#96;</span> | 

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Paper/Paper.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiPaper`.

## Demos

- [Autocomplete](/demos/autocomplete/)
- [Cards](/demos/cards/)
- [Paper](/demos/paper/)

