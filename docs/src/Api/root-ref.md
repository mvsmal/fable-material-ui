# RootRef

<p class="description">The API documentation of the RootRef React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.rootRef (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

Helper component to allow attaching a ref to a
wrapped element to access the underlying DOM element.

It's highly inspired by https://github.com/facebook/react/issues/11401#issuecomment-340543801.
For example:
```fsharp
open Fable.Core
open Fable.Import.React
open Fable.Helpers.React
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props

type MyComponent() =
    inherit Component<unit,unit>()
    let domRef = createRef()

    override __.componentDidMount() =
        Fable.Import.Browser.console.log(domRef?current)
    
    override __.render() =
        rootRef [ RootRefProp.RootRef (domRef |> U2.Case1) ] [
            someChildComponent
        ]
```

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name required">RootRefProp.RootRef *</span> | <span class="prop-type">type&nbsp;RefProp&nbsp;=&nbsp;U2&lt;obj,(ReactInstance&#8209;>unit)></span> |   | Provide a way to access the DOM node of the wrapped element. You can provide a callback ref or a `React.createRef()` ref. |

Any other properties supplied will be spread to the root element (native element).

