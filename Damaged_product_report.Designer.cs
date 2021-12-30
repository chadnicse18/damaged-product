
namespace Inventory_Mangaement
{
    partial class Damaged_product_report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Damaged_ProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventory_managementdbDataSet = new Inventory_Mangaement.inventory_managementdbDataSet();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Damaged_ProductTableAdapter = new Inventory_Mangaement.inventory_managementdbDataSetTableAdapters.Damaged_ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Damaged_ProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_managementdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Damaged_ProductBindingSource
            // 
            this.Damaged_ProductBindingSource.DataMember = "Damaged_Product";
            this.Damaged_ProductBindingSource.DataSource = this.inventory_managementdbDataSet;
            // 
            // inventory_managementdbDataSet
            // 
            this.inventory_managementdbDataSet.DataSetName = "inventory_managementdbDataSet";
            this.inventory_managementdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Damaged_Product";
            reportDataSource1.Value = this.Damaged_ProductBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Inventory_Mangaement.Damaged.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(687, 559);
            this.reportViewer2.TabIndex = 1;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // Damaged_ProductTableAdapter
            // 
            this.Damaged_ProductTableAdapter.ClearBeforeFill = true;
            // 
            // Damaged_product_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 559);
            this.Controls.Add(this.reportViewer2);
            this.Name = "Damaged_product_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Damaged_product_report";
            this.Load += new System.EventHandler(this.Damaged_product_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Damaged_ProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_managementdbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource Damaged_ProductBindingSource;
        private inventory_managementdbDataSet inventory_managementdbDataSet;
        private inventory_managementdbDataSetTableAdapters.Damaged_ProductTableAdapter Damaged_ProductTableAdapter;
    }
}