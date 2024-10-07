using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class DTO_cthd
    {
        private String sohd;
        private String madv;
        private int soluong;

        public DTO_cthd(string sohd, string madv)
        {
            this.sohd = sohd;
            this.madv = madv;
        }

        public DTO_cthd(string sohd, string madv, int soluong)
        {
            this.sohd = sohd;
            this.madv = madv;
            this.soluong = soluong;
        }

        public string Sohd { get => sohd; set => sohd = value; }
        public string Madv { get => madv; set => madv = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
