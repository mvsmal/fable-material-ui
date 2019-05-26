module Home.View

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

open App.Types
open Components
open Global
open Utils


let homeStyles (theme : ITheme) : IStyles list =
    let xsBreakpoint = theme.breakpoints.only MaterialSize.Xs
    let smBreakpoint = theme.breakpoints.only MaterialSize.Sm
    [
        Styles.Custom ("hero", [
            MinHeight "80vh"
            Flex "0 0 auto"
            Display DisplayOptions.Flex
            JustifyContent "center"
            CSSProp.AlignItems AlignItemsOptions.Center
            BackgroundColor theme.palette.background.paper
            CSSProp.Color theme.palette.primary.dark
        ])
        Styles.Text [
            Display DisplayOptions.Flex
            FlexDirection "column"
            JustifyContent "center"
            CSSProp.AlignItems AlignItemsOptions.Center
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
            TextAlign TextAlignOptions.Center
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
        Styles.Custom ("logo", [
            CSSProp.MarginTop (theme.spacing.unit * 3)
            CSSProp.MarginRight 0
            CSSProp.MarginLeft 0
            CSSProp.MarginBottom (theme.spacing.unit * 4)
            Width "100%"
            Height "35vw"
            MaxHeight 200
        ])
        Styles.Custom ("support", [
            CSSProp.TextAlign TextAlignOptions.Center
            CSSProp.MarginBottom 30
        ])
    ]

type HomeProps =
    abstract member dispatch : (Msg->unit) with get,set
    inherit IClassesProps


type HomeClasses =
    abstract member hero : string
    abstract member content : string
    abstract member logo : string
    abstract member text : string
    abstract member title : string
    abstract member headline : string
    abstract member button : string
    abstract member support: string
    inherit IClasses

let logo = importDefault "../../public/img/fable-material-ui-logo.svg"

let home (props : HomeProps) =
    let classes : HomeClasses = !!props.classes
    fragment [] [
        div [ Class classes.hero ] [
            div [ Class classes.content ] [
                img [
                    Src logo
                    Alt "Fable Material-UI Logo"
                    Class classes.logo
                ]
                div [ Class classes.text ] [
                    typography [
                        TypographyProp.Variant TypographyVariant.H3
                        TypographyProp.Align TypographyAlign.Center
                        MaterialProp.Component ("h1" |> ReactElementType.ofHtmlElement)
                        TypographyProp.Color TypographyColor.Inherit
                        TypographyProp.GutterBottom true
                        Class classes.title
                    ] [ str "FABLE MATERIAL-UI" ]
                    typography [
                        TypographyProp.Variant TypographyVariant.H5
                        MaterialProp.Component ("h2" |> ReactElementType.ofHtmlElement)
                        TypographyProp.Color TypographyColor.Inherit
                        TypographyProp.GutterBottom true
                        Class classes.headline
                    ] [ str "Fable bindings for Material-UI React components"]
                    button [
                        MaterialProp.Component ("a" |> ReactElementType.ofHtmlElement)
                        Href (toHash Installation)
                        Class classes.button
                        ButtonProp.Variant ButtonVariant.Outlined
                        MaterialProp.Color ComponentColor.Primary
                    ] [ str "Get Started" ]
                ]
            ]
        ]        
    ]

let homeWithStyles = withStyles (StyleType.Func homeStyles) [] home

let root dispatch =
    let props = createEmpty<HomeProps>
    props.dispatch <- dispatch
    ReactElementType.create homeWithStyles props []
