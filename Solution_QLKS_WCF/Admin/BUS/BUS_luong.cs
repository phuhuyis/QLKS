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
    public class BUS_luong
    {
        //DataTable Table;
        DataTable Tbl_luong;
        private static BUS_luong instance;
        public static BUS_luong DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_luong();
                }
                return instance;
            }
        }

        public bool kttinhluong()
        {
            return Program.qlks.kttinhluong();
        }

        public void loadluong(DataGridView dgv)
        {
            dgv.Columns.Clear();
            DataTable table = Program.qlks.loadluong();
            DataGridViewTextBoxColumn columnsstt = new DataGridViewTextBoxColumn();
            columnsstt.HeaderText = "STT";
            dgv.Columns.Add(columnsstt);
            dgv.DataSource = table;
            DataGridViewTextBoxColumn columns1 = new DataGridViewTextBoxColumn();
            columns1.HeaderText = "Số ngày nghỉ";
            DataGridViewTextBoxColumn columns2 = new DataGridViewTextBoxColumn();
            columns2.HeaderText = "Thưởng thêm";
            dgv.Columns[0].ReadOnly = true;
            dgv.Columns[1].ReadOnly = true;
            dgv.Columns[2].ReadOnly = true;
            dgv.Columns.Add(columns1);
            dgv.Columns.Add(columns2);
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[0].Value = i + 1;
            }
        }
        public bool ktnv()
        {
            return Program.qlks.ktnv();
        }

        public DataTable luu(DataGridView dgv, DataTable Table)
        {
            Table = new DataTable();
            DataColumn rowstt = new DataColumn("STT", typeof(String));
            DataColumn rowmanv = new DataColumn("Mã nhân viên", typeof(String));
            DataColumn rowtennv = new DataColumn("Tên nhân viên", typeof(String));
            DataColumn rowsongaynghi = new DataColumn("Số ngày nghỉ", typeof(String));
            DataColumn rowthuongthem = new DataColumn("Thưởng thêm", typeof(String));
            Table.Columns.Add(rowstt);
            Table.Columns.Add(rowmanv);
            Table.Columns.Add(rowtennv);
            Table.Columns.Add(rowsongaynghi);
            Table.Columns.Add(rowthuongthem);
            for (int i = 0; i < dgv.RowCount; i++)
            {
                DataRow row = Table.NewRow();
                for(int j = 0; j < dgv.ColumnCount; j++)
                {
                    try
                    {
                        row[j] = (String)dgv.Rows[i].Cells[j].Value;
                    }
                    catch(Exception)
                    {
                        row[j] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
                Table.Rows.Add(row);
            }
            return Table;
        }

        public void capnhapdata(DataGridView dgv, DataTable Table)
        {
            DataTable table = Program.qlks.loadluong();
            dgv.Columns.Clear();
            DataGridViewTextBoxColumn columnsstt = new DataGridViewTextBoxColumn();
            columnsstt.HeaderText = "STT";
            dgv.Columns.Add(columnsstt);
            //sua data
            dgv.DataSource = table;
            DataGridViewTextBoxColumn columns1 = new DataGridViewTextBoxColumn();
            columns1.HeaderText = "Số ngày nghỉ";
            DataGridViewTextBoxColumn columns2 = new DataGridViewTextBoxColumn();
            columns2.HeaderText = "Thưởng thêm";
            dgv.Columns[0].ReadOnly = true;
            dgv.Columns[1].ReadOnly = true;
            dgv.Columns[2].ReadOnly = true;
            dgv.Columns.Add(columns1);
            dgv.Columns.Add(columns2);
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[0].Value = i + 1;
            }
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                if(i < dgv.Rows.Count)
                {
                    if (Table.Rows[i][1].ToString() == dgv.Rows[i].Cells[1].Value.ToString())
                    {
                        //ma giong nhau sang qua
                        dgv.Rows[i].Cells[3].Value = Table.Rows[i][3].ToString();
                        dgv.Rows[i].Cells[4].Value = Table.Rows[i][4].ToString();
                    }
                    else
                    {
                        dgv.Rows[i].Cells[3].Value = Table.Rows[i + 1][3].ToString();
                        dgv.Rows[i].Cells[4].Value = Table.Rows[i + 1][4].ToString();
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public void capnhapdata2(DataGridView dgv, DataTable Table)
        {
            DataTable table = Program.qlks.loadluong();
            dgv.Columns.Clear();
            DataGridViewTextBoxColumn columnsstt = new DataGridViewTextBoxColumn();
            columnsstt.HeaderText = "STT";
            dgv.Columns.Add(columnsstt);
            //sua data
            dgv.DataSource = table;
            DataGridViewTextBoxColumn columns1 = new DataGridViewTextBoxColumn();
            columns1.HeaderText = "Số ngày nghỉ";
            DataGridViewTextBoxColumn columns2 = new DataGridViewTextBoxColumn();
            columns2.HeaderText = "Thưởng thêm";
            dgv.Columns[0].ReadOnly = true;
            dgv.Columns[1].ReadOnly = true;
            dgv.Columns[2].ReadOnly = true;
            dgv.Columns.Add(columns1);
            dgv.Columns.Add(columns2);
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[0].Value = i + 1;
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for(int j = 0; j < Table.Rows.Count; j++)
                {
                    if (Table.Rows[j][1].ToString() == dgv.Rows[i].Cells[1].Value.ToString())
                    {
                        //ma giong nhau sang qua
                        dgv.Rows[i].Cells[3].Value = Table.Rows[j][3].ToString();
                        dgv.Rows[i].Cells[4].Value = Table.Rows[j][4].ToString();
                    }
                }    
            }
        }

        bool ktsongaynghi(String songaynghi)
        {
            try
            {
                int l = int.Parse(songaynghi);
                if(l <= DateTime.DaysInMonth(DateTime.Now.Year,DateTime.Now.Month) && l >= 0)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool kttt(String tt)
        {
            try
            {
                long l = long.Parse(tt);
                if(l >= 0)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void tinhluong(DataGridView dgv, DataTable Table)
        {
            for(int i = 0; i < dgv.Rows.Count; i++)
            {
                String songaynghi = (String)dgv.Rows[i].Cells[3].Value;
                if(songaynghi != null)
                {
                    if(songaynghi.Trim().Length > 0)
                    {
                        if(ktsongaynghi(songaynghi.Trim()))
                        {
                            String thuongthem = (String)dgv.Rows[i].Cells[4].Value;
                            if(thuongthem != null)
                            {
                                if(thuongthem.Trim().Length > 0)
                                {
                                    if (kttt(thuongthem.Trim()))
                                    {
                                        MessageBox.Show("Lưu thành công");
                                        Table = luu(dgv, Table);
                                        Table.TableName = "tinhluong";
                                        Program.qlks.tinhluong(Table);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Cột thưởng thêm ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                    }
                                }   
                                else
                                {
                                    MessageBox.Show("chưa nhập cột thưởng thêm ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }    
                            }
                            else
                            {
                                MessageBox.Show("chưa nhập cột thưởng thêm ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số ngày nghỉ ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("chưa nhập cột số ngày nghỉ ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("chưa nhập cột số ngày nghỉ ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }

        public void xoaluong()
        {
            Program.qlks.xoaluong();
        }

        public void tkluong(String key, DataGridView dgv)
        {
            Tbl_luong = new DataTable();
            dgv.Columns.Clear();
            dgv.DataSource = Program.qlks.tkluong(key);
            DataGridViewButtonColumn colums1 = new DataGridViewButtonColumn();
            dgv.Columns.Add(colums1);
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[dgv.ColumnCount - 1].Value = "Sửa";
            }
            Tbl_luong = Program.qlks.tkluong2(key);
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            dgv.Columns[4].DefaultCellStyle.Format = "C0";
            dgv.Columns[4].DefaultCellStyle.FormatProvider = cul;
            dgv.Columns[5].DefaultCellStyle.Format = "C0";
            dgv.Columns[5].DefaultCellStyle.FormatProvider = cul;
        }

        public void chuyensua(int position, frmSystem frmSystem)
        {
            frmcapnhapluong frm = new frmcapnhapluong(Tbl_luong.Rows[position][0].ToString(), frmSystem);
            frm.Show();
        }

        public void loadluongcn(TextBox txtma, TextBox txtten, NumericUpDown txtsongaynghi, NumericUpDown txttt, String maphieu, frmcapnhapluong frm)
        {
            DataTable table = Program.qlks.loadluongcn(maphieu);
            if(table.Rows.Count > 0)
            {
                txtma.Text = table.Rows[0][0].ToString();
                txtsongaynghi.Minimum = 0;
                txtsongaynghi.Maximum = DateTime.DaysInMonth(int.Parse(table.Rows[0][1].ToString()), int.Parse(table.Rows[0][2].ToString()));
                txtsongaynghi.Value = int.Parse(table.Rows[0][3].ToString());
                txttt.Value = int.Parse(table.Rows[0][4].ToString());
                txtten.Text = table.Rows[0][5].ToString();
            }    
            else
            {
                frm.Close();
            }    
        }
        public void capnhapluong(NumericUpDown txtsongaynghi, NumericUpDown txttt, String maphieu)
        {
            DataTable table = new DataTable();
            DataColumn column1 = new DataColumn("manv", typeof(String));
            DataColumn column2 = new DataColumn("songaynghi", typeof(int));
            DataColumn column3 = new DataColumn("tt", typeof(long));
            table.Columns.Add(column1);
            table.Columns.Add(column2);
            table.Columns.Add(column3);
            DataRow row = table.NewRow();
            row[0] = maphieu;
            row[1] = txtsongaynghi.Value;
            row[2] = txttt.Value;
            table.Rows.Add(row);
            table.TableName = "cnluong";
            Program.qlks.capnhapluong(table);
        }
    }
}
