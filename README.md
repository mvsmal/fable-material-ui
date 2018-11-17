# Fable.Helpers.MaterialUI

Fable bindings for [Material-UI](https://material-ui.com)

# Installation
<p class="description">Install Fable bindings for Material-UI</p>

## Nuget
Fable Material-UI is available as [Nuget package](https://www.nuget.org/packages/Fable.MaterialUI/)
```sh
dotnet add package Fable.MaterialUI
```
or
```sh
paket add Fable.MaterialUI
```

## NPM
You also need to install [Material-UI](https://material-ui.com/getting-started/installation/) npm package
```sh
npm install @material-ui/core
```
or
```sh
yarn add @material-ui/core
```
If you use yarn, you need to make sure the reference is added to your client project file. 
```sh
    <ItemGroup>
      <PackageReference Include="Fable.MaterialUI" Version="2.4.0" />
    </ItemGroup>
```

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

# Migration to version 2

## Required dependency
Fable.MaterialUI v2 works only with **dotnet-fable** > [2.0.6](https://www.nuget.org/packages/dotnet-fable/2.0.6)

Make sure to use the correct version

## Breaking changes

`Styles.Custom` is now a function and has the signature: `string * CSSProp list -> Styles`. You don't need to manually convert the list of CSS props to an object

Predefined `Styles` props matching class keys are moved to a nested module `Themes.Styles` and require either `open Fable.MaterialUI.Themes.Styles` or qualified access, e.g. `Styles.Root`

`TransitionDuration` is removed from:
* MenuProp
* PopoverProp
* StepContentProp

and moved to `MaterialProp.TransitionDurationAuto` (compiled to `transitionDuration` but allows to pass `AutoEnum.Auto`)

## Other
Since `keyValueList` function is not recursive in Fable 2, there are several properties which have now been replaced with functions, converting a list of DU cases to an object. The usage of those props stays the same, except `Styles` (see above).
