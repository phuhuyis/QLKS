using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin.GUI;

namespace Admin.BUS
{
    public class BUS_system
    {
        String bloaiphong = "lp000";
        FlowLayoutPanel flpphong;
        private static BUS_system instance;
        frmSystem frm;


        public static BUS_system DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_system();
                }
                return instance;
            }
        }

        public void loadphong(String loaiphong, FlowLayoutPanel flpphong, frmSystem frm)
        {
            this.frm = frm;
            this.flpphong = flpphong;
            flpphong.Controls.Clear();
            DataTable dt = Program.qlks.loadphong(loaiphong);
            Button btn;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                btn = new Button();
                btn.Name = dt.Rows[i][0].ToString() + dt.Rows[i][2].ToString();
                btn.Text = "Phòng " + dt.Rows[i][1].ToString();
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Width = 120;
                btn.Height = 120;
                btn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
                btn.BackColor = Color.Blue;
                btn.ForeColor = Color.White;
                btn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 3;
                btn.Font = new System.Drawing.Font("Segoe UI", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (dt.Rows[i][2].ToString().Equals("1"))
                    btn.Image = Admin.Properties.Resources.home2;
                else
                    if (dt.Rows[i][2].ToString().Equals("2"))
                        btn.Image = Admin.Properties.Resources.home1;
                    else
                        btn.Image = Admin.Properties.Resources.home;
                btn.Click += new System.EventHandler(this.btndatthue_Click);
                flpphong.Controls.Add(btn);
            }
            flpphong.Show();
            frm.loailp = bloaiphong;
        }

        private void btndatthue_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name.Substring((sender as Button).Name.Length - 1) == "1")
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm khách hàng mới hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialog == System.Windows.Forms.DialogResult.OK)
                {
                    frm_thue_dat_phong frm = new frm_thue_dat_phong((sender as Button).Name.Substring(0, (sender as Button).Name.Length - 1), "moi", this.frm);
                    frm.Show();
                }
                else
                {
                    if(dialog == System.Windows.Forms.DialogResult.Cancel)
                    {
                        frm_thue_dat_phong frm = new frm_thue_dat_phong((sender as Button).Name.Substring(0, (sender as Button).Name.Length - 1), "cu", this.frm);
                        frm.Show();
                    }
                }
            }
            else
            {
                if ((sender as Button).Name.Substring((sender as Button).Name.Length - 1) == "2")
                {
                    DialogResult dialog = MessageBox.Show("Bạn có muốn chắc chắn muốn thuê phòng " + (sender as Button).Text.Substring(6) + " hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dialog == System.Windows.Forms.DialogResult.OK)
                    {
                        MessageBox.Show("Thuê phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.qlks.chuyen((sender as Button).Name.Substring(0, (sender as Button).Name.Length - 1), this.frm.user);
                    }
                }
                else
                {
                    frmgoidv frmgoidv = new frmgoidv(BUS_cthd.DAO.laysohd((sender as Button).Name.Substring(0, (sender as Button).Name.Length - 1)), this.frm);
                    frmgoidv.Show();
                }
            }
        }

        public void loadloaiphong(FlowLayoutPanel flploaiphong)
        {
            if(flploaiphong.Controls.Count > 0)
                flploaiphong.Controls.Clear();
            DataTable dt = Program.qlks.loadloaiphong();
            Button btn;
            btn = new Button();
            btn.Name = "lp000";
            btn.Text = "Tất cả";
            btn.Width = 150;
            btn.Height = 60;
            btn.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            btn.BackColor = Color.Blue;
            btn.ForeColor = Color.White;
            btn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 3;
            btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.Click += new System.EventHandler(this.btnloaiphong_Click);
            flploaiphong.Controls.Add(btn);
            for (int i = 1; i <= dt.Rows.Count; i++)
            {
                btn = new Button();
                btn.Name = dt.Rows[i - 1][0].ToString();
                btn.Text = dt.Rows[i - 1][1].ToString();
                btn.Width = 150;
                btn.Height = 60;
                btn.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
                btn.BackColor = Color.Blue;
                btn.ForeColor = Color.White;
                btn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 3;
                btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.Click += new System.EventHandler(this.btnloaiphong_Click);
                flploaiphong.Controls.Add(btn);
            }
        }

        private void btnloaiphong_Click(object sender, EventArgs e)
        {
            bloaiphong = (sender as Button).Name;
            loadphong(bloaiphong, flpphong, frm);
        }
    }
}
