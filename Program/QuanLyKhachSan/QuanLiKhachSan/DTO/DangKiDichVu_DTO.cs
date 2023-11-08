using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangKiDichVu_DTO
    {
        private string sMaPDK;
        private string sMaDV;
        private string sTenDV;
        private float fGiaDV;

        public DangKiDichVu_DTO()
        {
        }

        public DangKiDichVu_DTO(string sMaPDK, string sMaDV, string sTenDV, float fGiaDV)
        {
            this.SMaPDK = sMaPDK;
            this.SMaDV = sMaDV;
            this.STenDV = sTenDV;
            this.FGiaDV = fGiaDV;
        }

        public string SMaPDK { get => sMaPDK; set => sMaPDK = value; }
        public string SMaDV { get => sMaDV; set => sMaDV = value; }
        public string STenDV { get => sTenDV; set => sTenDV = value; }
        public float FGiaDV { get => fGiaDV; set => fGiaDV = value; }
    }
}
