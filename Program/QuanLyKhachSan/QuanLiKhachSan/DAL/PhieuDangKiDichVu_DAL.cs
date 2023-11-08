using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuDangKiDichVu_DAL
    {
        static SqlConnection conn;

        public static List<PhieuDangKiDichVu_DTO> LayPDK()
        {
            string sTruyVan = "select * from dangki_dichvu";
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<PhieuDangKiDichVu_DTO> lstpdk = new List<PhieuDangKiDichVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuDangKiDichVu_DTO pdk = new PhieuDangKiDichVu_DTO();
                pdk.SMaDV = dt.Rows[i]["madv"].ToString();
                pdk.SMaPDK = dt.Rows[i]["mapdk"].ToString();
                lstpdk.Add(pdk);
            }
            return lstpdk;
        }
        public static bool ThemPDKDV(PhieuDangKiDichVu_DTO pdk, string maPDK)
        {
            string sTruyVan = string.Format(@"insert into dangki_dichvu values(N'{0}',N'{1}')", pdk.SMaDV, maPDK);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
    }
}
