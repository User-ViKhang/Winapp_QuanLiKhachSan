using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TrangThaiPhong_BLL
    {
        public static List<TrangThaiPhong_DTO> LayPT()
        {
            return TrangThaiPhong_DAL.LayPhongTrong();
        }
        public static List<TrangThaiPhong_DTO> LayPK()
        {
            return TrangThaiPhong_DAL.LayPhongKin();
        }
        public static List<ChinhSuaThongTin_DTO> TimPhong(string maKP, string maLP)
        {
            return TrangThaiPhong_DAL.TimPhong(maKP, maLP);
        }
    }
}
