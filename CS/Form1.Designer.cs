namespace WinFormsPivot_App {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.productReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new WinFormsPivot_App.nwindDataSet();
            this.fieldCategoryName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductSales1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShippedDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.productReportsTableAdapter = new WinFormsPivot_App.nwindDataSetTableAdapters.ProductReportsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productReportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataSource = this.productReportsBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName1,
            this.fieldProductName1,
            this.fieldProductSales1,
            this.fieldShippedDate1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.Size = new System.Drawing.Size(728, 454);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.PopupMenuShowing += new DevExpress.XtraPivotGrid.PopupMenuShowingEventHandler(this.pivotGridControl1_PopupMenuShowing);
            // 
            // productReportsBindingSource
            // 
            this.productReportsBindingSource.DataMember = "ProductReports";
            this.productReportsBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldCategoryName1
            // 
            this.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName1.AreaIndex = 0;
            this.fieldCategoryName1.Caption = "CategoryName";
            dataSourceColumnBinding1.ColumnName = "CategoryName";
            this.fieldCategoryName1.DataBinding = dataSourceColumnBinding1;
            this.fieldCategoryName1.Name = "fieldCategoryName1";
            // 
            // fieldProductName1
            // 
            this.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName1.AreaIndex = 1;
            this.fieldProductName1.Caption = "ProductName";
            dataSourceColumnBinding2.ColumnName = "ProductName";
            this.fieldProductName1.DataBinding = dataSourceColumnBinding2;
            this.fieldProductName1.Name = "fieldProductName1";
            // 
            // fieldProductSales1
            // 
            this.fieldProductSales1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductSales1.AreaIndex = 0;
            this.fieldProductSales1.Caption = "ProductSales";
            dataSourceColumnBinding3.ColumnName = "ProductSales";
            this.fieldProductSales1.DataBinding = dataSourceColumnBinding3;
            this.fieldProductSales1.Name = "fieldProductSales1";
            // 
            // fieldShippedDate1
            // 
            this.fieldShippedDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldShippedDate1.AreaIndex = 0;
            this.fieldShippedDate1.Caption = "Year";
            dataSourceColumnBinding4.ColumnName = "ShippedDate";
            dataSourceColumnBinding4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldShippedDate1.DataBinding = dataSourceColumnBinding4;
            this.fieldShippedDate1.Name = "fieldShippedDate1";
            // 
            // productReportsTableAdapter
            // 
            this.productReportsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 454);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productReportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource productReportsBindingSource;
        private WinFormsPivot_App.nwindDataSetTableAdapters.ProductReportsTableAdapter productReportsTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductSales1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShippedDate1;
    }
}

