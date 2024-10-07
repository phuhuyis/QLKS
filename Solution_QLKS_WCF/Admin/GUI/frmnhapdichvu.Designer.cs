
namespace Admin.GUI
{
    partial class frmnhapdichvu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnhapdichvu));
            this.txtdv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdv
            // 
            this.txtdv.FormattingEnabled = true;
            this.txtdv.Location = new System.Drawing.Point(168, 15);
            this.txtdv.Name = "txtdv";
            this.txtdv.Size = new System.Drawing.Size(200, 24);
            this.txtdv.TabIndex = 9;
            this.txtdv.SelectedIndexChanged += new System.EventHandler(this.txtdv_SelectedIndexChanged);
            this.txtdv.TextChanged += new System.EventHandler(this.txtdv_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đơn vị cung cấp:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnnhap
            // 
            this.btnnhap.BackColor = System.Drawing.Color.Blue;
            this.btnnhap.FlatAppearance.BorderSize = 0;
            this.btnnhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnhap.Location = new System.Drawing.Point(374, 13);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(149, 30);
            this.btnnhap.TabIndex = 11;
            this.btnnhap.Text = "Nhập dịch vụ";
            this.btnnhap.UseVisualStyleBackColor = false;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // frmnhapdichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 51);
            this.Controls.Add(this.btnnhap);
            this.Controls.Add(this.txtdv);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmnhapdichvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn đơn vị cung cấp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmnhapdichvu_FormClosed);
            this.Load += new System.EventHandler(this.frmnhapdichvu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox txtdv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnnhap;
    }
}