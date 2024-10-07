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
using ADMIN2.BUS;

namespace ADMIN2.GUI
{
    public partial class frmChangePassword : Form
    {
        Thread t1;
        int port = 222;
        TcpClient tcpclient;
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void txtmatkhaucu_Enter(object sender, EventArgs e)
        {
            
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            tcpclient = new TcpClient();
            tcpclient.Connect("192.168.0.196", port);
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
                }
            });
			t1.Start();
		}

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            BUS_Login.DAO.doimatkhau(txtmatkhaucu, txtmatkhaumoi, txtnhaplaimatkhau);
        }

        private void frmChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }
    }
}
