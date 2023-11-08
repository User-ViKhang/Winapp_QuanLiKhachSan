using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Class_TraPhong_PhieuDangKi_User_BLL
    {
        public static List<Class_TraPhong_PhieuDangKi_User_DTO> LayPDK()
        {
            return Class_TraPhong_PhieuDangKi_User_DAL.LayPDK();
        }
        public static List<DanhSachDichVu_DTO> layDV_PDK(string maPDK)
        {
            return DanhSachDichVu_DAL.LayDV_PDK(maPDK);
        }

    }
}
