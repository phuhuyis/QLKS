
namespace Admin
{
    partial class frm_thongke_luongtienravao_thang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_thongke_luongtienravao_thang));
            this.thongketienravaothangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Tienravao = new Admin.DataSet_Tienravao();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numeryear = new System.Windows.Forms.NumericUpDown();
            this.numermonth = new System.Windows.Forms.NumericUpDown();
            this.btn_chart = new System.Windows.Forms.Button();
            this.btntable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rp_chart = new Microsoft.Reporting.WinForms.ReportViewer();
            this.thongketienravaothangTableAdapter = new Admin.DataSet_TienravaoTableAdapters.thongketienravaothangTableAdapter();
            this.rp_tbl = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.thongketienravaothangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Tienravao)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeryear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numermonth)).BeginInit();
            this.SuspendLayout();
            // 
            // thongketienravaothangBindingSource
            // 
            this.thongketienravaothangBindingSource.DataMember = "thongketienravaothang";
            this.thongketienravaothangBindingSource.DataSource = this.DataSet_Tienravao;
            // 
            // DataSet_Tienravao
            // 
            this.DataSet_Tienravao.DataSetName = "DataSet_Tienravao";
            this.DataSet_Tienravao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numeryear);
            this.panel1.Controls.Add(this.numermonth);
            this.panel1.Controls.Add(this.btn_chart);
            this.panel1.Controls.Add(this.btntable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 54);
            this.panel1.TabIndex = 4;
            // 
            // numeryear
            // 
            this.numeryear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numeryear.Location = new System.Drawing.Point(506, 19);
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
            this.numeryear.Size = new System.Drawing.Size(258, 22);
            this.numeryear.TabIndex = 24;
            this.numeryear.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // numermonth
            // 
            this.numermonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numermonth.Location = new System.Drawing.Point(106, 19);
            this.numermonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numermonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numermonth.Name = "numermonth";
            this.numermonth.Size = new System.Drawing.Size(288, 22);
            this.numermonth.TabIndex = 23;
            this.numermonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(400, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Năm:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(0, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tháng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rp_chart
            // 
            this.rp_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.thongketienravaothangBindingSource;
            this.rp_chart.LocalReport.DataSources.Add(reportDataSource1);
            this.rp_chart.LocalReport.ReportEmbeddedResource = "Admin.rp_chart_tienravao_thang.rdlc";
            this.rp_chart.Location = new System.Drawing.Point(0, 54);
            this.rp_chart.Name = "rp_chart";
            this.rp_chart.ServerReport.BearerToken = null;
            this.rp_chart.Size = new System.Drawing.Size(1289, 396);
            this.rp_chart.TabIndex = 5;
            this.rp_chart.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // thongketienravaothangTableAdapter
            // 
            this.thongketienravaothangTableAdapter.ClearBeforeFill = true;
            // 
            // rp_tbl
            // 
            this.rp_tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.thongketienravaothangBindingSource;
            this.rp_tbl.LocalReport.DataSources.Add(reportDataSource2);
            this.rp_tbl.LocalReport.ReportEmbeddedResource = "Admin.rp_tbl_tienravao_thang.rdlc";
            this.rp_tbl.Location = new System.Drawing.Point(0, 54);
            this.rp_tbl.Name = "rp_tbl";
            this.rp_tbl.ServerReport.BearerToken = null;
            this.rp_tbl.Size = new System.Drawing.Size(1289, 396);
            this.rp_tbl.TabIndex = 6;
            this.rp_tbl.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // frm_thongke_luongtienravao_thang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1289, 450);
            this.Controls.Add(this.rp_tbl);
            this.Controls.Add(this.rp_chart);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_thongke_luongtienravao_thang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê lượng tiền ra vào theo tháng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_thongke_luongtienravao_thang_FormClosed);
            this.Load += new System.EventHandler(this.frm_thongke_luongtienravao_thang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thongketienravaothangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Tienravao)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeryear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numermonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numeryear;
        private System.Windows.Forms.NumericUpDown numermonth;
        private System.Windows.Forms.Button btn_chart;
        private System.Windows.Forms.Button btntable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rp_chart;
        private System.Windows.Forms.BindingSource thongketienravaothangBindingSource;
        private DataSet_Tienravao DataSet_Tienravao;
        private DataSet_TienravaoTableAdapters.thongketienravaothangTableAdapter thongketienravaothangTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rp_tbl;
    }
}