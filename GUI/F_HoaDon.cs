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
    public partial class F_HoaDon : Form
    {
        F_HoaDon_HoaDon HoaDonBan = new F_HoaDon_HoaDon();
        F_HoaDon_MatHang MatHang = new F_HoaDon_MatHang();
        F_HoaDon_KhachHang KhachHang = new F_HoaDon_KhachHang();
        F_HoaDon_HoaDonNhap HoaDonNhap = new F_HoaDon_HoaDonNhap();

        public F_HoaDon()
        {
            InitializeComponent();

            tpHoaDonBan.Controls.Add(HoaDonBan);
            tpKhachHang.Controls.Add(KhachHang);
            tpMatHang.Controls.Add(MatHang);
            tpHoaDonNhap.Controls.Add(HoaDonNhap);

            HoaDonBan.Show();
            KhachHang.Show();
            MatHang.Show();
            HoaDonNhap.Show();
        }

        private void F_HoaDon_SizeChanged(object sender, EventArgs e)
        {
            pnRight.Width = pnRight.Width == 400 ? 550 : 400;
            if (pnRight.Width > pnNoiDung.Width)
            {
                pnRight.Width = 400;
            }
        }
    }
}
