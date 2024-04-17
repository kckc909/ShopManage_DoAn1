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
    public partial class F_DangNhap : Form
    {
        public F_DangNhap()
        {
            InitializeComponent();
        }

        BUS.DangNhap BUS_DangNhap = new BUS.DangNhap();

        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\n')
            {
                txtMatKhau.PasswordChar = '*';
            }
            else
            {
                txtMatKhau.PasswordChar = '\n';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (BUS_DangNhap.KiemTraRong(txtTenTaiKhoan.Text, txtMatKhau.Text))
            {
                if (BUS_DangNhap.KiemTraTaiKhoanMatKhau(txtTenTaiKhoan.Text, txtMatKhau.Text))
                {
                    // Login successfull
                }
                else
                {
                    // sai ten tai khoan hoac mat khau
                }
            }
            else
            {
                // sai ten tai khoan hoac mat khau
            }
        }
    }
}
