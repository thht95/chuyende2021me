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
    public partial class QLHD : Form
    {
        public QLPHEntities db = new QLPHEntities();

        public QLHD()
        {
            InitializeComponent();
            dgv.AutoGenerateColumns = false;
            reload();
        }

        private void QLHD_Load(object sender, EventArgs e)
        {
            Screen scr = Screen.FromPoint(this.Location);
            this.Location = new Point(scr.WorkingArea.Right - this.Width, scr.WorkingArea.Top);
        }

        private void reload()
        {
            loadCbb();
            db.SaveChanges();
            dgv.DataSource = db.Hoadons.ToList();
            
        }

        private void loadCbb()
        {
            cbbNhanvien.DataSource = db.NhanViens.ToList();
            cbbNhanvien.DisplayMember = "Hoten";
            cbbNhanvien.ValueMember = "ID";

            cbbKhachhang.DataSource = db.KhachHangs.ToList();
            cbbKhachhang.DisplayMember = "Hoten";
            cbbKhachhang.ValueMember = "ID";

            cbbPhonghat.DataSource = db.Phonghats.ToList();
            cbbPhonghat.DisplayMember = "TenPhong";
            cbbPhonghat.ValueMember = "ID";
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                cbbNhanvien.SelectedValue = dgv[1, e.RowIndex].Value;
                cbbKhachhang.SelectedValue = dgv[2, e.RowIndex].Value;
                cbbPhonghat.SelectedValue = dgv[3, e.RowIndex].Value;
                cbbLoaiphong.SelectedIndex = Convert.ToInt32(dgv[4, e.RowIndex].Value);
                txtTienphong.Text = dgv[5, e.RowIndex].Value == null ? "" : dgv[5, e.RowIndex].Value.ToString();
                dtp.Value = Convert.ToDateTime(dgv[6, e.RowIndex].Value);
                txtThanhtien.Text = dgv[7, e.RowIndex].Value == null ? "" : dgv[7, e.RowIndex].Value.ToString();
            }
        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            var row = dgv.CurrentRow;
            int id = (int)row.Cells[0].Value;
            var hoadon = db.Hoadons.FirstOrDefault(x => x.ID == id);

            if (hoadon.ChitietHoadons.Count == 0)
            {
                MessageBox.Show("Không có chi tiết hoá đơn", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                reportHoadonThanhtoan.hoadonID = id;
                reportHoadonThanhtoan rp = new reportHoadonThanhtoan();
                rp.Show();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var row = dgv.CurrentRow;
            int id = (int)row.Cells[0].Value;
            var hoadon = db.Hoadons.FirstOrDefault(x => x.ID == id);

            hoadon.Tienphong = Convert.ToInt32(txtTienphong.Text);
            hoadon.Thanhtien = Convert.ToInt32(txtThanhtien.Text);

            reload();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var row = dgv.CurrentRow;
            int id = (int)row.Cells[0].Value;
            var hoadon = db.Hoadons.FirstOrDefault(x => x.ID == id);

            if (hoadon.ChitietHoadons.Count > 0)
            {
                db.ChitietHoadons.RemoveRange(hoadon.ChitietHoadons);
            }

            db.Hoadons.Remove(hoadon);

            reload();
        }
    }
}
