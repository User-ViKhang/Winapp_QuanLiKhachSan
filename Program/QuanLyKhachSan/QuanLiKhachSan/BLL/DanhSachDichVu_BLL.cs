using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DanhSachDichVu_BLL
    {
        public static List<DanhSachDichVu_DTO> LayDV()
        {
            return DanhSachDichVu_DAL.LayDV();
        }
        public static bool ThemDV(DanhSachDichVu_DTO dv)
        {
            return DanhSachDichVu_DAL.ThemDichVu(dv);
        }
        public static DanhSachDichVu_DTO TimDVTheoMa(string ma)
        {
            return DanhSachDichVu_DAL.TimDVTheoMa(ma);
        }
        //Xóa 1 dịch vụ
        public static bool XoaDV(DanhSachDichVu_DTO dv)
        {
            return DanhSachDichVu_DAL.XoaDV(dv);
        }
        //Sửa 1 dịch vụ
        public static bool SuaDV(DanhSachDichVu_DTO dv)
        {
            return DanhSachDichVu_DAL.SuaDV(dv);
        }
        public static List<DanhSachDichVu_DTO> LayDSDV(string maPTT)
        {
            return DanhSachDichVu_DAL.LayDV_HD(maPTT);
        }
    }
}
