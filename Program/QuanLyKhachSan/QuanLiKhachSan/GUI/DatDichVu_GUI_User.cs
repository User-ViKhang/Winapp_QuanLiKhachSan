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
    public partial class DatDichVu_GUI_User : Form
    {
        int maPDK;
        public DatDichVu_GUI_User()
        {
            InitializeComponent();
        }
        public DatDichVu_GUI_User(int maPDK)
        {
            InitializeComponent();
            this.maPDK = maPDK;
        }

        private string selectedMaDV;
        private string selectedTenDV;
        private string selectedGia;
        private void DatDichVu_GUI_User_Load(object sender, EventArgs e)
        {
            List<DanhSachDichVu_DTO> lstDV = DanhSachDichVu_BLL.LayDV();
            dgvDSDV.DataSource = lstDV;
            dgvDSDV.Columns["sMaDV"].HeaderText = "Mã";
            dgvDSDV.Columns["sMaDV"].Width = 50;
            dgvDSDV.Columns["sTenDV"].HeaderText = "Tên dịch vụ";
            dgvDSDV.Columns["sTenDV"].Width = 220;
            dgvDSDV.Columns["fgiadv"].HeaderText = "Giá";
            dgvDSDV.Columns["fgiadv"].Width = 100;
        }

        private void dgvDSDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo chỉ xử lý khi chọn một hàng hợp lệ
            {
                DataGridViewRow row = dgvDSDV.Rows[e.RowIndex];
                selectedMaDV = row.Cells["sMaDV"].Value.ToString();
                selectedTenDV = row.Cells["sTenDv"].Value.ToString(); 
                selectedGia = row.Cells["fGiadv"].Value.ToString(); 
            }
            else
            {
                MessageBox.Show("Hãy chọn dịch vụ");
            }
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedMaDV) && !string.IsNullOrEmpty(selectedTenDV) && !string.IsNullOrEmpty(selectedGia))
            {
                ListViewItem item = new ListViewItem(selectedMaDV);
                item.SubItems.Add(selectedTenDV);
                item.SubItems.Add(selectedGia);
                lvDSDV.Items.Add(item);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDSDV.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvDSDV.SelectedItems[0];
                lvDSDV.Items.Remove(selectedItem);
            }
        }

        private void btnDat_Click(object sender, EventArgs e)
        {
            for(int i=0; i<lvDSDV.Items.Count; i++)
            {
                PhieuDangKiDichVu_DTO dv = new PhieuDangKiDichVu_DTO();
                dv.SMaDV = lvDSDV.Items[i].Text;
                dv.SMaPDK = maPDK.ToString();

                if (PhieuDangKiDichVu_BLL.ThemPDK(dv, maPDK.ToString()) == false)
                {
                    MessageBox.Show("Không thêm được.");
                    return;
                }
            }

            MessageBox.Show("Đã đặt phòng");
            GiaoDien_User frm = new GiaoDien_User();
            frm.Show();
            this.Hide();
            this.Visible = false;
        }
    }
}
