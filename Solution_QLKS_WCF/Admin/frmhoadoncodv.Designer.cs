
namespace Admin
{
    partial class frmhoadoncodv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhoadoncodv));
            this.hoadoncodvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLKSDataSet = new Admin.QLKSDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hoadoncodvTableAdapter = new Admin.QLKSDataSetTableAdapters.hoadoncodvTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hoadoncodvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLKSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // hoadoncodvBindingSource
            // 
            this.hoadoncodvBindingSource.DataMember = "hoadoncodv";
            this.hoadoncodvBindingSource.DataSource = this.QLKSDataSet;
            // 
            // QLKSDataSet
            // 
            this.QLKSDataSet.DataSetName = "QLKSDataSet";
            this.QLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.hoadoncodvBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Admin.rpinhdcodv.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // hoadoncodvTableAdapter
            // 
            this.hoadoncodvTableAdapter.ClearBeforeFill = true;
            // 
            // frmhoadoncodv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmhoadoncodv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmhoadoncodv_FormClosed);
            this.Load += new System.EventHandler(this.frmhoadoncodv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoadoncodvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLKSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource hoadoncodvBindingSource;
        private QLKSDataSet QLKSDataSet;
        private QLKSDataSetTableAdapters.hoadoncodvTableAdapter hoadoncodvTableAdapter;
    }
}