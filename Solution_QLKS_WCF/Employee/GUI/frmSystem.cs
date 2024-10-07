using Employee.BUS;
using Employee.GUI.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class frmSystem : Form
    {
        Thread t1;
        public static String user;
        TcpClient tcpclient;
        public static String loailp;
        public frmSystem(String us)
        {
            InitializeComponent();
            user = us.Trim();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất hay không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.qlks.dangxuat(user.Trim());
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.qlks.dangxuat(user.Trim());
                Process[] pro = Process.GetProcesses();
                foreach (var pc in pro)
                    if (pc.ProcessName == this.ProductName.ToString())
                        pc.Kill();
            }
        }

        private void frmSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.Show();
        }

        private void frmSystem_Load(object sender, EventArgs e)
        {
            tcpclient = new TcpClient();
            tcpclient.Connect(config.ipsocket, config.portsocket);
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
                            this.Hide();
                            t1.Abort();
                        }));
                    }
                    else
                    {
                        if(content == "themloaiphong")
                        {
                            Invoke(new Action(() =>
                            {
                                BUS_system.DAO.loadloaiphong(flploaiphong);
                            }));
                        }    
                        else
                        {
                            if (content == "xoaloaiphong")
                            {
                                Invoke(new Action(() =>
                                {
                                    BUS_system.DAO.loadloaiphong(flploaiphong);
                                }));
                            }
                            else
                            {
                                if (content == "sualoaiphong")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        BUS_system.DAO.loadloaiphong(flploaiphong);
                                    }));
                                }
                                else
                                {
                                    if (content == "themphong")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            BUS_system.DAO.loadphong(loailp, flpphong);
                                        }));
                                    }
                                    else
                                    {
                                        if (content == "xoaphong")
                                        {
                                            Invoke(new Action(() =>
                                            {
                                                BUS_system.DAO.loadphong(loailp, flpphong);
                                            }));
                                        }
                                        else
                                        {
                                            if (content == "themphong")
                                            {
                                                Invoke(new Action(() =>
                                                {
                                                    BUS_system.DAO.loadphong(loailp, flpphong);
                                                }));
                                            }
                                            else
                                            {
                                                if (content == "suaphong")
                                                {
                                                    Invoke(new Action(() =>
                                                    {
                                                        BUS_system.DAO.loadphong(loailp, flpphong);
                                                    }));
                                                }
                                                else
                                                {
                                                    if(content.Contains("datphongkc"))
                                                    {
                                                        Invoke(new Action(() =>
                                                        {
                                                            BUS_system.DAO.loadphong(loailp, flpphong);
                                                        }));
                                                    }
                                                    else
                                                    {
                                                        if (content.Contains("thuephongkc"))
                                                        {
                                                            Invoke(new Action(() =>
                                                            {
                                                                BUS_system.DAO.loadphong(loailp, flpphong);
                                                            }));
                                                        }
                                                    }    
                                                }
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
            BUS_system.DAO.loadloaiphong(flploaiphong);
            BUS_system.DAO.loadphong("lp000",flpphong);
        }

        private void frmSystem_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Program.qlks.dangxuat(user.Trim());
            t1.Abort();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmadd frm = new frmadd("khachhang");
            frm.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch("khachhang");
            frm.Show();
        }

        private void xemDanhSáchLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemdanhsach frm = new xemdanhsach("loaiphong");
            frm.Show();
        }

        private void xemDanhSáchThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtimphong frm = new frmtimphong("phong");
            frm.Show();
        }

        private void xemDanhSáchDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemdanhsach frm = new xemdanhsach("dichvu");
            frm.Show();
        }
    }
}
