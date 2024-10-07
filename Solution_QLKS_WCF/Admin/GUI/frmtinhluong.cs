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
    public partial class frmtinhluong : Form
    {
        DataTable Table;
        TcpClient tcpclient;
        Thread t1;
        frmSystem frm;

        public frmtinhluong(frmSystem frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void frmtinhluong_Load(object sender, EventArgs e)
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
                    else
                    {
                        if(content == "themnv")
                        {
                            Invoke(new Action(() =>
                            {
                                dgv.CellValueChanged -= dgv_CellValueChanged;
                                BUS_luong.DAO.capnhapdata(dgv, Table);
                                Table = BUS_luong.DAO.luu(dgv, Table);
                                if (dgv.RowCount == 0)
                                    this.Close();
                                dgv.CellValueChanged += dgv_CellValueChanged;
                            }));
                        }
                        else
                        {
                            if (content == "xoanv")
                            {
                                Invoke(new Action(() =>
                                {
                                    dgv.CellValueChanged -= dgv_CellValueChanged;
                                    BUS_luong.DAO.capnhapdata(dgv, Table);
                                    Table = BUS_luong.DAO.luu(dgv, Table);
                                    if (dgv.RowCount == 0)
                                        this.Close();
                                    dgv.CellValueChanged += dgv_CellValueChanged;
                                }));
                            }
                            else
                            {
                                if (content == "capnhapnv")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        dgv.CellValueChanged -= dgv_CellValueChanged;
                                        BUS_luong.DAO.capnhapdata(dgv, Table);
                                        Table = BUS_luong.DAO.luu(dgv, Table);
                                        if (dgv.RowCount == 0)
                                            this.Close();
                                        dgv.CellValueChanged += dgv_CellValueChanged;
                                    }));
                                }
                                else
                                {
                                    if (content == "xoaluong")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            dgv.CellValueChanged -= dgv_CellValueChanged;
                                            BUS_luong.DAO.capnhapdata2(dgv, Table);
                                            Table = BUS_luong.DAO.luu(dgv, Table);
                                            if (dgv.RowCount == 0)
                                                this.Close();
                                            dgv.CellValueChanged += dgv_CellValueChanged;
                                        }));
                                    }
                                    else
                                    {
                                        if (content == "tinhluong")
                                        {
                                            Invoke(new Action(() =>
                                            {
                                                this.Close();
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
            BUS_luong.DAO.loadluong(dgv);
        }

        private void frmtinhluong_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Table = BUS_luong.DAO.luu(dgv, Table);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            BUS_luong.DAO.tinhluong(dgv, Table);
        }
    }
}
