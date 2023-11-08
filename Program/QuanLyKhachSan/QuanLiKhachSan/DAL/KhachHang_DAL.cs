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
    public class KhachHang_DAL
    {
        static SqlConnection conn;
        public static List<KhachHang_DTO> LayKH()
        {
            string sTruyVan = "select * from khachhang";
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> lstKH = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.SMaKH = dt.Rows[i]["makh"].ToString();
                kh.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                kh.STenKH = dt.Rows[i]["TenKH"].ToString();
                kh.ICMND = int.Parse(dt.Rows[i]["CMND"].ToString());
                kh.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                kh.SQuocTich = dt.Rows[i]["QuocTich"].ToString();
                kh.ISDT = int.Parse(dt.Rows[i]["SDT"].ToString());
                kh.SEmail = dt.Rows[i]["Email"].ToString();
                kh.DNamSinh = DateTime.Parse(dt.Rows[i]["NamSinh"].ToString());
                lstKH.Add(kh);
            }
            return lstKH;
        }
        public static List<KhachHang_DTO> TimKhachHangTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from khachhang where tenkh like N'%{0}%'", ten);
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> lstKhachHang = new List<DTO.KhachHang_DTO>();
            for(int i=0; i<dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.SMaKH = dt.Rows[i]["makh"].ToString();
                kh.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                kh.STenKH = dt.Rows[i]["TenKH"].ToString();
                kh.ICMND = int.Parse(dt.Rows[i]["CMND"].ToString());
                kh.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                kh.SQuocTich = dt.Rows[i]["QuocTich"].ToString();
                kh.ISDT = int.Parse(dt.Rows[i]["SDT"].ToString());
                kh.SEmail = dt.Rows[i]["Email"].ToString();
                kh.DNamSinh = DateTime.Parse(dt.Rows[i]["NamSinh"].ToString());
                lstKhachHang.Add(kh);
            }
            DataProvider_DAL.DongKetNoi(conn);
            return lstKhachHang;
        }
        public static bool ThemKhachHang(KhachHang_DTO kh)
        {
            string sTruyVan = string.Format(@"insert into khachhang values(N'{0}',N'{1}',N'{2}',N'{3}','{4}',N'{5}',N'{6}',N'{7}',N'{8}')", kh.SMaKH, kh.SGioiTinh, kh.STenKH, kh.ICMND,kh.SDiaChi,kh.SQuocTich,kh.ISDT,kh.SEmail,kh.DNamSinh);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
        public static KhachHang_DTO TimKhachHangTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from khachhang where makh=N'{0}'",ma);
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.SMaKH = dt.Rows[0]["makh"].ToString();
            kh.SGioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            kh.STenKH = dt.Rows[0]["TenKH"].ToString();
            kh.ICMND = int.Parse(dt.Rows[0]["CMND"].ToString());
            kh.SDiaChi = dt.Rows[0]["DiaChi"].ToString();
            kh.SQuocTich = dt.Rows[0]["QuocTich"].ToString();
            kh.ISDT = int.Parse(dt.Rows[0]["SDT"].ToString());
            kh.SEmail = dt.Rows[0]["Email"].ToString();
            kh.DNamSinh = DateTime.Parse(dt.Rows[0]["NamSinh"].ToString());
            DataProvider_DAL.DongKetNoi(conn);
            return kh;
        }
        // Xóa khách hàng
        public static bool XoaKH(KhachHang_DTO kh)
        {
            string sTruyVan = string.Format(@"delete from khachhang where makh=N'{0}'", kh.SMaKH);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
        //Sửa kiểu phòng
        public static bool SuaKH(KhachHang_DTO kh)
        {
            string sTruyVan = string.Format(@"update khachhang set gioitinh=N'{0}',tenkh=N'{1}',cmnd=N'{2}',diachi=N'{3}',quoctich=N'{4}',sdt=N'{5}',email=N'{6}',namsinh=N'{7}' where makh=N'{8}'", kh.SGioiTinh, kh.STenKH, kh.ICMND, kh.SDiaChi, kh.SQuocTich, kh.ISDT, kh.SEmail, kh.DNamSinh, kh.SMaKH);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
    }
}
