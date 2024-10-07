using Admin.GUI;
using Admin.GUI.UC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.BUS
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

        public void loadthue(uc_dat_km datm, uc_thue_km thuem, uc_dat_kc datc, uc_thue_kc thuec, String lk, frm_thue_dat_phong frm, String ma, frmSystem frmsys)
        {
            if (lk == "cu")
            {
                if (frm.Controls.Count == 3)
                    frm.Controls.RemoveAt(2);
                frm.Text = "Thuê phòng";
                thuec = new uc_thue_kc(ma, frm, frmsys);
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
                thuem = new uc_thue_km(ma, frm, frmsys);
                thuem.Dock = DockStyle.Fill;
                thuem.Padding = new Padding(0, 80, 0, 0);
                //thuem.EnabledChanged += new System.EventHandler(this.ucdatphongkc1_EnabledChanged);
                frm.Controls.Add(thuem);
            }
        }

        public void loaddat(uc_dat_km datm, uc_thue_km thuem, uc_dat_kc datc, uc_thue_kc thuec, String lk, frm_thue_dat_phong frm, String ma, frmSystem frmsys)
        {
            if (lk == "cu")
            {
                if (frm.Controls.Count == 3)
                    frm.Controls.RemoveAt(2);
                frm.Text = "Đặt phòng";
                datc = new uc_dat_kc(ma, frm, frmsys);
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
                datm = new uc_dat_km(ma, frm, frmsys);
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

        public static bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }

        bool ktsdt(String sdt)
        {
            try
            {
                long sdtt = long.Parse(sdt);
                if (sdt.Length == 9)
                {
                    return true;
                }
                else
                {
                    if (sdt.Length == 12)
                        return true;
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        static string CapitalizeFirstLetter(string value)
        {
            value = value.ToLower();
            char[] array = value.ToCharArray();
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }

        public void datphongkm(TextBox namecustomer, TextBox cmnd, DateTimePicker datego, String maphong, frm_thue_dat_phong frm)
        {
            if (namecustomer.Text.Trim().Length > 0)
            {
                if (namecustomer.Text.Trim().Length > 100)
                {
                    //ten nv nhieu hon 100 ky tu
                    MessageBox.Show("Tên khách hàng nhiều hơn 100 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (hasSpecialChar(namecustomer.Text.Trim()))
                    {
                        MessageBox.Show("Tên khách hàng có ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (cmnd.Text.Trim().Length > 0)
                        {
                            if (ktsdt(cmnd.Text.Trim()))
                            {
                                if (ktngayden(datego.Value))
                                {
                                    MessageBox.Show("Đặt phòng thành công");
                                    Program.qlks.datphongkm(CapitalizeFirstLetter(namecustomer.Text.Trim()), cmnd.Text.Trim(), datego.Value, maphong);
                                    frm.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Ngày đến phải lớn hơn ngày hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("CMND sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            //sdt rong
                            MessageBox.Show("Hãy nhập CMND", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                //tennv rong
                MessageBox.Show("Hãy nhập tên khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void thuephongkm(TextBox namecustomer, TextBox cmnd, String maphong, String manv, frm_thue_dat_phong frm)
        {
            if (namecustomer.Text.Trim().Length > 0)
            {
                if (namecustomer.Text.Trim().Length > 100)
                {
                    //ten nv nhieu hon 100 ky tu
                    MessageBox.Show("Tên khách hàng nhiều hơn 100 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (hasSpecialChar(namecustomer.Text.Trim()))
                    {
                        MessageBox.Show("Tên khách hàng có ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (cmnd.Text.Trim().Length > 0)
                        {
                            if (ktsdt(cmnd.Text.Trim()))
                            {
                                MessageBox.Show("Thuê phòng thành công");
                                Program.qlks.thuephongkm(namecustomer.Text.Trim(), cmnd.Text.Trim(), maphong, manv);
                                frm.Close();
                            }
                            else
                            {
                                MessageBox.Show("CMND sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            //sdt rong
                            MessageBox.Show("Hãy nhập CMND", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                //tennv rong
                MessageBox.Show("Hãy nhập tên khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
