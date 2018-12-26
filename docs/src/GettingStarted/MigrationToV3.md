# Migration to version 3

Namespace `Fable.Helpers.MaterialUI` has been changed to `Fable.MaterialUI.Core` for consistency.

Imported _PascalCased_ `ComponentClass<'P>` components have been removed for tree-shaking support. If you need them, just import manually, e.g:
```fsharp
let AppBar<'P> = importDefault<Fable.Import.React.ComponentClass<'P>> "@material-ui/core/AppBar"
```

`ITransitions.create` method signature has been changed to (notice `string[]` instead of `string list`):
```fsharp
abstract create: props : U2<string, string[]> * ?options: ITransitionOptions -> string
```