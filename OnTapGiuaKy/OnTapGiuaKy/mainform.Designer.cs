namespace OnTapGiuaKy
{
    partial class MainForm
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clbChuyenNganh = new System.Windows.Forms.CheckedListBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.txbSoDT = new System.Windows.Forms.TextBox();
            this.txbLop = new System.Windows.Forms.TextBox();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txbCMND = new System.Windows.Forms.TextBox();
            this.txbHoLot = new System.Windows.Forms.TextBox();
            this.txbMSSV = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(677, 299);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 23);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(796, 299);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 23);
            this.btnThoat.TabIndex = 50;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(566, 299);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(94, 23);
            this.btnCapNhat.TabIndex = 49;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThemSV
            // 
            this.btnThemSV.Location = new System.Drawing.Point(447, 299);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(94, 23);
            this.btnThemSV.TabIndex = 48;
            this.btnThemSV.Text = "Thêm Mới";
            this.btnThemSV.UseVisualStyleBackColor = true;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvSinhVien);
            this.groupBox1.Location = new System.Drawing.Point(0, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 283);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Sinh Viên";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(6, 21);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(900, 262);
            this.lvSinhVien.TabIndex = 0;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "MSSV";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Họ Lót";
            this.columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Tên";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Giới Tính";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Ngày Sinh";
            this.columnHeader14.Width = 90;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Lớp";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "CMND";
            this.columnHeader16.Width = 80;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Số ĐT";
            this.columnHeader17.Width = 80;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Địa Chỉ";
            this.columnHeader18.Width = 200;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Môn Học";
            this.columnHeader19.Width = 300;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(330, 299);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 23);
            this.btnTimKiem.TabIndex = 46;
            this.btnTimKiem.Text = " Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "Môn học đăng ký:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "Địa chỉ liên lạc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Số ĐT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Lớp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Giới Tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Số CMND:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ngày Sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Họ Và Tên Lót:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "MSSV:";
            // 
            // clbChuyenNganh
            // 
            this.clbChuyenNganh.FormattingEnabled = true;
            this.clbChuyenNganh.Items.AddRange(new object[] {
            "Mạng Máy Tính",
            "Hệ Điều Hành",
            "Lập Trình CSDL",
            "Lập Trình Mạng",
            "Đồ Án Cơ Sở",
            "Phương Pháp NCKH",
            "Lập Trình Trên Thiết Bị Di Động",
            "An Toàn Và Bảo Mật Hệ Thống"});
            this.clbChuyenNganh.Location = new System.Drawing.Point(135, 204);
            this.clbChuyenNganh.MultiColumn = true;
            this.clbChuyenNganh.Name = "clbChuyenNganh";
            this.clbChuyenNganh.Size = new System.Drawing.Size(367, 89);
            this.clbChuyenNganh.TabIndex = 35;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(126, 167);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(734, 22);
            this.txbDiaChi.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdNu);
            this.panel1.Controls.Add(this.rdNam);
            this.panel1.Location = new System.Drawing.Point(625, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 29);
            this.panel1.TabIndex = 33;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(113, 3);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(47, 21);
            this.rdNu.TabIndex = 1;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(16, 3);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(58, 21);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // txbSoDT
            // 
            this.txbSoDT.Location = new System.Drawing.Point(625, 129);
            this.txbSoDT.Name = "txbSoDT";
            this.txbSoDT.Size = new System.Drawing.Size(235, 22);
            this.txbSoDT.TabIndex = 32;
            // 
            // txbLop
            // 
            this.txbLop.Location = new System.Drawing.Point(625, 92);
            this.txbLop.Name = "txbLop";
            this.txbLop.Size = new System.Drawing.Size(235, 22);
            this.txbLop.TabIndex = 31;
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(625, 54);
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(235, 22);
            this.txbTen.TabIndex = 30;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(126, 87);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(235, 22);
            this.dtpNgaySinh.TabIndex = 28;
            // 
            // txbCMND
            // 
            this.txbCMND.Location = new System.Drawing.Point(126, 129);
            this.txbCMND.Name = "txbCMND";
            this.txbCMND.Size = new System.Drawing.Size(235, 22);
            this.txbCMND.TabIndex = 29;
            // 
            // txbHoLot
            // 
            this.txbHoLot.Location = new System.Drawing.Point(126, 49);
            this.txbHoLot.Name = "txbHoLot";
            this.txbHoLot.Size = new System.Drawing.Size(235, 22);
            this.txbHoLot.TabIndex = 27;
            // 
            // txbMSSV
            // 
            this.txbMSSV.Location = new System.Drawing.Point(126, 10);
            this.txbMSSV.Name = "txbMSSV";
            this.txbMSSV.Size = new System.Drawing.Size(235, 22);
            this.txbMSSV.TabIndex = 26;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(215, 299);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 23);
            this.btnLoad.TabIndex = 52;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 620);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbChuyenNganh);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbSoDT);
            this.Controls.Add(this.txbLop);
            this.Controls.Add(this.txbTen);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txbCMND);
            this.Controls.Add(this.txbHoLot);
            this.Controls.Add(this.txbMSSV);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbChuyenNganh;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.TextBox txbSoDT;
        private System.Windows.Forms.TextBox txbLop;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txbCMND;
        private System.Windows.Forms.TextBox txbHoLot;
        private System.Windows.Forms.TextBox txbMSSV;
        private System.Windows.Forms.Button btnLoad;
    }
}

