using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        private string sMaKH;
        private string sGioiTinh;
        private string sTenKH;
        private int iCMND;
        private string sDiaChi;
        private string sQuocTich;
        private int iSDT;
        private string sEmail;
        private DateTime dNamSinh;

        public string SMaKH { get => sMaKH; set => sMaKH = value; }
        public string SGioiTinh { get => sGioiTinh; set => sGioiTinh = value; }
        public string STenKH { get => sTenKH; set => sTenKH = value; }
        public int ICMND { get => iCMND; set => iCMND = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        public string SQuocTich { get => sQuocTich; set => sQuocTich = value; }
        public int ISDT { get => iSDT; set => iSDT = value; }
        public string SEmail { get => sEmail; set => sEmail = value; }
        public DateTime DNamSinh { get => dNamSinh; set => dNamSinh = value; }

        public KhachHang_DTO(string sMaKH, string sGioiTinh, string sTenKH, int iCMND, string sDiaChi, string sQuocTich, int iSDT, string sEmail, DateTime dNamSinh)
        {
            this.SMaKH = sMaKH;
            this.SGioiTinh = sGioiTinh;
            this.STenKH = sTenKH;
            this.ICMND = iCMND;
            this.SDiaChi = sDiaChi;
            this.SQuocTich = sQuocTich;
            this.ISDT = iSDT;
            this.SEmail = sEmail;
            this.DNamSinh = dNamSinh;
        }

        public KhachHang_DTO()
        {
        }

    }
}
