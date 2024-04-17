using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_DangKyDangNhap : Form
    {
        public F_DangKyDangNhap()
        {
            InitializeComponent();
        }

        F_DangKy f_DangKy = new F_DangKy() { TopLevel = false };
        F_DangNhap f_DangNhap = new F_DangNhap() { TopLevel = false };
        private void lbDangKyDangNhap_MouseEnter(object sender, EventArgs e)
        {
            lbDangKyDangNhap.Font = new Font(lbDangKyDangNhap.Font, FontStyle.Underline);
        }

        private void lbDangKyDangNhap_MouseLeave(object sender, EventArgs e)
        {
            lbDangKyDangNhap.Font = new Font(lbDangKyDangNhap.Font, FontStyle.Regular);
        }

        private void lbDangKyDangNhap_Click(object sender, EventArgs e)
        {
            if (lbDangKyDangNhap.Text == "Đăng ký")
            {
                f_DangKy.Show();
                f_DangNhap.Hide();

                lbDangKyDangNhap.Text = "Đăng nhập";
            }
            else
            {
                f_DangNhap.Show();
                f_DangKy.Hide();

                lbDangKyDangNhap.Text = "Đăng ký";
            }
        }

        private void F_DangKyDangNhap_Load(object sender, EventArgs e)
        {
            pnContainer.Controls.Add(f_DangKy);
            pnContainer.Controls.Add(f_DangNhap);

            f_DangNhap.Show();
            lbDangKyDangNhap.Text = "Đăng ký";
        }

    }
}
