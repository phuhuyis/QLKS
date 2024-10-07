using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class DTO_thuephong
    {
        private String sohd;
        private String makh;
        private String tenkh;
        private String cmnd;
        private DateTime? ngayden;
        private DateTime? ngaydi;
        private String maphong;
        private String manv;

        public DTO_thuephong(string makh, string maphong, string manv)
        {
            this.makh = makh;
            this.maphong = maphong;
            this.manv = manv;
        }

        public DTO_thuephong(string sohd, string makh, DateTime? ngayden, DateTime? ngaydi, string maphong, string manv)
        {
            this.sohd = sohd;
            this.makh = makh;
            this.ngayden = ngayden;
            this.ngaydi = ngaydi;
            this.maphong = maphong;
            this.manv = manv;
        }

        public DTO_thuephong(string sohd, string tenkh, String cmnd, DateTime? ngayden, DateTime? ngaydi, string maphong, string manv)
        {
            this.sohd = sohd;
            this.tenkh = tenkh;
            this.cmnd = cmnd;
            this.ngayden = ngayden;
            this.ngaydi = ngaydi;
            this.maphong = maphong;
            this.manv = manv;
        }

        public DTO_thuephong(string sohd, string tenkh, String cmnd, string maphong, string manv)
        {
            this.sohd = sohd;
            this.tenkh = tenkh;
            this.cmnd = cmnd;
            this.maphong = maphong;
            this.manv = manv;
        }

        public string Sohd { get => sohd; set => sohd = value; }
        public string Makh { get => makh; set => makh = value; }
        public DateTime? Ngayden { get => ngayden; set => ngayden = value; }
        public DateTime? Ngaydi { get => ngaydi; set => ngaydi = value; }
        public string Maphong { get => maphong; set => maphong = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
    }
}
