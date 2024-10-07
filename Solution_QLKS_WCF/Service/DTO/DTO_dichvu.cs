using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class DTO_dichvu
    {
        private String ma;
        private String ten;
        private String dvt;
        private Decimal gia;
        private int soluong;

        public DTO_dichvu(string ten, string dvt, decimal gia)
        {
            this.ten = ten;
            this.dvt = dvt;
            this.gia = gia;
        }

        public DTO_dichvu(string ten, string dvt, decimal gia, int soluong)
        {
            this.ten = ten;
            this.dvt = dvt;
            this.gia = gia;
            this.soluong = soluong;
        }

        public DTO_dichvu(string ma, string ten, string dvt, decimal gia)
        {
            this.ma = ma;
            this.ten = ten;
            this.dvt = dvt;
            this.gia = gia;
        }

        public DTO_dichvu(string ma, string ten, string dvt, decimal gia, int soluong)
        {
            this.ma = ma;
            this.ten = ten;
            this.dvt = dvt;
            this.gia = gia;
            this.soluong = soluong;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Dvt { get => dvt; set => dvt = value; }
        public decimal Gia { get => gia; set => gia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
