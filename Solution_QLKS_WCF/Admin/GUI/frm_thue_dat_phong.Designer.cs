
namespace Admin.GUI
{
    partial class frm_thue_dat_phong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_thue_dat_phong));
            this.btnthue = new System.Windows.Forms.Button();
            this.btndat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnthue
            // 
            this.btnthue.BackColor = System.Drawing.Color.Blue;
            this.btnthue.FlatAppearance.BorderSize = 0;
            this.btnthue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnthue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnthue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthue.ForeColor = System.Drawing.Color.White;
            this.btnthue.Location = new System.Drawing.Point(400, 0);
            this.btnthue.Margin = new System.Windows.Forms.Padding(0);
            this.btnthue.Name = "btnthue";
            this.btnthue.Size = new System.Drawing.Size(400, 80);
            this.btnthue.TabIndex = 4;
            this.btnthue.Text = "THUÊ PHÒNG";
            this.btnthue.UseVisualStyleBackColor = false;
            this.btnthue.Click += new System.EventHandler(this.btnthue_Click);
            // 
            // btndat
            // 
            this.btndat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btndat.FlatAppearance.BorderSize = 0;
            this.btndat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btndat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btndat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndat.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndat.ForeColor = System.Drawing.Color.White;
            this.btndat.Location = new System.Drawing.Point(0, 0);
            this.btndat.Margin = new System.Windows.Forms.Padding(0);
            this.btndat.Name = "btndat";
            this.btndat.Size = new System.Drawing.Size(400, 80);
            this.btndat.TabIndex = 3;
            this.btndat.Text = "ĐẶT PHÒNG";
            this.btndat.UseVisualStyleBackColor = false;
            this.btndat.Click += new System.EventHandler(this.btndat_Click);
            // 
            // frm_thue_dat_phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthue);
            this.Controls.Add(this.btndat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_thue_dat_phong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_thue_dat_phong_FormClosed);
            this.Load += new System.EventHandler(this.frm_thue_dat_phong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnthue;
        private System.Windows.Forms.Button btndat;
    }
}