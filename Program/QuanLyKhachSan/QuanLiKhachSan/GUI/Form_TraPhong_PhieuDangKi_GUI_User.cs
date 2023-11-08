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
    public partial class Form_TraPhong_PhieuDangKi_GUI_User : Form
    {
        string oMaPDK;
        DateTime ngayDen;
        DateTime ngayDi;
        string sophong;
        int thoiGianO;
        float giaDV = 0;
        float giaH, giaD;
        float TraTruocTienP;
        int maPTT;

        public Form_TraPhong_PhieuDangKi_GUI_User()
        {
            InitializeComponent();
        }        

        private void Form_TraPhong_PhieuDangKi_GUI_User_Load(object sender, EventArgs e)
        {
            
            List<Class_TraPhong_PhieuDangKi_User_DTO> lstPDK = Class_TraPhong_PhieuDangKi_User_BLL.LayPDK();
            if(lstPDK != null)
            {
                dgvThanhToan.DataSource = lstPDK;
                dgvThanhToan.Columns["smapdk"].HeaderText = "Mã phiếu";
                dgvThanhToan.Columns["smapdk"].Width = 80;
                dgvThanhToan.Columns["stenkh"].HeaderText = "Khách hàng";
                dgvThanhToan.Columns["stenkh"].Width = 120;
                dgvThanhToan.Columns["sSoP"].HeaderText = "Phòng";
                dgvThanhToan.Columns["sSoP"].Width = 50;
                dgvThanhToan.Columns["dngayden"].HeaderText = "Nhận";
                dgvThanhToan.Columns["dngayden"].Width = 70;
                dgvThanhToan.Columns["dngaydi"].HeaderText = "Trả";
                dgvThanhToan.Columns["dngaydi"].Width = 70;
                dgvThanhToan.Columns["iSoGio"].HeaderText = "Giờ";
                dgvThanhToan.Columns["iSoGio"].Width = 40;
                dgvThanhToan.Columns["fTraTruoc"].HeaderText = "Trả trước";
                dgvThanhToan.Columns["fTraTruoc"].Width = 80;
                dgvThanhToan.Columns["sMaP"].Visible = false;
                dgvThanhToan.Columns["sMaKH"].Visible = false;
                dgvThanhToan.Columns["sMaNV"].Visible = false;
            }
            else
            {
                return;
            }

            
        }

        private void layOMaPDK()
        {
            if (dgvThanhToan.SelectedCells.Count > 0)
            {
                // Lấy ô đầu tiên đã chọn
                DataGridViewCell selectedCell = dgvThanhToan.SelectedCells[0];
                DataGridViewCell oNgayDen = dgvThanhToan.SelectedCells[3];
                DataGridViewCell oNgayDi = dgvThanhToan.SelectedCells[4];
                DataGridViewCell phong = dgvThanhToan.SelectedCells[2];
                DataGridViewCell gioO = dgvThanhToan.SelectedCells[5];
                DataGridViewCell traTruocTienPhong = dgvThanhToan.SelectedCells[6];
                // Kiểm tra xem ô có giá trị không
                if (selectedCell.Value != null)
                {
                    // Lấy giá trị của ô đã chọn
                    oMaPDK = selectedCell.Value.ToString();
                    sophong = phong.Value.ToString();
                    TraTruocTienP = float.Parse(traTruocTienPhong.Value.ToString());
                    thoiGianO = int.Parse(gioO.Value.ToString());
                    ngayDen = DateTime.Parse(oNgayDen.Value.ToString());
                    ngayDi = DateTime.Parse(oNgayDi.Value.ToString());
                }
            }
        }
        private void loadDataDV()
        {
            List<DanhSachDichVu_DTO> lstDV = Class_TraPhong_PhieuDangKi_User_BLL.layDV_PDK(oMaPDK);
            dataGridView1.DataSource = lstDV;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                giaDV += float.Parse(row.Cells[2].Value.ToString());
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            layOMaPDK();
            int den = ngayDen.Day;
            int di = ngayDi.Day;
            loadDataDV();

            Random random = new Random();
            maPTT = random.Next(100000);

            Class_PhieuThanhToan_User_DTO ptt = new Class_PhieuThanhToan_User_DTO();
            ptt.SMaPTT = maPTT.ToString();
            ptt.ISoNgay = (di - den).ToString();
            DateTime today = DateTime.Today;
            ptt.DNgayThanhToan = today;
            ptt.ISoGio = thoiGianO;
            List<ChinhSuaThongTin_DTO> lstGP = ChinhSuaThongTin_BLL.LayDSGP(sophong);
            dataGridView2.DataSource = lstGP;
            if (dataGridView2.Rows.Count > 0)
            {
                DataGridViewCell cellH = dataGridView2.Rows[0].Cells[7];
                DataGridViewCell cellD = dataGridView2.Rows[0].Cells[8];
                if (cellH.Value != null)
                {
                    giaH = float.Parse(cellH.Value.ToString());
                    giaD = float.Parse(cellD.Value.ToString());
                }
            }
            ptt.FTongTien = float.Parse((di - den).ToString())*giaD + float.Parse(thoiGianO.ToString())*giaH;
            if ((di - den) == 0)
            {
                ptt.FVAT = 0;
            }
            else
            {
                ptt.FVAT = 10;
            }
            ptt.SMaPDK = oMaPDK;
            ptt.SMaNV = "ZK809";
            float giaPhongChuaThue = (float.Parse((di - den).ToString()) * giaD + float.Parse(thoiGianO.ToString()) * giaH);
            if (ptt.FVAT == 0)
            {
                ptt.FTienPhaiTra = (giaPhongChuaThue + giaDV) - TraTruocTienP;
            }
            else
            {
                ptt.FTienPhaiTra = (giaPhongChuaThue + giaPhongChuaThue/100 + giaDV) - TraTruocTienP;

            }
            if (Class_PhieuThanhToan_User_BLL.ThemHD(ptt) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            Form_TraPhong_PhieuDangKi_GUI_User_Load(sender, e);
            MessageBox.Show("Done!");
            XuatHoaDon_GUI frmXuat = new XuatHoaDon_GUI(maPTT.ToString());
            frmXuat.Show();
            this.Visible = false;
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
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

        private void dgvThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
