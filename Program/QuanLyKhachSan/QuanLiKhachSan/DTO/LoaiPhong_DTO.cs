using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhong_DTO
    {
        private string sMaLP;
        private string sTenLP;
        private string sMoTa;

        public LoaiPhong_DTO()
        {
        }

        public LoaiPhong_DTO(string sMaLP, string sTenLP, string sMoTa)
        {
            this.SMaLP = sMaLP;
            this.STenLP = sTenLP;
            this.SMoTa = sMoTa;
        }

        public string SMaLP { get => sMaLP; set => sMaLP = value; }
        public string STenLP { get => sTenLP; set => sTenLP = value; }
        public string SMoTa { get => sMoTa; set => sMoTa = value; }
    }
}
