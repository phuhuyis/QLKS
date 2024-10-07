
namespace Admin.GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.cbxmatkhau = new System.Windows.Forms.CheckBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxmatkhau
            // 
            this.cbxmatkhau.AutoSize = true;
            this.cbxmatkhau.BackColor = System.Drawing.Color.White;
            this.cbxmatkhau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxmatkhau.ForeColor = System.Drawing.Color.Blue;
            this.cbxmatkhau.Location = new System.Drawing.Point(17, 216);
            this.cbxmatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxmatkhau.Name = "cbxmatkhau";
            this.cbxmatkhau.Size = new System.Drawing.Size(220, 30);
            this.cbxmatkhau.TabIndex = 15;
            this.cbxmatkhau.Text = "Hiển thị mật khẩu";
            this.cbxmatkhau.UseVisualStyleBackColor = false;
            this.cbxmatkhau.CheckedChanged += new System.EventHandler(this.cbxmatkhau_CheckedChanged);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Blue;
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(334, 268);
            this.btnexit.Margin = new System.Windows.Forms.Padding(0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(150, 47);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Blue;
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(82, 268);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(150, 47);
            this.btnlogin.TabIndex = 13;
            this.btnlogin.Text = "Đăng nhập";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BackColor = System.Drawing.Color.White;
            this.txtmatkhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmatkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.ForeColor = System.Drawing.Color.Black;
            this.txtmatkhau.Location = new System.Drawing.Point(270, 164);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(278, 30);
            this.txtmatkhau.TabIndex = 12;
            this.txtmatkhau.UseSystemPasswordChar = true;
            this.txtmatkhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmatkhau_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(10, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 62);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật khẩu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.BackColor = System.Drawing.Color.White;
            this.txttendangnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttendangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttendangnhap.ForeColor = System.Drawing.Color.Black;
            this.txttendangnhap.Location = new System.Drawing.Point(270, 108);
            this.txttendangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(278, 30);
            this.txttendangnhap.TabIndex = 10;
            this.txttendangnhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttendangnhap_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(10, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 52);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên đăng nhập:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 79);
            this.label1.TabIndex = 8;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 328);
            this.Controls.Add(this.cbxmatkhau);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxmatkhau;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}