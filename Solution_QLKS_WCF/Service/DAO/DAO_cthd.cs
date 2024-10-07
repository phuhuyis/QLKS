using Service.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DAO
{
    public class DAO_cthd
    {
        private static DAO_cthd instance;
        public static DAO_cthd DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_cthd();
                }
                return instance;
            }
        }

        public DataTable laysohd(String maphong)
        {
            return dataprovider.Dataprovider.cautv("laysohd", new object[] { maphong });
        }

        public DataTable loadbanggiadv()
        {
            return dataprovider.Dataprovider.cautv("loadbanggiadv", new object[] { });
        }

        public DataTable loaddvdagoi(String sohd)
        {
            return dataprovider.Dataprovider.cautv("loaddvdagoi", new object[] { sohd });
        }

        public DataTable loaddsdv()
        {
            return dataprovider.Dataprovider.cautv("loaddsdv", new object[] { });
        }

        public void goidv(DTO_cthd item)
        {
            dataprovider.Dataprovider.cautv("goidv", new object[] { item.Sohd, item.Madv, item.Soluong });
        }

        public void capnhapdv(DTO_cthd item)
        {
            dataprovider.Dataprovider.cautv("capnhapdvhd", new object[] { item.Sohd, item.Madv, item.Soluong });
        }

        public void xoadv(DTO_cthd item)
        {
            dataprovider.Dataprovider.cautv("xoadvhd", new object[] { item.Sohd, item.Madv });
        }

        public bool kiemtradvtontai(String sohd, String madv)
        {
            if(dataprovider.Dataprovider.cautv("kiemtratontaidv", new object[] { sohd, madv }).Rows.Count > 0)
            {
                //ton tai dv
                return true;
            }
            return false;
        }

        public int laysldv(String ma)
        {
            return int.Parse(dataprovider.Dataprovider.cautv("laysldv", new object[] { ma }).Rows[0][0].ToString());
        }

        public int laysldvhd(String sohd, String ma)
        {
            return int.Parse(dataprovider.Dataprovider.cautv("laysldvhd", new object[] { sohd, ma }).Rows[0][0].ToString());
        }

        public bool kiemtratontaihd(String sohd)
        {
            if (dataprovider.Dataprovider.cautv("kiemtrasohd", new object[] { sohd }).Rows.Count > 0)
                return true;
            return false;
        }

        public void huyhd(String sohd)
        {
            dataprovider.Dataprovider.cautv("huyhoadon", new object[] { sohd });
        }

        public void thanhtoan(String sohd)
        {
            dataprovider.Dataprovider.cautv("thanhtoan", new object[] { sohd });
        }

        public DataTable inhdkodv(String sohd)
        {
            return dataprovider.Dataprovider.cautv("hoadonkodv", new object[] { sohd });
        }

        public DataTable inhdcodv(String sohd)
        {
            return dataprovider.Dataprovider.cautv("hoadoncodv", new object[] { sohd });
        }

        public bool kiemtratontaihdtt(String sohd)
        {
            if (dataprovider.Dataprovider.cautv("kiemtrasohdtt", new object[] { sohd }).Rows.Count > 0)
                return true;
            return false;
        }

        public bool kiemtratontaihdcthd(String sohd)
        {
            if (dataprovider.Dataprovider.cautv("kiemtrasohdcthd", new object[] { sohd }).Rows.Count > 0)
                return true;
            return false;
        }

        public DataTable tk(String key)
        {
            return dataprovider.Dataprovider.cautv("tkhoadonthue", new object[] { key });
        }
    }
}
