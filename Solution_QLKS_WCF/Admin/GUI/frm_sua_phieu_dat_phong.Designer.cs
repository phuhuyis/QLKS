
namespace Admin.GUI
{
    partial class frm_sua_phieu_dat_phong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sua_phieu_dat_phong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnluu = new System.Windows.Forms.Button();
            this.txtkh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsophieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtphong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datengayden = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 60);
            this.panel1.TabIndex = 50;
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
            // txtkh
            // 
            this.txtkh.Location = new System.Drawing.Point(530, 6);
            this.txtkh.Name = "txtkh";
            this.txtkh.ReadOnly = true;
            this.txtkh.Size = new System.Drawing.Size(200, 22);
            this.txtkh.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(374, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 53;
            this.label1.Text = "Khách hàng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtsophieu
            // 
            this.txtsophieu.Location = new System.Drawing.Point(168, 6);
            this.txtsophieu.Name = "txtsophieu";
            this.txtsophieu.ReadOnly = true;
            this.txtsophieu.Size = new System.Drawing.Size(200, 22);
            this.txtsophieu.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 52;
            this.label2.Text = "Số phiếu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(374, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 30);
            this.label3.TabIndex = 57;
            this.label3.Text = "Ngày đến:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtphong
            // 
            this.txtphong.Location = new System.Drawing.Point(168, 36);
            this.txtphong.Name = "txtphong";
            this.txtphong.ReadOnly = true;
            this.txtphong.Size = new System.Drawing.Size(200, 22);
            this.txtphong.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 30);
            this.label4.TabIndex = 56;
            this.label4.Text = "Phòng:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datengayden
            // 
            this.datengayden.CustomFormat = "dd/MM/yyyy";
            this.datengayden.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datengayden.Location = new System.Drawing.Point(530, 36);
            this.datengayden.Name = "datengayden";
            this.datengayden.Size = new System.Drawing.Size(200, 22);
            this.datengayden.TabIndex = 58;
            // 
            // frm_sua_phieu_dat_phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(745, 135);
            this.Controls.Add(this.datengayden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtphong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtkh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsophieu);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_sua_phieu_dat_phong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhập thông tin phiếu đặt phòng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_sua_phieu_dat_phong_FormClosed);
            this.Load += new System.EventHandler(this.frm_sua_phieu_dat_phong_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.TextBox txtkh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsophieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datengayden;
    }
}