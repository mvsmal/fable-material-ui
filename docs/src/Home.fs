module Home.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Helpers.MaterialUI
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

open App.Types
open Components
open Global
open Utils

module Mui = Fable.Helpers.MaterialUI

let homeStyles (theme : ITheme) : IStyles list =
    let xsBreakpoint = theme.breakpoints.only MaterialSize.Xs
    let smBreakpoint = theme.breakpoints.only MaterialSize.Sm
    [
        customStyle "hero" [
            MinHeight "80vh"
            Flex "0 0 auto"
            Display "flex"
            JustifyContent "center"
            CSSProp.AlignItems "center"
            BackgroundColor theme.palette.background.paper
            CSSProp.Color theme.palette.primary.dark
        ]
        Styles.Text [
            Display "flex"
            FlexDirection "column"
            JustifyContent "center"
            CSSProp.AlignItems "center"
        ]
        Styles.Title [
            CSSProp.LetterSpacing ".2rem"
            CSSProp.TextIndent ".7rem"
            CSSProp.FontWeight theme.typography.fontWeightLight
            CSSProp.WhiteSpace "nowrap"
            customCss xsBreakpoint [
                CSSProp.FontSize 28
            ]
        ]
        Styles.Headline [
            PaddingLeft (theme.spacing.unit * 4)
            PaddingRight (theme.spacing.unit * 4)
            MarginTop theme.spacing.unit
            CSSProp.MaxWidth 500
            TextAlign "center"
        ]
        Styles.Content [
            PaddingBottom (theme.spacing.unit * 8)
            PaddingTop (theme.spacing.unit * 8)
            customCss smBreakpoint [
                PaddingTop (theme.spacing.unit * 12)
            ]
        ]
        Styles.Button [
            MarginTop (theme.spacing.unit * 3)
        ]
        customStyle "logo" [
            CSSProp.MarginTop (theme.spacing.unit * 3)
            CSSProp.MarginRight 0
            CSSProp.MarginLeft 0
            CSSProp.MarginBottom (theme.spacing.unit * 4)
            Width "100%"
            Height "35vw"
            MaxHeight 200
        ]
        customStyle "support" [
            CSSProp.TextAlign "center"
            CSSProp.MarginBottom 30
        ]
    ]

[<Pojo>]
type HomeProps =
    abstract member dispatch : (Msg->unit) with get,set
    inherit Mui.IClassesProps

[<Pojo>]
type HomeClasses =
    abstract member hero : string
    abstract member content : string
    abstract member logo : string
    abstract member text : string
    abstract member title : string
    abstract member headline : string
    abstract member button : string
    abstract member support: string
    inherit Mui.IClasses

let supportText = """
## Support fable-material-ui
Fable.MaterialUI is a MIT licensed open source project. We are intent on code quality and project maintain. Entirely thanks to our awesome backers.

### Support via [patreon](https://www.patreaon.com/mvsmal)
"""

let home (props : HomeProps) =
    let classes : HomeClasses = !!props.classes
    fragment [] [
        div [ Class classes.hero ] [
            div [ Class classes.content ] [
                img [
                    Src "img/fable-material-ui-logo.svg"
                    Alt "Fable Material-UI Logo"
                    Class classes.logo
                ]
                div [ Class classes.text ] [
                    typography [
                        TypographyProp.Variant TypographyVariant.Display2
                        TypographyProp.Align TypographyAlign.Center
                        MaterialProp.Component ("h1" |> U3.Case1)
                        TypographyProp.Color TypographyColor.Inherit
                        TypographyProp.GutterBottom true
                        Class classes.title
                    ] [ str "FABLE MATERIAL-UI" ]
                    typography [
                        TypographyProp.Variant TypographyVariant.Headline
                        MaterialProp.Component ("h2" |> U3.Case1)
                        TypographyProp.Color TypographyColor.Inherit
                        TypographyProp.GutterBottom true
                        Class classes.headline
                    ] [ str "Fable bindings for Material-UI React components"]
                    Mui.button [
                        MaterialProp.Component ("a" |> U3.Case1)
                        Href ("/" + toHash Installation)
                        Class classes.button
                        ButtonProp.Variant ButtonVariant.Outlined
                        MaterialProp.Color ComponentColor.Primary
                    ] [ str "Get Started" ]
                ]
            ]
        ]
        div [ Class classes.support ] [
            Markdown.view supportText
        ]
    ]

let homeWithStyles = Mui.withStyles (StyleType.Func homeStyles) [] home

let root dispatch =
    let props = createEmpty<HomeProps>
    props.dispatch <- dispatch
    from homeWithStyles props []