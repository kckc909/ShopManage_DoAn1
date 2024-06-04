using BUS;
using DTO;
using GUI.MyEventArgs;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class C_CTHoaDonNhap : Form
    {
        public event EventHandler<EventArgsChiTietHDN> Event_ThayDoiSoLuong;
        BUS_MatHang BUS_MatHang = new BUS_MatHang();
        public tblChiTietHDN CTHDN;
        public C_CTHoaDonNhap(tblChiTietHDN CTHDN)
        {
            InitializeComponent();
            this.CTHDN = CTHDN;
            Dock = DockStyle.Top;
            TopLevel = false;
        }

        void TinhThanhTien()
        {
            int thanhtien = (CTHDN.GiaNhap * CTHDN.SoLg).Value;
            txtThanhTien.Text = thanhtien.ToString("C");
        }

        void Raise_Event_ThayDoiSoLuong()
        {
            TinhThanhTien();
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
            lbTenMH.Text = BUS_MatHang.GetByID(CTHDN.MaMH).TenMH;
            txtSolg.Text = CTHDN.SoLg.ToString();
            txtGiaNhap.Text = CTHDN.GiaNhap.ToString();
            txtThanhTien.Text = (CTHDN.GiaNhap * CTHDN.SoLg).ToString();
            TinhThanhTien();
        }

        private void txtSolg_Leave(object sender, EventArgs e)
        {
            if (CTHDN.SoLg <= 0)
            {
                if (IsDisposed == false)
                {
                    Close();
                }    
                Raise_Event_ThayDoiSoLuong();
            }
            else
            {
                CTHDN.SoLg = Convert.ToInt32(txtSolg.Text);
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

        private void lbTenMH_Click(object sender, EventArgs e)
        {
            CTHDN.SoLg--;
            txtSolg.Text = CTHDN.SoLg.ToString();
            txtSolg_Leave(sender, e);
        }
    }
}
