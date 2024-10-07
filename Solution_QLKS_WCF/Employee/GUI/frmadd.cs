using Employee.BUS;
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

namespace Employee.GUI
{
    public partial class frmadd : Form
    {
        String chucnang;
        Thread t1;
        TcpClient tcpclient;
        int y, dongxoa;
        public frmadd(String cn)
        {
            InitializeComponent();
            chucnang = cn;
        }

        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

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
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa dòng này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnluu_Click(object sender, EventArgs e)
        {
            BUS_khachhang.DAO.them(dgv);
        }

        private void frmadd_Load(object sender, EventArgs e)
        {
            tcpclient = new TcpClient();
            tcpclient.Connect(config.ipsocket, config.portsocket);
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
                    /*if (chucnang == "phong")
                    {
                        if (content == "xoaloaiphong")
                        {
                            Invoke(new Action(() =>
                            {
                                dgv.CellValueChanged -= dgv_CellValueChanged;
                                BUS_phong.DAO.capnhapdata(dgv, this, Table);
                                Table = BUS_phong.DAO.luu(dgv, Table);
                                dgv.CellValueChanged += dgv_CellValueChanged;
                            }));
                        }
                        else
                        {
                            if (content == "themloaiphong")
                            {
                                Invoke(new Action(() =>
                                {
                                    dgv.CellValueChanged -= dgv_CellValueChanged;
                                    BUS_phong.DAO.capnhapdata(dgv, this, Table);
                                    Table = BUS_phong.DAO.luu(dgv, Table);
                                    dgv.CellValueChanged += dgv_CellValueChanged;
                                }));
                            }
                            else
                            {
                                if (content == "sualoaiphong")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        dgv.CellValueChanged -= dgv_CellValueChanged;
                                        BUS_phong.DAO.capnhapdata(dgv, this, Table);
                                        Table = BUS_phong.DAO.luu(dgv, Table);
                                        dgv.CellValueChanged += dgv_CellValueChanged;
                                    }));
                                }
                            }
                        }
                    }*/
                }
            });
            t1.Start();
            if (chucnang == "khachhang")
            {
                this.Text += "khách hàng";
                BUS_khachhang.DAO.loadbangdv(dgv, this);
            }
        }
    }
}
