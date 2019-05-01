module Demos.TextFields.WithIcon

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Custom("margin", [
            CSSProp.Margin theme.spacing.unit
        ])
    ]

let inputWithIcon (props : IClassesProps) =
    let classes = props.classes

    div [] [
        formControl [ Class !!classes?margin ] [
            inputLabel [ HTMLAttr.HtmlFor "input-with-icon-adornment" ] [
                str "With a start adornment"
            ]
            input [ 
                HTMLAttr.Id "input-with-icon-adornment"
                InputProp.StartAdornment (
                    inputAdornment [ InputAdornmentProp.Position InputAdornmentPosition.Start ] [
                        icon [] [ str "account_circle" ]
                    ]
                )
            ]
        ]
        textField [
            HTMLAttr.Class !!classes?margin
            HTMLAttr.Id "input-with-icon-textfield"
            HTMLAttr.Label "TextField"
            ChildrenProp.InputProps [
                InputProp.StartAdornment (
                    inputAdornment [ InputAdornmentProp.Position InputAdornmentPosition.Start ] [
                        icon [] [ str "account_circle" ]
                    ]
                )
            ]
        ] []
        div [ Class !!classes?margin ] [
            grid [
                GridProp.Container true
                GridProp.Spacing GridSpacing.``8``
                GridProp.AlignItems GridAlignItems.FlexEnd
            ] [
                grid [ GridProp.Item true ] [
                    icon [] [ str "account_circle" ]
                ]
                grid [ GridProp.Item true ] [
                    textField [
                        HTMLAttr.Id "input-with-icon-grid"
                        HTMLAttr.Label "With a grid"
                    ] []
                ]
            ]
        ]
    ]

let textFieldsWithStyles = withStyles (StyleType.Func styles) [] inputWithIcon

let view () =
    ReactElementType.create textFieldsWithStyles createEmpty<IClassesProps> []