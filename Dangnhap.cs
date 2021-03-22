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
    public partial class Dangnhap : Form
    {
        QLPHEntities db = new QLPHEntities();
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            NhanVien nhanvien = db.NhanViens.Where(x => x.Username == username && x.Password == password && x.Trangthai == true).FirstOrDefault();

            if (nhanvien != null)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                Main form = new Main();
                Main.isAdmin = (bool) nhanvien.IsAdmin;
                Main.ten = nhanvien.HoTen;
                Main.nhanvienID = nhanvien.ID;

                TimeLogin timeLogin = new TimeLogin();
                timeLogin.LoginAt = DateTime.Now;
                timeLogin.NhanvienID = nhanvien.ID;
                db.TimeLogins.Add(timeLogin);
                db.SaveChanges();

                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
