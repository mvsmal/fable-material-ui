# Usage
<p class="description">How to use the bindings</p>

Simply open Fable.MaterialUI.Core and Props module
```fsharp
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
```
There are several components, such as `button`, which are also present in `Fable.React.Standard`. To avoid conflicts you can assign module names:
```fsharp
module R = Fable.React.Standard
module Mui = Fable.MaterialUI.Core
```

## Minimal example
```fsharp
open Fable.React
open Fable.MaterialUI.Props
module Mui = Fable.MaterialUI.Core

let view =
    Mui.button [
        ButtonProp.Variant ButtonVariant.Contained
    ] [ str "Hello world!" ]
```