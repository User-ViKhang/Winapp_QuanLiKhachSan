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
    public partial class DanhSachLoaiPhong_GUI : Form
    {
        public DanhSachLoaiPhong_GUI()
        {
            InitializeComponent();
        }

        private void DanhSachLoaiPhong_GUI_Load(object sender, EventArgs e)
        {
            List<LoaiPhong_DTO> lstLP = LoaiPhong_BLL.LayLP();
            dgvDSLP.DataSource = lstLP;
            dgvDSLP.Columns["sMaLP"].HeaderText = "Mã";
            dgvDSLP.Columns["sMaLP"].Width = 50;
            dgvDSLP.Columns["sTenLP"].HeaderText = "Tên loại phòng";
            dgvDSLP.Columns["sTenLP"].Width = 150;
            dgvDSLP.Columns["sMoTa"].HeaderText = "Mô tả";
            dgvDSLP.Columns["sMoTa"].Width = 150;
        }

        private void DanhSachLoaiPhong_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDSLP.SelectedRows[0];
            txtMaLP.Text = dr.Cells["sMaLP"].Value.ToString();
            txtTenLP.Text = dr.Cells["sTenLP"].Value.ToString();
            txtMoTa.Text = dr.Cells["sMoTa"].Value.ToString();
            
        }

        private void dgvDSLP_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaLP.Text == "" || txtTenLP.Text == "" || txtMoTa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMaLP.Text.Length > 5)
            {
                MessageBox.Show("Mã kiểu phòng tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (LoaiPhong_BLL.TimLPTheoMa(txtMaLP.Text) != null)
            {
                MessageBox.Show("Mã loại phòng đã tồn tại!");
                return;
            }
            LoaiPhong_DTO lp = new LoaiPhong_DTO();
            lp.SMaLP = txtMaLP.Text;
            lp.STenLP = txtTenLP.Text;
            lp.SMoTa = txtMoTa.Text;
            if (LoaiPhong_BLL.ThemLP(lp) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            DanhSachLoaiPhong_GUI_Load(sender, e);
            MessageBox.Show("Đã thêm loại phòng mới.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaLP.Text == "" || LoaiPhong_BLL.TimLPTheoMa(txtMaLP.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn loại phòng!");
                return;
            }
            LoaiPhong_DTO lp = new LoaiPhong_DTO();
            lp.SMaLP = txtMaLP.Text;
            lp.STenLP = txtTenLP.Text;
            lp.SMoTa = txtMoTa.Text;
            if (LoaiPhong_BLL.XoaLP(lp) == true)
            {
                DanhSachLoaiPhong_GUI_Load(sender, e);
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
            if (txtMaLP.Text == "" || LoaiPhong_BLL.TimLPTheoMa(txtMaLP.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã loại phòng!");
                return;
            }
            LoaiPhong_DTO lp = new LoaiPhong_DTO();
            lp.SMaLP = txtMaLP.Text;
            lp.STenLP = txtTenLP.Text;
            lp.SMoTa = txtMoTa.Text;


            if (LoaiPhong_BLL.SuaLP(lp) == true)
            {
                DanhSachLoaiPhong_GUI_Load(sender, e);
                MessageBox.Show("Đã cập nhật thông tin loại phòng");
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
