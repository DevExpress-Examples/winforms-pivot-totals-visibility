Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid

Namespace Q134867
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.ProductReports' table. You can move, or remove it, as needed.
			Me.productReportsTableAdapter.Fill(Me.nwindDataSet.ProductReports)

		End Sub

		Private Sub pivotGridControl1_ShowMenu(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridMenuEventArgs) Handles pivotGridControl1.ShowMenu
			If e.MenuType = DevExpress.XtraPivotGrid.PivotGridMenuType.Header Then
				HandleHeaderShowMenu(e)
			End If
		End Sub

		Private Sub HandleHeaderShowMenu(ByVal e As DevExpress.XtraPivotGrid.PivotGridMenuEventArgs)
			If (Not IsLastAreaField(pivotGridControl1, e.Field)) Then
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

		Private Sub CreateToggleTotalsItem(ByVal e As DevExpress.XtraPivotGrid.PivotGridMenuEventArgs)
			Dim isTotalsVisible As Boolean = e.Field.TotalsVisibility <> PivotTotalsVisibility.None
			Dim toggleTotalItem As DXMenuItem
			If isTotalsVisible Then
				toggleTotalItem = New DXMenuItem("Hide Totals", AddressOf ToggleTotalsMenuItemClick)
			Else
				toggleTotalItem = New DXMenuItem("Show Totals", AddressOf ToggleTotalsMenuItemClick)
			End If
			toggleTotalItem.BeginGroup = True
			toggleTotalItem.Tag = e.Field
			e.Menu.Items.Add(toggleTotalItem)
		End Sub

		Private Sub ToggleTotalsMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As DXMenuItem = CType(sender, DXMenuItem)
			Dim field As PivotGridField = CType(item.Tag, PivotGridField)
			If field.TotalsVisibility = PivotTotalsVisibility.None Then
				field.TotalsVisibility = PivotTotalsVisibility.AutomaticTotals
			Else
				field.TotalsVisibility = PivotTotalsVisibility.None
			End If
		End Sub
	End Class
End Namespace