using ADMIN2.BUS;
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

namespace ADMIN2.GUI
{
    public partial class frmSystem : Form
    {
        Thread t1;
        public static String user;
        int port = 222;
        TcpClient tcpclient;
        public frmSystem(String us)
        {
            InitializeComponent();
            user = us.Trim();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.qlks.dangxuat(user.Trim());
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.qlks.dangxuat(user.Trim());
            Process[] pro = Process.GetProcesses();
            foreach (var pc in pro)
                if (pc.ProcessName == this.ProductName.ToString())
                    pc.Kill();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.Show();
        }

        private void frmSystem_Load(object sender, EventArgs e)
        {
            tcpclient = new TcpClient();
            tcpclient.Connect("192.168.0.196", port);
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
                }
            });
            t1.Start();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmadd frm = new frmadd("nhanvien");
            frm.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsearch frm = new frmsearch("nhanvien");
            frm.Show();
        }

        private void frmSystem_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Program.qlks.dangxuat(user.Trim());
            t1.Abort();
        }
    }
}
