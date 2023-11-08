using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVien_BLL
    {
        public static List<NhanVien_DTO> LayDS()
        {
            return NhanVien_DAL.LayNhanVien();
        }
        public static List<NhanVien_DTO> TimNhanVienTheoTen(string ten)
        {
            return NhanVien_DAL.TimNhanVienTheoTen(ten);
        }
        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAL.ThemNhanVien(nv);
        }
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            return NhanVien_DAL.TimNhanVienTheoMa(ma);
        }
        //Xóa 1 nhân viên
        public static bool XoaNV(NhanVien_DTO nv)
        {
            return NhanVien_DAL.XoaNV(nv);
        }
        //Sửa 1 nhân viên
        public static bool SuaNV(NhanVien_DTO nv)
        {
            return NhanVien_DAL.SuaNV(nv);
        }
    }
}
