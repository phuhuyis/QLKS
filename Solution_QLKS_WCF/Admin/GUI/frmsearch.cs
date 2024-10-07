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
    public partial class frmsearch : Form
    {
        String chucnang;
        TcpClient tcpclient;
        Thread t1;
        String key = "";
        bool kt = false;
        DataTable table;
        frmSystem frm;

        public frmsearch(String cn, frmSystem frm)
        {
            InitializeComponent();
            chucnang = cn;
            this.frm = frm;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            switch (chucnang)
            {
                case "nhanvien":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên nhân viên...")
                    {
                        key = "";
                    }
                    else
                    {
                        key = txttimkiem.Text.Trim();
                    }
                    break;
                case "donvi":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên đơn vị...")
                    {
                        key = "";
                    }
                    else
                    {
                        key = txttimkiem.Text.Trim();
                    }
                    break;
                case "loaiphong":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên loại phòng...")
                    {
                        key = "";
                    }
                    else
                    {
                        key = txttimkiem.Text.Trim();
                    }
                    break;
                case "phong":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên phòng...")
                    {
                        key = "";
                    }
                    else
                    {
                        key = txttimkiem.Text.Trim();
                    }
                    break;
                case "thietbi":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên thiết bị...")
                    {
                        key = "";
                    }
                    else
                    {
                        key = txttimkiem.Text.Trim();
                    }
                    break;
                case "dichvu":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên dịch vụ...")
                    {
                        key = "";
                    }
                    else
                    {
                        key = txttimkiem.Text.Trim();
                    }
                    break;
                case "khachhang":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên khách hàng...")
                    {
                        key = "";
                    }
                    else
                    {
                        key = txttimkiem.Text.Trim();
                    }
                    break;
                case "phieudatphong":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên khách hàng...")
                    {
                        key = "";
                    }
                    else
                    {
                        key = txttimkiem.Text.Trim();
                    }
                    break;
                case "hoadonthue":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên khách hàng...")
                    {
                        key = "";
                    }
                    else
                    {
                        key = txttimkiem.Text.Trim();
                    }
                    break;
            }
            if(chucnang == "nhanvien")
            {
                BUS_nhanvien.DAO.search(key, dgv);
            }    
            else
            {
                if(chucnang == "donvi")
                {
                    table = BUS_donvi.DAO.search(key, dgv);
                }  
                else
                {
                    if(chucnang == "loaiphong")
                    {
                        table = BUS_loaiphong.DAO.search(key, dgv);
                    }    
                    else
                    {
                        if (chucnang == "phong")
                        {
                            table = BUS_phong.DAO.search(key, dgv);
                        }
                        else
                        {
                            if(chucnang == "thietbi")
                            {
                                table = BUS_thietbi.DAO.search(key, dgv);
                            }    
                            else
                            {
                                if (chucnang == "dichvu")
                                {
                                    table = BUS_dichvu.DAO.search(key, dgv);
                                }
                                else
                                {
                                    if (chucnang == "khachhang")
                                    {
                                        table = BUS_khachhang.DAO.search(key, dgv);
                                    }
                                    else
                                    {
                                        if(chucnang == "phieudatphong")
                                        {
                                            table = BUS_phieudatphong.DAO.search(key, dgv);
                                        }
                                        else
                                        {
                                            if (chucnang == "hoadonthue")
                                            {
                                                table = BUS_cthd.DAO.search(key, dgv);
                                            }

                                        }
                                    }    
                                }
                            }    
                        }    
                    }    
                }    
            }    
            kt = true;
        }

        private void frmsearch_Load(object sender, EventArgs e)
        {
            tcpclient = new TcpClient();
            tcpclient.Connect(config.ipsocket, config.portsocket);
            BUS_Login.DAO.themsocket(frm.user.Trim());
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
                        if(chucnang == "nhanvien")
                        {
                            if (content == "themnv")
                            {
                                Invoke(new Action(() =>
                                {
                                    if (kt)
                                        BUS_nhanvien.DAO.search(key, dgv);
                                }));
                            }
                            else
                            {
                                if (content == "capnhapnv")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        if (kt)
                                            BUS_nhanvien.DAO.search(key, dgv);
                                    }));
                                }
                                else
                                {
                                    if (content == "xoanv")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            if (kt)
                                                BUS_nhanvien.DAO.search(key, dgv);
                                        }));
                                    }
                                    else
                                    {
                                        if (content == "doimatkhau")
                                        {
                                            Invoke(new Action(() =>
                                            {
                                                if (kt)
                                                    BUS_nhanvien.DAO.search(key, dgv);
                                            }));
                                        }   
                                    }    
                                }    
                            }    
                        } 
                        else
                        {
                            if(chucnang == "donvi")
                            {
                                if (content == "themdonvi")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        if (kt)
                                            table = BUS_donvi.DAO.search(key, dgv);
                                    }));
                                }
                                else
                                {
                                    if (content == "suadonvi")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            if (kt)
                                                table = BUS_donvi.DAO.search(key, dgv);
                                        }));
                                    }
                                    else
                                    {
                                        if (content == "xoadonvi")
                                        {
                                            Invoke(new Action(() =>
                                            {
                                                if (kt)
                                                    table = BUS_donvi.DAO.search(key, dgv);
                                            }));
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if(chucnang == "loaiphong")
                                {
                                    if (content == "themloaiphong")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            if (kt)
                                                table = BUS_loaiphong.DAO.search(key, dgv);
                                        }));
                                    }
                                    else
                                    {
                                        if (content == "xoaloaiphong")
                                        {
                                            Invoke(new Action(() =>
                                            {
                                                if (kt)
                                                    table = BUS_loaiphong.DAO.search(key, dgv);
                                            }));
                                        }
                                        else
                                        {
                                            if (content == "sualoaiphong")
                                            {
                                                Invoke(new Action(() =>
                                                {
                                                    if (kt)
                                                        table = BUS_loaiphong.DAO.search(key, dgv);
                                                }));
                                            }
                                        }    
                                    }    
                                }
                                else
                                {
                                    if(chucnang == "phong")
                                    {
                                        if (content == "themloaiphong")
                                        {
                                            Invoke(new Action(() =>
                                            {
                                                if (kt)
                                                    table = BUS_phong.DAO.search(key, dgv);
                                            }));
                                        }
                                        else
                                        {
                                            if (content == "xoaloaiphong")
                                            {
                                                Invoke(new Action(() =>
                                                {
                                                    if (kt)
                                                        table = BUS_phong.DAO.search(key, dgv);
                                                }));
                                            }
                                            else
                                            {
                                                if (content == "sualoaiphong")
                                                {
                                                    Invoke(new Action(() =>
                                                    {
                                                        if (kt)
                                                            table = BUS_phong.DAO.search(key, dgv);
                                                    }));
                                                }
                                                else
                                                {
                                                    if (content == "themphong")
                                                    {
                                                        Invoke(new Action(() =>
                                                        {
                                                            if (kt)
                                                                table = BUS_phong.DAO.search(key, dgv);
                                                        }));
                                                    }
                                                    else
                                                    {
                                                        if (content == "xoaphong")
                                                        {
                                                            Invoke(new Action(() =>
                                                            {
                                                                if (kt)
                                                                    table = BUS_phong.DAO.search(key, dgv);
                                                            }));
                                                        }
                                                        else
                                                        {
                                                            if (content == "suaphong")
                                                            {
                                                                Invoke(new Action(() =>
                                                                {
                                                                    if (kt)
                                                                        table = BUS_phong.DAO.search(key, dgv);
                                                                }));
                                                            }
                                                        }    
                                                    }    
                                                }    
                                            }
                                        }
                                    } 
                                    else
                                    {
                                        if(chucnang == "thietbi")
                                        {
                                            if (content == "themthietbi")
                                            {
                                                Invoke(new Action(() =>
                                                {
                                                    if (kt)
                                                        table = BUS_thietbi.DAO.search(key, dgv);
                                                }));
                                            }
                                            else
                                            {
                                                if (content == "xoathietbi")
                                                {
                                                    Invoke(new Action(() =>
                                                    {
                                                        if (kt)
                                                            table = BUS_thietbi.DAO.search(key, dgv);
                                                    }));
                                                }
                                                else
                                                {
                                                    if(content == "suathietbi")
                                                    {
                                                        Invoke(new Action(() =>
                                                        {
                                                            if (kt)
                                                                table = BUS_thietbi.DAO.search(key, dgv);
                                                        }));
                                                    }
                                                }    
                                            }    
                                        }    
                                        else
                                        {
                                            if (chucnang == "dichvu")
                                            {
                                                if (content == "themdichvu")
                                                {
                                                    Invoke(new Action(() =>
                                                    {
                                                        if (kt)
                                                            table = BUS_dichvu.DAO.search(key, dgv);
                                                    }));
                                                }
                                                else
                                                {
                                                    if (content == "xoadichvu")
                                                    {
                                                        Invoke(new Action(() =>
                                                        {
                                                            if (kt)
                                                                table = BUS_dichvu.DAO.search(key, dgv);
                                                        }));
                                                    }
                                                    else
                                                    {
                                                        if (content == "suadichvu")
                                                        {
                                                            Invoke(new Action(() =>
                                                            {
                                                                if (kt)
                                                                    table = BUS_dichvu.DAO.search(key, dgv);
                                                            }));
                                                        }
                                                        else
                                                        {
                                                            if (content == "nhapdichvu")
                                                            {
                                                                Invoke(new Action(() =>
                                                                {
                                                                    if (kt)
                                                                        table = BUS_dichvu.DAO.search(key, dgv);
                                                                }));
                                                            }
                                                            else
                                                            {
                                                                if (content.Contains("goidv"))
                                                                {
                                                                    Invoke(new Action(() =>
                                                                    {
                                                                        if (kt)
                                                                            table = BUS_dichvu.DAO.search(key, dgv);
                                                                    }));
                                                                }
                                                                else
                                                                {
                                                                    if (content.Contains("capnhapdvhd"))
                                                                    {
                                                                        Invoke(new Action(() =>
                                                                        {
                                                                            if (kt)
                                                                                table = BUS_dichvu.DAO.search(key, dgv);
                                                                        }));
                                                                    }
                                                                    else
                                                                    {
                                                                        if (content.Contains("xoadvhd"))
                                                                        {
                                                                            Invoke(new Action(() =>
                                                                            {
                                                                                if (kt)
                                                                                    table = BUS_dichvu.DAO.search(key, dgv);
                                                                            }));
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }    
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (chucnang == "khachhang")
                                                {
                                                    if (content == "themkhachhang")
                                                    {
                                                        Invoke(new Action(() =>
                                                        {
                                                            if (kt)
                                                                table = BUS_khachhang.DAO.search(key, dgv);
                                                        }));
                                                    }
                                                    else
                                                    {
                                                        if (content == "suakhachhang")
                                                        {
                                                            Invoke(new Action(() =>
                                                            {
                                                                if (kt)
                                                                    table = BUS_khachhang.DAO.search(key, dgv);
                                                            }));
                                                        }
                                                        else
                                                        {
                                                            if (content == "xoakhachhang")
                                                            {
                                                                Invoke(new Action(() =>
                                                                {
                                                                    if (kt)
                                                                        table = BUS_khachhang.DAO.search(key, dgv);
                                                                }));
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    if (chucnang == "phieudatphong")
                                                    {
                                                        if (content.Contains("datphongkm") || content.Contains("datphongkc"))
                                                        {
                                                            Invoke(new Action(() =>
                                                            {
                                                                if (kt)
                                                                    table = BUS_phieudatphong.DAO.search(key, dgv);
                                                            }));
                                                        }
                                                        else
                                                        {
                                                            if (content == "suaphieudatphong")
                                                            {
                                                                Invoke(new Action(() =>
                                                                {
                                                                    if (kt)
                                                                        table = BUS_phieudatphong.DAO.search(key, dgv);
                                                                }));
                                                            }
                                                            else
                                                            {
                                                                if (content == "xoaphieudatphong")
                                                                {
                                                                    Invoke(new Action(() =>
                                                                    {
                                                                        if (kt)
                                                                            table = BUS_phieudatphong.DAO.search(key, dgv);
                                                                    }));
                                                                }
                                                                else
                                                                {
                                                                    if (content == "xoaphong")
                                                                    {
                                                                        Invoke(new Action(() =>
                                                                        {
                                                                            if (kt)
                                                                                table = BUS_phieudatphong.DAO.search(key, dgv);
                                                                        }));
                                                                    }
                                                                    else
                                                                    {
                                                                        if (content == "suaphong")
                                                                        {
                                                                            Invoke(new Action(() =>
                                                                            {
                                                                                if (kt)
                                                                                    table = BUS_phieudatphong.DAO.search(key, dgv);
                                                                            }));
                                                                        }
                                                                        else
                                                                        {
                                                                            if (content == "suakhachhang")
                                                                            {
                                                                                Invoke(new Action(() =>
                                                                                {
                                                                                    if (kt)
                                                                                        table = BUS_phieudatphong.DAO.search(key, dgv);
                                                                                }));
                                                                            }
                                                                            else
                                                                            {
                                                                                if (content == "xoakhachhang")
                                                                                {
                                                                                    Invoke(new Action(() =>
                                                                                    {
                                                                                        if (kt)
                                                                                            table = BUS_phieudatphong.DAO.search(key, dgv);
                                                                                    }));
                                                                                }
                                                                            }
                                                                        }    
                                                                    }
                                                                }    
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if(chucnang == "hoadonthue")
                                                        {
                                                            if (content == "suaphong")
                                                            {
                                                                Invoke(new Action(() =>
                                                                {
                                                                    if (kt)
                                                                        table = BUS_cthd.DAO.search(key, dgv);

                                                                }));
                                                            }
                                                            else
                                                            {
                                                                if (content == "xoaloaiphong")
                                                                {
                                                                    Invoke(new Action(() =>
                                                                    {
                                                                        if (kt)
                                                                            table = BUS_cthd.DAO.search(key, dgv);
                                                                    }));
                                                                }
                                                                else
                                                                {
                                                                    if (content == "xoaphong")
                                                                    {
                                                                        Invoke(new Action(() =>
                                                                        {
                                                                            if (kt)
                                                                                table = BUS_cthd.DAO.search(key, dgv);
                                                                        }));
                                                                    }
                                                                    else
                                                                    {
                                                                        if (content.Contains("thanhtoan"))
                                                                        {
                                                                            Invoke(new Action(() =>
                                                                            {
                                                                                if (kt)
                                                                                    table = BUS_cthd.DAO.search(key, dgv);
                                                                            }));
                                                                        }
                                                                        else
                                                                        {
                                                                            if (content == "suakhachhang")
                                                                            {
                                                                                Invoke(new Action(() =>
                                                                                {
                                                                                    if (kt)
                                                                                        table = BUS_cthd.DAO.search(key, dgv);
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
            });
            t1.Start();
            if (chucnang == "nhanvien")
            {
                this.Text += "nhân viên";
            }
            else
            {
                if(chucnang == "donvi")
                {
                    this.Text += "đơn vị cung cấp";
                }
                else
                {
                    if(chucnang == "loaiphong")
                    {
                        this.Text += "loại phòng";
                    }
                    else
                    {
                        if(chucnang == "phong")
                        {
                            this.Text += "phòng";
                        }
                        else
                        {
                            if(chucnang == "thietbi")
                            {
                                this.Text += "thiết bị";
                            }    
                            else
                            {
                                if(chucnang == "dichvu")
                                {
                                    this.Text += "dịch vụ";
                                }    
                                else
                                {
                                    if (chucnang == "khachhang")
                                    {
                                        this.Text += "khách hàng";
                                    }
                                    else
                                    {
                                        if(chucnang == "phieudatphong")
                                        {
                                            this.Text += "phiếu đặt phòng";
                                        }
                                        else
                                        {
                                            if (chucnang == "hoadonthue")
                                            {
                                                this.Text += "hóa đơn thuê";
                                            }
                                        }
                                    }    
                                }
                            }    
                        }    
                    }    
                }    
            }

            switch (chucnang)
            {
                case "nhanvien":
                    txttimkiem.Text = "Tìm kiếm theo tên nhân viên...";
                    txttimkiem.ForeColor = Color.Black;
                    break;
                case "donvi":
                    txttimkiem.Text = "Tìm kiếm theo tên đơn vị...";
                    txttimkiem.ForeColor = Color.Black;
                    break;
                case "loaiphong":
                    txttimkiem.Text = "Tìm kiếm theo tên loại phòng...";
                    txttimkiem.ForeColor = Color.Black;
                    break;
                case "phong":
                    txttimkiem.Text = "Tìm kiếm theo tên phòng...";
                    txttimkiem.ForeColor = Color.Black;
                    break;
                case "thietbi":
                    txttimkiem.Text = "Tìm kiếm theo tên thiết bị...";
                    txttimkiem.ForeColor = Color.Black;
                    break;
                case "dichvu":
                    txttimkiem.Text = "Tìm kiếm theo tên dịch vụ...";
                    txttimkiem.ForeColor = Color.Black;
                    break;
                case "khachhang":
                    txttimkiem.Text = "Tìm kiếm theo tên khách hàng...";
                    txttimkiem.ForeColor = Color.Black;
                    break;
                case "phieudatphong":
                    txttimkiem.Text = "Tìm kiếm theo tên khách hàng...";
                    txttimkiem.ForeColor = Color.Black;
                    break;
                case "hoadonthue":
                    txttimkiem.Text = "Tìm kiếm theo tên khách hàng...";
                    txttimkiem.ForeColor = Color.Black;
                    break;
            }
        }

        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            switch(chucnang)
            {
                case "nhanvien":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên nhân viên...")
                    {
                        txttimkiem.Text = "";
                        txttimkiem.ForeColor = Color.Black;
                    }
                    break;
                case "donvi":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên đơn vị...")
                    {
                        txttimkiem.Text = "";
                        txttimkiem.ForeColor = Color.Black;
                    }
                    break;
                case "loaiphong":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên loại phòng...")
                    {
                        txttimkiem.Text = "";
                        txttimkiem.ForeColor = Color.Black;
                    }
                    break;
                case "phong":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên phòng...")
                    {
                        txttimkiem.Text = "";
                        txttimkiem.ForeColor = Color.Black;
                    }
                    break;
                case "thietbi":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên thiết bị...")
                    {
                        txttimkiem.Text = "";
                        txttimkiem.ForeColor = Color.Black;
                    }
                    break;
                case "dichvu":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên dịch vụ...")
                    {
                        txttimkiem.Text = "";
                        txttimkiem.ForeColor = Color.Black;
                    }
                    break;
                case "khachhang":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên khách hàng...")
                    {
                        txttimkiem.Text = "";
                        txttimkiem.ForeColor = Color.Black;
                    }
                    break;
                case "phieudatphong":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên khách hàng...")
                    {
                        txttimkiem.Text = "";
                        txttimkiem.ForeColor = Color.Black;
                    }
                    break;
                case "hoadonthue":
                    if (txttimkiem.Text.Trim() == "Tìm kiếm theo tên khách hàng...")
                    {
                        txttimkiem.Text = "";
                        txttimkiem.ForeColor = Color.Black;
                    }
                    break;
            }    
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            switch (chucnang)
            {
                case "nhanvien":
                    if (txttimkiem.Text.Trim() == "")
                    {
                        txttimkiem.Text = "Tìm kiếm theo tên nhân viên...";
                        txttimkiem.ForeColor = Color.FromArgb(224, 224, 224);
                    }
                    break;
                case "donvi":
                    if (txttimkiem.Text.Trim() == "")
                    {
                        txttimkiem.Text = "Tìm kiếm theo tên đơn vị...";
                        txttimkiem.ForeColor = Color.FromArgb(224, 224, 224);
                    }
                    break;
                case "loaiphong":
                    if (txttimkiem.Text.Trim() == "")
                    {
                        txttimkiem.Text = "Tìm kiếm theo tên loại phòng...";
                        txttimkiem.ForeColor = Color.FromArgb(224, 224, 224);
                    }
                    break;
                case "phong":
                    if (txttimkiem.Text.Trim() == "")
                    {
                        txttimkiem.Text = "Tìm kiếm theo tên phòng...";
                        txttimkiem.ForeColor = Color.FromArgb(224, 224, 224);
                    }
                    break;
                case "thietbi":
                    if (txttimkiem.Text.Trim() == "")
                    {
                        txttimkiem.Text = "Tìm kiếm theo tên thiết bị...";
                        txttimkiem.ForeColor = Color.FromArgb(224, 224, 224);
                    }
                    break;
                case "dichvu":
                    if (txttimkiem.Text.Trim() == "")
                    {
                        txttimkiem.Text = "Tìm kiếm theo tên dịch vụ...";
                        txttimkiem.ForeColor = Color.FromArgb(224, 224, 224);
                    }
                    break;
                case "khachhang":
                    if (txttimkiem.Text.Trim() == "")
                    {
                        txttimkiem.Text = "Tìm kiếm theo tên khách hàng...";
                        txttimkiem.ForeColor = Color.FromArgb(224, 224, 224);
                    }
                    break;
                case "phieudatphong":
                    if (txttimkiem.Text.Trim() == "")
                    {
                        txttimkiem.Text = "Tìm kiếm theo tên khách hàng...";
                        txttimkiem.ForeColor = Color.FromArgb(224, 224, 224);
                    }
                    break;
                case "hoadonthue":
                    if (txttimkiem.Text.Trim() == "")
                    {
                        txttimkiem.Text = "Tìm kiếm theo tên khách hàng...";
                        txttimkiem.ForeColor = Color.FromArgb(224, 224, 224);
                    }
                    break;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(chucnang == "nhanvien")
            {
                if (e.ColumnIndex == dgv.ColumnCount - 1)
                {
                    if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                    {
                        MessageBox.Show("Việc xóa nhân viên sẽ xóa hết những dữ liệu về lương và xóa thông tin của nhân viên trong hóa đơn, hãy cân nhắc thao tác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên " + dgv.Rows[e.RowIndex].Cells[1].Value.ToString() + " hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                        {
                            BUS_nhanvien.DAO.xoanv(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                            MessageBox.Show("Đã xóa thành công", "Thông báo");
                        }
                    }
                }
                if (e.ColumnIndex == dgv.ColumnCount - 2)
                {
                    if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                    {
                        frmchange_info_employee frm = new frmchange_info_employee(dgv.Rows[e.RowIndex].Cells[0].Value.ToString(), this.frm);
                        frm.Show();
                    }
                }
            }    
            else
            {
                if(chucnang == "donvi")
                {
                    if (e.ColumnIndex == dgv.ColumnCount - 1)
                    {
                        if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                        {
                            MessageBox.Show("Việc xóa đơn vị cung cấp sẽ xóa thông tin của đơn vị trong hóa đơn, hãy cân nhắc thao tác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn vị " + dgv.Rows[e.RowIndex].Cells[0].Value.ToString() + " hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                            {
                                BUS_donvi.DAO.xoadv(table.Rows[e.RowIndex][0].ToString());
                                MessageBox.Show("Đã xóa thành công", "Thông báo");
                            }
                        }
                    }
                    if (e.ColumnIndex == dgv.ColumnCount - 2)
                    {
                        if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                        {
                            frmsua_don_vi frm = new frmsua_don_vi(table.Rows[e.RowIndex][0].ToString(), this.frm);
                            frm.Show();
                        }
                    }
                }  
                else
                {
                    if (chucnang == "loaiphong")
                    {
                        if (e.ColumnIndex == dgv.ColumnCount - 1)
                        {
                            if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                            {
                                MessageBox.Show("Việc xóa loại phòng sẽ xóa hết những dữ liệu về tất cả phòng thuộc loại đó, hãy cân nhắc thao tác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                if (MessageBox.Show("Bạn có chắc chắn muốn xóa loại phòng " + dgv.Rows[e.RowIndex].Cells[0].Value.ToString() + " hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                                {
                                    BUS_loaiphong.DAO.xoa(table.Rows[e.RowIndex][0].ToString());
                                    MessageBox.Show("Đã xóa thành công", "Thông báo");
                                }
                            }
                        }
                        if (e.ColumnIndex == dgv.ColumnCount - 2)
                        {
                            if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                            {
                                frmsua_loai_phong frm = new frmsua_loai_phong(table.Rows[e.RowIndex][0].ToString(), this.frm);
                                frm.Show();
                            }
                        }
                    }
                    else
                    {
                        if (chucnang == "phong")
                        {
                            if (e.ColumnIndex == dgv.ColumnCount - 1)
                            {
                                if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                                {
                                    MessageBox.Show("Việc xóa phòng sẽ xóa hết tất cả phiếu đặt phòng, hóa đơn và loại bỏ tất cả thiết bị trong phòng, hãy cân nhắc thao tác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa phòng " + dgv.Rows[e.RowIndex].Cells[0].Value.ToString() + " hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                                    {
                                        BUS_phong.DAO.xoa(table.Rows[e.RowIndex][0].ToString());
                                        MessageBox.Show("Đã xóa thành công", "Thông báo");
                                    }
                                }
                            }
                            if (e.ColumnIndex == dgv.ColumnCount - 2)
                            {
                                if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                                {
                                    frmsua_phong frm = new frmsua_phong(table.Rows[e.RowIndex][0].ToString(), this.frm);
                                    frm.Show();
                                }
                            }
                            else
                            {
                                if(e.ColumnIndex == dgv.ColumnCount - 3)
                                {
                                    if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                                    {
                                        if(BUS_phong.DAO.kt(table.Rows[e.RowIndex][0].ToString()))
                                        {
                                            frmsapxeptb drm = new frmsapxeptb(table.Rows[e.RowIndex][0].ToString(), this.frm);
                                            drm.Show();
                                        }   
                                        else
                                        {
                                            MessageBox.Show("Chưa thêm thiết bị nào hãy thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }    
                                    }
                                }    
                                else
                                {
                                    if (e.ColumnIndex == dgv.ColumnCount - 4)
                                    {
                                        if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                                        {
                                            frmXemdanhsach frm = new frmXemdanhsach(table.Rows[e.RowIndex][0].ToString(), this.frm);
                                            frm.Show();
                                            /*if (BUS_phong.DAO.kt(table.Rows[e.RowIndex][0].ToString()))
                                            {
                                                frmsapxeptb drm = new frmsapxeptb(table.Rows[e.RowIndex][0].ToString());
                                                drm.Show();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Chưa thêm thiết bị nào hãy thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }*/
                                        }
                                    }
                                }    
                            }    
                        }
                        else
                        {
                            if (chucnang == "thietbi")
                            {
                                if (e.ColumnIndex == dgv.ColumnCount - 1)
                                {
                                    if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                                    {
                                        MessageBox.Show("Việc xóa thiết bị sẽ xóa hết tất cả thiết bị trong phòng đã sắp xếp, hãy cân nhắc thao tác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        if (MessageBox.Show("Bạn có chắc chắn muốn xóa thiết bị " + dgv.Rows[e.RowIndex].Cells[0].Value.ToString() + " hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                                        {
                                            BUS_thietbi.DAO.xoa(table.Rows[e.RowIndex][0].ToString());
                                            MessageBox.Show("Đã xóa thành công", "Thông báo");
                                        }
                                    }
                                }
                                if (e.ColumnIndex == dgv.ColumnCount - 2)
                                {
                                    if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                                    {
                                        frm_sua_thietbi frm = new frm_sua_thietbi(table.Rows[e.RowIndex][0].ToString(), this.frm);
                                        frm.Show();
                                    }
                                }
                            }
                            else
                            {
                                if (chucnang == "dichvu")
                                {
                                    if (e.ColumnIndex == dgv.ColumnCount - 1)
                                    {
                                        if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                                        {
                                            MessageBox.Show("Việc xóa dịch vụ sẽ xóa hết tất cả dịch vụ trong hóa đơn, hãy cân nhắc thao tác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ " + dgv.Rows[e.RowIndex].Cells[0].Value.ToString() + " hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                                            {
                                                BUS_dichvu.DAO.xoa(table.Rows[e.RowIndex][0].ToString());
                                                MessageBox.Show("Đã xóa thành công", "Thông báo");
                                            }
                                        }
                                    }
                                    if (e.ColumnIndex == dgv.ColumnCount - 2)
                                    {
                                        if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                                        {
                                            frm_Sua_dich_vu frm = new frm_Sua_dich_vu(table.Rows[e.RowIndex][0].ToString(), this.frm);
                                            frm.Show();
                                        }
                                    }
                                }
                                else
                                {
                                    if (chucnang == "khachhang")
                                    {
                                        if (e.ColumnIndex == dgv.ColumnCount - 1)
                                        {
                                            if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                                            {
                                                frm_sua_khach_hang frm = new frm_sua_khach_hang(table.Rows[e.RowIndex][0].ToString(), this.frm);
                                                frm.Show();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (chucnang == "phieudatphong")
                                        {
                                            if (e.ColumnIndex == dgv.ColumnCount - 1)
                                            {
                                                if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                                                {
                                                    
                                                    if (MessageBox.Show("Bạn có chắc chắn muốn hủy phiếu đặt phòng " + dgv.Rows[e.RowIndex].Cells[0].Value.ToString() + " hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                                                    {
                                                        BUS_phieudatphong.DAO.xoa(table.Rows[e.RowIndex][0].ToString());
                                                        MessageBox.Show("Đã hủy thành công", "Thông báo");
                                                    }
                                                }
                                            }
                                            if (e.ColumnIndex == dgv.ColumnCount - 2)
                                            {
                                                if ((e.RowIndex < dgv.RowCount) && (e.RowIndex >= 0))
                                                {
                                                    frm_sua_phieu_dat_phong frm = new frm_sua_phieu_dat_phong(table.Rows[e.RowIndex][0].ToString(), this.frm);
                                                    frm.Show();
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (chucnang == "hoadonthue")
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
                                    }
                                }
                            }    
                        }    
                    }    
                }    
            }    
        }

        private void frmsearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        private void dgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
    }
}
