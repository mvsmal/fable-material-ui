module GettingStarted.Usage.View
open Components

let text = """
# Usage
<p class="description">How to use the bindings</p>

Simply open Fable.Helpers.MaterialUI and Props module
```fsharp
open Fable.Helpers.MaterialUI
open Fable.MaterialUI.Props
```
There are several components, such as `button`, which are also present in `Fable.Helpers.React`. To avoid conflicts you can assign module names:
```fsharp
module R = Fable.Helpers.React
module Mui = Fable.Helpers.MaterialUI
```

## Minimal example
```fsharp
module R = Fable.Helpers.React
module Mui = Fable.Helpers.MaterialUI
open Fable.MaterialUI.Props

let view =
    Mui.button [
        ButtonProp.Variant ButtonVariant.Contained
    ] [ R.str "Hello world!" ]
```
"""
let root () =
    Markdown.view text
