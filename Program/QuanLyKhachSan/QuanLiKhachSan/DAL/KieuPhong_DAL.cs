using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class KieuPhong_DAL
    {
        static SqlConnection conn;
        public static List<KieuPhong_DTO> LayKP()
        {
            string sTruyVan = "select * from kieu_phong";
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KieuPhong_DTO> lstKP = new List<KieuPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KieuPhong_DTO kp = new KieuPhong_DTO();
                kp.SMaKP = dt.Rows[i]["makp"].ToString();
                kp.STenKP = dt.Rows[i]["tenkp"].ToString();
                kp.SMoTa = dt.Rows[i]["trangbi"].ToString();
                lstKP.Add(kp);
            }
            return lstKP;
        }
        public static bool ThemKieuPhong(KieuPhong_DTO kp)
        {
            string sTruyVan = string.Format(@"insert into kieu_phong values(N'{0}',N'{1}',N'{2}')",kp.SMaKP, kp.STenKP, kp.SMoTa);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
        // Lấy thông tin nhân viên có mã ma, trả về null nếu không thấy
        public static KieuPhong_DTO TimKieuPhongTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from kieu_phong where makp=N'{0}'", ma);
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            KieuPhong_DTO kp = new KieuPhong_DTO();
            kp.SMaKP = dt.Rows[0]["makp"].ToString();
            kp.STenKP = dt.Rows[0]["tenkp"].ToString();
            kp.SMoTa = dt.Rows[0]["trangbi"].ToString();

            DataProvider_DAL.DongKetNoi(conn);
            return kp;
        }
        // Xóa kiểu phòng
        public static bool XoaKP(KieuPhong_DTO kp)
        {
            string sTruyVan = string.Format(@"delete from kieu_phong where makp=N'{0}'", kp.SMaKP);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
        //Sửa kiểu phòng
        public static bool SuaKP(KieuPhong_DTO kp)
        {
            string sTruyVan = string.Format(@"update kieu_phong set tenkp=N'{0}',trangbi=N'{1}' where makp=N'{2}'", kp.STenKP, kp.SMoTa, kp.SMaKP);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
    }
}
