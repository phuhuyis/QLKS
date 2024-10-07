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
    public partial class frmXemdanhsach : Form
    {
        String chucnang;
        Thread t1;
        TcpClient tcpclient;
        public frmXemdanhsach(String cn)
        {
            InitializeComponent();
            chucnang = cn;
        }

        private void frmXemdanhsach_Load(object sender, EventArgs e)
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
                        if (content == "suathietbi")
                        {
                            Invoke(new Action(() =>
                            {
                                BUS_phong.DAO.loadbang(chucnang, dgv, this);
                            }));
                        }
                        else
                        {
                            if (content == "xoathietbi")
                            {
                                Invoke(new Action(() =>
                                {
                                    BUS_phong.DAO.loadbang(chucnang, dgv, this);
                                }));
                            }
                            else
                            {
                                if (content == "xoaphong")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        BUS_phong.DAO.loadbang(chucnang, dgv, this);
                                    }));
                                }
                                else
                                {
                                    if (content == "sapxeptb")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            BUS_phong.DAO.loadbang(chucnang, dgv, this);
                                        }));
                                    }
                                }
                            }
                        }
                    }
                }
            });
            t1.Start();
            BUS_phong.DAO.loadbang(chucnang, dgv, this);
        }

        private void frmXemdanhsach_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }
    }
}
