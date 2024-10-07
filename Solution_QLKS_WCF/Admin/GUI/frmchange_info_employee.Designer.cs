
namespace Admin.GUI
{
    partial class frmchange_info_employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmchange_info_employee));
            this.label1 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtlcb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txthsl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtgioitinh = new System.Windows.Forms.ComboBox();
            this.txtca = new System.Windows.Forms.ComboBox();
            this.txttt = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnluu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(168, 13);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(200, 22);
            this.txtma.TabIndex = 0;
            this.txtma.Enter += new System.EventHandler(this.txtma_Enter);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(530, 13);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(200, 22);
            this.txtten.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(374, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhân viên:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày sinh:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(374, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giới tính:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(168, 73);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(200, 22);
            this.txtdiachi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Địa chỉ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(530, 73);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(200, 22);
            this.txtsdt.TabIndex = 5;
            this.txtsdt.TextChanged += new System.EventHandler(this.txtsdt_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(374, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số điện thoại:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ca làm việc:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(374, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tình trạng:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtlcb
            // 
            this.txtlcb.Location = new System.Drawing.Point(168, 133);
            this.txtlcb.Name = "txtlcb";
            this.txtlcb.Size = new System.Drawing.Size(200, 22);
            this.txtlcb.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 30);
            this.label9.TabIndex = 18;
            this.label9.Text = "Lương cơ bản:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txthsl
            // 
            this.txthsl.Location = new System.Drawing.Point(530, 133);
            this.txthsl.Name = "txthsl";
            this.txthsl.Size = new System.Drawing.Size(200, 22);
            this.txthsl.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(374, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 30);
            this.label10.TabIndex = 20;
            this.label10.Text = "Hệ số lương:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.CustomFormat = "dd/MM/yyyy";
            this.txtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtngaysinh.Location = new System.Drawing.Point(168, 45);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(200, 22);
            this.txtngaysinh.TabIndex = 2;
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.FormattingEnabled = true;
            this.txtgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtgioitinh.Location = new System.Drawing.Point(530, 47);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(200, 24);
            this.txtgioitinh.TabIndex = 3;
            this.txtgioitinh.TextChanged += new System.EventHandler(this.txtgioitinh_TextChanged);
            // 
            // txtca
            // 
            this.txtca.FormattingEnabled = true;
            this.txtca.Items.AddRange(new object[] {
            "Ca sáng",
            "Ca chiều",
            "Ca tối"});
            this.txtca.Location = new System.Drawing.Point(168, 103);
            this.txtca.Name = "txtca";
            this.txtca.Size = new System.Drawing.Size(200, 24);
            this.txtca.TabIndex = 6;
            this.txtca.TextChanged += new System.EventHandler(this.txtca_TextChanged);
            // 
            // txttt
            // 
            this.txttt.FormattingEnabled = true;
            this.txttt.Items.AddRange(new object[] {
            "Còn làm",
            "Đã nghỉ việc"});
            this.txttt.Location = new System.Drawing.Point(530, 103);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(200, 24);
            this.txttt.TabIndex = 7;
            this.txttt.TextChanged += new System.EventHandler(this.txttt_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 60);
            this.panel1.TabIndex = 26;
            // 
            // btnluu
            // 
            this.btnluu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnluu.BackColor = System.Drawing.Color.Blue;
            this.btnluu.FlatAppearance.BorderSize = 0;
            this.btnluu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnluu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.White;
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(332, 10);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(80, 40);
            this.btnluu.TabIndex = 0;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // frmchange_info_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 244);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txttt);
            this.Controls.Add(this.txtca);
            this.Controls.Add(this.txtgioitinh);
            this.Controls.Add(this.txtngaysinh);
            this.Controls.Add(this.txthsl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtlcb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmchange_info_employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhập thông tin nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmchange_info_employee_FormClosed);
            this.Load += new System.EventHandler(this.frmchange_info_employee_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtlcb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txthsl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtngaysinh;
        private System.Windows.Forms.ComboBox txtgioitinh;
        private System.Windows.Forms.ComboBox txtca;
        private System.Windows.Forms.ComboBox txttt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnluu;
    }
}