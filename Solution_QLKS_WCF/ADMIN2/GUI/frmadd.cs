using ADMIN2.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN2.GUI
{
    public partial class frmadd : Form
    {
        String chucnang;
        Thread t1;
        int port = 222;
        TcpClient tcpclient;
        int y, dongxoa;
        public frmadd(String cn)
        {
            InitializeComponent();
            chucnang = cn;
        }

        private void frmadd_Load(object sender, EventArgs e)
        {
            tcpclient = new TcpClient();
            tcpclient.Connect("192.168.0.196", port);
            BUS_Login.DAO.themsocket(frmSystem.user.Trim());
            t1 = new Thread(() =>
            {
                while (true)
                {
                    Stream stream = tcpclient.GetStream();
                    var reader = new StreamReader(stream);
                    var writer = new StreamWriter(stream);
                    writer.AutoFlush = true;
                    String content = reader.ReadLine();
                    if (content == "dangxuat")
                    {
                        Invoke(new Action(() =>
                        {
                            this.Close();
                        }));
                    }
                }
            });
            t1.Start();
            if (chucnang == "nhanvien")
            {
                this.Text += "nhân viên";
                BUS_nhanvien.DAO.loadbangnv(dgv);
            }
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgv.Rows[dgv.RowCount - 1].Cells[0].Value = dgv.RowCount;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex > -1 && e.RowIndex < dgv.Rows.Count - 1)
            {
                xoa.Show(new Point(Left, y));
            }
        }

        private void dgv_MouseDown(object sender, MouseEventArgs e)
        {
            y = e.Y;
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dongxoa = e.RowIndex;
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv.Rows.RemoveAt(dongxoa);
                resetstt(dongxoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa dòng này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            BUS_nhanvien.DAO.themnv(dgv, frmSystem.user);
        }

        private void frmadd_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        void resetstt(int dongx)
        {
            for (int i = dongx; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}
