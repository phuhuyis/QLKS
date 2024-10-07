
namespace Employee.GUI.UC
{
    partial class uc_thue_kc
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbltieude = new System.Windows.Forms.Label();
            this.cbxcustomer = new System.Windows.Forms.ComboBox();
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
            this.btnthue.Location = new System.Drawing.Point(380, 547);
            this.btnthue.Name = "btnthue";
            this.btnthue.Size = new System.Drawing.Size(300, 77);
            this.btnthue.TabIndex = 30;
            this.btnthue.Text = "Thuê phòng";
            this.btnthue.UseVisualStyleBackColor = false;
            this.btnthue.Click += new System.EventHandler(this.btnthue_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(4, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 49);
            this.label1.TabIndex = 26;
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
            this.lbltieude.TabIndex = 25;
            this.lbltieude.Text = "PHIẾU THUÊ PHÒNG";
            this.lbltieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxcustomer
            // 
            this.cbxcustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxcustomer.FormattingEnabled = true;
            this.cbxcustomer.Location = new System.Drawing.Point(192, 296);
            this.cbxcustomer.Name = "cbxcustomer";
            this.cbxcustomer.Size = new System.Drawing.Size(790, 33);
            this.cbxcustomer.TabIndex = 31;
            this.cbxcustomer.TextChanged += new System.EventHandler(this.cbxcustomer_TextChanged);
            // 
            // uc_thue_kc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.cbxcustomer);
            this.Controls.Add(this.btnthue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltieude);
            this.Name = "uc_thue_kc";
            this.Size = new System.Drawing.Size(1058, 658);
            this.Load += new System.EventHandler(this.uc_thue_kc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnthue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltieude;
        private System.Windows.Forms.ComboBox cbxcustomer;
    }
}
