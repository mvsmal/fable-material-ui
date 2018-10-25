# Themes

<p class="description">Customize Material-UI with your theme. You can change the colors, the typography and much more.</p>

The theme specifies the color of the components, darkness of the surfaces, level of shadow, appropriate opacity of ink elements, etc.

Themes let you apply a consistent tone to your app. It allows you to **customize all design aspects** of your project in order to meet the specific needs of your business or brand.

To promote greater consistency between apps, light and dark theme types are available to choose from. By default, components use the light theme type.

## Theme provider

If you wish to customize the theme, you need to use the `MuiThemeProvider` component in order to inject a theme into your application.
However, this is optional; Material-UI components come with a default theme.

`MuiThemeProvider` relies on the context feature of React to pass the theme down to the components,
so you need to make sure that `MuiThemeProvider` is a parent of the components you are trying to customize.
You can learn more about this in the API section.

## Theme configuration variables

Changing the theme configuration variables is the most effective way to match Material-UI to your needs.
The following sections cover the most important theme variables.

### Palette

#### Intentions

A color intention is a mapping of a palette to a given intention within your application.

The theme exposes the following color intentions:

- primary - used to represent primary interface elements for a user.
- secondary - used to represent secondary interface elements for a user.
- error - used to represent interface elements that the user should be made aware of.

The default palette uses the shades prefixed with `A` (`A200`, etc.) for the secondary intention,
and the un-prefixed shades for the other intentions.

If you want to learn more about color, you can check out [the color section](#/style/color/).

#### Custom palette

You may override the default palette values by including a `palette` object as part of your theme.

If any of the [`palette.primary`](https://material-ui.com/customization/default-theme/?expend-path=$.palette.primary),
[`palette.secondary`](https://material-ui.com/customization/default-theme/?expend-path=$.palette.secondary) or
[`palette.error`](https://material-ui.com/customization/default-theme/?expend-path=$.palette.error)
'intention' objects are provided, they will replace the defaults.

The intention value is list of props from the following discriminated union:

```fsharp
type PaletteIntentionProp =
    | Light of string
    | Main of string
    | Dark of string
    | ContrastText of string
```

**Using a color object**

The simplest way to customize an intention is to import one or more of the provided colors
and apply them to a palette intention. Unlike in JS version of Material-UI, you can only define a specific
`PaletteIntentionProp`, however if you define just `Main`, other colors will be calculated automaticaly.

These code samples are identical:

```js
import { createMuiTheme } from '@material-ui/core/styles';
import blue from '@material-ui/core/colors/blue';

const theme = createMuiTheme({
  palette: {
    primary: blue,
  },
});
```

```fsharp
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
open Fable.MaterialUI

let theme = createMuiTheme [
                ThemeProp.Palette [
                    PaletteProp.Primary [
                        PaletteIntentionProp.Main Colors.blue.``500``
                    ]
                ]
            ]
```

**Providing the colors directly**

If you wish to provide more customized colors, you can directly supply colors to some or all of the intention's keys:

```fsharp
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
open Fable.MaterialUI

let theme = createMuiTheme [
                ThemeProp.Palette [
                    PaletteProp.Primary [
                        // PaletteIntentionProp.Light will be calculated from Main
                        PaletteIntentionProp.Main "#ff4400"
                        // PaletteIntentionProp.Dark will be calculated from Main
                        // PaletteIntentionProp.ContrastText will be calculated to contrast with Main
                    ]
                    PaletteProp.Secondary [
                        PaletteIntentionProp.Light "#0066ff"
                        PaletteIntentionProp.Main "#0044ff"
                        // PaletteIntentionProp.Dark will be calculated from Main
                        PaletteIntentionProp.ContrastText "#ffcc00"
                    ]
                    // PaletteProp.Error will use the default color
                ]
            ]
```

As in the example above, if the intention object contains custom colors using any of the
`Main`, `Light`, `Dark` or `ContrastText` keys, these map as follows:

- If the `Dark` and / or `Light` keys are omitted, their value(s) will be calculated from `Main`,
according to the `TonalOffset` value.

- If `ContrastText` is omitted, its value will be calculated to contrast with `Main`,
according to the`ContrastThreshold` value.

Both the `TonalOffset` and `ContrastThreshold` values may be customized as needed.
A higher value for `TonalOffset` will make calculated values for `Light` lighter, and `Dark` darker.
A higher value for `ContrastThreshold` increases the point at which a background color is considered
light, and given a dark `ContrastText`.

Note that `ContrastThreshold` follows a non-linear curve.