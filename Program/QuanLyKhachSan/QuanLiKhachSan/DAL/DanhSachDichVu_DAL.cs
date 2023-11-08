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
    public class DanhSachDichVu_DAL
    {
        static SqlConnection conn;
        public static List<DanhSachDichVu_DTO> LayDV()
        {
            string sTruyVan = "select * from dichvu";
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DanhSachDichVu_DTO> lstDV = new List<DanhSachDichVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DanhSachDichVu_DTO dv = new DanhSachDichVu_DTO();
                dv.SMaDV = dt.Rows[i]["madv"].ToString();
                dv.STenDV = dt.Rows[i]["tendv"].ToString();
                dv.FGiaDV = float.Parse(dt.Rows[i]["giadv"].ToString());
                lstDV.Add(dv);
            }
            return lstDV;
        }
        // Load dịch vụ form Xuất hóa đơn
        public static List<DanhSachDichVu_DTO> LayDV_HD(string maPTT)
        {
            string sTruyVan = string.Format("select dv.* from phieu_thanhtoan ptt, dichvu dv, dangki_dichvu dkdv, phieu_dangki pdk where ptt.mapdk = pdk.mapdk and pdk.MaPDK = dkdv.MaPDK and dkdv.MaDV = dv.MaDV and ptt.maptt = '{0}'", maPTT);
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DanhSachDichVu_DTO> lstDV = new List<DanhSachDichVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DanhSachDichVu_DTO dv = new DanhSachDichVu_DTO();
                dv.SMaDV = dt.Rows[i]["madv"].ToString();
                dv.STenDV = dt.Rows[i]["tendv"].ToString();
                dv.FGiaDV = float.Parse(dt.Rows[i]["giadv"].ToString());
                lstDV.Add(dv);
            }
            return lstDV;
        }
        public static List<DanhSachDichVu_DTO> LayDV_PDK(string maPDK)
        {
            string sTruyVan = string.Format("select dv.* from dangki_dichvu dkdv, dichvu dv where dkdv.madv = dv.madv and dkdv.mapdk = N'{0}'", maPDK);
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DanhSachDichVu_DTO> lstDV = new List<DanhSachDichVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DanhSachDichVu_DTO dv = new DanhSachDichVu_DTO();
                dv.SMaDV = dt.Rows[i]["madv"].ToString();
                dv.STenDV = dt.Rows[i]["tendv"].ToString();
                dv.FGiaDV = float.Parse(dt.Rows[i]["giadv"].ToString());
                lstDV.Add(dv);
            }
            return lstDV;
        }
        public static bool ThemDichVu(DanhSachDichVu_DTO dv)
        {
            string sTruyVan = string.Format(@"insert into dichvu values(N'{0}',N'{1}',{2})",dv.SMaDV, dv.STenDV, dv.FGiaDV);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
        // Lấy thông tin nhân viên có mã ma, trả về null nếu không thấy
        public static DanhSachDichVu_DTO TimDVTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from dichvu where madv=N'{0}'", ma);
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DanhSachDichVu_DTO dv = new DanhSachDichVu_DTO();
            dv.SMaDV = dt.Rows[0]["madv"].ToString();
            dv.STenDV = dt.Rows[0]["tendv"].ToString();
            dv.FGiaDV = float.Parse(dt.Rows[0]["giadv"].ToString());
            DataProvider_DAL.DongKetNoi(conn);
            return dv;
        }
        // Xóa dịch vụ
        public static bool XoaDV(DanhSachDichVu_DTO dv)
        {
            string sTruyVan = string.Format(@"delete from dichvu where madv=N'{0}'", dv.SMaDV);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
        //Sửa kiểu phòng
        public static bool SuaDV(DanhSachDichVu_DTO dv)
        {
            string sTruyVan = string.Format(@"update dichvu set tendv=N'{0}',giadv={1} where madv=N'{2}'", dv.STenDV, dv.FGiaDV, dv.SMaDV);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
    }
}
