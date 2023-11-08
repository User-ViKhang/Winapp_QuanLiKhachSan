using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhSachDichVu_DTO
    {
        private string sMaDV;
        private string sTenDV;
        private float fGiaDV;

        public DanhSachDichVu_DTO()
        {
        }

        public DanhSachDichVu_DTO(string sMaDV, string sTenDV, float fGiaDV)
        {
            this.SMaDV = sMaDV;
            this.STenDV = sTenDV;
            this.FGiaDV = fGiaDV;
        }

        public string SMaDV { get => sMaDV; set => sMaDV = value; }
        public string STenDV { get => sTenDV; set => sTenDV = value; }
        public float FGiaDV { get => fGiaDV; set => fGiaDV = value; }
    }
}
