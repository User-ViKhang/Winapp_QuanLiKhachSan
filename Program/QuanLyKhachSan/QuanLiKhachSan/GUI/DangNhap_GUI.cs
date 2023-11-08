using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class DangNhap_GUI : Form
    {
        TaiKhoan_DTO taikhoan_dto = new TaiKhoan_DTO();
        TaiKhoan_BLL taikhoan_bll = new TaiKhoan_BLL();

        public DangNhap_GUI()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            taikhoan_dto.STaiKhoan = txtTenDangNhap.Text;
            taikhoan_dto.SMatKhau = txtMatKhau.Text;
            if (rdQuanTri.Checked == true)
            {
                taikhoan_dto.FK_iMaQuyen = 1;
            } else if(rdKhach.Checked == true)
            {
                taikhoan_dto.FK_iMaQuyen = 2;
            }
            string getuser = taikhoan_bll.Check_Login(taikhoan_dto);
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống", "Đăng nhập thất bại");
                    return;
                case "requeid_password":
                    MessageBox.Show("Mật khẩu không được để trống", "Đăng nhập thất bại");
                    return;
                case "Tai khoan hoac mat khau khong chinh xac":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Đăng nhập thất bại");
                    return;
            }
            TaiKhoan_DTO tk = TaiKhoan_BLL.TimTenUser(txtTenDangNhap.Text);
            if(rdQuanTri.Checked == true)
            {
                MessageBox.Show("Bạn đang ở quyền Quản trị viên.", "Xin chào " + tk.STaiKhoan);
                GiaoDienChinh frmGiaoDienChinh = new GiaoDienChinh(tk.STaiKhoan);
                frmGiaoDienChinh.Show();
                this.Visible=false;
                this.Hide();
            }
            else if (rdKhach.Checked == true)
            {
                MessageBox.Show("Bạn đang ở quyền Nhân viên.", "Xin chào " + tk.STaiKhoan);
                GiaoDien_User frmGiaoDienChinh = new GiaoDien_User(tk.STaiKhoan);
                frmGiaoDienChinh.Show();
                this.Visible = false;
                this.Hide();
            }
        }

        private void DangNhap_GUI_Load(object sender, EventArgs e)
        {
            rdQuanTri.Checked = true;
            txtTenDangNhap.Focus();
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void lmDangKi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKi_GUI frm_dk = new DangKi_GUI();
            frm_dk.Show();
            this.Visible = false;
            this.Hide();
            
        }

        private void lkQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau_GUI frmQuenMK = new QuenMatKhau_GUI();
            frmQuenMK.Show();
            this.Visible=false;
            this.Hide();
        }

        private void rdHienMK_CheckedChanged_1(object sender, EventArgs e)
        {
            if(rdHienMK.Checked == false)
            {
                txtMatKhau.UseSystemPasswordChar = true;
            } else
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
        }
    }
}
