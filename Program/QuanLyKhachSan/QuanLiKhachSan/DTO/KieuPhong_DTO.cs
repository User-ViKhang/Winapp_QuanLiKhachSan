using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KieuPhong_DTO
    {
        private string sMaKP;
        private string sTenKP;
        private string sMoTa;

        public KieuPhong_DTO()
        {
        }

        public KieuPhong_DTO(string sMaKP, string sTenKP, string sMoTa)
        {
            this.SMaKP = sMaKP;
            this.STenKP = sTenKP;
            this.SMoTa = sMoTa;
        }

        public string SMaKP { get => sMaKP; set => sMaKP = value; }
        public string STenKP { get => sTenKP; set => sTenKP = value; }
        public string SMoTa { get => sMoTa; set => sMoTa = value; }
    }
}
