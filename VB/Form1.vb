Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid

Namespace Q134867

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' TODO: This line of code loads data into the 'nwindDataSet.ProductReports' table. You can move, or remove it, as needed.
            productReportsTableAdapter.Fill(nwindDataSet.ProductReports)
        End Sub

        Private Sub pivotGridControl1_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PopupMenuShowingEventArgs)
            If e.MenuType Is DevExpress.XtraPivotGrid.PivotGridMenuType.Header Then
                Me.HandleHeaderShowMenu(e)
            End If
        End Sub

        Private Sub HandleHeaderShowMenu(ByVal e As DevExpress.XtraPivotGrid.PopupMenuShowingEventArgs)
            If Not IsLastAreaField(pivotGridControl1, e.Field) Then Me.CreateToggleTotalsItem(e)
        End Sub

        Private Function IsLastAreaField(ByVal pivotGridControl As PivotGridControl, ByVal field As PivotGridField) As Boolean
            For i As Integer = 0 To pivotGridControl.Fields.Count - 1
                If pivotGridControl.Fields(i).Visible AndAlso pivotGridControl.Fields(i).Area Is field.Area AndAlso pivotGridControl.Fields(i).AreaIndex > field.AreaIndex Then Return False
            Next

            Return True
        End Function

        Private Sub CreateToggleTotalsItem(ByVal e As DevExpress.XtraPivotGrid.PopupMenuShowingEventArgs)
            Dim isTotalsVisible As Boolean = e.Field.TotalsVisibility IsNot PivotTotalsVisibility.None
            Dim toggleTotalItem As DXMenuItem = New DXMenuItem(If(isTotalsVisible, "Hide Totals", "Show Totals"), AddressOf ToggleTotalsMenuItemClick)
            toggleTotalItem.BeginGroup = True
            toggleTotalItem.Tag = e.Field
            e.Menu.Items.Add(toggleTotalItem)
        End Sub

        Private Sub ToggleTotalsMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As DXMenuItem = CType(sender, DXMenuItem)
            Dim field As PivotGridField = CType(item.Tag, PivotGridField)
            If field.TotalsVisibility Is PivotTotalsVisibility.None Then
                field.TotalsVisibility = PivotTotalsVisibility.AutomaticTotals
            Else
                field.TotalsVisibility = PivotTotalsVisibility.None
            End If
        End Sub
    End Class
End Namespace
