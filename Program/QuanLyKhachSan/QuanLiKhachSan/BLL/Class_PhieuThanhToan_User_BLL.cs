using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Class_PhieuThanhToan_User_BLL
    {
        public static bool ThemHD(Class_PhieuThanhToan_User_DTO ptt)
        {
            return Class_TraPhong_User_DAL.ThemHoaDon(ptt);
        }
    }
}
