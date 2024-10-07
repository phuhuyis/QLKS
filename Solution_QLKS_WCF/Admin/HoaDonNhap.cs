using Admin.BUS;
using Admin.GUI;
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

namespace Admin
{
    public partial class HoaDonNhap : Form
    {
        String sohd;
        TcpClient tcpclient;
        Thread t1;
        frmSystem frm;

        public HoaDonNhap(String sohd, frmSystem frm)
        {
            InitializeComponent();
            this.sohd = sohd;
            this.frm = frm;
        }

        private void HoaDonNhap_Load(object sender, EventArgs e)
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
                        if (content == "suadonvi")
                        {
                            Invoke(new Action(() =>
                            {
                                //this.xemhoadonnhapTableAdapter.Fill(this.QLKSDataSet.xemhoadonnhap, sohd);
                                this.xemhoadonnhapBindingSource.DataSource = Program.qlks.inhd(sohd);

                                this.reportViewer1.RefreshReport();
                            }));
                        }
                        else
                        {
                            if (content == "xoadonvi")
                            {
                                Invoke(new Action(() =>
                                {
                                    //this.xemhoadonnhapTableAdapter.Fill(this.QLKSDataSet.xemhoadonnhap, sohd);
                                    this.xemhoadonnhapBindingSource.DataSource = Program.qlks.inhd(sohd);

                                    this.reportViewer1.RefreshReport();
                                }));
                            }
                            else
                            {
                                if (content == "suadichvu")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        //this.xemhoadonnhapTableAdapter.Fill(this.QLKSDataSet.xemhoadonnhap, sohd);
                                        this.xemhoadonnhapBindingSource.DataSource = Program.qlks.inhd(sohd);

                                        this.reportViewer1.RefreshReport();
                                    }));
                                }
                                else
                                {
                                    if (content == "xoadichvu")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            //this.xemhoadonnhapTableAdapter.Fill(this.QLKSDataSet.xemhoadonnhap, sohd);
                                            this.xemhoadonnhapBindingSource.DataSource = Program.qlks.inhd(sohd);
                                            this.reportViewer1.RefreshReport();
                                        }));
                                    }
                                }
                            }
                        }
                    }
                }
            });
            t1.Start();
            QLKSDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'QLKSDataSet.xemhoadonnhap' table. You can move, or remove it, as needed.
            //this.xemhoadonnhapTableAdapter.Fill(this.QLKSDataSet.xemhoadonnhap, sohd);
            this.xemhoadonnhapBindingSource.DataSource = Program.qlks.inhd(sohd);
            //this.xemhoadonnhapTableAdapter.Fill(this.QLKSDataSet.xemhoadonnhap, sohd);

            this.reportViewer1.RefreshReport();
        }

        private void HoaDonNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }
    }
}
