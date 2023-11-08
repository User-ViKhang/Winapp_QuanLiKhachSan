using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class XuatHoaDon_DTO
    {
        private string sMaHD;
        private int iSoNgay;
        private int iSoGio;
        private DateTime dNgayThanhToan;
        private float fTongTien;
        private float fVAT;
        private float fTienPhaiTra;
        private string sTenNV;
        private string sMaNV;
        private string sSoP;
        private string sMaKH;
        private string sTenKH;
        private string sMaP;
        private string sTenP;
        private float fGiaTheoGio;
        private float fGiaTheoNgay;
        private string sTenLP;
        private float fTraTruoc;
        private string sTenKP;

        public XuatHoaDon_DTO()
        {
        }

        public XuatHoaDon_DTO(string sMaHD, int iSoNgay, int iSoGio, DateTime dNgayThanhToan, float fTongTien, float fVAT, float fTienPhaiTra, string sTenNV, string sMaNV, string sSoP, string sMaKH, string sTenKH, string sMaP, string sTenP, float fGiaTheoGio, float fGiaTheoNgay, string sTenLP, float fTraTruoc, string sTenKP)
        {
            this.SMaHD = sMaHD;
            this.ISoNgay = iSoNgay;
            this.ISoGio = iSoGio;
            this.DNgayThanhToan = dNgayThanhToan;
            this.FTongTien = fTongTien;
            this.FVAT = fVAT;
            this.FTienPhaiTra = fTienPhaiTra;
            this.STenNV = sTenNV;
            this.SMaNV = sMaNV;
            this.SSoP = sSoP;
            this.SMaKH = sMaKH;
            this.STenKH = sTenKH;
            this.SMaP = sMaP;
            this.STenP = sTenP;
            this.FGiaTheoGio = fGiaTheoGio;
            this.FGiaTheoNgay = fGiaTheoNgay;
            this.STenLP = sTenLP;
            this.FTraTruoc = fTraTruoc;
            this.STenKP = sTenKP;
        }

        public string SMaHD { get => sMaHD; set => sMaHD = value; }
        public int ISoNgay { get => iSoNgay; set => iSoNgay = value; }
        public int ISoGio { get => iSoGio; set => iSoGio = value; }
        public DateTime DNgayThanhToan { get => dNgayThanhToan; set => dNgayThanhToan = value; }
        public float FTongTien { get => fTongTien; set => fTongTien = value; }
        public float FVAT { get => fVAT; set => fVAT = value; }
        public float FTienPhaiTra { get => fTienPhaiTra; set => fTienPhaiTra = value; }
        public string STenNV { get => sTenNV; set => sTenNV = value; }
        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public string SSoP { get => sSoP; set => sSoP = value; }
        public string SMaKH { get => sMaKH; set => sMaKH = value; }
        public string STenKH { get => sTenKH; set => sTenKH = value; }
        public string SMaP { get => sMaP; set => sMaP = value; }
        public string STenP { get => sTenP; set => sTenP = value; }
        public float FGiaTheoGio { get => fGiaTheoGio; set => fGiaTheoGio = value; }
        public float FGiaTheoNgay { get => fGiaTheoNgay; set => fGiaTheoNgay = value; }
        public string STenLP { get => sTenLP; set => sTenLP = value; }
        public float FTraTruoc { get => fTraTruoc; set => fTraTruoc = value; }
        public string STenKP { get => sTenKP; set => sTenKP = value; }
    }
}
