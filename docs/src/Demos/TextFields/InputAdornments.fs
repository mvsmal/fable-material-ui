module Demos.TextFields.InputAdornments

open Fable.Core
open Fable.Helpers.React
open Fable.Core.JsInterop
open Fable.Helpers.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
open Fable.Import.React

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Root [
            CSSProp.Display "flex"
            CSSProp.FlexWrap "wrap"
        ]
        Styles.Custom ("margin", [
            CSSProp.Margin theme.spacing.unit
        ])
        Styles.Custom ("withoutLabel", [
            CSSProp.MarginTop (theme.spacing.unit * 3)
        ])
        Styles.Custom ("textField", [
            CSSProp.FlexBasis 200
        ])
    ]

let ranges = [
    "0-20", "0 to 20"
    "21-50", "21 to 50"
    "51-100", "51 to 100"
]

type InputAdornmentsProps = {
    amount : string
    password : string
    weight : string
    weightRange : string
    showPassword : bool
}

type InputAdornments(p) =
    inherit Component<IClassesProps, InputAdornmentsProps>(p)
    do
        base.setInitState {
            amount = ""
            password = ""
            weight = ""
            weightRange = ""
            showPassword = false
        }
    member private this.handleWeightChange (e : FormEvent) =
        let value = e.Value
        this.setState (fun s _ -> { s with weight = value })
    member private this.handleWeightRangeChange (e : FormEvent) =
        let value = e.Value
        this.setState (fun s _ -> { s with weightRange = value })
    member private this.handleAmountChange (e : FormEvent) =
        let value = e.Value
        this.setState (fun s _ -> { s with amount = value })
    member private this.handlePasswordChange (e : FormEvent) =
        let value = e.Value
        this.setState (fun s _ -> { s with password = value })
    
    member private this.handleClickShowPassword _ =
        this.setState (fun s _ -> { s with showPassword = not s.showPassword })
    override this.render() =
        let classes = this.props.classes

        div [ Class !!classes?root ] [
            textField [
                HTMLAttr.Label "With normal TextField"
                HTMLAttr.Id "simple-start-adornment"
                classList [
                    !!classes?margin, true
                    !!classes?textField, true
                ]
                ChildrenProp.InputProps [
                    InputProp.StartAdornment (
                        inputAdornment
                            [ InputAdornmentProp.Position InputAdornmentPosition.Start ]
                            [ str "Kg" ]
                        |> U2.Case1 |> U3.Case1)
                ]
            ] []
            textField [
                TextFieldProp.Select true
                HTMLAttr.Label "With Select"
                HTMLAttr.Value this.state.weightRange
                DOMAttr.OnChange this.handleWeightRangeChange
                classList [
                    !!classes?margin, true
                    !!classes?textField, true
                ]
                ChildrenProp.InputProps [
                    InputProp.StartAdornment (
                        inputAdornment
                            [ InputAdornmentProp.Position InputAdornmentPosition.Start ]
                            [ str "Kg" ]
                        |> U2.Case1 |> U3.Case1)
                ]
            ] (ranges |> List.map (fun (k,l) -> menuItem [ Prop.Key k; HTMLAttr.Value k] [ str l ]))
            formControl [
                MaterialProp.FullWidth true
                HTMLAttr.Class !!classes?margin
            ] [
                inputLabel [ HTMLAttr.HtmlFor "adornment-amount" ] [ str "Amount" ]
                input [
                    HTMLAttr.Id "adornment-amount"
                    HTMLAttr.Value this.state.amount
                    DOMAttr.OnChange this.handleAmountChange
                    InputProp.StartAdornment (
                        inputAdornment
                            [ InputAdornmentProp.Position InputAdornmentPosition.Start ]
                            [ str "$" ]
                    |> U2.Case1 |> U3.Case1)
                ]
            ]
            formControl [
                classList [
                    !!classes?margin, true
                    !!classes?withoutLabel, true
                    !!classes?textField, true
                ]
                HTMLAttr.Custom("aria-describedby", "weight-helper-text")
            ] [
                input [
                    HTMLAttr.Id "adornment-weight"
                    HTMLAttr.Value this.state.weight
                    DOMAttr.OnChange this.handleWeightChange
                    InputProp.EndAdornment (
                        inputAdornment
                            [ InputAdornmentProp.Position InputAdornmentPosition.End ]
                            [ str "Kg" ]
                    |> U2.Case1 |> U3.Case1)
                    MaterialProp.InputProps [ HTMLAttr.Custom ("aria-label", "Weight") ]
                ]
                formHelperText [ HTMLAttr.Id "weight-helper-text" ] [ str "Weight" ]
            ]
            formControl [
                classList [
                    !!classes?margin, true
                    !!classes?textField, true
                ]
            ] [
                inputLabel [ HTMLAttr.HtmlFor "adornment-password" ] [ str "Password" ]
                input [
                    HTMLAttr.Id "adornment-password"
                    HTMLAttr.Type (if this.state.showPassword then "text" else "password")
                    HTMLAttr.Value this.state.password
                    DOMAttr.OnChange this.handlePasswordChange
                    InputProp.EndAdornment (
                        inputAdornment
                            [ InputAdornmentProp.Position InputAdornmentPosition.End ]
                            [
                                iconButton [
                                    HTMLAttr.Custom("aria-label", "Toggle password visibility")
                                    DOMAttr.OnClick this.handleClickShowPassword
                                ] [
                                    icon [] [
                                        str (if this.state.showPassword then "visibility_off"
                                             else "visibility")
                                    ]
                                ]
                             ]
                    |> U2.Case1 |> U3.Case1)
                ]
            ]
        ]

let textFields props =
    ofType<InputAdornments,_,_> props []

let textFieldsWithStyles = withStyles (StyleType.Func styles) [] textFields

let view () =
    from textFieldsWithStyles createEmpty<IClassesProps> []
