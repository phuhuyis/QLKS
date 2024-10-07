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
    public partial class frmsua_loai_phong : Form
    {
        frmsua_loai_phong instance;
        String malp;
        Thread t1;
        TcpClient tcpclient;
        frmSystem frm;

        public frmsua_loai_phong(String ma, frmSystem frm)
        {
            InitializeComponent();
            malp = ma;
            this.frm = frm;
            instance = this;
        }

        private void frmsua_loai_phong_Load(object sender, EventArgs e)
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
                                BUS_loaiphong.DAO.load(malp, txtten, gia, instance);
                            }));
                        }
                        else
                        {
                            if (content == "sualoaiphong")
                            {
                                Invoke(new Action(() =>
                                {
                                    BUS_loaiphong.DAO.load(malp, txtten, gia, instance);
                                }));
                            }
                        }
                    }
                }
            });
            t1.Start();
            BUS_loaiphong.DAO.load(malp, txtten, gia, instance);
        }

        private void frmsua_loai_phong_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            BUS_loaiphong.DAO.sua(malp, txtten, gia, this);
        }
    }
}
