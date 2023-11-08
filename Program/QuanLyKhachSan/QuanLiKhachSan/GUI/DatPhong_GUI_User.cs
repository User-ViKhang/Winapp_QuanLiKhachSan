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
    public partial class DatPhong_GUI_User : Form
    {
        public DatPhong_GUI_User()
        {
            InitializeComponent();
        }

        private void DatPhong_GUI_User_Load(object sender, EventArgs e)
        {

        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            if(txtTenKH.Text == "" || txtEmail.Text == "" || txtCMND.Text == "" || txtDiaChi.Text == "" || txtQuocTich.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            Random random = new Random();
            int randomNumber = random.Next(100000);
            while (KhachHang_BLL.TimKhachHangTheoMa(randomNumber.ToString()) != null)
            {
                randomNumber = random.Next(100000);
            }
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.SMaKH = randomNumber.ToString();
            if (rdNam.Checked == true)
            {
                kh.SGioiTinh = "Nam";
            }
            else
            {
                kh.SGioiTinh = "Nữ";
            }
            kh.STenKH = txtTenKH.Text;
            kh.ICMND = int.Parse(txtCMND.Text);
            kh.SDiaChi = txtDiaChi.Text;
            kh.SQuocTich = txtQuocTich.Text;
            kh.ISDT = int.Parse(txtSDT.Text);
            kh.SEmail = txtEmail.Text;
            kh.DNamSinh = DateTime.Parse(dtpNgaySinh.Text);

            if (KhachHang_BLL.ThemKhachHang(kh) == false)
            {
                MessageBox.Show("Không thêm được");
                return;
            }
            DatPhong_Phong_GUI_User frmDPP = new DatPhong_Phong_GUI_User(randomNumber);
            frmDPP.Show();
            this.Hide();
            this.Visible = false;
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
