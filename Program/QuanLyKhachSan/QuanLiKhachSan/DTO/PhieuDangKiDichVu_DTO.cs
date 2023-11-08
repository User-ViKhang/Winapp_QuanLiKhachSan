using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDangKiDichVu_DTO
    {
        private string sMaPDK;
        private string sMaDV;

        public PhieuDangKiDichVu_DTO()
        {
        }

        public PhieuDangKiDichVu_DTO(string sMaPDK, string sMaDV)
        {
            this.SMaPDK = sMaPDK;
            this.SMaDV = sMaDV;
        }

        public string SMaPDK { get => sMaPDK; set => sMaPDK = value; }
        public string SMaDV { get => sMaDV; set => sMaDV = value; }
    }
}
