# Hidden

<p class="description">The API documentation of the Hidden React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.hidden (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

Responsively hides children based on the selected implementation.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">children</span> | <span class="prop-type">node</span> |   | The content of the component. |
| <span class="prop-name">implementation</span> | <span class="prop-type">enum:&nbsp;"js"&nbsp;&#124;<br>&nbsp;"css"<br></span> | <span class="prop-default">"js"</span> | Specify which implementation to use.  "js" is the default, "css" works better for server side rendering. |
| <span class="prop-name">initialWidth</span> | <span class="prop-type">enum:&nbsp;"xs", "sm", "md", "lg", "xl"<br></span> |   | You can use this property when choosing the `js` implementation with server side rendering.<br>As `window.innerWidth` is unavailable on the server, we default to rendering an empty componenent during the first mount. In some situation you might want to use an heristic to approximate the screen width of the client browser screen width.<br>For instance, you could be using the user-agent or the client-hints. https://caniuse.com/#search=client%20hint |
| <span class="prop-name">lgDown</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and down will be hidden. |
| <span class="prop-name">lgUp</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and up will be hidden. |
| <span class="prop-name">mdDown</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and down will be hidden. |
| <span class="prop-name">mdUp</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and up will be hidden. |
| <span class="prop-name">only</span> | <span class="prop-type">union:&nbsp;enum:&nbsp;"xs", "sm", "md", "lg", "xl"<br>&nbsp;&#124;<br>&nbsp;arrayOf<br></span> |   | Hide the given breakpoint(s). |
| <span class="prop-name">smDown</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and down will be hidden. |
| <span class="prop-name">smUp</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and up will be hidden. |
| <span class="prop-name">xlDown</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and down will be hidden. |
| <span class="prop-name">xlUp</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and up will be hidden. |
| <span class="prop-name">xsDown</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and down will be hidden. |
| <span class="prop-name">xsUp</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and up will be hidden. |

Any other properties supplied will be spread to the root element (native element).

## Demos

- [Hidden](/layout/hidden/)

