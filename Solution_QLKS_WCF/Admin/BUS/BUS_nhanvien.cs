using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.BUS
{
    public class BUS_nhanvien
    {
        private static BUS_nhanvien instance;
        public static BUS_nhanvien DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_nhanvien();
                }
                return instance;
            }
        }

        public void loadbangnv(DataGridView dgv)
        {
            dgv.Columns.Clear();
            DataGridViewTextBoxColumn columnstt = new DataGridViewTextBoxColumn();
            columnstt.HeaderText = "STT";
            columnstt.ReadOnly = true;
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "Tên nhân viên";
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Ngày sinh";
            DataGridViewComboBoxColumn column3 = new DataGridViewComboBoxColumn();
            column3.HeaderText = "Giới tính";
            column3.Items.Add("Nam");
            column3.Items.Add("Nữ");
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.HeaderText = "Địa chỉ";
            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.HeaderText = "SĐT";
            DataGridViewComboBoxColumn column6 = new DataGridViewComboBoxColumn();
            column6.HeaderText = "Ca";
            column6.Items.Add("Ca sáng");
            column6.Items.Add("Ca chiều");
            column6.Items.Add("Ca tối");
            DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
            column7.HeaderText = "Lương cơ bản";
            DataGridViewTextBoxColumn column8 = new DataGridViewTextBoxColumn();
            column8.HeaderText = "HSL";
            dgv.Columns.Add(columnstt);
            dgv.Columns.Add(column1);
            dgv.Columns.Add(column2);
            dgv.Columns.Add(column3);
            dgv.Columns.Add(column4);
            dgv.Columns.Add(column5);
            dgv.Columns.Add(column6);
            dgv.Columns.Add(column7);
            dgv.Columns.Add(column8);
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
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

        public static bool hasSpecialChar2(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }

        public static bool space(string input)
        {
            string specialChar = " ";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }

        bool ktns(String ns)
        {
            try
            {
                String d = ns;
                //convert sang dung dinh dang
                if(ns.Contains(@"\"))
                {
                    int ngay = int.Parse(d.Substring(0, d.IndexOf(@"\")));
                    d = d.Substring(d.IndexOf(@"\") + 1);
                    if(d.Contains(@"\"))
                    {
                        int thang = int.Parse(d.Substring(0, d.IndexOf(@"\")));
                        d = d.Substring(d.IndexOf(@"\") + 1);
                        int nam = int.Parse(d.Substring(0));
                        if (ngay < 100 && thang < 100 && nam < 10000)
                        {
                            if (ngay > 0 && thang > 0 && nam > 1000)
                            {
                                String ngayghep = thang.ToString() + @"/" + ngay.ToString() + @"/" + nam.ToString();
                                DateTime date = DateTime.Parse(ngayghep);
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
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if(ns.Contains(@"/"))
                    {
                        int ngay = int.Parse(d.Substring(0, d.IndexOf(@"/")));
                        d = d.Substring(d.IndexOf(@"/") + 1);
                        if (d.Contains(@"/"))
                        {
                            int thang = int.Parse(d.Substring(0, d.IndexOf(@"/")));
                            d = d.Substring(d.IndexOf(@"/") + 1);
                            int nam = int.Parse(d.Substring(0));
                            if (ngay < 100 && thang < 100 && nam < 10000)
                            {
                                if (ngay > 0 && thang > 0 && nam > 1000)
                                {
                                    String ngayghep = thang.ToString() + @"/" + ngay.ToString() + @"/" + nam.ToString();
                                    DateTime date = DateTime.Parse(ngayghep);
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
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if(ns.Contains("."))
                        {
                            int ngay = int.Parse(d.Substring(0, d.IndexOf(@".")));
                            d = d.Substring(d.IndexOf(@".") + 1);
                            if (d.Contains(@"."))
                            {
                                int thang = int.Parse(d.Substring(0, d.IndexOf(@".")));
                                d = d.Substring(d.IndexOf(@".") + 1);
                                int nam = int.Parse(d.Substring(0));
                                if (ngay < 100 && thang < 100 && nam < 10000)
                                {
                                    if (ngay > 0 && thang > 0 && nam > 1000)
                                    {
                                        String ngayghep = thang.ToString() + @"/" + ngay.ToString() + @"/" + nam.ToString();
                                        DateTime date = DateTime.Parse(ngayghep);
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
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if(ns.Contains("-"))
                            {
                                int ngay = int.Parse(d.Substring(0, d.IndexOf(@"-")));
                                d = d.Substring(d.IndexOf(@"-") + 1);
                                if (d.Contains(@"-"))
                                {
                                    int thang = int.Parse(d.Substring(0, d.IndexOf(@"-")));
                                    d = d.Substring(d.IndexOf(@"-") + 1);
                                    int nam = int.Parse(d.Substring(0));
                                    if (ngay < 100 && thang < 100 && nam < 10000)
                                    {
                                        if (ngay > 0 && thang > 0 && nam > 1000)
                                        {
                                            String ngayghep = thang.ToString() + @"/" + ngay.ToString() + @"/" + nam.ToString();
                                            DateTime date = DateTime.Parse(ngayghep);
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
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool ktns2(String ns)
        {
            try
            {
                String d = ns;
                //convert sang dung dinh dang
                if (ns.Contains(@"\"))
                {
                    int ngay = int.Parse(d.Substring(0, d.IndexOf(@"\")));
                    d = d.Substring(d.IndexOf(@"\") + 1);
                    if (d.Contains(@"\"))
                    {
                        int thang = int.Parse(d.Substring(0, d.IndexOf(@"\")));
                        d = d.Substring(d.IndexOf(@"\") + 1);
                        int nam = int.Parse(d.Substring(0));
                        if (ngay < 100 && thang < 100 && nam < 10000)
                        {
                            if (ngay > 0 && thang > 0 && nam > 1000)
                            {
                                String ngayghep = thang.ToString() + @"/" + ngay.ToString() + @"/" + nam.ToString();
                                DateTime date = DateTime.Parse(ngayghep);
                                if (date.Year < DateTime.Now.Year)
                                {
                                    return true;
                                }
                                else
                                {
                                    if (date.Year == DateTime.Now.Year)
                                    {
                                        if (date.Month < DateTime.Now.Month)
                                        {
                                            return true;
                                        }
                                        else
                                        {
                                            if (date.Month == DateTime.Now.Month)
                                            {
                                                return false;
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
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (ns.Contains(@"/"))
                    {
                        int ngay = int.Parse(d.Substring(0, d.IndexOf(@"/")));
                        d = d.Substring(d.IndexOf(@"/") + 1);
                        if (d.Contains(@"/"))
                        {
                            int thang = int.Parse(d.Substring(0, d.IndexOf(@"/")));
                            d = d.Substring(d.IndexOf(@"/") + 1);
                            int nam = int.Parse(d.Substring(0));
                            if (ngay < 100 && thang < 100 && nam < 10000)
                            {
                                if (ngay > 0 && thang > 0 && nam > 1000)
                                {
                                    String ngayghep = thang.ToString() + @"/" + ngay.ToString() + @"/" + nam.ToString();
                                    DateTime date = DateTime.Parse(ngayghep);
                                    if (date.Year < DateTime.Now.Year)
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        if (date.Year == DateTime.Now.Year)
                                        {
                                            if (date.Month < DateTime.Now.Month)
                                            {
                                                return true;
                                            }
                                            else
                                            {
                                                if (date.Month == DateTime.Now.Month)
                                                {
                                                    return false;
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
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (ns.Contains("."))
                        {
                            int ngay = int.Parse(d.Substring(0, d.IndexOf(@".")));
                            d = d.Substring(d.IndexOf(@".") + 1);
                            if (d.Contains(@"."))
                            {
                                int thang = int.Parse(d.Substring(0, d.IndexOf(@".")));
                                d = d.Substring(d.IndexOf(@".") + 1);
                                int nam = int.Parse(d.Substring(0));
                                if (ngay < 100 && thang < 100 && nam < 10000)
                                {
                                    if (ngay > 0 && thang > 0 && nam > 1000)
                                    {
                                        String ngayghep = thang.ToString() + @"/" + ngay.ToString() + @"/" + nam.ToString();
                                        DateTime date = DateTime.Parse(ngayghep);
                                        if (date.Year < DateTime.Now.Year)
                                        {
                                            return true;
                                        }
                                        else
                                        {
                                            if (date.Year == DateTime.Now.Year)
                                            {
                                                if (date.Month < DateTime.Now.Month)
                                                {
                                                    return true;
                                                }
                                                else
                                                {
                                                    if (date.Month == DateTime.Now.Month)
                                                    {
                                                        return false;
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
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (ns.Contains("-"))
                            {
                                int ngay = int.Parse(d.Substring(0, d.IndexOf(@"-")));
                                d = d.Substring(d.IndexOf(@"-") + 1);
                                if (d.Contains(@"-"))
                                {
                                    int thang = int.Parse(d.Substring(0, d.IndexOf(@"-")));
                                    d = d.Substring(d.IndexOf(@"-") + 1);
                                    int nam = int.Parse(d.Substring(0));
                                    if (ngay < 100 && thang < 100 && nam < 10000)
                                    {
                                        if (ngay > 0 && thang > 0 && nam > 1000)
                                        {
                                            String ngayghep = thang.ToString() + @"/" + ngay.ToString() + @"/" + nam.ToString();
                                            DateTime date = DateTime.Parse(ngayghep);
                                            if (date.Year < DateTime.Now.Year)
                                            {
                                                return true;
                                            }
                                            else
                                            {
                                                if (date.Year == DateTime.Now.Year)
                                                {
                                                    if (date.Month < DateTime.Now.Month)
                                                    {
                                                        return true;
                                                    }
                                                    else
                                                    {
                                                        if (date.Month == DateTime.Now.Month)
                                                        {
                                                            return false;
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
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool ktsdt(String sdt)
        {
            try
            {
                long sdtt = long.Parse(sdt);
                if (sdt.Length == 10)
                {
                    if(sdt.Substring(0, 1) == "0")
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
                    if(sdt.Length == 12)
                    {
                        if (sdt.Substring(0, 3) == "+84")
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
            catch (Exception)
            {
                return false;
            }
        }

        bool ktlcb(String lcb)
        {
            try
            {
                long l = long.Parse(lcb);
                if (l > 0)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool kthsl(String lcb)
        {
            try
            {
                double l = double.Parse(lcb);
                if(l >= 1)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void themnv(DataGridView dgv, String tendangnhap)
        {
            bool loi = false;
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                String tennv = (String)dgv.Rows[i].Cells[1].Value;
                if (tennv != null && tennv.Trim().Length > 0)
                {
                    if(hasSpecialChar(tennv.Trim()))
                    {
                        loi = true;
                        MessageBox.Show("cột tên nhân viên ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " có ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }   
                    else
                    {
                        if(tennv.Trim().Length > 100)
                        {
                            loi = true;
                            MessageBox.Show("cột tên nhân viên ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " quá 100 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }   
                        else
                        {
                            String ns = (String)dgv.Rows[i].Cells[2].Value;
                            if (ns != null && ns.Trim().Length > 0)
                            {
                                if (ktns(((String)dgv.Rows[i].Cells[2].Value).Trim()))
                                {
                                    if(ktns2(((String)dgv.Rows[i].Cells[2].Value).Trim()))
                                    {
                                        String gt = (String)dgv.Rows[i].Cells[3].Value;
                                        if (gt != null && gt.Trim().Length > 0)
                                        {
                                            String dc = (String)dgv.Rows[i].Cells[4].Value;
                                            if (dc != null && dc.Trim().Length > 0)
                                            {
                                                if(hasSpecialChar2(dc.Trim()))
                                                {
                                                    loi = true;
                                                    MessageBox.Show("địa chỉ ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " có ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    break;
                                                }
                                                else
                                                {
                                                    String sdt = (String)dgv.Rows[i].Cells[5].Value;
                                                    if (sdt != null && sdt.Trim().Length > 0)
                                                    {
                                                        if (ktsdt(sdt.Trim()))
                                                        {
                                                            String ca = (String)dgv.Rows[i].Cells[6].Value;
                                                            if (ca != null && ca.Trim().Length > 0)
                                                            {
                                                                String lcb = (String)dgv.Rows[i].Cells[7].Value;
                                                                if (lcb != null && lcb.Trim().Length > 0)
                                                                {
                                                                    if (ktlcb(lcb.Trim()))
                                                                    {
                                                                        String hsl = (String)dgv.Rows[i].Cells[8].Value;
                                                                        if (hsl != null && hsl.Trim().Length > 0)
                                                                        {
                                                                            if (kthsl(hsl.Trim()))
                                                                            {

                                                                            }
                                                                            else
                                                                            {
                                                                                loi = true;
                                                                                MessageBox.Show("sai hệ số lương ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                break;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            loi = true;
                                                                            MessageBox.Show("chưa nhập hệ số lương ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                            break;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        loi = true;
                                                                        MessageBox.Show("sai lương cơ bản ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                        break;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    loi = true;
                                                                    MessageBox.Show("chưa nhập lương cơ bản ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    break;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                loi = true;
                                                                MessageBox.Show("chưa chọn ca làm việc ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            loi = true;
                                                            MessageBox.Show("sai số điện thoại ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            break;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        loi = true;
                                                        MessageBox.Show("chưa nhập số điện thoại ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        break;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                loi = true;
                                                MessageBox.Show("chưa nhập địa chỉ ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            loi = true;
                                            MessageBox.Show("chưa chọn giới tính ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        loi = true;
                                        MessageBox.Show("Ngày sinh ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " phải nhỏ hơn ngày hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                    }
                                }
                                else
                                {
                                    loi = true;
                                    MessageBox.Show("Sai định dạng cột ngày sinh ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            }
                            else
                            {
                                loi = true;
                                MessageBox.Show("chưa nhập cột ngày sinh ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }    
                    }    
                }
                else
                {
                    loi = true;
                    MessageBox.Show("chưa nhập cột tên nhân viên ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            if (!loi)
            {
                if (dgv.Rows.Count > 1)
                {
                    MessageBox.Show("Đã lưu thành công", "Thông Báo");
                    DataTable table = new DataTable();
                    DataColumn columnstt = new DataColumn();
                    columnstt.ColumnName = "STT";
                    columnstt.DataType = typeof(String);
                    DataColumn column1 = new DataColumn();
                    column1.ColumnName = "Tên nhân viên";
                    columnstt.DataType = typeof(String);
                    DataColumn column2 = new DataColumn();
                    column2.ColumnName = "Ngày sinh";
                    columnstt.DataType = typeof(DateTime);
                    DataColumn column3 = new DataColumn();
                    column3.ColumnName = "Giới tính";
                    columnstt.DataType = typeof(String);
                    DataColumn column4 = new DataColumn();
                    column4.ColumnName = "Địa chỉ";
                    columnstt.DataType = typeof(String);
                    DataColumn column5 = new DataColumn();
                    column5.ColumnName = "SĐT";
                    columnstt.DataType = typeof(String);
                    DataColumn column6 = new DataColumn();
                    column6.ColumnName = "Ca";
                    columnstt.DataType = typeof(String);
                    DataColumn column7 = new DataColumn();
                    column7.ColumnName = "Lương cơ bản";
                    columnstt.DataType = typeof(String);
                    DataColumn column8 = new DataColumn();
                    column8.ColumnName = "HSL";
                    columnstt.DataType = typeof(String);
                    table.Columns.Add(columnstt);
                    table.Columns.Add(column1);
                    table.Columns.Add(column2);
                    table.Columns.Add(column3);
                    table.Columns.Add(column4);
                    table.Columns.Add(column5);
                    table.Columns.Add(column6);
                    table.Columns.Add(column7);
                    table.Columns.Add(column8);
                    for (int i = 0; i < dgv.Rows.Count - 1; i++)
                    {
                        DataRow row = table.NewRow();
                        row[0] = CapitalizeFirstLetter(dgv.Rows[i].Cells[0].Value.ToString().Trim());
                        row[1] = CapitalizeFirstLetter(dgv.Rows[i].Cells[1].Value.ToString().Trim());
                        row[2] = DateTime.Parse(convert(dgv.Rows[i].Cells[2].Value.ToString()).Trim());
                        row[3] = dgv.Rows[i].Cells[3].Value.ToString().Trim();
                        row[4] = dgv.Rows[i].Cells[4].Value.ToString().Trim();
                        if (dgv.Rows[i].Cells[5].Value.ToString().Trim().Substring(0, 3) == "+84")
                            row[5] = "0" + dgv.Rows[i].Cells[5].Value.ToString().Trim().Substring(3);
                        else
                            row[5] = dgv.Rows[i].Cells[5].Value.ToString().Trim();
                        if (dgv.Rows[i].Cells[6].Value.ToString() == "Ca sáng")
                        {
                            row[6] = "1";
                        }
                        else
                        {
                            if (dgv.Rows[i].Cells[6].Value.ToString() == "Ca chiều")
                            {
                                row[6] = "2";
                            }
                            else
                            {
                                row[6] = "3";
                            }
                        }
                        row[7] = dgv.Rows[i].Cells[7].Value.ToString().Trim();
                        row[8] = dgv.Rows[i].Cells[8].Value.ToString().Trim();
                        table.Rows.Add(row);
                    }
                    table.TableName = "nv";
                    Program.qlks.themnv(table, tendangnhap);
                    dgv.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Chưa nhập nhân viên nào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private String convert(String ns)
        {
            String e = "";
            String d = ns;
            if (ns.Contains(@"\"))
            {
                int ngay = int.Parse(d.Substring(0, d.IndexOf(@"\")));
                d = d.Substring(d.IndexOf(@"\") + 1);
                if (d.Contains(@"\"))
                {
                    int thang = int.Parse(d.Substring(0, d.IndexOf(@"\")));
                    d = d.Substring(d.IndexOf(@"\") + 1);
                    int nam = int.Parse(d.Substring(0));
                    if (ngay < 100 && thang < 100 && nam < 10000)
                    {
                        if (ngay > 0 && thang > 0 && nam > 1000)
                        {
                            e = thang.ToString() + @"/" + ngay.ToString() + @"/" + nam.ToString();
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    
                }
            }
            else
            {
                if (ns.Contains(@"/"))
                {
                    int ngay = int.Parse(d.Substring(0, d.IndexOf(@"/")));
                    d = d.Substring(d.IndexOf(@"/") + 1);
                    if (d.Contains(@"/"))
                    {
                        int thang = int.Parse(d.Substring(0, d.IndexOf(@"/")));
                        d = d.Substring(d.IndexOf(@"/") + 1);
                        int nam = int.Parse(d.Substring(0));
                        if (ngay < 100 && thang < 100 && nam < 10000)
                        {
                            if (ngay > 0 && thang > 0 && nam > 1000)
                            {
                                e = thang.ToString() + @"/" + ngay.ToString() + @"/" + nam.ToString();

                            }
                            else
                            {

                            }
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    if (ns.Contains("."))
                    {
                        int ngay = int.Parse(d.Substring(0, d.IndexOf(@".")));
                        d = d.Substring(d.IndexOf(@".") + 1);
                        if (d.Contains(@"."))
                        {
                            int thang = int.Parse(d.Substring(0, d.IndexOf(@".")));
                            d = d.Substring(d.IndexOf(@".") + 1);
                            int nam = int.Parse(d.Substring(0));
                            if (ngay < 100 && thang < 100 && nam < 10000)
                            {
                                if (ngay > 0 && thang > 0 && nam > 1000)
                                {
                                    e = thang.ToString() + @"/" + ngay.ToString() + @"/" + nam.ToString();

                                }
                                else
                                {

                                }
                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            
                        }
                    }
                    else
                    {
                        if (ns.Contains("-"))
                        {
                            int ngay = int.Parse(d.Substring(0, d.IndexOf(@"-")));
                            d = d.Substring(d.IndexOf(@"-") + 1);
                            if (d.Contains(@"-"))
                            {
                                int thang = int.Parse(d.Substring(0, d.IndexOf(@"-")));
                                d = d.Substring(d.IndexOf(@"-") + 1);
                                int nam = int.Parse(d.Substring(0));
                                if (ngay < 100 && thang < 100 && nam < 10000)
                                {
                                    if (ngay > 0 && thang > 0 && nam > 1000)
                                    {
                                        e = thang.ToString() + @"/" + ngay.ToString() + @"/" + nam.ToString();

                                    }
                                    else
                                    {

                                    }
                                }
                                else
                                {

                                }
                            }
                            else
                            {
                                
                            }
                        }
                        else
                        {
                            
                        }
                    }
                }
            }
            return e;
        }

        public void search(String key, DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.DataSource = Program.qlks.searchnv(key);
            DataGridViewButtonColumn colums1 = new DataGridViewButtonColumn();
            dgv.Columns.Add(colums1);
            DataGridViewButtonColumn colums2 = new DataGridViewButtonColumn();
            dgv.Columns.Add(colums2);
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[dgv.ColumnCount - 2].Value = "Sửa";
                dgv.Rows[i].Cells[dgv.ColumnCount - 1].Value = "Xóa";
            }
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            dgv.Columns[7].DefaultCellStyle.FormatProvider = cul;
            dgv.Columns[7].DefaultCellStyle.Format = "C0";
            dgv.Columns[2].DefaultCellStyle.FormatProvider = cul;
            dgv.Columns[2].DefaultCellStyle.Format = "d";
        }

        public void xoanv(String manv)
        {
            Program.qlks.xoanv(manv);
        }

        public void laydl(String manv, TextBox txtmanv, TextBox tennv, DateTimePicker ngaysinh, ComboBox gt, TextBox diachi, TextBox sdt, ComboBox ca, ComboBox tt, TextBox lcb, TextBox hsl)
        {
            DataTable table = Program.qlks.laydlnv(manv);
            txtmanv.Text = manv;
            tennv.Text = table.Rows[0][0].ToString();
            ngaysinh.Value = DateTime.Parse(table.Rows[0][1].ToString());
            gt.Text = table.Rows[0][2].ToString();
            diachi.Text = table.Rows[0][3].ToString();
            sdt.Text = table.Rows[0][4].ToString();
            ca.Text = table.Rows[0][5].ToString();
            lcb.Text = table.Rows[0][6].ToString();
            hsl.Text = table.Rows[0][7].ToString();
            tt.Text = table.Rows[0][8].ToString();
        }

        bool ktns3(DateTime ns)
        {
            if(ns.Year < DateTime.Now.Year)
            {
                return true;
            }
            else
            {
                if(ns.Year == DateTime.Now.Year)
                {
                    if (ns.Month < DateTime.Now.Month)
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

        public void capnhap(Form frm,TextBox txtmanv, TextBox tennv, DateTimePicker ngaysinh, ComboBox gt, TextBox diachi, TextBox sdt, ComboBox ca, ComboBox tt, TextBox lcb, TextBox hsl)
        {
            bool loi = false;
            if (tennv.Text.Trim().Length > 0)
            {
                if (hasSpecialChar(tennv.Text.Trim()))
                {
                    loi = true;
                    MessageBox.Show("Tên nhân viên có ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (tennv.Text.Trim().Length > 100)
                    {
                        loi = true;
                        MessageBox.Show("Tên nhân viên quá 100 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(ktns3(ngaysinh.Value))
                        {
                            if (diachi.Text.Trim().Length > 0)
                            {
                                if (hasSpecialChar2(diachi.Text.Trim()))
                                {
                                    loi = true;
                                    MessageBox.Show("địa chỉ có ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    if (sdt.Text.Trim().Length > 0)
                                    {
                                        if (ktsdt(sdt.Text.Trim()))
                                        {
                                            if (ca.Text.Trim().Length > 0)
                                            {
                                                if (lcb.Text.Trim().Length > 0)
                                                {
                                                    if (ktlcb(lcb.Text.Trim()))
                                                    {
                                                        if (hsl.Text.Trim().Length > 0)
                                                        {
                                                            if (kthsl(hsl.Text.Trim()))
                                                            {

                                                            }
                                                            else
                                                            {
                                                                loi = true;
                                                                MessageBox.Show("sai hệ số lương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            loi = true;
                                                            MessageBox.Show("chưa nhập hệ số lương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        loi = true;
                                                        MessageBox.Show("sai lương cơ bản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                }
                                                else
                                                {
                                                    loi = true;
                                                    MessageBox.Show("chưa nhập lương cơ bản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                            }
                                            else
                                            {
                                                loi = true;
                                                MessageBox.Show("chưa chọn ca làm việc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            loi = true;
                                            MessageBox.Show("sai số điện thoại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        loi = true;
                                        MessageBox.Show("chưa nhập số điện thoại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                loi = true;
                                MessageBox.Show("chưa nhập địa chỉ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            loi = true;
                            MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                }
            }
            else
            {
                loi = true;
                MessageBox.Show("Hãy nhập tên nhân viên ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(!loi)
            {
                MessageBox.Show("Đã lưu thành công", "Thông Báo");
                DataTable table = new DataTable();
                DataColumn columnstt = new DataColumn();
                columnstt.ColumnName = "STT";
                columnstt.DataType = typeof(String);
                DataColumn column1 = new DataColumn();
                column1.ColumnName = "Tên nhân viên";
                column1.DataType = typeof(String);
                DataColumn column2 = new DataColumn();
                column2.ColumnName = "Ngày sinh";
                column2.DataType = typeof(DateTime);
                DataColumn column3 = new DataColumn();
                column3.ColumnName = "Giới tính";
                column3.DataType = typeof(String);
                DataColumn column4 = new DataColumn();
                column4.ColumnName = "Địa chỉ";
                column4.DataType = typeof(String);
                DataColumn column5 = new DataColumn();
                column5.ColumnName = "SĐT";
                column5.DataType = typeof(String);
                DataColumn column6 = new DataColumn();
                column6.ColumnName = "Ca";
                column6.DataType = typeof(String);
                DataColumn column9 = new DataColumn();
                column9.ColumnName = "Tình trạng";
                column9.DataType = typeof(String);
                DataColumn column7 = new DataColumn();
                column7.ColumnName = "Lương cơ bản";
                column7.DataType = typeof(String);
                DataColumn column8 = new DataColumn();
                column8.ColumnName = "HSL";
                column8.DataType = typeof(String);
                table.Columns.Add(columnstt);
                table.Columns.Add(column1);
                table.Columns.Add(column2);
                table.Columns.Add(column3);
                table.Columns.Add(column4);
                table.Columns.Add(column5);
                table.Columns.Add(column6);
                table.Columns.Add(column9);
                table.Columns.Add(column7);
                table.Columns.Add(column8);
                DataRow row = table.NewRow();
                row[0] = CapitalizeFirstLetter(txtmanv.Text.Trim());
                row[1] = CapitalizeFirstLetter(tennv.Text.Trim());
                row[2] = DateTime.Parse(ngaysinh.Value.ToShortDateString().Trim());
                row[3] = gt.Text.ToString().Trim();
                row[4] = diachi.Text.ToString().Trim();
                row[5] = sdt.Text.ToString().Trim();
                if (ca.Text.ToString() == "Ca sáng")
                {
                    row[6] = "1";
                }
                else
                {
                    if (ca.Text.ToString() == "Ca chiều")
                    {
                        row[6] = "2";
                    }
                    else
                    {
                        row[6] = "3";
                    }
                }
                if (tt.Text.ToString() == "Còn làm")
                {
                    row[7] = "0";
                }
                else
                {
                    row[7] = "1";
                }
                row[8] = lcb.Text.ToString().Trim();
                row[9] = hsl.Text.ToString().Trim();
                table.Rows.Add(row);
                table.TableName = "capnhapnv";
                Program.qlks.capnhapnv(table);
                frm.Close();
            }    
        }
    }
}
