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
    public partial class ChinhSuaThongTinKhachHang_GUI : Form
    {
        public ChinhSuaThongTinKhachHang_GUI()
        {
            InitializeComponent();
        }

        private void ChinhSuaThongTinKhachHang_GUI_Load(object sender, EventArgs e)
        {
            List<KhachHang_DTO> lstKH = KhachHang_BLL.LayKH();
            dgvDanhSachKhachHang.DataSource = lstKH;

            dgvDanhSachKhachHang.Columns["sMaKH"].HeaderText = "Mã";
            dgvDanhSachKhachHang.Columns["sMaKH"].Width = 50;
            dgvDanhSachKhachHang.Columns["sGioiTinh"].HeaderText = "Phái";
            dgvDanhSachKhachHang.Columns["sGioiTinh"].Width = 50;
            dgvDanhSachKhachHang.Columns["sTenKH"].HeaderText = "Họ tên";
            dgvDanhSachKhachHang.Columns["sTenKH"].Width = 100;
            dgvDanhSachKhachHang.Columns["icmnd"].HeaderText = "CMND";
            dgvDanhSachKhachHang.Columns["icmnd"].Width = 80;
            dgvDanhSachKhachHang.Columns["sdiachi"].HeaderText = "Địa chỉ";
            dgvDanhSachKhachHang.Columns["sdiachi"].Width = 100;
            dgvDanhSachKhachHang.Columns["squoctich"].HeaderText = "Quốc tịch";
            dgvDanhSachKhachHang.Columns["squoctich"].Width = 80;
            dgvDanhSachKhachHang.Columns["isdt"].HeaderText = "SDT";
            dgvDanhSachKhachHang.Columns["isdt"].Width = 80;
            dgvDanhSachKhachHang.Columns["semail"].HeaderText = "Email";
            dgvDanhSachKhachHang.Columns["semail"].Width = 120;
            dgvDanhSachKhachHang.Columns["dnamsinh"].HeaderText = "Năm sinh";
            dgvDanhSachKhachHang.Columns["dnamsinh"].Width = 80;
        }

        private void dgvDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDanhSachKhachHang.SelectedRows[0];
            txtMaKH.Text = dr.Cells["sMaKH"].Value.ToString();
            if (dr.Cells["sGioiTinh"].Value.ToString() == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            txtTenKH.Text = dr.Cells["sTenKH"].Value.ToString();
            txtCMND.Text = dr.Cells["iCMND"].Value.ToString();
            txtDiaChi.Text = dr.Cells["sDiaChi"].Value.ToString();
            txtQuocTich.Text = dr.Cells["sQuocTich"].Value.ToString();
            txtSDT.Text = dr.Cells["isdt"].Value.ToString();
            txtEmail.Text = dr.Cells["sEmail"].Value.ToString();
            dtpNgaySinh.Text = dr.Cells["dNamSinh"].Value.ToString();
        }

        private void dgvDanhSachKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = txtTraCuuTheoTen.Text;
            List<KhachHang_DTO> lstKH = KhachHang_BLL.TimKhachHangTheoTen(ten);
            if (lstKH == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgvDanhSachKhachHang.DataSource = lstKH;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTraCuuTheoTen.Text = "";
            btnTim_Click(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtEmail.Text == "" || txtCMND.Text == "" || txtDiaChi.Text == "" || txtQuocTich.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMaKH.Text.Length > 5)
            {
                MessageBox.Show("Mã khách hàng tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (KhachHang_BLL.TimKhachHangTheoMa(txtMaKH.Text) != null)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!");
                return;
            }
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.SMaKH = txtMaKH.Text;
            if (rdNam.Checked == true)
            {
                kh.SGioiTinh = "Nam";
            }
            else
            {
                kh.SGioiTinh = "Nữ";
            }
            kh.STenKH = txtTenKH.Text;
            kh.ICMND = int.Parse(txtCMND.Text);
            kh.SDiaChi = txtDiaChi.Text;
            kh.SQuocTich = txtQuocTich.Text;
            kh.ISDT = int.Parse(txtSDT.Text);
            kh.SEmail = txtEmail.Text;
            kh.DNamSinh = DateTime.Parse(dtpNgaySinh.Text);

            if(KhachHang_BLL.ThemKhachHang(kh) == false)
            {
                MessageBox.Show("Khong thêm được");
                return;
            }

            List<KhachHang_DTO> lstKH = KhachHang_BLL.LayKH();
            dgvDanhSachKhachHang.DataSource = lstKH;

            MessageBox.Show("Đã thêm nhân viên.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaKH.Text == "" || KhachHang_BLL.TimKhachHangTheoMa(txtMaKH.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn kiểu phòng!");
                return;
            }
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.SMaKH = txtMaKH.Text;
            if (rdNam.Checked == true)
            {
                kh.SGioiTinh = "Nam";
            }
            else
            {
                kh.SGioiTinh = "Nữ";
            }
            kh.STenKH = txtTenKH.Text;
            kh.ICMND = int.Parse(txtCMND.Text);
            kh.SDiaChi = txtDiaChi.Text;
            kh.SQuocTich = txtQuocTich.Text;
            kh.ISDT = int.Parse(txtSDT.Text);
            kh.SEmail = txtEmail.Text;
            kh.DNamSinh = DateTime.Parse(dtpNgaySinh.Text);
            if (KhachHang_BLL.XoaKH(kh) == true)
            {
                ChinhSuaThongTinKhachHang_GUI_Load(sender, e);
                MessageBox.Show("Đã xóa khách hàng.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaKH.Text == "" || KhachHang_BLL.TimKhachHangTheoMa(txtMaKH.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!");
                return;
            }
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.SMaKH = txtMaKH.Text;
            if (rdNam.Checked == true)
            {
                kh.SGioiTinh = "Nam";
            }
            else
            {
                kh.SGioiTinh = "Nữ";
            }
            kh.STenKH = txtTenKH.Text;
            kh.ICMND = int.Parse(txtCMND.Text);
            kh.SDiaChi = txtDiaChi.Text;
            kh.SQuocTich = txtQuocTich.Text;
            kh.ISDT = int.Parse(txtSDT.Text);
            kh.SEmail = txtEmail.Text;
            kh.DNamSinh = DateTime.Parse(dtpNgaySinh.Text);


            if (KhachHang_BLL.SuaKH(kh) == true)
            {
                ChinhSuaThongTinKhachHang_GUI_Load(sender, e);
                MessageBox.Show("Đã cập nhật thông tin khách hàng");
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn trờ về giao diện không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                GiaoDienChinh frm = new GiaoDienChinh();
                frm.Show();
                this.Hide();
                this.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
