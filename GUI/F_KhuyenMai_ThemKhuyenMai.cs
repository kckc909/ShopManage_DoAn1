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
    public partial class F_KhuyenMai_ThemKhuyenMai : Form
    {
        public event EventHandler KhuyenMaiAdded;
        BUS_KhuyenMai BUS_KhuyenMai = new BUS_KhuyenMai();
        public F_KhuyenMai_ThemKhuyenMai()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tblKhuyenMai km = new tblKhuyenMai();
            km.MaKM = BUS_KhuyenMai.MaTuDong();
            if (txtTenKM.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên khuyến mãi");
                txtTenKM.Focus();
                return;
            }
            km.TenKM = txtTenKM.Text;
            if (txtMoTa.Text.Trim().Equals(""))
            {
                MessageBox.Show("Hãy mô tả khuyến mãi!");
                txtMoTa.Focus();
                return;
            }
            km.MoTa = txtMoTa.Text;
            int ptg;
            if (int.TryParse(txtPhanTramgGiam.Text, out ptg))
            {
                if (ptg >= 0 && ptg <= 100)
                {
                    km.PhamTramGiam = ptg;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mức giảm hợp lí! [0, 100]");
                    txtPhanTramgGiam.Focus();
                    return;
                }
            }
            if (dtpNgayBatDau.Value > dtpNgayKetThuc.Value)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc");
                return;
            }
            km.NgayBatDau = dtpNgayBatDau.Value;
            km.NgayKetThuc = dtpNgayKetThuc.Value;
            BUS_KhuyenMai.Them(km);
            KhuyenMaiAdded?.Invoke(this, EventArgs.Empty);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPhanTramgGiam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
