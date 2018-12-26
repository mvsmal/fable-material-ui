# GridListTileBar

<p class="description">The API documentation of the GridListTileBar React component. Learn more about the properties and the CSS customization points.</p>

```fsharp
Fable.MaterialUI.Core.gridListTileBar (props : IHTMLProp list) (children : ReactElement list) : ReactElement
```



## Props

| Name | Type | Default | Description |
|:-----|:-----|:--------|:------------|
| <span class="prop-name">MaterialProp.Classes</span> | <span class="prop-type">ClassNames list</span> |   | Override or extend the styles applied to the component.  See CSS API below for more details.  |
| <span class="prop-name">GridListTileBarProp.ActionIcon</span> | <span class="prop-type">ReactNode</span> |   | An IconButton element to be used as secondary action target (primary action target is the tile itself). |
| <span class="prop-name">GridListTileBarProp.ActionPosition</span> | <span class="prop-type">type&nbsp;ActionPosition&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Left<br>&nbsp;&nbsp;&#124;&nbsp;Right<br></span> | <span class="prop-default">ActionPosition.Right</span> | Position of secondary action IconButton. |
| <span class="prop-name">GridListTileBarProp.Subtitle</span> | <span class="prop-type">ReactNode</span> |   | String or element serving as subtitle (support text). |
| <span class="prop-name">GridListTileBarProp.Title</span> | <span class="prop-type">ReactNode</span> |   | Title to be displayed on tile. |
| <span class="prop-name">GridListTileBarProp.TitlePosition</span> | <span class="prop-type">type&nbsp;TitlePosition&nbsp;=<br>&nbsp;&nbsp;&#124;&nbsp;Top<br>&nbsp;&nbsp;&#124;&nbsp;TitlePosition.Bottom<br></span> | <span class="prop-default">Bottom</span> | Position of the title bar. |

Any other properties supplied will be spread to the root element (native element).

## CSS API

You can override all the class names injected by Material-UI thanks to the `MaterialProp.Classes` property.
This property accepts the following keys:


| Name | Description |
|:-----|:------------|
| <span class="prop-name">ClassNames.Root</span> | Styles applied to the root element.
| <span class="prop-name">ClassNames.TitlePositionBottom</span> | Styles applied to the root element if `titlePosition="bottom"`.
| <span class="prop-name">ClassNames.TitlePositionTop</span> | Styles applied to the root element if `titlePosition="top"`.
| <span class="prop-name">ClassNames.RootSubtitle</span> | Styles applied to the root element if a `subtitle` is provided.
| <span class="prop-name">ClassNames.TitleWrap</span> | Styles applied to the title and subtitle container element.
| <span class="prop-name">ClassNames.TitleWrapActionPosLeft</span> | Styles applied to the container element if `actionPosition="left"`.
| <span class="prop-name">ClassNames.TitleWrapActionPosRight</span> | Styles applied to the container element if `actionPosition="right"`.
| <span class="prop-name">ClassNames.Title</span> | Styles applied to the title container element.
| <span class="prop-name">ClassNames.Subtitle</span> | Styles applied to the subtitle container element.
| <span class="prop-name">ClassNames.ActionIcon</span> | Styles applied to the actionIcon if supplied.
| <span class="prop-name">ClassNames.ActionIconActionPosLeft</span> | Styles applied to the actionIcon if `actionPosition="left"`.

Have a look at [overriding with classes](#/customization/overrides) section
and the [implementation of the component](https://github.com/mui-org/material-ui/tree/master/packages/material-ui/src/GridListTileBar/GridListTileBar.js)
for more detail.

If using the `overrides` key of the theme as documented
[here](#/customization/themes),
you need to use the following style sheet name: `OverridesProp.MuiGridListTileBar`.

<!--## Demos-->

<!--- [Grid List](/demos/grid-list/)-->

