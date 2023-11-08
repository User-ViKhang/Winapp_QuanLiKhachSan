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
    public partial class DangKi_GUI : Form
    {
        public DangKi_GUI()
        {
            InitializeComponent();
        }

        private void DangKi_GUI_Load(object sender, EventArgs e)
        {
            rdKhach.Checked = true;
            rdKhach.Enabled = false;
            txtCode.UseSystemPasswordChar = true;
            txtMatKhau.UseSystemPasswordChar = true;

        }

        private void lkDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap_GUI frm_dn = new DangNhap_GUI();
            frm_dn.Show();
            this.Visible = false;
            this.Hide();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if(txtCode.Text == "11112002")
            {
                if(txtTenDangNhap.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo lỗi");
                    return;
                }
                if(txtMatKhau.Text.Length <= 5 && txtMatKhau.Text.Length > 20)
                {
                    MessageBox.Show("Mật khẩu quá ngắn!", "Thông báo lỗi");
                    return;
                }
                if(TaiKhoan_BLL.TimTenUser(txtTenDangNhap.Text) != null)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại! Hãy thử tên đăng nhập khác.", "Thông báo lỗi");
                    return;
                }
                TaiKhoan_DTO tk = new TaiKhoan_DTO();
                tk.SMaTK = 2.ToString();
                tk.STaiKhoan = txtTenDangNhap.Text;
                tk.SMatKhau = txtMatKhau.Text;
                tk.FK_iMaQuyen = 2;
                if(TaiKhoan_BLL.DangKiTaoKhoan(tk) == false)
                {
                    MessageBox.Show("Không thêm được!", "Thông báo lỗi");
                    return;
                }
                MessageBox.Show("Đăng kí thành công!", "Thông báo");
            }
            else if(txtCode.Text == "")
            {
                MessageBox.Show("Bạn phải có code thông thành để tạo tài khoản", "Thông báo lỗi");
            }
            else
            {
                MessageBox.Show("Code thông hành không chính xác, vui lòng thử lại.", "Thông báo CODE thông hành");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Hide();
            DangNhap_GUI frmDangNhap = new DangNhap_GUI();
            frmDangNhap.Show();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (rdHienMK.Checked == false)
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
        }
    }
}
