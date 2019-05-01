module Customization.Themes.TypographyTheme

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

let styles : IStyles list = [
    Styles.Root [
        CSSProp.Display DisplayOptions.Flex
    ]
]

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
                    ThemeTypographyProp.FontWeightMedium 500
                    ThemeTypographyProp.Body1 [
                        TextStyleProp.FontWeight "500"
                    ]
                    ThemeTypographyProp.Subtitle1 [
                        TextStyleProp.FontSize "12"
                    ]
                    ThemeTypographyProp.Button [
                        !!("fontStyle", "italic")
                    ]
                ]
            ]

let typographyTheme (props : IClassesProps) =
    let children =
        div [] [
            typography [] [ str "body1" ]
            typography [ TypographyProp.Variant TypographyVariant.Subtitle1 ] [ str "subtitle" ]
            button [] [ str "button" ]
        ]
    
    div [ HTMLAttr.Class !!props.classes?root ] [
        children
        muiThemeProvider [ MuiThemeProviderProp.Theme (ProviderTheme.Theme theme) ] [
            children
        ]
    ]

let withStyles = withStyles (StyleType.Styles styles) [] typographyTheme

let view () =
    ReactElementType.create withStyles createEmpty<IClassesProps> []
