module Demos.TextFields.FilledInputAdornments

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
open Browser.Types

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Root [
            CSSProp.Display DisplayOptions.Flex
            CSSProp.FlexWrap "wrap"
        ]
        Styles.Custom ("margin", [
            CSSProp.Margin theme.spacing.unit
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
    member private this.handleWeightChange (e : Event) =
        let value = e.Value
        this.setState (fun s _ -> { s with weight = value })
    member private this.handleWeightRangeChange (e : Event) =
        let value = e.Value
        this.setState (fun s _ -> { s with weightRange = value })
    member private this.handleAmountChange (e : Event) =
        let value = e.Value
        this.setState (fun s _ -> { s with amount = value })
    member private this.handlePasswordChange (e : Event) =
        let value = e.Value
        this.setState (fun s _ -> { s with password = value })
    
    member private this.handleClickShowPassword _ =
        this.setState (fun s _ -> { s with showPassword = not s.showPassword })
    override this.render() =
        let classes = this.props.classes

        div [ Class !!classes?root ] [
            textField [
                HTMLAttr.Label "With filled TextField"
                HTMLAttr.Id "filled-simple-start-adornment"
                TextFieldProp.Variant TextFieldVariant.Filled
                classList [
                    !!classes?margin, true
                    !!classes?textField, true
                ]
                ChildrenProp.InputProps [
                    InputProp.StartAdornment (
                        inputAdornment [ 
                            InputAdornmentProp.Position InputAdornmentPosition.Start
                            InputAdornmentProp.Variant InputAdornmentVariant.Filled
                        ] [ str "Kg" ])
                ]
            ] []
            textField [
                TextFieldProp.Select true
                HTMLAttr.Label "With Select"
                HTMLAttr.Value this.state.weightRange
                TextFieldProp.Variant TextFieldVariant.Filled
                DOMAttr.OnChange this.handleWeightRangeChange
                classList [
                    !!classes?margin, true
                    !!classes?textField, true
                ]
                ChildrenProp.InputProps [
                    InputProp.StartAdornment (
                        inputAdornment [
                            InputAdornmentProp.Position InputAdornmentPosition.Start
                            InputAdornmentProp.Variant InputAdornmentVariant.Filled
                        ] [ str "Kg" ])
                ]
            ] (ranges |> List.map (fun (k,l) -> menuItem [ Prop.Key k; HTMLAttr.Value k] [ str l ]))
            textField [
                HTMLAttr.Id "filled-adornment-amount"
                HTMLAttr.Value this.state.amount
                HTMLAttr.Label "Amount"
                TextFieldProp.Variant TextFieldVariant.Filled
                DOMAttr.OnChange this.handleAmountChange
                classList [
                    !!classes?margin, true
                    !!classes?textField, true
                ]
                ChildrenProp.InputProps [
                    InputProp.StartAdornment (
                        inputAdornment [
                            InputAdornmentProp.Position InputAdornmentPosition.Start
                            InputAdornmentProp.Variant InputAdornmentVariant.Filled
                        ] [ str "$" ])
                ]
            ] []
            textField [
                HTMLAttr.Id "filled-adornment-weight"
                HTMLAttr.Value this.state.weight
                HTMLAttr.Label "Weight"
                TextFieldProp.Variant TextFieldVariant.Filled
                TextFieldProp.HelperText ("Weight" |> str)
                DOMAttr.OnChange this.handleWeightChange
                classList [
                    !!classes?margin, true
                    !!classes?textField, true
                ]
                ChildrenProp.InputProps [
                    InputProp.EndAdornment (
                        inputAdornment [
                            InputAdornmentProp.Position InputAdornmentPosition.End
                            InputAdornmentProp.Variant InputAdornmentVariant.Filled
                        ] [ str "Kg" ])
                ]
            ] []
            textField [
                HTMLAttr.Id "filled-adornment-password"
                HTMLAttr.Value this.state.password
                HTMLAttr.Label "Password"
                HTMLAttr.Type (if this.state.showPassword then "text" else "password")
                TextFieldProp.Variant TextFieldVariant.Filled
                DOMAttr.OnChange this.handlePasswordChange
                classList [
                    !!classes?margin, true
                    !!classes?textField, true
                ]
                ChildrenProp.InputProps [
                    InputProp.EndAdornment (
                        inputAdornment [
                            InputAdornmentProp.Position InputAdornmentPosition.End
                            InputAdornmentProp.Variant InputAdornmentVariant.Filled
                        ] [
                            iconButton [
                                HTMLAttr.Custom("aria-label", "Toggle password visibility")
                                DOMAttr.OnClick this.handleClickShowPassword
                            ] [
                                icon [] [
                                    str (if this.state.showPassword then "visibility_off"
                                         else "visibility")
                                ]
                            ]
                        ])
                ]
            ] []
        ]

let textFields props =
    ofType<InputAdornments,_,_> props []

let textFieldsWithStyles = withStyles (StyleType.Func styles) [] textFields

let view () =
    ReactElementType.create textFieldsWithStyles createEmpty<IClassesProps> []

