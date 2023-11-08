using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DataProvider_DAL
    {
        public static SqlConnection Connect_Login()
        {
            string sTruyVan = @"Data Source=LAPTOP-J92JSP1P\SQLEXPRESS01;Initial Catalog=LOGIN_QUANLIKHACHSAN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sTruyVan);
            conn.Open();
            return conn;
        }
        public static void Disconnect_Login(SqlConnection conn)
        {
            conn.Close();
        }
        //--------------------------------------
        public static SqlConnection MoKetNoi()
        {
            string sTruyVan = @"Data Source=LAPTOP-J92JSP1P\SQLEXPRESS01;Initial Catalog=QUANLIKHACHSAN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sTruyVan);
            conn.Open();
            return conn;
        }
        public static void DongKetNoi(SqlConnection conn)
        {
            conn.Close();
        }
        //--------------------------------------
        public static DataTable TruyVanLayDuLieu(string sTruyVan, SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool TruyVanKhongLayDuLieu(string sTruyVan, SqlConnection conn)
        {
            try
            {
                SqlCommand cm = new SqlCommand(sTruyVan, conn);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //--------------------------------------
        public static string Check_Login_DTO(TaiKhoan_DTO taikhoan)
        {
            string user = null;
            SqlConnection conn = Connect_Login();
            //conn.Open();
            SqlCommand cmd = new SqlCommand("proc_login", conn); 
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", taikhoan.STaiKhoan);
            cmd.Parameters.AddWithValue("@pass", taikhoan.SMatKhau);
            cmd.Parameters.AddWithValue("@quyen", taikhoan.FK_iMaQuyen);
            cmd.Connection = conn;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    user = rd.GetString(0);
                    return user;
                }
                rd.Close();
                conn.Close();
            }
            else
            {
                return "Tai khoan hoac mat khau khong chinh xac";
            }
            return user;
        }
    }
}