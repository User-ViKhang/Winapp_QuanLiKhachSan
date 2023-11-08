using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Class_TraPhong_PhieuDangKi_User_DAL
    {
        static SqlConnection conn;
        public static List<Class_TraPhong_PhieuDangKi_User_DTO> LayPDK()
        {
            string sTruyVan = "select pdk.MaPDK, kh.TenKH, pdk.SoPhong, pdk.NgayDen, pdk.NgayDi, pdk.SoGio, pdk.TraTruoc, p.MaP, kh.MaKH, pdk.MaNV from PHIEU_DANGKI pdk, KHACHHANG kh, DANGKI_PHONG dkp, PHONG p where pdk.MaKH = kh.makh and pdk.MaPDK = dkp.mapdk and dkp.MaP=p.MaP and p.TrangThai = N'Kín'";
            conn = DataProvider_DAL.MoKetNoi();
            DataTable dt = DataProvider_DAL.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Class_TraPhong_PhieuDangKi_User_DTO> lstpdk = new List<Class_TraPhong_PhieuDangKi_User_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Class_TraPhong_PhieuDangKi_User_DTO pdk = new Class_TraPhong_PhieuDangKi_User_DTO();
                pdk.SMaPDK = dt.Rows[i]["mapdk"].ToString();
                pdk.STenKH = dt.Rows[i]["TenKH"].ToString();
                pdk.SSoP = dt.Rows[i]["sophong"].ToString();
                pdk.DNgayDen = DateTime.Parse(dt.Rows[i]["ngayden"].ToString());
                pdk.DNgayDi = DateTime.Parse(dt.Rows[i]["ngaydi"].ToString());
                pdk.ISoGio = int.Parse(dt.Rows[i]["sogio"].ToString());
                pdk.FTraTruoc = float.Parse(dt.Rows[i]["tratruoc"].ToString());
                pdk.SMaP = dt.Rows[i]["map"].ToString();
                pdk.SMaKH = dt.Rows[i]["makh"].ToString();
                pdk.SMaNV = dt.Rows[i]["manv"].ToString();
                lstpdk.Add(pdk);
            }
            return lstpdk;
        }
    }
}
