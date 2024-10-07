using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ADMIN2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQLKS" in both code and config file together.
    [ServiceContract]
    public interface IQLKS
    {
        //quan ly he thong
        [OperationContract]
        bool Login(String tendangnhap, String matkhau, int quyen);
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
    }
}
