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
        F_HoaDon_HoaDon HoaDon = new F_HoaDon_HoaDon();
        F_HoaDon_MatHang MatHang = new F_HoaDon_MatHang();
        F_HoaDon_KhachHang KhachHang = new F_HoaDon_KhachHang();
        F_HoaDon_NCC NCC = new F_HoaDon_NCC();
        F_HoaDon_TT F_HoaDon_TT_HD = new F_HoaDon_TT();

        public F_HoaDon()
        {
            InitializeComponent();

            // pnNoiDung
            tpHoaDonBan.Controls.Add(HoaDon);
            tpKhachHang.Controls.Add(KhachHang);
            tpMatHang.Controls.Add(MatHang);
            tpNCC.Controls.Add(NCC);

            HoaDon.Show();
            KhachHang.Show();
            MatHang.Show();
            NCC.Show();

            // pnRight
            pnRight.Controls.Add(F_HoaDon_TT_HD);
            F_HoaDon_TT_HD.Show();

            // Event
            HoaDon.Event_HDB += F_HoaDon_TT_HD.Catch_ChonHDB;
            HoaDon.Event_HDN += F_HoaDon_TT_HD.Catch_ChonHDN;
            KhachHang.ChonKhachHang += F_HoaDon_TT_HD.Catch_ChonKhachHang;
            MatHang.ChonMatHang += F_HoaDon_TT_HD.Catch_ChonMatHang;
            NCC.ChonNCC += F_HoaDon_TT_HD.Catch_ChonNCC;
        }

        private void F_HoaDon_SizeChanged(object sender, EventArgs e)
        {
            pnRight.Width = 550;
            if (pnRight.Width > pnNoiDung.Width)
            {
                pnRight.Width = 400;
            }
        }
    }
}
