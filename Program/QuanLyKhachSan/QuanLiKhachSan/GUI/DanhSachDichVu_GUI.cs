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
    public partial class frm_DanhSachDichVu_GUI : Form
    {
        public frm_DanhSachDichVu_GUI()
        {
            InitializeComponent();
        }

        private void frm_DanhSachDichVu_GUI_Load(object sender, EventArgs e)
        {
            List<DanhSachDichVu_DTO> lstDV = DanhSachDichVu_BLL.LayDV();
            dgvDSDichVu.DataSource = lstDV;
            dgvDSDichVu.Columns["sMaDV"].HeaderText = "Mã";
            dgvDSDichVu.Columns["sMaDV"].Width = 50;
            dgvDSDichVu.Columns["sTenDV"].HeaderText = "Tên dịch vụ";
            dgvDSDichVu.Columns["sTenDV"].Width = 220;
            dgvDSDichVu.Columns["fgiadv"].HeaderText = "Giá";
            dgvDSDichVu.Columns["fgiadv"].Width = 100;
        }

        private void DanhSachDichVu_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDSDichVu.SelectedRows[0];
            txtMaDV.Text = dr.Cells["sMaDV"].Value.ToString();
            txtTenDichVu.Text = dr.Cells["sTenDV"].Value.ToString();
            txtGia.Text = dr.Cells["fgiadv"].Value.ToString();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaDV.Text == "" || txtTenDichVu.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMaDV.Text.Length > 5)
            {
                MessageBox.Show("Mã dịch vụ tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (DanhSachDichVu_BLL.TimDVTheoMa(txtMaDV.Text) != null)
            {
                MessageBox.Show("Mã dịch vụ đã tồn tại!");
                return;
            }
            DanhSachDichVu_DTO dv = new DanhSachDichVu_DTO();
            dv.SMaDV = txtMaDV.Text;
            dv.STenDV = txtTenDichVu.Text;
            dv.FGiaDV = float.Parse(txtGia.Text);
            if (DanhSachDichVu_BLL.ThemDV(dv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            frm_DanhSachDichVu_GUI_Load(sender, e);
            MessageBox.Show("Đã thêm kiểu phòng mới.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaDV.Text == "" || DanhSachDichVu_BLL.TimDVTheoMa(txtMaDV.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ!");
                return;
            }
            DanhSachDichVu_DTO dv = new DanhSachDichVu_DTO();
            dv.SMaDV = txtMaDV.Text;
            dv.STenDV = txtTenDichVu.Text;
            dv.FGiaDV = float.Parse(txtGia.Text);
            if (DanhSachDichVu_BLL.XoaDV(dv) == true)
            {
                frm_DanhSachDichVu_GUI_Load(sender, e);
                MessageBox.Show("Đã xóa dịch vụ.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaDV.Text == "" || DanhSachDichVu_BLL.TimDVTheoMa(txtMaDV.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ!");
                return;
            }

            DanhSachDichVu_DTO dv = new DanhSachDichVu_DTO();
            dv.SMaDV = txtMaDV.Text;
            dv.STenDV = txtTenDichVu.Text;
            dv.FGiaDV = float.Parse(txtGia.Text);

            if (DanhSachDichVu_BLL.SuaDV(dv) == true)
            {
                frm_DanhSachDichVu_GUI_Load(sender, e);
                MessageBox.Show("Đã cập nhật thông tin dịch vụ");
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
