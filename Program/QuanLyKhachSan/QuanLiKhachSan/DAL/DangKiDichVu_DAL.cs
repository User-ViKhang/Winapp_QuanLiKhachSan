using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DangKiDichVu_DAL
    {
        static SqlConnection conn;
        public static List<DangKiDichVu_DTO> LayPDK()
        {
            string sTruyVan = "select dkdv.*, dv.TenDV, dv.GiaDV from DANGKI_DICHVU dkdv, DICHVU dv where dkdv.MaDV = dv.MaDV";
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DangKiDichVu_DTO> lstPDK = new List<DangKiDichVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DangKiDichVu_DTO pdk = new DangKiDichVu_DTO();
                pdk.SMaDV = dt.Rows[i]["MaDV"].ToString();
                pdk.SMaPDK = dt.Rows[i]["MaPDK"].ToString();
                pdk.STenDV = dt.Rows[i]["TenDV"].ToString();
                pdk.FGiaDV = float.Parse(dt.Rows[i]["GiaDV"].ToString());
                lstPDK.Add(pdk);
            }
            return lstPDK;
        }
        public static List<DangKiDichVu_DTO> Loc(string ma)
        {
            string sTruyVan = string.Format(@"select dkdv.*, dv.TenDV, dv.GiaDV from DANGKI_DICHVU dkdv, DICHVU dv where dkdv.MaDV = dv.MaDV and maPDK like N'%{0}%'", ma);
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DangKiDichVu_DTO> lstPDK = new List<DTO.DangKiDichVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DangKiDichVu_DTO pdk = new DangKiDichVu_DTO();
                pdk.SMaDV = dt.Rows[i]["MaDV"].ToString();
                pdk.SMaPDK = dt.Rows[i]["MaPDK"].ToString();
                pdk.STenDV = dt.Rows[i]["TenDV"].ToString();
                pdk.FGiaDV = float.Parse(dt.Rows[i]["GiaDV"].ToString());
                lstPDK.Add(pdk);
            }
            DataProvider_DAL.DongKetNoi(conn);
            return lstPDK;
        }
    }
}
