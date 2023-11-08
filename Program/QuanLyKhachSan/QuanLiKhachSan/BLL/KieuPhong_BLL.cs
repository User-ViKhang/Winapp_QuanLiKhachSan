using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KieuPhong_BLL
    {
        //Lấy kiêu phòng
        public static List<KieuPhong_DTO> LayKP()
        {
            return KieuPhong_DAL.LayKP();
        }
        //Thêm kiểu phòng
        public static bool ThemKieuPhong(KieuPhong_DTO kp)
        {
            return KieuPhong_DAL.ThemKieuPhong(kp);
        }
        //Tìm kiểu phòng theo MAPHONG
        public static KieuPhong_DTO TimKPTheoMa(string ma)
        {
            return KieuPhong_DAL.TimKieuPhongTheoMa(ma);
        }
        //Xóa 1 kiểu phòng
        public static bool XoaKP(KieuPhong_DTO kp)
        {
            return KieuPhong_DAL.XoaKP(kp);
        }
        //Sửa 1 kiểu phòng
        public static bool SuaKP(KieuPhong_DTO kp)
        {
            return KieuPhong_DAL.SuaKP(kp);
        }
    }
}
