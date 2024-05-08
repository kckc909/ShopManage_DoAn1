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
    public partial class F_DangKy : Form
    {
        public F_DangKy()
        {
            InitializeComponent();
        }
        BUS.BUS_DangKy BUS_DangKy = new BUS.BUS_DangKy();   

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (BUS_DangKy.KiemTraTenTaiKhoan(txtTenTaiKhoan.Text))
            {
                if (BUS_DangKy.KiemTraTrungMatKhau(txtMatKhau.Text, txtNhapLaiMatKhau.Text))
                {
                    if (BUS_DangKy.KiemTraEmail(txtEmail.Text))
                    {
                        BUS_DangKy.TaoTaiKhoan(txtTenTaiKhoan.Text, txtMatKhau.Text, txtEmail.Text);
                        MessageBox.Show("Người dùng tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
                        Hide();
                    }
                    // Email khong ton tai trong he thong
                    else
                    {
                        MessageBox.Show("Email không tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Focus();
                    }
                }
                // Mat Khau phai giong nhap lai mat khau
                else
                {
                    MessageBox.Show("Mật khẩu phải giống nhập lại mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNhapLaiMatKhau.Focus();
                }
            }
            // Ten tai khoan da ton tai
            else
            {
                MessageBox.Show("Tên tài khoản đã tồn tại, vui lòng nhập tên tài khoản khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTaiKhoan.Focus();
            }
        }
    }
}
