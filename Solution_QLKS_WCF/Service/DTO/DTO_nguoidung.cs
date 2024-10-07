using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class DTO_nguoidung
    {
        private String tendangnhap;
        private String matkhau;
        private int quyen;
        private int tinhtrang;

        public DTO_nguoidung(string tendangnhap, string matkhau, int quyen, int tinhtrang)
        {
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.quyen = quyen;
            this.tinhtrang = tinhtrang;
        }

        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int Quyen { get => quyen; set => quyen = value; }
        public int Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
    }
}
