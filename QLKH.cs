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
    public partial class QLKH : Form
    {
        QLPHEntities db = new QLPHEntities();
        public QLKH()
        {
            InitializeComponent();
            dgvKhachhang.AutoGenerateColumns = false;
            reload();
        }

        private void QLKH_Load(object sender, EventArgs e)
        {
            Screen scr = Screen.FromPoint(this.Location);
            this.Location = new Point(scr.WorkingArea.Right - this.Width, scr.WorkingArea.Top);

            if (!Main.isAdmin)
            {
                button3.Hide();
            }
        }

        private void reload()
        {
            db.SaveChanges();
            dgvKhachhang.DataSource = db.KhachHangs.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang khachhang = new KhachHang();
            khachhang.HoTen = txtHoten.Text;
            khachhang.SDT = txtSDT.Text;

            db.KhachHangs.Add(khachhang);
            reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var row = dgvKhachhang.CurrentRow;
            int khachhangid = (int) row.Cells[0].Value;
            var khachhang = db.KhachHangs.FirstOrDefault(x => x.ID == khachhangid);
            khachhang.SDT = txtSDT.Text;
            khachhang.HoTen = txtHoten.Text;

            reload();
        }

        private void dgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var row = dgvKhachhang.CurrentRow;
            int id = (int) row.Cells[0].Value;
            var khachhang = db.KhachHangs.FirstOrDefault(x => x.ID == id);
            if (khachhang.Hoadons.Count > 0 || khachhang.Phonghats.Count > 0)
            {
                MessageBox.Show("Không thể xoá vì khách đã đặt phòng hoặc có hoá đơn", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                db.KhachHangs.Remove(khachhang);
                reload();
            }

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimkiem.Text))
            {
                reload();

            }
            else
            {
                string timkiem = txtTimkiem.Text;
                var result = db.KhachHangs.Where(x => x.HoTen.Contains(timkiem) || x.SDT.Contains(timkiem)).ToList();
                dgvKhachhang.DataSource = result;
            }
            
        }

        private void dgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtHoten.Text = dgvKhachhang[1, e.RowIndex].Value.ToString();
                txtSDT.Text = dgvKhachhang[2, e.RowIndex].Value.ToString();
            }
        }
    }
}
