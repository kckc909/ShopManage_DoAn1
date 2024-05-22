using DTO;
using GUI.MyEventArgs;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class C_CTHoaDonNhap : Form
    {
        public event EventHandler<EventArgsChiTietHDN> Event_ThayDoiSoLuong;
        public tblChiTietHDN CTHDN;
        public C_CTHoaDonNhap(tblChiTietHDN CTHDN)
        {
            InitializeComponent();
            this.CTHDN = CTHDN;
        }

        void Raise_Event_ThayDoiSoLuong()
        {
            Event_ThayDoiSoLuong?.Invoke(this, new EventArgsChiTietHDN()
            {
                CTHDN = CTHDN
            });
        }

        public void Catch_Event_TangSoLuong()
        {
            CTHDN.SoLg++;
            txtSolg.Text = CTHDN.SoLg.ToString();
            Raise_Event_ThayDoiSoLuong();
        }

        private void C_CTHoaDon_Load(object sender, EventArgs e)
        {
            txtTenMH.Text = CTHDN.tblMatHang.TenMH;
            txtSolg.Text = CTHDN.SoLg.ToString();
            txtGiaNhap.Text = CTHDN.GiaNhap.ToString();
            txtThanhTien.Text = (CTHDN.GiaNhap * CTHDN.SoLg).ToString();
        }

        private void txtSolg_Leave(object sender, EventArgs e)
        {
            if (txtSolg.Text.Equals(""))
            {
                Close();
            }
            else
            {
                CTHDN.SoLg = Convert.ToInt32(txtSolg.Text);
                Raise_Event_ThayDoiSoLuong() ;
            }
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            CTHDN.SoLg++;
            txtSolg.Text = CTHDN.SoLg.ToString();
            Raise_Event_ThayDoiSoLuong();
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            CTHDN.SoLg--;
            if (CTHDN.SoLg == 0)
            {
                Close();
            }
            else
            {
                txtSolg.Text = CTHDN.SoLg.ToString();
                Raise_Event_ThayDoiSoLuong();
            }
        }

        private void txtSolg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar == (char)(Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
