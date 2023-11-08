using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class rp_NhanVien_BLL
    {
        public static DataTable getNhanVien()
        {
            return rp_NhanVien_DAL.getNhanVien();
        }
    }
}
