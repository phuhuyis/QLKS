
namespace Admin.GUI.UC
{
    partial class uc_dat_km
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
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcus = new System.Windows.Forms.TextBox();
            this.btndat = new System.Windows.Forms.Button();
            this.ngayden = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltieude = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcmnd
            // 
            this.txtcmnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcmnd.Location = new System.Drawing.Point(192, 315);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(790, 30);
            this.txtcmnd.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(4, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 49);
            this.label3.TabIndex = 20;
            this.label3.Text = "CMND:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtcus
            // 
            this.txtcus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcus.Location = new System.Drawing.Point(192, 247);
            this.txtcus.Name = "txtcus";
            this.txtcus.Size = new System.Drawing.Size(790, 30);
            this.txtcus.TabIndex = 19;
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
            this.btndat.Location = new System.Drawing.Point(380, 513);
            this.btndat.Name = "btndat";
            this.btndat.Size = new System.Drawing.Size(300, 77);
            this.btndat.TabIndex = 18;
            this.btndat.Text = "Đặt phòng";
            this.btndat.UseVisualStyleBackColor = false;
            this.btndat.Click += new System.EventHandler(this.btndat_Click);
            // 
            // ngayden
            // 
            this.ngayden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ngayden.CustomFormat = "dd/MM/yyyy";
            this.ngayden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayden.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayden.Location = new System.Drawing.Point(192, 386);
            this.ngayden.Name = "ngayden";
            this.ngayden.Size = new System.Drawing.Size(790, 30);
            this.ngayden.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(4, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 49);
            this.label2.TabIndex = 16;
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
            this.label1.Location = new System.Drawing.Point(4, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 49);
            this.label1.TabIndex = 15;
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
            this.lbltieude.TabIndex = 14;
            this.lbltieude.Text = "PHIẾU ĐẶT PHÒNG";
            this.lbltieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_dat_km
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.txtcmnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcus);
            this.Controls.Add(this.btndat);
            this.Controls.Add(this.ngayden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltieude);
            this.Name = "uc_dat_km";
            this.Size = new System.Drawing.Size(1058, 658);
            this.Load += new System.EventHandler(this.uc_dat_km_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcus;
        private System.Windows.Forms.Button btndat;
        private System.Windows.Forms.DateTimePicker ngayden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltieude;
    }
}
