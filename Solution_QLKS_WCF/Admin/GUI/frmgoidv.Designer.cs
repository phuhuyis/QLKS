
namespace Admin.GUI
{
    partial class frmgoidv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgoidv));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvdg = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btntt = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btngoi = new System.Windows.Forms.Button();
            this.numersoluong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxdv = new System.Windows.Forms.ComboBox();
            this.dgvds = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnhuyhd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdg)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numersoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgvdg);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dịch vụ đã gọi";
            // 
            // dgvdg
            // 
            this.dgvdg.AllowUserToAddRows = false;
            this.dgvdg.BackgroundColor = System.Drawing.Color.White;
            this.dgvdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdg.Location = new System.Drawing.Point(3, 18);
            this.dgvdg.Name = "dgvdg";
            this.dgvdg.ReadOnly = true;
            this.dgvdg.RowHeadersVisible = false;
            this.dgvdg.RowHeadersWidth = 51;
            this.dgvdg.RowTemplate.Height = 24;
            this.dgvdg.Size = new System.Drawing.Size(1050, 225);
            this.dgvdg.TabIndex = 0;
            this.dgvdg.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdg_CellEnter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 246);
            this.panel2.TabIndex = 3;
            // 
            // btntt
            // 
            this.btntt.BackColor = System.Drawing.Color.Blue;
            this.btntt.FlatAppearance.BorderSize = 0;
            this.btntt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btntt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btntt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntt.ForeColor = System.Drawing.Color.White;
            this.btntt.Location = new System.Drawing.Point(197, 187);
            this.btntt.Name = "btntt";
            this.btntt.Size = new System.Drawing.Size(120, 34);
            this.btntt.TabIndex = 7;
            this.btntt.Text = "Thanh Toán";
            this.btntt.UseVisualStyleBackColor = false;
            this.btntt.Click += new System.EventHandler(this.btntt_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.Blue;
            this.btnhuy.FlatAppearance.BorderSize = 0;
            this.btnhuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnhuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnhuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.ForeColor = System.Drawing.Color.White;
            this.btnhuy.Location = new System.Drawing.Point(35, 187);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(120, 34);
            this.btnhuy.TabIndex = 6;
            this.btnhuy.Text = "Xóa";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Blue;
            this.btnsua.FlatAppearance.BorderSize = 0;
            this.btnsua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnsua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.White;
            this.btnsua.Location = new System.Drawing.Point(197, 122);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(120, 34);
            this.btnsua.TabIndex = 5;
            this.btnsua.Text = "Cập nhập";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btngoi
            // 
            this.btngoi.BackColor = System.Drawing.Color.Blue;
            this.btngoi.FlatAppearance.BorderSize = 0;
            this.btngoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btngoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btngoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngoi.ForeColor = System.Drawing.Color.White;
            this.btngoi.Location = new System.Drawing.Point(35, 122);
            this.btngoi.Name = "btngoi";
            this.btngoi.Size = new System.Drawing.Size(120, 34);
            this.btngoi.TabIndex = 4;
            this.btngoi.Text = "Gọi";
            this.btngoi.UseVisualStyleBackColor = false;
            this.btngoi.Click += new System.EventHandler(this.btngoi_Click);
            // 
            // numersoluong
            // 
            this.numersoluong.Location = new System.Drawing.Point(110, 52);
            this.numersoluong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numersoluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numersoluong.Name = "numersoluong";
            this.numersoluong.Size = new System.Drawing.Size(210, 22);
            this.numersoluong.TabIndex = 3;
            this.numersoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng:";
            // 
            // cbxdv
            // 
            this.cbxdv.FormattingEnabled = true;
            this.cbxdv.Location = new System.Drawing.Point(110, 6);
            this.cbxdv.Name = "cbxdv";
            this.cbxdv.Size = new System.Drawing.Size(210, 24);
            this.cbxdv.TabIndex = 1;
            this.cbxdv.TextChanged += new System.EventHandler(this.cbxdv_TextChanged);
            // 
            // dgvds
            // 
            this.dgvds.AllowUserToAddRows = false;
            this.dgvds.BackgroundColor = System.Drawing.Color.White;
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvds.Location = new System.Drawing.Point(3, 18);
            this.dgvds.Name = "dgvds";
            this.dgvds.ReadOnly = true;
            this.dgvds.RowHeadersVisible = false;
            this.dgvds.RowHeadersWidth = 51;
            this.dgvds.RowTemplate.Height = 24;
            this.dgvds.Size = new System.Drawing.Size(701, 343);
            this.dgvds.TabIndex = 0;
            this.dgvds.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvds_CellEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvds);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 364);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng giá";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dịch vụ:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(349, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 364);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 364);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.btnhuyhd);
            this.panel4.Controls.Add(this.btntt);
            this.panel4.Controls.Add(this.btnhuy);
            this.panel4.Controls.Add(this.btnsua);
            this.panel4.Controls.Add(this.btngoi);
            this.panel4.Controls.Add(this.numersoluong);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cbxdv);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(349, 364);
            this.panel4.TabIndex = 1;
            // 
            // btnhuyhd
            // 
            this.btnhuyhd.BackColor = System.Drawing.Color.Blue;
            this.btnhuyhd.FlatAppearance.BorderSize = 0;
            this.btnhuyhd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnhuyhd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnhuyhd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhuyhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuyhd.ForeColor = System.Drawing.Color.White;
            this.btnhuyhd.Location = new System.Drawing.Point(35, 247);
            this.btnhuyhd.Name = "btnhuyhd";
            this.btnhuyhd.Size = new System.Drawing.Size(282, 34);
            this.btnhuyhd.TabIndex = 8;
            this.btnhuyhd.Text = "Hủy hóa đơn";
            this.btnhuyhd.UseVisualStyleBackColor = false;
            this.btnhuyhd.Click += new System.EventHandler(this.btnhuyhd_Click);
            // 
            // frmgoidv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1056, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmgoidv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gọi dịch vụ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmgoidv_FormClosed);
            this.Load += new System.EventHandler(this.frmgoidv_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdg)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numersoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvdg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btntt;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btngoi;
        private System.Windows.Forms.NumericUpDown numersoluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxdv;
        private System.Windows.Forms.DataGridView dgvds;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnhuyhd;
    }
}