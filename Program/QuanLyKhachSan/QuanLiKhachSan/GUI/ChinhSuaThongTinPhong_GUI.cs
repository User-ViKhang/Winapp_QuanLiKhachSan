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
    public partial class ChinhSuaThongTinPhong_GUI : Form
    {
        public ChinhSuaThongTinPhong_GUI()
        {
            InitializeComponent();
        }

        private void ChinhSuaThongTinPhong_GUI_Load(object sender, EventArgs e)
        {
            List<ChinhSuaThongTin_DTO> lstDS = ChinhSuaThongTin_BLL.LayDS();
            dgvDSPChinhSua.DataSource = lstDS;

            List<KieuPhong_DTO> lstKP = KieuPhong_BLL.LayKP();
            cboKieuPhong.DataSource = lstKP;
            cboKieuPhong.DisplayMember = "stenkp";
            cboKieuPhong.ValueMember = "smakp";

            List<LoaiPhong_DTO> lstLP = LoaiPhong_BLL.LayLP();
            cboLoaiPhong.DataSource = lstLP;
            cboLoaiPhong.DisplayMember = "stenlp";
            cboLoaiPhong.ValueMember = "smalp";

            dgvDSPChinhSua.Columns["sMap"].HeaderText = "Mã phòng";
            dgvDSPChinhSua.Columns["sMap"].Width = 100;
            dgvDSPChinhSua.Columns["sTenp"].HeaderText = "Số phòng";
            dgvDSPChinhSua.Columns["sTenp"].Width = 90;
            dgvDSPChinhSua.Columns["sTrangThai"].HeaderText = "Status";
            dgvDSPChinhSua.Columns["sTrangThai"].Width = 60;
            dgvDSPChinhSua.Columns["sMaKP"].HeaderText = "Mã Kiểu phòng";
            dgvDSPChinhSua.Columns["sMaKP"].Visible = false;
            dgvDSPChinhSua.Columns["sTenKP"].HeaderText = "Kiểu phòng";
            dgvDSPChinhSua.Columns["sTenKP"].Width = 220;
            dgvDSPChinhSua.Columns["sMaLP"].HeaderText = "Mã loại phòng";
            dgvDSPChinhSua.Columns["sMaLP"].Visible = false;
            dgvDSPChinhSua.Columns["sTenLP"].HeaderText = "Loại phòng";
            dgvDSPChinhSua.Columns["sTenLP"].Width = 160;
            dgvDSPChinhSua.Columns["fGiaTheoGio"].HeaderText = "Giá giờ";
            dgvDSPChinhSua.Columns["fGiaTheoGio"].Width = 100;
            dgvDSPChinhSua.Columns["fGiaTheoNgay"].HeaderText = "Giá ngày";
            dgvDSPChinhSua.Columns["fGiaTheoNgay"].Width = 100;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
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

        private void ChinhSuaThongTinPhong_GUI_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDSPChinhSua.SelectedRows[0];
            txtMaPhong.Text = dr.Cells["sMap"].Value.ToString();
            txtTenPhong.Text = dr.Cells["sTenp"].Value.ToString();
            txtTrangThai.Text = dr.Cells["sTrangThai"].Value.ToString();
            cboKieuPhong.Text = dr.Cells["sTenKP"].Value.ToString();
            cboLoaiPhong.Text = dr.Cells["sTenLP"].Value.ToString();
            txtGio.Text = dr.Cells["fGiaTheoGio"].Value.ToString();
            txtNgay.Text = dr.Cells["fGiaTheoNgay"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
             // Kiểm tra dữ liệu có bị bỏ trống 
             if (txtMaPhong.Text == "" || txtTenPhong.Text == "" || txtTrangThai.Text == "" || cboKieuPhong.Text == "" || cboLoaiPhong.Text == "" || txtGio.Text == "" || txtNgay.Text == "")
             {
                 MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                 return;
             }
             // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
             if (txtMaPhong.Text.Length > 5)
             {
                 MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                 return;
             }
             // Kiểm tra mã nhân viên có bị trùng không
             if (ChinhSuaThongTin_BLL.TimPhongTheoMa(txtMaPhong.Text) != null)
             {
                 MessageBox.Show("Mã phòng đã tồn tại!");
                 return;
             }
            if (ChinhSuaThongTin_BLL.TimPhongTheoTen(txtTenPhong.Text) != null)
             {
                 MessageBox.Show("Tên phòng đã tồn tại!");
                 return;
             }

             ChinhSuaThongTin_DTO p = new ChinhSuaThongTin_DTO();
             p.SMaP = txtMaPhong.Text;
             p.STenP = txtTenPhong.Text;
             p.STrangThai = txtTrangThai.Text;
             p.FGiaTheoGio = float.Parse(txtGio.Text);
             p.FGiaTheoNgay = float.Parse(txtNgay.Text);
             p.SMaKP = cboKieuPhong.SelectedValue.ToString();
             p.SMaLP = cboLoaiPhong.SelectedValue.ToString();
             p.STenKP = cboKieuPhong.Text;
             p.STenLP = cboLoaiPhong.Text;

            if (ChinhSuaThongTin_BLL.ThemP(p) == false)
            {
                MessageBox.Show("Không thêm phòng được.");
                return;
            }
            if(ChinhSuaThongTin_BLL.ThemGP(p) == false)
            {
                MessageBox.Show("Không thêm giá được.");
                return;
            }

            ChinhSuaThongTinPhong_GUI_Load(sender, e);
            MessageBox.Show("Đã thêm phòng mới.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaPhong.Text == "" || ChinhSuaThongTin_BLL.TimPhongTheoMa(txtMaPhong.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn phòng!");
                return;
            }

            ChinhSuaThongTin_DTO p = new ChinhSuaThongTin_DTO();
            p.SMaP = txtMaPhong.Text;
            p.STenP = txtTenPhong.Text;
            p.STrangThai = txtTrangThai.Text;
            p.FGiaTheoGio = float.Parse(txtGio.Text);
            p.FGiaTheoNgay = float.Parse(txtNgay.Text);
            p.SMaKP = cboKieuPhong.SelectedValue.ToString();
            p.SMaLP = cboLoaiPhong.SelectedValue.ToString();
            p.STenKP = cboKieuPhong.Text;
            p.STenLP = cboLoaiPhong.Text;
            if (ChinhSuaThongTin_BLL.XoaP(p) == true)
            {
                ChinhSuaThongTinPhong_GUI_Load(sender, e);
                MessageBox.Show("Đã xóa phòng.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaPhong.Text == "" || ChinhSuaThongTin_BLL.TimPhongTheoMa(txtMaPhong.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn phòng!");
                return;
            }

            ChinhSuaThongTin_DTO p = new ChinhSuaThongTin_DTO();

            p.SMaP = txtMaPhong.Text;
            p.STenP = txtTenPhong.Text;
            p.STrangThai = txtTrangThai.Text;
            p.FGiaTheoGio = float.Parse(txtGio.Text);
            p.FGiaTheoNgay = float.Parse(txtNgay.Text);
            p.SMaKP = cboKieuPhong.SelectedValue.ToString();
            p.SMaLP = cboLoaiPhong.SelectedValue.ToString();
            p.STenKP = cboKieuPhong.Text;
            p.STenLP = cboLoaiPhong.Text;
            if (ChinhSuaThongTin_BLL.SuaP(p) == true)
            {
                ChinhSuaThongTinPhong_GUI_Load(sender, e);
                MessageBox.Show("Đã cập nhật thông tin phòng");
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }
        }

        private void dgvDSPChinhSua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
