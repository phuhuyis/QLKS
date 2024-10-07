using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Service.DAO;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "QLKS" in both code and config file together.
    public class QLKS : IQLKS
    {
        private static Server server = new Server();

        //quan ly he thong
        public bool Login(String tendangnhap, String matkhau)
        {
            return server.Login(tendangnhap, matkhau);
        }

        public void dangxuat(String tendangnhap)
        {
            server.dangxuat(tendangnhap);
        }

        public bool kiemtratt(String tendangnhap)
        {
            return server.kiemtratt(tendangnhap);
        }

        public bool kiemtramatkhaucu(string tendangnhap, string matkhau)
        {
            return server.kiemtramatkhaucu(tendangnhap, matkhau);
        }
        public void doimatkhau(String tendangnhap, String matkhau)
        {
            server.doimatkhau(tendangnhap, matkhau);
        }
        public void themsocket(string tendangnhap)
        {
            server.themsocket(tendangnhap);
        }
        public bool ktvohieuhoa(String tendangnhap)
        {
            return server.ktvohieuhoa(tendangnhap);
        }

        public int layquyen(String tendangnhap)
        {
            return server.layquyen(tendangnhap);
        }

        //quan ly nhan vien
        public void themnv(DataTable table, String tendangnhap)
        {
            server.themnv(table, tendangnhap);
        }

        public DataTable searchnv(string key)
        {
            return server.searchnv(key);
        }

        public void xoanv(string manv)
        {
            server.xoanv(manv);
        }

        public DataTable laydlnv(string manv)
        {
            return server.laydlnv(manv);
        }

        public void capnhapnv(DataTable table)
        {
            server.capnhapnv(table);
        }
        //quan ly luong
        public bool kttinhluong()
        {
            return server.kttinhluong();
        }

        public DataTable loadluong()
        {
            return server.loadluong();
        }

        public bool ktnv()
        {
            return server.ktnv();
        }

        public void tinhluong(DataTable table)
        {
            server.tinhluong(table);
        }

        public void xoaluong()
        {
            server.xoaluong();
        }

        public DataTable tkluong(string key)
        {
            return server.tkluong(key);
        }

        public DataTable tkluong2(string key)
        {
            return server.tkluong2(key);
        }

        public DataTable loadluongcn(string maphieu)
        {
            return server.loadluongcn(maphieu);
        }

        public void capnhapluong(DataTable table)
        {
            server.capnhapluong(table);
        }

        public void themdonvi(DataTable table)
        {
            server.themdonvicungcap(table);
        }

        public DataTable tkdonvi(string key)
        {
            return server.tkdonvi(key);
        }

        public void suadonvi(DataTable table)
        {
            server.suadonvi(table);
        }

        public void xoadonvi(string madv)
        {
            server.xoadonvi(madv);
        }

        public DataTable load(string madv)
        {
            return server.load(madv);
        }
        //nhap dich vu
        public DataTable loaddvcc()
        {
            return server.loaddvcc();
        }

        public string taohdnhap(string madv)
        {
            return server.taohdnhap(madv);
        }

        public void huyhd(string sohd)
        {
            server.huyhd(sohd);
        }

        public DataTable loaddichvu()
        {
            return server.loaddichvu();
        }

        public void nhapdichvu(DataTable table)
        {
            server.nhapdichvu(table);
        }

        public DataTable xemhoadonnhapdichvu(String sohd)
        {
            return server.xemhoadonnhapdichvu(sohd);
        }

        public DataTable timkiemhdnhap(String key)
        {
            return server.timkiemhdnhap(key);
        }

        public DataTable inhd(String sohd)
        {
            return server.inhd(sohd);
        }

        //system nhan vien
        public DataTable loadloaiphong()
        {
            return server.loadloaiphong();
        }

        public DataTable loadphong(string loaiphong)
        {
            return server.loadphong(loaiphong);
        }
        //quan ly loai phong
        public void themloaiphong(DataTable table)
        {
            server.themloaiphong(table);
        }

        public DataTable tkloaiphong(string key)
        {
            return server.tkloaiphong(key);
        }

        public void xoaloaiphong(string ma)
        {
            server.xoaloaiphong(ma);
        }

        public void sualoaiphong(DataTable table)
        {
            server.sualoaiphong(table);
        }

        public DataTable loadloaiphong2(string madv)
        {
            return server.loadloaiphong(madv);
        }
        //quan ly phong
        public void themphong(DataTable table)
        {
            server.themphong(table);
        }

        public DataTable tkphong(string key)
        {
            return server.tkphong(key);
        }

        public void xoaphong(string ma)
        {
            server.xoaphong(ma);
        }

        public void suaphong(DataTable table)
        {
            server.suaphong(table);
        }

        public DataTable loadphongql(string madv)
        {
            return server.loadphongql(madv);
        }

        public DataTable loadtbqlp()
        {
            return server.loadtbqlp();
        }

        public DataTable loadtbtpqlp(string madv)
        {
            return server.loadtbtpqlp(madv);
        }

        public DataTable ktphong(string madv)
        {
            return server.ktphong(madv);
        }

        public void sapxeptb(DataTable table)
        {
            server.sapxeptb(table);
        }

        public DataTable loadtbtpqlp2(string madv)
        {
            return server.loadtbtpqlp2(madv);
        }

        //quan ly thiet bi
        public void themthietbi(DataTable table)
        {
            server.themthietbi(table);
        }

        public DataTable tkthietbi(string key)
        {
            return server.tkthietbi(key);
        }

        public void xoathietbi(string ma)
        {
            server.xoathietbi(ma);
        }

        public void suathietbi(DataTable table)
        {
            server.suathietbi(table);
        }

        public DataTable loadthietbiql(string madv)
        {
            return server.loadthietbiql(madv);
        }

        //quan ly dich vu
        public void themdichvu(DataTable table)
        {
            server.themdichvu(table);
        }

        public DataTable tkdichvu(string key)
        {
            return server.tkdichvu(key);
        }

        public void xoadichvu(string ma)
        {
            server.xoadichvu(ma);
        }

        public void suadichvu(DataTable table)
        {
            server.suadichvu(table);
        }

        public DataTable loaddichvuql(string madv)
        {
            return server.loaddichvuql(madv);
        }

        //quan ly khach hang
        public void themkhachhang(DataTable table)
        {
            server.themkhachhang(table);
        }

        public DataTable tkkhachhang(string key)
        {
            return server.tkkhachhang(key);
        }

        public void xoakhachhang(string ma)
        {
            server.xoakhachhang(ma);
        }

        public void suakhachhang(DataTable table)
        {
            server.suakhachhang(table);
        }

        public DataTable loadkhachhangql(string madv)
        {
            return server.loadkhachhangql(madv);
        }

        //dat phong
        public DataTable loadkhdat()
        {
            return server.loadkhdat();
        }

        public void datphongkc(string makh, DateTime ngayden, string maphong)
        {
            server.datphongkc(makh, ngayden, maphong);
        }

        public void datphongkm(String tenkh, String cmnd, DateTime ngayden, String maphong)
        {
            server.datphongkm(tenkh, cmnd, ngayden, maphong);
        }

        public bool kiemtraphong(string maphong)
        {
            return server.kiemtraphong(maphong);
        }

        //thue phong
        public DataTable loadkhthue()
        {
            return server.loadkhthue();
        }

        public void thuephongkc(string makh, string maphong, String manv)
        {
            server.thuephongkc(makh, maphong, manv);
        }

        public void thuephongkm(string tenkh, string cmnd, string maphong, String manv)
        {
            server.thuephongkm(tenkh, cmnd, maphong, manv);
        }

        public void chuyen(string sophong, string manv)
        {
            server.chuyen(sophong, manv);
        }

        //quan ly phieu dat phong
        public DataTable tkphieudatphong(string key)
        {
            return server.tkphieudatphong(key);
        }

        public void xoaphieudatphong(string ma)
        {
            server.xoaphieudatphong(ma);
        }

        public void suaphieudatphong(DataTable table)
        {
            server.suaphieudatphong(table);
        }

        public DataTable loadphieudatphong(string ma)
        {
            return server.loadphieudatphong(ma);
        }

        //goi dich vu
        public String laysohd(String maphong)
        {
            return server.laysohd(maphong);
        }

        public DataTable loadbanggiadv()
        {
            return server.loadbanggiadv();
        }

        public DataTable loaddvdagoi(String sohd)
        {
            return server.loaddvdagoi(sohd);
        }

        public DataTable loaddsdv()
        {
            return server.loaddsdv();
        }

        public void goidv(String sohd, String madv, int sl)
        {
            server.goidv(sohd, madv, sl);
        }

        public void capnhapdv(String sohd, String madv, int sl)
        {
            server.capnhapdv(sohd, madv, sl);
        }

        public void xoadv(String sohd, String madv)
        {
            server.xoadv(sohd, madv);
        }

        public bool kiemtradvtontai(String sohd, String madv)
        {
            return server.kiemtradvtontai(sohd, madv);
        }

        public int laysldv(String ma)
        {
            return server.laysldv(ma);
        }

        public int laysldvhd(String sohd, String ma)
        {
            return server.laysldvhd(sohd, ma);
        }

        public bool kiemtrasohd(String sohd)
        {
            return server.kiemtrasohd(sohd);
        }

        public void huyhdthue(String sohd)
        {
            server.huyhdthue(sohd);
        }

        public void thanhtoan(String sohd)
        {
            server.thanhtoan(sohd);
        }

        public DataTable inhdkodv(String sohd)
        {
            return server.inhdkodv(sohd);
        }

        public DataTable inhdcodv(String sohd)
        {
            return server.inhdcodv(sohd);
        }

        public bool kiemtratontaihdtt(String sohd)
        {
            return server.kiemtratontaihdtt(sohd);
        }

        public bool kiemtratontaihdcthd(String sohd)
        {
            return server.kiemtratontaihdcthd(sohd);
        }

        public DataTable tkhoadonthue(String key)
        {
            return server.tkhoadonthue(key);
        }

        public DataTable thongkedoanhthu_chart(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            return server.thongkedoanhthu_chart(ngaybatdau, ngayketthuc);
        }

        public DataTable thongkedoanhthuhd_chart(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            return server.thongkedoanhthuhd_chart(ngaybatdau, ngayketthuc);
        }

        public DataTable thongkedoanhthu_table(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            return server.thongkedoanhthu_table(ngaybatdau, ngayketthuc);
        }

        public DataTable thongkedoanhthu_chart_nam(int nam)
        {
            return server.thongkedoanhthu_chart_nam(nam);
        }

        public DataTable thongkedoanhthuhd_chart_nam(int nam)
        {
            return server.thongkedoanhthuhd_chart_nam(nam);
        }

        public DataTable thongkedoanhthu_table_nam(int nam)
        {
            return server.thongkedoanhthu_table_nam(nam);
        }

        public DataTable thongkedoanhthu_chart_thang(int thang, int nam)
        {
            return server.thongkedoanhthu_chart_thang(thang, nam);
        }

        public DataTable thongkedoanhthuhd_chart_thang(int thang, int nam)
        {
            return server.thongkedoanhthuhd_chart_thang(thang, nam);
        }

        public DataTable thongkedoanhthu_table_thang(int thang, int nam)
        {
            return server.thongkedoanhthu_table_thang(thang, nam);
        }

        public DataTable thongkesolanthue_nam(int nam)
        {
            return server.thongkesolanthue_nam(nam);
        }

        public DataTable thongkesolanthue_thang(int thang, int nam)
        {
            return server.thongkesolanthue_thang(thang, nam);
        }

        public DataTable thongkesolanthue_kcngay(DateTime ngaybd, DateTime ngaykt)
        {
            return server.thongkesolanthue_kcngay(ngaybd, ngaykt);
        }

        public DataTable thongkeluong_thang(int thang, int nam)
        {
            return server.thongkeluong_thang(thang, nam);
        }

        public DataTable thongkeluong_nam(int nam)
        {
            return server.thongkeluong_nam(nam);
        }

        public DataTable thongkehdthue_kcngay(DateTime ngaybd, DateTime ngaykt)
        {
            return server.thongkehdthue_kcngay(ngaybd, ngaykt);
        }

        public DataTable thongkehdthue_thang(int thang, int nam)
        {
            return server.thongkehdthue_thang(thang, nam);
        }

        public DataTable thongkehdthue_nam(int nam)
        {
            return server.thongkehdthue_nam(nam);
        }

        public DataTable thongketienravao_kcngay(DateTime ngaybd, DateTime ngaykt)
        {
            return server.thongketienravao_kcngay(ngaybd, ngaykt);
        }

        public DataTable thongketienravao_thang(int thang, int nam)
        {
            return server.thongketienravao_thang(thang, nam);
        }

        public DataTable thongketienravao_nam(int nam)
        {
            return server.thongketienravao_nam(nam);
        }
    }
}
