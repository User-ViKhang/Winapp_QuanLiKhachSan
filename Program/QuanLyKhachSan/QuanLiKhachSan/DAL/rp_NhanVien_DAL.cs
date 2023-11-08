using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class rp_NhanVien_DAL
    {
        static SqlConnection conn;
        public static DataTable getNhanVien()
        {
            string sTruyVan = "select * from nhanvien";
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            return dt;
        }
    }
}
