<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to toggle totals visibility at runtime


This example demonstrates how to add an item to the headers popup menu. To do this, handle the [PivotGridControl.PopupMenuShowing](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.PopupMenuShowing) event, create a new menu item and add it to the [e.Menu.Items](https://docs.devexpress.com/WindowsForms/DevExpress.Utils.Menu.DXSubMenuItem.Items) collection.

![screenshot](https://github.com/DevExpress-Examples/how-to-toggle-totals-visibility-at-runtime-e923/blob/13.1.4%2B/images/screenshot.png)