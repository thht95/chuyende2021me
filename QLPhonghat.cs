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
    public partial class QLPhonghat : Form
    {
        public QLPHEntities db = new QLPHEntities();
        public QLPhonghat()
        {
            InitializeComponent();
            dgv.AutoGenerateColumns = false;
            reload();
        }

        private void QLPhonghat_Load(object sender, EventArgs e)
        {
            Screen scr = Screen.FromPoint(this.Location);
            this.Location = new Point(scr.WorkingArea.Right - this.Width, scr.WorkingArea.Top);
        }

        private void reload()
        {
            db.SaveChanges();
            dgv.DataSource = db.Phonghats.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phonghat phonghat = new Phonghat();
            phonghat.TenPhong = txtTenphong.Text;
            phonghat.Size = Convert.ToInt32(txtSonguoi.Text);
            phonghat.Dongia = Convert.ToInt32(txtDongia.Text);

            db.Phonghats.Add(phonghat);
            reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var row = dgv.CurrentRow;
            int id = (int)row.Cells[0].Value;
            var phonghat = db.Phonghats.FirstOrDefault(x => x.ID == id);
            phonghat.TenPhong = txtTenphong.Text;
            phonghat.Size = Convert.ToInt32(txtSonguoi.Text);
            phonghat.Dongia = Convert.ToInt32(txtDongia.Text);

            reload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var row = dgv.CurrentRow;
            int id = (int) row.Cells[0].Value;
            var phonghat = db.Phonghats.FirstOrDefault(x => x.ID == id);
            if (phonghat.Hoadons.Count > 0)
            {
                MessageBox.Show("Không thể xoá", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                db.Phonghats.Remove(phonghat);
                reload();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtTenphong.Text = dgv[1, e.RowIndex].Value.ToString();
                txtSonguoi.Text = dgv[2, e.RowIndex].Value.ToString();
                txtDongia.Text = dgv[3, e.RowIndex].Value.ToString();
            }
        }
    }
}
