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
    public partial class XNK : Form
    {
        public QLPHEntities db = new QLPHEntities();
        public XNK()
        {
            InitializeComponent();
            dgv.AutoGenerateColumns = false;
            reload();
        }

        private void XNK_Load(object sender, EventArgs e)
        {
            Screen scr = Screen.FromPoint(this.Location);
            this.Location = new Point(scr.WorkingArea.Right - this.Width, scr.WorkingArea.Top);
        }

        private void reload()
        {
            loadCbb();
            db.SaveChanges();
            dgv.DataSource = db.LichsuXuatNhapkhoes.ToList();
        }

        private void loadCbb()
        {
            cbbNhanvien.DataSource = db.NhanViens.ToList();
            cbbNhanvien.DisplayMember = "Hoten";
            cbbNhanvien.ValueMember = "ID";

            cbbSanpham.DataSource = db.Products.ToList();
            cbbSanpham.DisplayMember = "TenHang";
            cbbSanpham.ValueMember = "ID";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LichsuXuatNhapkho xnk = new LichsuXuatNhapkho();
            xnk.NhanvienID = Main.nhanvienID;
            xnk.ProductID = Convert.ToInt32(cbbSanpham.SelectedValue);
            xnk.Ghichu = txtGhichu.Text;
            xnk.Thoigian = DateTime.Now;
            xnk.SoLuong = Convert.ToInt32(txtSoluong.Text);
            if (cbbType.SelectedIndex == 0)
            {
                xnk.SoLuong = -xnk.SoLuong;
            }

            var product = db.Products.FirstOrDefault(x => x.ID == xnk.ProductID);
            if (product != null)
                product.SoLuong += xnk.SoLuong;

            db.LichsuXuatNhapkhoes.Add(xnk);

            reload();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var row = dgv.CurrentRow;
            int id = (int)row.Cells[0].Value;
            var xnk = db.LichsuXuatNhapkhoes.FirstOrDefault(x => x.ID == id);

            xnk.ProductID = Convert.ToInt32(cbbSanpham.SelectedValue);
            xnk.Ghichu = txtGhichu.Text;
            xnk.SoLuong = Convert.ToInt32(txtSoluong.Text);
            if (cbbType.SelectedIndex == 0)
            {
                xnk.SoLuong = -xnk.SoLuong;
            }

            reload();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                cbbNhanvien.SelectedValue = dgv[1, e.RowIndex].Value;
                cbbSanpham.SelectedValue = dgv[2, e.RowIndex].Value;
                txtSoluong.Text = dgv[3, e.RowIndex].Value == null ? "" : Math.Abs(Convert.ToInt32(dgv[3, e.RowIndex].Value)).ToString();
                dtp.Value = Convert.ToDateTime(dgv[4, e.RowIndex].Value);
                txtGhichu.Text = dgv[5, e.RowIndex].Value == null ? "" : dgv[5, e.RowIndex].Value.ToString();
                cbbType.SelectedIndex = dgv[3, e.RowIndex].Value == null ? 0 : Convert.ToInt32(dgv[3, e.RowIndex].Value) > 0 ? 1 : 0;
            }
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = e.RowIndex;
                var col = e.ColumnIndex;
                if (col == 2)
                {
                    var productId = Convert.ToInt32(dgv[col, row].Value);
                    e.Value = db.Products.FirstOrDefault(x => x.ID == productId).TenHang;
                }
                if (col == 6)
                {
                    if (Convert.ToInt32(dgv[3, row].Value) > 0)
                        e.Value = "Nhập kho";
                    else
                        e.Value = "Xuất kho";
                }
                if (col == 3)
                {
                    if (e.Value != null)
                        e.Value = Math.Abs((int)e.Value);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var row = dgv.CurrentRow;
            int id = (int)row.Cells[0].Value;
            var xnk = db.LichsuXuatNhapkhoes.FirstOrDefault(x => x.ID == id);

            db.LichsuXuatNhapkhoes.Remove(xnk);

            reload();
        }
    }
}
