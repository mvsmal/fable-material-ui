# Popper

<p class="description">A Popper can be used to display some content on top of another. It's an alternative to react-popper.</p>

Some important features of the `Popper` component:

- 🕷 Popper relies on the 3rd party library ([Popper.js](https://github.com/FezVrasta/popper.js)) for perfect positioning.
- 💄 It's an alternative API to react-popper. It aims for simplicity.
- 📦 10 kB gzipped.
- The children is `Portal` to the body of the document to avoid rendering problems.
You can disable this behavior with `disablePortal`.
- The scroll isn't blocked like with the `Popover` component.
The placement of the popper updates with the available area in the viewport.
- Clicking away does not hide the `Popper` component.
  If you need this behavior, you can use `ClickAwayListener`.
- The `anchorEl` is passed as the reference object to create a new `Popper.js` instance.