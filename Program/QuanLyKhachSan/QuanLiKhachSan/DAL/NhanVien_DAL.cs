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
    public class NhanVien_DAL
    {
        static SqlConnection conn;
        public static List<NhanVien_DTO> LayNhanVien()
        {
            string sTruyVan = "select * from nhanvien";
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstDSNV = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV = dt.Rows[i]["MaNV"].ToString();
                nv.STenNV = dt.Rows[i]["TenNV"].ToString();
                nv.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                nv.DNgaySinh = dt.Rows[i]["NamSinh"].ToString();
                nv.ICMND = int.Parse(dt.Rows[i]["CMND"].ToString());
                nv.ISDT = int.Parse(dt.Rows[i]["SDT"].ToString());
                nv.SEmail = dt.Rows[i]["email"].ToString();
                lstDSNV.Add(nv);
            }
            return lstDSNV;
        }

        public static List<NhanVien_DTO> TimNhanVienTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where tennv like N'%{0}%'", ten);
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<DTO.NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV = dt.Rows[i]["MaNV"].ToString();
                nv.STenNV = dt.Rows[i]["TenNV"].ToString();
                nv.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                nv.DNgaySinh = dt.Rows[i]["NamSinh"].ToString();
                nv.ICMND = int.Parse(dt.Rows[i]["CMND"].ToString());
                nv.ISDT = int.Parse(dt.Rows[i]["SDT"].ToString());
                nv.SEmail = dt.Rows[i]["email"].ToString();
                lstNhanVien.Add(nv);
            }
            DataProvider_DAL.DongKetNoi(conn);
            return lstNhanVien;
        }
        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"insert into nhanvien values(N'{0}',N'{1}',N'{2}',N'{3}','{4}',N'{5}',N'{6}')", nv.SMaNV, nv.STenNV, nv.SGioiTinh, nv.DNgaySinh, nv.ICMND, nv.ISDT, nv.SEmail);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
        // Lấy thông tin nhân viên có mã ma, trả về null nếu không thấy
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where manv=N'{0}'", ma);
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = dt.Rows[0]["MaNV"].ToString();
            nv.STenNV = dt.Rows[0]["TenNV"].ToString();
            nv.SGioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            nv.DNgaySinh = dt.Rows[0]["NamSinh"].ToString();
            nv.ICMND = int.Parse(dt.Rows[0]["CMND"].ToString());
            nv.ISDT = int.Parse(dt.Rows[0]["SDT"].ToString());
            nv.SEmail = dt.Rows[0]["email"].ToString();

            DataProvider_DAL.DongKetNoi(conn);
            return nv;
        }
        // Xóa nhân viên
        public static bool XoaNV(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"delete from nhanvien where manv=N'{0}'", nv.SMaNV);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
        //Sửa nhân viên
        public static bool SuaNV(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"update nhanvien set tennv=N'{0}',gioitinh=N'{1}',namsinh=N'{2}',cmnd={3},sdt={4},email=N'{5}' where manv=N'{6}'", nv.STenNV, nv.SGioiTinh, nv.DNgaySinh, nv.ICMND, nv.ISDT, nv.SEmail, nv.SMaNV);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }

    }
}
