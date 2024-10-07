using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class DTO_nhanvien
    {
        private String manv;
        private String tennv;
        private DateTime? ngaysinh;
        private String gioitinh;
        private String diachi;
        private String sdt;
        private int calamviec;
        private int tinhtrang;
        private long lcb;
        private double hsl;
        private String tendangnhap;

        public DTO_nhanvien(string manv, string tennv, DateTime? ngaysinh, string gioitinh, string diachi, string sdt, int calamviec, int tinhtrang, long lcb, double hsl, string tendangnhap)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.calamviec = calamviec;
            this.tinhtrang = tinhtrang;
            this.lcb = lcb;
            this.hsl = hsl;
            this.tendangnhap = tendangnhap;
        }

        public DTO_nhanvien(string manv, string tennv, DateTime? ngaysinh, string gioitinh, string diachi, string sdt, int calamviec, int tinhtrang, long lcb, double hsl)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.calamviec = calamviec;
            this.tinhtrang = tinhtrang;
            this.lcb = lcb;
            this.hsl = hsl;
        }

        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public DateTime? Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int Calamviec { get => calamviec; set => calamviec = value; }
        public int Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public long Lcb { get => lcb; set => lcb = value; }
        public double Hsl { get => hsl; set => hsl = value; }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
    }
}
