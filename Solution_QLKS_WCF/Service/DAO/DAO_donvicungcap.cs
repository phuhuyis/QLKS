using Service.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DAO
{
    public class DAO_donvicungcap
    {
        private static DAO_donvicungcap instance;
        public static DAO_donvicungcap DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_donvicungcap();
                }
                return instance;
            }
        }

        public string taoma()
        {
			DataTable dt = dataprovider.Dataprovider.cautv("taomadonvi", new object[] { });
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

        public void them(DTO_donvicungcap item)
        {
			dataprovider.Dataprovider.cautv("themdonvi", new object[] { taoma(), item.Tendv, item.Sdt, item.Diachi });
        }

		public DataTable tkdonvi(String key)
        {
			return dataprovider.Dataprovider.cautv("tkdonvi", new object[] { key });
        }

		public void sua(DTO_donvicungcap item)
		{
			dataprovider.Dataprovider.cautv("suadonvi", new object[] { item.Madv, item.Tendv, item.Sdt, item.Diachi });
		}

		public void xoa(String ma)
		{
			dataprovider.Dataprovider.cautv("xoadonvi", new object[] { ma });
		}

		public DataTable load(String ma)
		{
			return dataprovider.Dataprovider.cautv("loaddonvi", new object[] { ma });
		}
	}
}
