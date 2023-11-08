using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        private string sMaTK;
        private string sTaiKhoan;
        private string sMatKhau;
        private int fK_iMaQuyen;

        public TaiKhoan_DTO(string sMaTK, string sTaiKhoan, string sMatKhau, int fK_iMaQuyen)
        {
            this.SMaTK = sMaTK;
            this.STaiKhoan = sTaiKhoan;
            this.SMatKhau = sMatKhau;
            FK_iMaQuyen = fK_iMaQuyen;
        }

        public TaiKhoan_DTO()
        {
        }
        public string SMaTK { get => sMaTK; set => sMaTK = value; }
        public string STaiKhoan { get => sTaiKhoan; set => sTaiKhoan = value; }
        public string SMatKhau { get => sMatKhau; set => sMatKhau = value; }
        public int FK_iMaQuyen { get => fK_iMaQuyen; set => fK_iMaQuyen = value; }
    }
}
