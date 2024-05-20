using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_TaiKhoan_ThemTaiKhoan : Form
    {
        BUS_TaiKhoan BUS_TaiKhoan = new BUS_TaiKhoan();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();

        public F_TaiKhoan_ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string TenTk = txtTenTK.Text.Trim();
            if (TenTk != "")
            {
                string MK = txtMatKhau.Text.Trim();
                if (MK != "")
                {
                    if (MK.Length > 4)
                    {
                        string MaNV = txtMaNV.Text.Trim();
                        if (MaNV != "")
                        {
                            if (BUS_NhanVien.KiemTraTonTai(MaNV))
                            {
                                if (!BUS_TaiKhoan.Check_NhanVienCoTaiKhoan(MaNV))
                                {
                                    BUS_TaiKhoan.Them(new DTO.tblTaiKhoanMatKhau()
                                    {
                                        TaiKhoan = txtTenTK.Text,
                                        MatKhau = txtMatKhau.Text,
                                        MaNV = txtMaNV.Text
                                    });
                                    MessageBox.Show("Thêm tài khoản thành công!");
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("Mỗi nhân viên chỉ có thể có một tài khoản!");
                                }    
                            }
                            else
                            {
                                MessageBox.Show("Nhân viên không tồn tại!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hãy nhập mã nhân viên!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu quá yếu! Hãy nhập mật khẩu dài hơn 4 ký tự!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!");
                }
            }
            else
            {
                MessageBox.Show("Không thể để trống tên tài khoản!");
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
