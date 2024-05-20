using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class C_CTHoaDonNhap : Form
    {
        tblChiTietHDN CTHDN;
        public C_CTHoaDonNhap(tblChiTietHDN CTHDN)
        {
            InitializeComponent();
            this.CTHDN = CTHDN;
        }

        private void C_CTHoaDon_Load(object sender, EventArgs e)
        {
            txtTenMH.Text = CTHDN.tblMatHang.TenMH;
            txtSolg.Text = CTHDN.SoLg.ToString();
            txtGiaNhap.Text = CTHDN.GiaNhap.ToString();
            txtThanhTien.Text = (CTHDN.GiaNhap * CTHDN.SoLg).ToString();
        }

        private void txtSolg_TextChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (CTHDN.GiaNhap * CTHDN.SoLg).ToString();
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            CTHDN.SoLg++;
            txtSolg.Text = CTHDN.SoLg.ToString();
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            CTHDN.SoLg--;
            txtSolg.Text = CTHDN.SoLg.ToString();
        }
    }
}
