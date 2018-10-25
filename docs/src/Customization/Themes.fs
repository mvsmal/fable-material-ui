module Customization.Themes.View

open Fable.Core.JsInterop
open Fable.Helpers.React

open Components

let text = importDefault "./Themes.md"

let colorToolText = """
#### Color tool

Need inspiration? The Material Design team has built an awesome
[palette configuration tool](https://material-ui.com/style/color/#color-tool) to help you.
"""

let darkThemeText = """
### Type (light /dark theme)

You can make the theme dark by setting `PaletteProp.Type` to `PaletteType.Dark`.
While it's only a single property value change, internally it modifies the value of the following keys:
- `palette.text`
- `palette.divider`
- `palette.background`
- `palette.action`

```fsharp
let theme = createMuiTheme [
                ThemeProp.Palette [
                    PaletteProp.Type PaletteType.Dark
                ]
            ]
```
"""

let typographyThemeText = """
### Typography

Too many type sizes and styles at once can spoil any layout.
The theme provides a **limited set of type sizes** that work well together along with the layout grid.
These sizes are used across the components.

Have a look at the following example regarding changing the default values, such as the font family.
""" // If you want to learn more about typography, you can check out [the typography section](/style/typography/).

let typographyFontFamilyText = """
### Typography - Font family

```fsharp
let theme = createMuiTheme [
                ThemeProp.Typography [
                    ThemeTypographyProp.UseNextVariants true
                    ThemeTypographyProp.FontFamily ([
                        "-apple-system"
                        "BlinkMacSystemFont"
                        "\"Segou UI\""
                        "Roboto"
                        "\"Helvetica Neue\""
                        "Arial"
                        "sans-serif"
                        "\"Apple Color Emoji\""
                        "\"Segoe UI Emoji\""
                        "\"Segoe UI Symbol\"" ] |> String.concat(","))
                ]
            ]
```
"""

let typographyFontSizeText = """
### Typography - Font size

Material-UI uses `rem` units for the font size.
The browser `<html>` element default font size is `16px`, but browsers have an option to change this value,
so `rem` units allow us to accommodate the user's settings, resulting in a much better user experience.
Users change font size settings for all kinds of reasons, from poor eyesight to choosing optimum settings
for devices that can be vastly different in size and viewing distance.

To change the font-size of Material-UI you can provide a `ThemeTypographyProp.FontSize` property.
The default value is `14px`.

```fsharp
let theme = createMuiTheme [
                ThemeProp.Typography [
                    ThemeTypographyProp.FontSize "12"
                ]
            ]
```
The computed font size by the browser follows this mathematical equation:

![font-size](/img/font-size.gif)
"""

let htmlFontSizeText = """
### Typography - HTML font size

You might want to change the `<html>` element default font size. For instance, when using the [10px simplification](https://www.sitepoint.com/understanding-and-using-rem-units-in-css/).
We provide a `ThemeTypographyProp.HtmlFontSize` theme property for this use case.
It's telling Material-UI what's the font-size on the `<html>` element is.
It's used to adjust the `rem` value so the calculated font-size always match the specification.

```fsharp
let theme = createMuiTheme [
                ThemeProp.Typography [
                    // Tell Material-UI what's the font-size on the html element is.
                    ThemeTypographyProp.HtmlFontSize "12"
                ]
            ]
```

```css
html {
  font-size: 62.5%; /* 62.5% of 16px = 10px */
}
```

*You need to apply the above CSS on the html element of this page to see the below demo rendered correctly*
"""

let customVariablesText = """
### Custom variables

When using Material-UI's [styling solution](#/customization/css-in-js) with your own components,
you can also take advantage of the theme.
It can be convenient to add additional variables to the theme so you can use them everywhere.
For instance:
"""

let otherVariablesText = """
### Other variables

In addition to the palette, dark and light types, and typography, the theme normalizes implementation by providing many more default values, such as breakpoints, shadows, transitions, etc.
You can check out the 
<a href="https://material-ui.com/customization/default-theme/" target="_blank">default theme section</a> to view the default theme in full.
"""

let overrideCSSText = """
## Customizing all instances of a component type

### CSS

When the configuration variables aren't powerful enough, you can take advantage of the
`ThemeProp.Overrides` key of the `theme` to potentially change every single **style** injected by Material-UI into the DOM.
That's a really powerful feature.

```fsharp
let theme = createMuiTheme [
                ThemeProp.Overrides [
                    Overrides.MuiButton [ // Name of the component ⚛️ / style sheet
                        Styles.Root [ // Name of the rule
                            CSSProp.Color "white" // Some CSS
                        ]
                    ]
                ]
            ]
```
"""

let overridesPropertiesText = """
### Properties

You can also apply properties on all the instances of a component type.
We expose a `ThemeProp.Props` key in the `theme` for this use case.

```fsharp
let theme = createMuiTheme [
                ThemeProp.Props [
                    // Name of the component ⚛️
                    ThemePropsProp.MuiButtonBase [
                        // The properties to apply
                        MaterialProp.DisableRipple true // No more ripple, on the whole application!
                    ]
                ]
            ]
```
"""

let withThemeText = """
## Accessing the theme in a component

You might need to access the theme variables inside your React components.
Let's say you want to display the value of the primary color, you can use the `withTheme()` higher-order component to do so. Here is an example:
"""

let nestedText = """
## Nesting the theme

The theming solution is very flexible, as you can nest multiple theme providers.
This can be really useful when dealing with different area of your application that have distinct appearance from each other.
"""

let performanceNote = """
#### A note on performance

The performance implications of nesting the `MuiThemeProvider` component are linked to JSS's work behind the scenes.
The main point to understand is that we cache the injected CSS with the following tuple `(styles, theme)`.
- `theme`: If you provide a new theme at each render, a new CSS object will be computed and injected. Both for UI consistency and performance, it's better to render a limited number of theme objects.
- `styles`: The larger the styles object is, the more work is needed.
"""

let apiText = """
## API

### `muiThemeProvider`

This component takes a `MuiThemeProviderProp.Theme` property, and makes the `theme` available down the React tree thanks to React context.
It should preferably be used at **the root of your component tree**.

<!--You can see the full properties API in [this dedicated page](/api/mui-theme-provider/).-->

#### Examples

```fsharp
open Fable.Helpers.MaterialUI

let theme = createMuiTheme []

let view () =
    muiThemeProvider [ MuiThemeProviderProp.Theme (ProviderTheme.Theme theme) ] [
        div [] [] // your application components
    ]
```

### `createMuiTheme (options : ThemeProp list) : ITheme`

Generate a theme base on the options received.

#### Arguments

1. `options` (*ThemeProp list*): Takes an incomplete list of `ThemeProp`s and adds the missing parts.

```fsharp
type ThemeProp =
    | Direction of Themes.TextDirection
    | Shadows of string list
    | [<Erase>] Custom of string*obj

ThemeProp.Palette (props : PaletteProp list) : ThemeProp
ThemeProp.Shape (props : ShapeProp list) : ThemeProp
ThemeProp.Spacing (props : SpacingProp list) : ThemeProp
ThemeProp.Typography (props : ThemeTypographyProp list) : ThemeProp
ThemeProp.ZIndex (props : ZIndexProp list) : ThemeProp
ThemeProp.Overrides (props : IOverridesProp list) : ThemeProp
```

You can find full list of `Theme` options and subprops [here](https://github.com/mvsmal/fable-material-ui/blob/master/src/Fable.Helpers.MaterialUI.Props.fs#L1711-L1962)

#### Returns

`theme` (*ITheme*): A complete, ready to use theme object.

#### Examples

```fsharp
open Fable.Helpers.MaterialUI
open Fable.MaterialUI.Props
open Fable.MaterialUI

let theme = createMuiTheme [
                ThemeProp.Palette [
                    PaletteProp.Primary [
                        PaletteIntentionProp.Main Colors.purple.``500``
                    ]
                    PaletteProp.Secondary [
                        PaletteIntentionProp.Main "#11cb5f"
                    ]
                ]
            ]
```


### `withTheme<'P when 'P :> IThemeProps> (fn : ('P -> ReactElement)) : ClassComponent<'P>`

Provide the `theme` object as a property of the input component so it can be used
in the render method.

#### Arguments

1. `fn` (*'P -> ReactElement*): The function which expects `props : 'P` argument and returns `ReactElement`.
`'P` should inherit `IThemeProps`

#### Returns

`Component` (*ClassComponent<'P>*): The new component created.

#### Examples

```fsharp
open Fable.Helpers.MaterialUI

let myFun (props : IThemeProps) =
    div [] [ str props.theme.palette.primary.main ]

let myFunWithTheme = withTheme myFun

let myComponent () =
    from myFunWithTheme createEmpty<IThemeProps> []

```

```fsharp
open Fable.Helpers.MaterialUI

type MyFunProps =
    abstract foo : string with get,set
    inherit IThemeProps

let myFun (props : MyFunProps) =
    div [] [
        str props.theme.palette.primary.main 
        str props.foo
    ]

let myFunWithTheme = withTheme myFun

let myComponent () =
    let props = createEmpty<MyFunProps>
    props.foo <- "bar"
    from myFunWithTheme props []
```
"""

let view () =
    div [] [
        Markdown.view text
        Demo.view "#### Example" "./Customization/Themes/Palette.fs" Palette.view
        Markdown.view colorToolText
        Demo.view darkThemeText "./Customization/Themes/DarkTheme.fs" DarkTheme.view
        Demo.view typographyThemeText "./Customization/Themes/TypographyTheme.fs" TypographyTheme.view
        Markdown.view typographyFontFamilyText
        Markdown.view typographyFontSizeText
        Demo.view htmlFontSizeText "./Customization/Themes/FontSizeTheme.fs" FontSizeTheme.view
        Demo.view customVariablesText "./Customization/Themes/CustomStyles.fs" CustomStyles.view
        Markdown.view otherVariablesText
        Demo.view overrideCSSText "./Customization/Themes/OverrideCss.fs" OverrideCss.view
        Demo.view overridesPropertiesText "./Customization/Themes/OverrideProperties.fs" OverrideProperties.view
        Demo.view withThemeText "./Customization/Themes/WithTheme.fs" WithTheme.view
        Demo.view nestedText "./Customization/Themes/Nested.fs" Nested.view
        Markdown.view performanceNote
        Markdown.view apiText

    ]