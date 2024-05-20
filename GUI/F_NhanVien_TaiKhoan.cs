using BUS;
using DTO;
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
    public partial class F_NhanVien_TaiKhoan : Form
    {
        BUS_TaiKhoan BUS_TaiKhoan = new BUS_TaiKhoan();
        tblTaiKhoanMatKhau TK;
        public F_NhanVien_TaiKhoan(tblNhanVien NV)
        {
            InitializeComponent();
            TK = BUS_TaiKhoan.TheoMaNhanVien(NV.MaNV);
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

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!txtTenTaiKhoan.Text.Trim().Equals(""))
            {
                if (!txtMatKhau.Text.Trim().Equals(""))
                {
                    if (BUS_TaiKhoan.Check_TenTaiKhoanMoi(TK.TaiKhoan, txtTenTaiKhoan.Text))
                    {
                        if (MessageBox.Show("Bạn có muốn thay đổi thông tin tài khoản ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            BUS_TaiKhoan.Sua(TK.TaiKhoan, txtTenTaiKhoan.Text, txtMatKhau.Text);
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản mới đã bị trùng!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Không thể để trống mật khẩu!");
                }
            }
            else
            {
                MessageBox.Show("Không thể để trống tên tài khoản!");
            }
        }

        private void F_NhanVien_TaiKhoan_Load(object sender, EventArgs e)
        {
            if (TK != null)
            {
                txtTenTaiKhoan.Text = TK.TaiKhoan;
                txtMatKhau.Text = TK.MatKhau;
            }
        }
    }
}
