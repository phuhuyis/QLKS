using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class DTO_thietbi
    {
        private String matb;
        private String tentb;
        private String dvt;
        private decimal gia;

        public DTO_thietbi(string matb, string tentb, string dvt, decimal gia)
        {
            this.matb = matb;
            this.tentb = tentb;
            this.dvt = dvt;
            this.gia = gia;
        }

        public DTO_thietbi(string tentb, string dvt, decimal gia)
        {
            this.tentb = tentb;
            this.dvt = dvt;
            this.gia = gia;
        }

        public string Matb { get => matb; set => matb = value; }
        public string Tentb { get => tentb; set => tentb = value; }
        public string Dvt { get => dvt; set => dvt = value; }
        public decimal Gia { get => gia; set => gia = value; }
    }
}
