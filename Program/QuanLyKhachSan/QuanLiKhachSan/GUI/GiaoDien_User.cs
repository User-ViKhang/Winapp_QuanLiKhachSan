using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GiaoDien_User : Form
    {
        string tenTaiKhoan;
        public GiaoDien_User()
        {
            InitializeComponent();
        }
        public GiaoDien_User(string tenTaiKhoan)
        {
            InitializeComponent();
            this.tenTaiKhoan = tenTaiKhoan;
        }


        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phong_User frmPhongUS = new Phong_User();
            frmPhongUS.Show();
            this.Hide();
            this.Visible = false;
        }

        private void kiểuPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KieuPhong_GUI_User frmKuPhongUS = new KieuPhong_GUI_User();
            frmKuPhongUS.Show();
            this.Hide();
            this.Visible = false;

        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiPhong_GUI_User loaiPhongUS = new LoaiPhong_GUI_User();
            loaiPhongUS.Show();
            this.Visible = false;
            this.Hide();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DichVu_GUI_User frmDVUS = new DichVu_GUI_User();
            frmDVUS.Show();
            this.Hide();
            this.Visible = false;
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatPhong_GUI_User frmDat = new DatPhong_GUI_User();
            frmDat.Show();
            this.Hide();
            this.Visible = false;
        }

        private void đăngKíDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TraPhong_PhieuDangKi_GUI_User frm = new Form_TraPhong_PhieuDangKi_GUI_User();
            frm.Show();
            this.Hide();
            this.Visible = false;
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon_GUI frmHD = new HoaDon_GUI();
            frmHD.Show();
            this.Hide();
            this.Visible = false;
        }

        private void GiaoDien_User_Load_1(object sender, EventArgs e)
        {
            this.lbTenDangNhap.Text = tenTaiKhoan;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap_GUI frmDX = new DangNhap_GUI();
            frmDX.Show();
            this.Hide();
            this.Visible = false;
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChinhSuaThongTinKhachHang_GUI frm = new ChinhSuaThongTinKhachHang_GUI();
            frm.Show();
            this.Hide();
            this.Visible = false;
        }
    }
}
