using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDon_BLL
    {

        public static List<HoaDon_DTO> LayHD()
        {
            return HoaDon_DAL.LayHD();
        }
        public static List<HoaDon_DTO> TimHDTheoNgayDen(string ngay)
        {
            return HoaDon_DAL.TimHDTheoNgayDen(ngay);
        }
        //--
        private string strMaHD;
        public void SetMaHoaDon(string strMaHD)
        {
            this.strMaHD = strMaHD;
        }

        public void XuatHoaDon()
        {
            XuatHoaDon_DAL xuatHoaDon_DAL = new XuatHoaDon_DAL();
            xuatHoaDon_DAL.XuatHoaDon(strMaHD);
        }
        //--
    }
}
