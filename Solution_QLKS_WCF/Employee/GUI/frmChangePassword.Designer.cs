
namespace Employee.GUI
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmatkhaucu = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmatkhaumoi = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnhaplaimatkhau = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btndoimatkhau = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtmatkhaucu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // txtmatkhaucu
            // 
            this.txtmatkhaucu.BackColor = System.Drawing.Color.White;
            this.txtmatkhaucu.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhaucu.ForeColor = System.Drawing.Color.Black;
            this.txtmatkhaucu.Location = new System.Drawing.Point(247, 20);
            this.txtmatkhaucu.Name = "txtmatkhaucu";
            this.txtmatkhaucu.Size = new System.Drawing.Size(357, 22);
            this.txtmatkhaucu.TabIndex = 0;
            this.txtmatkhaucu.Enter += new System.EventHandler(this.txtmatkhaucu_Enter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtmatkhaumoi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 61);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // txtmatkhaumoi
            // 
            this.txtmatkhaumoi.BackColor = System.Drawing.Color.White;
            this.txtmatkhaumoi.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhaumoi.Location = new System.Drawing.Point(247, 20);
            this.txtmatkhaumoi.Name = "txtmatkhaumoi";
            this.txtmatkhaumoi.Size = new System.Drawing.Size(357, 22);
            this.txtmatkhaumoi.TabIndex = 0;
            this.txtmatkhaumoi.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtnhaplaimatkhau);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(616, 61);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // txtnhaplaimatkhau
            // 
            this.txtnhaplaimatkhau.BackColor = System.Drawing.Color.White;
            this.txtnhaplaimatkhau.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhaplaimatkhau.Location = new System.Drawing.Point(247, 20);
            this.txtnhaplaimatkhau.Name = "txtnhaplaimatkhau";
            this.txtnhaplaimatkhau.Size = new System.Drawing.Size(357, 22);
            this.txtnhaplaimatkhau.TabIndex = 0;
            this.txtnhaplaimatkhau.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btndoimatkhau);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 183);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(616, 59);
            this.panel4.TabIndex = 3;
            // 
            // btndoimatkhau
            // 
            this.btndoimatkhau.BackColor = System.Drawing.Color.Blue;
            this.btndoimatkhau.FlatAppearance.BorderSize = 0;
            this.btndoimatkhau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btndoimatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndoimatkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoimatkhau.ForeColor = System.Drawing.Color.White;
            this.btndoimatkhau.Location = new System.Drawing.Point(233, 9);
            this.btndoimatkhau.Name = "btndoimatkhau";
            this.btndoimatkhau.Size = new System.Drawing.Size(150, 40);
            this.btndoimatkhau.TabIndex = 0;
            this.btndoimatkhau.Text = "Đổi mật khẩu";
            this.btndoimatkhau.UseVisualStyleBackColor = false;
            this.btndoimatkhau.Click += new System.EventHandler(this.btndoimatkhau_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 242);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChangePassword_FormClosed);
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmatkhaucu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmatkhaumoi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnhaplaimatkhau;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btndoimatkhau;
    }
}