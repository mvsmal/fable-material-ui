# MuiThemeProvider

<p class="description">The API documentation of the MuiThemeProvider React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.muiThemeProvider (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

This component takes a `MuiThemeProviderProp.Theme` property.
It makes the `theme` available down the React tree thanks to React context.
This component should preferably be used at **the root of your component tree**.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name required">children *</span> | <span class="prop-type">node</span> |   | You can wrap a node. |
| <span class="prop-name required">MuiThemeProviderProp.Theme *</span> | <span class="prop-type">type&nbsp;[&lt;Erase&gt;]&nbsp;ProviderTheme&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Theme&nbsp;of&nbsp;Themes.ITheme<br>&nbsp;&nbsp;&#124;&nbsp;Func&nbsp;of&nbsp;(Themes.ITheme-&gt;Themes.ITheme)<br></span> |   | A theme object. |
| <span class="prop-name">MuiThemeProviderProp.DisableStylesGeneration</span> | <span class="prop-type">bool</span> |   | You can disable the generation of the styles with this option. It can be useful when traversing the React tree outside of the HTML rendering step on the server. Let's say you are using react-apollo to extract all the queries made by the interface server side. You can significantly speed up the traversal with this property. |
| <span class="prop-name">MuiThemeProviderProp.SheetsManager</span> | <span class="prop-type">obj</span> |   | The sheetsManager is used to deduplicate style sheet injection in the page. It's deduplicating using the (theme, styles) couple. On the server, you should provide a new instance for each request. |

Any other properties supplied will be spread to the root element (native element).

