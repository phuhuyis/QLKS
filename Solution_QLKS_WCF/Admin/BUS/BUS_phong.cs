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
    public class BUS_phong
    {
        //DataTable Table;
        private static BUS_phong instance;
        public static BUS_phong DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_phong();
                }
                return instance;
            }
        }

        public bool ktlp()
        {
            DataTable table = Program.qlks.tkloaiphong("");
            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }    
        }

        public void loadbangdv(DataGridView dgv, frmadd frm)
        {
            dgv.Columns.Clear();
            DataTable table = Program.qlks.tkloaiphong("");
            if (table.Rows.Count == 0)
            {
                frm.Close();
            }
            else
            {
                DataGridViewTextBoxColumn columnstt = new DataGridViewTextBoxColumn();
                columnstt.HeaderText = "STT";
                columnstt.ReadOnly = true;
                DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                column1.HeaderText = "Tên phòng";
                DataGridViewComboBoxColumn column2 = new DataGridViewComboBoxColumn();
                column2.HeaderText = "Loại";
                column2.DataSource = table;
                column2.DisplayMember = "Tên loại";
                column2.ValueMember = "Mã loại";
                dgv.Columns.Add(columnstt);
                dgv.Columns.Add(column1);
                dgv.Columns.Add(column2);
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }    
        }

        public DataTable searchnv(String key, DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.DataSource = Program.qlks.tkphong(key);
            DataGridViewButtonColumn colums3 = new DataGridViewButtonColumn();
            dgv.Columns.Add(colums3);
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[dgv.ColumnCount - 1].Value = "Xem";
            }
            dgv.Columns.RemoveAt(0);
            return Program.qlks.tkphong(key);
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
                int sdtt = int.Parse(sdt);
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

        public DataTable luu(DataGridView dgv, DataTable Table)
        {
            Table = new DataTable();
            DataColumn rowstt = new DataColumn("STT", typeof(String));
            DataColumn rowtennv = new DataColumn("Tên phòng", typeof(String));
            DataColumn rowsongaynghi = new DataColumn("Loại", typeof(String));
            Table.Columns.Add(rowstt);
            Table.Columns.Add(rowtennv);
            Table.Columns.Add(rowsongaynghi);
            for (int i = 0; i < dgv.RowCount; i++)
            {
                DataRow row = Table.NewRow();
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    try
                    {
                        row[j] = (String)dgv.Rows[i].Cells[j].Value;
                    }
                    catch (Exception)
                    {
                        row[j] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
                Table.Rows.Add(row);
            }
            return Table;
        }

        public void capnhapdata(DataGridView dgv, frmadd frm, DataTable Table)
        {
            dgv.Columns.Clear();
            DataTable table = Program.qlks.tkloaiphong("");
            if (table.Rows.Count == 0)
            {
                frm.Close();
            }
            else
            {
                DataGridViewTextBoxColumn columnstt = new DataGridViewTextBoxColumn();
                columnstt.HeaderText = "STT";
                columnstt.ReadOnly = true;
                DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                column1.HeaderText = "Tên phòng";
                DataGridViewComboBoxColumn column2 = new DataGridViewComboBoxColumn();
                column2.HeaderText = "Loại";
                column2.DataSource = table;
                column2.DisplayMember = "Tên loại";
                column2.ValueMember = "Mã loại";
                dgv.Columns.Add(columnstt);
                dgv.Columns.Add(column1);
                dgv.Columns.Add(column2);
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                //set du lieu
                if(Table.Rows.Count > 1)
                {
                    dgv.Rows.Add(Table.Rows.Count - 1);
                    for (int i = 0; i < Table.Rows.Count; i++)
                    {
                        dgv.Rows[i].Cells[0].Value = i + 1;
                    }
                    for (int i = 0; i < Table.Rows.Count; i++)
                    {
                        dgv.Rows[i].Cells[1].Value = Table.Rows[i][1].ToString();
                        try
                        {
                            dgv.Rows[i].Cells[2].Value = Table.Rows[i][2].ToString();
                        }
                        catch (ArgumentException)
                        {
                            dgv.Rows[i].Cells[2].Value = table.Rows[0][1].ToString();
                        }
                    }
                }   
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
                        MessageBox.Show("cột tên phòng ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " quá 100 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        String sdt = (String)dgv.Rows[i].Cells[2].Value;
                        if (sdt != null && sdt.Trim().Length > 0)
                        {

                        }
                        else
                        {
                            loi = true;
                            MessageBox.Show("chưa chọn loại phòng ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
                else
                {
                    loi = true;
                    MessageBox.Show("chưa nhập cột tên phòng ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        row[1] = dgv.Rows[i].Cells[1].Value.ToString().Trim().ToUpper();
                        row[2] = dgv.Rows[i].Cells[2].Value.ToString().Trim();
                        table.Rows.Add(row);
                    }
                    table.TableName = "phong";
                    Program.qlks.themphong(table);
                    dgv.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Chưa nhập phòng nào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dgv.DataSource = Program.qlks.tkphong(key);
            DataGridViewButtonColumn colums3 = new DataGridViewButtonColumn();
            dgv.Columns.Add(colums3);
            DataGridViewButtonColumn colums1 = new DataGridViewButtonColumn();
            dgv.Columns.Add(colums1);
            DataGridViewButtonColumn colums2 = new DataGridViewButtonColumn();
            dgv.Columns.Add(colums2);
            DataGridViewButtonColumn colums4 = new DataGridViewButtonColumn();
            dgv.Columns.Add(colums4);
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[dgv.ColumnCount - 4].Value = "Xem";
                dgv.Rows[i].Cells[dgv.ColumnCount - 3].Value = "Sắp xếp";
                dgv.Rows[i].Cells[dgv.ColumnCount - 2].Value = "Sửa";
                dgv.Rows[i].Cells[dgv.ColumnCount - 1].Value = "Xóa";
            }
            dgv.Columns.RemoveAt(0);
            return Program.qlks.tkphong(key);
        }

        public void xoa(String ma)
        {
            Program.qlks.xoaphong(ma);
        }

        public void loadlp(ComboBox loai, frmsua_phong frm)
        {
            DataTable table = Program.qlks.tkloaiphong("");
            if (table.Rows.Count == 0)
            {
                frm.Close();
            }
            else
            {
                loai.DataSource = table;
                loai.DisplayMember = "Tên loại";
                loai.ValueMember = "Mã loại";
            }    
        }

        public void load(String madv, TextBox tennv, ComboBox loai, frmsua_phong frm)
        {
            DataTable table = Program.qlks.loadphongql(madv);
            if (table.Rows.Count == 0)
            {
                frm.Close();
            }
            else
            {
                tennv.Text = table.Rows[0][1].ToString();
                loai.SelectedValue = table.Rows[0][3].ToString();
            }
        }

        public void sua(String madv, TextBox tennv, ComboBox loai, frmsua_phong frm)
        {
            bool loi = false;
            if (tennv.Text.Trim().Length > 0)
            {
                if (tennv.Text.Trim().Length > 100)
                {
                    //ten nv nhieu hon 100 ky tu
                    MessageBox.Show("Tên phòng nhiều hơn 100 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loi = true;
                }
                else
                {
                    if (loai.SelectedIndex != -1)
                    {

                    }
                    else
                    {
                        //sdt rong
                        MessageBox.Show("Hãy chọn loại phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loi = true;
                    }
                }
            }
            else
            {
                //tennv rong
                MessageBox.Show("Hãy nhập tên phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loi = true;
            }
            if (!loi)
            {
                MessageBox.Show("Đã lưu thành công", "Thông Báo");
                DataTable table = new DataTable();
                table.TableName = "suaphong";
                DataColumn rowma = new DataColumn("1", typeof(String));
                DataColumn rowten = new DataColumn("2", typeof(String));
                DataColumn rowsdt = new DataColumn("3", typeof(String));
                table.Columns.Add(rowma);
                table.Columns.Add(rowten);
                table.Columns.Add(rowsdt);
                DataRow row = table.NewRow();
                row[0] = madv;
                row[1] = tennv.Text.Trim().ToUpper();
                row[2] = loai.SelectedValue;
                table.Rows.Add(row);
                Program.qlks.suaphong(table);
                frm.Close();
            }
        }

        public bool kt(String ma)
        {
            DataTable table = Program.qlks.tkthietbi("");
            if (table.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        public void loadbang(String ma, DataGridView dgv, frmsapxeptb frm)
        {
            dgv.Columns.Clear();
            DataTable table = Program.qlks.tkthietbi("");
            if (table.Rows.Count == 0)
            {
                frm.Close();
            }
            else
            {
                DataTable dataTable = Program.qlks.ktphong(ma);
                if (dataTable.Rows.Count == 0)
                {
                    frm.Close();
                }
                else
                {
                    DataGridViewTextBoxColumn columnstt = new DataGridViewTextBoxColumn();
                    columnstt.HeaderText = "STT";
                    columnstt.ReadOnly = true;
                    DataGridViewComboBoxColumn column1 = new DataGridViewComboBoxColumn();
                    column1.HeaderText = "Thiết bị";
                    column1.DataSource = table;
                    column1.DisplayMember = "Tên thiết bị";
                    column1.ValueMember = "Mã thiết bị";
                    DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
                    column2.HeaderText = "Số lượng";
                    dgv.Columns.Add(columnstt);
                    dgv.Columns.Add(column1);
                    dgv.Columns.Add(column2);
                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {
                        dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    DataTable table1 = Program.qlks.loadtbtpqlp(ma);
                    if(table1.Rows.Count == 1)
                        dgv.Rows.Add(1);
                    if (table1.Rows.Count > 1)
                        dgv.Rows.Add(table1.Rows.Count);
                    for (int i = 0; i < table1.Rows.Count; i++)
                    {
                        dgv.Rows[i].Cells[0].Value = (i + 1).ToString();
                        dgv.Rows[i].Cells[1].Value = table1.Rows[i][0].ToString();
                        dgv.Rows[i].Cells[2].Value = table1.Rows[i][1].ToString();
                    }
                }        
            }
        }

        public void loadbang(String ma, DataGridView dgv, frmXemdanhsach frm)
        {
            dgv.Columns.Clear();
            DataTable table = Program.qlks.tkthietbi("");
            if (table.Rows.Count == 0)
            {
                frm.Close();
            }
            else
            {
                DataTable dataTable = Program.qlks.ktphong(ma);
                if (dataTable.Rows.Count == 0)
                {
                    frm.Close();
                }
                else
                {
                    DataTable table1 = Program.qlks.loadtbtpqlp2(ma);
                    dgv.DataSource = table1;
                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {
                        dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                    dgv.Columns[1].DefaultCellStyle.FormatProvider = cul;
                    dgv.Columns[1].DefaultCellStyle.Format = "C0";
                    dgv.Columns[3].DefaultCellStyle.FormatProvider = cul;
                    dgv.Columns[3].DefaultCellStyle.Format = "C0";
                }
            }
        }

        public DataTable luudata(DataGridView dgv, DataTable Table)
        {
            Table = new DataTable();
            DataColumn rowstt = new DataColumn("STT", typeof(String));
            DataColumn rowtennv = new DataColumn("Thiết bị", typeof(String));
            DataColumn rowsongaynghi = new DataColumn("Số lượng", typeof(String));
            Table.Columns.Add(rowstt);
            Table.Columns.Add(rowtennv);
            Table.Columns.Add(rowsongaynghi);
            for (int i = 0; i < dgv.RowCount; i++)
            {
                DataRow row = Table.NewRow();
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    try
                    {
                        row[j] = (String)dgv.Rows[i].Cells[j].Value;
                    }
                    catch (Exception)
                    {
                        row[j] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
                Table.Rows.Add(row);
            }
            return Table;
        }

        public void capnhap(String ma, DataGridView dgv, frmsapxeptb frm, DataTable Table)
        {
            dgv.Columns.Clear();
            DataTable table = Program.qlks.tkthietbi("");
            if (table.Rows.Count == 0)
            {
                frm.Close();
            }
            else
            {
                DataTable dataTable = Program.qlks.ktphong(ma);
                if(dataTable.Rows.Count == 0)
                {
                    frm.Close();
                }    
                else
                {
                    DataGridViewTextBoxColumn columnstt = new DataGridViewTextBoxColumn();
                    columnstt.HeaderText = "STT";
                    columnstt.ReadOnly = true;
                    DataGridViewComboBoxColumn column1 = new DataGridViewComboBoxColumn();
                    column1.HeaderText = "Thiết bị";
                    column1.DataSource = table;
                    column1.DisplayMember = "Tên thiết bị";
                    column1.ValueMember = "Mã thiết bị";
                    DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
                    column2.HeaderText = "Số lượng";
                    dgv.Columns.Add(columnstt);
                    dgv.Columns.Add(column1);
                    dgv.Columns.Add(column2);
                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {
                        dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    //set du lieu
                    if (Table.Rows.Count > 1)
                    {
                        dgv.Rows.Add(Table.Rows.Count - 1);
                        for (int i = 0; i < Table.Rows.Count; i++)
                        {
                            dgv.Rows[i].Cells[0].Value = i + 1;
                        }
                        for (int i = 0; i < Table.Rows.Count; i++)
                        {
                            dgv.Rows[i].Cells[2].Value = Table.Rows[i][2].ToString();
                            try
                            {
                                dgv.Rows[i].Cells[1].Value = Table.Rows[i][1].ToString();
                            }
                            catch (ArgumentException)
                            {
                                dgv.Rows[i].Cells[1].Value = table.Rows[0][1].ToString();
                            }
                        }
                    }
                }    
            }
        }

        public void them2(String ma, DataGridView dgv)
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
                        MessageBox.Show("cột tên phòng ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " quá 100 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        String sdt = (String)dgv.Rows[i].Cells[2].Value;
                        if (sdt != null && sdt.Trim().Length > 0)
                        {
                            if(ktsdt(sdt.Trim()))
                            {

                            }   
                            else
                            {
                                loi = true;
                                MessageBox.Show("số lượng sai ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }    
                        }
                        else
                        {
                            loi = true;
                            MessageBox.Show("chưa nhập số lượng ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
                else
                {
                    loi = true;
                    MessageBox.Show("chưa chọn thiết bị ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            if (!loi)
            {
                if (dgv.Rows.Count > 1)
                {
                    for(int i = 0; i < dgv.Rows.Count - 1; i++)
                    {
                        for(int j = i + 1; j < dgv.Rows.Count - 1; j++)
                        {
                            if(dgv.Rows[i].Cells[1].Value.ToString() == dgv.Rows[j].Cells[1].Value.ToString())
                            {
                                if(i != j)
                                {
                                    loi = true;
                                    MessageBox.Show("Thiết bị ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " và dòng " + dgv.Rows[j].Cells[0].Value.ToString() + " giống nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }    
                            }
                        } 
                        if(loi)
                        {
                            break;
                        }    
                    }    
                    if(!loi)
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
                            row[0] = ma;
                            row[1] = dgv.Rows[i].Cells[1].Value.ToString();
                            row[2] = dgv.Rows[i].Cells[2].Value.ToString().Trim();
                            table.Rows.Add(row);
                        }
                        table.TableName = "sxthietbi";
                        Program.qlks.sapxeptb(table);
                        dgv.Rows.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập thiết bị nào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
