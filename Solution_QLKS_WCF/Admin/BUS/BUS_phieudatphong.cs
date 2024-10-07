using Admin.GUI;
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
    public class BUS_phieudatphong
    {
        private static BUS_phieudatphong instance;
        public static BUS_phieudatphong DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_phieudatphong();
                }
                return instance;
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
                decimal sdtt = decimal.Parse(sdt);
                if (sdtt > 0)
                {
                    return true;
                }
                else
                {
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

        public DataTable search(String key, DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.DataSource = Program.qlks.tkphieudatphong(key);
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
                dgv.Rows[i].Cells[dgv.ColumnCount - 1].Value = "Hủy";
            }
            //dgv.Columns.RemoveAt(0);
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            dgv.Columns[2].DefaultCellStyle.Format = "d";
            dgv.Columns[2].DefaultCellStyle.FormatProvider = cul;
            return Program.qlks.tkphieudatphong(key);
        }

        public DataTable searchnv(String key, DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.DataSource = Program.qlks.tkphieudatphong(key);
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //dgv.Columns.RemoveAt(0);
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            dgv.Columns[2].DefaultCellStyle.Format = "d";
            dgv.Columns[2].DefaultCellStyle.FormatProvider = cul;
            return Program.qlks.tkphieudatphong(key);
        }

        public void xoa(String ma)
        {
            Program.qlks.xoaphieudatphong(ma);
        }

        public void load(String so, TextBox sophieu, TextBox khachhang, DateTimePicker ngayden, TextBox phong, frm_sua_phieu_dat_phong frm)
        {
            DataTable table = Program.qlks.loadphieudatphong(so);
            if (table.Rows.Count == 0)
            {
                frm.Close();
            }
            else
            {
                sophieu.Text = table.Rows[0][0].ToString();
                khachhang.Text = table.Rows[0][1].ToString();
                ngayden.Value = DateTime.Parse(table.Rows[0][2].ToString());
                phong.Text = table.Rows[0][3].ToString();
            }
        }

        public void sua(String so, DateTimePicker ngayden, frm_sua_phieu_dat_phong frm)
        {
            if (ktngayden(ngayden.Value))
            {
                MessageBox.Show("Đã lưu thành công", "Thông Báo");
                DataTable table = new DataTable();
                table.TableName = "suaphieudatphong";
                DataColumn rowma = new DataColumn("1", typeof(String));
                DataColumn rowngay = new DataColumn("2", typeof(DateTime));
                table.Columns.Add(rowma);
                table.Columns.Add(rowngay);
                DataRow row = table.NewRow();
                row[0] = so;
                row[1] = ngayden.Value;
                table.Rows.Add(row);
                Program.qlks.suaphieudatphong(table);
                frm.Close();
            }
            else
            {
                MessageBox.Show("Ngày đến phải lớn hơn ngày hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ktngayden(DateTime date)
        {
            if (date.Year > DateTime.Now.Year)
            {
                return true;
            }
            else
            {
                if (date.Year == DateTime.Now.Year)
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
    }
}
