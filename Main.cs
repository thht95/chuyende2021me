using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPH
{
    public partial class Main : Form
    {
        public static bool isAdmin = false;
        public static string ten = null;
        public static int nhanvienID = 1;
        QLPHEntities db = new QLPHEntities();

        public Main()
        {
            InitializeComponent();
            dgvPhonghat.AutoGenerateColumns = false;
        }

        private void xinChàoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (ten != null)
            {
                xinChàoToolStripMenuItem.Text = "Xin chào " + ten;
            }

            if (!isAdmin)
            {
                quảnLýNhânViênToolStripMenuItem.Visible = false;
                quảnLýPhòngHátToolStripMenuItem1.Visible = false;
                quảnLýHoáĐơnToolStripMenuItem.Visible = false;
                quảnLýSảnPhẩmToolStripMenuItem.Visible = false;
                quảnLýXuấtNhậpKhoToolStripMenuItem.Visible = false;
            }

            reload();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var timelogin = db.TimeLogins.Where(x => x.NhanvienID == nhanvienID).OrderByDescending(x => x.ID).FirstOrDefault();
            timelogin.LogoutAt = DateTime.Now;
            db.SaveChanges();

            Dangnhap formDn = (Dangnhap) Application.OpenForms["Dangnhap"];
            formDn.Show();
            this.Hide();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }

        private void dgvPhonghat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            if (row > -1)
            {
                if (col == 3)
                {
                    if (!(bool) dgvPhonghat["Trangthai", row].Value)
                    {
                        if ((bool) dgvPhonghat["IsReserved", row].Value)
                        {
                            e.Value = "Đã đặt trước";
                            if (dgvPhonghat["IsReserverdBy", row].Value != null)
                            {
                                int khachhangid = (int)dgvPhonghat["IsReserverdBy", row].Value;
                                KhachHang khachHang = db.KhachHangs.FirstOrDefault(x => x.ID == khachhangid);
                                dgvPhonghat[7, row].Value = "Đặt trước bởi " + khachHang.HoTen + ". SĐT: " + khachHang.SDT;
                                
                            }
                        }
                        else
                        {
                            e.Value = "Đang sử dụng";
                            int phonghatID = (int) dgvPhonghat["ID", row].Value;

                            Hoadon hoadon = db.Hoadons.Where(x => x.PhonghatID == phonghatID).OrderByDescending(x => x.ID).FirstOrDefault();
                            if (hoadon != null)
                            {
                                dgvPhonghat[7, row].Value = "Bắt đầu lúc " + hoadon.ThoigianBatdau;
                                if ((bool)hoadon.LoaiPhong)
                                {
                                    dgvPhonghat["LoaiPhong", row].Value = "Theo giờ";
                                }
                                else
                                {
                                    dgvPhonghat["LoaiPhong", row].Value = "Theo bài hát";
                                }
                            }
                        }
                    }
                    else
                    {
                        e.Value = "Phòng trống";
                    }
                }
            }

        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLKH form = new QLKH();
            form.MdiParent = this;
            form.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var row = dgvPhonghat.CurrentRow.Cells[3];
            if ((bool) row.Value)
            {
                var list = db.KhachHangs.ToList();
                list.Reverse();
                
                cbbKhachhang.DataSource = list;
                cbbKhachhang.DisplayMember = "Hoten";
                cbbKhachhang.ValueMember = "ID";

                cbbKhachhang.Visible = true;
                btnChon.Visible = true;
                label2.Visible = true;
                button1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chọn phòng đang trống để đặt trước", "Thông báo", MessageBoxButtons.OK);
            }
            
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            cbbKhachhang.Visible = false;
            btnChon.Visible = false;
            label2.Visible = false;
            lbLoaiphong.Visible = false;
            cbbLoaiphong.Visible = false;

            int khachhangID = (int)cbbKhachhang.SelectedValue;
            int phongID = (int)dgvPhonghat.CurrentRow.Cells["ID"].Value;

            //Dat truoc
            if (button1.Enabled == false)
            {
                button1.Enabled = true;
                
                Phonghat phonghat = db.Phonghats.FirstOrDefault(x => x.ID == phongID);
                phonghat.IsReserved = true;
                phonghat.IsReserverdBy = khachhangID;
                phonghat.Trangthai = false;

                db.SaveChanges();
                reload();
            }

            //sudung
            if (button2.Enabled == false)
            {
                Hoadon hoadon = new Hoadon();
                hoadon.NhanvienID = nhanvienID;
                hoadon.KhachhangID = khachhangID;
                hoadon.PhonghatID = phongID;
                hoadon.LoaiPhong = Convert.ToBoolean(cbbLoaiphong.SelectedIndex);
                hoadon.ThoigianBatdau = DateTime.Now;

                Phonghat phonghat = db.Phonghats.FirstOrDefault(x => x.ID == phongID);
                phonghat.Trangthai = false;
                phonghat.IsReserved = false;
                phonghat.IsReserverdBy = null;

                db.Hoadons.Add(hoadon);
                db.SaveChanges();
                reload();

                button2.Enabled = true;
            }
        }

        private void btnSudung_Click(object sender, EventArgs e)
        {
            var row = dgvPhonghat.CurrentRow;
            if ((bool) row.Cells[3].Value || ((bool)row.Cells[4].Value && !(bool)row.Cells[3].Value))
            {
                loadKH();

                cbbKhachhang.Visible = true;
                btnChon.Visible = true;
                label2.Visible = true;
                lbLoaiphong.Visible = true;
                cbbLoaiphong.Visible = true;
                button2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chọn phòng đang trống để sử dụng", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void reload()
        {
            dgvPhonghat.DataSource = db.Phonghats.ToList();
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            int phonghatID = (int)dgvPhonghat.CurrentRow.Cells["ID"].Value;
            Hoadon hoadon = db.Hoadons.Where(x => x.PhonghatID == phonghatID).OrderByDescending(x => x.ID).FirstOrDefault();
            Phonghat phonghat = db.Phonghats.FirstOrDefault(x => x.ID == phonghatID);

            showGroupThanhtoan(true);

            //thanh toán
            double tienphong = 0;
            if ((bool) hoadon.LoaiPhong)
            {
                var hours = (DateTime.Now - hoadon.ThoigianBatdau).Value.TotalHours;
                tienphong = (double) phonghat.Dongia * hours;
                txtTienphong.Text = Convert.ToInt32((Math.Round(tienphong/1000)*1000)).ToString();
            }
        }

        private void loadKH()
        {
            var list = db.KhachHangs.ToList();
            list.Reverse();

            cbbKhachhang.DataSource = list;
            cbbKhachhang.DisplayMember = "Hoten";
            cbbKhachhang.ValueMember = "ID";
        }

        private void loadMonan()
        {
            cbbProduct.DataSource = db.Products.ToList(); ;
            cbbProduct.DisplayMember = "TenHang";
            cbbProduct.ValueMember = "ID";
        }

        private void btnGoimon_Click(object sender, EventArgs e)
        {
            var row = dgvPhonghat.CurrentRow.Cells[3];
            if (!(bool) row.Value)
            {
                loadMonan();
                showGroupOrder(true);
            }
            else
            {
                MessageBox.Show("Chọn phòng đang sử dụng để gọi món", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void showGroupOrder(bool show)
        {
            label3.Visible = show;
            label4.Visible = show;
            cbbProduct.Visible = show;
            txtSoluong.Visible = show;
            btnXacnhanOrder.Visible = show;
        }

        private void showGroupThanhtoan(bool show)
        {
            lbTienPhong.Visible = show;
            txtTienphong.Visible = show;
            btnXacnhanThanhtoan.Visible = show;
        }
        

        private void btnXacnhanOrder_Click(object sender, EventArgs e)
        {
            showGroupOrder(false);
            int phonghatID = (int)dgvPhonghat.CurrentRow.Cells["ID"].Value;
            Hoadon hoadon = db.Hoadons.Where(x => x.PhonghatID == phonghatID).OrderByDescending(x => x.ID).FirstOrDefault();

            ChitietHoadon chitietHoadon = new ChitietHoadon();
            chitietHoadon.HoadonID = hoadon.ID;
            chitietHoadon.ProductID = (int) cbbProduct.SelectedValue;
            chitietHoadon.Soluong = Convert.ToInt32(txtSoluong.Text);

            db.ChitietHoadons.Add(chitietHoadon);
            db.SaveChanges();

            MessageBox.Show("Thêm món thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnXacnhanThanhtoan_Click(object sender, EventArgs e)
        {
            int phonghatID = (int)dgvPhonghat.CurrentRow.Cells["ID"].Value;
            Hoadon hoadon = db.Hoadons.Where(x => x.PhonghatID == phonghatID).OrderByDescending(x => x.ID).FirstOrDefault();
            Phonghat phonghat = db.Phonghats.FirstOrDefault(x => x.ID == phonghatID);

            var tienphong = Convert.ToInt32(txtTienphong.Text);
            hoadon.Tienphong = tienphong;

            var tiendoan = 0;
            foreach (var cthd in hoadon.ChitietHoadons)
            {
                var soluong = cthd.Soluong;
                var dongia = cthd.Product.Dongia;
                var sotienphaitra = Convert.ToInt32(soluong * dongia);
                tiendoan += sotienphaitra;
            }
            hoadon.Thanhtien = tiendoan + tienphong;

            phonghat.IsReserved = false;
            phonghat.Trangthai = true;

            showGroupThanhtoan(false);

            db.SaveChanges();
            reload();

            reportHoadonThanhtoan.hoadonID = hoadon.ID;
            reportHoadonThanhtoan rp = new reportHoadonThanhtoan();
            rp.Show();
        }

        private void quảnLýPhòngHátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QLPhonghat qLPhonghat = new QLPhonghat();
            qLPhonghat.MdiParent = this;
            qLPhonghat.Show();
        }

        private void quảnLýHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHD qlhoadon = new QLHD();
            qlhoadon.MdiParent = this;
            qlhoadon.Show();
        }

        private void quảnLýXuấtNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XNK xnk = new XNK();
            xnk.MdiParent = this;
            xnk.Show();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLSP qlsp = new QLSP();
            qlsp.MdiParent = this;
            qlsp.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNV qlnv = new QLNV();
            qlnv.MdiParent = this;
            qlnv.Show();
        }
    }
}
