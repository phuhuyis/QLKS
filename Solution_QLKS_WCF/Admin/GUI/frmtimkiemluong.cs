using Admin.BUS;
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

namespace Admin.GUI
{
    public partial class frmtimkiemluong : Form
    {
        String key = "";
        TcpClient tcpclient;
        Thread t1;
        bool kt = false;
        frmSystem frm;

        public frmtimkiemluong(frmSystem frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên nhân viên...")
            {
                txttimkiem.Text = "";
                txttimkiem.ForeColor = Color.Black;
            }
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (txttimkiem.Text.Trim() == "")
            {
                txttimkiem.Text = "Tìm kiếm theo tên nhân viên...";
                txttimkiem.ForeColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void frmtimkiemluong_Load(object sender, EventArgs e)
        {
            tcpclient = new TcpClient();
            tcpclient.Connect(config.ipsocket, config.portsocket);
            BUS_Login.DAO.themsocket(frm.user.Trim());
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
                        if (content == "tinhluong")
                        {
                            if(kt)
                            {
                                Invoke(new Action(() =>
                                {
                                    BUS_luong.DAO.tkluong(key, dgv);
                                }));
                            }    
                        }
                        else
                        {
                            if (content == "capnhapnv")
                            {
                                if (kt)
                                {
                                    Invoke(new Action(() =>
                                    {
                                        BUS_luong.DAO.tkluong(key, dgv);
                                    }));
                                }
                            }
                            else
                            {
                                if (content == "xoaluong")
                                {
                                    if (kt)
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            BUS_luong.DAO.tkluong(key, dgv);
                                        }));
                                    }
                                }
                                else
                                {
                                    if (content == "xoanv")
                                    {
                                        if (kt)
                                        {
                                            Invoke(new Action(() =>
                                            {
                                                BUS_luong.DAO.tkluong(key, dgv);
                                            }));
                                        }
                                    }
                                    else
                                    {
                                        if (content == "capnhapluong")
                                        {
                                            if (kt)
                                            {
                                                Invoke(new Action(() =>
                                                {
                                                    BUS_luong.DAO.tkluong(key, dgv);
                                                }));
                                            }
                                        }
                                    }    
                                }    
                            }    
                        }
                    }    
                }
            });
            t1.Start();
            txttimkiem.Text = "Tìm kiếm theo tên nhân viên...";
        }

        private void frmtimkiemluong_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên nhân viên...")
            {
                key = "";
            }
            else
            {
                key = txttimkiem.Text.Trim();
            }
            BUS_luong.DAO.tkluong(key, dgv);
            kt = true;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv.ColumnCount - 1)
            {
                if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                {
                    BUS_luong.DAO.chuyensua(e.RowIndex, this.frm);
                }
            }
        }
    }
}
