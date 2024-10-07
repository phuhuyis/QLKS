
namespace Admin.GUI.UC
{
    partial class uc_thue_km
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnthue = new System.Windows.Forms.Button();
            this.cmnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.namecus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltieude = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnthue
            // 
            this.btnthue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnthue.BackColor = System.Drawing.Color.Blue;
            this.btnthue.FlatAppearance.BorderSize = 0;
            this.btnthue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnthue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnthue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthue.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthue.ForeColor = System.Drawing.Color.White;
            this.btnthue.Location = new System.Drawing.Point(380, 513);
            this.btnthue.Name = "btnthue";
            this.btnthue.Size = new System.Drawing.Size(300, 77);
            this.btnthue.TabIndex = 24;
            this.btnthue.Text = "Thuê phòng";
            this.btnthue.UseVisualStyleBackColor = false;
            this.btnthue.Click += new System.EventHandler(this.btnthue_Click);
            // 
            // cmnd
            // 
            this.cmnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnd.Location = new System.Drawing.Point(192, 330);
            this.cmnd.Name = "cmnd";
            this.cmnd.Size = new System.Drawing.Size(790, 30);
            this.cmnd.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(4, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 49);
            this.label3.TabIndex = 22;
            this.label3.Text = "CMND:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // namecus
            // 
            this.namecus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namecus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namecus.Location = new System.Drawing.Point(192, 262);
            this.namecus.Name = "namecus";
            this.namecus.Size = new System.Drawing.Size(790, 30);
            this.namecus.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(4, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 49);
            this.label1.TabIndex = 20;
            this.label1.Text = "Khách hàng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbltieude
            // 
            this.lbltieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltieude.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieude.ForeColor = System.Drawing.Color.Blue;
            this.lbltieude.Location = new System.Drawing.Point(0, 0);
            this.lbltieude.Name = "lbltieude";
            this.lbltieude.Size = new System.Drawing.Size(1058, 123);
            this.lbltieude.TabIndex = 19;
            this.lbltieude.Text = "PHIẾU THUÊ PHÒNG";
            this.lbltieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_thue_km
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnthue);
            this.Controls.Add(this.cmnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.namecus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltieude);
            this.Name = "uc_thue_km";
            this.Size = new System.Drawing.Size(1058, 658);
            this.Load += new System.EventHandler(this.uc_thue_km_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthue;
        private System.Windows.Forms.TextBox cmnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namecus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltieude;
    }
}
