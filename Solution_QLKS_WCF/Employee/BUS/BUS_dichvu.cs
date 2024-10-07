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
    public class BUS_dichvu
    {
        private static BUS_dichvu instance;
        public static BUS_dichvu DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_dichvu();
                }
                return instance;
            }
        }

        public DataTable search(String key, DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.DataSource = Program.qlks.tkdichvu(key);
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgv.Columns.RemoveAt(0);
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            dgv.Columns[2].DefaultCellStyle.Format = "C0";
            dgv.Columns[2].DefaultCellStyle.FormatProvider = cul;
            return Program.qlks.tkdichvu(key);
        }
    }
}
