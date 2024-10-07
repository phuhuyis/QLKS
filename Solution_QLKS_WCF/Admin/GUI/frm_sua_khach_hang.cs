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
    public partial class frm_sua_khach_hang : Form
    {
        frm_sua_khach_hang instance;
        String map;
        Thread t1;
        TcpClient tcpclient;
        frmSystem frm;
        public frm_sua_khach_hang(String ma, frmSystem frm)
        {
            InitializeComponent();
            map = ma;
            instance = this;
            this.frm = frm;
        }

        private void frm_sua_khach_hang_Load(object sender, EventArgs e)
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
                        if (content == "xoakhachhang")
                        {
                            Invoke(new Action(() =>
                            {
                                BUS_khachhang.DAO.load(map, txtten, txtcmnd, instance);
                            }));
                        }
                        else
                        {
                            if (content == "suakhachhang")
                            {
                                Invoke(new Action(() =>
                                {
                                    BUS_khachhang.DAO.load(map, txtten, txtcmnd, instance);
                                }));
                            }
                        }
                    }
                }
            });
            t1.Start();
            BUS_khachhang.DAO.load(map, txtten, txtcmnd, instance);
        }

        private void frm_sua_khach_hang_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            BUS_khachhang.DAO.sua(map, txtten, txtcmnd, this);
        }
    }
}
