using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee.BUS;

namespace Employee.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void cbxmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxmatkhau.Checked)
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtmatkhau.UseSystemPasswordChar = true;
            }    
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Process[] pro = Process.GetProcesses();
            foreach (var pc in pro)
                if (pc.ProcessName == this.ProductName.ToString())
                    pc.Kill();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(BUS_Login.DAO.dangnhap(txttendangnhap.Text.Trim(), txtmatkhau.Text.Trim()))
            {
                frmSystem frm = new frmSystem(txttendangnhap.Text.Trim());
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }

        private void txttendangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnlogin_Click(sender, e);
            }
        }

        private void txtmatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnlogin_Click(sender, e);
            }
        }
    }
}
