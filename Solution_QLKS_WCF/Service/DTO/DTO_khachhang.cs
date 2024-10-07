using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class DTO_khachhang
    {
        private String makh;
        private String hoten;
        private String cmnd;

        public DTO_khachhang(string hoten, string cmnd)
        {
            this.hoten = hoten;
            this.cmnd = cmnd;
        }

        public DTO_khachhang(string makh, string hoten, string cmnd)
        {
            this.makh = makh;
            this.hoten = hoten;
            this.cmnd = cmnd;
        }

        public DTO_khachhang(string makh, string hoten, int a)
        {
            this.makh = makh;
            this.hoten = hoten;
        }

        public string Makh { get => makh; set => makh = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
    }
}
