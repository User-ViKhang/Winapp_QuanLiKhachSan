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
    public partial class KieuPhong_GUI_User : Form
    {
        public KieuPhong_GUI_User()
        {
            InitializeComponent();
        }

        private void KieuPhong_GUI_User_Load(object sender, EventArgs e)
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

        private void dgvDSKP_Click(object sender, EventArgs e)
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
                GiaoDien_User frm = new GiaoDien_User();
                frm.Show();
                this.Hide();
                this.Visible = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
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
