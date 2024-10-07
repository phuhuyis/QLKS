using Admin.BUS;
using Admin.GUI;
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

namespace Admin
{
    public partial class frm_tk_hdthue_thang : Form
    {
        int nam, thang;
        frmSystem frm;
        TcpClient tcpclient;
        Thread t1;
        bool kt = false;

        public frm_tk_hdthue_thang(frmSystem frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void frm_tk_hdthue_thang_Load(object sender, EventArgs e)
        {
            numermonth.Value = DateTime.Now.Month;
            numeryear.Value = DateTime.Now.Year;
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
                        if (content == "nhapdichvu")
                        {
                            Invoke(new Action(() =>
                            {
                                if (kt)
                                {
                                    BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                }
                            }));
                        }
                        else
                        {
                            if (content == "tinhluong")
                            {
                                Invoke(new Action(() =>
                                {
                                    if (kt)
                                    {
                                        BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                    }
                                }));
                            }
                            else
                            {
                                if (content == "xoaluong")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        if (kt)
                                        {
                                            BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                        }
                                    }));
                                }
                                else
                                {
                                    if (content == "capnhapluong")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            if (kt)
                                            {
                                                BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                            }
                                        }));
                                    }
                                    else
                                    {
                                        if (content == "xoanv")
                                        {
                                            Invoke(new Action(() =>
                                            {
                                                if (kt)
                                                {
                                                    BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                }
                                            }));
                                        }
                                        else
                                        {
                                            if (content == "capnhapnv")
                                            {
                                                Invoke(new Action(() =>
                                                {
                                                    if (kt)
                                                    {
                                                        BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                    }
                                                }));
                                            }
                                            else
                                            {
                                                if (content == "xoadonvi")
                                                {
                                                    Invoke(new Action(() =>
                                                    {
                                                        if (kt)
                                                        {
                                                            BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                        }
                                                    }));
                                                }
                                                else
                                                {
                                                    if (content == "xoaloaiphong")
                                                    {
                                                        Invoke(new Action(() =>
                                                        {
                                                            if (kt)
                                                            {
                                                                BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                            }
                                                        }));
                                                    }
                                                    else
                                                    {
                                                        if (content == "sualoaiphong")
                                                        {
                                                            Invoke(new Action(() =>
                                                            {
                                                                if (kt)
                                                                {
                                                                    BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                                }
                                                            }));
                                                        }
                                                        else
                                                        {
                                                            if (content == "xoaphong")
                                                            {
                                                                Invoke(new Action(() =>
                                                                {
                                                                    if (kt)
                                                                    {
                                                                        BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                                    }
                                                                }));
                                                            }
                                                            else
                                                            {
                                                                if (content == "suaphong")
                                                                {
                                                                    Invoke(new Action(() =>
                                                                    {
                                                                        if (kt)
                                                                        {
                                                                            BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                                        }
                                                                    }));
                                                                }
                                                                else
                                                                {
                                                                    if (content == "xoadichvu")
                                                                    {
                                                                        Invoke(new Action(() =>
                                                                        {
                                                                            if (kt)
                                                                            {
                                                                                BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                                            }
                                                                        }));
                                                                    }
                                                                    else
                                                                    {
                                                                        if (content == "suadichvu")
                                                                        {
                                                                            Invoke(new Action(() =>
                                                                            {
                                                                                if (kt)
                                                                                {
                                                                                    BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                                                }
                                                                            }));
                                                                        }
                                                                        else
                                                                        {
                                                                            if (content == "xoakhachhang")
                                                                            {
                                                                                Invoke(new Action(() =>
                                                                                {
                                                                                    if (kt)
                                                                                    {
                                                                                        BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                                                    }
                                                                                }));
                                                                            }
                                                                            else
                                                                            {
                                                                                if (content.Contains("thuephongkc"))
                                                                                {
                                                                                    Invoke(new Action(() =>
                                                                                    {
                                                                                        if (kt)
                                                                                        {
                                                                                            BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                                                        }
                                                                                    }));
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (content.Contains("thuephongkm"))
                                                                                    {
                                                                                        Invoke(new Action(() =>
                                                                                        {
                                                                                            if (kt)
                                                                                            {
                                                                                                BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                                                            }
                                                                                        }));
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (content == "chuyenphong")
                                                                                        {
                                                                                            Invoke(new Action(() =>
                                                                                            {
                                                                                                if (kt)
                                                                                                {
                                                                                                    BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                                                                }
                                                                                            }));
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (content.Contains("goidv"))
                                                                                            {
                                                                                                Invoke(new Action(() =>
                                                                                                {
                                                                                                    if (kt)
                                                                                                    {
                                                                                                        BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                                                                    }
                                                                                                }));
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (content.Contains("capnhapdvhd"))
                                                                                                {
                                                                                                    Invoke(new Action(() =>
                                                                                                    {
                                                                                                        if (kt)
                                                                                                        {
                                                                                                            BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                                                                        }
                                                                                                    }));
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (content.Contains("xoadvhd"))
                                                                                                    {
                                                                                                        Invoke(new Action(() =>
                                                                                                        {
                                                                                                            if (kt)
                                                                                                            {
                                                                                                                BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                                                                            }
                                                                                                        }));
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (content.Contains("huyhd"))
                                                                                                        {
                                                                                                            Invoke(new Action(() =>
                                                                                                            {
                                                                                                                if (kt)
                                                                                                                {
                                                                                                                    BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                                                                                }
                                                                                                            }));
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if (content.Contains("thanhtoan"))
                                                                                                            {
                                                                                                                Invoke(new Action(() =>
                                                                                                                {
                                                                                                                    if (kt)
                                                                                                                    {
                                                                                                                        BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                                                                                    }
                                                                                                                }));
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if (content.Contains("themloaiphong"))
                                                                                                                {
                                                                                                                    Invoke(new Action(() =>
                                                                                                                    {
                                                                                                                        if (kt)
                                                                                                                        {
                                                                                                                            BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                                                                                        }
                                                                                                                    }));
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if (content.Contains("sualoaiphong"))
                                                                                                                    {
                                                                                                                        Invoke(new Action(() =>
                                                                                                                        {
                                                                                                                            if (kt)
                                                                                                                            {
                                                                                                                                BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
                                                                                                                            }
                                                                                                                        }));
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            });
            t1.Start();
        }

        private void frm_tk_hdthue_thang_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv.Rows[e.RowIndex].Cells[3].Value.ToString() == "Chưa trả phòng")
            {
                MessageBox.Show("Phòng này khách chưa trả nên chưa có hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
            else
            {
                if (e.ColumnIndex == dgv.ColumnCount - 1)
                {
                    if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                    {

                        BUS_cthd.DAO.xemhoadon(dgv.Rows[e.RowIndex].Cells[0].Value.ToString(), this.frm);
                    }
                }
            }
        }

        private void btntable_Click(object sender, EventArgs e)
        {
            kt = true;
            nam = (int)numeryear.Value;
            thang = (int)numermonth.Value;
            BUS_tkhdthue.DAO.tkthang(dgv, thang, nam);
        }
    }
}
