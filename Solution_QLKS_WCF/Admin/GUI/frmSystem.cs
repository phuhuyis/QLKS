using Admin.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class frmSystem : Form
    {
        Thread t1;
        public String user;
        TcpClient tcpclient;
        int quyen;
        public String loailp;

        public frmSystem(String us)
        {
            InitializeComponent();
            user = us.Trim();
            this.quyen = Program.qlks.layquyen(us);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(user);
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất hay không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.qlks.dangxuat(user.Trim());
            }    
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.qlks.dangxuat(user.Trim());
                frmLogin.thoat = true;
                /*Process[] pro = Process.GetProcesses();
                foreach (var pc in pro)
                    if (pc.ProcessName == this.ProductName.ToString())
                        pc.Kill();*/
            }
        }

        private void frmSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.qlks.dangxuat(user.Trim());
            t1.Abort();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(this);
            frm.Show();
        }

        private void frmSystem_Load(object sender, EventArgs e)
        {
            if (quyen == 1)
            {
                //admin
                flploaiphong.Visible = false;
                flpphong.Visible = false;
                quảnLýKháchHàngToolStripMenuItem.Visible = false;
                tìmKiếmPhiếuĐặtPhòngToolStripMenuItem.Visible = false;
                xemHóaĐơnThuêPhòngToolStripMenuItem.Visible = false;
                xemDanhSáchDịchVụToolStripMenuItem.Visible = false;
                xemDanhSáchThiếtBịToolStripMenuItem.Visible = false;
                xemDanhSáchLoạiPhòngToolStripMenuItem.Visible = false;
                DataTable dt1 = Program.qlks.thongkedoanhthu_chart_thang(DateTime.Now.Month, DateTime.Now.Year);
                chart.Series[0].Points.AddXY(dt1.Rows[0][0].ToString(), int.Parse(dt1.Rows[0][1].ToString()));
                chart.Series[0].Points.AddXY(dt1.Rows[1][0].ToString(), int.Parse(dt1.Rows[1][1].ToString()));
                chart.Series[0].Points[0].IsValueShownAsLabel = true;
                chart.Series[0].Points[1].IsValueShownAsLabel = true;
                chart.Series[0].Points[0].LabelFormat = "#,0 'đ'";
                chart.Series[0].Points[1].LabelFormat = "#,0 'đ'";
            }   
            else
            {
                //nhan vien
                this.BackgroundImage = null;
                this.BackColor = Color.White;
                quảnLýDịchVụToolStripMenuItem.Visible = false;
                báoCáoThốngKêToolStripMenuItem.Visible = false;
                quảnLýLoạiPhòngToolStripMenuItem.Visible = false;
                quảnLýLươngNhânViênToolStripMenuItem.Visible = false;
                quảnLýNhânViênToolStripMenuItem.Visible = false;
                quảnLýPhòngToolStripMenuItem.Visible = false;
                quảnLýThiếtBịToolStripMenuItem.Visible = false;
                quảnLýĐơnVịCungCấpToolStripMenuItem.Visible = false;
                chart.Visible = false;
            }
            if(quyen != 1)
            {
                BUS_system.DAO.loadloaiphong(flploaiphong);
                BUS_system.DAO.loadphong("lp000", flpphong, this);
            }
            tcpclient = new TcpClient();
            tcpclient.Connect(config.ipsocket, config.portsocket);
            BUS_Login.DAO.themsocket(user.Trim());
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
                            this.Hide();
                            t1.Abort();
                        }));
                    }
                    if(quyen != 1)
                    {
                        if (content == "themloaiphong")
                        {
                            Invoke(new Action(() =>
                            {
                                BUS_system.DAO.loadloaiphong(flploaiphong);
                            }));
                        }
                        else
                        {
                            if (content == "xoaloaiphong")
                            {
                                Invoke(new Action(() =>
                                {
                                    BUS_system.DAO.loadloaiphong(flploaiphong);
                                    BUS_system.DAO.loadphong(loailp, flpphong, this);
                                }));
                            }
                            else
                            {
                                if (content == "sualoaiphong")
                                {
                                    Invoke(new Action(() =>
                                    {
                                        BUS_system.DAO.loadloaiphong(flploaiphong);
                                        BUS_system.DAO.loadphong(loailp, flpphong, this);
                                    }));
                                }
                                else
                                {
                                    if (content == "themphong")
                                    {
                                        Invoke(new Action(() =>
                                        {
                                            BUS_system.DAO.loadphong(loailp, flpphong, this);
                                        }));
                                    }
                                    else
                                    {
                                        if (content == "xoaphong")
                                        {
                                            Invoke(new Action(() =>
                                            {
                                                BUS_system.DAO.loadphong(loailp, flpphong, this);
                                            }));
                                        }
                                        else
                                        {
                                            if (content == "themphong")
                                            {
                                                Invoke(new Action(() =>
                                                {
                                                    BUS_system.DAO.loadphong(loailp, flpphong, this);
                                                }));
                                            }
                                            else
                                            {
                                                if (content == "suaphong")
                                                {
                                                    Invoke(new Action(() =>
                                                    {
                                                        BUS_system.DAO.loadphong(loailp, flpphong, this);
                                                    }));
                                                }
                                                else
                                                {
                                                    if (content.Contains("datphongkc"))
                                                    {
                                                        Invoke(new Action(() =>
                                                        {
                                                            BUS_system.DAO.loadphong(loailp, flpphong, this);
                                                        }));
                                                    }
                                                    else
                                                    {
                                                        if (content.Contains("thuephongkc"))
                                                        {
                                                            Invoke(new Action(() =>
                                                            {
                                                                BUS_system.DAO.loadphong(loailp, flpphong, this);
                                                            }));
                                                        }
                                                        else
                                                        {
                                                            if (content.Contains("datphongkm"))
                                                            {
                                                                Invoke(new Action(() =>
                                                                {
                                                                    BUS_system.DAO.loadphong(loailp, flpphong, this);
                                                                }));
                                                            }
                                                            else
                                                            {
                                                                if (content.Contains("thuephongkm"))
                                                                {
                                                                    Invoke(new Action(() =>
                                                                    {
                                                                        BUS_system.DAO.loadphong(loailp, flpphong, this);
                                                                    }));
                                                                }
                                                                else
                                                                {
                                                                    if (content == "chuyenphong")
                                                                    {
                                                                        Invoke(new Action(() =>
                                                                        {
                                                                            BUS_system.DAO.loadphong(loailp, flpphong, this);
                                                                        }));
                                                                    }
                                                                    else
                                                                    {
                                                                        if (content == "suaphieudatphong")
                                                                        {
                                                                            Invoke(new Action(() =>
                                                                            {
                                                                                BUS_system.DAO.loadphong(loailp, flpphong, this);
                                                                            }));
                                                                        }
                                                                        else
                                                                        {
                                                                            if (content == "xoaphieudatphong")
                                                                            {
                                                                                Invoke(new Action(() =>
                                                                                {
                                                                                    BUS_system.DAO.loadphong(loailp, flpphong, this);
                                                                                }));
                                                                            }
                                                                            else
                                                                            {
                                                                                if (content.Contains("huyhd"))
                                                                                {
                                                                                    Invoke(new Action(() =>
                                                                                    {
                                                                                        BUS_system.DAO.loadphong(loailp, flpphong, this);
                                                                                    }));
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (content.Contains("thanhtoan"))
                                                                                    {
                                                                                        Invoke(new Action(() =>
                                                                                        {
                                                                                            BUS_system.DAO.loadphong(loailp, flpphong, this);
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
            });
            t1.Start();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmadd frm = new frmadd("nhanvien", this);
            frm.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsearch frm = new frmsearch("nhanvien", this);
            frm.Show();
        }

        private void tínhLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(BUS_luong.DAO.kttinhluong())
            {
                if(BUS_luong.DAO.ktnv())
                {
                    frmtinhluong frm = new frmtinhluong(this);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Chưa thêm nhân viên nào cả", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
            else
            {
                MessageBox.Show("Đã tính lương tháng này cho nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void xóaTấtCảLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!BUS_luong.DAO.kttinhluong())
            {
                if (BUS_luong.DAO.ktnv())
                {
                    if(MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả lương của nhân viên trong tháng này hay không?","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        MessageBox.Show("Xóa thành công");
                        BUS_luong.DAO.xoaluong();
                    }    
                }
                else
                {
                    MessageBox.Show("Chưa thêm nhân viên nào cả", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa tính lương tháng này cho nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cậpNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtimkiemluong frm = new frmtimkiemluong(this);
            frm.Show();
        }

        private void thêmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmadd frm = new frmadd("donvi", this);
            frm.Show();
        }

        private void tìmKiếmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmsearch frm = new frmsearch("donvi", this);
            frm.Show();
        }

        private void nhậpDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if(BUS_nhapdichvu.DAO.ktdvcc())
            {
                frmnhapdichvu frm = new frmnhapdichvu();
                frm.Show();
            }*/
        }

        private void thêmToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmadd frm = new frmadd("loaiphong", this);
            frm.Show();
        }

        private void tìmKiếmToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmsearch frm = new frmsearch("loaiphong", this);
            frm.Show();
        }

        private void thêmToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (BUS_phong.DAO.ktlp())
            {
                frmadd frm = new frmadd("phong", this);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Chưa có loại phòng nào cả hãy thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void tìmKiếmToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmsearch frm = new frmsearch("phong", this);
            frm.Show();
        }

        private void thêmToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmadd frm = new frmadd("thietbi", this);
            frm.Show();
        }

        private void tìmKiếmToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmsearch frm = new frmsearch("thietbi", this);
            frm.Show();
        }

        private void thêmToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmadd frm = new frmadd("dichvu", this);
            frm.Show();
        }

        private void tìmKiếmToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmsearch frm = new frmsearch("dichvu", this);
            frm.Show();
        }

        private void nhậpDịchVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (BUS_nhapdichvu.DAO.ktdvcc())
            {
                frmnhapdichvu frm = new frmnhapdichvu(this);
                frm.Show();
            }
        }

        private void xemHóaĐơnNhậpDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemHóaĐơnNhậpDịchVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmXemHD frm = new frmXemHD(this);
            frm.Show();
        }

        private void thêmToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmadd frm = new frmadd("khachhang", this);
            frm.Show();
        }

        private void tìmKiếmToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmsearch frm = new frmsearch("khachhang", this);
            frm.Show();
        }

        private void xemDanhSáchDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemdanhsach frm = new xemdanhsach("dichvu", this);
            frm.Show();
        }

        private void xemDanhSáchLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemdanhsach frm = new xemdanhsach("loaiphong", this);
            frm.Show();
        }

        private void xemDanhSáchThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtimphong frm = new frmtimphong("phong", this);
            frm.Show();
        }

        private void tìmKiếmPhiếuĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsearch frm = new frmsearch("phieudatphong", this);
            frm.Show();
        }

        private void xemHóaĐơnThuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsearch frm = new frmsearch("hoadonthue", this);
            frm.Show();
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thốngKêTheoKhoảngThờiGianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthongkedoanhthu_khoangtg frm = new frmthongkedoanhthu_khoangtg(this);
            frm.Show();
        }

        private void thốngKêTheoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthongkedoanhthunam frm = new frmthongkedoanhthunam(this);
            frm.Show();
        }

        private void thốngKêTheoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthongkedoanhthuthang frm = new frmthongkedoanhthuthang(this);
            frm.Show();
        }

        private void thốngKêTheoKhoảngThờiGianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmthongke_solanthue_kcngay frm = new frmthongke_solanthue_kcngay(this);
            frm.Show();
        }

        private void thốngKêTheoNămToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmthongke_solanthue_nam frm = new frmthongke_solanthue_nam(this);
            frm.Show();
        }

        private void thốngKêTheoThángToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmthongke_solanthue_thang frm = new frmthongke_solanthue_thang(this);
            frm.Show();
        }

        private void thốngKêTheoThángToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmthongkeluong_thang frm = new frmthongkeluong_thang(this);
            frm.Show();
        }

        private void thốngKêTheoNămToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmthongkeluong_nam frm = new frmthongkeluong_nam(this);
            frm.Show();
        }

        private void thốngKêTheoThángToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frm_tk_hdthue_thang frm = new frm_tk_hdthue_thang(this);
            frm.Show();
        }

        private void thốngKêTheoNămToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frm_tk_hdthue_nam frm = new frm_tk_hdthue_nam(this);
            frm.Show();
        }

        private void thốngKêTheoKhoảngThờiGianToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_tk_hdthue_kcngay frm = new frm_tk_hdthue_kcngay(this);
            frm.Show();
        }

        private void thốngKêTheoThángToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frm_thongke_luongtienravao_thang frm = new frm_thongke_luongtienravao_thang(this);
            frm.Show();
        }

        private void thốngKêTheoNămToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frm_thongke_luongtienravao_nam frm = new frm_thongke_luongtienravao_nam(this);
            frm.Show();
        }

        private void thốngKêTheoKhoảngThờiGianToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frm_thongke_luongtienravao_kcngay frm = new frm_thongke_luongtienravao_kcngay(this);
            frm.Show();
        }
    }
}
