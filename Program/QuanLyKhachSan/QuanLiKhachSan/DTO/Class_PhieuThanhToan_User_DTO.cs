using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Class_PhieuThanhToan_User_DTO
    {
        private string sMaPTT;
        private string iSoNgay;
        private DateTime dNgayThanhToan;
        private float fTongTien;
        private float fVAT;
        private float fTienPhaiTra;
        private string sMaPDK;
        private string sMaNV;
        private int iSoGio;

        public Class_PhieuThanhToan_User_DTO()
        {
        }

        public Class_PhieuThanhToan_User_DTO(string sMaPTT, string iSoNgay, DateTime dNgayThanhToan, float fTongTien, float fVAT, float fTienPhaiTra, string sMaPDK, string sMaNV, int iSoGio)
        {
            this.SMaPTT = sMaPTT;
            this.ISoNgay = iSoNgay;
            this.DNgayThanhToan = dNgayThanhToan;
            this.FTongTien = fTongTien;
            this.FVAT = fVAT;
            this.FTienPhaiTra = fTienPhaiTra;
            this.SMaPDK = sMaPDK;
            this.SMaNV = sMaNV;
            this.ISoGio = iSoGio;
        }

        public string SMaPTT { get => sMaPTT; set => sMaPTT = value; }
        public string ISoNgay { get => iSoNgay; set => iSoNgay = value; }
        public DateTime DNgayThanhToan { get => dNgayThanhToan; set => dNgayThanhToan = value; }
        public float FTongTien { get => fTongTien; set => fTongTien = value; }
        public float FVAT { get => fVAT; set => fVAT = value; }
        public float FTienPhaiTra { get => fTienPhaiTra; set => fTienPhaiTra = value; }
        public string SMaPDK { get => sMaPDK; set => sMaPDK = value; }
        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public int ISoGio { get => iSoGio; set => iSoGio = value; }
    }
}
