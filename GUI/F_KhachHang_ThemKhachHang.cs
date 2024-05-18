using BUS;
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
    public partial class F_KhachHang_ThemKhachHang : Form
    {
        public event EventHandler ThemKhachHang;
        BUS_KhachHang BUS_KhachHang = new BUS_KhachHang();
        public F_KhachHang_ThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!txtTenKH.Text.Trim().Equals(""))
            {
                if (Tools.Check.IsValidPhoneNumber(txtSDT.Text))
                {
                    BUS_KhachHang.Them(new DTO.tblKhachHang()
                    {
                        MaKH = BUS_KhachHang.MaTuDong(),
                        TenKH = txtTenKH.Text,
                        SDT = txtSDT.Text
                    });
                    ThemKhachHang.Invoke(this, e);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng số điện thoại khách hàng!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && (char)Keys.Back != e.KeyChar)
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (char)Keys.Back != e.KeyChar)
            {
                e.Handled = true;
            }
        }
    }
}
