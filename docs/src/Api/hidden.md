# Hidden

<p class="description">The API documentation of the Hidden React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.hidden (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

Responsively hides children based on the selected implementation.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">HiddenProp.Implementation</span> | <span class="prop-type">type&nbsp;HiddenImplementation&nbsp;=&nbsp;Js&nbsp;&#124;&nbsp;Css<br></span> | <span class="prop-default">HiddenImplementation.Js</span> | Specify which implementation to use.  `Js` is the default, `Css` works better for server side rendering. |
| <span class="prop-name">HiddenProp.InitialWidth</span> | <span class="prop-type">type&nbsp;MaterialSize&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Xs<br>&nbsp;&nbsp;&#124;&nbsp;Sm<br>&nbsp;&nbsp;&#124;&nbsp;Md<br>&nbsp;&nbsp;&#124;&nbsp;Lg<br>&nbsp;&nbsp;&#124;&nbsp;Xl<br></span> |   | You can use this property when choosing the `Js` implementation with server side rendering.<br>As `window.innerWidth` is unavailable on the server, we default to rendering an empty componenent during the first mount. In some situation you might want to use an heristic to approximate the screen width of the client browser screen width.<br>For instance, you could be using the user-agent or the client-hints. https://caniuse.com/#search=client%20hint |
| <span class="prop-name">HiddenProp.LgDown</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and down will be hidden. |
| <span class="prop-name">HiddenProp.LgUp</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and up will be hidden. |
| <span class="prop-name">HiddenProp.MdDown</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and down will be hidden. |
| <span class="prop-name">HiddenProp.MdUp</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and up will be hidden. |
| <span class="prop-name">HiddenProp.Only</span> | <span class="prop-type">type&nbsp;HiddenOnly&nbsp;=&nbsp;U2&lt;MaterialSize,&nbsp;MaterialSize&nbsp;list&gt;<br><br>type&nbsp;MaterialSize&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Xs<br>&nbsp;&nbsp;&#124;&nbsp;Sm<br>&nbsp;&nbsp;&#124;&nbsp;Md<br>&nbsp;&nbsp;&#124;&nbsp;Lg<br>&nbsp;&nbsp;&#124;&nbsp;Xl<br></span> |   | Hide the given breakpoint(s). |
| <span class="prop-name">HiddenProp.SmDown</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and down will be hidden. |
| <span class="prop-name">HiddenProp.SmUp</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and up will be hidden. |
| <span class="prop-name">HiddenProp.XlDown</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and down will be hidden. |
| <span class="prop-name">HiddenProp.XlUp</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and up will be hidden. |
| <span class="prop-name">HiddenProp.XsDown</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and down will be hidden. |
| <span class="prop-name">HiddenProp.XsUp</span> | <span class="prop-type">bool</span> | <span class="prop-default">false</span> | If true, screens this size and up will be hidden. |

Any other properties supplied will be spread to the root element (native element).

<!--## Demos-->

<!--- [Hidden](/layout/hidden/)-->

