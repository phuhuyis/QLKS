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
    public partial class frmadd : Form
    {
        DataTable Table;
        String chucnang;
        Thread t1;
        TcpClient tcpclient;
        int y, dongxoa;
        frmSystem frm;

        public frmadd(String cn, frmSystem frm)
        {
            InitializeComponent();
            chucnang = cn;
            this.frm = frm;
        }

        private void frmadd_Load(object sender, EventArgs e)
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
                            this.Close();
                        }));
                    }
                    if(chucnang == "phong")
                    {
                        if (content == "xoaloaiphong")
                        {
                            Invoke(new Action(() =>
                            {
                                dgv.CellValueChanged -= dgv_CellValueChanged;
                                BUS_phong.DAO.capnhapdata(dgv, this, Table);
                                Table = BUS_phong.DAO.luu(dgv, Table);
                                dgv.CellValueChanged += dgv_CellValueChanged;
                            }));
                        }
                        else
                        {
                            if (content == "themloaiphong")
                            {
                                Invoke(new Action(() =>
                                {
                                    dgv.CellValueChanged -= dgv_CellValueChanged;
                                    BUS_phong.DAO.capnhapdata(dgv, this, Table);
                                    Table = BUS_phong.DAO.luu(dgv, Table);
                                    dgv.CellValueChanged += dgv_CellValueChanged;
                                }));
                            }
                            else
                            {
                                if (content == "sualoaiphong")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        dgv.CellValueChanged -= dgv_CellValueChanged;
                                        BUS_phong.DAO.capnhapdata(dgv, this, Table);
                                        Table = BUS_phong.DAO.luu(dgv, Table);
                                        dgv.CellValueChanged += dgv_CellValueChanged;
                                    }));
                                }
                            }    
                        }    
                    }    
                }
            });
            t1.Start();
            if (chucnang == "nhanvien")
            {
                this.Text += "nhân viên";
                BUS_nhanvien.DAO.loadbangnv(dgv);
            }
            else
            {
                if(chucnang == "donvi")
                {
                    this.Text += "đơn vị cung cấp";
                    BUS_donvi.DAO.loadbangdv(dgv);
                }   
                else
                {
                    if(chucnang == "loaiphong")
                    {
                        this.Text += "loại phòng";
                        BUS_loaiphong.DAO.loadbangdv(dgv);
                    }  
                    else
                    {
                        if (chucnang == "phong")
                        {
                            this.Text += "phòng";
                            BUS_phong.DAO.loadbangdv(dgv, this);
                        }
                        else
                        {
                            if(chucnang == "thietbi")
                            {
                                this.Text += "thiết bị";
                                BUS_thietbi.DAO.loadbangdv(dgv, this);
                            }    
                            else
                            {
                                if(chucnang == "dichvu")
                                {
                                    this.Text += "dịch vụ";
                                    BUS_dichvu.DAO.loadbangdv(dgv, this);
                                }    
                                else
                                {
                                    if (chucnang == "khachhang")
                                    {
                                        this.Text += "khách hàng";
                                        BUS_khachhang.DAO.loadbangdv(dgv, this);
                                    }
                                }
                            }    
                        }    
                    }    
                }    
            }    
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

        private void btnluu_Click(object sender, EventArgs e)
        {
            if(chucnang == "nhanvien")
            {
                BUS_nhanvien.DAO.themnv(dgv, frm.user);
            }    
            else
            {
                if(chucnang == "donvi")
                {
                    BUS_donvi.DAO.themdv(dgv);
                }
                else
                {
                    if(chucnang == "loaiphong")
                    {
                        BUS_loaiphong.DAO.them(dgv);
                    }
                    else
                    {
                        if (chucnang == "phong")
                        {
                            BUS_phong.DAO.them(dgv);
                        }
                        else
                        {
                            if(chucnang == "thietbi")
                            {
                                BUS_thietbi.DAO.them(dgv);
                            }    
                            else
                            {
                                if(chucnang == "dichvu")
                                {
                                    BUS_dichvu.DAO.them(dgv);
                                }    
                                else
                                {
                                    if(chucnang == "khachhang")
                                    {
                                        BUS_khachhang.DAO.them(dgv);
                                    }
                                }
                            }    
                        }    
                    }    
                }    
            }
        }

        private void frmadd_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(chucnang == "phong")
                Table = BUS_phong.DAO.luu(dgv, Table);
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.WriteLine("error");
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
