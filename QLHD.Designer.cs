namespace QLPH
{
    partial class QLHD
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanvienID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachhangID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhonghatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tienphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thoigianbatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbNhanvien = new System.Windows.Forms.ComboBox();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.cbbKhachhang = new System.Windows.Forms.ComboBox();
            this.cbbPhonghat = new System.Windows.Forms.ComboBox();
            this.cbbLoaiphong = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtTienphong = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChitiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NhanvienID,
            this.KhachhangID,
            this.PhonghatID,
            this.LoaiPhong,
            this.Tienphong,
            this.Thoigianbatdau,
            this.Thanhtien});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 331);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(951, 165);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NhanvienID
            // 
            this.NhanvienID.DataPropertyName = "NhanvienID";
            this.NhanvienID.HeaderText = "NhanvienID";
            this.NhanvienID.Name = "NhanvienID";
            this.NhanvienID.ReadOnly = true;
            // 
            // KhachhangID
            // 
            this.KhachhangID.DataPropertyName = "KhachhangID";
            this.KhachhangID.HeaderText = "KhachhangID";
            this.KhachhangID.Name = "KhachhangID";
            this.KhachhangID.ReadOnly = true;
            // 
            // PhonghatID
            // 
            this.PhonghatID.DataPropertyName = "PhonghatID";
            this.PhonghatID.HeaderText = "PhonghatID";
            this.PhonghatID.Name = "PhonghatID";
            this.PhonghatID.ReadOnly = true;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại phòng";
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.ReadOnly = true;
            // 
            // Tienphong
            // 
            this.Tienphong.DataPropertyName = "Tienphong";
            this.Tienphong.HeaderText = "Tiền phòng";
            this.Tienphong.Name = "Tienphong";
            this.Tienphong.ReadOnly = true;
            // 
            // Thoigianbatdau
            // 
            this.Thoigianbatdau.DataPropertyName = "Thoigianbatdau";
            this.Thoigianbatdau.HeaderText = "Thời gian bắt đầu";
            this.Thoigianbatdau.Name = "Thoigianbatdau";
            this.Thoigianbatdau.ReadOnly = true;
            this.Thoigianbatdau.Width = 150;
            // 
            // Thanhtien
            // 
            this.Thanhtien.DataPropertyName = "Thanhtien";
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(951, 66);
            this.label4.TabIndex = 8;
            this.label4.Text = "DANH SÁCH HOÁ ĐƠN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phòng hát";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Loại phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Thời gian bắt đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tiền phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Thành tiền";
            // 
            // cbbNhanvien
            // 
            this.cbbNhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNhanvien.Enabled = false;
            this.cbbNhanvien.FormattingEnabled = true;
            this.cbbNhanvien.Location = new System.Drawing.Point(185, 58);
            this.cbbNhanvien.Name = "cbbNhanvien";
            this.cbbNhanvien.Size = new System.Drawing.Size(121, 21);
            this.cbbNhanvien.TabIndex = 16;
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(185, 256);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(100, 20);
            this.txtThanhtien.TabIndex = 17;
            // 
            // cbbKhachhang
            // 
            this.cbbKhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhachhang.Enabled = false;
            this.cbbKhachhang.FormattingEnabled = true;
            this.cbbKhachhang.Location = new System.Drawing.Point(185, 94);
            this.cbbKhachhang.Name = "cbbKhachhang";
            this.cbbKhachhang.Size = new System.Drawing.Size(121, 21);
            this.cbbKhachhang.TabIndex = 18;
            // 
            // cbbPhonghat
            // 
            this.cbbPhonghat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhonghat.Enabled = false;
            this.cbbPhonghat.FormattingEnabled = true;
            this.cbbPhonghat.Location = new System.Drawing.Point(185, 127);
            this.cbbPhonghat.Name = "cbbPhonghat";
            this.cbbPhonghat.Size = new System.Drawing.Size(121, 21);
            this.cbbPhonghat.TabIndex = 19;
            // 
            // cbbLoaiphong
            // 
            this.cbbLoaiphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiphong.Enabled = false;
            this.cbbLoaiphong.FormattingEnabled = true;
            this.cbbLoaiphong.Items.AddRange(new object[] {
            "Theo bài hát",
            "Theo giờ"});
            this.cbbLoaiphong.Location = new System.Drawing.Point(185, 157);
            this.cbbLoaiphong.Name = "cbbLoaiphong";
            this.cbbLoaiphong.Size = new System.Drawing.Size(121, 21);
            this.cbbLoaiphong.TabIndex = 20;
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtp.Enabled = false;
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(185, 187);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(140, 20);
            this.dtp.TabIndex = 21;
            // 
            // txtTienphong
            // 
            this.txtTienphong.Location = new System.Drawing.Point(185, 223);
            this.txtTienphong.Name = "txtTienphong";
            this.txtTienphong.Size = new System.Drawing.Size(100, 20);
            this.txtTienphong.TabIndex = 22;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(594, 108);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 57);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(753, 108);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 57);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChitiet
            // 
            this.btnChitiet.Location = new System.Drawing.Point(450, 108);
            this.btnChitiet.Name = "btnChitiet";
            this.btnChitiet.Size = new System.Drawing.Size(75, 57);
            this.btnChitiet.TabIndex = 25;
            this.btnChitiet.Text = "Xem chi tiết";
            this.btnChitiet.UseVisualStyleBackColor = true;
            this.btnChitiet.Click += new System.EventHandler(this.btnChitiet_Click);
            // 
            // QLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 496);
            this.Controls.Add(this.btnChitiet);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtTienphong);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cbbLoaiphong);
            this.Controls.Add(this.cbbPhonghat);
            this.Controls.Add(this.cbbKhachhang);
            this.Controls.Add(this.txtThanhtien);
            this.Controls.Add(this.cbbNhanvien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv);
            this.Name = "QLHD";
            this.Text = "QLHD";
            this.Load += new System.EventHandler(this.QLHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbNhanvien;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.ComboBox cbbKhachhang;
        private System.Windows.Forms.ComboBox cbbPhonghat;
        private System.Windows.Forms.ComboBox cbbLoaiphong;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtTienphong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChitiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanvienID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachhangID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhonghatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tienphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoigianbatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
    }
}