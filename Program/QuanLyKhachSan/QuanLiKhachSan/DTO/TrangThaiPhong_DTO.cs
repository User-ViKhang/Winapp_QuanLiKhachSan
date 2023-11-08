using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrangThaiPhong_DTO
    {
        private string sMaP;
        private string sTenP;
        private string sTrangThai;

        public TrangThaiPhong_DTO()
        {
        }

        public TrangThaiPhong_DTO(string sMaP, string sTenP, string sTrangThai)
        {
            this.SMaP = sMaP;
            this.STenP = sTenP;
            this.STrangThai = sTrangThai;
        }

        public string SMaP { get => sMaP; set => sMaP = value; }
        public string STenP { get => sTenP; set => sTenP = value; }
        public string STrangThai { get => sTrangThai; set => sTrangThai = value; }
    }
}
