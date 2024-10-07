using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class DTO_donvicungcap
    {
        private String madv;
        private String tendv;
        private String sdt;
        private String diachi;

        public DTO_donvicungcap(string tendv, string sdt, string diachi)
        {
            this.tendv = tendv;
            this.sdt = sdt;
            this.diachi = diachi;
        }

        public DTO_donvicungcap(string madv, string tendv, string sdt, string diachi)
        {
            this.madv = madv;
            this.tendv = tendv;
            this.sdt = sdt;
            this.diachi = diachi;
        }

        public string Madv { get => madv; set => madv = value; }
        public string Tendv { get => tendv; set => tendv = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
