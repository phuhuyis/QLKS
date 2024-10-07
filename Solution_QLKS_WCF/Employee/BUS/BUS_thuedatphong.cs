using Employee.GUI;
using Employee.GUI.UC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee.BUS
{
    public class BUS_thuedatphong
    {
        private static BUS_thuedatphong instance;
        public static BUS_thuedatphong DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_thuedatphong();
                }
                return instance;
            }
        }

        public void loadthue(uc_dat_km datm, uc_thue_km thuem, uc_dat_kc datc, uc_thue_kc thuec, String lk, frm_thue_dat_phong frm, String ma)
        {
            if (lk == "cu")
            {
                if (frm.Controls.Count == 3)
                    frm.Controls.RemoveAt(2);
                frm.Text = "Thuê phòng";
                thuec = new uc_thue_kc(ma, frm);
                thuec.Dock = DockStyle.Fill;
                thuec.Padding = new Padding(0, 80, 0, 0);
                //thuec.EnabledChanged += new System.EventHandler(this.ucdatphongkc1_EnabledChanged);
                frm.Controls.Add(thuec);
            }
            else
            {
                //Controls.Remove(dat);
                if(frm.Controls.Count == 3)
                    frm.Controls.RemoveAt(2);
                //Controls.Remove(thue);
                frm.Text = "Thuê phòng";
                thuem = new uc_thue_km();
                thuem.Dock = DockStyle.Fill;
                thuem.Padding = new Padding(0, 80, 0, 0);
                //thuem.EnabledChanged += new System.EventHandler(this.ucdatphongkc1_EnabledChanged);
                frm.Controls.Add(thuem);
            }
        }

        public void loaddat(uc_dat_km datm, uc_thue_km thuem, uc_dat_kc datc, uc_thue_kc thuec, String lk, frm_thue_dat_phong frm, String ma)
        {
            if (lk == "cu")
            {
                if (frm.Controls.Count == 3)
                    frm.Controls.RemoveAt(2);
                frm.Text = "Đặt phòng";
                datc = new uc_dat_kc(ma, frm);
                datc.Dock = DockStyle.Fill;
                datc.Padding = new Padding(0, 80, 0, 0);
                //datc.EnabledChanged += new EventHandler(this.ucdatphongkc1_EnabledChanged);
                frm.Controls.Add(datc);
            }
            else
            {
                frm.Text = "Đặt phòng";
                //Controls.Remove(dat);
                if (frm.Controls.Count == 3)
                    frm.Controls.RemoveAt(2);
                //Controls.Remove(thue);
                //frm.Controls.Remove(thuem);
                frm.Text = "Đặt phòng";
                datm = new uc_dat_km();
                datm.Dock = DockStyle.Fill;
                datm.Padding = new Padding(0, 80, 0, 0);
                //datm.EnabledChanged += new System.EventHandler(this.ucdatphongkc1_EnabledChanged);
                frm.Controls.Add(datm);
            }
        }

        public void loadkh(ComboBox cbx)
        {
            cbx.DataSource = Program.qlks.loadkhdat();
            cbx.DisplayMember = "hoten";
            cbx.ValueMember = "makh";
        }

        public void datphong(ComboBox cbxcustomer, DateTimePicker datego, String maphong, frm_thue_dat_phong frm)
        {
            if(ktngayden(datego.Value))
            {
                MessageBox.Show("Đặt phòng thành công");
                Program.qlks.datphongkc(cbxcustomer.SelectedValue.ToString(), datego.Value, maphong);
                frm.Close();
            }
            else
            {
                MessageBox.Show("Ngày đến phải lớn hơn ngày hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool kiemtraphong(String maphong)
        {
            return Program.qlks.kiemtraphong(maphong);
        }

        private bool ktngayden(DateTime date)
        {
            if(date.Year > DateTime.Now.Year)
            {
                return true;
            }
            else
            {
                if(date.Year == DateTime.Now.Year)
                {
                    if (date.Month > DateTime.Now.Month)
                    {
                        return true;
                    }
                    else
                    {
                        if (date.Month == DateTime.Now.Month)
                        {
                            if (date.Day > DateTime.Now.Day)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }   
                else
                {
                    return false;
                }
            }
        }

        public void thuephong(ComboBox cbxcustomer, String maphong, String manv, frm_thue_dat_phong frm)
        {
            MessageBox.Show("Thuê phòng thành công");
            Program.qlks.thuephongkc(cbxcustomer.SelectedValue.ToString(), maphong, manv);
            frm.Close();
        }
    }
}
