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
    public partial class frmnhapdichvu : Form
    {
        frmnhapdichvu instance;
        Thread t1;
        TcpClient tcpclient;
        int position = 0;
        frmSystem frm;

        public frmnhapdichvu(frmSystem frm)
        {
            InitializeComponent();
            instance = this;
            this.frm = frm;
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            if(BUS_nhapdichvu.DAO.ktdv())
            {
                frmnhap_ctdichvu frm = new frmnhap_ctdichvu(BUS_nhapdichvu.DAO.taosohd(position), BUS_nhapdichvu.DAO.laymadv(position), instance, this.frm);
                this.Hide();
                frm.Show();
            }    
            else
            {
                MessageBox.Show("Chưa thêm dịch vụ nào cả, hãy thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void frmnhapdichvu_Load(object sender, EventArgs e)
        {
            BUS_nhapdichvu.DAO.loaddvcc(txtdv, this);
            txtdv.SelectedIndex = 0;
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
                                BUS_nhapdichvu.DAO.loaddvcc(txtdv, instance);
                                if(txtdv.Items.Count > 0)
                                    txtdv.SelectedIndex = 0;
                            }));
                        }
                        else
                        {
                            if (content == "suadonvi")
                            {
                                Invoke(new Action(() =>
                                {
                                    BUS_nhapdichvu.DAO.loaddvcc(txtdv, instance);
                                    txtdv.SelectedIndex = position;
                                }));
                            }
                            else
                            {
                                if (content == "themdonvi")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        BUS_nhapdichvu.DAO.loaddvcc(txtdv, instance);
                                        txtdv.SelectedIndex = position;
                                    }));
                                }
                            }
                        }
                    }
                }
            });
            t1.Start();
        }

        private void txtdv_TextChanged(object sender, EventArgs e)
        {
            if(txtdv.SelectedIndex == -1)
            {
                txtdv.SelectedIndex = 0;
                position = 0;
            }
        }

        private void txtdv_SelectedIndexChanged(object sender, EventArgs e)
        {
            position = txtdv.SelectedIndex;
        }

        private void frmnhapdichvu_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }
    }
}
