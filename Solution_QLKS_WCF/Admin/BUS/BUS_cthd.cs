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
    public class BUS_cthd
    {
        private static BUS_cthd instance;
        public static BUS_cthd DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_cthd();
                }
                return instance;
            }
        }

        public DataTable loaddsdv(ComboBox cbxdv)
        {
            DataTable table = Program.qlks.loaddsdv();
            cbxdv.DataSource = table;
            cbxdv.DisplayMember = "tendv";
            cbxdv.ValueMember = "madv";
            return table;
        }

        public DataTable loadbanggia(DataGridView dgv)
        {
            DataTable tbl = Program.qlks.loadbanggiadv();
            dgv.DataSource = tbl;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            dgv.Columns[2].DefaultCellStyle.Format = "C0";
            dgv.Columns[2].DefaultCellStyle.FormatProvider = cul;
            return tbl;
        }

        public DataTable loaddvdagoi(DataGridView dgv, String sohd)
        {
            DataTable tbl = Program.qlks.loaddvdagoi(sohd);
            dgv.DataSource = tbl;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            dgv.Columns[1].DefaultCellStyle.Format = "C0";
            dgv.Columns[1].DefaultCellStyle.FormatProvider = cul;
            dgv.Columns[3].DefaultCellStyle.Format = "C0";
            dgv.Columns[3].DefaultCellStyle.FormatProvider = cul;
            return tbl;
        }

        public String laysohd(String maphong)
        {
            return Program.qlks.laysohd(maphong);
        }

        public void goidv(ComboBox cbxdv, NumericUpDown numersl, String sohd)
        {
            if(Program.qlks.kiemtradvtontai(sohd, cbxdv.SelectedValue.ToString()))
            {
                //da ton tai
                MessageBox.Show("Đã gọi dịch vụ này rồi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(numersl.Value > Program.qlks.laysldv(cbxdv.SelectedValue.ToString()))
                {
                    //sl khong hop le
                    MessageBox.Show("Số lượng không đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Gọi dịch vụ thành công");
                    Program.qlks.goidv(sohd, cbxdv.SelectedValue.ToString(), (int)numersl.Value);
                }
            }
        }

        public void capnhapdv(ComboBox cbxdv, NumericUpDown numersl, String sohd)
        {
            if (Program.qlks.kiemtradvtontai(sohd, cbxdv.SelectedValue.ToString()))
            {
                //da ton tai
                if (numersl.Value > Program.qlks.laysldv(cbxdv.SelectedValue.ToString()) + Program.qlks.laysldvhd(sohd, cbxdv.SelectedValue.ToString()))
                {
                    //sl khong hop le
                    MessageBox.Show("Số lượng không đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cập nhập thành công");
                    Program.qlks.capnhapdv(sohd, cbxdv.SelectedValue.ToString(), (int)numersl.Value);
                }
            }
            else
            {
                MessageBox.Show("Chưa gọi dịch vụ này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void huydv(ComboBox cbxdv, String sohd)
        {
            if (Program.qlks.kiemtradvtontai(sohd, cbxdv.SelectedValue.ToString()))
            {
                MessageBox.Show("Hủy dịch vụ thành công");
                Program.qlks.xoadv(sohd, cbxdv.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Chưa gọi dịch vụ này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool kiemtrahd(String sohd)
        {
            return Program.qlks.kiemtrasohd(sohd);
        }

        public void huyhd(String sohd)
        {
            Program.qlks.huyhdthue(sohd);
        }

        public void thanhtoan(String sohd, frmgoidv frm, DataGridView dgv, frmSystem frmsys)
        {
            if(MessageBox.Show("Bạn có chắn chắn muốn thanh toán hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Program.qlks.thanhtoan(sohd);
                if (dgv.Rows.Count == 0)
                {
                    frmhoadonkodv frmhd = new frmhoadonkodv(sohd, frmsys);
                    frmhd.Show();
                    frm.Close();
                }
                else
                {
                    frmhoadoncodv frmhd = new frmhoadoncodv(sohd, frmsys);
                    frmhd.Show();
                    frm.Close();
                }
            }    
        }

        public DataTable search(String key, DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.DataSource = Program.qlks.tkhoadonthue(key);
            DataGridViewButtonColumn colums1 = new DataGridViewButtonColumn();
            dgv.Columns.Add(colums1);
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[dgv.ColumnCount - 1].Value = "Xem";
            }
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            dgv.Columns[2].DefaultCellStyle.Format = "d";
            dgv.Columns[2].DefaultCellStyle.FormatProvider = cul;
            dgv.Columns[3].DefaultCellStyle.Format = "d";
            dgv.Columns[3].DefaultCellStyle.FormatProvider = cul;
            return Program.qlks.tkhoadonthue(key);
        }

        public void xemhoadon(String sohd, frmSystem frm)
        {
            if(Program.qlks.kiemtratontaihdcthd(sohd))
            {
                //co cthd
                frmhoadoncodv frmhd = new frmhoadoncodv(sohd, frm);
                frmhd.Show();
            }
            else
            {
                frmhoadonkodv frmhd = new frmhoadonkodv(sohd, frm);
                frmhd.Show();
            }
        }
    }
}
