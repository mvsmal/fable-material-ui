module Components.Markdown

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.MaterialUI
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.MaterialUI.Themes

open Import.Prism
open Import.Marked
open Utils

module MProps = Fable.MaterialUI.Props

let markdownStyles (theme : ITheme) : IStyles list =
    [
        customStyle "markdown" [
            FontFamily theme.typography.fontFamily
            FontSize 16
            CSSProp.Color theme.palette.text.primary

            customCss "& .anchor-link" [
                MarginTop -96
                Position "absolute"
            ]
            customCss """& pre, & pre[class*="language-"]""" [
                Margin "24px 0"
                CSSProp.Padding "12px 18px"
                BackgroundColor theme.palette.background.paper
                BorderRadius theme.shape.borderRadius
                Overflow "auto"
                CSSProp.Custom ("WebkitOverflowScrolling", "touch")
            ]
            customCss "& code" [
                Display "inline-block"
                LineHeight 1.6
                FontFamily """Consolas, "Liberation Mono", Menlo, Courier, monospace"""
                CSSProp.Padding "3px 6px"
                CSSProp.Color theme.palette.text.primary
                BackgroundColor theme.palette.background.paper
                FontSize 14
            ]
            customCss "& p code, & ul code, & pre code" [
                FontSize 14
                LineHeight 1.6
            ]
            customCss "& h1" [
                FontFamily theme.typography.display2.fontFamily
                FontSize theme.typography.display2.fontSize
                FontWeight theme.typography.display2.fontWeight
                LineHeight theme.typography.display2.lineHeight
                LetterSpacing theme.typography.display2.letterSpacing
                TextTransform theme.typography.display2.textTransform
                CSSProp.Color theme.palette.text.secondary
                CSSProp.Margin "32px 0 16px"
            ]
            customCss "& .description" [
                FontFamily theme.typography.headline.fontFamily
                FontSize theme.typography.headline.fontSize
                FontWeight theme.typography.headline.fontWeight
                LineHeight theme.typography.headline.lineHeight
                LetterSpacing theme.typography.headline.letterSpacing
                TextTransform theme.typography.headline.textTransform
                CSSProp.Margin "0 0 40px"
            ]
            customCss "& h2" [
                FontFamily theme.typography.display1.fontFamily
                FontSize theme.typography.display1.fontSize
                FontWeight theme.typography.display1.fontWeight
                LineHeight theme.typography.display1.lineHeight
                LetterSpacing theme.typography.display1.letterSpacing
                TextTransform theme.typography.display1.textTransform
                CSSProp.Color theme.palette.text.secondary
                CSSProp.Margin "32px 0 24px"
            ]
            customCss "& h3" [
                FontFamily theme.typography.headline.fontFamily
                FontSize theme.typography.headline.fontSize
                FontWeight theme.typography.headline.fontWeight
                LineHeight theme.typography.headline.lineHeight
                LetterSpacing theme.typography.headline.letterSpacing
                TextTransform theme.typography.headline.textTransform
                CSSProp.Color theme.palette.text.secondary
                CSSProp.Margin "32px 0 24px"
            ]
            customCss "& h4" [
                FontFamily theme.typography.title.fontFamily
                FontSize theme.typography.title.fontSize
                FontWeight theme.typography.title.fontWeight
                LineHeight theme.typography.title.lineHeight
                LetterSpacing theme.typography.title.letterSpacing
                TextTransform theme.typography.title.textTransform
                CSSProp.Color theme.palette.text.secondary
                CSSProp.Margin "24px 0 16px"
            ]
            customCss "& p, & ul, & ol" [
                LineHeight 1.6
            ]
            customCss "& h1, & h2, & h3, & h4" [
                customCss "& code" [
                    FontSize "inherit"
                    LineHeight "inherit"
                    WordBreak "break-word"
                ]
                customCss "& .anchor-link-style" [
                    Opacity 0
                    Display "none"
                ]
                customCss "&:hover .anchor-link-style" [
                    Display "inline-block"
                    Opacity 1
                    CSSProp.Padding "0 8px"
                    CSSProp.Color theme.palette.text.hint
                    customCss "&:hover" [
                        CSSProp.Color theme.palette.text.secondary
                    ]
                    customCss "& svg" [
                        Width "0.55em"
                        Height "0.55em"
                        Fill "currentColor"
                    ]
                ]
            ]
            customCss "& strong" [
                FontWeight theme.typography.fontWeightMedium
            ]
            customCss "& blockquote" [
                BorderLeft ("5px solid " + theme.palette.text.hint)
                BackgroundColor theme.palette.background.paper
                CSSProp.Padding "4px 24px"
                CSSProp.Margin "24px 0"
            ]
            customCss "& a, & a code" [
                CSSProp.Color theme.palette.secondary.main
                TextDecoration "none"
                customCss "&:hover" [
                    TextDecoration "underline"
                ]
            ]
            customCss "& img" [
                MaxWidth "100%"
            ]
        ]
    ]

[<Pojo>]
type MarkdownProps =
    abstract member text : string with get,set
    inherit IClassesProps

[<Emit("new $0.Renderer()")>]
let newRenderer m : obj = jsNative

let heading (text : string) (level : int) =
    if level >= 4
    then (level, text, level) |||> sprintf "<h%i>%s</h%i>"
    else
        let escapedText =
            text
                .ToLower()
                .Replace("=&gt;", "")
                .Replace("&lt;", "")
                .Replace("/&gt;", "")
                .Replace("<code>", "")
                .Replace("</code>", "")
                .Replace(" ", "-")
                .Replace("\t", "-")
                .Replace("\n", "-")
        sprintf """
        <h%i>
            <a class="anchor-link" id="%s"></a>%s
            <a class="anchor-link-style" href="#%s">
                <svg viewBox="0 0 48 48" xmlns="http://www.w3.org/2000/svg"><path d="M46.9 13.9c-.5-.6-1.2-.94-2.07-.94h-6.67l1.86-8.98c.17-.85 0-1.7-.52-2.3-.48-.6-1.2-.94-2.07-.94-1.6 0-3.2 1.27-3.54 2.93l-.5 2.42c0 .07-.07.13-.07.2l-1.37 6.62H20.7l1.88-8.96c.16-.85 0-1.7-.53-2.3-.48-.6-1.2-.94-2.07-.94-1.65 0-3.2 1.27-3.56 2.93l-.52 2.58v.08l-1.37 6.64H7.3c-1.67 0-3.22 1.3-3.58 2.96-.16.86 0 1.7.52 2.3.48.6 1.2.93 2.07.93h6.97l-2 9.65H4c-1.67 0-3.22 1.27-3.56 2.94-.2.8 0 1.67.5 2.27.5.6 1.2.93 2.08.93H10l-1.84 9.05c-.2.84 0 1.67.52 2.3.5.6 1.25.92 2.08.92 1.66 0 3.2-1.3 3.55-2.94l1.94-9.33h11.22l-1.87 9.05c-.15.84.03 1.67.53 2.3.5.6 1.2.92 2.07.92 1.65 0 3.22-1.3 3.56-2.94l1.9-9.33h7c1.6 0 3.2-1.28 3.53-2.93.2-.87 0-1.7-.52-2.3-.48-.62-1.2-.96-2.05-.96h-6.7l2.02-9.65h6.93c1.67 0 3.22-1.27 3.56-2.92.2-.85 0-1.7-.5-2.3l-.04.03zM17.53 28.77l1.95-9.65H30.7l-1.97 9.66H17.5h.03z"/></svg>
            </a></h%i>
        """ level escapedText text escapedText level

let link (href : string) (title : string) (text : string) =
    if href.StartsWith("http")
    then sprintf """<a href="%s" target="_blank" title="%s">%s</a>""" href title text
    else sprintf """<a href="%s" title="%s">%s</a>""" href title text

let renderer = newRenderer Marked.marked
// renderer?heading <- heading
renderer?link <- link

let highlight code (lang : string) =
    let language = function
        | "fsharp" -> prism.languages?fsharp
        | "js" | "jsx" -> prism.languages?jsx
        | "css" -> prism.languages?css
        | "shell" | "sh" -> prism.languages?shell
        | _ -> prism.languages?fsharp
    prism.highlight(code, language lang)

let markedOptions = createEmpty<MarkedOptions>
markedOptions.gfm <- true
markedOptions.tables <- true
markedOptions.breaks <- false
markedOptions.pedantic <- false
markedOptions.sanitize <- false
markedOptions.smartLists <- true
markedOptions.smartypants <- false
markedOptions.highlight <- highlight
markedOptions.renderer <- renderer

let markdown (props : MarkdownProps) =
    let markedText = Marked.marked(props.text, markedOptions)
    div [
        Class !!props.classes?markdown
        DangerouslySetInnerHTML { __html = markedText }
    ] []

let markdownWithStyles = withStyles (StyleType.Func markdownStyles) [ MProps.Flip false ] markdown

let view text =
    let props = createEmpty<MarkdownProps>
    props.text <- text
    from markdownWithStyles props []
