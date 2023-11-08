using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChinhSuaThongTin_BLL
    {
        public static List<ChinhSuaThongTin_DTO> LayDS()
        {
            return ChinhSuaThongTin_DAL.LayTatCaCacPhong();
        }
        public static List<ChinhSuaThongTin_DTO> LayDSGP(string soPhong)
        {
            return ChinhSuaThongTin_DAL.LayGiaPThanhToan(soPhong);
        }
        public static bool ThemP(ChinhSuaThongTin_DTO p)
        {
            return ChinhSuaThongTin_DAL.ThemPhong(p);
        }
        public static bool ThemGP(ChinhSuaThongTin_DTO p)
        {
            return ChinhSuaThongTin_DAL.ThemGiaPhong(p);
        }
        public static ChinhSuaThongTin_DTO TimPhongTheoMa(string ma)
        {
            return ChinhSuaThongTin_DAL.TimPhongTheoMa(ma);
        }
        public static ChinhSuaThongTin_DTO TimPhongTheoTen(string ten)
        {
            return ChinhSuaThongTin_DAL.TimPhongTheoTen(ten);
        }
        //Xóa 1 phòng
        public static bool XoaP(ChinhSuaThongTin_DTO p)
        {
            return ChinhSuaThongTin_DAL.XoaP(p);
        }
        //Sửa 1 phòng
        public static bool SuaP(ChinhSuaThongTin_DTO p)
        {
            return ChinhSuaThongTin_DAL.SuaP(p);
        }

    }
}
