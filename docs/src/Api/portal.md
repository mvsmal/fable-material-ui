# Portal

<p class="description">The API documentation of the Portal React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.Portal (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

Portals provide a first-class way to render children into a DOM node
that exists outside the DOM hierarchy of the parent component.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Container</span> | <span class="prop-type">ReactInstance</span> |   | A node, component instance, or function that returns either. The `container` will have the portal children appended to it. By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time. |
| <span class="prop-name">MaterialProp.DisablePortal</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | Disable the portal behavior. The children stay within it's parent DOM hierarchy. |
| <span class="prop-name">MaterialProp.OnRendered</span> | <span class="prop-type">obj->unit</span> |   | Callback fired once the children has been mounted into the `container`. |

Any other properties supplied will be spread to the root element (native element).

<!--## Demos-->

<!--- [Portal](/utils/portal/)-->

