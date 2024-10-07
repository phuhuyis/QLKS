using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DAO
{
    public class DAO_systemnhanvien
    {
        private static DAO_systemnhanvien instance;
        public static DAO_systemnhanvien DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_systemnhanvien();
                }
                return instance;
            }
        }

        public DataTable loadloaiphong()
        {
            return dataprovider.Dataprovider.cautv("loadloaiphong", new object[] { });
        }

        public DataTable loadphong(String loaiphong)
        {
            return dataprovider.Dataprovider.cautv("loadphong", new object[] { loaiphong });
        }

        public DataTable sophongtrong(String loaiphong)
        {
            return dataprovider.Dataprovider.cautv("sophongtrong", new object[] { loaiphong });
        }
    }
}
