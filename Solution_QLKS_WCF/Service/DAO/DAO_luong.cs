using Service.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DAO
{
    public class DAO_luong
    {
        private static DAO_luong instance;
        public static DAO_luong DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_luong();
                }
                return instance;
            }
        }
        public DataTable load()
        {
            return dataprovider.Dataprovider.cautv("bangtinhluong2", new object[] { });
        }
        public DataTable ktnv()
        {
            return dataprovider.Dataprovider.cautv("bangtinhluong", new object[] { });
        }
        public void themluong(DTO_luong item)
        {
            dataprovider.Dataprovider.cautv("themluong", new object[] { item.Maluong, item.Manv, item.Songaynghi, item.Thuongthem });
        }

        public DataTable tkluong(String key)
        {
            return dataprovider.Dataprovider.cautv("tkluong", new object[] { key });
        }

        public DataTable loadluongcn(String maph)
        {
            return dataprovider.Dataprovider.cautv("loadluongcn", new object[] { maph });
        }

        public void capnhapluong(DTO_luong item)
        {
            dataprovider.Dataprovider.cautv("capnhapluong", new object[] { item.Maluong, item.Songaynghi, item.Thuongthem });
        }
    }
}
