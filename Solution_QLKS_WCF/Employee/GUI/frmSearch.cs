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
    public partial class frmSearch : Form
    {
        String chucnang;
        TcpClient tcpclient;
        Thread t1;
        String key = "";
        bool kt = false;
        DataTable table;
        public frmSearch(String cn)
        {
            InitializeComponent();
            chucnang = cn;
        }

        private void frmSearch_Load(object sender, EventArgs e)
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
                    else
                    {
                        if (chucnang == "khachhang")
                        {
                            if (content == "themkhachhang")
                            {
                                Invoke(new Action(() =>
                                {
                                    if (kt)
                                        BUS_khachhang.DAO.search(key, dgv);
                                }));
                            }
                            else
                            {
                                if (content == "suakhachhang")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        if (kt)
                                            BUS_khachhang.DAO.search(key, dgv);
                                    }));
                                }
                                else
                                {
                                    if (content == "xoakhachhang")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            if (kt)
                                                BUS_khachhang.DAO.search(key, dgv);
                                        }));
                                    }
                                }
                            }
                        }
                    }
                }
            });
            t1.Start();
            if (chucnang == "khachhang")
            {
                this.Text += "khách hàng";
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text.Trim() == "Tìm kiếm...")
            {
                key = "";
            }
            else
            {
                key = txttimkiem.Text.Trim();
            }
            if (chucnang == "khachhang")
            {
                table = BUS_khachhang.DAO.search(key, dgv);
            }
            kt = true;
        }

        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (txttimkiem.Text.Trim() == "Tìm kiếm...")
            {
                txttimkiem.Text = "";
                txttimkiem.ForeColor = Color.Black;
            }
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (txttimkiem.Text.Trim() == "")
            {
                txttimkiem.Text = "Tìm kiếm...";
                txttimkiem.ForeColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chucnang == "khachhang")
            {
                if (e.ColumnIndex == dgv.ColumnCount - 1)
                {
                    if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                    {
                        frm_sua_khach_hang frm = new frm_sua_khach_hang(table.Rows[e.RowIndex][0].ToString());
                        frm.Show();
                    }
                }
            }
        }

        private void frmSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }
    }
}
