using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuDangKi_BLL
    {
        public static List<PhieuDangKi_DTO> LayPDK()
        {
            return PhiheuDangKi_DAL.LayPDK();
        }
        public static List<PhieuDangKi_DTO> TimPDKTheoNgayDen(string ngay)
        {
            return PhiheuDangKi_DAL.TimPDKTheoNgayDen(ngay);
        }
        public static bool ThemPDK(PhieuDangKiNguyenBan_DTO pdk, string maP)
        {
            return PhiheuDangKi_DAL.ThemPDK(pdk, maP);
        }
        public static List<PhieuDangKi_DTO> TimPDKTheoMa(string ma)
        {
            return PhiheuDangKi_DAL.TimPDKTheoMa(ma);
        }
    }
}
