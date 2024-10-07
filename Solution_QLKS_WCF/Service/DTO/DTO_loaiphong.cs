using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class DTO_loaiphong
    {
        private String maloai;
        private String tenloai;
        private long gia;

        public DTO_loaiphong(string maloai, string tenloai, long gia)
        {
            this.maloai = maloai;
            this.tenloai = tenloai;
            this.gia = gia;
        }

        public DTO_loaiphong(string tenloai, long gia)
        {
            this.tenloai = tenloai;
            this.gia = gia;
        }

        public string Maloai { get => maloai; set => maloai = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
        public long Gia { get => gia; set => gia = value; }
    }
}
