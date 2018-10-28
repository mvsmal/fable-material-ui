# Fade

<p class="description">The API documentation of the Fade React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.Helpers.MaterialUI.fade (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```

The Fade transition is used by the [Modal](/utils/modal/) component.
It uses [react-transition-group](https://github.com/reactjs/react-transition-group) internally.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">children</span> | <span class="prop-type">union:&nbsp;element&nbsp;&#124;<br>&nbsp;func<br></span> |   | A single child content element. |
| <span class="prop-name">MaterialProp.In</span> | <span class="prop-type">bool</span> |   | If `true`, the component will transition in. |
| <span class="prop-name">MaterialProp.Timeout</span> | <span class="prop-type">U2&lt;float,&nbsp;TransitionDurationProp&nbsp;list&gt;<br><br>type&nbsp;TransitionDurationProp&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Enter&nbsp;of&nbsp;float<br>&nbsp;&nbsp;&#124;&nbsp;Exit&nbsp;of&nbsp;float<br></span> | <span class="prop-default">{  enter: duration.enteringScreen,  exit: duration.leavingScreen,}</span> | The duration for the transition, in milliseconds. You may specify a single timeout for all transitions, or individually with an object. |

Any other properties supplied will be spread to the root element ([Transition](https://reactcommunity.org/react-transition-group/#Transition)).

## Inheritance

The properties of the [Transition](https://reactcommunity.org/react-transition-group/#Transition) component, from react-transition-group, are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

## Demos

- [Transitions](/utils/transitions/)

