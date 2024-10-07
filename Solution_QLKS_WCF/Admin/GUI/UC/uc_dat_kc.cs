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

namespace Admin.GUI.UC
{
    public partial class uc_dat_kc : UserControl
    {
        String maphong;
        frm_thue_dat_phong frm;
        Thread t1;
        TcpClient tcpclient;
        frmSystem frmsys;

        public uc_dat_kc(String ma, frm_thue_dat_phong frm, frmSystem frmsys)
        {
            InitializeComponent();
            this.maphong = ma;
            this.frm = frm;
            this.frmsys = frmsys;
        }

        private void uc_dat_kc_Load(object sender, EventArgs e)
        {
            BUS_thuedatphong.DAO.loadkh(cbxcustomer);
            tcpclient = new TcpClient();
            tcpclient.Connect(config.ipsocket, config.portsocket);
            BUS_Login.DAO.themsocket(frmsys.user.Trim());
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
                catch(Exception)
                {
                    Console.WriteLine("a");
                }
            });
            t1.Start();
        }

        private void btndat_Click(object sender, EventArgs e)
        {
            BUS_thuedatphong.DAO.datphong(cbxcustomer, datego, maphong, frm);
        }

        private void cbxcustomer_TextChanged(object sender, EventArgs e)
        {
            if (cbxcustomer.SelectedIndex == -1)
                cbxcustomer.SelectedIndex = 0;
        }
    }
}
