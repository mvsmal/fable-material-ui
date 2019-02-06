# MobileStepper

<p class="description">The API documentation of the MobileStepper React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.mobileStepper (props : seq<IHTMLProp>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MobileStepperProp.BackButton</span> | <span class="prop-type">ReactElement</span> |   | A back button element. For instance, it can be be a `Button` or a `IconButton`. |
| <span class="prop-name">MobileStepperProp.ActiveStep</span> | <span class="prop-type">int</span> | <span class="prop-default">0</span> | Set the active step (zero based index). Defines which dot is highlighted when the variant is `Dots`. |
| <span class="prop-name">MobileStepperProp.NextButton</span> | <span class="prop-type">ReactElement</span> |   | A next button element. For instance, it can be be a `Button` or a `IconButton`. |
| <span class="prop-name">MobileStepperProp.Position</span> | <span class="prop-type">type&nbsp;MobileStepperPosition&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Bottom<br>&nbsp;&nbsp;&#124;&nbsp;Top<br>&nbsp;&nbsp;&#124;&nbsp;Static<br></span> | <span class="prop-default">MobileStepperPosition.Bottom</span> | Set the positioning type. |
| <span class="prop-name required">MobileStepperProp.Steps *</span> | <span class="prop-type">int</span> |   | The total steps. |
| <span class="prop-name">MobileStepperProp.Variant</span> | <span class="prop-type">type&nbsp;MobileStepperVariant&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Text<br>&nbsp;&nbsp;&#124;&nbsp;Dots<br>&nbsp;&nbsp;&#124;&nbsp;Progress<br></span> | <span class="prop-default">MobileStepperVariant.Dots</span> | The variant to use. |
| <span class="prop-name">ChildrenProp.LinearProgressProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the `LinearProgress` element. |

Any other properties supplied will be spread to the root element ([Paper](#/api/paper)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.PositionBottom</span> | Styles applied to the root element if `position="bottom"`.
| <span class="prop-name">ClassNames.PositionTop</span> | Styles applied to the root element if `position="top"`.
| <span class="prop-name">ClassNames.PositionStatic</span> | Styles applied to the root element if `position="static"`.
| <span class="prop-name">ClassNames.Dots</span> | Styles applied to the dots container if `variant="dots"`.
| <span class="prop-name">ClassNames.Dot</span> | Styles applied to each dot if `variant="dots"`.
| <span class="prop-name">ClassNames.DotActive</span> | Styles applied to a dot if `variant="dots"` and this is the active step.
| <span class="prop-name">ClassNames.Progress</span> | Styles applied to the Linear Progress component if `variant="progress"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/MobileStepper/MobileStepper.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiMobileStepper`.

## Inheritance

The properties of the [Paper](#/api/paper) component are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [Steppers](/demos/steppers/)-->

