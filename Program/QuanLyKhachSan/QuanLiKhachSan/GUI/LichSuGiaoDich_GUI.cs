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
    public partial class LichSuGiaoDich_GUI : Form
    {
        public LichSuGiaoDich_GUI()
        {
            InitializeComponent();
        }

        private void LichSuGiaoDich_GUI_Load(object sender, EventArgs e)
        {
            List<PhieuDangKi_DTO> lstPDK = PhieuDangKi_BLL.LayPDK();
            dgvPhieuDangKi.DataSource = lstPDK;

            dgvPhieuDangKi.Columns["sMaPhieu"].HeaderText = "Mã phiếu";
            dgvPhieuDangKi.Columns["sMaPhieu"].Width = 100;
            dgvPhieuDangKi.Columns["isophong"].HeaderText = "Số phòng";
            dgvPhieuDangKi.Columns["isophong"].Width = 100;
            dgvPhieuDangKi.Columns["ftratruoc"].HeaderText = "Trả trước";
            dgvPhieuDangKi.Columns["ftratruoc"].Width = 100;
            dgvPhieuDangKi.Columns["dngayden"].HeaderText = "Ngày đến";
            dgvPhieuDangKi.Columns["dngayden"].Width = 100;
            dgvPhieuDangKi.Columns["dngaydi"].HeaderText = "Ngày đi";
            dgvPhieuDangKi.Columns["dngaydi"].Width = 100;
            dgvPhieuDangKi.Columns["isogio"].HeaderText = "Số giờ";
            dgvPhieuDangKi.Columns["isogio"].Width = 100;
            dgvPhieuDangKi.Columns["smakhach"].HeaderText = "Mã khách";
            dgvPhieuDangKi.Columns["smakhach"].Width = 100;
            dgvPhieuDangKi.Columns["smanhanvien"].HeaderText = "Mã nhân viên";
            dgvPhieuDangKi.Columns["smanhanvien"].Width = 150;
            dgvPhieuDangKi.Columns["stenkhachhang"].HeaderText = "Tên khách hàng";
            dgvPhieuDangKi.Columns["stenkhachhang"].Width = 150;
            dgvPhieuDangKi.Columns["stennhanvien"].HeaderText = "Tên nhân viên";
            dgvPhieuDangKi.Columns["stennhanvien"].Width = 150;
        }

        private void dgvPhieuDangKi_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvPhieuDangKi.SelectedRows[0];
            txtPhieuDK.Text = dr.Cells["sMaPhieu"].Value.ToString();
            txtSoPhong.Text = dr.Cells["isophong"].Value.ToString();
            txtTraTruoc.Text = dr.Cells["ftratruoc"].Value.ToString();
            dtpNgayDen.Text = dr.Cells["dngayden"].Value.ToString();
            dtpNgayDi.Text = dr.Cells["dngaydi"].Value.ToString();
            txtSoGio.Text = dr.Cells["isogio"].Value.ToString();
            txtKhachHang.Text = dr.Cells["smakhach"].Value.ToString();
            txtNhanVien.Text = dr.Cells["smanhanvien"].Value.ToString();
            txtTenKhachHang.Text = dr.Cells["stenkhachhang"].Value.ToString();
            txtTenNhanVien.Text = dr.Cells["stennhanvien"].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string ngay = txtTraCuuTheoNgayDen.Text;
                string find = "='" + ngay + "'";
                List<PhieuDangKi_DTO> lstPDK = PhieuDangKi_BLL.TimPDKTheoNgayDen(find);
                if (lstPDK == null)
                {
                    MessageBox.Show("Không tìm thấy!");
                    return;
                }
                dgvPhieuDangKi.DataSource = lstPDK;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }
        

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            string ngay = "";
            string find = "like '%" + ngay + "%'";
            List<PhieuDangKi_DTO> lstPDK = PhieuDangKi_BLL.TimPDKTheoNgayDen(find);
            if (lstPDK == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgvPhieuDangKi.DataSource = lstPDK;
        }

        private void label13_Click(object sender, EventArgs e)
        {

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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                GiaoDien_User frm = new GiaoDien_User();
                frm.Show();
                this.Visible = false;
                this.Hide();
            }
        }
    }
}
