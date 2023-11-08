namespace GUI
{
    partial class DatPhong_Phong_GUI_User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.txtSoGio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTraTruoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHuyDatPhong = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTimPhong = new System.Windows.Forms.DataGridView();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboKP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPhongTrong = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPhongDaDat = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPhongTrong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPhong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimPhong)).BeginInit();
            this.tabPhongTrong.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongDaDat)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPhong);
            this.tabControl1.Controls.Add(this.tabPhongTrong);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(469, 330);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPhong
            // 
            this.tabPhong.BackColor = System.Drawing.Color.White;
            this.tabPhong.Controls.Add(this.txtSoGio);
            this.tabPhong.Controls.Add(this.label7);
            this.tabPhong.Controls.Add(this.txtTraTruoc);
            this.tabPhong.Controls.Add(this.label6);
            this.tabPhong.Controls.Add(this.dtpNgayDi);
            this.tabPhong.Controls.Add(this.label5);
            this.tabPhong.Controls.Add(this.dtpNgayDen);
            this.tabPhong.Controls.Add(this.label4);
            this.tabPhong.Controls.Add(this.btnHuyDatPhong);
            this.tabPhong.Controls.Add(this.btnDatPhong);
            this.tabPhong.Controls.Add(this.btnTim);
            this.tabPhong.Controls.Add(this.groupBox1);
            this.tabPhong.Controls.Add(this.cboLoaiPhong);
            this.tabPhong.Controls.Add(this.label3);
            this.tabPhong.Controls.Add(this.cboKP);
            this.tabPhong.Controls.Add(this.label2);
            this.tabPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPhong.Location = new System.Drawing.Point(4, 25);
            this.tabPhong.Name = "tabPhong";
            this.tabPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhong.Size = new System.Drawing.Size(461, 301);
            this.tabPhong.TabIndex = 0;
            this.tabPhong.Text = "Tìm phòng";
            // 
            // txtSoGio
            // 
            this.txtSoGio.Location = new System.Drawing.Point(89, 182);
            this.txtSoGio.Name = "txtSoGio";
            this.txtSoGio.Size = new System.Drawing.Size(155, 26);
            this.txtSoGio.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(36, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số giờ:";
            // 
            // txtTraTruoc
            // 
            this.txtTraTruoc.Location = new System.Drawing.Point(89, 150);
            this.txtTraTruoc.Name = "txtTraTruoc";
            this.txtTraTruoc.Size = new System.Drawing.Size(155, 26);
            this.txtTraTruoc.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(20, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Trả trước:";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDi.Location = new System.Drawing.Point(89, 119);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(155, 26);
            this.dtpNgayDi.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(31, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày đi: ";
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDen.Location = new System.Drawing.Point(89, 87);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(155, 26);
            this.dtpNgayDen.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(17, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày đến: ";
            // 
            // btnHuyDatPhong
            // 
            this.btnHuyDatPhong.Location = new System.Drawing.Point(13, 255);
            this.btnHuyDatPhong.Name = "btnHuyDatPhong";
            this.btnHuyDatPhong.Size = new System.Drawing.Size(231, 35);
            this.btnHuyDatPhong.TabIndex = 7;
            this.btnHuyDatPhong.Text = "Hủy đặt phòng";
            this.btnHuyDatPhong.UseVisualStyleBackColor = true;
            this.btnHuyDatPhong.Click += new System.EventHandler(this.btnHuyDatPhong_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Location = new System.Drawing.Point(128, 214);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(116, 35);
            this.btnDatPhong.TabIndex = 6;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(13, 214);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(109, 35);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTimPhong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(250, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 281);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả tìm kiếm";
            // 
            // dgvTimPhong
            // 
            this.dgvTimPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimPhong.Location = new System.Drawing.Point(6, 20);
            this.dgvTimPhong.Name = "dgvTimPhong";
            this.dgvTimPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimPhong.Size = new System.Drawing.Size(187, 255);
            this.dgvTimPhong.TabIndex = 0;
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Location = new System.Drawing.Point(89, 52);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(155, 28);
            this.cboLoaiPhong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(7, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại phòng:";
            // 
            // cboKP
            // 
            this.cboKP.FormattingEnabled = true;
            this.cboKP.Location = new System.Drawing.Point(89, 18);
            this.cboKP.Name = "cboKP";
            this.cboKP.Size = new System.Drawing.Size(155, 28);
            this.cboKP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kiểu phòng:";
            // 
            // tabPhongTrong
            // 
            this.tabPhongTrong.Controls.Add(this.groupBox3);
            this.tabPhongTrong.Controls.Add(this.groupBox2);
            this.tabPhongTrong.Location = new System.Drawing.Point(4, 25);
            this.tabPhongTrong.Name = "tabPhongTrong";
            this.tabPhongTrong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhongTrong.Size = new System.Drawing.Size(461, 301);
            this.tabPhongTrong.TabIndex = 1;
            this.tabPhongTrong.Text = "Trạng thái";
            this.tabPhongTrong.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPhongDaDat);
            this.groupBox3.Location = new System.Drawing.Point(235, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 289);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phòng đã đặt";
            // 
            // dgvPhongDaDat
            // 
            this.dgvPhongDaDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongDaDat.Location = new System.Drawing.Point(6, 21);
            this.dgvPhongDaDat.Name = "dgvPhongDaDat";
            this.dgvPhongDaDat.Size = new System.Drawing.Size(214, 262);
            this.dgvPhongDaDat.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPhongTrong);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phòng trống";
            // 
            // dgvPhongTrong
            // 
            this.dgvPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongTrong.Location = new System.Drawing.Point(6, 21);
            this.dgvPhongTrong.Name = "dgvPhongTrong";
            this.dgvPhongTrong.Size = new System.Drawing.Size(214, 262);
            this.dgvPhongTrong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đặt phòng";
            // 
            // DatPhong_Phong_GUI_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "DatPhong_Phong_GUI_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.DatPhong_Phong_GUI_User_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPhong.ResumeLayout(false);
            this.tabPhong.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimPhong)).EndInit();
            this.tabPhongTrong.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongDaDat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPhong;
        private System.Windows.Forms.TabPage tabPhongTrong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTimPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboKP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnHuyDatPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.DataGridView dgvPhongTrong;
        private System.Windows.Forms.TextBox txtTraTruoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoGio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPhongDaDat;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}