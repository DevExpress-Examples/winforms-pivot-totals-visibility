using DevExpress.Utils.Menu;
using DevExpress.XtraPivotGrid;
using System;

namespace WinFormsPivot_App {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
			InitializeComponent();
            pivotGridControl1.BestFit();
		}

		private void Form1_Load(object sender, EventArgs e) {
			// This line of code loads data into the 'nwindDataSet.ProductReports' table. You can move, or remove it, as needed.
			this.productReportsTableAdapter.Fill(this.nwindDataSet.ProductReports);
		}

        void pivotGridControl1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if (e.MenuType == PivotGridMenuType.Header) {
                HandleHeaderShowMenu(e);
            }
        }

        private void HandleHeaderShowMenu(DevExpress.XtraPivotGrid.PopupMenuShowingEventArgs e) {
			if(!IsLastAreaField(pivotGridControl1, e.Field))
				CreateToggleTotalsItem(e);
		}

		private bool IsLastAreaField(PivotGridControl pivotGridControl, PivotGridField field) {
			for(int i = 0; i < pivotGridControl.Fields.Count; i++) {
				if(pivotGridControl.Fields[i].Visible && pivotGridControl.Fields[i].Area == field.Area 
					&& pivotGridControl.Fields[i].AreaIndex > field.AreaIndex)
					return false;
			}
			return true;
		}

        private void CreateToggleTotalsItem(PopupMenuShowingEventArgs e) {
			bool isTotalsVisible = e.Field.TotalsVisibility != PivotTotalsVisibility.None;
			DXMenuItem toggleTotalItem = new DXMenuItem(isTotalsVisible ? "Hide Totals" : "Show Totals", ToggleTotalsMenuItemClick);
			toggleTotalItem.BeginGroup = true;
			toggleTotalItem.Tag = e.Field;
			e.Menu.Items.Add(toggleTotalItem);
		}

		private void ToggleTotalsMenuItemClick(object sender, EventArgs e) {
			DXMenuItem item = (DXMenuItem)sender;
			PivotGridField field = (PivotGridField)item.Tag;
			if(field.TotalsVisibility == PivotTotalsVisibility.None)
				field.TotalsVisibility = PivotTotalsVisibility.AutomaticTotals;
			else
				field.TotalsVisibility = PivotTotalsVisibility.None;
		}
	}
}