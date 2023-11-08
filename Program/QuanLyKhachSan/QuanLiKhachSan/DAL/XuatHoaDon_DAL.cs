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
    public class XuatHoaDon_DAL
    {
        //--
        public string strMaHD;
        public void XuatHoaDon(string strMaHD)
        {
            this.strMaHD = strMaHD;
        }
        //--

        static SqlConnection conn;
        public static List<XuatHoaDon_DTO> LayHD(string ma)
        {
            string sTruyVan = string.Format(@"select ptt.MaPTT, ptt.SoNgay, ptt.Gio, ptt.NgayThanhToan, ptt.TongTien, ptt.VAT, ptt.TienPhaiTra, nv.TenNV, nv.MaNV, pdk.SoPhong, kh.MaKH, kh.TenKH, dkp.MaP, p.TenP, gp.GiaTheoGio, gp.GiaTheoNgay, lp.TenLP, kp.TenKP, pdk.tratruoc from PHIEU_THANHTOAN ptt, NHANVIEN nv, PHIEU_DANGKI pdk, KHACHHANG kh, DANGKI_PHONG dkp, PHONG p, GIA_PHONG gp, LOAI_PHONG lp, KIEU_PHONG kp where ptt.MaNV = nv.MaNV and ptt.MaPDK = pdk.MaPDK and pdk.MaKH = kh.MaKH and pdk.MaPDK = dkp.MaPDK and dkp.MaP = p.MaP and p.MaP = gp.MaP and gp.MaLP = lp.MaLP and gp.MaKP=kp.makp and ptt.maptt='{0}'", ma);
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<XuatHoaDon_DTO> lstHD = new List<XuatHoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                XuatHoaDon_DTO hd = new XuatHoaDon_DTO();
                hd.SMaHD = dt.Rows[i]["MaPTT"].ToString();
                hd.ISoNgay = int.Parse(dt.Rows[i]["SoNgay"].ToString());
                hd.ISoGio = int.Parse(dt.Rows[i]["Gio"].ToString());
                hd.DNgayThanhToan = DateTime.Parse(dt.Rows[i]["NgayThanhToan"].ToString());
                hd.FTongTien = float.Parse(dt.Rows[i]["TongTien"].ToString());
                hd.FVAT = float.Parse(dt.Rows[i]["VAT"].ToString());
                hd.FTienPhaiTra = float.Parse(dt.Rows[i]["TienPhaiTra"].ToString());
                hd.STenNV = dt.Rows[i]["TenNV"].ToString();
                hd.SMaNV = dt.Rows[i]["MaNV"].ToString();
                hd.SSoP = dt.Rows[i]["SoPhong"].ToString();
                hd.SMaKH = dt.Rows[i]["MaKH"].ToString();
                hd.STenKH = dt.Rows[i]["TenKH"].ToString();
                hd.SMaP = dt.Rows[i]["MaP"].ToString();
                hd.STenP = dt.Rows[i]["TenP"].ToString();
                hd.FGiaTheoGio = float.Parse(dt.Rows[i]["GiaTheoGio"].ToString());
                hd.FGiaTheoNgay = float.Parse(dt.Rows[i]["GiaTheoNgay"].ToString());
                hd.STenLP = dt.Rows[i]["TenLP"].ToString();
                hd.STenNV = dt.Rows[i]["tennv"].ToString();
                hd.FTraTruoc = float.Parse(dt.Rows[i]["tratruoc"].ToString());
                hd.STenKP = dt.Rows[i]["tenkp"].ToString();

                lstHD.Add(hd);
            }
            return lstHD;
        }

    }
}
