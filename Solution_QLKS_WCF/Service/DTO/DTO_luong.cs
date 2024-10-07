using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class DTO_luong
    {
        private String maluong;
        private String manv;
        private DateTime? ngaytinhluong;
        private int songaynghi;
        private long thuongthem;

        public DTO_luong(string maluong, string manv, int songaynghi, long thuongthem)
        {
            this.maluong = maluong;
            this.manv = manv;
            this.songaynghi = songaynghi;
            this.thuongthem = thuongthem;
        }

        public DTO_luong(string maluong, int songaynghi, long thuongthem)
        {
            this.maluong = maluong;
            this.songaynghi = songaynghi;
            this.thuongthem = thuongthem;
        }

        public DTO_luong(string maluong, string manv, DateTime? ngaytinhluong, int songaynghi, long thuongthem)
        {
            this.maluong = maluong;
            this.manv = manv;
            this.ngaytinhluong = ngaytinhluong;
            this.songaynghi = songaynghi;
            this.thuongthem = thuongthem;
        }

        public string Maluong { get => maluong; set => maluong = value; }
        public string Manv { get => manv; set => manv = value; }
        public DateTime? Ngaytinhluong { get => ngaytinhluong; set => ngaytinhluong = value; }
        public int Songaynghi { get => songaynghi; set => songaynghi = value; }
        public long Thuongthem { get => thuongthem; set => thuongthem = value; }
    }
}
