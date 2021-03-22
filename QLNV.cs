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
    public partial class QLNV : Form
    {
        public QLPHEntities db = new QLPHEntities();
        public QLNV()
        {
            InitializeComponent();
            dgv.AutoGenerateColumns = false;
            reload();
        }

        private void reload()
        {
            db.SaveChanges();
            dgv.DataSource = db.NhanViens.ToList();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            Screen scr = Screen.FromPoint(this.Location);
            this.Location = new Point(scr.WorkingArea.Right - this.Width, scr.WorkingArea.Top);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.HoTen = txtHoten.Text;
            nhanvien.Password = txtPassword.Text;
            nhanvien.Username = txtUsername.Text;
            nhanvien.SDT = txtSDT.Text;
            nhanvien.Diachi = txtDiachi.Text;
            nhanvien.DOB = dtp.Value.Date;
            nhanvien.Trangthai = ckbTrangthai.Checked;
            nhanvien.IsAdmin = ckbAdmin.Checked;

            db.NhanViens.Add(nhanvien);
            reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var row = dgv.CurrentRow;
            int id = (int)row.Cells[0].Value;
            var nhanvien = db.NhanViens.FirstOrDefault(x => x.ID == id);
            nhanvien.HoTen = txtHoten.Text;
            nhanvien.Password = txtPassword.Text;
            nhanvien.Username = txtUsername.Text;
            nhanvien.SDT = txtSDT.Text;
            nhanvien.Diachi = txtDiachi.Text;
            nhanvien.DOB = dtp.Value.Date;
            nhanvien.Trangthai = ckbTrangthai.Checked;
            nhanvien.IsAdmin = ckbAdmin.Checked;

            reload();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtHoten.Text = dgv[1, e.RowIndex].Value.ToString();
                txtPassword.Text = dgv[2, e.RowIndex].Value.ToString();
                txtUsername.Text = dgv[3, e.RowIndex].Value.ToString(); 
                txtSDT.Text = dgv[4, e.RowIndex].Value.ToString();
                txtDiachi.Text = dgv[5, e.RowIndex].Value.ToString();
                dtp.Value = Convert.ToDateTime(dgv[6, e.RowIndex].Value);
                ckbTrangthai.Checked = (bool) dgv[7, e.RowIndex].Value;
                ckbAdmin.Checked = (bool) dgv[8, e.RowIndex].Value;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var row = dgv.CurrentRow;
            int id = (int)row.Cells[0].Value;
            var nhanvien = db.NhanViens.FirstOrDefault(x => x.ID == id);
            if (nhanvien.Hoadons.Count > 0 || nhanvien.LichsuXuatNhapkhoes.Count > 0 || nhanvien.TimeLogins.Count > 0)
            {
                MessageBox.Show("Không thể xoá", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                db.NhanViens.Remove(nhanvien);
                reload();
            }
        }
    }
}
