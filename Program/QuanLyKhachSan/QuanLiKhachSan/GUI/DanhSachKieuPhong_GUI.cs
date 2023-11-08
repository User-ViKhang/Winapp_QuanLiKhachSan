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
    public partial class frmDSKP : Form
    {
        public frmDSKP()
        {
            InitializeComponent();
        }

        private void frmDSKP_Load(object sender, EventArgs e)
        {
            List<KieuPhong_DTO> lstDS = KieuPhong_BLL.LayKP();
            dgvDSKP.DataSource = lstDS;
            dgvDSKP.Columns["sMaKP"].HeaderText = "Mã";
            dgvDSKP.Columns["sMaKP"].Width = 50;
            dgvDSKP.Columns["sTenKP"].HeaderText = "Tên kiểu phòng";
            dgvDSKP.Columns["sTenKP"].Width = 150;
            dgvDSKP.Columns["sMoTa"].HeaderText = "Trang bị";
            dgvDSKP.Columns["sMoTa"].Width = 150;
        }

        private void dgvDSKP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DanhSachKieuPhong_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDSKP.SelectedRows[0];
            txtMaKP.Text = dr.Cells["sMaKP"].Value.ToString();
            txtTenKP.Text = dr.Cells["sTenKP"].Value.ToString();
            txtTrangBi.Text = dr.Cells["sMoTa"].Value.ToString();
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
            if (txtMaKP.Text == "" || txtTenKP.Text == "" || txtTrangBi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMaKP.Text.Length > 5)
            {
                MessageBox.Show("Mã kiểu phòng tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (KieuPhong_BLL.TimKPTheoMa(txtMaKP.Text) != null)
            {
                MessageBox.Show("Mã kiểu phòng đã tồn tại!");
                return;
            }
            KieuPhong_DTO kp = new KieuPhong_DTO();
            kp.SMaKP = txtMaKP.Text;
            kp.STenKP = txtTenKP.Text;
            kp.SMoTa = txtTrangBi.Text;
            if (KieuPhong_BLL.ThemKieuPhong(kp) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            frmDSKP_Load(sender, e);
            MessageBox.Show("Đã thêm kiểu phòng mới.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaKP.Text == "" || KieuPhong_BLL.TimKPTheoMa(txtMaKP.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn kiểu phòng!");
                return;
            }
            KieuPhong_DTO kp = new KieuPhong_DTO();
            kp.SMaKP = txtMaKP.Text;
            kp.STenKP = txtTenKP.Text;
            kp.SMoTa = txtTrangBi.Text;
            if (KieuPhong_BLL.XoaKP(kp) == true)
            {
                frmDSKP_Load(sender, e);
                MessageBox.Show("Đã xóa kiểu phòng.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaKP.Text == "" || KieuPhong_BLL.TimKPTheoMa(txtMaKP.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã kiểu phòng!");
                return;
            }
            KieuPhong_DTO kp = new KieuPhong_DTO();
            kp.SMaKP = txtMaKP.Text;
            kp.STenKP = txtTenKP.Text;
            kp.SMoTa = txtTrangBi.Text;
            

            if (KieuPhong_BLL.SuaKP(kp) == true)
            {
                frmDSKP_Load(sender, e);
                MessageBox.Show("Đã cập nhật thông tin kiểu phòng");
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
