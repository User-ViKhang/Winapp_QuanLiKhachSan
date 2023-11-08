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
    public partial class Phong_User : Form
    {
        public Phong_User()
        {
            InitializeComponent();
        }

        private void dgvDSPChinhSua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Phong_User_Load(object sender, EventArgs e)
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
            dgvDSPChinhSua.Columns["sTenKP"].Width = 150;
            dgvDSPChinhSua.Columns["sMaLP"].HeaderText = "Mã loại phòng";
            dgvDSPChinhSua.Columns["sMaLP"].Visible = false;
            dgvDSPChinhSua.Columns["sTenLP"].HeaderText = "Loại phòng";
            dgvDSPChinhSua.Columns["sTenLP"].Width = 160;
            dgvDSPChinhSua.Columns["fGiaTheoGio"].HeaderText = "Giá giờ";
            dgvDSPChinhSua.Columns["fGiaTheoGio"].Width = 100;
            dgvDSPChinhSua.Columns["fGiaTheoNgay"].HeaderText = "Giá ngày";
            dgvDSPChinhSua.Columns["fGiaTheoNgay"].Width = 100;
        }

        private void dgvDSPChinhSua_Click(object sender, EventArgs e)
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn trờ về giao diện không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                GiaoDien_User frm = new GiaoDien_User();
                frm.Show();
                this.Hide();
                this.Visible = false;
            }
        }
    }
}
