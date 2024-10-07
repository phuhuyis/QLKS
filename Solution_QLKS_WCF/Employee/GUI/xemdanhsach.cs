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
    public partial class xemdanhsach : Form
    {
        String chucnang;
        Thread t1;
        TcpClient tcpclient;
        public xemdanhsach(String cn)
        {
            InitializeComponent();
            chucnang = cn;
        }

        private void xemdanhsach_Load(object sender, EventArgs e)
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
                        if(chucnang == "loaiphong")
                        {
                            if (content == "themloaiphong")
                            {
                                Invoke(new Action(() =>
                                {
                                    BUS_loaiphong.DAO.search("", dgv);
                                }));
                            }
                            else
                            {
                                if (content == "sualoaiphong")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        BUS_loaiphong.DAO.search("", dgv);
                                    }));
                                }
                                else
                                {
                                    if (content == "xoaloaiphong")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            BUS_loaiphong.DAO.search("", dgv);
                                        }));
                                    }
                                }    
                            }    
                        }
                        else
                        {
                            if (chucnang == "dichvu")
                            {
                                if (content == "themdichvu")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        BUS_dichvu.DAO.search("", dgv);
                                    }));
                                }
                                else
                                {
                                    if (content == "suadichvu")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            BUS_dichvu.DAO.search("", dgv);
                                        }));
                                    }
                                    else
                                    {
                                        if (content == "xoadichvu")
                                        {
                                            Invoke(new Action(() =>
                                            {
                                                BUS_dichvu.DAO.search("", dgv);
                                            }));
                                        }
                                        else
                                        {
                                            if (content == "nhapdichvu")
                                            {
                                                Invoke(new Action(() =>
                                                {
                                                    BUS_dichvu.DAO.search("", dgv);
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
            if (chucnang == "loaiphong")
            {
                this.Text += "Danh sách loại phòng";
                BUS_loaiphong.DAO.search("", dgv);
            }
            else
            {
                if (chucnang == "dichvu")
                {
                    this.Text += "Danh sách dịch vụ";
                    BUS_dichvu.DAO.search("", dgv);
                }
            }    
        }

        private void xemdanhsach_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }
    }
}
