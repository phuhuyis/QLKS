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
    public partial class frmchange_info_employee : Form
    {
        Thread t1;
        TcpClient tcpclient;
        String manv;
        frmSystem frm;

        public frmchange_info_employee(String ma, frmSystem frm)
        {
            InitializeComponent();
            manv = ma;
            this.frm = frm;
        }

        private void frmchange_info_employee_Load(object sender, EventArgs e)
        {
            BUS_nhanvien.DAO.laydl(manv, txtma, txtten, txtngaysinh, txtgioitinh, txtdiachi, txtsdt, txtca, txttt, txtlcb, txthsl);
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
                        if(content == "capnhapnv")
                        {
                            Invoke(new Action(() =>
                            {
                                BUS_nhanvien.DAO.laydl(manv, txtma, txtten, txtngaysinh, txtgioitinh, txtdiachi, txtsdt, txtca, txttt, txtlcb, txthsl);
                            }));
                        } 
                        else
                        {
                            if (content == "x" + manv)
                            {
                                Invoke(new Action(() =>
                                {
                                    this.Close();
                                }));
                            }
                        }    
                    }    
                }
            });
            t1.Start();
        }

        private void txtma_Enter(object sender, EventArgs e)
        {
            txtten.Focus();
        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {
            if((sender as TextBox).Text.Length >= 3)
            {
                if ((sender as TextBox).Text.Substring(0, 3) == "+84")
                {
                    (sender as TextBox).Text = "0" + (sender as TextBox).Text.Substring(3);
                    (sender as TextBox).SelectionStart = 1;
                }
            }
        }

        private void txtgioitinh_TextChanged(object sender, EventArgs e)
        {
            if (txtgioitinh.SelectedIndex == -1)
                txtgioitinh.SelectedIndex = 0;
        }

        private void txtca_TextChanged(object sender, EventArgs e)
        {
            if (txtca.SelectedIndex == -1)
                txtca.SelectedIndex = 0;
        }

        private void txttt_TextChanged(object sender, EventArgs e)
        {
            if (txttt.SelectedIndex == -1)
                txttt.SelectedIndex = 0;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            BUS_nhanvien.DAO.capnhap(this, txtma, txtten, txtngaysinh, txtgioitinh, txtdiachi, txtsdt, txtca, txttt, txtlcb, txthsl);
        }

        private void frmchange_info_employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }
    }
}
