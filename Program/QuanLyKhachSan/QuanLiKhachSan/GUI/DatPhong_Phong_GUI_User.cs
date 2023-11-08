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
    public partial class DatPhong_Phong_GUI_User : Form
    {
        int maKH;
        public DatPhong_Phong_GUI_User()
        {
            InitializeComponent();
        }
        public DatPhong_Phong_GUI_User(int maKH)
        {
            InitializeComponent();
            this.maKH = maKH;
        }

        private void DatPhong_Phong_GUI_User_Load(object sender, EventArgs e)
        {
            List<TrangThaiPhong_DTO> lstDS = TrangThaiPhong_BLL.LayPT();
            dgvPhongTrong.DataSource = lstDS;
            dgvPhongTrong.Columns["sMap"].Visible = false;
            dgvPhongTrong.Columns["stenp"].HeaderText = "Phòng";
            dgvPhongTrong.Columns["stenp"].Width = 70;
            dgvPhongTrong.Columns["strangthai"].HeaderText = "Trạng thái";
            dgvPhongTrong.Columns["strangthai"].Width = 100;
            
            List<TrangThaiPhong_DTO> lstDSK  = TrangThaiPhong_BLL.LayPK();
            dgvPhongDaDat.DataSource = lstDSK;
            dgvPhongDaDat.Columns["sMap"].Visible = false;
            dgvPhongDaDat.Columns["stenp"].HeaderText = "Phòng";
            dgvPhongDaDat.Columns["stenp"].Width = 70;
            dgvPhongDaDat.Columns["strangthai"].HeaderText = "Trạng thái";
            dgvPhongDaDat.Columns["strangthai"].Width = 100;

            List<KieuPhong_DTO> lstKP = KieuPhong_BLL.LayKP();
            cboKP.DataSource = lstKP;
            cboKP.DisplayMember = "stenkp";
            cboKP.ValueMember = "smakp";

            List<LoaiPhong_DTO> lstLP = LoaiPhong_BLL.LayLP();
            cboLoaiPhong.DataSource = lstLP;
            cboLoaiPhong.DisplayMember = "stenlp";
            cboLoaiPhong.ValueMember = "smalp";
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(100000);
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtSoGio.Text == "" || txtTraTruoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            while (PhieuDangKi_BLL.TimPDKTheoMa(randomNumber.ToString())!= null)
            {
                randomNumber = random.Next(100000);
            }

            string oMaPhong;
            if (dgvTimPhong.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTimPhong.SelectedRows[0];
                oMaPhong = selectedRow.Cells[0].Value.ToString();

                PhieuDangKiNguyenBan_DTO pdk = new PhieuDangKiNguyenBan_DTO();
                pdk.SMaPhieu = randomNumber.ToString();
                pdk.DNgayDen = DateTime.Parse(dtpNgayDen.Text);
                pdk.DNgayDi = DateTime.Parse(dtpNgayDi.Text);
                pdk.ISoPhong = selectedRow.Cells["stenp"].Value.ToString();
                pdk.FTraTruoc = float.Parse(txtTraTruoc.Text);
                pdk.SMaKhach = maKH.ToString();
                pdk.SMaNhanVien = "ZK809";
                pdk.ISoGio = int.Parse(txtSoGio.Text);

                if (PhieuDangKi_BLL.ThemPDK(pdk, oMaPhong) == false)
                {
                    MessageBox.Show("Không thêm được.");
                    return;
                }

                DatPhong_Phong_GUI_User_Load(sender, e);
                DatDichVu_GUI_User frmDatDV = new DatDichVu_GUI_User(randomNumber);
                frmDatDV.Show();
                this.Hide();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng");
            }

            //string oMaPhong = dgvTimPhong.Rows[0].Cells[0].Value.ToString();


        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                List<ChinhSuaThongTin_DTO> lstDS = TrangThaiPhong_BLL.TimPhong(cboKP.SelectedValue.ToString(), cboLoaiPhong.SelectedValue.ToString());
                dgvTimPhong.DataSource = lstDS;

                dgvTimPhong.Columns["sMap"].Visible = false;
                dgvTimPhong.Columns["sTenp"].HeaderText = "Phòng";
                dgvTimPhong.Columns["sTenp"].Width = 80;
                dgvTimPhong.Columns["sTrangThai"].Visible = false;
                dgvTimPhong.Columns["sMaKP"].Visible=false;
                dgvTimPhong.Columns["sTenKP"].Visible=false;
                dgvTimPhong.Columns["sMaLP"].Visible = false;
                dgvTimPhong.Columns["sTenLP"].Visible=false;
                dgvTimPhong.Columns["fGiaTheoGio"].HeaderText = "Giá giờ";
                dgvTimPhong.Columns["fGiaTheoGio"].Width = 100;
                dgvTimPhong.Columns["fGiaTheoNgay"].HeaderText = "Giá ngày";
                dgvTimPhong.Columns["fGiaTheoNgay"].Width = 100;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Phòng không tồn tại");
            }
        }

        private void btnHuyDatPhong_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có hủy đặt phòng không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                GiaoDien_User frmGD = new GiaoDien_User();
                frmGD.Show();
                this.Visible = false;
                this.Hide();
            }
                
        }
    }
}
