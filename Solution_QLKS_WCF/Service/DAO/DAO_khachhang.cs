using Service.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DAO
{
    public class DAO_khachhang
    {
		private static DAO_khachhang instance;
		public static DAO_khachhang DAO
		{
			get
			{
				if (instance == null)
				{
					instance = new DAO_khachhang();
				}
				return instance;
			}
		}

		public string taoma()
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

		public void them(DTO_khachhang item)
		{
			dataprovider.Dataprovider.cautv("themkhachhang", new object[] { taoma(), item.Hoten, item.Cmnd });
		}

		public DataTable tk(String key)
		{
			return dataprovider.Dataprovider.cautv("tkkhachhang", new object[] { key });
		}

		public void sua(DTO_khachhang item)
		{
			dataprovider.Dataprovider.cautv("suakhachhang", new object[] { item.Makh, item.Hoten, item.Cmnd });
		}

		public void xoa(String ma)
		{
			dataprovider.Dataprovider.cautv("xoakhachhang", new object[] { ma });
		}

		public DataTable load(String ma)
		{
			return dataprovider.Dataprovider.cautv("taobangcnkhachhang", new object[] { ma });
		}
	}
}
