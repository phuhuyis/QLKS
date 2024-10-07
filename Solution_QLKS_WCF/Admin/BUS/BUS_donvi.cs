using Admin.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.BUS
{
    public class BUS_donvi
    {
        private static BUS_donvi instance;
        public static BUS_donvi DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_donvi();
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
            column1.HeaderText = "Tên đơn vị";
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Số điện thoại";
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.HeaderText = "Địa chỉ";
            dgv.Columns.Add(columnstt);
            dgv.Columns.Add(column1);
            dgv.Columns.Add(column2);
            dgv.Columns.Add(column4);
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

        bool ktsdt(String sdt)
        {
            try
            {
                long sdtt = long.Parse(sdt);
                if (sdt.Length == 10)
                {
                    if (sdt.Substring(0, 1) == "0")
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
                    if (sdt.Length == 12)
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

        public void themdv(DataGridView dgv)
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
                        MessageBox.Show("cột tên đơn vị ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " có ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        if (tendv.Trim().Length > 100)
                        {
                            loi = true;
                            MessageBox.Show("cột tên đơn vị ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " quá 100 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                        {
                            String sdt = (String)dgv.Rows[i].Cells[2].Value;
                            if (sdt != null && sdt.Trim().Length > 0)
                            {
                                if (ktsdt(sdt.Trim()))
                                {
                                    String dc = (String)dgv.Rows[i].Cells[3].Value;
                                    if (dc != null && dc.Trim().Length > 0)
                                    {
                                        if (hasSpecialChar2(dc.Trim()))
                                        {
                                            loi = true;
                                            MessageBox.Show("địa chỉ ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " có ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            break;
                                        }
                                        else
                                        {

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
                }
                else
                {
                    loi = true;
                    MessageBox.Show("chưa nhập cột tên đơn vị cung cấp ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    DataColumn column4 = new DataColumn();
                    column4.ColumnName = "Địa chỉ";
                    table.Columns.Add(columnstt);
                    table.Columns.Add(column1);
                    table.Columns.Add(column4);
                    table.Columns.Add(column5);
                    for (int i = 0; i < dgv.Rows.Count - 1; i++)
                    {
                        DataRow row = table.NewRow();
                        row[0] = CapitalizeFirstLetter(dgv.Rows[i].Cells[0].Value.ToString().Trim());
                        row[1] = CapitalizeFirstLetter(dgv.Rows[i].Cells[1].Value.ToString().Trim());
                        row[3] = dgv.Rows[i].Cells[3].Value.ToString().Trim();
                        if (dgv.Rows[i].Cells[2].Value.ToString().Trim().Substring(0, 3) == "+84")
                            row[2] = "0" + dgv.Rows[i].Cells[2].Value.ToString().Trim().Substring(3);
                        else
                            row[2] = dgv.Rows[i].Cells[2].Value.ToString().Trim();
                        table.Rows.Add(row);
                    }
                    table.TableName = "donvi";
                    Program.qlks.themdonvi(table);
                    dgv.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Chưa nhập đơn vị cung cấp nào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dgv.DataSource = Program.qlks.tkdonvi(key);
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
            return Program.qlks.tkdonvi(key);
        }

        public void xoadv(String madv)
        {
            Program.qlks.xoadonvi(madv);
        }

        public void load(String madv, TextBox tennv, TextBox sdt, TextBox dc, frmsua_don_vi frm)
        {
            DataTable table = Program.qlks.load(madv);
            if(table.Rows.Count == 0)
            {
                frm.Close();
            }
            else
            {
                tennv.Text = table.Rows[0][1].ToString();
                sdt.Text = table.Rows[0][2].ToString();
                dc.Text = table.Rows[0][3].ToString();
            }
        }

        public void sua(String madv, TextBox tennv, TextBox sdt, TextBox dc, frmsua_don_vi frm)
        {
            bool loi = false;
            if(tennv.Text.Trim().Length > 0)
            {
                if(hasSpecialChar(tennv.Text.Trim()))
                {
                    //ten nv co ky tu dac biet
                    MessageBox.Show("Tên nhân viên có ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loi = true;
                }
                else
                {
                    if (tennv.Text.Trim().Length > 100)
                    {
                        //ten nv nhieu hon 100 ky tu
                        MessageBox.Show("Tên nhân viên nhiều hơn 100 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loi = true;
                    }
                    else
                    {
                        if (sdt.Text.Trim().Length > 0)
                        {
                            if (ktsdt(sdt.Text.Trim()))
                            {
                                if (dc.Text.Trim().Length > 0)
                                {
                                    if (hasSpecialChar2(dc.Text.Trim()))
                                    {
                                        //ky tu dac biet
                                        MessageBox.Show("Địa chỉ có ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        loi = true;
                                    }
                                    else
                                    {

                                    }
                                }
                                else
                                {
                                    //dc rong
                                    MessageBox.Show("Hãy nhập địa chỉ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    loi = true;
                                }
                            }
                            else
                            {
                                //sdt sai
                                MessageBox.Show("Số điện thoại sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                loi = true;
                            }
                        }
                        else
                        {
                            //sdt rong
                            MessageBox.Show("Hãy nhập số điện thoại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            loi = true;
                        }
                    }
                }
            }
            else
            {
                //tennv rong
                MessageBox.Show("Hãy nhập tên nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loi = true;
            }
            if(!loi)
            {
                MessageBox.Show("Đã lưu thành công", "Thông Báo");
                DataTable table = new DataTable();
                table.TableName = "suadonvi";
                DataColumn rowma = new DataColumn("1", typeof(String));
                DataColumn rowten = new DataColumn("2", typeof(String));
                DataColumn rowsdt = new DataColumn("3", typeof(String));
                DataColumn rowdc = new DataColumn("4", typeof(String));
                table.Columns.Add(rowma);
                table.Columns.Add(rowten);
                table.Columns.Add(rowsdt);
                table.Columns.Add(rowdc);
                DataRow row = table.NewRow();
                row[0] = madv;
                row[1] = CapitalizeFirstLetter(tennv.Text.Trim());
                row[2] = sdt.Text.Trim();
                row[3] = dc.Text.Trim();
                table.Rows.Add(row);
                Program.qlks.suadonvi(table);
                frm.Close();
            }
        }
    }
}
