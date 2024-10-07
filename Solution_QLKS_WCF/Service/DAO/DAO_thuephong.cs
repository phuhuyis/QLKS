using Service.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DAO
{
    public class DAO_thuephong
    {
        private static DAO_thuephong instance;
        public static DAO_thuephong DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_thuephong();
                }
                return instance;
            }
        }

        public DataTable loadkh()
        {
            return dataprovider.Dataprovider.cautv("loadkhthue", new object[] { });
        }

		public string taoma()
		{
			DataTable dt = dataprovider.Dataprovider.cautv("taosohd", new object[] { });
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

		public string taomakh()
		{
			DataTable dt = dataprovider.Dataprovider.cautv("taomakhachhang", new object[] { });
			String d;
			if (dt.Rows.Count == 0)
			{
				d = "kh001";
			}
			else
			{
				int a = int.Parse(dt.Rows[0][0].ToString().Substring(2));
				a++;
				d = "kh";
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

		public void thuephong(DTO_thuephong item)
        {
			dataprovider.Dataprovider.cautv("thuephongkc", new object[] { taoma(), item.Makh, item.Maphong, item.Manv });
        }

		public void thuephongkm(DTO_thuephong item)
		{
			dataprovider.Dataprovider.cautv("thuephongkm", new object[] { taoma(), taomakh(), item.Tenkh, item.Cmnd, item.Maphong, item.Manv });
		}

		public void chuyen(String sophong, String manv)
        {
			dataprovider.Dataprovider.cautv("chuyen", new object[] { taoma(), sophong, manv });
		}

		public bool kiemtraphong(String maphong)
        {
			if (dataprovider.Dataprovider.cautv("kiemtraphong", new object[] { maphong }).Rows.Count == 0)
            {
				return false;
            }
			return true;
        }
	}
}
