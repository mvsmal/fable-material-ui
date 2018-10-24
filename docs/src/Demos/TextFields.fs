module Demos.TextFields.View

open Fable.Core.JsInterop
open Fable.Helpers.React

open Demos.TextFields
open Components

let text = importDefault "./TextFields.md"
let textFieldText = """
## TextField

The `TextField` wrapper component is a complete form control including a label, input and help text.
"""

let outlinedText = """
## Outlined

`TextField` supports outlined styling.
"""

let filledText = """
## Filled

`TextField` supports filled styling.
"""

let composedText = """
## Components

`TextField` is composed of smaller components (
`FormControl`,
`Input`,
`InputLabel`,
and `FormHelperText`
) that you can leverage directly to significantly customize your form inputs.

You might also have noticed that some native HTML input properties are missing from the `TextField` component.
This is on purpose.
The component takes care of the most used properties, then it's up to the user to use the underlying component shown in the following demo. Still, you can use `inputProps` (and `InputProps`, `InputLabelProps` properties) if you want to avoid some boilerplate.
"""

let layoutText = """
## Layout

`TextField`, `FormControl` allow the specification of `margin` to alter the vertical spacing of inputs. Using
`none` (default) will not apply margins to the `FormControl`, whereas `dense` and `normal` will as well as alter
other styles to meet the specification.
"""

let inputAdornmentsText = """
## Input Adornments

`Input` allows the provision of `InputAdornment`.
These can be used to add a prefix, a suffix or an action to an input.
For instance, you can use an icon button to hide or reveal the password.
"""

let customizedText = """
## Customized inputs

If you have been reading the overrides documentation page
but you are not confident jumping in, here's an example of how you can change the main color of an Input.
"""

let withIconText = """
## With icon

Icons can be specified as prepended or appended.
"""
let view () =
    div [] [
        Markdown.view text
        Demo.view textFieldText "./Demos/TextFields/TextField.fs" TextField.view
        Demo.view outlinedText "./Demos/TextFields/Outlined.fs" Outlined.view
        Demo.view filledText "./Demos/TextFields/Filled.fs" Filled.view
        Demo.view composedText "./Demos/TextFields/Composed.fs" Composed.view
        Demo.view "## Input" "./Demos/TextFields/Input.fs" Input.view
        Demo.view layoutText "./Demos/TextFields/Layout.fs" Layout.view
        Demo.view inputAdornmentsText "./Demos/TextFields/InputAdornments.fs" InputAdornments.view
        Demo.view "## Filled Input Adornments" "./Demos/TextFields/FilledInputAdornments.fs" FilledInputAdornments.view
        Demo.view "## Outlined Input Adornments" "./Demos/TextFields/OutlinedInputAdornments.fs" OutlinedInputAdornments.view
        Demo.view customizedText "./Demos/TextFields/Customized.fs" Customized.view
        Demo.view withIconText "./Demos/TextFields/WithIcon.fs" WithIcon.view
    ]
