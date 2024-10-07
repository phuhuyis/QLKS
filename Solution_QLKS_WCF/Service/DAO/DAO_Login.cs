using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.DTO;

namespace Service.DAO
{
    public class DAO_Login
    {
        public static List<String> luser = new List<string>();
        private static DAO_Login instance;
        public static DAO_Login DAO
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_Login();
                }
                return instance;
            }
        }
        
        public void themuser(String tendangnhap)
        {
            luser.Add(tendangnhap);
        }

        public bool dangnhap(String tendangnhap, String matkhau)
        {
            DataTable table = dataprovider.Dataprovider.cautv("laythongtin", new object[] { tendangnhap });
            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                DTO_nguoidung nguoidung = new DTO_nguoidung(tendangnhap, table.Rows[0][0].ToString(), int.Parse(table.Rows[0][1].ToString()), int.Parse(table.Rows[0][2].ToString()));
                if (String.Compare(encrytion.Decrypt(nguoidung.Matkhau), matkhau, true) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public int layquyen(String tendangnhap)
        {
            DataTable table = dataprovider.Dataprovider.cautv("laythongtin", new object[] { tendangnhap });
            DTO_nguoidung nguoidung = new DTO_nguoidung(tendangnhap, table.Rows[0][0].ToString(), int.Parse(table.Rows[0][1].ToString()), int.Parse(table.Rows[0][2].ToString()));
            return nguoidung.Quyen;
        }

        public bool kiemtratt(String tendangnhap)
        {
            DataTable table = dataprovider.Dataprovider.cautv("laythongtin", new object[] { tendangnhap });
            DTO_nguoidung nguoidung = new DTO_nguoidung(tendangnhap, table.Rows[0][0].ToString(), int.Parse(table.Rows[0][1].ToString()), int.Parse(table.Rows[0][2].ToString()));
            if (nguoidung.Tinhtrang == 0)
            {
                if(nguoidung.Quyen == 1)
                {
                    dataprovider.Dataprovider.cautv("dangnhap", new object[] { tendangnhap });
                    //luser.Add(tendangnhap);
                }    
                else
                {
                    if (!ktvohieuhoa(tendangnhap))
                    {
                        dataprovider.Dataprovider.cautv("dangnhap", new object[] { tendangnhap });
                        //luser.Add(tendangnhap);
                    }
                }  
                return true;
            }
            else
            {
                return false;
            }
        }

        public void dangxuat(String tendangnhap)
        {
            dataprovider.Dataprovider.cautv("dangxuat", new object[] { tendangnhap });
        }

        public bool kiemtramatkhaucu(String tendangnhap, String matkhau)
        {
            DataTable table = dataprovider.Dataprovider.cautv("laythongtin", new object[] { tendangnhap });
            DTO_nguoidung nguoidung = new DTO_nguoidung(tendangnhap, table.Rows[0][0].ToString(), int.Parse(table.Rows[0][1].ToString()), int.Parse(table.Rows[0][2].ToString()));
            if (String.Compare(encrytion.Decrypt(nguoidung.Matkhau), matkhau, true) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void doimatkhau(String tendangnhap, String matkhau)
        {
            dataprovider.Dataprovider.cautv("doimk", new object[] { tendangnhap, encrytion.Encrypt(matkhau) });
        }

        public bool ktvohieuhoa(String tendangnhap)
        {
            DataTable table = dataprovider.Dataprovider.cautv("laytrangthainv", new object[] { tendangnhap });
            if(String.Compare(table.Rows[0][0].ToString(),"1", true) == 0)
            {
                return true;
            }    
            else
            {
                return false;
            }    
        }
    }
}
