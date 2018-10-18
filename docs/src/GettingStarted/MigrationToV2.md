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