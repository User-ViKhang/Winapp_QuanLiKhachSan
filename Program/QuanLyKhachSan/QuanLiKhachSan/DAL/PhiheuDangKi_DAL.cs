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
    public class PhiheuDangKi_DAL
    {
        static SqlConnection conn;
        public static List<PhieuDangKi_DTO> LayPDK()
        {
            string sTruyVan = "select pdk.*, nv.TenNV, kh.TenKH from PHIEU_DANGKI pdk, NHANVIEN nv, KHACHHANG kh where pdk.MaKH = kh.MaKH and pdk.MaNV = nv.MaNV";
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<PhieuDangKi_DTO> lstPDK = new List<PhieuDangKi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuDangKi_DTO pdk = new PhieuDangKi_DTO();
                pdk.SMaPhieu = dt.Rows[i]["MaPDK"].ToString();
                pdk.DNgayDen = DateTime.Parse(dt.Rows[i]["NgayDen"].ToString());
                pdk.DNgayDi = DateTime.Parse(dt.Rows[i]["NgayDi"].ToString());
                pdk.ISoPhong = dt.Rows[i]["SoPhong"].ToString();
                pdk.FTraTruoc = float.Parse(dt.Rows[i]["TraTruoc"].ToString());
                pdk.SMaKhach = dt.Rows[i]["MaKH"].ToString();
                pdk.SMaNhanVien = dt.Rows[i]["MaNV"].ToString();
                pdk.ISoGio = int.Parse(dt.Rows[i]["SoGio"].ToString());
                pdk.STenNhanVien = dt.Rows[i]["TenNV"].ToString();
                pdk.STenKhachHang = dt.Rows[i]["TenKH"].ToString();
                lstPDK.Add(pdk);
            }
            return lstPDK;
        }
        public static List<PhieuDangKi_DTO> TimPDKTheoNgayDen(string ngay)
        {
            string sTruyVan = string.Format(@"select pdk.*, nv.TenNV, kh.TenKH from PHIEU_DANGKI pdk, NHANVIEN nv, KHACHHANG kh where pdk.MaKH = kh.MaKH and pdk.MaNV = nv.MaNV and NgayDen {0}", ngay);
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<PhieuDangKi_DTO> lstPDK = new List<DTO.PhieuDangKi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuDangKi_DTO pdk = new PhieuDangKi_DTO();
                pdk.SMaPhieu = dt.Rows[i]["MaPDK"].ToString();
                pdk.DNgayDen = DateTime.Parse(dt.Rows[i]["NgayDen"].ToString());
                pdk.DNgayDi = DateTime.Parse(dt.Rows[i]["NgayDi"].ToString());
                pdk.ISoPhong = dt.Rows[i]["SoPhong"].ToString();
                pdk.FTraTruoc = float.Parse(dt.Rows[i]["TraTruoc"].ToString());
                pdk.SMaKhach = dt.Rows[i]["MaKH"].ToString();
                pdk.SMaNhanVien = dt.Rows[i]["MaNV"].ToString();
                pdk.ISoGio = int.Parse(dt.Rows[i]["SoGio"].ToString());
                pdk.STenNhanVien = dt.Rows[i]["TenNV"].ToString();
                pdk.STenKhachHang = dt.Rows[i]["TenKH"].ToString();
                lstPDK.Add(pdk);
            }
            DataProvider_DAL.DongKetNoi(conn);
            return lstPDK;
        }
        //Thêm phiếu đăng kí
        public static bool ThemPDK(PhieuDangKiNguyenBan_DTO pdk, string maP)
        {
            string sTruyVan = string.Format(@"insert into phieu_dangki values(N'{0}',N'{1}',N'{2}',N'{3}',{4},N'{5}',N'{6}',{7}); insert into dangki_phong values(N'{8}',N'{9}'); update phong set trangthai=N'Kín' where map = N'{10}'", pdk.SMaPhieu, pdk.DNgayDen, pdk.DNgayDi, pdk.ISoPhong, pdk.FTraTruoc, pdk.SMaKhach, pdk.SMaNhanVien, pdk.ISoGio, maP, pdk.SMaPhieu, maP);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
        //Tìm mã phiếu đăng kí
        public static List<PhieuDangKi_DTO> TimPDKTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select pdk.*, nv.TenNV, kh.TenKH from PHIEU_DANGKI pdk, NHANVIEN nv, KHACHHANG kh where pdk.MaKH = kh.MaKH and pdk.MaNV = nv.MaNV and mapdk=N'{0}'", ma);
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<PhieuDangKi_DTO> lstPDK = new List<DTO.PhieuDangKi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuDangKi_DTO pdk = new PhieuDangKi_DTO();
                pdk.SMaPhieu = dt.Rows[i]["MaPDK"].ToString();
                pdk.DNgayDen = DateTime.Parse(dt.Rows[i]["NgayDen"].ToString());
                pdk.DNgayDi = DateTime.Parse(dt.Rows[i]["NgayDi"].ToString());
                pdk.ISoPhong = dt.Rows[i]["SoPhong"].ToString();
                pdk.FTraTruoc = float.Parse(dt.Rows[i]["TraTruoc"].ToString());
                pdk.SMaKhach = dt.Rows[i]["MaKH"].ToString();
                pdk.SMaNhanVien = dt.Rows[i]["MaNV"].ToString();
                pdk.ISoGio = int.Parse(dt.Rows[i]["SoGio"].ToString());
                pdk.STenNhanVien = dt.Rows[i]["TenNV"].ToString();
                pdk.STenKhachHang = dt.Rows[i]["TenKH"].ToString();
                lstPDK.Add(pdk);
            }
            DataProvider_DAL.DongKetNoi(conn);
            return lstPDK;
        }
    }
}
