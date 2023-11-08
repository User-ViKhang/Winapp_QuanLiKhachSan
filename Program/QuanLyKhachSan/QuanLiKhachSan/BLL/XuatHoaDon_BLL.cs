using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class XuatHoaDon_BLL
    {
        public static List<XuatHoaDon_DTO> LayDS(string ma)
        {
            return XuatHoaDon_DAL.LayHD(ma);
        }

    }
}
