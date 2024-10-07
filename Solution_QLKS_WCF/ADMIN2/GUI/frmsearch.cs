using ADMIN2.BUS;
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

namespace ADMIN2.GUI
{
    public partial class frmsearch : Form
    {
        String chucnang;
        int port = 222;
        TcpClient tcpclient;
        Thread t1;
        String key = "";
        bool kt = false;
        public frmsearch(String cn)
        {
            InitializeComponent();
            chucnang = cn;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text.Trim() == "Tìm kiếm...")
            {
                key = "";
            }
            else
            {
                key = txttimkiem.Text.Trim();
            }
            BUS_nhanvien.DAO.search(key, dgv);
            kt = true;
        }

        private void frmsearch_Load(object sender, EventArgs e)
        {
            tcpclient = new TcpClient();
            tcpclient.Connect("192.168.0.196", port);
            BUS_Login.DAO.themsocket(frmSystem.user.Trim());
            t1 = new Thread(() =>
            {
                while(true)
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
                        if (content == "themnv")
                        {
                            Invoke(new Action(() =>
                            {
                                if(kt)
                                    BUS_nhanvien.DAO.search(key, dgv);
                            }));
                        }
                    }
                }    
            });
            t1.Start();
            if (chucnang == "nhanvien")
            {
                this.Text += "nhân viên";
            }
        }

        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (txttimkiem.Text.Trim() == "Tìm kiếm...")
            {
                txttimkiem.Text = "";
                txttimkiem.ForeColor = Color.Black;
            }
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (txttimkiem.Text.Trim() == "")
            {
                txttimkiem.Text = "Tìm kiếm...";
                txttimkiem.ForeColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv.ColumnCount - 1)
            {
                if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                {
                    MessageBox.Show("Việc xóa nhân viên sẽ xóa hết những dữ liệu về lương và xóa thông tin của nhân viên trong hóa đơn, hãy cân nhắc thao tác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên " + dgv.Rows[e.RowIndex].Cells[1].Value.ToString() + " hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        BUS_nhanvien.DAO.xoanv(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }
                }
            }
            if (e.ColumnIndex == dgv.ColumnCount - 2)
            {
                if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                {
                    frmchange_info_employee frm = new frmchange_info_employee(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                    frm.Show();
                }
            }
        }

        private void frmsearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }
    }
}
