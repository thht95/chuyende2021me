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
    public partial class QLSP : Form
    {
        public QLPHEntities db = new QLPHEntities();
        public QLSP()
        {
            InitializeComponent();
            dgv.AutoGenerateColumns = false;
            reload();
        }

        private void QLSP_Load(object sender, EventArgs e)
        {
            Screen scr = Screen.FromPoint(this.Location);
            this.Location = new Point(scr.WorkingArea.Right - this.Width, scr.WorkingArea.Top);
        }
        private void reload()
        {
            db.SaveChanges();
            dgv.DataSource = db.Products.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Product sp = new Product();
            sp.TenHang = txtTenHang.Text;
            sp.SoLuong = Convert.ToInt32(txtSoluong.Text);
            sp.Donvi = txtDonvi.Text;
            sp.Dongia = Convert.ToInt32(txtDongia.Text);

            db.Products.Add(sp);

            reload();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var row = dgv.CurrentRow;
            int id = (int)row.Cells[0].Value;
            var sp = db.Products.FirstOrDefault(x => x.ID == id);

            sp.TenHang = txtTenHang.Text;
            sp.SoLuong = Convert.ToInt32(txtSoluong.Text);
            sp.Donvi = txtDonvi.Text;
            sp.Dongia = Convert.ToInt32(txtDongia.Text);

            reload();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var row = dgv.CurrentRow;
            int id = (int)row.Cells[0].Value;
            var sp = db.Products.FirstOrDefault(x => x.ID == id);

            if (sp.LichsuXuatNhapkhoes.Count > 0)
                MessageBox.Show("Không thể xoá", "Thông báo", MessageBoxButtons.OK);
            else
                db.Products.Remove(sp);

            reload();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtTenHang.Text = dgv[1, e.RowIndex].Value.ToString();
                txtSoluong.Text = dgv[2, e.RowIndex].Value.ToString();
                txtDonvi.Text = dgv[3, e.RowIndex].Value.ToString();
                txtDongia.Text = dgv[4, e.RowIndex].Value.ToString();
            }
        }
    }
}
