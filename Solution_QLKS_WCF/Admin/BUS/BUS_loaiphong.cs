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
    public class BUS_loaiphong
    {
        private static BUS_loaiphong instance;
        public static BUS_loaiphong DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_loaiphong();
                }
                return instance;
            }
        }

        public void loadbangdv(DataGridView dgv)
        {
            dgv.Columns.Clear();
            DataGridViewTextBoxColumn columnstt = new DataGridViewTextBoxColumn();
            columnstt.HeaderText = "STT";
            columnstt.ReadOnly = true;
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "Tên loại phòng";
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Giá";
            dgv.Columns.Add(columnstt);
            dgv.Columns.Add(column1);
            dgv.Columns.Add(column2);
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

        bool ktsdt(String sdt)
        {
            try
            {
                long sdtt = long.Parse(sdt);
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

        public void them(DataGridView dgv)
        {
            bool loi = false;
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                String tendv = (String)dgv.Rows[i].Cells[1].Value;
                if (tendv != null && tendv.Trim().Length > 0)
                {
                    if (hasSpecialChar(tendv.Trim()))
                    {
                        loi = true;
                        MessageBox.Show("cột tên loại phòng ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " có ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        if (tendv.Trim().Length > 100)
                        {
                            loi = true;
                            MessageBox.Show("cột tên loại phòng ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " quá 100 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                        {
                            String sdt = (String)dgv.Rows[i].Cells[2].Value;
                            if (sdt != null && sdt.Trim().Length > 0)
                            {
                                if (ktsdt(sdt.Trim()))
                                {

                                }
                                else
                                {
                                    loi = true;
                                    MessageBox.Show("sai giá ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            }
                            else
                            {
                                loi = true;
                                MessageBox.Show("chưa nhập giá ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                }
                else
                {
                    loi = true;
                    MessageBox.Show("chưa nhập cột tên loại phòng ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    DataColumn column1 = new DataColumn();
                    column1.ColumnName = "Tên đơn vị";
                    DataColumn column5 = new DataColumn();
                    column5.ColumnName = "SĐT";
                    table.Columns.Add(columnstt);
                    table.Columns.Add(column1);
                    table.Columns.Add(column5);
                    for (int i = 0; i < dgv.Rows.Count - 1; i++)
                    {
                        DataRow row = table.NewRow();
                        row[0] = CapitalizeFirstLetter(dgv.Rows[i].Cells[0].Value.ToString().Trim());
                        row[1] = CapitalizeFirstLetter(dgv.Rows[i].Cells[1].Value.ToString().Trim());
                        row[2] = dgv.Rows[i].Cells[2].Value.ToString().Trim();
                        table.Rows.Add(row);
                    }
                    table.TableName = "donvi";
                    Program.qlks.themloaiphong(table);
                    dgv.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Chưa nhập loại phòng nào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public DataTable search(String key, DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.DataSource = Program.qlks.tkloaiphong(key);
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
            dgv.Columns.RemoveAt(0);
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            dgv.Columns[1].DefaultCellStyle.FormatProvider = cul;
            dgv.Columns[1].DefaultCellStyle.Format = "C0";
            return Program.qlks.tkloaiphong(key);
        }

        public DataTable searchnv(String key, DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.DataSource = Program.qlks.tkloaiphong(key);
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgv.Columns.RemoveAt(0);
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            dgv.Columns[1].DefaultCellStyle.FormatProvider = cul;
            dgv.Columns[1].DefaultCellStyle.Format = "C0";
            return Program.qlks.tkloaiphong(key);
        }

        public void xoa(String ma)
        {
            Program.qlks.xoaloaiphong(ma);
        }

        public void load(String madv, TextBox tennv, NumericUpDown sdt, frmsua_loai_phong frm)
        {
            DataTable table = Program.qlks.loadloaiphong2(madv);
            if (table.Rows.Count == 0)
            {
                frm.Close();
            }
            else
            {
                tennv.Text = table.Rows[0][1].ToString();
                sdt.Value = long.Parse(table.Rows[0][2].ToString());
            }
        }

        public void sua(String madv, TextBox tennv, NumericUpDown sdt, frmsua_loai_phong frm)
        {
            bool loi = false;
            if (tennv.Text.Trim().Length > 0)
            {
                if (hasSpecialChar(tennv.Text.Trim()))
                {
                    //ten nv co ky tu dac biet
                    MessageBox.Show("Tên loại phòng có ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loi = true;
                }
                else
                {
                    if (tennv.Text.Trim().Length > 100)
                    {
                        //ten nv nhieu hon 100 ky tu
                        MessageBox.Show("Tên loại phòng nhiều hơn 100 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loi = true;
                    }
                    else
                    {
                        if (sdt.Text.Trim().Length > 0)
                        {
                            if (ktsdt(sdt.Text.Trim()))
                            {

                            }
                            else
                            {
                                //sdt sai
                                MessageBox.Show("Giá sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                loi = true;
                            }
                        }
                        else
                        {
                            //sdt rong
                            MessageBox.Show("Hãy nhập giá", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            loi = true;
                        }
                    }
                }
            }
            else
            {
                //tennv rong
                MessageBox.Show("Hãy nhập tên loại phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loi = true;
            }
            if (!loi)
            {
                MessageBox.Show("Đã lưu thành công", "Thông Báo");
                DataTable table = new DataTable();
                table.TableName = "sualoaiphong";
                DataColumn rowma = new DataColumn("1", typeof(String));
                DataColumn rowten = new DataColumn("2", typeof(String));
                DataColumn rowsdt = new DataColumn("3", typeof(String));
                table.Columns.Add(rowma);
                table.Columns.Add(rowten);
                table.Columns.Add(rowsdt);
                DataRow row = table.NewRow();
                row[0] = madv;
                row[1] = CapitalizeFirstLetter(tennv.Text.Trim());
                row[2] = sdt.Text.Trim();
                table.Rows.Add(row);
                Program.qlks.sualoaiphong(table);
                frm.Close();
            }
        }
    }
}
