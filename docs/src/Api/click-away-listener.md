# ClickAwayListener

<p class="description">The API documentation of the ClickAwayListener React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.clickAwayListener (props : seq<IHTMLProp>) (children : seq<ReactElement>) : ReactElement
```

Listen for click events that occur somewhere in the document, outside of the element itself.
For instance, if you need to hide a menu when people click anywhere else on your page.

## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">ClickAwayListenerProp.MouseEvent</span> | <span class="prop-type">type&nbsp;[&lt;Erase&gt;]&nbsp;ClickAwayListenerMouseEvent&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Event&nbsp;of&nbsp;MouseEvent<br>&nbsp;&nbsp;&#124;&nbsp;False<br><br>type&nbsp;MouseEvent&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;OnClick<br>&nbsp;&nbsp;&#124;&nbsp;OnMouseDown<br>&nbsp;&nbsp;&#124;&nbsp;OnMouseUp<br></span> | <span class="prop-default">MouseEvent.OnMouseUp</span> | The mouse event to listen to. You can disable the listener by providing `false`. |
| <span class="prop-name required">ClickAwayListenerProp.OnClickAway *</span> | <span class="prop-type">obj->unit</span> |   | Callback fired when a "click away" event is detected. |
| <span class="prop-name">ClickAwayListenerProp.TouchEvent</span> | <span class="prop-type">type&nbsp;[&lt;Erase&gt;]&nbsp;ClickAwayListenerTouchEvent&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Event&nbsp;of&nbsp;TouchEvent<br>&nbsp;&nbsp;&#124;&nbsp;False<br><br>type&nbsp;TouchEvent&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;OnTouchStart<br>&nbsp;&nbsp;&#124;&nbsp;OnTouchEnd<br></span> | <span class="prop-default">TouchEvent.OnTouchEnd</span> | The touch event to listen to. You can disable the listener by providing `false`. |

Any other properties supplied will be spread to the root element ([EventListener](https://github.com/oliviertassinari/react-event-listener/)).

## Inheritance

The properties of the [EventListener](https://github.com/oliviertassinari/react-event-listener/) component, from react-event-listener, are also available.
<!-- You can take advantage of this behavior to [target nested components](/guides/api/#spread). -->

<!--## Demos-->

<!--- [Menus](/demos/menus/)-->
<!--- [Click Away Listener](/utils/click-away-listener/)-->

