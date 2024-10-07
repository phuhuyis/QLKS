using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class DTO_tttp
    {
        private string maphieu;
        private string maphong;
        private string matb;
        private int sl;

        public DTO_tttp(string maphong, string matb, int sl)
        {
            this.maphong = maphong;
            this.matb = matb;
            this.sl = sl;
        }

        public string Maphieu { get => maphieu; set => maphieu = value; }
        public string Maphong { get => maphong; set => maphong = value; }
        public string Matb { get => matb; set => matb = value; }
        public int Sl { get => sl; set => sl = value; }
    }
}
