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
    public partial class QuenMatKhau_GUI : Form
    {
        public QuenMatKhau_GUI()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txtNhapCodeThon.Text == "")
            {
                MessageBox.Show("Code thông hành không đươc để trống", "Thông báo lỗi");
            } else if(txtNhapCodeThon.Text != "11112002")
            {
                MessageBox.Show("Code thông hành không chính xác", "Thông báo lỗi");
            } else if (txtNhapCodeThon.Text == "11112002" && TaiKhoan_BLL.TimTenUser(txtNhapTenDangNhap.Text) != null)
            {
                TaiKhoan_DTO tk = TaiKhoan_BLL.TimTenUser(txtNhapTenDangNhap.Text);
                txtTenDangNhapTraVe.Text = tk.STaiKhoan.ToString();
                txtMatKhauTraVe.Text = tk.SMatKhau.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên đăng nhập", "Thông báo lỗi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DangNhap_GUI frmDangNhap = new DangNhap_GUI();
            frmDangNhap.Show();
            this.Visible = false;
            this.Hide();
        }

        private void txtNhapCodeThon_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuenMatKhau_GUI_Load(object sender, EventArgs e)
        {
            txtNhapCodeThon.UseSystemPasswordChar = true;
        }
    }
}
