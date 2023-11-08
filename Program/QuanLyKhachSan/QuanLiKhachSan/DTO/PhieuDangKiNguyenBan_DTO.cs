using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDangKiNguyenBan_DTO
    {
        private string sMaPhieu;
        private string iSoPhong;
        private float fTraTruoc;
        private DateTime dNgayDen;
        private DateTime dNgayDi;
        private int iSoGio;
        private string sMaKhach;
        private string sMaNhanVien;

        public PhieuDangKiNguyenBan_DTO()
        {
        }

        public PhieuDangKiNguyenBan_DTO(string sMaPhieu, string iSoPhong, float fTraTruoc, DateTime dNgayDen, DateTime dNgayDi, int iSoGio, string sMaKhach, string sMaNhanVien)
        {
            this.SMaPhieu = sMaPhieu;
            this.ISoPhong = iSoPhong;
            this.FTraTruoc = fTraTruoc;
            this.DNgayDen = dNgayDen;
            this.DNgayDi = dNgayDi;
            this.ISoGio = iSoGio;
            this.SMaKhach = sMaKhach;
            this.SMaNhanVien = sMaNhanVien;
        }

        public string SMaPhieu { get => sMaPhieu; set => sMaPhieu = value; }
        public string ISoPhong { get => iSoPhong; set => iSoPhong = value; }
        public float FTraTruoc { get => fTraTruoc; set => fTraTruoc = value; }
        public DateTime DNgayDen { get => dNgayDen; set => dNgayDen = value; }
        public DateTime DNgayDi { get => dNgayDi; set => dNgayDi = value; }
        public int ISoGio { get => iSoGio; set => iSoGio = value; }
        public string SMaKhach { get => sMaKhach; set => sMaKhach = value; }
        public string SMaNhanVien { get => sMaNhanVien; set => sMaNhanVien = value; }
    }
}
