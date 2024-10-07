
namespace Admin.GUI
{
    partial class frmcapnhapluong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcapnhapluong));
            this.txtten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnluu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsongaynghi = new System.Windows.Forms.NumericUpDown();
            this.txttt = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsongaynghi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttt)).BeginInit();
            this.SuspendLayout();
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(530, 13);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(200, 22);
            this.txtten.TabIndex = 5;
            this.txtten.Enter += new System.EventHandler(this.txtten_Enter);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(374, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên nhân viên:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(168, 13);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(200, 22);
            this.txtma.TabIndex = 3;
            this.txtma.Enter += new System.EventHandler(this.txtma_Enter);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã nhân viên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 60);
            this.panel1.TabIndex = 27;
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
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(374, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 30);
            this.label3.TabIndex = 31;
            this.label3.Text = "Thưởng thêm:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 30);
            this.label4.TabIndex = 29;
            this.label4.Text = "Số ngày nghỉ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtsongaynghi
            // 
            this.txtsongaynghi.Location = new System.Drawing.Point(168, 44);
            this.txtsongaynghi.Name = "txtsongaynghi";
            this.txtsongaynghi.Size = new System.Drawing.Size(200, 22);
            this.txtsongaynghi.TabIndex = 32;
            // 
            // txttt
            // 
            this.txttt.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txttt.Location = new System.Drawing.Point(530, 44);
            this.txttt.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(200, 22);
            this.txttt.TabIndex = 33;
            // 
            // frmcapnhapluong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 141);
            this.Controls.Add(this.txttt);
            this.Controls.Add(this.txtsongaynghi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcapnhapluong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhập thông tin lương";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmcapnhapluong_FormClosed);
            this.Load += new System.EventHandler(this.frmcapnhapluong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtsongaynghi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtsongaynghi;
        private System.Windows.Forms.NumericUpDown txttt;
    }
}