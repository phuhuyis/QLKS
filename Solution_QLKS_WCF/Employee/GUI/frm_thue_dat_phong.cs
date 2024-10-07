using Employee.BUS;
using Employee.GUI.UC;
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
    public partial class frm_thue_dat_phong : Form
    {
        String sophong, lk;
        uc_dat_kc datc;
        uc_dat_km datm = null;
        uc_thue_kc thuec;
        uc_thue_km thuem = null;
        Thread t1;
        TcpClient tcpclient;

        public frm_thue_dat_phong(String so, String c)
        {
            InitializeComponent();
            sophong = so;
            lk = c;
        }

        private void btnthue_Click(object sender, EventArgs e)
        {
            btnthue.BackColor = Color.FromArgb(0, 0, 192);
            btndat.BackColor = Color.Blue;
            BUS_thuedatphong.DAO.loadthue(datm, thuem, datc, thuec, lk, this, sophong);
        }

        private void btndat_Click(object sender, EventArgs e)
        {
            btndat.BackColor = Color.FromArgb(0, 0, 192);
            btnthue.BackColor = Color.Blue;
            BUS_thuedatphong.DAO.loaddat(datm, thuem, datc, thuec, lk, this, sophong);
        }

        private void frm_thue_dat_phong_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        private void frm_thue_dat_phong_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width + 20, Screen.PrimaryScreen.WorkingArea.Height + 20);
            this.WindowState = FormWindowState.Maximized;
            int a = 1539 / 2;
            btndat.Width = a + 1;
            btndat.Height = 70;
            btndat.Location = new Point(0, 0);
            btnthue.Height = 70;
            btnthue.Width = a;
            btnthue.Location = new Point(a, 0);
            BUS_thuedatphong.DAO.loaddat(datm, thuem, datc, thuec, lk, this, sophong);
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
                    if(content.Contains("datphongkc"))
                    {
                        if(content == "datphongkc" + sophong)
                        {
                            Invoke(new Action(() =>
                            {
                                this.Close();
                            }));
                        }
                    }
                    if(content == "xoaphong")
                    {
                        if(!BUS_thuedatphong.DAO.kiemtraphong(sophong))
                        {
                            Invoke(new Action(() =>
                            {
                                this.Close();
                            }));
                        }
                    }
                    if (content.Contains("thuephongkc"))
                    {
                        if (content == "thuephongkc" + sophong)
                        {
                            Invoke(new Action(() =>
                            {
                                this.Close();
                            }));
                        }
                    }
                }
            });
            t1.Start();
        }
    }
}
