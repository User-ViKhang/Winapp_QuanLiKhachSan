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
    public partial class ChinhSuaThongTinNhanVien_GUI : Form
    {
        public ChinhSuaThongTinNhanVien_GUI()
        {
            InitializeComponent();
        }

        private void ChinhSuaThongTinNhanVien_GUI_Load(object sender, EventArgs e)
        {
            List<NhanVien_DTO> lstNV = NhanVien_BLL.LayDS();
            dgvDanhSachNhanVien.DataSource = lstNV;

            dgvDanhSachNhanVien.Columns["sMaNV"].HeaderText = "Mã";
            dgvDanhSachNhanVien.Columns["sMaNV"].Width = 80;
            dgvDanhSachNhanVien.Columns["sTenNV"].HeaderText = "Họ tên";
            dgvDanhSachNhanVien.Columns["sTenNV"].Width = 140;
            dgvDanhSachNhanVien.Columns["sGioiTinh"].HeaderText = "Phái";
            dgvDanhSachNhanVien.Columns["sGioiTinh"].Width = 80;
            dgvDanhSachNhanVien.Columns["dNgaySinh"].HeaderText = "Năm sinh";
            dgvDanhSachNhanVien.Columns["dNgaySinh"].Width = 100;
            dgvDanhSachNhanVien.Columns["icmnd"].HeaderText = "CMND";
            dgvDanhSachNhanVien.Columns["icmnd"].Width = 100;
            dgvDanhSachNhanVien.Columns["isdt"].HeaderText = "SDT";
            dgvDanhSachNhanVien.Columns["isdt"].Width = 100;
            dgvDanhSachNhanVien.Columns["semail"].HeaderText = "Email";
            dgvDanhSachNhanVien.Columns["semail"].Width = 120;
        }

        private void dgvDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDanhSachNhanVien.SelectedRows[0];
            txtMaNV.Text = dr.Cells["sMaNV"].Value.ToString();
            txtTenNV.Text = dr.Cells["sTenNV"].Value.ToString();
            if(dr.Cells["sgioitinh"].Value.ToString() == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            dtpNgaySinh.Text = dr.Cells["dNgaysinh"].Value.ToString();
            txtCMND.Text = dr.Cells["icmnd"].Value.ToString();
            txtSDT.Text = dr.Cells["isdt"].Value.ToString();
            txtEmail.Text = dr.Cells["semail"].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = txtTraCuuTheoTen.Text;
            List<NhanVien_DTO> lstNV = NhanVien_BLL.TimNhanVienTheoTen(ten);
            if (lstNV == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgvDanhSachNhanVien.DataSource = lstNV;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTraCuuTheoTen.Text = "";
            btnTim_Click(sender, e);
        }

        private void txtTraCuuTheoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtCMND.Text == "" || txtEmail.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMaNV.Text.Length > 5)
            {
                MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (NhanVien_BLL.TimNhanVienTheoMa(txtMaNV.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            nv.STenNV = txtTenNV.Text;
            if (rdNam.Checked == true)
            {
                nv.SGioiTinh = "Nam";
            }
            else
            {
                nv.SGioiTinh = "Nữ";
            }
            nv.DNgaySinh = dtpNgaySinh.Text;
            nv.ICMND = int.Parse(txtCMND.Text);
            nv.ISDT = int.Parse(txtSDT.Text);
            nv.SEmail = txtEmail.Text;
            if (NhanVien_BLL.ThemNhanVien(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            ChinhSuaThongTinNhanVien_GUI_Load(sender, e);
            MessageBox.Show("Đã thêm nhân viên.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaNV.Text == "" || NhanVien_BLL.TimNhanVienTheoMa(txtMaNV.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!");
                return;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            nv.STenNV = txtTenNV.Text;
            if (rdNam.Checked == true)
            {
                nv.SGioiTinh = "Nam";
            }
            else
            {
                nv.SGioiTinh = "Nữ";
            }
            nv.DNgaySinh = dtpNgaySinh.Text;
            nv.ICMND = int.Parse(txtCMND.Text);
            nv.ISDT = int.Parse(txtSDT.Text);
            nv.SEmail = txtEmail.Text;
            if (NhanVien_BLL.XoaNV(nv) == true)
            {
                ChinhSuaThongTinNhanVien_GUI_Load(sender, e);
                MessageBox.Show("Đã xóa loại phòng.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaNV.Text == "" || NhanVien_BLL.TimNhanVienTheoMa(txtMaNV.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!");
                return;
            }

            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            nv.STenNV = txtTenNV.Text;
            if (rdNam.Checked == true)
            {
                nv.SGioiTinh = "Nam";
            }
            else
            {
                nv.SGioiTinh = "Nữ";
            }
            nv.DNgaySinh = dtpNgaySinh.Text;
            nv.ICMND = int.Parse(txtCMND.Text);
            nv.ISDT = int.Parse(txtSDT.Text);
            nv.SEmail = txtEmail.Text;

            if (NhanVien_BLL.SuaNV(nv) == true)
            {
                ChinhSuaThongTinNhanVien_GUI_Load(sender, e);
                MessageBox.Show("Đã cập nhật thông tin nhân viên");
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
