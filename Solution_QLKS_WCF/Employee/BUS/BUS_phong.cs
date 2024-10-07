using Employee.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee.BUS
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

        public DataTable search(String key, DataGridView dgv)
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
    }
}
