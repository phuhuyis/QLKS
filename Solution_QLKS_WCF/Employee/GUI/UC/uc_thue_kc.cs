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

namespace Employee.GUI.UC
{
    public partial class uc_thue_kc : UserControl
    {
        String maphong;
        frm_thue_dat_phong frm;
        Thread t1;
        TcpClient tcpclient;

        public uc_thue_kc(String ma, frm_thue_dat_phong frm)
        {
            InitializeComponent();
            this.maphong = ma;
            this.frm = frm;
        }

        private void uc_thue_kc_Load(object sender, EventArgs e)
        {
            BUS_thuedatphong.DAO.loadkh(cbxcustomer);
            tcpclient = new TcpClient();
            tcpclient.Connect(config.ipsocket, config.portsocket);
            BUS_Login.DAO.themsocket(frmSystem.user.Trim());
            t1 = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        Stream stream = tcpclient.GetStream();
                        var reader = new StreamReader(stream);
                        var writer = new StreamWriter(stream);
                        writer.AutoFlush = true;
                        String content = reader.ReadLine();

                        if (content == "themkhachhang")
                        {
                            Invoke(new Action(() =>
                            {
                                BUS_thuedatphong.DAO.loadkh(cbxcustomer);
                            }));
                        }
                        else
                        {
                            if (content == "suakhachhang")
                            {
                                Invoke(new Action(() =>
                                {
                                    BUS_thuedatphong.DAO.loadkh(cbxcustomer);
                                }));
                            }
                            else
                            {
                                if (content == "xoakhachhang")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        BUS_thuedatphong.DAO.loadkh(cbxcustomer);
                                    }));
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("a");
                }
            });
            t1.Start();
        }

        private void cbxcustomer_TextChanged(object sender, EventArgs e)
        {
            if (cbxcustomer.SelectedIndex == -1)
                cbxcustomer.SelectedIndex = 0;
        }

        private void btnthue_Click(object sender, EventArgs e)
        {
            BUS_thuedatphong.DAO.thuephong(cbxcustomer, maphong, frmSystem.user, frm);
        }
    }
}
