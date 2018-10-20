module Demos.TextFields.Filled

open Fable.Core
open Fable.Helpers.React
open Fable.Core.JsInterop
open Fable.Import
open Fable.Helpers.MaterialUI
open Fable.Helpers.React.Props
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
open Fable.Import.React
module R = Fable.Helpers.React

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Container [
            CSSProp.Display "flex"
            CSSProp.FlexWrap "wrap"
        ]
        Styles.Custom ("textField", [
            CSSProp.MarginLeft theme.spacing.unit
            CSSProp.MarginRight theme.spacing.unit
            CSSProp.Width 200
        ])
        Styles.Dense [
            CSSProp.MarginTop 19
        ]
        Styles.Custom("menu", [
            CSSProp.Width 200
        ])
    ]

let currencies = [
    ("$", "USD")
    ("€", "EUR")
    ("฿", "BTC")
    ("¥", "JPY")
]

type TextFieldState = {
    name : string
    age : string
    multiline : string
    currency : string
}

type TextFields (p) =
    inherit React.Component<IClassesProps,TextFieldState>(p)
    do
        base.setInitState {
            name = "Cat in the Hat"
            age = ""
            multiline = "Controlled"
            currency = "EUR"
        }
    
    member private this.handleNameChange (event : FormEvent) =
        let value = event.Value
        this.setState (fun s _ -> { s with name = value })
    
    member private this.handleMultilineChange (event : FormEvent) =
        let value = event.Value
        this.setState (fun s _ -> { s with multiline = value })

    member private this.handleAgeChange (event : FormEvent) =
        let value = event.Value
        this.setState (fun s _ -> { s with age = value })
    
    member private this.handleCurrencyChange (event : FormEvent) =
        let value = event.Value
        this.setState (fun s _ -> { s with currency = value })
    
    override this.render() =
        R.form [
            HTMLAttr.Class !!this.props.classes?container
            HTMLAttr.NoValidate true
            HTMLAttr.AutoComplete "off"
        ] [
            textField [
                HTMLAttr.Id "standard-name"
                HTMLAttr.Label "Name"
                HTMLAttr.Class !!this.props.classes?textField
                HTMLAttr.Value this.state.name
                DOMAttr.OnChange this.handleNameChange
                MaterialProp.Margin FormControlMargin.Normal
                TextFieldProp.Variant TextFieldVariant.Filled
            ] []
            textField [
                HTMLAttr.Id "standard-uncontrolled"
                HTMLAttr.Label "Uncontrolled"
                HTMLAttr.Class !!this.props.classes?textField
                HTMLAttr.DefaultValue "foo"
                MaterialProp.Margin FormControlMargin.Normal
                TextFieldProp.Variant TextFieldVariant.Filled
            ] []
            textField [
                HTMLAttr.Id "standard-required"
                HTMLAttr.Label "Required"
                HTMLAttr.Class !!this.props.classes?textField
                HTMLAttr.DefaultValue "Hello World"
                MaterialProp.Margin FormControlMargin.Normal
                HTMLAttr.Required true
                TextFieldProp.Variant TextFieldVariant.Filled
            ] []
            textField [
                HTMLAttr.Id "standard-error"
                HTMLAttr.Label "Error"
                HTMLAttr.Class !!this.props.classes?textField
                HTMLAttr.DefaultValue "Hello World"
                MaterialProp.Margin FormControlMargin.Normal
                MaterialProp.Error true
                TextFieldProp.Variant TextFieldVariant.Filled
            ] []
            textField [
                HTMLAttr.Disabled true
                HTMLAttr.Id "standard-disabled"
                HTMLAttr.Label "Disabled"
                HTMLAttr.Class !!this.props.classes?textField
                HTMLAttr.DefaultValue "Hello World"
                MaterialProp.Margin FormControlMargin.Normal
                TextFieldProp.Variant TextFieldVariant.Filled
            ] []
            textField [
                HTMLAttr.Id "standard-email-input"
                HTMLAttr.Label "Email"
                HTMLAttr.Class !!this.props.classes?textField
                HTMLAttr.Type "email"
                HTMLAttr.AutoComplete "email"
                MaterialProp.Margin FormControlMargin.Normal
                TextFieldProp.Variant TextFieldVariant.Filled
            ] []
            textField [
                HTMLAttr.Id "standard-password-input"
                HTMLAttr.Label "Password"
                HTMLAttr.Class !!this.props.classes?textField
                HTMLAttr.Type "password"
                HTMLAttr.AutoComplete "current-password"
                MaterialProp.Margin FormControlMargin.Normal
                TextFieldProp.Variant TextFieldVariant.Filled
            ] []
            textField [
                HTMLAttr.Id "standard-read-only-input"
                HTMLAttr.Label "Read Only"
                HTMLAttr.Class !!this.props.classes?textField
                HTMLAttr.DefaultValue "Hello World"
                MaterialProp.Margin FormControlMargin.Normal
                TextFieldProp.Variant TextFieldVariant.Filled
                ChildrenProp.InputProps [
                    HTMLAttr.ReadOnly true
                ]
            ] []
            textField [
                HTMLAttr.Id "standard-dense"
                HTMLAttr.Label "Dense"
                TextFieldProp.Variant TextFieldVariant.Filled
                classList [
                    (!!this.props.classes?textField, true)
                    (!!this.props.classes?dense, true)
                ]
                MaterialProp.Margin FormControlMargin.Dense
            ] []
            textField [
                HTMLAttr.Id "standard-multiline-flexible"
                HTMLAttr.Label "Multiline"
                MaterialProp.Multiline true
                MaterialProp.RowsMax 4
                HTMLAttr.Value this.state.multiline
                DOMAttr.OnChange this.handleMultilineChange
                MaterialProp.Margin FormControlMargin.Normal
                TextFieldProp.Variant TextFieldVariant.Filled
                HTMLAttr.Class !!this.props.classes?textField
            ] []
            textField [
                HTMLAttr.Id "standard-multiline-static"
                HTMLAttr.Label "Multiline"
                HTMLAttr.Class !!this.props.classes?textField
                HTMLAttr.Rows 4
                MaterialProp.Multiline true
                HTMLAttr.DefaultValue "Default Value"
                TextFieldProp.Variant TextFieldVariant.Filled
                MaterialProp.Margin FormControlMargin.Normal
            ] []
            textField [
                HTMLAttr.Id "standard-helperText"
                HTMLAttr.Label "Helper text"
                HTMLAttr.Class !!this.props.classes?textField
                HTMLAttr.DefaultValue "Default Value"
                TextFieldProp.HelperText ("Some important text" |> str |> U2.Case1 |> U3.Case1)
                TextFieldProp.Variant TextFieldVariant.Filled
                MaterialProp.Margin FormControlMargin.Normal
            ] []
            textField [
                HTMLAttr.Id "standard-with-placeholder"
                HTMLAttr.Label "With placeholder"
                HTMLAttr.Placeholder "Placeholder"
                HTMLAttr.Class !!this.props.classes?textField
                TextFieldProp.Variant TextFieldVariant.Filled
                MaterialProp.Margin FormControlMargin.Normal
            ] []
            textField [
                HTMLAttr.Id "standard-textarea"
                HTMLAttr.Label "Multiline placeholder"
                HTMLAttr.Placeholder "Placeholder"
                HTMLAttr.Class !!this.props.classes?textField
                TextFieldProp.Variant TextFieldVariant.Filled
                MaterialProp.Multiline true
                MaterialProp.Margin FormControlMargin.Normal
            ] []
            textField [
                HTMLAttr.Id "standard-number"
                HTMLAttr.Label "Number"
                HTMLAttr.Value this.state.age
                HTMLAttr.Type "number"
                TextFieldProp.Variant TextFieldVariant.Filled
                DOMAttr.OnChange this.handleAgeChange
                ChildrenProp.InputLabelProps [
                    InputLabelProp.Shrink true
                ]
                HTMLAttr.Class !!this.props.classes?textField
                MaterialProp.Margin FormControlMargin.Normal
            ] []
            textField [
                HTMLAttr.Id "standard-search"
                HTMLAttr.Label "Search field"
                HTMLAttr.Class !!this.props.classes?textField
                HTMLAttr.Type "search"
                TextFieldProp.Variant TextFieldVariant.Filled
                MaterialProp.Margin FormControlMargin.Normal
            ] []
            textField [
                HTMLAttr.Id "standard-select-currency"
                HTMLAttr.Label "Select"
                HTMLAttr.Class !!this.props.classes?textField
                HTMLAttr.Type "search"
                HTMLAttr.Value this.state.currency
                DOMAttr.OnChange this.handleCurrencyChange
                TextFieldProp.Variant TextFieldVariant.Filled
                TextFieldProp.HelperText ("Please select your currency" |> str |> U2.Case1 |> U3.Case1)
                TextFieldProp.Select true
                MaterialProp.Margin FormControlMargin.Normal
                ChildrenProp.SelectProps [
                    ChildrenProp.MenuProps [
                        HTMLAttr.Class !!this.props.classes?menu
                    ]
                ]
            ] (currencies |> List.map (fun (k,v) -> menuItem [ Prop.Key v; HTMLAttr.Value v ] [ str k ]))
            textField [
                HTMLAttr.Id "standard-select-currency-native"
                HTMLAttr.Label "Native select"
                HTMLAttr.Class !!this.props.classes?textField
                HTMLAttr.Type "search"
                HTMLAttr.Value this.state.currency
                DOMAttr.OnChange this.handleCurrencyChange
                TextFieldProp.HelperText ("Please select your currency" |> str |> U2.Case1 |> U3.Case1)
                TextFieldProp.Select true
                TextFieldProp.Variant TextFieldVariant.Filled
                MaterialProp.Margin FormControlMargin.Normal
                ChildrenProp.SelectProps [
                    SelectProp.Native true
                    ChildrenProp.MenuProps [
                        HTMLAttr.Class !!this.props.classes?menu
                    ]
                ]
            ] (currencies |> List.map (fun (k,v) -> option [ Prop.Key v; HTMLAttr.Value v ] [ str k ]))
            textField [
                HTMLAttr.Id "standard-full-width"
                HTMLAttr.Label "Label"
                Style [ CSSProp.Margin 8 ]
                HTMLAttr.Placeholder "Placeholder"
                MaterialProp.FullWidth true
                TextFieldProp.HelperText ("Full width!" |> str |> U2.Case1 |> U3.Case1)
                TextFieldProp.Variant TextFieldVariant.Filled
                ChildrenProp.InputLabelProps [
                    InputLabelProp.Shrink true
                ]
                MaterialProp.Margin FormControlMargin.Normal
                // HTMLAttr.Class !!this.props.classes?textField
            ] []
            textField [
                HTMLAttr.Id "standard-bare"
                HTMLAttr.Class !!this.props.classes?textField
                HTMLAttr.DefaultValue "Bare"
                MaterialProp.Margin FormControlMargin.Normal
                TextFieldProp.Variant TextFieldVariant.Filled
            ] []
        ]

let textFields props =
    ofType<TextFields,_,_> props []

let textFieldsWithStyles<'a> = withStyles (StyleType.Func styles) [] textFields

let view () =
    R.from textFieldsWithStyles createEmpty []
