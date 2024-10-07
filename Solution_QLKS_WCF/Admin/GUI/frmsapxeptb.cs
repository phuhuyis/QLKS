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
    public partial class frmsapxeptb : Form
    {
        DataTable Table;
        String ma;
        Thread t1;
        TcpClient tcpclient;
        int y, dongxoa;
        frmSystem frm;

        public frmsapxeptb(String ma, frmSystem frm)
        {
            InitializeComponent();
            this.ma = ma;
            this.frm = frm;
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

        private void dgv_MouseDown(object sender, MouseEventArgs e)
        {
            y = e.Y;
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dongxoa = e.RowIndex;
        }

        private void frmsapxeptb_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        private void frmsapxeptb_Load(object sender, EventArgs e)
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
                        if (content == "themthietbi")
                        {
                            Invoke(new Action(() =>
                            {
                                dgv.CellValueChanged -= dgv_CellValueChanged;
                                BUS_phong.DAO.capnhap(ma, dgv, this, Table);
                                Table = BUS_phong.DAO.luudata(dgv, Table);
                                dgv.CellValueChanged += dgv_CellValueChanged;
                            }));
                        }
                        else
                        {
                            if (content == "suathietbi")
                            {
                                Invoke(new Action(() =>
                                {
                                    dgv.CellValueChanged -= dgv_CellValueChanged;
                                    BUS_phong.DAO.capnhap(ma, dgv, this, Table);
                                    Table = BUS_phong.DAO.luudata(dgv, Table);
                                    dgv.CellValueChanged += dgv_CellValueChanged;
                                }));
                            }
                            else
                            {
                                if (content == "xoathietbi")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        dgv.CellValueChanged -= dgv_CellValueChanged;
                                        BUS_phong.DAO.capnhap(ma, dgv, this, Table);
                                        Table = BUS_phong.DAO.luudata(dgv, Table);
                                        dgv.CellValueChanged += dgv_CellValueChanged;
                                    }));
                                }
                                else
                                {
                                    if (content == "xoaphong")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            dgv.CellValueChanged -= dgv_CellValueChanged;
                                            BUS_phong.DAO.capnhap(ma, dgv, this, Table);
                                            Table = BUS_phong.DAO.luudata(dgv, Table);
                                            dgv.CellValueChanged += dgv_CellValueChanged;
                                        }));
                                    }
                                    else
                                    {
                                        if (content == "sapxeptb")
                                        {
                                            Invoke(new Action(() =>
                                            {
                                                dgv.CellValueChanged -= dgv_CellValueChanged;
                                                BUS_phong.DAO.loadbang(ma, dgv, this);
                                                Table = BUS_phong.DAO.luudata(dgv, Table);
                                                dgv.CellValueChanged += dgv_CellValueChanged;
                                            }));
                                        }
                                    }    
                                }    
                            }    
                        }    
                    }    
                }
            });
            t1.Start();
            BUS_phong.DAO.loadbang(ma, dgv, this);
            Table = BUS_phong.DAO.luudata(dgv, Table);
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

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Table = BUS_phong.DAO.luudata(dgv, Table);
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.WriteLine("error");
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            BUS_phong.DAO.them2(ma, dgv);
        }

        void resetstt(int dongx)
        {
            for (int i = dongx; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}
