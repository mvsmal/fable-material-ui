module Demos.AppBar.View

open Fable.Helpers.React

open Components.Typography
open Demos
open Demos.AppBar
open Components

let text = """
# App Bar
<p class="description">The App Bar displays information and actions relating to the current screen.</p>

The top App Bar provides content and actions related to the current screen. It’s used for branding, screen titles, navigation, and actions.

It can transform into a contextual action bar or used as a navbar.
"""

let view () =
    div [] [
        Markdown.view text
        Demo.view "Simple App Bar" "./AppBar/SimpleAppBar.fs" SimpleAppBar.view
        Demo.view "App Bar with buttons" "./AppBar/AppBarWithButtons.fs" AppBarWithButtons.view
    ]