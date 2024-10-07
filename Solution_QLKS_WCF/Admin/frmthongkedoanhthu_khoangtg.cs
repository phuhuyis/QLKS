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
    public partial class frmthongkedoanhthu_khoangtg : Form
    {
        TcpClient tcpclient;
        Thread t1;
        frmSystem frm;
        DateTime datebatdau = DateTime.Now;
        DateTime dateketthuc = DateTime.Now;
        bool kt = false;

        public frmthongkedoanhthu_khoangtg(frmSystem frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void frmthongkedoanhthu_Load(object sender, EventArgs e)
        {
            rltable.Visible = false;
            rp_chart.Visible = false;
            QLKSDataSet.EnforceConstraints = false;
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
                                if(kt)
                                {
                                    this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                    this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                    this.rp_chart.RefreshReport();
                                    this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                    this.rltable.RefreshReport();
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
                                        this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                        this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                        this.rp_chart.RefreshReport();
                                        this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                        this.rltable.RefreshReport();
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
                                            this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                            this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                            this.rp_chart.RefreshReport();
                                            this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                            this.rltable.RefreshReport();
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
                                                this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                this.rp_chart.RefreshReport();
                                                this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                                this.rltable.RefreshReport();
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
                                                    this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                    this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                    this.rp_chart.RefreshReport();
                                                    this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                                    this.rltable.RefreshReport();
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
                                                        this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                        this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                        this.rp_chart.RefreshReport();
                                                        this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                                        this.rltable.RefreshReport();
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
                                                            this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                            this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                            this.rp_chart.RefreshReport();
                                                            this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                                            this.rltable.RefreshReport();
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
                                                                this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                                this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                                this.rp_chart.RefreshReport();
                                                                this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                                                this.rltable.RefreshReport();
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
                                                                    this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                                    this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                                    this.rp_chart.RefreshReport();
                                                                    this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                                                    this.rltable.RefreshReport();
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
                                                                        this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                                        this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                                        this.rp_chart.RefreshReport();
                                                                        this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                                                        this.rltable.RefreshReport();
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
                                                                            this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                                            this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                                            this.rp_chart.RefreshReport();
                                                                            this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                                                            this.rltable.RefreshReport();
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
                                                                                this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                                                this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                                                this.rp_chart.RefreshReport();
                                                                                this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                                                                this.rltable.RefreshReport();
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
                                                                                    this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                                                    this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                                                    this.rp_chart.RefreshReport();
                                                                                    this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                                                                    this.rltable.RefreshReport();
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
                                                                                        this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                                                        this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                                                        this.rp_chart.RefreshReport();
                                                                                        this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                                                                        this.rltable.RefreshReport();
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
                                                                                            this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                                                            this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                                                            this.rp_chart.RefreshReport();
                                                                                            this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                                                                            this.rltable.RefreshReport();
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
                                                                                                this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                                                                this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                                                                this.rp_chart.RefreshReport();
                                                                                                this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                                                                                this.rltable.RefreshReport();
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
                                                                                                    this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                                                                    this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                                                                    this.rp_chart.RefreshReport();
                                                                                                    this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                                                                                    this.rltable.RefreshReport();
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
                                                                                                        this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                                                                        this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                                                                        this.rp_chart.RefreshReport();
                                                                                                        this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                                                                                        this.rltable.RefreshReport();
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
                                                                                                            this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                                                                            this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                                                                            this.rp_chart.RefreshReport();
                                                                                                            this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                                                                                            this.rltable.RefreshReport();
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
                                                                                                                this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                                                                                this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                                                                                this.rp_chart.RefreshReport();
                                                                                                                this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(datebatdau, dateketthuc);
                                                                                                                this.rltable.RefreshReport();
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
                                                                                                                    this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(datebatdau, dateketthuc);
                                                                                                                    this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(datebatdau, dateketthuc);
                                                                                                                    this.rp_chart.RefreshReport();
                                                                                                                    this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(dateStart.Value, dateEnd.Value);
                                                                                                                    this.rltable.RefreshReport();
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
                                                                                                                        this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(dateStart.Value, dateEnd.Value);
                                                                                                                        this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(dateStart.Value, dateEnd.Value);
                                                                                                                        this.rp_chart.RefreshReport();
                                                                                                                        this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(dateStart.Value, dateEnd.Value);
                                                                                                                        this.rltable.RefreshReport();
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

        private void btn_chart_Click(object sender, EventArgs e)
        {
            if(kiemtrangay(dateStart.Value, dateEnd.Value))
            {
                kt = true;
                datebatdau = dateStart.Value;
                dateketthuc = dateEnd.Value;
                rp_chart.Visible = true;
                rltable.Visible = false;
                this.thongkedoanhthuBindingSource.DataSource = Program.qlks.thongkedoanhthu_chart(dateStart.Value, dateEnd.Value);
                this.thongkedoanhthuhdBindingSource.DataSource = Program.qlks.thongkedoanhthuhd_chart(dateStart.Value, dateEnd.Value);
                // TODO: This line of code loads data into the 'QLKSDataSet.thongkedoanhthu' table. You can move, or remove it, as needed.
                //this.thongkedoanhthuTableAdapter.Fill(this.QLKSDataSet.thongkedoanhthu, DateTime.Now, DateTime.Now);
                // TODO: This line of code loads data into the 'QLKSDataSet.thongkedoanhthuhd' table. You can move, or remove it, as needed.
                //this.thongkedoanhthuhdTableAdapter.Fill(this.QLKSDataSet.thongkedoanhthuhd, DateTime.Now, DateTime.Now);
                //MessageBox.Show(dateStart.Value.ToString());
                this.rp_chart.RefreshReport();
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntable_Click(object sender, EventArgs e)
        {
            if (kiemtrangay(dateStart.Value, dateEnd.Value))
            {
                kt = true;
                datebatdau = dateStart.Value;
                dateketthuc = dateEnd.Value;
                rp_chart.Visible = false;
                rltable.Visible = true;
                //this.thongkedoanhthuallTableAdapter.Fill(this.QLKSDataSet.thongkedoanhthuall);
                this.thongkedoanhthuallBindingSource.DataSource = Program.qlks.thongkedoanhthu_table(dateStart.Value, dateEnd.Value);
                this.rltable.RefreshReport();
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool kiemtrangay(DateTime ngaybatdau, DateTime ngaykt)
        {
            if(ngaybatdau.Year < ngaykt.Year)
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

        private void frmthongkedoanhthu_khoangtg_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }
    }
}