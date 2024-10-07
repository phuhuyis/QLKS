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
    public partial class frm_thongke_luongtienravao_kcngay : Form
    {
        TcpClient tcpclient;
        Thread t1;
        frmSystem frm;
        DateTime ngaybd, ngaykt;
        bool kt = false;

        public frm_thongke_luongtienravao_kcngay(frmSystem frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btntable_Click(object sender, EventArgs e)
        {
            if (kiemtrangay(dateStart.Value, dateEnd.Value))
            {
                kt = true;
                rp_chart.Visible = false;
                rp_tbl.Visible = true;
                kt = true;
                ngaybd = dateStart.Value;
                ngaykt = dateEnd.Value;
                thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);

                this.rp_tbl.RefreshReport();
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_chart_Click(object sender, EventArgs e)
        {
            if (kiemtrangay(dateStart.Value, dateEnd.Value))
            {
                kt = true;
                rp_chart.Visible = true;
                rp_tbl.Visible = false;
                ngaybd = dateStart.Value;
                ngaykt = dateEnd.Value;
                thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                this.rp_chart.RefreshReport();
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_thongke_luongtienravao_kcngay_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        private void frm_thongke_luongtienravao_kcngay_Load(object sender, EventArgs e)
        {
            rp_chart.Visible = false;
            rp_tbl.Visible = false;
            DataSet_Tienravao.EnforceConstraints = false;
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
                                    thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                    this.rp_chart.RefreshReport();
                                    this.rp_tbl.RefreshReport();
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
                                        thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                        this.rp_chart.RefreshReport();
                                        this.rp_tbl.RefreshReport();
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
                                            thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                            this.rp_chart.RefreshReport();
                                            this.rp_tbl.RefreshReport();
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
                                                thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                this.rp_chart.RefreshReport();
                                                this.rp_tbl.RefreshReport();
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
                                                    thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                    this.rp_chart.RefreshReport();
                                                    this.rp_tbl.RefreshReport();
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
                                                        thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                        this.rp_chart.RefreshReport();
                                                        this.rp_tbl.RefreshReport();
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
                                                            thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                            this.rp_chart.RefreshReport();
                                                            this.rp_tbl.RefreshReport();
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
                                                                thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                                this.rp_chart.RefreshReport();
                                                                this.rp_tbl.RefreshReport();
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
                                                                    thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                                    this.rp_chart.RefreshReport();
                                                                    this.rp_tbl.RefreshReport();
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
                                                                        thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                                        this.rp_chart.RefreshReport();
                                                                        this.rp_tbl.RefreshReport();
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
                                                                            thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                                            this.rp_chart.RefreshReport();
                                                                            this.rp_tbl.RefreshReport();
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
                                                                                thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                                                this.rp_chart.RefreshReport();
                                                                                this.rp_tbl.RefreshReport();
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
                                                                                    thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                                                    this.rp_chart.RefreshReport();
                                                                                    this.rp_tbl.RefreshReport();
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
                                                                                        thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                                                        this.rp_chart.RefreshReport();
                                                                                        this.rp_tbl.RefreshReport();
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
                                                                                            thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                                                            this.rp_chart.RefreshReport();
                                                                                            this.rp_tbl.RefreshReport();
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
                                                                                                thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                                                                this.rp_chart.RefreshReport();
                                                                                                this.rp_tbl.RefreshReport();
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
                                                                                                    thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                                                                    this.rp_chart.RefreshReport();
                                                                                                    this.rp_tbl.RefreshReport();
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
                                                                                                        thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                                                                        this.rp_chart.RefreshReport();
                                                                                                        this.rp_tbl.RefreshReport();
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
                                                                                                            thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                                                                            this.rp_chart.RefreshReport();
                                                                                                            this.rp_tbl.RefreshReport();
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
                                                                                                                thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                                                                                this.rp_chart.RefreshReport();
                                                                                                                this.rp_tbl.RefreshReport();
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
                                                                                                                    thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                                                                                    this.rp_chart.RefreshReport();
                                                                                                                    this.rp_tbl.RefreshReport();
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
                                                                                                                        thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                                                                                        this.rp_chart.RefreshReport();
                                                                                                                        this.rp_tbl.RefreshReport();
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
                                                                                                                            thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                                                                                            this.rp_chart.RefreshReport();
                                                                                                                            this.rp_tbl.RefreshReport();
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
                                                                                                                                thongketienravaokcngayBindingSource.DataSource = Program.qlks.thongketienravao_kcngay(ngaybd, ngaykt);
                                                                                                                                this.rp_chart.RefreshReport();
                                                                                                                                this.rp_tbl.RefreshReport();
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

        bool kiemtrangay(DateTime ngaybatdau, DateTime ngaykt)
        {
            if (ngaybatdau.Year < ngaykt.Year)
            {
                return true;
            }
            else
            {
                if (ngaybatdau.Year == ngaykt.Year)
                {
                    if (ngaybatdau.Month < ngaykt.Month)
                    {
                        return true;
                    }
                    else
                    {
                        if (ngaybatdau.Month == ngaykt.Month)
                        {
                            if (ngaybatdau.Day <= ngaykt.Day)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
