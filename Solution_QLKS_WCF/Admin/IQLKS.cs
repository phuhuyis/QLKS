using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Admin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQLKS" in both code and config file together.
    [ServiceContract]
    public interface IQLKS
    {
        //quan ly he thong
        [OperationContract]
        bool Login(String tendangnhap, String matkhau);
        [OperationContract]
        void themsocket(string tendangnhap);
        [OperationContract]
        void dangxuat(String tendangnhap);
        [OperationContract]
        bool kiemtratt(String tendangnhap);
        [OperationContract]
        bool kiemtramatkhaucu(String tendangnhap, String matkhau);
        [OperationContract]
        void doimatkhau(String tendangnhap, String matkhau);
        [OperationContract]
        int layquyen(String tendangnhap);
        [OperationContract]
        bool ktvohieuhoa(String tendangnhap);
        //quan ly nhan vien
        [OperationContract]
        void themnv(DataTable table, String tendangnhap);
        [OperationContract]
        DataTable searchnv(String key);
        [OperationContract]
        void xoanv(String manv);
        [OperationContract]
        DataTable laydlnv(String manv);
        [OperationContract]
        void capnhapnv(DataTable table);
        //tinh luong
        [OperationContract]
        bool kttinhluong();
        [OperationContract]
        DataTable loadluong();
        [OperationContract]
        bool ktnv();
        [OperationContract]
        void tinhluong(DataTable table);
        [OperationContract]
        void xoaluong();
        [OperationContract]
        DataTable tkluong(String key);
        [OperationContract]
        DataTable tkluong2(String key);
        [OperationContract]
        DataTable loadluongcn(String maphieu);
        [OperationContract]
        void capnhapluong(DataTable table);
        //quan ly don vi cung cap
        [OperationContract]
        void themdonvi(DataTable table);
        [OperationContract]
        DataTable tkdonvi(String key);
        [OperationContract]
        void suadonvi(DataTable table);
        [OperationContract]
        void xoadonvi(String madv);
        [OperationContract]
        DataTable load(String madv);
        //nhap dich vu
        [OperationContract]
        DataTable loaddvcc();
        [OperationContract]
        String taohdnhap(String madv);
        [OperationContract]
        void huyhd(String sohd);
        [OperationContract]
        DataTable loaddichvu();
        [OperationContract]
        void nhapdichvu(DataTable table);
        [OperationContract]
        DataTable xemhoadonnhapdichvu(String sohd);
        [OperationContract]
        DataTable timkiemhdnhap(String key);
        [OperationContract]
        DataTable inhd(String sohd);
        //quan ly loai phong
        [OperationContract]
        void themloaiphong(DataTable table);
        [OperationContract]
        DataTable tkloaiphong(String key);
        [OperationContract]
        void xoaloaiphong(String ma);
        [OperationContract]
        void sualoaiphong(DataTable table);
        [OperationContract]
        DataTable loadloaiphong2(String madv);
        //quan ly phong
        [OperationContract]
        void themphong(DataTable table);
        [OperationContract]
        DataTable tkphong(String key);
        [OperationContract]
        void xoaphong(String ma);
        [OperationContract]
        void suaphong(DataTable table);
        [OperationContract]
        DataTable loadphongql(String madv);
        [OperationContract]
        DataTable loadtbqlp();
        [OperationContract]
        DataTable loadtbtpqlp(String madv);
        [OperationContract]
        DataTable ktphong(String madv);
        [OperationContract]
        void sapxeptb(DataTable table);
        [OperationContract]
        DataTable loadtbtpqlp2(String madv);
        //quan ly thiet bi
        [OperationContract]
        void themthietbi(DataTable table);
        [OperationContract]
        DataTable tkthietbi(String key);
        [OperationContract]
        void xoathietbi(String ma);
        [OperationContract]
        void suathietbi(DataTable table);
        [OperationContract]
        DataTable loadthietbiql(String madv);
        //quan ly dich vu
        [OperationContract]
        void themdichvu(DataTable table);
        [OperationContract]
        DataTable tkdichvu(String key);
        [OperationContract]
        void xoadichvu(String ma);
        [OperationContract]
        void suadichvu(DataTable table);
        [OperationContract]
        DataTable loaddichvuql(String madv);
        //system nhan vien
        [OperationContract]
        DataTable loadloaiphong();
        [OperationContract]
        DataTable loadphong(String loaiphong);
        //quan ly khach hang
        [OperationContract]
        void themkhachhang(DataTable table);
        [OperationContract]
        DataTable tkkhachhang(String key);
        [OperationContract]
        void xoakhachhang(String ma);
        [OperationContract]
        void suakhachhang(DataTable table);
        [OperationContract]
        DataTable loadkhachhangql(String madv);
        //dat phong
        [OperationContract]
        DataTable loadkhdat();
        [OperationContract]
        void datphongkc(String makh, DateTime ngayden, String maphong);
        [OperationContract]
        void datphongkm(String tenkh, String cmnd, DateTime ngayden, String maphong);
        [OperationContract]
        bool kiemtraphong(String maphong);
        //thue phong
        [OperationContract]
        DataTable loadkhthue();
        [OperationContract]
        void thuephongkc(String makh, String maphong, String manv);
        [OperationContract]
        void thuephongkm(String tenkh, String cmnd, String maphong, String manv);
        [OperationContract]
        void chuyen(String sophong, String manv);
        //quan ly phieu dat phong
        [OperationContract]
        DataTable tkphieudatphong(String key);
        [OperationContract]
        void xoaphieudatphong(String ma);
        [OperationContract]
        void suaphieudatphong(DataTable table);
        [OperationContract]
        DataTable loadphieudatphong(String ma);
        //goi dich vu
        [OperationContract]
        String laysohd(String maphong);
        [OperationContract]
        DataTable loadbanggiadv();
        [OperationContract]
        DataTable loaddvdagoi(String sohd);
        [OperationContract]
        DataTable loaddsdv();
        [OperationContract]
        void goidv(String sohd, String madv, int sl);
        [OperationContract]
        void capnhapdv(String sohd, String madv, int sl);
        [OperationContract]
        void xoadv(String sohd, String madv);
        [OperationContract]
        bool kiemtradvtontai(String sohd, String madv);
        [OperationContract]
        int laysldv(String ma);
        [OperationContract]
        int laysldvhd(String sohd, String ma);
        [OperationContract]
        bool kiemtrasohd(String sohd);
        [OperationContract]
        void huyhdthue(String sohd);
        [OperationContract]
        void thanhtoan(String sohd);
        [OperationContract]
        DataTable inhdkodv(String sohd);
        [OperationContract]
        DataTable inhdcodv(String sohd);
        [OperationContract]
        bool kiemtratontaihdtt(String sohd);
        [OperationContract]
        bool kiemtratontaihdcthd(String sohd);
        [OperationContract]
        DataTable tkhoadonthue(String key);
        //thong ke doanh thu
        [OperationContract]
        DataTable thongkedoanhthu_chart(DateTime ngaybatdau, DateTime ngayketthuc);
        [OperationContract]
        DataTable thongkedoanhthuhd_chart(DateTime ngaybatdau, DateTime ngayketthuc);
        [OperationContract]
        DataTable thongkedoanhthu_table(DateTime ngaybatdau, DateTime ngayketthuc);
        [OperationContract]
        DataTable thongkedoanhthu_chart_nam(int nam);
        [OperationContract]
        DataTable thongkedoanhthuhd_chart_nam(int nam);
        [OperationContract]
        DataTable thongkedoanhthu_table_nam(int nam);
        [OperationContract]
        DataTable thongkedoanhthu_chart_thang(int thang, int nam);
        [OperationContract]
        DataTable thongkedoanhthuhd_chart_thang(int thang, int nam);
        [OperationContract]
        DataTable thongkedoanhthu_table_thang(int thang, int nam);
        [OperationContract]
        DataTable thongkesolanthue_nam(int nam);
        [OperationContract]
        DataTable thongkesolanthue_thang(int thang, int nam);
        [OperationContract]
        DataTable thongkesolanthue_kcngay(DateTime ngaybd, DateTime ngaykt);
        [OperationContract]
        DataTable thongkeluong_thang(int thang, int nam);
        [OperationContract]
        DataTable thongkeluong_nam(int nam);
        [OperationContract]
        DataTable thongkehdthue_kcngay(DateTime ngaybd, DateTime ngaykt);
        [OperationContract]
        DataTable thongkehdthue_thang(int thang, int nam);
        [OperationContract]
        DataTable thongkehdthue_nam(int nam);
        [OperationContract]
        DataTable thongketienravao_kcngay(DateTime ngaybd, DateTime ngaykt);
        [OperationContract]
        DataTable thongketienravao_thang(int thang, int nam);
        [OperationContract]
        DataTable thongketienravao_nam(int nam);
    }
}
