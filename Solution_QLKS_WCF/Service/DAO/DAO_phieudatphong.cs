using Service.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DAO
{
    public class DAO_phieudatphong
    {
        private static DAO_phieudatphong instance;
        public static DAO_phieudatphong DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_phieudatphong();
                }
                return instance;
            }
        }

        public DataTable tk(String key)
        {
            return dataprovider.Dataprovider.cautv("tkphieudatphong", new object[] { key });
        }

        public void sua(DTO_phieudatphong item)
        {
            dataprovider.Dataprovider.cautv("suaphieu", new object[] { item.Maphieu, item.Ngayden });
        }

        public void xoa(String ma)
        {
            dataprovider.Dataprovider.cautv("xoaphieu", new object[] { ma });
        }

        public DataTable load(String ma)
        {
            return dataprovider.Dataprovider.cautv("loadphieu", new object[] { ma });
        }
    }
}
