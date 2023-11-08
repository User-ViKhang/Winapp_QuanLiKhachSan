using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Class_TraPhong_PhieuDangKi_User_DTO
    {
        private string sMaPDK;
        private string sTenKH;
        private string sSoP;
        private DateTime dNgayDen;
        private DateTime dNgayDi;
        private int iSoGio;
        private float fTraTruoc;
        private string sMaP;
        private string sMaKH;
        private string sMaNV;

        public Class_TraPhong_PhieuDangKi_User_DTO()
        {
        }

        public Class_TraPhong_PhieuDangKi_User_DTO(string sMaPDK, string sTenKH, string sSoP, DateTime dNgayDen, DateTime dNgayDi, int iSoGio, float fTraTruoc, string sMaP, string sMaKH, string sMaNV)
        {
            this.SMaPDK = sMaPDK;
            this.STenKH = sTenKH;
            this.SSoP = sSoP;
            this.DNgayDen = dNgayDen;
            this.DNgayDi = dNgayDi;
            this.ISoGio = iSoGio;
            this.FTraTruoc = fTraTruoc;
            this.SMaP = sMaP;
            this.SMaKH = sMaKH;
            this.SMaNV = sMaNV;
        }

        public string SMaPDK { get => sMaPDK; set => sMaPDK = value; }
        public string STenKH { get => sTenKH; set => sTenKH = value; }
        public string SSoP { get => sSoP; set => sSoP = value; }
        public DateTime DNgayDen { get => dNgayDen; set => dNgayDen = value; }
        public DateTime DNgayDi { get => dNgayDi; set => dNgayDi = value; }
        public int ISoGio { get => iSoGio; set => iSoGio = value; }
        public float FTraTruoc { get => fTraTruoc; set => fTraTruoc = value; }
        public string SMaP { get => sMaP; set => sMaP = value; }
        public string SMaKH { get => sMaKH; set => sMaKH = value; }
        public string SMaNV { get => sMaNV; set => sMaNV = value; }
    }
}
