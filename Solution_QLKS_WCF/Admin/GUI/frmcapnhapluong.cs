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
    public partial class frmcapnhapluong : Form
    {
        public static frmcapnhapluong instance;
        String maphieu;
        Thread t1;
        TcpClient tcpclient;
        frmSystem frm;

        public frmcapnhapluong(String maph, frmSystem frm)
        {
            InitializeComponent();
            maphieu = maph;
            instance = this;
            this.frm = frm;
        }

        private void frmcapnhapluong_Load(object sender, EventArgs e)
        {
            BUS_luong.DAO.loadluongcn(txtma, txtten, txtsongaynghi, txttt, maphieu, instance);
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
                        if (content == "capnhapluong")
                        {
                            Invoke(new Action(() =>
                            {
                                BUS_luong.DAO.loadluongcn(txtma, txtten, txtsongaynghi, txttt, maphieu, instance);
                            }));
                        }
                        else
                        {
                            if (content == "xoaluong")
                            {
                                Invoke(new Action(() =>
                                {
                                    BUS_luong.DAO.loadluongcn(txtma, txtten, txtsongaynghi, txttt, maphieu, instance);
                                }));
                            }
                            else
                            {
                                if (content == "capnhapnv")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        BUS_luong.DAO.loadluongcn(txtma, txtten, txtsongaynghi, txttt, maphieu, instance);
                                    }));
                                }
                                else
                                {
                                    if (content == "xoanv")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            BUS_luong.DAO.loadluongcn(txtma, txtten, txtsongaynghi, txttt, maphieu, instance);
                                        }));
                                    }
                                }    
                            }    
                        }    
                    }    
                }
            });
            t1.Start();
        }

        private void txtma_Enter(object sender, EventArgs e)
        {
            txtsongaynghi.Focus();
        }

        private void txtten_Enter(object sender, EventArgs e)
        {
            txtsongaynghi.Focus();
        }

        private void frmcapnhapluong_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            BUS_luong.DAO.capnhapluong(txtsongaynghi, txttt, maphieu);
            MessageBox.Show("Lưu thành công");
            this.Close();
        }
    }
}
