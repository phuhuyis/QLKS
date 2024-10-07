﻿using Admin.BUS;
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
    public partial class frmthongkedoanhthuthang : Form
    {
        TcpClient tcpclient;
        Thread t1;
        frmSystem frm;
        int nam;
        int thang;
        bool kt = false;

        public frmthongkedoanhthuthang(frmSystem frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void frmthongkedoanhthuthang_Load(object sender, EventArgs e)
        {
            numermonth.Value = DateTime.Now.Month;
            numeryear.Value = DateTime.Now.Year;
            rp_chart.Visible = false;
            rp_tbl.Visible = false;
            DataSet_doanhthu_thang.EnforceConstraints = false;
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
                                    this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                    this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                    this.rp_chart.RefreshReport();
                                    this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                        this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                        this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                        this.rp_chart.RefreshReport();
                                        this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                            this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                            this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                            this.rp_chart.RefreshReport();
                                            this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                this.rp_chart.RefreshReport();
                                                this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                    this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                    this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                    this.rp_chart.RefreshReport();
                                                    this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                        this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                        this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                        this.rp_chart.RefreshReport();
                                                        this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                            this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                            this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                            this.rp_chart.RefreshReport();
                                                            this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                                this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                                this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                                this.rp_chart.RefreshReport();
                                                                this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                                    this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                                    this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                                    this.rp_chart.RefreshReport();
                                                                    this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                                        this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                                        this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                                        this.rp_chart.RefreshReport();
                                                                        this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                                            this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                                            this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                                            this.rp_chart.RefreshReport();
                                                                            this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                                                this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                                                this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                                                this.rp_chart.RefreshReport();
                                                                                this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                                                    this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                                                    this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                                                    this.rp_chart.RefreshReport();
                                                                                    this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                                                        this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                                                        this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                                                        this.rp_chart.RefreshReport();
                                                                                        this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                                                            this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                                                            this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                                                            this.rp_chart.RefreshReport();
                                                                                            this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                                                                this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                                                                this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                                                                this.rp_chart.RefreshReport();
                                                                                                this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                                                                    this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                                                                    this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                                                                    this.rp_chart.RefreshReport();
                                                                                                    this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                                                                        this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                                                                        this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                                                                        this.rp_chart.RefreshReport();
                                                                                                        this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                                                                            this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                                                                            this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                                                                            this.rp_chart.RefreshReport();
                                                                                                            this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                                                                                this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                                                                                this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                                                                                this.rp_chart.RefreshReport();
                                                                                                                this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                                                                                    this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                                                                                    this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                                                                                    this.rp_chart.RefreshReport();
                                                                                                                    this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
                                                                                                                        this.thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
                                                                                                                        this.thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
                                                                                                                        this.rp_chart.RefreshReport();
                                                                                                                        this.thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);
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
            });
            t1.Start();
        }

        private void btntable_Click(object sender, EventArgs e)
        {
            rp_chart.Visible = false;
            rp_tbl.Visible = true;
            kt = true;
            nam = (int)numeryear.Value;
            thang = (int)numermonth.Value;
            thongkedoanhthuallthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_table_thang(thang, nam);

            this.rp_tbl.RefreshReport();
        }

        private void frmthongkedoanhthuthang_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        private void btn_chart_Click(object sender, EventArgs e)
        {
            kt = true;
            rp_chart.Visible = true;
            rp_tbl.Visible = false;
            nam = (int)numeryear.Value;
            thang = (int)numermonth.Value;
            thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
            thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);
            thongkedoanhthuhdthangBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart_thang(thang, nam);
            thongkedoanhthuthangBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart_thang(thang, nam);

            this.rp_chart.RefreshReport();
            this.rp_chart.RefreshReport();
        }
    }
}
