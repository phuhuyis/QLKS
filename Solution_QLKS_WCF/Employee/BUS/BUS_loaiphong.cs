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
        
        public DataTable search(String key, DataGridView dgv)
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
    }
}
