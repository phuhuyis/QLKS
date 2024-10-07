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
    public class BUS_nhapdichvu
    {
        DataTable table;
        DataTable table2;
        private static BUS_nhapdichvu instance;
        public static BUS_nhapdichvu DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_nhapdichvu();
                }
                return instance;
            }
        }

        public bool ktdvcc()
        {
            table = Program.qlks.loaddvcc();
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có đơn vị cung cấp nào hãy thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void loaddvcc(ComboBox cmb, frmnhapdichvu frm)
        {
            cmb.Items.Clear();
            table = Program.qlks.loaddvcc();
            if(table.Rows.Count == 0)
            {
                frm.Close();
            }
            else
            {
                for(int i = 0; i < table.Rows.Count; i++)
                {
                    cmb.Items.Add(table.Rows[i][1].ToString());
                }
            }
        }

        public String laymadv(int position)
        {
            return table.Rows[position][0].ToString();
        }

        public String taosohd(int position)
        {
            return Program.qlks.taohdnhap(laymadv(position));
        }

        public void huyhd(String sohd)
        {
            Program.qlks.huyhd(sohd);
        }

        public Boolean loadbangdv(DataGridView dgv, frmnhap_ctdichvu frm, Boolean kt)
        {
            table2 = Program.qlks.loaddichvu();
            if (table2.Rows.Count == 0)
            {
                kt = true;
                frm.Close();
            }    
            else
            {
                dgv.Columns.Clear();
                DataGridViewTextBoxColumn columnstt = new DataGridViewTextBoxColumn();
                columnstt.HeaderText = "STT";
                columnstt.ReadOnly = true;
                DataGridViewComboBoxColumn column1 = new DataGridViewComboBoxColumn();
                column1.HeaderText = "Dịch vụ";
                column1.DataSource = table2;
                column1.DisplayMember = "tendv";
                column1.ValueMember = "madv";
                DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
                column2.HeaderText = "Giá";
                DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
                column3.HeaderText = "Số lượng";
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
            return kt;
        }

        bool ktgia(String gia)
        {
            try
            {
                long l = long.Parse(gia);
                if (l >= 1)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool ktsl (String sl)
        {
            try
            {
                int l = int.Parse(sl);
                if (l >= 1)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void nhapdichvu(DataGridView dgv, String sohd, frmnhap_ctdichvu frm, frmSystem frmSystem)
        {
            bool loi = false;
            for(int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                String dichvu = (String)dgv.Rows[i].Cells[1].Value;
                if(dichvu == null)
                {
                    //nhap dv
                    loi = true;
                    MessageBox.Show("Chưa chọn dịch vụ ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                {
                    if(dichvu.Trim().Length > 0)
                    {
                        String gia = (String)dgv.Rows[i].Cells[2].Value;
                        if (gia == null)
                        {
                            //nhap gia
                            loi = true;
                            MessageBox.Show("Chưa nhập giá ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else
                        {
                            if (gia.Trim().Length > 0)
                            {
                                if(ktgia(gia.Trim()))
                                {
                                    for(int j = 0; j < table2.Rows.Count; j++)
                                    {
                                        if(table2.Rows[j][0].ToString() == dichvu)
                                        {
                                            if(long.Parse(table2.Rows[j][3].ToString()) < long.Parse(gia))
                                            {
                                                loi = true;
                                                MessageBox.Show("Giá ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " lớn hơn giá bán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                break;
                                            }    
                                        }
                                    }
                                    if(!loi)
                                    {
                                        String sl = (String)dgv.Rows[i].Cells[3].Value;
                                        if (sl == null)
                                        {
                                            //nhap sl
                                            loi = true;
                                            MessageBox.Show("Chưa nhập số lượng ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            break;
                                        }
                                        else
                                        {
                                            if (sl.Trim().Length > 0)
                                            {
                                                if (ktsl(sl.Trim()))
                                                {

                                                }
                                                else
                                                {
                                                    //sl khong hop le
                                                    loi = true;
                                                    MessageBox.Show("Số lượng không hợp lệ ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    break;
                                                }
                                            }
                                            else
                                            {
                                                //nhap sl
                                                loi = true;
                                                MessageBox.Show("Chưa nhập số lượng ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                break;
                                            }
                                        }
                                    }    
                                    else
                                    {
                                        break;
                                    }    
                                }
                                else
                                {
                                    //gia khong hop le
                                    loi = true;
                                    MessageBox.Show("Giá không hợp lệ ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            }
                            else
                            {
                                //nhap gia
                                loi = true;
                                MessageBox.Show("Chưa nhập giá ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                    else
                    {
                        //nhap dv
                        loi = true;
                        MessageBox.Show("Chưa chọn dịch vụ ở dòng " + dgv.Rows[i].Cells[0].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
            if(!loi)
            {
                for (int i = 0; i < dgv.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgv.Rows.Count - 1; j++)
                    {
                        if (i != j)
                        {
                            if (dgv.Rows[i].Cells[1].Value.ToString() == dgv.Rows[j].Cells[1].Value.ToString())
                            {
                                loi = true;
                                MessageBox.Show("Dịch vụ ở dòng " + dgv.Rows[i].Cells[0].Value.ToString() + " và dòng " + dgv.Rows[j].Cells[0].Value.ToString() + " giống nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                    if (loi)
                        break;
                }
            }    
            if (!loi)
            {
                if(dgv.Rows.Count > 1)
                {
                    MessageBox.Show("Nhập dịch vụ thành công");
                    DataTable table = new DataTable();
                    table.TableName = "nhapdichvu";
                    DataColumn column1 = new DataColumn("sohd", typeof(String));
                    DataColumn column2 = new DataColumn("madv", typeof(String));
                    DataColumn column3 = new DataColumn("gia", typeof(String));
                    DataColumn column4 = new DataColumn("sl", typeof(String));
                    table.Columns.Add(column1);
                    table.Columns.Add(column2);
                    table.Columns.Add(column3);
                    table.Columns.Add(column4);
                    for(int i = 0; i < dgv.Rows.Count - 1; i++)
                    {
                        DataRow row = table.NewRow();
                        row[0] = sohd;
                        row[1] = dgv.Rows[i].Cells[1].Value.ToString();
                        row[2] = dgv.Rows[i].Cells[2].Value.ToString();
                        row[3] = dgv.Rows[i].Cells[3].Value.ToString();
                        table.Rows.Add(row);
                    }
                    Program.qlks.nhapdichvu(table);
                    frmnhap_ctdichvu.kt2 = true;
                    frm.Close();
                    HoaDonNhap hsn = new HoaDonNhap(sohd, frmSystem);
                    hsn.Show();
                }
                else
                {
                    MessageBox.Show("Chưa chọn dịch vụ nào để thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public DataTable luudata(DataGridView dgv, DataTable Table)
        {
            Table = new DataTable();
            DataColumn rowstt = new DataColumn("STT", typeof(String));
            DataColumn rowtennv = new DataColumn("Dịch vụ", typeof(String));
            DataColumn rowsongaynghi = new DataColumn("Giá", typeof(String));
            DataColumn rowsongaynghi2 = new DataColumn("Số lượng", typeof(String));
            Table.Columns.Add(rowstt);
            Table.Columns.Add(rowtennv);
            Table.Columns.Add(rowsongaynghi);
            Table.Columns.Add(rowsongaynghi2);
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

        public Boolean ktdv()
        {
            table2 = Program.qlks.loaddichvu();
            if (table2.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        public Boolean capnhap(DataGridView dgv, DataTable Table, Boolean kt3)
        {
            table2 = Program.qlks.loaddichvu();
            if (table2.Rows.Count == 0)
            {
                kt3 = true;
            }
            else
            {
                dgv.Columns.Clear();
                DataGridViewTextBoxColumn columnstt = new DataGridViewTextBoxColumn();
                columnstt.HeaderText = "STT";
                columnstt.ReadOnly = true;
                DataGridViewComboBoxColumn column1 = new DataGridViewComboBoxColumn();
                column1.HeaderText = "Dịch vụ";
                column1.DataSource = table2;
                column1.DisplayMember = "tendv";
                column1.ValueMember = "madv";
                DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
                column2.HeaderText = "Giá";
                DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
                column3.HeaderText = "Số lượng";
                dgv.Columns.Add(columnstt);
                dgv.Columns.Add(column1);
                dgv.Columns.Add(column2);
                dgv.Columns.Add(column3);
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
                        dgv.Rows[i].Cells[3].Value = Table.Rows[i][3].ToString();
                    }
                }
            }
            return kt3;
        }

        public void search(String key, DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.DataSource = Program.qlks.timkiemhdnhap(key);
            DataGridViewButtonColumn colums2 = new DataGridViewButtonColumn();
            dgv.Columns.Add(colums2);
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[dgv.ColumnCount - 1].Value = "Xem";
            }
            dgv.Columns[0].HeaderText = "Số hóa đơn";
            dgv.Columns[1].HeaderText = "Đơn vị cung cấp";
            dgv.Columns[2].HeaderText = "Ngày nhập";
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            dgv.Columns[2].DefaultCellStyle.FormatProvider = cul;
            dgv.Columns[2].DefaultCellStyle.Format = "d";
        }
    }
}
