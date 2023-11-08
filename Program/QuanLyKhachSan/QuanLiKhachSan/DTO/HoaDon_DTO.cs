using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        private string sMaPTT;
        private string sMaKH;
        private string sMaNV;
        private DateTime sThanhToan;
        private int iSoNgay;
        private int iSoGio;
        private float fTongTien;
        private float fPhaiTra;
        private float fThue;

        public HoaDon_DTO()
        {
        }

        public HoaDon_DTO(string sMaPTT, string sMaKH, string sMaNV, DateTime sThanhToan, int iSoNgay, int iSoGio, float fTongTien, float fPhaiTra, float fThue)
        {
            this.SMaPTT = sMaPTT;
            this.SMaKH = sMaKH;
            this.SMaNV = sMaNV;
            this.SThanhToan = sThanhToan;
            this.ISoNgay = iSoNgay;
            this.ISoGio = iSoGio;
            this.FTongTien = fTongTien;
            this.FPhaiTra = fPhaiTra;
            this.FThue = fThue;
        }

        public string SMaPTT { get => sMaPTT; set => sMaPTT = value; }
        public string SMaKH { get => sMaKH; set => sMaKH = value; }
        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public DateTime SThanhToan { get => sThanhToan; set => sThanhToan = value; }
        public int ISoNgay { get => iSoNgay; set => iSoNgay = value; }
        public int ISoGio { get => iSoGio; set => iSoGio = value; }
        public float FTongTien { get => fTongTien; set => fTongTien = value; }
        public float FPhaiTra { get => fPhaiTra; set => fPhaiTra = value; }
        public float FThue { get => fThue; set => fThue = value; }
    }
}
