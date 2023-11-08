using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHang_BLL
    {
        public static List<KhachHang_DTO> LayKH()
        {
            return KhachHang_DAL.LayKH();
        }
        public static List<KhachHang_DTO> TimKhachHangTheoTen(string ten)
        {
            return KhachHang_DAL.TimKhachHangTheoTen(ten);
        }
        //Thêm khách hàng
        public static bool ThemKhachHang(KhachHang_DTO kh)
        {
            return KhachHang_DAL.ThemKhachHang(kh);
        }
        //TÌm kiếm khách hàng theo tên
        public static KhachHang_DTO TimKhachHangTheoMa(string ma)
        {
            return KhachHang_DAL.TimKhachHangTheoMa(ma);
        }
        //Xóa khách hàng
        public static bool XoaKH(KhachHang_DTO kh)
        {
            return KhachHang_DAL.XoaKH(kh);
        }
        //Sửa khách hàng
        public static bool SuaKH(KhachHang_DTO kh)
        {
            return KhachHang_DAL.SuaKH(kh);
        }
    }
}
