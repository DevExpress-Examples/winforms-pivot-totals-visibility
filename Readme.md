<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582643/18.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E923)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Pivot Grid for WinForms - How to Customize the Popup Menu to Hide or Show the Totals

This example demonstrates how to add a new item to the [Header Area](https://docs.devexpress.com/WindowsForms/1803) popup menu. This item shows or hides totals in the PivotGrid control.

For this, handle the [PivotGridControl.PopupMenuShowing](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.PopupMenuShowing) event. In the **PopupMenuShowing** event handler, create a new menu item and add it to the [e.Menu.Items](https://docs.devexpress.com/WindowsForms/DevExpress.Utils.Menu.DXSubMenuItem.Items) collection.

![screenshot](https://github.com/DevExpress-Examples/how-to-toggle-totals-visibility-at-runtime-e923/blob/18.2.3%2B/images/screenshot.png)

<!-- default file list -->
## Files to Look at

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
## Documentation 
- [PivotGridControl.PopupMenuShowing](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.PopupMenuShowing)
- [Header Area Context Menu](https://docs.devexpress.com/WindowsForms/1725/controls-and-libraries/pivot-grid/ui-elements/header-area-context-menu)
## More Examples
- [Pivot Grid for WinForms - How to Change SummaryDisplayType in the Context Menu](https://github.com/DevExpress-Examples/how-to-change-summarydisplaytype-via-the-context-menu-e2321)
