using Service.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DAO
{
    public class DAO_dichvu
    {
		private static DAO_dichvu instance;
		public static DAO_dichvu DAO
		{
			get
			{
				if (instance == null)
				{
					instance = new DAO_dichvu();
				}
				return instance;
			}
		}

		public string taoma()
		{
			DataTable dt = dataprovider.Dataprovider.cautv("taomadichvu", new object[] { });
			String d;
			if (dt.Rows.Count == 0)
			{
				d = "dv001";
			}
			else
			{
				int a = int.Parse(dt.Rows[0][0].ToString().Substring(2));
				a++;
				d = "dv";
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

		public void them(DTO_dichvu item)
		{
			dataprovider.Dataprovider.cautv("themdichvu", new object[] { taoma(), item.Ten, item.Dvt, item.Gia });
		}

		public DataTable tk(String key)
		{
			return dataprovider.Dataprovider.cautv("tkdichvu", new object[] { key });
		}

		public void sua(DTO_dichvu item)
		{
			dataprovider.Dataprovider.cautv("suadichvu", new object[] { item.Ma, item.Ten, item.Dvt, item.Gia });
		}

		public void xoa(String ma)
		{
			dataprovider.Dataprovider.cautv("xoadichvu", new object[] { ma });
		}

		public DataTable load(String ma)
		{
			return dataprovider.Dataprovider.cautv("taobangcndichvu", new object[] { ma });
		}
	}
}
