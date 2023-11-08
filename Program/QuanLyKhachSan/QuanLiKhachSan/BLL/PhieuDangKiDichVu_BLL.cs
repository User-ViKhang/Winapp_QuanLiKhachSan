using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuDangKiDichVu_BLL
    {
        public static bool ThemPDK(PhieuDangKiDichVu_DTO pdk, string maPDK)
        {
            return PhieuDangKiDichVu_DAL.ThemPDKDV(pdk, maPDK);
        }
    }
}
