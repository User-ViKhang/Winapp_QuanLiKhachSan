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
    public partial class XuatHoaDon_GUI : Form
    {
        public string trMaHD;
        public XuatHoaDon_GUI()
        {
            InitializeComponent();
        }

        public XuatHoaDon_GUI(string trMaHD)
        {
            InitializeComponent();
            this.trMaHD = trMaHD;
        }

        private void XuatHoaDon_GUI_Load(object sender, EventArgs e)
        {
            List<XuatHoaDon_DTO> lstNV = XuatHoaDon_BLL.LayDS(trMaHD);
            dataGridView2.DataSource = lstNV;

            DataGridViewRow dr = dataGridView2.CurrentRow;
            txtHD.Text = dr.Cells["smahd"].Value.ToString();
            txtMaKH.Text = dr.Cells["smakh"].Value.ToString();
            txtTenKH.Text = dr.Cells["stenkh"].Value.ToString();
            txtNgayThanhToan.Text = dr.Cells["dngaythanhtoan"].Value.ToString();
            txtTenKP.Text = dr.Cells["stenkp"].Value.ToString();
            txtMaP.Text = dr.Cells["stenp"].Value.ToString();
            txtTenLP.Text = dr.Cells["stenLP"].Value.ToString();
            txtSoH.Text = dr.Cells["isogio"].Value.ToString();
            txtSoD.Text = dr.Cells["isongay"].Value.ToString();
            txtDonGiaH.Text = dr.Cells["fGiaTheoGio"].Value.ToString();
            txtDonGiaD.Text = dr.Cells["fGiaTheoNgay"].Value.ToString();
            txtThue.Text = dr.Cells["fVAT"].Value.ToString();
            txtTienP.Text = dr.Cells["fTienPhaiTra"].Value.ToString();
            txtTraTruoc.Text = dr.Cells["ftratruoc"].Value.ToString();
            txtNhanVien.Text = dr.Cells["stennv"].Value.ToString();

            float tienPThue = 0;

             tienPThue += float.Parse(txtTienP.Text) + float.Parse(txtTienP.Text) * float.Parse(txtThue.Text);
             txtTienPThue.Text = tienPThue.ToString();

            List<DanhSachDichVu_DTO> lstDV = DanhSachDichVu_BLL.LayDSDV(txtHD.Text);
            dataGridView1.DataSource = lstDV;
            dataGridView1.Columns["smadv"].Visible = false;
            dataGridView1.Columns["sTendv"].HeaderText = "Tên dịch vụ";
            dataGridView1.Columns["sTendv"].Width = 100;
            dataGridView1.Columns["fgiadv"].HeaderText = "Giá";
            dataGridView1.Columns["fgiadv"].Width = 150;
            float tongDV = 0;
            for(int i = 0; i < lstDV.Count; i++)
            {
                tongDV += float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());

            }
           txtTienDV.Text = tongDV.ToString();
            float tongTien = (tongDV + tienPThue) - float.Parse(txtTraTruoc.Text);
            txtTong.Text = tongTien.ToString();
        }

        private void txtNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HoaDon_GUI frmHD = new HoaDon_GUI();
            frmHD.Show();
            this.Visible = false;
            this.Hide();
        }
    }
}
