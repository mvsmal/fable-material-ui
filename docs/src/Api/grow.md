# Grow

<p class="description">The API documentation of the Grow React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.grow (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```

The Grow transition is used by the [Tooltip](/demos/tooltips/) and
[Popover](/utils/popover/) components.
It uses [react-transition-group](https://github.com/reactjs/react-transition-group) internally.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.In</span> | <span class="prop-type">bool</span> |   | If `true`, show the component; triggers the enter or exit animation. |
| <span class="prop-name">GrowProp.Timeout</span> | <span class="prop-type">U3&lt;float,&nbsp;TransitionDuration&nbsp;list,&nbsp;AutoEnum&gt;<br><br>type&nbsp;TransitionDurationProp&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Enter&nbsp;of&nbsp;float<br>&nbsp;&nbsp;&#124;&nbsp;Exit&nbsp;of&nbsp;float<br><br>type&nbsp;AutoEnum&nbsp;=&nbsp;Auto<br></span> | <span class="prop-default">AutoEnum.Auto</span> | The duration for the transition, in milliseconds. You may specify a single timeout for all transitions, or individually with an object.<br>Set to `AutoEnum.Auto` to automatically calculate transition time based on height. |

Any other properties supplied will be spread to the root element ([Transition](https://reactcommunity.org/react-transition-group/#Transition)).

## Inheritance

The properties of the [Transition](https://reactcommunity.org/react-transition-group/#Transition) component, from react-transition-group, are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [Popover](/utils/popover/)-->
<!--- [Transitions](/utils/transitions/)-->

