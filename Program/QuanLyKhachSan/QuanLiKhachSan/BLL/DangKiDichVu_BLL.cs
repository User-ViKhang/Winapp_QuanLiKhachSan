using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DangKiDichVu_BLL
    {
        public static List<DangKiDichVu_DTO> LayPDK()
        {
            return DangKiDichVu_DAL.LayPDK();
        }
        public static List<DangKiDichVu_DTO> loc(string ma)
        {
            return DangKiDichVu_DAL.Loc(ma);
        }
    }
}
