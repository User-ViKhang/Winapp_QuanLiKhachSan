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
    public class HoaDon_DAL
    {
        static SqlConnection conn;
        public static List<HoaDon_DTO> LayHD()
        {
            string sTruyVan = @"select ptt.maptt, ptt.manv, pdk.makh, ptt.songay, ptt.gio, ptt.ngaythanhtoan, ptt.vat, ptt.tongtien, ptt.tienphaitra from PHIEU_THANHTOAN ptt, PHIEU_DANGKI pdk where ptt.MaPDK = pdk.MaPDK";
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lstHD = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.SMaPTT = dt.Rows[i]["MaPTT"].ToString();
                hd.SMaNV = dt.Rows[i]["MaNV"].ToString();
                hd.SMaKH = dt.Rows[i]["MaKH"].ToString();
                hd.SThanhToan = DateTime.Parse(dt.Rows[i]["ngaythanhtoan"].ToString());
                hd.ISoNgay = int.Parse(dt.Rows[i]["songay"].ToString());
                hd.ISoGio = int.Parse(dt.Rows[i]["gio"].ToString());
                hd.FThue = float.Parse(dt.Rows[i]["vat"].ToString());
                hd.FTongTien = float.Parse(dt.Rows[i]["tongtien"].ToString());
                hd.FPhaiTra = float.Parse(dt.Rows[i]["tienphaitra"].ToString());

                lstHD.Add(hd);
            }
            return lstHD;
        }
        public static List<HoaDon_DTO> TimHDTheoNgayDen(string ngay)
        {
            string sTruyVan = string.Format(@"select ptt.maptt, ptt.manv, pdk.makh, ptt.songay, ptt.gio, ptt.ngaythanhtoan, ptt.vat, ptt.tongtien, ptt.tienphaitra from PHIEU_THANHTOAN ptt, PHIEU_DANGKI pdk where ptt.MaPDK = pdk.MaPDK and ngaythanhtoan {0}", ngay);
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lstHD = new List<DTO.HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.SMaPTT = dt.Rows[i]["MaPTT"].ToString();
                hd.SMaNV = dt.Rows[i]["MaNV"].ToString();
                hd.SMaKH = dt.Rows[i]["MaKH"].ToString();
                hd.SThanhToan = DateTime.Parse(dt.Rows[i]["ngaythanhtoan"].ToString());
                hd.ISoNgay = int.Parse(dt.Rows[i]["songay"].ToString());
                hd.ISoGio = int.Parse(dt.Rows[i]["gio"].ToString());
                hd.FThue = float.Parse(dt.Rows[i]["vat"].ToString());
                hd.FTongTien = float.Parse(dt.Rows[i]["tongtien"].ToString());
                hd.FPhaiTra = float.Parse(dt.Rows[i]["tienphaitra"].ToString());

                lstHD.Add(hd);
            }
            DataProvider_DAL.DongKetNoi(conn);
            return lstHD;
        }
    }
}
