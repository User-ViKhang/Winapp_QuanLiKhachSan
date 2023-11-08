namespace GUI
{
    partial class DatDichVu_GUI_User
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSDV = new System.Windows.Forms.DataGridView();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnDat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvDSDV = new System.Windows.Forms.ListView();
            this.lvMaDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTenDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đặt dịch vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSDV);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 202);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch vụ";
            // 
            // dgvDSDV
            // 
            this.dgvDSDV.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDV.Location = new System.Drawing.Point(6, 19);
            this.dgvDSDV.Name = "dgvDSDV";
            this.dgvDSDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDV.Size = new System.Drawing.Size(240, 177);
            this.dgvDSDV.TabIndex = 0;
            this.dgvDSDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDV_CellContentClick);
            // 
            // btnThemDV
            // 
            this.btnThemDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemDV.Location = new System.Drawing.Point(528, 91);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(82, 38);
            this.btnThemDV.TabIndex = 5;
            this.btnThemDV.Text = "Thêm ";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnDat
            // 
            this.btnDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDat.Location = new System.Drawing.Point(528, 179);
            this.btnDat.Name = "btnDat";
            this.btnDat.Size = new System.Drawing.Size(82, 38);
            this.btnDat.TabIndex = 6;
            this.btnDat.Text = "Đặt";
            this.btnDat.UseVisualStyleBackColor = true;
            this.btnDat.Click += new System.EventHandler(this.btnDat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvDSDV);
            this.groupBox2.Location = new System.Drawing.Point(270, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 202);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dịch vụ đã chọn";
            // 
            // lvDSDV
            // 
            this.lvDSDV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvMaDV,
            this.lvTenDV,
            this.lvGia});
            this.lvDSDV.FullRowSelect = true;
            this.lvDSDV.HideSelection = false;
            this.lvDSDV.Location = new System.Drawing.Point(6, 19);
            this.lvDSDV.Name = "lvDSDV";
            this.lvDSDV.Size = new System.Drawing.Size(240, 177);
            this.lvDSDV.TabIndex = 0;
            this.lvDSDV.UseCompatibleStateImageBehavior = false;
            this.lvDSDV.View = System.Windows.Forms.View.Details;
            // 
            // lvMaDV
            // 
            this.lvMaDV.Text = "Mã dịch vụ";
            this.lvMaDV.Width = 72;
            // 
            // lvTenDV
            // 
            this.lvTenDV.Text = "Tên dịch vụ";
            this.lvTenDV.Width = 94;
            // 
            // lvGia
            // 
            this.lvGia.Text = "Giá dịch vụ";
            this.lvGia.Width = 85;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(528, 135);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 38);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // DatDichVu_GUI_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 271);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDat);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "DatDichVu_GUI_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt dịch vụ";
            this.Load += new System.EventHandler(this.DatDichVu_GUI_User_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Button btnDat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvDSDV;
        private System.Windows.Forms.ColumnHeader lvMaDV;
        private System.Windows.Forms.ColumnHeader lvTenDV;
        private System.Windows.Forms.ColumnHeader lvGia;
        private System.Windows.Forms.Button btnXoa;
    }
}