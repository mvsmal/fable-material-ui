# Usage
<p class="description">How to use the bindings</p>

Simply open Fable.MaterialUI.Core and Props module
```fsharp
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
```
There are several components, such as `button`, which are also present in `Fable.Helpers.React`. To avoid conflicts you can assign module names:
```fsharp
module R = Fable.Helpers.React
module Mui = Fable.MaterialUI.Core
```

## Minimal example
```fsharp
module R = Fable.Helpers.React
module Mui = Fable.MaterialUI.Core
open Fable.MaterialUI.Props

let view =
    Mui.button [
        ButtonProp.Variant ButtonVariant.Contained
    ] [ R.str "Hello world!" ]
```