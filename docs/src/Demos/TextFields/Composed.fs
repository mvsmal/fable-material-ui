module Demos.TextFields.Composed

open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.Themes
open Browser.Types

let styles (theme : ITheme) : IStyles list =
    [
        Styles.Container [
            CSSProp.Display DisplayOptions.Flex
            CSSProp.FlexWrap "wrap"
        ]
        Styles.FormControl [
            CSSProp.Margin theme.spacing.unit
        ]
    ]

type ComposedTextFieldState = {
    name : string
}

type ComposedTextField(p) =
    inherit Component<IClassesProps,ComposedTextFieldState>(p)
    do
        base.setInitState { name = "Composed TextField" }

    member private this.handleChange (e : Event) =
        let value = e.Value
        this.setState (fun s _ -> { s with name = value })
    
    override this.render() =
        let classes = this.props.classes
        div [ HTMLAttr.Class !!classes?container ] [
            formControl [ HTMLAttr.Class !!classes?formControl ] [
                inputLabel [ HtmlFor "component-simple" ] [ str "Name" ]
                input [
                    HTMLAttr.Id "component-simple"
                    HTMLAttr.Value this.state.name
                    DOMAttr.OnChange this.handleChange
                ]
            ]
            formControl [
                HTMLAttr.Class !!classes?formControl
                HTMLAttr.Custom ("aria-describedby", "component-helper-text")
            ] [
                inputLabel [ HtmlFor "component-helper" ] [ str "Name" ]
                input [
                    HTMLAttr.Id "component-helper"
                    HTMLAttr.Value this.state.name
                    DOMAttr.OnChange this.handleChange
                ]
                formHelperText [ HTMLAttr.Id "component-helper-text" ] [
                    str "Some important helper text"
                ]
            ]
            formControl [
                HTMLAttr.Class !!classes?formControl
                HTMLAttr.Disabled true
            ] [
                inputLabel [ HtmlFor "component-disabled" ] [ str "Name" ]
                input [
                    HTMLAttr.Id "component-disabled"
                    HTMLAttr.Value this.state.name
                    DOMAttr.OnChange this.handleChange
                ]
                formHelperText [ ] [ str "Disabled" ]
            ]
            formControl [
                HTMLAttr.Class !!classes?formControl
                HTMLAttr.Custom ("aria-describedby", "component-error-text")
                MaterialProp.Error true
            ] [
                inputLabel [ HtmlFor "component-error" ] [ str "Name" ]
                input [
                    HTMLAttr.Id "component-error"
                    HTMLAttr.Value this.state.name
                    DOMAttr.OnChange this.handleChange
                ]
                formHelperText [ HTMLAttr.Id "component-error-text" ] [ str "Error" ]
            ]
            formControl [
                HTMLAttr.Class !!classes?formControl
                FormControlProp.Variant FormControlVariant.Filled
            ] [
                inputLabel [ HtmlFor "component-filled" ] [ str "Name" ]
                filledInput [
                    HTMLAttr.Id "component-filled"
                    HTMLAttr.Value this.state.name
                    DOMAttr.OnChange this.handleChange
                ] []
            ]
        ]

let textFields props =
    ofType<ComposedTextField,_,_> props []

let textFieldsWithStyles = withStyles (StyleType.Func styles) [] textFields

let view () =
    ReactElementType.create textFieldsWithStyles createEmpty<IClassesProps> []


