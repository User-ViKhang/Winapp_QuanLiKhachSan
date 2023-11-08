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
    public partial class DangKiDichVu_GUI : Form
    {
        public DangKiDichVu_GUI()
        {
            InitializeComponent();
        }

        private void DangKiDichVu_GUI_Load(object sender, EventArgs e)
        {
            List<DangKiDichVu_DTO> lstDS = DangKiDichVu_BLL.LayPDK();
            dgvDangKiDichVu.DataSource = lstDS;

            List<PhieuDangKi_DTO> cboPDK = PhieuDangKi_BLL.LayPDK();
            cboLoc.DataSource = cboPDK;
            cboLoc.ValueMember = "sMaPhieu";
            cboLoc.DisplayMember = "sMaPhieu";

            dgvDangKiDichVu.Columns["sMaDV"].HeaderText = "Mã dịch vụ";
            dgvDangKiDichVu.Columns["sMaDV"].Width = 100;
            dgvDangKiDichVu.Columns["sMaPDK"].HeaderText = "Mã phiếu";
            dgvDangKiDichVu.Columns["sMaPDK"].Width = 100;
            dgvDangKiDichVu.Columns["stenDv"].HeaderText = "Tên";
            dgvDangKiDichVu.Columns["stenDv"].Width = 100;
            dgvDangKiDichVu.Columns["fgiadv"].HeaderText = "Giá";
            dgvDangKiDichVu.Columns["fgiadv"].Width = 100;
        }

        private void dgvDangKiDichVu_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDangKiDichVu.SelectedRows[0];
            txtMaDV.Text = dr.Cells["sMaDV"].Value.ToString();
            txtMaPDK.Text = dr.Cells["sMaPDK"].Value.ToString();
            txtTenDV.Text = dr.Cells["sTenDV"].Value.ToString();
            txtGiaDV.Text = dr.Cells["fGiaDV"].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ma = cboLoc.Text;
            List<DangKiDichVu_DTO> lstPDK = DangKiDichVu_BLL.loc(ma);
            if (lstPDK == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgvDangKiDichVu.DataSource = lstPDK;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboLoc.Text = "";
            btnTim_Click(sender, e);
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
                Application.Exit();
        }
    }
}
