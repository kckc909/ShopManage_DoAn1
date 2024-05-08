using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void F_DangNhap_Load(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Focus();
        }

        public event EventHandler DangNhapThanhCong;

        BUS.BUS_DangNhap BUS_DangNhap = new BUS.BUS_DangNhap();

        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                txtMatKhau.PasswordChar = '*';
            }
            else
            {
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (BUS_DangNhap.KiemTraRong(txtTenTaiKhoan.Text, txtMatKhau.Text))
            {
                if (BUS_DangNhap.KiemTraTaiKhoanMatKhau(txtTenTaiKhoan.Text, txtMatKhau.Text))
                {
                    //MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK);

                    F_MainParent.NguoiDung = BatSuKien_DangNhapThanhCong();
                    F_MainParent.Instance().Show();
                    txtTenTaiKhoan.Clear();
                    txtMatKhau.Clear();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        tblNhanVien BatSuKien_DangNhapThanhCong()
        {
            DangNhapThanhCong?.Invoke(this, EventArgs.Empty);
            
            return BUS_DangNhap.LayNhanVien(txtTenTaiKhoan.Text);
        }
    }
}
