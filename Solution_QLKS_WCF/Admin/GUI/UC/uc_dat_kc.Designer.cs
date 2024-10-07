
namespace Admin.GUI.UC
{
    partial class uc_dat_kc
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
            this.btndat = new System.Windows.Forms.Button();
            this.datego = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltieude = new System.Windows.Forms.Label();
            this.cbxcustomer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btndat
            // 
            this.btndat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btndat.BackColor = System.Drawing.Color.Blue;
            this.btndat.FlatAppearance.BorderSize = 0;
            this.btndat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btndat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btndat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndat.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndat.ForeColor = System.Drawing.Color.White;
            this.btndat.Location = new System.Drawing.Point(380, 547);
            this.btndat.Name = "btndat";
            this.btndat.Size = new System.Drawing.Size(300, 77);
            this.btndat.TabIndex = 26;
            this.btndat.Text = "Đặt phòng";
            this.btndat.UseVisualStyleBackColor = false;
            this.btndat.Click += new System.EventHandler(this.btndat_Click);
            // 
            // datego
            // 
            this.datego.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datego.CustomFormat = "dd/MM/yyyy";
            this.datego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datego.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datego.Location = new System.Drawing.Point(192, 348);
            this.datego.Name = "datego";
            this.datego.Size = new System.Drawing.Size(790, 30);
            this.datego.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(4, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 49);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ngày đến:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(4, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 49);
            this.label1.TabIndex = 23;
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
            this.lbltieude.TabIndex = 22;
            this.lbltieude.Text = "PHIẾU ĐẶT PHÒNG";
            this.lbltieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxcustomer
            // 
            this.cbxcustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxcustomer.FormattingEnabled = true;
            this.cbxcustomer.Location = new System.Drawing.Point(192, 281);
            this.cbxcustomer.Name = "cbxcustomer";
            this.cbxcustomer.Size = new System.Drawing.Size(790, 33);
            this.cbxcustomer.TabIndex = 30;
            this.cbxcustomer.TextChanged += new System.EventHandler(this.cbxcustomer_TextChanged);
            // 
            // uc_dat_kc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.cbxcustomer);
            this.Controls.Add(this.btndat);
            this.Controls.Add(this.datego);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltieude);
            this.Name = "uc_dat_kc";
            this.Size = new System.Drawing.Size(1058, 658);
            this.Load += new System.EventHandler(this.uc_dat_kc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndat;
        private System.Windows.Forms.DateTimePicker datego;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltieude;
        private System.Windows.Forms.ComboBox cbxcustomer;
    }
}
