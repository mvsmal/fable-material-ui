# StepContent

<p class="description">The API documentation of the StepContent React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.stepContent (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">ChildrenProp.TransitionComponent</span> | <span class="prop-type">ReactElementType</span> | <span class="prop-default">Collapse</span> | Collapse component. |
| <span class="prop-name">MaterialProp.TransitionDuration</span> | <span class="prop-type">U3&lt;float,&nbsp;TransitionDuration&nbsp;list,&nbsp;AutoEnum&gt;<br><br>type&nbsp;TransitionDurationProp&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Enter&nbsp;of&nbsp;float<br>&nbsp;&nbsp;&#124;&nbsp;Exit&nbsp;of&nbsp;float<br><br>type&nbsp;AutoEnum&nbsp;=&nbsp;Auto<br></span> | <span class="prop-default">Auto</span> | Adjust the duration of the content expand transition. Passed as a property to the transition component.<br>Set to `Auto` to automatically calculate transition time based on height. |
| <span class="prop-name">ChildrenProp.TransitionProps</span> | <span class="prop-type">IHTMLProp list</span> |   | Properties applied to the `Transition` element. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.Last</span> | Styles applied to the root element if `last={true}` (controlled by `Step`).
| <span class="prop-name">ClassNames.Transition</span> | Styles applied to the Transition component.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/StepContent/StepContent.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiStepContent`.

<!--## Demos-->

<!--- [Steppers](/demos/steppers/)-->

