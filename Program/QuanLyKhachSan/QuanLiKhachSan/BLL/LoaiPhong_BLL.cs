using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiPhong_BLL
    {
        public static List<LoaiPhong_DTO> LayLP()
        {
            return LoaiPhong_DAL.LayLP();
        }
        public static bool ThemLP(LoaiPhong_DTO lp)
        {
            return LoaiPhong_DAL.ThemLP(lp);
        }
        public static LoaiPhong_DTO TimLPTheoMa(string ma)
        {
            return LoaiPhong_DAL.TimLPTheoMa(ma);
        }
        //Xóa 1 kiểu phòng
        public static bool XoaLP(LoaiPhong_DTO lp)
        {
            return LoaiPhong_DAL.XoaLP(lp);
        }
        //Sửa 1 kiểu phòng
        public static bool SuaLP(LoaiPhong_DTO lp)
        {
            return LoaiPhong_DAL.SuaLP(lp);
        }
    }
}
