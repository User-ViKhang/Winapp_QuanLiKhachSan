using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BLL;

namespace GUI
{
    public partial class frm_bcNhanVien : Form
    {
        public frm_bcNhanVien()
        {
            InitializeComponent();
        }

        private void frm_bcNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.rp_NhanVien.rdlc";
                ReportDataSource rpDataSource = new ReportDataSource();
                rpDataSource.Name = "NhanVien_Dataset";
                rpDataSource.Value = rp_NhanVien_BLL.getNhanVien();
                reportViewer1.LocalReport.DataSources.Add(rpDataSource);
                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            GiaoDienChinh frm = new GiaoDienChinh();
            frm.Show();
            this.Hide();
            this.Visible = false;
        }
    }
}
