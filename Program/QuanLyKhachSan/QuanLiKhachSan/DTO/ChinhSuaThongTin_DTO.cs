using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChinhSuaThongTin_DTO
    {
        private string sMaP;
        private string sTenP;
        private string sTrangThai;
        private string sMaKP;
        private string sTenKP;
        private string sMaLP;
        private string sTenLP;
        private float fGiaTheoGio;
        private float fGiaTheoNgay;

        public ChinhSuaThongTin_DTO()
        {
        }

        public ChinhSuaThongTin_DTO(string sMaP, string sTenP, string sTrangThai, string sMaKP, string sTenKP, string sMaLP, string sTenLP, float fGiaTheoGio, float fGiaTheoNgay)
        {
            this.SMaP = sMaP;
            this.STenP = sTenP;
            this.STrangThai = sTrangThai;
            this.SMaKP = sMaKP;
            this.STenKP = sTenKP;
            this.SMaLP = sMaLP;
            this.STenLP = sTenLP;
            this.FGiaTheoGio = fGiaTheoGio;
            this.FGiaTheoNgay = fGiaTheoNgay;
        }

        public string SMaP { get => sMaP; set => sMaP = value; }
        public string STenP { get => sTenP; set => sTenP = value; }
        public string STrangThai { get => sTrangThai; set => sTrangThai = value; }
        public string SMaKP { get => sMaKP; set => sMaKP = value; }
        public string STenKP { get => sTenKP; set => sTenKP = value; }
        public string SMaLP { get => sMaLP; set => sMaLP = value; }
        public string STenLP { get => sTenLP; set => sTenLP = value; }
        public float FGiaTheoGio { get => fGiaTheoGio; set => fGiaTheoGio = value; }
        public float FGiaTheoNgay { get => fGiaTheoNgay; set => fGiaTheoNgay = value; }
    }
}
