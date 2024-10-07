using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DAO
{
    public class DAO_thongke
    {
        private static DAO_thongke instance;
        public static DAO_thongke DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_thongke();
                }
                return instance;
            }
        }

        public DataTable thongkedoanhthu_chart(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            return dataprovider.Dataprovider.cautv("thongkedoanhthu", new object[] { ngaybatdau, ngayketthuc });
        }

        public DataTable thongkedoanhthuhd_chart(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            return dataprovider.Dataprovider.cautv("thongkedoanhthuhd", new object[] { ngaybatdau, ngayketthuc });
        }

        public DataTable thongkedoanhthu_table(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            return dataprovider.Dataprovider.cautv("thongkedoanhthuall", new object[] { ngaybatdau, ngayketthuc });
        }

        public DataTable thongkedoanhthu_chart(int nam)
        {
            return dataprovider.Dataprovider.cautv("thongkedoanhthunam", new object[] { nam });
        }

        public DataTable thongkedoanhthuhd_chart(int nam)
        {
            return dataprovider.Dataprovider.cautv("thongkedoanhthuhdnam", new object[] { nam });
        }

        public DataTable thongkedoanhthu_table(int nam)
        {
            return dataprovider.Dataprovider.cautv("thongkedoanhthuallnam", new object[] { nam });
        }

        public DataTable thongkedoanhthu_chart_thang(int thang, int nam)
        {
            return dataprovider.Dataprovider.cautv("thongkedoanhthuthang", new object[] { thang, nam });
        }

        public DataTable thongkedoanhthuhd_chart_thang(int thang, int nam)
        {
            return dataprovider.Dataprovider.cautv("thongkedoanhthuhdthang", new object[] { thang, nam });
        }

        public DataTable thongkedoanhthu_table_thang(int thang, int nam)
        {
            return dataprovider.Dataprovider.cautv("thongkedoanhthuallthang", new object[] { thang, nam });
        }

        public DataTable thongkesolanthue_nam(int nam)
        {
            return dataprovider.Dataprovider.cautv("thongkesolanthuenam", new object[] { nam });
        }

        public DataTable thongkesolanthue_thang(int thang, int nam)
        {
            return dataprovider.Dataprovider.cautv("thongkesolanthuethang", new object[] { thang, nam });
        }

        public DataTable thongkesolanthue_kcngay(DateTime ngaybd, DateTime ngaykt)
        {
            return dataprovider.Dataprovider.cautv("thongkesolanthuekcngay", new object[] { ngaybd, ngaykt });
        }

        public DataTable thongkeluong_thang(int thang, int nam)
        {
            return dataprovider.Dataprovider.cautv("thongkeluongthang", new object[] { thang, nam });
        }

        public DataTable thongkeluong_nam(int nam)
        {
            return dataprovider.Dataprovider.cautv("thongkeluongnam", new object[] { nam });
        }

        public DataTable thongkehdthue_kcngay(DateTime ngaybd, DateTime ngaykt)
        {
            return dataprovider.Dataprovider.cautv("thongkehdthuekcngay", new object[] { ngaybd, ngaykt });
        }

        public DataTable thongkehdthue_thang(int thang, int nam)
        {
            return dataprovider.Dataprovider.cautv("thongkehdthuethang", new object[] { thang, nam });
        }

        public DataTable thongkehdthue_nam(int nam)
        {
            return dataprovider.Dataprovider.cautv("thongkehdthuenam", new object[] { nam });
        }

        public DataTable thongketienravao_kcngay(DateTime ngaybd, DateTime ngaykt)
        {
            return dataprovider.Dataprovider.cautv("thongketienravaokcngay", new object[] { ngaybd, ngaykt });
        }

        public DataTable thongketienravao_thang(int thang, int nam)
        {
            return dataprovider.Dataprovider.cautv("thongketienravaothang", new object[] { thang, nam });
        }

        public DataTable thongketienravao_nam(int nam)
        {
            return dataprovider.Dataprovider.cautv("thongketienravaonam", new object[] { nam });
        }
    }
}
