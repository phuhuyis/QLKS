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
    public partial class frm_sua_thietbi : Form
    {
        frm_sua_thietbi instance;
        String map;
        Thread t1;
        TcpClient tcpclient;
        frmSystem frm;

        public frm_sua_thietbi(String ma, frmSystem frm)
        {
            InitializeComponent();
            map = ma;
            instance = this;
            this.frm = frm;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                comboBox1.SelectedIndex = 0;
        }

        private void frm_sua_thietbi_Load(object sender, EventArgs e)
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
                        if (content == "xoathietbi")
                        {
                            Invoke(new Action(() =>
                            {
                                BUS_thietbi.DAO.load(map, txtten, gia, comboBox1, instance);
                            }));
                        }
                        else
                        {
                            if (content == "suathietbi")
                            {
                                Invoke(new Action(() =>
                                {
                                    BUS_thietbi.DAO.load(map, txtten, gia, comboBox1, instance);
                                }));
                            }
                        }
                    }
                }
            });
            t1.Start();
            BUS_thietbi.DAO.load(map, txtten, gia, comboBox1, instance);
        }

        private void frm_sua_thietbi_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            BUS_thietbi.DAO.sua(map, txtten, gia, comboBox1, this);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                comboBox1.SelectedIndex = 0;
        }
    }
}
