module GettingStarted.Installation.View

open Components

let text = """
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
"""
let root () =
    Markdown.view text