using Service.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DAO
{
    public class DAO_datphong
    {
        private static DAO_datphong instance;
        public static DAO_datphong DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_datphong();
                }
                return instance;
            }
        }

        public DataTable loadkh()
        {
            return dataprovider.Dataprovider.cautv("loadkhdat", new object[] { });
        }

		public string taoma()
		{
			DataTable dt = dataprovider.Dataprovider.cautv("taomaphieu", new object[] { });
			String d;
			if (dt.Rows.Count == 0)
			{
				d = "ph001";
			}
			else
			{
				int a = int.Parse(dt.Rows[0][0].ToString().Substring(2));
				a++;
				d = "ph";
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

		public void datphong(DTO_phieudatphong item)
        {
			dataprovider.Dataprovider.cautv("datphongkc", new object[] { taoma(), item.Makh, item.Ngayden, item.Maphong });
        }

		public void datphongkm(DTO_phieudatphong item)
		{
			dataprovider.Dataprovider.cautv("datphongkm", new object[] { taoma(), taomakh(), item.Tenkh, item.Cmnd, item.Ngayden, item.Maphong });
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
