Namespace WinFormsPivot_App
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.productReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New nwindDataSet()
            Me.fieldCategoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductSales1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldShippedDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.productReportsTableAdapter = New nwindDataSetTableAdapters.ProductReportsTableAdapter()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.productReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.pivotGridControl1.DataSource = Me.productReportsBindingSource
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCategoryName1, Me.fieldProductName1, Me.fieldProductSales1, Me.fieldShippedDate1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(728, 454)
            Me.pivotGridControl1.TabIndex = 0
            '
            'productReportsBindingSource
            '
            Me.productReportsBindingSource.DataMember = "ProductReports"
            Me.productReportsBindingSource.DataSource = Me.nwindDataSet
            '
            'nwindDataSet
            '
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'fieldCategoryName1
            '
            Me.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName1.AreaIndex = 0
            Me.fieldCategoryName1.Caption = "CategoryName"
            DataSourceColumnBinding1.ColumnName = "CategoryName"
            Me.fieldCategoryName1.DataBinding = DataSourceColumnBinding1
            Me.fieldCategoryName1.Name = "fieldCategoryName1"
            '
            'fieldProductName1
            '
            Me.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName1.AreaIndex = 1
            Me.fieldProductName1.Caption = "ProductName"
            DataSourceColumnBinding2.ColumnName = "ProductName"
            Me.fieldProductName1.DataBinding = DataSourceColumnBinding2
            Me.fieldProductName1.Name = "fieldProductName1"
            '
            'fieldProductSales1
            '
            Me.fieldProductSales1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldProductSales1.AreaIndex = 0
            Me.fieldProductSales1.Caption = "ProductSales"
            DataSourceColumnBinding3.ColumnName = "ProductSales"
            Me.fieldProductSales1.DataBinding = DataSourceColumnBinding3
            Me.fieldProductSales1.Name = "fieldProductSales1"
            '
            'fieldShippedDate1
            '
            Me.fieldShippedDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldShippedDate1.AreaIndex = 0
            Me.fieldShippedDate1.Caption = "Year"
            DataSourceColumnBinding4.ColumnName = "ShippedDate"
            DataSourceColumnBinding4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldShippedDate1.DataBinding = DataSourceColumnBinding4
            Me.fieldShippedDate1.Name = "fieldShippedDate1"
            '
            'productReportsTableAdapter
            '
            Me.productReportsTableAdapter.ClearBeforeFill = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(728, 454)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.productReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private nwindDataSet As nwindDataSet
		Private productReportsBindingSource As System.Windows.Forms.BindingSource
		Private productReportsTableAdapter As nwindDataSetTableAdapters.ProductReportsTableAdapter
		Private fieldCategoryName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductSales1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldShippedDate1 As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

