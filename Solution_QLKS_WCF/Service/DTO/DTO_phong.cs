using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class DTO_phong
    {
        private String maphong;
        private String tenphong;
        private int tinhtrang;
        private string loai;

        public DTO_phong(string tenphong, string loai)
        {
            this.tenphong = tenphong;
            this.loai = loai;
        }

        public DTO_phong(string maphong, string tenphong, string loai)
        {
            this.maphong = maphong;
            this.tenphong = tenphong;
            this.loai = loai;
        }

        public DTO_phong(string maphong, string tenphong, int tinhtrang, string loai)
        {
            this.maphong = maphong;
            this.tenphong = tenphong;
            this.tinhtrang = tinhtrang;
            this.loai = loai;
        }

        public string Maphong { get => maphong; set => maphong = value; }
        public string Tenphong { get => tenphong; set => tenphong = value; }
        public int Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public string Loai { get => loai; set => loai = value; }
    }
}
