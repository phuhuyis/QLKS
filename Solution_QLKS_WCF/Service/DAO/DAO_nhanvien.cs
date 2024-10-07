using Service.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DAO
{
    public class DAO_nhanvien
    {
        private static DAO_nhanvien instance;
        public static DAO_nhanvien DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_nhanvien();
                }
                return instance;
            }
        }

        public void them(DTO_nhanvien item, String matkhau)
        {
            dataprovider.Dataprovider.cautv("themnv", new object[] { item.Manv, item.Tennv, item.Ngaysinh, item.Gioitinh, item.Diachi, item.Sdt, item.Calamviec, matkhau, item.Lcb, item.Hsl });
        }

        public DataTable search(String key)
        {
            DataTable table = dataprovider.Dataprovider.cautv("tknv", new object[] { key });
            table.TableName = "searchnv";
            foreach(DataRow row in table.Rows)
            {
                row[table.Columns.Count - 1] = encrytion.Decrypt(row[table.Columns.Count - 1].ToString());
            }
            return table;
        }

        public void xoanv(String manv)
        {
            dataprovider.Dataprovider.cautv("xoanv", new object[] { manv });
        }

        public DataTable laydl(String manv)
        {
            return dataprovider.Dataprovider.cautv("loadbangnv", new object[] { manv });
        }

        public void capnhap(DTO_nhanvien item)
        {
            dataprovider.Dataprovider.cautv("capnhapnv", new object[] { item.Manv, item.Tennv, item.Ngaysinh, item.Gioitinh, item.Diachi, item.Sdt, item.Calamviec, item.Lcb, item.Hsl, item.Tinhtrang });
        }
    }
}
