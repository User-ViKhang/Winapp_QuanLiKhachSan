using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.ComponentModel;

namespace DAL
{
    public class TaiKhoan_DAL:DataProvider_DAL
    {
        static SqlConnection conn;
        public string Check_Login(TaiKhoan_DTO taikhoan)
        {
            string info = Check_Login_DTO(taikhoan);
            return info;
        }
        public static bool ThemTaiKhoan(TaiKhoan_DTO tk)
        {
            string sTruyVan = string.Format(@"insert into tbl_taikhoan values('2', N'{0}', N'{1}', '2')", tk.STaiKhoan, tk.SMatKhau);
            conn = DataProvider_DAL.Connect_Login();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.Disconnect_Login(conn);
            return kq;
        }
        public static TaiKhoan_DTO TimTenUser(string ma)
        {
            string sTruyVan = string.Format(@"select * from tbl_taikhoan where staikhoan = N'{0}'", ma);
            conn = DataProvider_DAL.Connect_Login();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.SMaTK = dt.Rows[0]["sMatk"].ToString();
            tk.STaiKhoan = dt.Rows[0]["staikhoan"].ToString();
            tk.SMatKhau = dt.Rows[0]["smatkhau"].ToString();
            tk.FK_iMaQuyen = int.Parse(dt.Rows[0]["FK_iMaQuyen"].ToString());
            DataProvider_DAL.Disconnect_Login(conn);
            return tk;
        }
    }
}
