
namespace Admin
{
    partial class frmthongkedoanhthu_khoangtg
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmthongkedoanhthu_khoangtg));
            this.thongkedoanhthuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLKSDataSet = new Admin.QLKSDataSet();
            this.thongkedoanhthuhdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongkedoanhthuallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongkedoanhthuTableAdapter = new Admin.QLKSDataSetTableAdapters.thongkedoanhthuTableAdapter();
            this.thongkedoanhthuhdTableAdapter = new Admin.QLKSDataSetTableAdapters.thongkedoanhthuhdTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_chart = new System.Windows.Forms.Button();
            this.btntable = new System.Windows.Forms.Button();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rp_chart = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rltable = new Microsoft.Reporting.WinForms.ReportViewer();
            this.thongkedoanhthuallTableAdapter = new Admin.QLKSDataSetTableAdapters.thongkedoanhthuallTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.thongkedoanhthuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLKSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongkedoanhthuhdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongkedoanhthuallBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // thongkedoanhthuBindingSource
            // 
            this.thongkedoanhthuBindingSource.DataMember = "thongkedoanhthu";
            this.thongkedoanhthuBindingSource.DataSource = this.QLKSDataSet;
            // 
            // QLKSDataSet
            // 
            this.QLKSDataSet.DataSetName = "QLKSDataSet";
            this.QLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongkedoanhthuhdBindingSource
            // 
            this.thongkedoanhthuhdBindingSource.DataMember = "thongkedoanhthuhd";
            this.thongkedoanhthuhdBindingSource.DataSource = this.QLKSDataSet;
            // 
            // thongkedoanhthuallBindingSource
            // 
            this.thongkedoanhthuallBindingSource.DataMember = "thongkedoanhthuall";
            this.thongkedoanhthuallBindingSource.DataSource = this.QLKSDataSet;
            // 
            // thongkedoanhthuTableAdapter
            // 
            this.thongkedoanhthuTableAdapter.ClearBeforeFill = true;
            // 
            // thongkedoanhthuhdTableAdapter
            // 
            this.thongkedoanhthuhdTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_chart);
            this.panel1.Controls.Add(this.btntable);
            this.panel1.Controls.Add(this.dateEnd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateStart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 54);
            this.panel1.TabIndex = 1;
            // 
            // btn_chart
            // 
            this.btn_chart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_chart.BackColor = System.Drawing.Color.Blue;
            this.btn_chart.FlatAppearance.BorderSize = 0;
            this.btn_chart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_chart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chart.ForeColor = System.Drawing.Color.White;
            this.btn_chart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chart.Location = new System.Drawing.Point(1030, 7);
            this.btn_chart.Name = "btn_chart";
            this.btn_chart.Size = new System.Drawing.Size(250, 40);
            this.btn_chart.TabIndex = 22;
            this.btn_chart.Text = "Thống kê bằng biểu đồ";
            this.btn_chart.UseVisualStyleBackColor = false;
            this.btn_chart.Click += new System.EventHandler(this.btn_chart_Click);
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
            this.btntable.Location = new System.Drawing.Point(770, 7);
            this.btntable.Name = "btntable";
            this.btntable.Size = new System.Drawing.Size(250, 40);
            this.btntable.TabIndex = 21;
            this.btntable.Text = "Thống kê bằng bảng";
            this.btntable.UseVisualStyleBackColor = false;
            this.btntable.Click += new System.EventHandler(this.btntable_Click);
            // 
            // dateEnd
            // 
            this.dateEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateEnd.CustomFormat = "dd/MM/yyyy";
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(510, 16);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(250, 22);
            this.dateEnd.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(400, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Đến ngày:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateStart
            // 
            this.dateStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateStart.CustomFormat = "dd/MM/yyyy";
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(110, 16);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(250, 22);
            this.dateStart.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(0, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Từ ngày:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rp_chart
            // 
            this.rp_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.thongkedoanhthuBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.thongkedoanhthuhdBindingSource;
            this.rp_chart.LocalReport.DataSources.Add(reportDataSource1);
            this.rp_chart.LocalReport.DataSources.Add(reportDataSource2);
            this.rp_chart.LocalReport.ReportEmbeddedResource = "Admin.rp_doanhthu.rdlc";
            this.rp_chart.Location = new System.Drawing.Point(0, 54);
            this.rp_chart.Name = "rp_chart";
            this.rp_chart.ServerReport.BearerToken = null;
            this.rp_chart.Size = new System.Drawing.Size(1289, 396);
            this.rp_chart.TabIndex = 2;
            this.rp_chart.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // rltable
            // 
            this.rltable.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.thongkedoanhthuallBindingSource;
            this.rltable.LocalReport.DataSources.Add(reportDataSource3);
            this.rltable.LocalReport.ReportEmbeddedResource = "Admin.rp_doanhthu_ktg_all.rdlc";
            this.rltable.Location = new System.Drawing.Point(0, 54);
            this.rltable.Name = "rltable";
            this.rltable.ServerReport.BearerToken = null;
            this.rltable.Size = new System.Drawing.Size(1289, 396);
            this.rltable.TabIndex = 3;
            this.rltable.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // thongkedoanhthuallTableAdapter
            // 
            this.thongkedoanhthuallTableAdapter.ClearBeforeFill = true;
            // 
            // frmthongkedoanhthu_khoangtg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1289, 450);
            this.Controls.Add(this.rltable);
            this.Controls.Add(this.rp_chart);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmthongkedoanhthu_khoangtg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu theo khoảng thời gian";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmthongkedoanhthu_khoangtg_FormClosed);
            this.Load += new System.EventHandler(this.frmthongkedoanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thongkedoanhthuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLKSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongkedoanhthuhdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongkedoanhthuallBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource thongkedoanhthuBindingSource;
        private QLKSDataSet QLKSDataSet;
        private System.Windows.Forms.BindingSource thongkedoanhthuhdBindingSource;
        private QLKSDataSetTableAdapters.thongkedoanhthuTableAdapter thongkedoanhthuTableAdapter;
        private QLKSDataSetTableAdapters.thongkedoanhthuhdTableAdapter thongkedoanhthuhdTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rp_chart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_chart;
        private System.Windows.Forms.Button btntable;
        private Microsoft.Reporting.WinForms.ReportViewer rltable;
        private System.Windows.Forms.BindingSource thongkedoanhthuallBindingSource;
        private QLKSDataSetTableAdapters.thongkedoanhthuallTableAdapter thongkedoanhthuallTableAdapter;
    }
}