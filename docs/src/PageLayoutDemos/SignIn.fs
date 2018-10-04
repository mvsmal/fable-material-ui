module PageLayoutDemos.SignIn

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Helpers.MaterialUI
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
module Mui = Fable.Helpers.MaterialUI

let toObj = keyValueList CaseRules.LowerFirst

let styles (theme : ITheme) : IStyles list =
    // In Fable 2 you don't need to create a seperate variable.
    let breakPoint = theme.breakpoints.up( U2.Case2 <| 400 + theme.spacing.unit * 3 * 2 )

    [
        Styles.Layout [
            Width "auto"
            Display "block"
            MarginLeft (theme.spacing.unit * 3)
            MarginRight (theme.spacing.unit * 3)            
            CSSProp.Custom(
                breakPoint, [
                    Width 400
                    MarginLeft "auto"
                    MarginRight "auto"
                ] |> toObj)
        ]
        Styles.Paper [
            MarginTop (theme.spacing.unit * 8)
            Display "Flex"
            FlexDirection "column"
            CSSProp.AlignItems "center"
            CSSProp.Padding (sprintf "%ipx %ipx %ipx" (theme.spacing.unit * 2) (theme.spacing.unit * 3) (theme.spacing.unit * 3))            
        ]

        Styles.Avatar [
            CSSProp.Margin theme.spacing.unit
            BackgroundColor theme.palette.secondary.main
        ]

        Styles.Form [
            Width "100%"
            MarginTop theme.spacing.unit
        ]

        Styles.Custom (
            "submit",
            [MarginTop (theme.spacing.unit * 3)] |> toObj
        )
    ]

let withStyles<'a> = Mui.withStyles (StyleType.Func styles) []

let lockIcon =
    Mui.svgIcon [] [
        path [
            SVGAttr.D "M18 8h-1V6c0-2.76-2.24-5-5-5S7 3.24 7 6v2H6c-1.1 0-2 .9-2 2v10c0 1.1.9 2 2 2h12c1.1 0 2-.9 2-2V10c0-1.1-.9-2-2-2zm-6 9c-1.1 0-2-.9-2-2s.9-2 2-2 2 .9 2 2-.9 2-2 2zm3.1-9H8.9V6c0-1.71 1.39-3.1 3.1-3.1 1.71 0 3.1 1.39 3.1 3.1v2z"
        ] []
    ]

let signIn props =
    let classes = props?classes

    main [Class !!classes?layout ] [
        paper [Class !!classes?paper] [
            avatar [Class !!classes?avatar] [
                lockIcon
            ]

            typography [Variant TypographyVariant.Headline] [ str "Sign in" ]

            form [Class !!classes?form] [
                formControl [MaterialProp.Margin FormControlMargin.Normal; HTMLAttr.Required true; MaterialProp.FullWidth true] [
                    inputLabel [HtmlFor "email"] [str "Email Address"]
                    input [
                        Id "email"
                        HTMLAttr.Name "email"
                        AutoComplete "email"
                        AutoFocus true
                    ]
                ]

                formControl [MaterialProp.Margin FormControlMargin.Normal; HTMLAttr.Required true; MaterialProp.FullWidth true] [
                    inputLabel [HtmlFor "password"] [str "Password"]
                    input [
                        HTMLAttr.Name "password"
                        HTMLAttr.Type "password"
                        Id "password"
                        AutoComplete "current-password"
                    ]
                ]

                button [ HTMLAttr.Type "submit"
                         MaterialProp.FullWidth true
                         ButtonProp.Variant ButtonVariant.Raised
                         MaterialProp.Color ComponentColor.Primary
                         Class !!classes?submit ]  [
                    str "Sign in"
                ]
            ]
        ]        
    ]

let root () =
    from (signIn |> withStyles) createEmpty []