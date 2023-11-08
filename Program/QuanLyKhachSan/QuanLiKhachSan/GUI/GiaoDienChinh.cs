using BLL;
using DTO;
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
    public partial class GiaoDienChinh : Form
    {
        public string tenTaiKhoan;
        public GiaoDienChinh()
        {
            InitializeComponent();
        }
        public GiaoDienChinh(string tenTaiKhoan)
        {
            InitializeComponent();
            this.tenTaiKhoan = tenTaiKhoan;
        }

        private void GiaoDienChinh_Load(object sender, EventArgs e)
        {
            this.lbTenDangNhap.Text = tenTaiKhoan;
        }


        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChinhSuaThongTinPhong_GUI frm_ChinhSuaThongTin = new ChinhSuaThongTinPhong_GUI();
            frm_ChinhSuaThongTin.Show();
            this.Hide();
            this.Visible = false;
        }

        private void kiểuPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSKP frmKP = new frmDSKP();
            frmKP.Show();
            this.Visible = false;
            this.Hide();

        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachLoaiPhong_GUI frmLP = new DanhSachLoaiPhong_GUI();
            frmLP.Show();
            this.Visible = false;
            this.Hide();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DanhSachDichVu_GUI frmDV = new frm_DanhSachDichVu_GUI();
            frmDV.Show();
            this.Hide();
            this.Visible=false;
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChinhSuaThongTinKhachHang_GUI frmChinhSuaKH = new ChinhSuaThongTinKhachHang_GUI();
            frmChinhSuaKH.Show();
            this.Hide();
            this.Visible = false;
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChinhSuaThongTinNhanVien_GUI frmNhanVien = new ChinhSuaThongTinNhanVien_GUI();
            frmNhanVien.Show();
            this.Hide();
            this.Visible = false;
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LichSuGiaoDich_GUI frmLichSu = new LichSuGiaoDich_GUI();
            frmLichSu.Show();
            this.Hide();
            this.Visible = false;
        }

        private void đăngKíDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKiDichVu_GUI frmDKDV = new DangKiDichVu_GUI();
            frmDKDV.Show();
            this.Visible = false;
            this.Hide();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon_GUI frmHD = new HoaDon_GUI();
            frmHD.Show();
            this.Visible = false;
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap_GUI frmHD = new DangNhap_GUI();
            frmHD.Show();
            this.Hide();
            this.Visible = false;
        }

        private void báoCáoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_bcNhanVien frm = new frm_bcNhanVien();
            frm.Show();
            this.Hide();
            this.Visible = false;
        }

        private void saoLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
