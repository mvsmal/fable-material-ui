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
        Styles.Custom ("markdown", [
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
                FontFamily theme.typography.h2.fontFamily
                FontSize theme.typography.h2.fontSize
                FontWeight theme.typography.h2.fontWeight
                LineHeight theme.typography.h2.lineHeight
                LetterSpacing theme.typography.h2.letterSpacing
                TextTransform theme.typography.h2.textTransform
                // CSSProp.Color theme.palette.text.secondary
                CSSProp.Margin "32px 0 16px"
            ]
            customCss "& .description" [
                FontFamily theme.typography.h5.fontFamily
                FontSize theme.typography.h5.fontSize
                FontWeight theme.typography.h5.fontWeight
                LineHeight theme.typography.h5.lineHeight
                LetterSpacing theme.typography.h5.letterSpacing
                TextTransform theme.typography.h5.textTransform
                CSSProp.Margin "0 0 40px"
            ]
            customCss "& h2" [
                FontFamily theme.typography.h4.fontFamily
                FontSize theme.typography.h4.fontSize
                FontWeight theme.typography.h4.fontWeight
                LineHeight theme.typography.h4.lineHeight
                LetterSpacing theme.typography.h4.letterSpacing
                TextTransform theme.typography.h4.textTransform
                CSSProp.Color theme.palette.text.secondary
                CSSProp.Margin "32px 0 24px"
            ]
            customCss "& h3" [
                FontFamily theme.typography.h5.fontFamily
                FontSize theme.typography.h5.fontSize
                FontWeight theme.typography.h5.fontWeight
                LineHeight theme.typography.h5.lineHeight
                LetterSpacing theme.typography.h5.letterSpacing
                TextTransform theme.typography.h5.textTransform
                CSSProp.Color theme.palette.text.secondary
                CSSProp.Margin "32px 0 24px"
            ]
            customCss "& h4" [
                FontFamily theme.typography.h6.fontFamily
                FontSize theme.typography.h6.fontSize
                FontWeight theme.typography.h6.fontWeight
                LineHeight theme.typography.h6.lineHeight
                LetterSpacing theme.typography.h6.letterSpacing
                TextTransform theme.typography.h6.textTransform
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
            customCss "& table" [
                CSSProp.Width "100%"
                CSSProp.Display "block"
                CSSProp.OverflowX "auto"
                CSSProp.Custom ("WebkitOverflowScrolling", "touch")
                CSSProp.BorderCollapse "collapse"
                CSSProp.BorderSpacing 0
                CSSProp.Overflow "hidden"
                customCss "& .prop-name" [
                    CSSProp.FontSize 13
                    CSSProp.FontFamily "Conolas, \"Liberation Mono\", Menlo, monospace"
                ]
                customCss "& .required" [
                    CSSProp.Color "#006500"
                ]
                customCss "& .prop-type" [
                    CSSProp.FontSize 13
                    CSSProp.FontFamily "Conolas, \"Liberation Mono\", Menlo, monospace"
                    CSSProp.Color "#932981"
                ]
                customCss "& .prop-default" [
                    CSSProp.FontSize 13
                    CSSProp.FontFamily "Conolas, \"Liberation Mono\", Menlo, monospace"
                    CSSProp.BorderBottom ("1px dotted " + theme.palette.text.hint)
                ]
            ]
            customCss "& thead" [
                CSSProp.FontSize 14
                CSSProp.FontWeight theme.typography.fontWeightMedium
                CSSProp.Color theme.palette.text.secondary
            ]
            customCss "& tbody" [
                CSSProp.FontSize 14
                CSSProp.LineHeight 1.5
                CSSProp.Color theme.palette.text.primary
            ]
            customCss "& td" [
                CSSProp.BorderBottom ("1px solid " + theme.palette.divider)
                CSSProp.Padding "8px 16px 8px 8px"
                CSSProp.TextAlign "left"
            ]
            customCss "& td:last-child" [
                CSSProp.PaddingRight 24
            ]
            customCss "& td compact" [
                CSSProp.PaddingRight 24
            ]
            customCss "& td code" [
                CSSProp.FontSize 13
                CSSProp.LineHeight 1.6
            ]
            customCss "& th" [
                CSSProp.WhiteSpace "pre"
                CSSProp.BorderBottom ("1px solid " + theme.palette.divider)
                CSSProp.FontWeight theme.typography.fontWeightMedium
                CSSProp.Padding "0 16px 0 8px"
                CSSProp.TextAlign "left"
            ]
            customCss "& th:last-child" [
                CSSProp.PaddingRight 24
            ]
            customCss "& tr" [
                CSSProp.Height 48
            ]
            customCss "& thead tr" [
                CSSProp.Height 64
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
        ])
    ]


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
        | "js" | "jsx" -> prism.languages?javascript
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

let markdownWithStyles = withStyles (StyleType.Func markdownStyles) [ MProps.Flip (Some false) ] markdown

let view text =
    let props = createEmpty<MarkdownProps>
    props.text <- text
    from markdownWithStyles props []
