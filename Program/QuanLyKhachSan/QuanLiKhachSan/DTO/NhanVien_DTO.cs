using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string sMaNV;
        private string sTenNV;
        private string dNgaySinh;
        private string sGioiTinh;
        private int iCMND;
        private string sEmail;
        private int iSDT;

        public NhanVien_DTO()
        {
        }

        public NhanVien_DTO(string sMaNV, string sTenNV, string dNgaySinh, string sGioiTinh, int iCMND, string sEmail, int iSDT)
        {
            this.SMaNV = sMaNV;
            this.STenNV = sTenNV;
            this.DNgaySinh = dNgaySinh;
            this.SGioiTinh = sGioiTinh;
            this.ICMND = iCMND;
            this.SEmail = sEmail;
            this.ISDT = iSDT;
        }

        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public string STenNV { get => sTenNV; set => sTenNV = value; }
        public string DNgaySinh { get => dNgaySinh; set => dNgaySinh = value; }
        public string SGioiTinh { get => sGioiTinh; set => sGioiTinh = value; }
        public int ICMND { get => iCMND; set => iCMND = value; }
        public string SEmail { get => sEmail; set => sEmail = value; }
        public int ISDT { get => iSDT; set => iSDT = value; }
    }
}
