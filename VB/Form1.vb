Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid
Imports System
Imports System.Windows.Forms

Namespace Q134867
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
			pivotGridControl1.BestFit()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' TODO: This line of code loads data into the 'nwindDataSet.ProductReports' table. You can move, or remove it, as needed.
			Me.productReportsTableAdapter.Fill(Me.nwindDataSet.ProductReports)
		End Sub

		Private Sub pivotGridControl1_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs) Handles pivotGridControl1.PopupMenuShowing
			If e.MenuType = PivotGridMenuType.Header Then
				HandleHeaderShowMenu(e)
			End If
		End Sub

		Private Sub HandleHeaderShowMenu(ByVal e As DevExpress.XtraPivotGrid.PopupMenuShowingEventArgs)
			If Not IsLastAreaField(pivotGridControl1, e.Field) Then
				CreateToggleTotalsItem(e)
			End If
		End Sub

		Private Function IsLastAreaField(ByVal pivotGridControl As PivotGridControl, ByVal field As PivotGridField) As Boolean
			For i As Integer = 0 To pivotGridControl.Fields.Count - 1
				If pivotGridControl.Fields(i).Visible AndAlso pivotGridControl.Fields(i).Area = field.Area AndAlso pivotGridControl.Fields(i).AreaIndex > field.AreaIndex Then
					Return False
				End If
			Next i
			Return True
		End Function

		Private Sub CreateToggleTotalsItem(ByVal e As PopupMenuShowingEventArgs)
			Dim isTotalsVisible As Boolean = e.Field.TotalsVisibility <> PivotTotalsVisibility.None
			Dim toggleTotalItem As New DXMenuItem(If(isTotalsVisible, "Hide Totals", "Show Totals"), AddressOf ToggleTotalsMenuItemClick)
			toggleTotalItem.BeginGroup = True
			toggleTotalItem.Tag = e.Field
			e.Menu.Items.Add(toggleTotalItem)
		End Sub

		Private Sub ToggleTotalsMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As DXMenuItem = DirectCast(sender, DXMenuItem)
			Dim field As PivotGridField = DirectCast(item.Tag, PivotGridField)
			If field.TotalsVisibility = PivotTotalsVisibility.None Then
				field.TotalsVisibility = PivotTotalsVisibility.AutomaticTotals
			Else
				field.TotalsVisibility = PivotTotalsVisibility.None
			End If
		End Sub
	End Class
End Namespace