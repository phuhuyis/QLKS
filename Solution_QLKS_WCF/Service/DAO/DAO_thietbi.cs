using Service.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DAO
{
    public class DAO_thietbi
    {
		private static DAO_thietbi instance;
		public static DAO_thietbi DAO
		{
			get
			{
				if (instance == null)
				{
					instance = new DAO_thietbi();
				}
				return instance;
			}
		}

		public string taoma()
		{
			DataTable dt = dataprovider.Dataprovider.cautv("taomatb", new object[] { });
			String d;
			if (dt.Rows.Count == 0)
			{
				d = "tb001";
			}
			else
			{
				int a = int.Parse(dt.Rows[0][0].ToString().Substring(2));
				a++;
				d = "tb";
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
		public void them(DTO_thietbi item)
		{
			dataprovider.Dataprovider.cautv("themtb", new object[] { taoma(), item.Tentb, item.Dvt, item.Gia });
		}

		public DataTable tk(String key)
		{
			return dataprovider.Dataprovider.cautv("tktb", new object[] { key });
		}

		public void sua(DTO_thietbi item)
		{
			dataprovider.Dataprovider.cautv("suatb", new object[] { item.Matb, item.Tentb, item.Dvt, item.Gia });
		}

		public void xoa(String ma)
		{
			dataprovider.Dataprovider.cautv("xoatb", new object[] { ma });
		}

		public DataTable load(String ma)
		{
			return dataprovider.Dataprovider.cautv("taobangcntb", new object[] { ma });
		}
	}
}
