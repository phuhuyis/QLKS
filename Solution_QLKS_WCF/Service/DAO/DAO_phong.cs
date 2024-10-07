using Service.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DAO
{
    public class DAO_phong
    {
		private static DAO_phong instance;
		public static DAO_phong DAO
		{
			get
			{
				if (instance == null)
				{
					instance = new DAO_phong();
				}
				return instance;
			}
		}

		public string taoma()
		{
			DataTable dt = dataprovider.Dataprovider.cautv("taomaphong", new object[] { });
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
		public void them(DTO_phong item)
		{
			dataprovider.Dataprovider.cautv("themphong", new object[] { taoma(), item.Tenphong, item.Loai });
		}

		public DataTable tk(String key)
		{
			return dataprovider.Dataprovider.cautv("tkphong", new object[] { key });
		}

		public void sua(DTO_phong item)
		{
			dataprovider.Dataprovider.cautv("capnhapphong", new object[] { item.Maphong, item.Tenphong, item.Loai });
		}

		public void xoa(String ma)
		{
			dataprovider.Dataprovider.cautv("xoaphong", new object[] { ma });
		}

		public DataTable load(String ma)
		{
			return dataprovider.Dataprovider.cautv("loadphongsua", new object[] { ma });
		}

		public DataTable loadtb()
		{
			return dataprovider.Dataprovider.cautv("tktb", new object[] { "" });
		}

		public DataTable loadtbtp(String ma)
		{
			return dataprovider.Dataprovider.cautv("loadtbtp", new object[] { ma });
		}

		public DataTable ktphong(String ma)
        {
			return dataprovider.Dataprovider.cautv("ktphong", new object[] { ma });
		}

		public string taoma2()
		{
			DataTable dt = dataprovider.Dataprovider.cautv("taomasxtb", new object[] { });
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

		public void them2(DTO_tttp item)
		{
			dataprovider.Dataprovider.cautv("sapxeptb", new object[] { taoma2(), item.Maphong, item.Matb, item.Sl });
		}

		public void xoa2(String ma)
        {
			dataprovider.Dataprovider.cautv("xoaalltb", new object[] { ma });
		}

		public DataTable loadtbtp2(String ma)
		{
			return dataprovider.Dataprovider.cautv("loadtbtp2", new object[] { ma });
		}
	}
}
