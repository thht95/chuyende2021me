namespace QLPH
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xinChàoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngHátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngHátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýXuấtNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPhonghat = new System.Windows.Forms.DataGridView();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sizee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isReserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsReserverdBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsReserverdByy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbbKhachhang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.lbLoaiphong = new System.Windows.Forms.Label();
            this.cbbLoaiphong = new System.Windows.Forms.ComboBox();
            this.btnGoimon = new System.Windows.Forms.Button();
            this.cbbProduct = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXacnhanOrder = new System.Windows.Forms.Button();
            this.btnXacnhanThanhtoan = new System.Windows.Forms.Button();
            this.txtTienphong = new System.Windows.Forms.TextBox();
            this.lbTienPhong = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhonghat)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xinChàoToolStripMenuItem,
            this.quảnLýPhòngHátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xinChàoToolStripMenuItem
            // 
            this.xinChàoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.xinChàoToolStripMenuItem.Name = "xinChàoToolStripMenuItem";
            this.xinChàoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.xinChàoToolStripMenuItem.Text = "Xin chào";
            this.xinChàoToolStripMenuItem.Click += new System.EventHandler(this.xinChàoToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLýPhòngHátToolStripMenuItem
            // 
            this.quảnLýPhòngHátToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKháchHàngToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýPhòngHátToolStripMenuItem1,
            this.quảnLýHoáĐơnToolStripMenuItem,
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýXuấtNhậpKhoToolStripMenuItem});
            this.quảnLýPhòngHátToolStripMenuItem.Name = "quảnLýPhòngHátToolStripMenuItem";
            this.quảnLýPhòngHátToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýPhòngHátToolStripMenuItem.Text = "Quản lý";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            this.quảnLýKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýPhòngHátToolStripMenuItem1
            // 
            this.quảnLýPhòngHátToolStripMenuItem1.Name = "quảnLýPhòngHátToolStripMenuItem1";
            this.quảnLýPhòngHátToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.quảnLýPhòngHátToolStripMenuItem1.Text = "Quản lý phòng hát";
            this.quảnLýPhòngHátToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýPhòngHátToolStripMenuItem1_Click);
            // 
            // quảnLýHoáĐơnToolStripMenuItem
            // 
            this.quảnLýHoáĐơnToolStripMenuItem.Name = "quảnLýHoáĐơnToolStripMenuItem";
            this.quảnLýHoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.quảnLýHoáĐơnToolStripMenuItem.Text = "Quản lý hoá đơn";
            this.quảnLýHoáĐơnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHoáĐơnToolStripMenuItem_Click);
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            this.quảnLýSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // quảnLýXuấtNhậpKhoToolStripMenuItem
            // 
            this.quảnLýXuấtNhậpKhoToolStripMenuItem.Name = "quảnLýXuấtNhậpKhoToolStripMenuItem";
            this.quảnLýXuấtNhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.quảnLýXuấtNhậpKhoToolStripMenuItem.Text = "Quản lý xuất nhập kho";
            this.quảnLýXuấtNhậpKhoToolStripMenuItem.Click += new System.EventHandler(this.quảnLýXuấtNhậpKhoToolStripMenuItem_Click);
            // 
            // dgvPhonghat
            // 
            this.dgvPhonghat.AllowUserToAddRows = false;
            this.dgvPhonghat.AllowUserToDeleteRows = false;
            this.dgvPhonghat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhonghat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPhong,
            this.Dongia,
            this.Sizee,
            this.Trangthai,
            this.isReserved,
            this.IsReserverdBy,
            this.LoaiPhong,
            this.IsReserverdByy,
            this.ID});
            this.dgvPhonghat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhonghat.Location = new System.Drawing.Point(0, 497);
            this.dgvPhonghat.Name = "dgvPhonghat";
            this.dgvPhonghat.ReadOnly = true;
            this.dgvPhonghat.Size = new System.Drawing.Size(939, 309);
            this.dgvPhonghat.TabIndex = 2;
            this.dgvPhonghat.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPhonghat_CellFormatting);
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên phòng";
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            // 
            // Dongia
            // 
            this.Dongia.DataPropertyName = "Dongia";
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.Name = "Dongia";
            this.Dongia.ReadOnly = true;
            // 
            // Sizee
            // 
            this.Sizee.DataPropertyName = "Size";
            this.Sizee.HeaderText = "Số người";
            this.Sizee.Name = "Sizee";
            this.Sizee.ReadOnly = true;
            // 
            // Trangthai
            // 
            this.Trangthai.DataPropertyName = "Trangthai";
            this.Trangthai.HeaderText = "Trạng thái";
            this.Trangthai.Name = "Trangthai";
            this.Trangthai.ReadOnly = true;
            // 
            // isReserved
            // 
            this.isReserved.DataPropertyName = "IsReserved";
            this.isReserved.HeaderText = "isReserved";
            this.isReserved.Name = "isReserved";
            this.isReserved.ReadOnly = true;
            this.isReserved.Visible = false;
            // 
            // IsReserverdBy
            // 
            this.IsReserverdBy.DataPropertyName = "IsReserverdBy";
            this.IsReserverdBy.HeaderText = "IsReservedBy";
            this.IsReserverdBy.Name = "IsReserverdBy";
            this.IsReserverdBy.ReadOnly = true;
            this.IsReserverdBy.Visible = false;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.HeaderText = "Loại phòng";
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.ReadOnly = true;
            // 
            // IsReserverdByy
            // 
            this.IsReserverdByy.HeaderText = "Ghi chú";
            this.IsReserverdByy.Name = "IsReserverdByy";
            this.IsReserverdByy.ReadOnly = true;
            this.IsReserverdByy.Width = 300;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(939, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH SÁCH PHÒNG HÁT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đặt trước";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 58);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sử dụng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSudung_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(549, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 58);
            this.button3.TabIndex = 7;
            this.button3.Text = "Thanh toán";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // cbbKhachhang
            // 
            this.cbbKhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhachhang.FormattingEnabled = true;
            this.cbbKhachhang.Location = new System.Drawing.Point(42, 260);
            this.cbbKhachhang.Name = "cbbKhachhang";
            this.cbbKhachhang.Size = new System.Drawing.Size(130, 21);
            this.cbbKhachhang.TabIndex = 8;
            this.cbbKhachhang.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chọn khách hàng";
            this.label2.Visible = false;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(211, 229);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 78);
            this.btnChon.TabIndex = 10;
            this.btnChon.Text = "Xác nhận";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Visible = false;
            this.btnChon.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // lbLoaiphong
            // 
            this.lbLoaiphong.AutoSize = true;
            this.lbLoaiphong.Location = new System.Drawing.Point(42, 305);
            this.lbLoaiphong.Name = "lbLoaiphong";
            this.lbLoaiphong.Size = new System.Drawing.Size(84, 13);
            this.lbLoaiphong.TabIndex = 12;
            this.lbLoaiphong.Text = "Chọn loại phòng";
            this.lbLoaiphong.Visible = false;
            // 
            // cbbLoaiphong
            // 
            this.cbbLoaiphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiphong.FormattingEnabled = true;
            this.cbbLoaiphong.Items.AddRange(new object[] {
            "Theo bài hát",
            "Theo giờ"});
            this.cbbLoaiphong.Location = new System.Drawing.Point(42, 332);
            this.cbbLoaiphong.Name = "cbbLoaiphong";
            this.cbbLoaiphong.Size = new System.Drawing.Size(130, 21);
            this.cbbLoaiphong.TabIndex = 13;
            this.cbbLoaiphong.Visible = false;
            // 
            // btnGoimon
            // 
            this.btnGoimon.Location = new System.Drawing.Point(377, 119);
            this.btnGoimon.Name = "btnGoimon";
            this.btnGoimon.Size = new System.Drawing.Size(75, 58);
            this.btnGoimon.TabIndex = 15;
            this.btnGoimon.Text = "Gọi món";
            this.btnGoimon.UseVisualStyleBackColor = true;
            this.btnGoimon.Click += new System.EventHandler(this.btnGoimon_Click);
            // 
            // cbbProduct
            // 
            this.cbbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProduct.FormattingEnabled = true;
            this.cbbProduct.Location = new System.Drawing.Point(377, 255);
            this.cbbProduct.Name = "cbbProduct";
            this.cbbProduct.Size = new System.Drawing.Size(121, 21);
            this.cbbProduct.TabIndex = 16;
            this.cbbProduct.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Chọn món";
            this.label3.Visible = false;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(377, 332);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(26, 20);
            this.txtSoluong.TabIndex = 18;
            this.txtSoluong.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số lượng";
            this.label4.Visible = false;
            // 
            // btnXacnhanOrder
            // 
            this.btnXacnhanOrder.Location = new System.Drawing.Point(549, 229);
            this.btnXacnhanOrder.Name = "btnXacnhanOrder";
            this.btnXacnhanOrder.Size = new System.Drawing.Size(75, 78);
            this.btnXacnhanOrder.TabIndex = 20;
            this.btnXacnhanOrder.Text = "Xác nhận";
            this.btnXacnhanOrder.UseVisualStyleBackColor = true;
            this.btnXacnhanOrder.Visible = false;
            this.btnXacnhanOrder.Click += new System.EventHandler(this.btnXacnhanOrder_Click);
            // 
            // btnXacnhanThanhtoan
            // 
            this.btnXacnhanThanhtoan.Location = new System.Drawing.Point(549, 234);
            this.btnXacnhanThanhtoan.Name = "btnXacnhanThanhtoan";
            this.btnXacnhanThanhtoan.Size = new System.Drawing.Size(75, 78);
            this.btnXacnhanThanhtoan.TabIndex = 21;
            this.btnXacnhanThanhtoan.Text = "Xác nhận";
            this.btnXacnhanThanhtoan.UseVisualStyleBackColor = true;
            this.btnXacnhanThanhtoan.Visible = false;
            this.btnXacnhanThanhtoan.Click += new System.EventHandler(this.btnXacnhanThanhtoan_Click);
            // 
            // txtTienphong
            // 
            this.txtTienphong.Location = new System.Drawing.Point(374, 267);
            this.txtTienphong.Name = "txtTienphong";
            this.txtTienphong.Size = new System.Drawing.Size(84, 20);
            this.txtTienphong.TabIndex = 22;
            this.txtTienphong.Visible = false;
            // 
            // lbTienPhong
            // 
            this.lbTienPhong.AutoSize = true;
            this.lbTienPhong.Location = new System.Drawing.Point(374, 242);
            this.lbTienPhong.Name = "lbTienPhong";
            this.lbTienPhong.Size = new System.Drawing.Size(86, 13);
            this.lbTienPhong.TabIndex = 23;
            this.lbTienPhong.Text = "Nhập tiền phòng";
            this.lbTienPhong.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 806);
            this.Controls.Add(this.lbTienPhong);
            this.Controls.Add(this.txtTienphong);
            this.Controls.Add(this.btnXacnhanThanhtoan);
            this.Controls.Add(this.btnXacnhanOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbProduct);
            this.Controls.Add(this.btnGoimon);
            this.Controls.Add(this.cbbLoaiphong);
            this.Controls.Add(this.lbLoaiphong);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbKhachhang);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPhonghat);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhonghat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xinChàoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngHátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngHátToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgvPhonghat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbbKhachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Label lbLoaiphong;
        private System.Windows.Forms.ComboBox cbbLoaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sizee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn isReserved;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsReserverdBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsReserverdByy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button btnGoimon;
        private System.Windows.Forms.ComboBox cbbProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXacnhanOrder;
        private System.Windows.Forms.Button btnXacnhanThanhtoan;
        private System.Windows.Forms.TextBox txtTienphong;
        private System.Windows.Forms.Label lbTienPhong;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHoáĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýXuấtNhậpKhoToolStripMenuItem;
    }
}