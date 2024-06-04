using BUS;
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
        public event EventHandler DangNhapThanhCong;

        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        BUS_TaiKhoan BUS_TaiKhoan = new BUS_TaiKhoan();

        public F_DangNhap()
        {
            InitializeComponent();
        }

        private void F_DangNhap_Load(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Focus();
        }

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
            if (txtTenTaiKhoan.Text!="" && txtMatKhau.Text!= "")
            {
                if (BUS_TaiKhoan.Check_DangNhap(txtTenTaiKhoan.Text, txtMatKhau.Text))
                {
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
            return BUS_NhanVien.GetById(BUS_TaiKhoan.TheoTenTaiKhoan(txtTenTaiKhoan.Text).MaNV);
        }

        private void lbQMK_Click(object sender, EventArgs e)
        {
            F_DangNhap_QuenMatKhau F = new F_DangNhap_QuenMatKhau();
            F.ShowDialog();
        }
    }
}
