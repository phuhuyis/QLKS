using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class DTO_phieudatphong
    {
        private String maphieu;
        private String makh;
        private String tenkh;
        private String cmnd;
        private DateTime? ngayden;
        private String maphong;

        public DTO_phieudatphong(string makh, DateTime? ngayden, string maphong)
        {
            this.makh = makh;
            this.ngayden = ngayden;
            this.maphong = maphong;
        }

        public DTO_phieudatphong(string maphieu, string makh, DateTime? ngayden, string maphong)
        {
            this.Maphieu = maphieu;
            this.Makh = makh;
            this.Ngayden = ngayden;
            this.Maphong = maphong;
        }

        public DTO_phieudatphong(string maphieu, DateTime? ngayden)
        {
            this.Maphieu = maphieu;
            this.Ngayden = ngayden;
        }

        public DTO_phieudatphong(string maphieu, string tenkh, string cmnd, DateTime? ngayden, string maphong)
        {
            this.maphieu = maphieu;
            this.tenkh = tenkh;
            this.cmnd = cmnd;
            this.ngayden = ngayden;
            this.maphong = maphong;
        }

        public string Maphieu { get => maphieu; set => maphieu = value; }
        public string Makh { get => makh; set => makh = value; }
        public DateTime? Ngayden { get => ngayden; set => ngayden = value; }
        public string Maphong { get => maphong; set => maphong = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
    }
}
