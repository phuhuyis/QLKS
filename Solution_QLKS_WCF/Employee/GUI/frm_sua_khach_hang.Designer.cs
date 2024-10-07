
namespace Employee.GUI
{
    partial class frm_sua_khach_hang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sua_khach_hang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnluu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 60);
            this.panel1.TabIndex = 40;
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(374, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 43;
            this.label1.Text = "CMND:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(168, 13);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(200, 22);
            this.txtten.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 42;
            this.label2.Text = "Tên khách hàng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(530, 13);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(200, 22);
            this.txtcmnd.TabIndex = 44;
            // 
            // frm_sua_khach_hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(745, 115);
            this.Controls.Add(this.txtcmnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_sua_khach_hang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhập thông tin khách hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_sua_khach_hang_FormClosed);
            this.Load += new System.EventHandler(this.frm_sua_khach_hang_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcmnd;
    }
}