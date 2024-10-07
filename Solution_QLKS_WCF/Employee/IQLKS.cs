using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Employee
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQLKS" in both code and config file together.
    [ServiceContract]
    public interface IQLKS
    {
        //quan ly he thong
        [OperationContract]
        bool Login(String tendangnhap, String matkhau, int quyen);
        [OperationContract]
        void dangxuat(String tendangnhap);
        [OperationContract]
        bool kiemtratt(String tendangnhap);
        [OperationContract]
        bool kiemtramatkhaucu(String tendangnhap, String matkhau);
        [OperationContract]
        void doimatkhau(String tendangnhap, String matkhau);
        [OperationContract]
        void themsocket(string tendangnhap);
        [OperationContract]
        bool ktvohieuhoa(String tendangnhap);
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
        [OperationContract]
        DataTable tkloaiphong(String key);
        [OperationContract]
        DataTable loadtbtpqlp2(String madv);
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
        //dat phong
        [OperationContract]
        DataTable loadkhdat();
        [OperationContract]
        void datphongkc(String makh, DateTime ngayden, String maphong);
        [OperationContract]
        bool kiemtraphong(String maphong);
        //thue phong
        [OperationContract]
        DataTable loadkhthue();
        [OperationContract]
        void thuephongkc(String makh, String maphong, String manv);
    }
}
