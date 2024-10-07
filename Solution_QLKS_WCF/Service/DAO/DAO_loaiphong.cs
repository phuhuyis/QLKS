using Service.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DAO
{
    public class DAO_loaiphong
    {
		private static DAO_loaiphong instance;
		public static DAO_loaiphong DAO
		{
			get
			{
				if (instance == null)
				{
					instance = new DAO_loaiphong();
				}
				return instance;
			}
		}

		public string taoma()
		{
			DataTable dt = dataprovider.Dataprovider.cautv("taomaloaiphong", new object[] { });
			String d;
			if (dt.Rows.Count == 0)
			{
				d = "lp001";
			}
			else
			{
				int a = int.Parse(dt.Rows[0][0].ToString().Substring(2));
				a++;
				d = "lp";
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
		public void them(DTO_loaiphong item)
		{
			dataprovider.Dataprovider.cautv("themloaiphong", new object[] { taoma(), item.Tenloai, item.Gia });
		}

		public DataTable tk(String key)
		{
			return dataprovider.Dataprovider.cautv("tkloaiphong", new object[] { key });
		}

		public void sua(DTO_loaiphong item)
		{
			dataprovider.Dataprovider.cautv("capnhaploaiphong", new object[] { item.Maloai, item.Tenloai, item.Gia });
		}

		public void xoa(String ma)
		{
			dataprovider.Dataprovider.cautv("xoaloaiphong", new object[] { ma });
		}

		public DataTable load(String ma)
		{
			return dataprovider.Dataprovider.cautv("loadloaiphongsua", new object[] { ma });
		}
	}
}
