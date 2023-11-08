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
    public class ChinhSuaThongTin_DAL
    {
        static SqlConnection conn;
        public static List<ChinhSuaThongTin_DTO> LayTatCaCacPhong()
        {
            string sTruyVan = "select p.MaP, p.TenP, p.TrangThai, lp.MaLP, lp.TenLP, kp.MaKP, kp.TenKP, g.GiaTheoGio, g.GiaTheoNgay from phong p, LOAI_PHONG lp, KIEU_PHONG kp, GIA_PHONG g where p.MaP=g.MaP and g.MaLP=lp.MaLP and g.MaKP=kp.MaKP\r\n";
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
        public static bool ThemPhong(ChinhSuaThongTin_DTO p)
        {
            string sTruyVan = string.Format(@"insert into phong values(N'{0}',N'{1}',N'{2}')", p.SMaP, p.STenP, p.STrangThai);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }

        public static bool ThemGiaPhong(ChinhSuaThongTin_DTO p)
        {
            string sTruyVan = string.Format(@"insert into GIA_PHONG values(N'{0}',N'{1}',N'{2}',{3},{4})", p.SMaP, p.SMaKP, p.SMaLP, p.FGiaTheoGio, p.FGiaTheoNgay);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
        public static ChinhSuaThongTin_DTO TimPhongTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select p.MaP, p.TenP, p.TrangThai, lp.MaLP, lp.TenLP, kp.MaKP, kp.TenKP, g.GiaTheoGio, g.GiaTheoNgay from phong p, LOAI_PHONG lp, KIEU_PHONG kp, GIA_PHONG g where p.MaP=g.MaP and g.MaLP=lp.MaLP and g.MaKP=kp.MaKP and p.map=N'{0}'", ma);
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            ChinhSuaThongTin_DTO allP = new ChinhSuaThongTin_DTO();
            allP.SMaP = dt.Rows[0]["maP"].ToString();
            allP.STenP = dt.Rows[0]["tenP"].ToString();
            allP.STrangThai = dt.Rows[0]["trangthai"].ToString();
            allP.SMaLP = dt.Rows[0]["malp"].ToString();
            allP.STenLP = dt.Rows[0]["tenlp"].ToString();
            allP.SMaKP = dt.Rows[0]["makp"].ToString();
            allP.STenKP = dt.Rows[0]["tenkp"].ToString();
            allP.FGiaTheoGio = int.Parse(dt.Rows[0]["giatheogio"].ToString());
            allP.FGiaTheoNgay = int.Parse(dt.Rows[0]["giatheongay"].ToString());

            DataProvider_DAL.DongKetNoi(conn);
            return allP;
        }
        public static ChinhSuaThongTin_DTO TimPhongTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select p.MaP, p.TenP, p.TrangThai, lp.MaLP, lp.TenLP, kp.MaKP, kp.TenKP, g.GiaTheoGio, g.GiaTheoNgay from phong p, LOAI_PHONG lp, KIEU_PHONG kp, GIA_PHONG g where p.MaP=g.MaP and g.MaLP=lp.MaLP and g.MaKP=kp.MaKP and p.tenp=N'{0}'", ten);
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            ChinhSuaThongTin_DTO allP = new ChinhSuaThongTin_DTO();
            allP.SMaP = dt.Rows[0]["maP"].ToString();
            allP.STenP = dt.Rows[0]["tenP"].ToString();
            allP.STrangThai = dt.Rows[0]["trangthai"].ToString();
            allP.SMaLP = dt.Rows[0]["malp"].ToString();
            allP.STenLP = dt.Rows[0]["tenlp"].ToString();
            allP.SMaKP = dt.Rows[0]["makp"].ToString();
            allP.STenKP = dt.Rows[0]["tenkp"].ToString();
            allP.FGiaTheoGio = int.Parse(dt.Rows[0]["giatheogio"].ToString());
            allP.FGiaTheoNgay = int.Parse(dt.Rows[0]["giatheongay"].ToString());

            DataProvider_DAL.DongKetNoi(conn);
            return allP;
        }
        // Xóa phòng
        public static bool XoaP(ChinhSuaThongTin_DTO p)
        {
            string sTruyVan = string.Format(@"delete from gia_phong where map='{0}'; delete from phong where map='{1}'", p.SMaP, p.SMaP);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
        //Sửa phòng
        public static bool SuaP(ChinhSuaThongTin_DTO p)
        {
            string sTruyVan = string.Format(@"ALTER TABLE GIA_PHONG DROP CONSTRAINT FK_GIAPHONG_PHONG; update phong set tenp=N'{0}',trangthai=N'{1}' where map=N'{2}'; update gia_phong set makp=N'{3}',malp=N'{4}',giatheogio={5},giatheongay={6} where map=N'{7}'; ALTER TABLE GIA_PHONG ADD CONSTRAINT FK_GIAPHONG_PHONG FOREIGN KEY(MaP) REFERENCES PHONG(MaP)", p.STenP, p.STrangThai, p.SMaP, p.SMaKP,p.SMaLP, p.FGiaTheoGio, p.FGiaTheoNgay, p.SMaP);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
        public static List<ChinhSuaThongTin_DTO> LayGiaPThanhToan(string soPhong)
        {
            string sTruyVan = string.Format("select p.MaP, p.TenP, p.TrangThai, lp.MaLP, lp.TenLP, kp.MaKP, kp.TenKP, g.GiaTheoGio, g.GiaTheoNgay from phong p, LOAI_PHONG lp, KIEU_PHONG kp, GIA_PHONG g where p.MaP=g.MaP and g.MaLP=lp.MaLP and g.MaKP=kp.MaKP and p.tenp = '{0}'", soPhong);
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
