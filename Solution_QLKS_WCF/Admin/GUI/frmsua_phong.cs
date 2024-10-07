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
    public partial class frmsua_phong : Form
    {
        frmsua_phong instance;
        String map;
        Thread t1;
        TcpClient tcpclient;
        frmSystem frm;

        public frmsua_phong(String ma, frmSystem frm)
        {
            InitializeComponent();
            map = ma;
            instance = this;
            this.frm = frm;
        }

        private void frmsua_phong_Load(object sender, EventArgs e)
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
                        if (content == "xoaloaiphong")
                        {
                            Invoke(new Action(() =>
                            {
                                BUS_phong.DAO.loadlp(cbxloai, instance);
                                BUS_phong.DAO.load(map, txtten, cbxloai, instance);
                            }));
                        }
                        else
                        {
                            if (content == "sualoaiphong")
                            {
                                Invoke(new Action(() =>
                                {
                                    BUS_phong.DAO.loadlp(cbxloai, instance);
                                    BUS_phong.DAO.load(map, txtten, cbxloai, instance);
                                }));
                            }
                            else
                            {
                                if (content == "themloaiphong")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        BUS_phong.DAO.loadlp(cbxloai, instance);
                                        BUS_phong.DAO.load(map, txtten, cbxloai, instance);
                                    }));
                                }
                                else
                                {
                                    if (content == "xoaphong")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            BUS_phong.DAO.loadlp(cbxloai, instance);
                                            BUS_phong.DAO.load(map, txtten, cbxloai, instance);
                                        }));
                                    }
                                    else
                                    {
                                        if (content == "suaphong")
                                        {
                                            Invoke(new Action(() =>
                                            {
                                                BUS_phong.DAO.loadlp(cbxloai, instance);
                                                BUS_phong.DAO.load(map, txtten, cbxloai, instance);
                                            }));
                                        }
                                    }    
                                }    
                            }    
                        }
                    }
                }
            });
            t1.Start();
            BUS_phong.DAO.loadlp(cbxloai, instance);
            BUS_phong.DAO.load(map, txtten, cbxloai, instance);
        }

        private void frmsua_phong_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            BUS_phong.DAO.sua(map, txtten, cbxloai, this);
        }
    }
}
