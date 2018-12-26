# Paper

<p class="description">The API documentation of the Paper React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.Paper (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"div"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">MaterialProp.Elevation</span> | <span class="prop-type">int</span> | <span class="prop-default">2</span> | Shadow depth, corresponds to `dp` in the spec. It's accepting values between 0 and 24 inclusive. |
| <span class="prop-name">PaperProp.Square</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If `true`, rounded corners are disabled. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Rounded</span> | Styles applied to the root element if `square={false}`.
| <span class="prop-name">ClassNames.Elevation0</span> | 
| <span class="prop-name">ClassNames.Elevation1</span> | 
| <span class="prop-name">ClassNames.Elevation2</span> | 
| <span class="prop-name">ClassNames.Elevation3</span> | 
| <span class="prop-name">ClassNames.Elevation4</span> | 
| <span class="prop-name">ClassNames.Elevation5</span> | 
| <span class="prop-name">ClassNames.Elevation6</span> | 
| <span class="prop-name">ClassNames.Elevation7</span> | 
| <span class="prop-name">ClassNames.Elevation8</span> | 
| <span class="prop-name">ClassNames.Elevation9</span> | 
| <span class="prop-name">ClassNames.Elevation10</span> | 
| <span class="prop-name">ClassNames.Elevation11</span> | 
| <span class="prop-name">ClassNames.Elevation12</span> | 
| <span class="prop-name">ClassNames.Elevation13</span> | 
| <span class="prop-name">ClassNames.Elevation14</span> | 
| <span class="prop-name">ClassNames.Elevation15</span> | 
| <span class="prop-name">ClassNames.Elevation16</span> | 
| <span class="prop-name">ClassNames.Elevation17</span> | 
| <span class="prop-name">ClassNames.Elevation18</span> | 
| <span class="prop-name">ClassNames.Elevation19</span> | 
| <span class="prop-name">ClassNames.Elevation20</span> | 
| <span class="prop-name">ClassNames.Elevation21</span> | 
| <span class="prop-name">ClassNames.Elevation22</span> | 
| <span class="prop-name">ClassNames.Elevation23</span> | 
| <span class="prop-name">ClassNames.Elevation24</span> | 

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Paper/Paper.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiPaper`.

<!--## Demos-->

<!--- [Autocomplete](/demos/autocomplete/)-->
<!--- [Cards](/demos/cards/)-->
<!--- [Paper](/demos/paper/)-->

