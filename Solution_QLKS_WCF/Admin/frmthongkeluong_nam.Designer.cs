
namespace Admin
{
    partial class frmthongkeluong_nam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmthongkeluong_nam));
            this.thongkeluongnamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_luong = new Admin.DataSet_luong();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numeryear = new System.Windows.Forms.NumericUpDown();
            this.btntable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.thongkeluongnamTableAdapter = new Admin.DataSet_luongTableAdapters.thongkeluongnamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.thongkeluongnamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_luong)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeryear)).BeginInit();
            this.SuspendLayout();
            // 
            // thongkeluongnamBindingSource
            // 
            this.thongkeluongnamBindingSource.DataMember = "thongkeluongnam";
            this.thongkeluongnamBindingSource.DataSource = this.DataSet_luong;
            // 
            // DataSet_luong
            // 
            this.DataSet_luong.DataSetName = "DataSet_luong";
            this.DataSet_luong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numeryear);
            this.panel1.Controls.Add(this.btntable);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 54);
            this.panel1.TabIndex = 3;
            // 
            // numeryear
            // 
            this.numeryear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numeryear.Location = new System.Drawing.Point(111, 19);
            this.numeryear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numeryear.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.numeryear.Name = "numeryear";
            this.numeryear.Size = new System.Drawing.Size(288, 22);
            this.numeryear.TabIndex = 23;
            this.numeryear.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // btntable
            // 
            this.btntable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btntable.BackColor = System.Drawing.Color.Blue;
            this.btntable.FlatAppearance.BorderSize = 0;
            this.btntable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btntable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntable.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntable.ForeColor = System.Drawing.Color.White;
            this.btntable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntable.Location = new System.Drawing.Point(405, 7);
            this.btntable.Name = "btntable";
            this.btntable.Size = new System.Drawing.Size(108, 40);
            this.btntable.TabIndex = 21;
            this.btntable.Text = "Thống kê";
            this.btntable.UseVisualStyleBackColor = false;
            this.btntable.Click += new System.EventHandler(this.btntable_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(5, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Năm:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.thongkeluongnamBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Admin.rp_luong_nam.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 54);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(516, 396);
            this.reportViewer1.TabIndex = 4;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // thongkeluongnamTableAdapter
            // 
            this.thongkeluongnamTableAdapter.ClearBeforeFill = true;
            // 
            // frmthongkeluong_nam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmthongkeluong_nam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê lương theo năm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmthongkeluong_nam_FormClosed);
            this.Load += new System.EventHandler(this.frmthongkeluong_nam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thongkeluongnamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_luong)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeryear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numeryear;
        private System.Windows.Forms.Button btntable;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource thongkeluongnamBindingSource;
        private DataSet_luong DataSet_luong;
        private DataSet_luongTableAdapters.thongkeluongnamTableAdapter thongkeluongnamTableAdapter;
    }
}