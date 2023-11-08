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
    public class TrangThaiPhong_DAL
    {
        static SqlConnection conn;
        public static List<TrangThaiPhong_DTO> LayPhongTrong()
        {
            string sTruyVan = "select * from phong where trangthai = N'Trống'";
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TrangThaiPhong_DTO> lstPT = new List<TrangThaiPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TrangThaiPhong_DTO PT = new TrangThaiPhong_DTO();
                PT.SMaP = dt.Rows[i]["maP"].ToString();
                PT.STenP = dt.Rows[i]["tenp"].ToString();
                PT.STrangThai = dt.Rows[i]["trangthai"].ToString();
                lstPT.Add(PT);
            }
            return lstPT;
        }
        public static List<TrangThaiPhong_DTO> LayPhongKin()
        {
            string sTruyVan = "select * from phong where trangthai = N'Kín'";
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TrangThaiPhong_DTO> lstPT = new List<TrangThaiPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TrangThaiPhong_DTO PT = new TrangThaiPhong_DTO();
                PT.SMaP = dt.Rows[i]["maP"].ToString();
                PT.STenP = dt.Rows[i]["tenp"].ToString();
                PT.STrangThai = dt.Rows[i]["trangthai"].ToString();
                lstPT.Add(PT);
            }
            return lstPT;
        }
        public static List<ChinhSuaThongTin_DTO> TimPhong(string maKP, string maLP)
        {
            string sTruyVan = string.Format("select p.MaP, p.TenP, p.TrangThai, lp.MaLP, lp.TenLP, kp.MaKP, kp.TenKP, g.GiaTheoGio, g.GiaTheoNgay from phong p, LOAI_PHONG lp, KIEU_PHONG kp, GIA_PHONG g where p.MaP=g.MaP and g.MaLP=lp.MaLP and g.MaKP=kp.MaKP and kp.makp='{0}' and lp.malp='{1}' and p.trangthai = N'Trống'", maKP, maLP);
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChinhSuaThongTin_DTO> lstDSP = new List<ChinhSuaThongTin_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChinhSuaThongTin_DTO allP = new ChinhSuaThongTin_DTO();
                allP.SMaP = dt.Rows[i]["maP"].ToString();
                allP.STenP = dt.Rows[i]["tenP"].ToString();
                allP.STrangThai = dt.Rows[i]["trangthai"].ToString();
                allP.SMaLP = dt.Rows[i]["malp"].ToString();
                allP.STenLP = dt.Rows[i]["tenlp"].ToString();
                allP.SMaKP = dt.Rows[i]["makp"].ToString();
                allP.STenKP = dt.Rows[i]["tenkp"].ToString();
                allP.FGiaTheoGio = int.Parse(dt.Rows[i]["giatheogio"].ToString());
                allP.FGiaTheoNgay = int.Parse(dt.Rows[i]["giatheongay"].ToString());
                lstDSP.Add(allP);
            }
            return lstDSP;
        }
    }
}
