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
    public class LoaiPhong_DAL
    {
        static SqlConnection conn;
        public static List<LoaiPhong_DTO> LayLP()
        {
            string sTruyVan = "select * from loai_phong";
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LoaiPhong_DTO> lstLP = new List<LoaiPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiPhong_DTO lp = new LoaiPhong_DTO();
                lp.SMaLP = dt.Rows[i]["malp"].ToString();
                lp.STenLP = dt.Rows[i]["tenlp"].ToString();
                lp.SMoTa = dt.Rows[i]["mota"].ToString();
                lstLP.Add(lp);
            }
            return lstLP;
        }
        public static bool ThemLP(LoaiPhong_DTO lp)
        {
            string sTruyVan = string.Format(@"insert into loai_phong values(N'{0}',N'{1}',N'{2}')", lp.SMaLP, lp.STenLP, lp.SMoTa);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
        // Lấy thông tin nhân viên có mã ma, trả về null nếu không thấy
        public static LoaiPhong_DTO TimLPTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from loai_phong where malp=N'{0}'", ma);
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            LoaiPhong_DTO lp = new LoaiPhong_DTO();
            lp.SMaLP = dt.Rows[0]["malp"].ToString();
            lp.STenLP = dt.Rows[0]["tenlp"].ToString();
            lp.SMoTa = dt.Rows[0]["mota"].ToString();

            DataProvider_DAL.DongKetNoi(conn);
            return lp;
        }
        // Xóa loại phòng
        public static bool XoaLP(LoaiPhong_DTO lp)
        {
            string sTruyVan = string.Format(@"delete from loai_phong where malp=N'{0}'", lp.SMaLP);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
        //Sửa kiểu phòng
        public static bool SuaLP(LoaiPhong_DTO lp)
        {
            string sTruyVan = string.Format(@"update loai_phong set tenlp=N'{0}',mota=N'{1}' where malp=N'{2}'",lp.STenLP, lp.SMoTa, lp.SMaLP);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
    }
}
