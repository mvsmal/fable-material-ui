# MuiThemeProvider

<p class="description">The API documentation of the MuiThemeProvider React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.muiThemeProvider (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```

This component takes a `MuiThemeProviderProp.Theme` property.
It makes the `theme` available down the React tree thanks to React context.
This component should preferably be used at **the root of your component tree**.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name required">MuiThemeProviderProp.Theme *</span> | <span class="prop-type">type&nbsp;[&lt;Erase&gt;]&nbsp;ProviderTheme&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Theme&nbsp;of&nbsp;Themes.ITheme<br>&nbsp;&nbsp;&#124;&nbsp;Func&nbsp;of&nbsp;(Themes.ITheme-&gt;Themes.ITheme)<br></span> |   | A theme object. |

Any other properties supplied will be spread to the root element (native element).

