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
    public partial class LoaiPhong_GUI_User : Form
    {
        public LoaiPhong_GUI_User()
        {
            InitializeComponent();
        }

        private void LoaiPhong_GUI_User_Load(object sender, EventArgs e)
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

        private void dgvDSLP_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDSLP.SelectedRows[0];
            txtMaLP.Text = dr.Cells["sMaLP"].Value.ToString();
            txtTenLP.Text = dr.Cells["sTenLP"].Value.ToString();
            txtMoTa.Text = dr.Cells["sMoTa"].Value.ToString();
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
