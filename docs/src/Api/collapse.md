# Collapse

<p class="description">The API documentation of the Collapse React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.collapse (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```

The Collapse transition is used by the
[Vertical Stepper](/demos/steppers/#vertical-stepper) StepContent component.
It uses [react-transition-group](https://github.com/reactjs/react-transition-group) internally.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">MaterialProp.Component</span> | <span class="prop-type">ReactType</span> | <span class="prop-default">"div"</span> | The component used for the root node. Either a string to use a DOM element or a component. |
| <span class="prop-name">MaterialProp.In</span> | <span class="prop-type">bool</span> |   | If `true`, the component will transition in. |
| <span class="prop-name">CollapseProp.CollapsedHeight</span> | <span class="prop-type">string</span> | <span class="prop-default">"0px"</span> | The height of the container when collapsed. |
| <span class="prop-name">CollapseProp.Timeout</span> | <span class="prop-type">U3&lt;float,&nbsp;TransitionDuration&nbsp;list,&nbsp;AutoEnum&gt;<br><br>type&nbsp;TransitionDurationProp&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Enter&nbsp;of&nbsp;float<br>&nbsp;&nbsp;&#124;&nbsp;Exit&nbsp;of&nbsp;float<br><br>type&nbsp;AutoEnum&nbsp;=&nbsp;Auto<br></span> | <span class="prop-default">duration.standard</span> | The duration for the transition, in milliseconds. You may specify a single timeout for all transitions, or individually with an object.<br>Set to `Auto` to automatically calculate transition time based on height. |

Any other properties supplied will be spread to the root element ([Transition](https://reactcommunity.org/react-transition-group/#Transition)).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Container</span> | Styles applied to the container element.
| <span class="prop-name">ClassNames.Entered</span> | Styles applied to the container element when the transition has entered.
| <span class="prop-name">ClassNames.Wrapper</span> | Styles applied to the outer wrapper element.
| <span class="prop-name">ClassNames.WrapperInner</span> | Styles applied to the inner wrapper element.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/Collapse/Collapse.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiCollapse`.

## Inheritance

The properties of the [Transition](https://reactcommunity.org/react-transition-group/#Transition) component, from react-transition-group, are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [Cards](/demos/cards/)-->
<!--- [Lists](/demos/lists/)-->
<!--- [Transitions](/utils/transitions/)-->

