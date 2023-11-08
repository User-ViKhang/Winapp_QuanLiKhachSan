using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Class_TraPhong_User_DAL
    {
        static SqlConnection conn;
        public static bool ThemHoaDon(Class_PhieuThanhToan_User_DTO ptt)
        {
            string sTruyVan = string.Format(@"insert into phieu_thanhtoan values(N'{0}',{1},N'{2}',{3},{4},{5},N'{6}',N'{7}',{8}); UPDATE PHONG SET trangthai=N'Trống' WHERE map = (select p.map from phong p, PHIEU_DANGKI pdk, DANGKI_PHONG dkp where pdk.MaPDK = dkp.MaPDK and dkp.map = p.map and pdk.MaPDK = '{9}')", ptt.SMaPTT, ptt.ISoNgay, ptt.DNgayThanhToan, ptt.FTongTien, ptt.FVAT, ptt.FTienPhaiTra, ptt.SMaPDK, ptt.SMaNV, ptt.ISoGio, ptt.SMaPDK);
            conn = DataProvider_DAL.MoKetNoi();
            bool kq = DataProvider_DAL.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider_DAL.DongKetNoi(conn);
            return kq;
        }
    }
}
