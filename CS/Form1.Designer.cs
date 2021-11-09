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
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.productReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new WinFormsPivot_App.nwindDataSet();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductSales = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShippedDate = new DevExpress.XtraPivotGrid.PivotGridField();
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
            this.fieldCategoryName,
            this.fieldProductName,
            this.fieldProductSales,
            this.fieldShippedDate});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
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
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "CategoryName";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "ProductName";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldProductSales
            // 
            this.fieldProductSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductSales.AreaIndex = 0;
            this.fieldProductSales.Caption = "ProductSales";
            this.fieldProductSales.FieldName = "ProductSales";
            this.fieldProductSales.Name = "fieldProductSales";
            // 
            // fieldShippedDate
            // 
            this.fieldShippedDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldShippedDate.AreaIndex = 0;
            this.fieldShippedDate.Caption = "Year";
            this.fieldShippedDate.FieldName = "ShippedDate";
            this.fieldShippedDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldShippedDate.Name = "fieldShippedDate";
            this.fieldShippedDate.UnboundFieldName = "fieldShippedDate";
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
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductSales;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShippedDate;
    }
}

