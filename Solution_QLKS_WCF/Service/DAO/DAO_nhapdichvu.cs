using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DAO
{
    public class DAO_nhapdichvu
    {
        private static DAO_nhapdichvu instance;
        public static DAO_nhapdichvu DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_nhapdichvu();
                }
                return instance;
            }
        }

        public DataTable loaddv()
        {
            return dataprovider.Dataprovider.cautv("loaddvcc", new object[] { });
        }

		public string taoma()
		{
			DataTable dt = dataprovider.Dataprovider.cautv("taosohdnhap", new object[] { });
			String d;
			if (dt.Rows.Count == 0)
			{
				d = "hd001";
			}
			else
			{
				int a = int.Parse(dt.Rows[0][0].ToString().Substring(2));
				a++;
				d = "hd";
				if (a >= 100)
				{
					d += a.ToString();
				}
				else
				{
					if (a >= 10)
					{
						d += "0" + a.ToString();
					}
					else
					{
						d += "00" + a.ToString();
					}
				}
			}
			return d;
		}

		public String taohdnhap(String madonvi)
        {
			String sohd = taoma();
			dataprovider.Dataprovider.cautv("taohoadonnhap", new object[] { sohd, madonvi });
			return sohd;
        }

		public void huyhd(String sohd)
        {
			dataprovider.Dataprovider.cautv("huyhoadonnhap", new object[] { sohd });
        }

		public DataTable loaddichvu()
        {
			return dataprovider.Dataprovider.cautv("loaddichvu", new object[] { });
        }

		public void nhapdv(String sohd, String madv, long gia, int soluong)
        {
			dataprovider.Dataprovider.cautv("nhapdichvu", new object[] { sohd, madv, gia, soluong });
        }

		public DataTable inhoadon(String sohd)
        {
			return dataprovider.Dataprovider.cautv("xemhoadonnhap", new object[] { sohd });
		}

		public DataTable timkiemhd(String key)
        {
			return dataprovider.Dataprovider.cautv("timkiemhdnhap", new object[] { key });
		}

		public DataTable inhd(String sohd)
		{
			return dataprovider.Dataprovider.cautv("xemhoadonnhap", new object[] { sohd });
		}
	}
}
