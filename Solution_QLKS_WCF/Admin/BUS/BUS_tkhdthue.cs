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
    public class BUS_tkhdthue
    {
        private static BUS_tkhdthue instance;
        public static BUS_tkhdthue DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_tkhdthue();
                }
                return instance;
            }
        }

        public DataTable tknam(DataGridView dgv, int nam)
        {
            dgv.Columns.Clear();
            dgv.DataSource = Program.qlks.thongkehdthue_nam(nam);
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
            return Program.qlks.thongkehdthue_nam(nam);
        }

        public DataTable tkthang(DataGridView dgv, int thang, int nam)
        {
            dgv.Columns.Clear();
            dgv.DataSource = Program.qlks.thongkehdthue_thang(thang, nam);
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
            return Program.qlks.thongkehdthue_thang(thang, nam);
        }

        public DataTable tkkcngay(DataGridView dgv, DateTime ngaybd, DateTime ngaykt)
        {
            dgv.Columns.Clear();
            dgv.DataSource = Program.qlks.thongkehdthue_kcngay(ngaybd, ngaykt);
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
            return Program.qlks.thongkehdthue_kcngay(ngaybd, ngaykt);
        }
    }
}
