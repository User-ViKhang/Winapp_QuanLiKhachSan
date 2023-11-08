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
    public partial class DichVu_GUI_User : Form
    {
        public DichVu_GUI_User()
        {
            InitializeComponent();
        }

        private void DichVu_GUI_User_Load(object sender, EventArgs e)
        {
            List<DanhSachDichVu_DTO> lstDV = DanhSachDichVu_BLL.LayDV();
            dgvDSDichVu.DataSource = lstDV;
            dgvDSDichVu.Columns["sMaDV"].HeaderText = "Mã";
            dgvDSDichVu.Columns["sMaDV"].Width = 50;
            dgvDSDichVu.Columns["sTenDV"].HeaderText = "Tên dịch vụ";
            dgvDSDichVu.Columns["sTenDV"].Width = 220;
            dgvDSDichVu.Columns["fgiadv"].HeaderText = "Giá";
            dgvDSDichVu.Columns["fgiadv"].Width = 100;
        }

        private void dgvDSDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void dgvDSDichVu_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDSDichVu.SelectedRows[0];
            txtMaDV.Text = dr.Cells["sMaDV"].Value.ToString();
            txtTenDichVu.Text = dr.Cells["sTenDV"].Value.ToString();
            txtGia.Text = dr.Cells["fgiadv"].Value.ToString();
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
