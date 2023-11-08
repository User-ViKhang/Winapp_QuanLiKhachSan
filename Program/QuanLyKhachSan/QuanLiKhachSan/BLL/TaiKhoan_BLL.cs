using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoan_BLL
    {
        TaiKhoan_DAL tkAccess = new TaiKhoan_DAL();
        public string Check_Login(TaiKhoan_DTO taikhoan)
        {
            if(taikhoan.STaiKhoan == "")
            {
                return "requeid_taikhoan";
            }
            if (taikhoan.SMatKhau == "")
            {
                return "requeid_password";
            }
            string info = tkAccess.Check_Login(taikhoan);
            return info;
        }
        public static bool DangKiTaoKhoan(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAL.ThemTaiKhoan(tk);
        }
        public static TaiKhoan_DTO TimTenUser(string ma)
        {
            return TaiKhoan_DAL.TimTenUser(ma);
        }
    }
}
