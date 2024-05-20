using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class C_CTHoaDonBan : Form
    {
        tblChiTietHDB CTHDB;
        public C_CTHoaDonBan(tblChiTietHDB CTHDB)
        {
            InitializeComponent();
            this.CTHDB = CTHDB;
        }

        private void C_CTHoaDon_Load(object sender, EventArgs e)
        {
            txtTenMH.Text = CTHDB.tblMatHang.TenMH;
            txtSolg.Text = CTHDB.SoLg.ToString();
            txtGiaBan.Text = CTHDB.GiaBan.ToString();
            txtThanhTien.Text = (CTHDB.GiaBan * CTHDB.SoLg).ToString();
        }

        private void txtSolg_TextChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (CTHDB.GiaBan * CTHDB.SoLg).ToString();
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            CTHDB.SoLg++;
            txtSolg.Text = CTHDB.SoLg.ToString();
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            CTHDB.SoLg--;
            txtSolg.Text = CTHDB.SoLg.ToString();
        }
    }
}
