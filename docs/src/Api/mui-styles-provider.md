# MuiStylesProvider

<p class="description">The API documentation of the MuiStylesProvider React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.muiStylesProvider (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```

This component takes a `MuiStylesProviderProp.Theme` property.
This component allows you to change the behavior of the styling solution.
It makes the options available down the React tree thanks to the context.
This component should preferably be used at **the root of your component tree**.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MuiStylesProviderProp.DisableGeneration</span> | <span class="prop-type">bool</span> | false | You can disable the generation of the styles with this option. It can be useful when traversing the React tree outside of the HTML rendering step on the server. Let's say you are using react-apollo to extract all the queries made by the interface server-side. You can significantly speed up the traversal with this property. |
| <span class="prop-name">MuiStylesProviderProp.GenerateClassName</span> | <span class="prop-type">obj-&gt;(obj-&gt;string)</span> | | JSS's class name generator. |
| <span class="prop-name">MuiStylesProviderProp.InjectFirst</span> | <span class="prop-type">bool</span> | false | By default, the styles are injected last in the `<head>` element of the page. As a result, they gain more specificity than any other style sheet. If you want to override Material-UI's styles, set this prop. |
| <span class="prop-name">MuiStylesProviderProp.Jss</span> | <span class="prop-type">obj</span> | | JSS's instance. |
| <span class="prop-name">MuiStylesProviderProp.ServerGenerateClassName</span> | <span class="prop-type">obj</span> | | |
| <span class="prop-name">MuiStylesProviderProp.SheetsCache</span> | <span class="prop-type">obj</span> | | Beta feature. |
| <span class="prop-name">MuiStylesProviderProp.SheetsManager</span> | <span class="prop-type">obj</span> |   | The sheetsManager is used to deduplicate style sheet injection in the page. It's deduplicating using the (theme, styles) couple. On the server, you should provide a new instance for each request. |
| <span class="prop-name">MuiStylesProviderProp.SheetsRegistry</span> | <span class="prop-type">obj</span> | | Collect the sheets. Used on server side rendering |

Any other properties supplied will be spread to the root element (native element).

