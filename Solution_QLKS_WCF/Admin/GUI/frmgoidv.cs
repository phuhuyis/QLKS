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
    public partial class frmgoidv : Form
    {
        String sohd;
        Thread t1;
        TcpClient tcpclient;
        frmSystem frm;
        DataTable tblgia = new DataTable();
        DataTable tbldagoi = new DataTable();
        DataTable tbldv = new DataTable();

        public frmgoidv(String sohd, frmSystem frm)
        {
            InitializeComponent();
            this.sohd = sohd;
            this.frm = frm;
        }

        private void frmgoidv_Load(object sender, EventArgs e)
        {
            tbldv = BUS_cthd.DAO.loaddsdv(cbxdv);
            tbldagoi = BUS_cthd.DAO.loaddvdagoi(dgvdg, sohd);
            tblgia = BUS_cthd.DAO.loadbanggia(dgvds);
            cbxdv.SelectedIndex = 0;
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
                        if (content == "goidv" + sohd)
                        {
                            Invoke(new Action(() =>
                            {
                                tbldv = BUS_cthd.DAO.loaddsdv(cbxdv);
                                tbldagoi = BUS_cthd.DAO.loaddvdagoi(dgvdg, sohd);
                                tblgia = BUS_cthd.DAO.loadbanggia(dgvds);
                            }));
                        }
                        else
                        {
                            if (content == "capnhapdvhd" + sohd)
                            {
                                Invoke(new Action(() =>
                                {
                                    tbldv = BUS_cthd.DAO.loaddsdv(cbxdv);
                                    tbldagoi = BUS_cthd.DAO.loaddvdagoi(dgvdg, sohd);
                                    tblgia = BUS_cthd.DAO.loadbanggia(dgvds);
                                }));
                            }
                            else
                            {
                                if (content == "xoadvhd" + sohd)
                                {
                                    Invoke(new Action(() =>
                                    {
                                        tbldv = BUS_cthd.DAO.loaddsdv(cbxdv);
                                        tbldagoi = BUS_cthd.DAO.loaddvdagoi(dgvdg, sohd);
                                        tblgia = BUS_cthd.DAO.loadbanggia(dgvds);
                                    }));
                                }
                                else
                                {
                                    if (content == "themdichvu")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            tbldv = BUS_cthd.DAO.loaddsdv(cbxdv);
                                            tbldagoi = BUS_cthd.DAO.loaddvdagoi(dgvdg, sohd);
                                            tblgia = BUS_cthd.DAO.loadbanggia(dgvds);
                                        }));
                                    }
                                    else
                                    {
                                        if (content == "xoadichvu")
                                        {
                                            Invoke(new Action(() =>
                                            {
                                                tbldv = BUS_cthd.DAO.loaddsdv(cbxdv);
                                                tbldagoi = BUS_cthd.DAO.loaddvdagoi(dgvdg, sohd);
                                                tblgia = BUS_cthd.DAO.loadbanggia(dgvds);
                                            }));
                                        }
                                        else
                                        {
                                            if (content == "suadichvu")
                                            {
                                                Invoke(new Action(() =>
                                                {
                                                    tbldv = BUS_cthd.DAO.loaddsdv(cbxdv);
                                                    tbldagoi = BUS_cthd.DAO.loaddvdagoi(dgvdg, sohd);
                                                    tblgia = BUS_cthd.DAO.loadbanggia(dgvds);
                                                }));
                                            }
                                            else
                                            {
                                                if (content == "xoaphong")
                                                {
                                                    if(!BUS_cthd.DAO.kiemtrahd(sohd))
                                                    {
                                                        Invoke(new Action(() =>
                                                        {
                                                            this.Close();
                                                        }));
                                                    }   
                                                }
                                                else
                                                {
                                                    if (content == "huyhd" + sohd)
                                                    {
                                                        Invoke(new Action(() =>
                                                        {
                                                            this.Close();
                                                        }));
                                                    }
                                                    else
                                                    {
                                                        if (content == "thanhtoan" + sohd)
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
                            }    
                        }    
                    }
                }
            });
            t1.Start();
        }

        private void frmgoidv_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        private void cbxdv_TextChanged(object sender, EventArgs e)
        {
            if (cbxdv.SelectedIndex == -1)
                cbxdv.SelectedIndex = 0;
        }

        private void btngoi_Click(object sender, EventArgs e)
        {
            BUS_cthd.DAO.goidv(cbxdv, numersoluong, sohd);
            tbldagoi = BUS_cthd.DAO.loaddvdagoi(dgvdg, sohd);
            tblgia = BUS_cthd.DAO.loadbanggia(dgvds);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            BUS_cthd.DAO.capnhapdv(cbxdv, numersoluong, sohd);
            tbldagoi = BUS_cthd.DAO.loaddvdagoi(dgvdg, sohd);
            tblgia = BUS_cthd.DAO.loadbanggia(dgvds);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            BUS_cthd.DAO.huydv(cbxdv, sohd);
            tbldagoi = BUS_cthd.DAO.loaddvdagoi(dgvdg, sohd);
            tblgia = BUS_cthd.DAO.loadbanggia(dgvds);
        }

        private void dgvds_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                for (int i = 0; i < tbldv.Rows.Count; i++)
                {
                    if (tbldv.Rows[i][1].ToString() == dgvds.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        cbxdv.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < tbldagoi.Rows.Count; i++)
                {
                    if (tbldagoi.Rows[i][0].ToString() == dgvds.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        dgvdg.ClearSelection();
                        dgvdg.Rows[i].Cells[0].Selected = true;
                        break;
                    }
                }
            }
            catch(Exception)
            {
                Console.WriteLine("a");
            }
        }

        private void dgvdg_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                for (int i = 0; i < tbldv.Rows.Count; i++)
                {
                    if (tbldv.Rows[i][1].ToString() == dgvdg.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        cbxdv.SelectedIndex = i;
                        numersoluong.Value = Decimal.Parse(dgvdg.Rows[e.RowIndex].Cells[2].Value.ToString());
                        break;
                    }
                }
                for (int i = 0; i < tblgia.Rows.Count; i++)
                {
                    if (tblgia.Rows[i][0].ToString() == dgvdg.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        dgvds.ClearSelection();
                        dgvds.Rows[i].Cells[0].Selected = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("a");
            }
        }

        private void btnhuyhd_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn phòng này hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Hủy hóa đơn thành công");
                BUS_cthd.DAO.huyhd(sohd);
                this.Close();
            }    
        }

        private void btntt_Click(object sender, EventArgs e)
        {
            BUS_cthd.DAO.thanhtoan(sohd, this, dgvdg, this.frm);
        }
    }
}
