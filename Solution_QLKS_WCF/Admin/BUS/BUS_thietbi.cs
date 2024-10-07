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
    public class BUS_thietbi
    {
        private static BUS_thietbi instance;
        public static BUS_thietbi DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_thietbi();
                }
                return instance;
            }
        }

        public void loadbangdv(DataGridView dgv, frmadd frm)
        {
            dgv.Columns.Clear();
            DataGridViewTextBoxColumn columnstt = new DataGridViewTextBoxColumn();
            columnstt.HeaderText = "STT";
            columnstt.ReadOnly = true;
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "Tên thiết bị";
            DataGridViewComboBoxColumn column2 = new DataGridViewComboBoxColumn();
            column2.HeaderText = "Đơn vị tính";
            column2.Items.Add("Cái");
            column2.Items.Add("Bộ");
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.HeaderText = "Giá";
            dgv.Columns.Add(columnstt);
            dgv.Columns.Add(column1);
            dgv.Columns.Add(column2);
            dgv.Columns.Add(column3);
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
                decimal sdtt = decimal.Parse(sdt);
                if(sdtt > 0)
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
                    if (tendv.Trim().Length > 100)
                    {
                        loi = true;
                        MessageBox.Show("cột tên thiết bị ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " quá 100 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        if(hasSpecialChar(tendv.Trim()))
                        {
                            loi = true;
                            MessageBox.Show("cột tên thiết bị ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " có ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }    
                        else
                        {
                            String sdt = (String)dgv.Rows[i].Cells[2].Value;
                            if (sdt != null && sdt.Trim().Length > 0)
                            {
                                String gia = (String)dgv.Rows[i].Cells[3].Value;
                                if (gia != null && gia.Trim().Length > 0)
                                {
                                    if (ktsdt(gia.Trim()))
                                    {

                                    }
                                    else
                                    {
                                        loi = true;
                                        MessageBox.Show("Giá sai ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            else
                            {
                                loi = true;
                                MessageBox.Show("chưa chọn đơn vị tính ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }   
                    }
                }
                else
                {
                    loi = true;
                    MessageBox.Show("chưa nhập cột tên thiết bị ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    DataColumn column6 = new DataColumn();
                    column6.ColumnName = "SĐT2";
                    table.Columns.Add(columnstt);
                    table.Columns.Add(column1);
                    table.Columns.Add(column5);
                    table.Columns.Add(column6);
                    for (int i = 0; i < dgv.Rows.Count - 1; i++)
                    {
                        DataRow row = table.NewRow();
                        row[0] = CapitalizeFirstLetter(dgv.Rows[i].Cells[0].Value.ToString().Trim());
                        row[1] = CapitalizeFirstLetter(dgv.Rows[i].Cells[1].Value.ToString().Trim());
                        row[2] = dgv.Rows[i].Cells[2].Value.ToString().Trim();
                        row[3] = dgv.Rows[i].Cells[3].Value.ToString().Trim();
                        table.Rows.Add(row);
                    }
                    table.TableName = "thietbi";
                    Program.qlks.themthietbi(table);
                    dgv.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Chưa nhập thiết bị nào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dgv.DataSource = Program.qlks.tkthietbi(key);
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
            dgv.Columns[2].DefaultCellStyle.Format = "C0";
            dgv.Columns[2].DefaultCellStyle.FormatProvider = cul;
            return Program.qlks.tkthietbi(key);
        }

        public void xoa(String ma)
        {
            Program.qlks.xoathietbi(ma);
        }

        public void load(String madv, TextBox tennv, NumericUpDown gia, ComboBox dvt, frm_sua_thietbi frm)
        {
            DataTable table = Program.qlks.loadthietbiql(madv);
            if (table.Rows.Count == 0)
            {
                frm.Close();
            }
            else
            {
                tennv.Text = table.Rows[0][0].ToString();
                dvt.Text = table.Rows[0][1].ToString();
                gia.Value = decimal.Parse(table.Rows[0][2].ToString());
            }
        }

        public void sua(String madv, TextBox tennv, NumericUpDown gia, ComboBox dvt, frm_sua_thietbi frm)
        {
            bool loi = false;
            if (tennv.Text.Trim().Length > 0)
            {
                if (tennv.Text.Trim().Length > 100)
                {
                    //ten nv nhieu hon 100 ky tu
                    MessageBox.Show("Tên thiết bị nhiều hơn 100 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loi = true;
                }
                else
                {
                    if(hasSpecialChar(tennv.Text.Trim()))
                    {
                        MessageBox.Show("Tên thiết bị có ký tự đặc biệt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loi = true;
                    }    
                    else
                    {
                        if (gia.Value > 0)
                        {

                        }
                        else
                        {
                            //sdt rong
                            MessageBox.Show("Nhập giá sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            loi = true;
                        }
                    }
                }
            }
            else
            {
                //tennv rong
                MessageBox.Show("Hãy nhập tên thiết bị", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loi = true;
            }
            if (!loi)
            {
                MessageBox.Show("Đã lưu thành công", "Thông Báo");
                DataTable table = new DataTable();
                table.TableName = "suathietbi";
                DataColumn rowma = new DataColumn("1", typeof(String));
                DataColumn rowten = new DataColumn("2", typeof(String));
                DataColumn rowsdt = new DataColumn("3", typeof(String));
                DataColumn rowsdtt = new DataColumn("4", typeof(String));
                table.Columns.Add(rowma);
                table.Columns.Add(rowten);
                table.Columns.Add(rowsdt);
                table.Columns.Add(rowsdtt);
                DataRow row = table.NewRow();
                row[0] = madv;
                row[1] = CapitalizeFirstLetter(tennv.Text.Trim());
                row[2] = dvt.Text;
                row[3] = gia.Value.ToString();
                table.Rows.Add(row);
                Program.qlks.suathietbi(table);
                frm.Close();
            }
        }
    }
}
