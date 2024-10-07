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
    public partial class frmsua_don_vi : Form
    {
        frmsua_don_vi instance;
        String madv;
        Thread t1;
        TcpClient tcpclient;
        frmSystem frm;

        public frmsua_don_vi(String ma, frmSystem frm)
        {
            InitializeComponent();
            madv = ma;
            instance = this;
            this.frm = frm;
        }

        private void frmsua_don_vi_Load(object sender, EventArgs e)
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
                        if (content == "xoadonvi")
                        {
                            Invoke(new Action(() =>
                            {
                                BUS_donvi.DAO.load(madv, txtten, txtsdt, txtdc, instance);
                            }));
                        }
                        else
                        {
                            if (content == "suadonvi")
                            {
                                Invoke(new Action(() =>
                                {
                                    BUS_donvi.DAO.load(madv, txtten, txtsdt, txtdc, instance);
                                }));
                            }
                        }
                    }
                }
            });
            t1.Start();
            BUS_donvi.DAO.load(madv, txtten, txtsdt, txtdc, this);
        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {
            if(txtsdt.Text.Length >= 3)
            {
                if(txtsdt.Text.Substring(0,3) == "+84")
                {
                    if (txtsdt.Text.Length > 3)
                        txtsdt.Text = "0" + txtsdt.Text.Substring(3);
                    else
                        txtsdt.Text = "0";
                    txtsdt.SelectionStart = 1;
                }    
            }    
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            BUS_donvi.DAO.sua(madv, txtten, txtsdt, txtdc, this);
        }

        private void frmsua_don_vi_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }
    }
}
