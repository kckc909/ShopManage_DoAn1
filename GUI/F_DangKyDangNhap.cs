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
        private static F_DangKyDangNhap instance;

        private F_DangKyDangNhap()
        {
            InitializeComponent();
        }

        public static F_DangKyDangNhap Instance()
        {
            if (instance == null)
            {
                instance = new F_DangKyDangNhap();
            }
            return instance;
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
                f_DangKy.BringToFront();

                lbDangKyDangNhap.Text = "Đăng nhập";
            }
            else
            {
                f_DangNhap.Show();
                f_DangNhap.BringToFront();

                lbDangKyDangNhap.Text = "Đăng ký";
            }
        }

        private void F_DangKyDangNhap_Load(object sender, EventArgs e)
        {
            pnContainer.Controls.Add(f_DangKy);
            pnContainer.Controls.Add(f_DangNhap);

            f_DangNhap.Show();
            lbDangKyDangNhap.Text = "Đăng ký";

            f_DangNhap.DangNhapThanhCong += AnFormDangNhapDangKy;
        }

        void AnFormDangNhapDangKy(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
