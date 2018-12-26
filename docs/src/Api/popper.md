# Popper

<p class="description">The API documentation of the Popper React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.Popper (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

Poppers rely on the 3rd party library [Popper.js](https://github.com/FezVrasta/popper.js) for positioning.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.AnchorEl</span> | <span class="prop-type">ReactInstance</span> |   | This is the DOM element, or a function that returns the DOM element, that may be used to set the position of the popover. The return value will passed as the reference object of the Popper instance. |
| <span class="prop-name">MaterialProp.Container</span> | <span class="prop-type">ReactType</span> |   | A node, component instance, or function that returns either. The `container` will passed to the Modal component. By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time. |
| <span class="prop-name required">MaterialProp.Open *</span> | <span class="prop-type">bool</span> |   | If `true`, the popper is visible. |
| <span class="prop-name">MaterialProp.DisablePortal</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Disable the portal behavior. The children stay within it's parent DOM hierarchy. |
| <span class="prop-name">MaterialProp.KeepMounted</span> | <span class="prop-type">bool</span> |   | Always keep the children in the DOM. This property can be useful in SEO situation or when you want to maximize the responsiveness of the Popper. |
| <span class="prop-name">MaterialProp.Placement</span> | <span class="prop-type">type&nbsp;PlacementType&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;BottomEnd<br>&nbsp;&nbsp;&#124;&nbsp;BottomStart<br>&nbsp;&nbsp;&#124;&nbsp;Bottom<br>&nbsp;&nbsp;&#124;&nbsp;LeftEnd<br>&nbsp;&nbsp;&#124;&nbsp;LeftStart<br>&nbsp;&nbsp;&#124;&nbsp;Left<br>&nbsp;&nbsp;&#124;&nbsp;RightEnd<br>&nbsp;&nbsp;&#124;&nbsp;RightStart<br>&nbsp;&nbsp;&#124;&nbsp;Right<br>&nbsp;&nbsp;&#124;&nbsp;TopEnd<br>&nbsp;&nbsp;&#124;&nbsp;TopStart<br>&nbsp;&nbsp;&#124;&nbsp;Top<br></span> | <span class="prop-default">PlacementType.Bottom</span> | Popper placement. |
| <span class="prop-name">PopperProp.Modifiers</span> | <span class="prop-type">obj</span> |   | Popper.js is based on a "plugin-like" architecture, most of its features are fully encapsulated "modifiers".<br>A modifier is a function that is called each time Popper.js needs to compute the position of the popper. For this reason, modifiers should be very performant to avoid bottlenecks. To learn how to create a modifier, [read the modifiers documentation](https://github.com/FezVrasta/popper.js/blob/master/docs/_includes/popper-documentation.md#modifiers--object). |
| <span class="prop-name">PopperProp.PopperOptions</span> | <span class="prop-type">obj</span> |   | Options provided to the [`popper.js`](https://github.com/FezVrasta/popper.js) instance. |
| <span class="prop-name">PopperProp.Transition</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Help supporting a react-transition-group/Transition component. |

Any other properties supplied will be spread to the root element (native element).

<!--## Demos-->

<!--- [Autocomplete](/demos/autocomplete/)-->
<!--- [Menus](/demos/menus/)-->
<!--- [Popper](/utils/popper/)-->

