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
    public partial class frmnhap_ctdichvu : Form
    {
        DataTable Table;
        String sohd, madv;
        frmnhapdichvu instance;
        Thread t1;
        TcpClient tcpclient;
        bool kt = false;
        int y, dongxoa;
        public static bool kt2 = false;
        bool kt3 = false;
        frmSystem frm;

        public frmnhap_ctdichvu(String sohd, String madv, frmnhapdichvu instance, frmSystem frm)
        {
            InitializeComponent();
            this.sohd = sohd;
            this.madv = madv;
            this.instance = instance;
            this.frm = frm;
        }

        private void frmnhap_ctdichvu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(kt3)
            {
                BUS_nhapdichvu.DAO.huyhd(sohd);
                instance.Show();
                t1.Abort();
            }   
            else
            {
                if (kt2)
                {
                    instance.Show();
                    t1.Abort();
                }
                else
                {
                    if (kt)
                    {
                        BUS_nhapdichvu.DAO.huyhd(sohd);
                        t1.Abort();
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            BUS_nhapdichvu.DAO.huyhd(sohd);
                            t1.Abort();
                            instance.Show();
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                }
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            BUS_nhapdichvu.DAO.nhapdichvu(dgv, sohd, this, frm);
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgv.Rows[dgv.RowCount - 1].Cells[0].Value = dgv.RowCount;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex > -1 && e.RowIndex < dgv.Rows.Count - 1)
            {
                xoa.Show(new Point(Left, y));
            }
        }

        private void dgv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dongxoa = e.RowIndex;
        }

        private void xoa_Opening(object sender, CancelEventArgs e)
        {

        }

        void resetstt(int dongx)
        {
            for (int i = dongx; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv.Rows.RemoveAt(dongxoa);
                resetstt(dongxoa);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa dòng này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.WriteLine("error");
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Table = BUS_nhapdichvu.DAO.luudata(dgv, Table);
        }

        private void dgv_MouseDown(object sender, MouseEventArgs e)
        {
            y = e.Y;
        }

        private void frmnhap_ctdichvu_Load(object sender, EventArgs e)
        {
            Table = new DataTable();
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
                            kt = true;
                            this.Close();
                        }));
                    }
                    else
                    {
                        if (content == "xoadonvi")
                        {
                            Invoke(new Action(() =>
                            {
                                kt3 = true;
                                this.Close();
                            }));
                        }
                        else
                        {
                            if(content == "themdichvu")
                            {
                                Invoke(new Action(() =>
                                {
                                    dgv.CellValueChanged -= dgv_CellValueChanged;
                                    kt3 = BUS_nhapdichvu.DAO.capnhap(dgv, Table, kt3);
                                    if (kt3)
                                        this.Close();
                                    Table = BUS_nhapdichvu.DAO.luudata(dgv, Table);
                                    dgv.CellValueChanged += dgv_CellValueChanged;
                                }));
                            }    
                            else
                            {
                                if (content == "suadichvu")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        dgv.CellValueChanged -= dgv_CellValueChanged;
                                        kt3 = BUS_nhapdichvu.DAO.capnhap(dgv, Table, kt3);
                                        if (kt3)
                                            this.Close();
                                        Table = BUS_nhapdichvu.DAO.luudata(dgv, Table);
                                        dgv.CellValueChanged += dgv_CellValueChanged;
                                    }));
                                }
                                else
                                {
                                    if (content == "xoadichvu")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            dgv.CellValueChanged -= dgv_CellValueChanged;
                                            kt3 = BUS_nhapdichvu.DAO.capnhap(dgv, Table, kt3);
                                            if (kt3)
                                                this.Close();
                                            Table = BUS_nhapdichvu.DAO.luudata(dgv, Table);
                                            dgv.CellValueChanged += dgv_CellValueChanged;
                                        }));
                                    }
                                }    
                            }    
                        }    
                    }
                }
            });
            t1.Start();
            kt3 = BUS_nhapdichvu.DAO.loadbangdv(dgv, this, kt3);
            if (kt3)
                this.Close();
        }
    }
}
