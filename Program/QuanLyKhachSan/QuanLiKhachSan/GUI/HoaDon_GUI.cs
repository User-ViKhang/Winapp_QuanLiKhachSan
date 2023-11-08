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
    public partial class HoaDon_GUI : Form
    {
        public HoaDon_GUI()
        {
            InitializeComponent();
        }

        private void HoaDon_GUI_Load(object sender, EventArgs e)
        {
            List<HoaDon_DTO> lstHD = HoaDon_BLL.LayHD();
            dgvHoaDon.DataSource = lstHD;

            dgvHoaDon.Columns["smaptt"].HeaderText = "Mã phiếu";
            dgvHoaDon.Columns["smaptt"].Width = 80;
            dgvHoaDon.Columns["smakh"].HeaderText = "Mã khách";
            dgvHoaDon.Columns["smakh"].Width = 80;
            dgvHoaDon.Columns["smanv"].HeaderText = "Mã nhân viên";
            dgvHoaDon.Columns["smanv"].Width = 100;
            dgvHoaDon.Columns["sthanhtoan"].HeaderText = "Thanh toán";
            dgvHoaDon.Columns["sthanhtoan"].Width = 100;
            dgvHoaDon.Columns["isongay"].HeaderText = "Ngày";
            dgvHoaDon.Columns["isongay"].Width = 50;
            dgvHoaDon.Columns["isogio"].HeaderText = "Giờ";
            dgvHoaDon.Columns["isogio"].Width = 50;
            dgvHoaDon.Columns["ftongtien"].HeaderText = "Tổng tiền";
            dgvHoaDon.Columns["ftongtien"].Width = 100;
            dgvHoaDon.Columns["fphaitra"].HeaderText = "Phải trả";
            dgvHoaDon.Columns["fphaitra"].Width = 100;
            dgvHoaDon.Columns["fthue"].HeaderText = "Thuế";
            dgvHoaDon.Columns["fthue"].Width = 50;
        }

        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvHoaDon.SelectedRows[0];
            txtMaPTT.Text = dr.Cells["smaptt"].Value.ToString();
            txtMaKH.Text = dr.Cells["smakh"].Value.ToString();
            txtMaNV.Text = dr.Cells["smanv"].Value.ToString();
            txtPhaiTra.Text = dr.Cells["fphaitra"].Value.ToString();
            txtTongTien.Text = dr.Cells["ftongtien"].Value.ToString();
            txtSoGio.Text = dr.Cells["isogio"].Value.ToString();
            txtSoNgay.Text = dr.Cells["isongay"].Value.ToString();
            dtpNgayThanhToan.Text = dr.Cells["sthanhtoan"].Value.ToString();
            txtThue.Text = dr.Cells["fthue"].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string ngay = dtpTim.Text;
                string find = "='" + ngay + "'";
                List<HoaDon_DTO> lstHD = HoaDon_BLL.TimHDTheoNgayDen(find);
                if (lstHD == null)
                {
                    MessageBox.Show("Không tìm thấy!");
                    return;
                }
                dgvHoaDon.DataSource = lstHD;
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
            List<HoaDon_DTO> lstHD = HoaDon_BLL.TimHDTheoNgayDen(find);
            if (lstHD == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgvHoaDon.DataSource = lstHD;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //--
            string strMaHD;
            strMaHD = txtMaPTT.Text;
            XuatHoaDon_GUI frmXuat = new XuatHoaDon_GUI(strMaHD);
            frmXuat.Show();
            this.Hide();
            this.Visible = false;
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
            traloi = MessageBox.Show("Bạn có muốn trở về trang chủ không?", "Thông báo",
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
