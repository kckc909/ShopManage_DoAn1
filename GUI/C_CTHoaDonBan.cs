using BUS;
using DTO;
using GUI.MyEventArgs;
using System;
using System.Windows.Forms;
using System.Text;

namespace GUI
{
    public partial class C_CTHoaDonBan : Form
    {
        public event EventHandler<EventArgsChiTietHDB> Event_ThayDoiSoLuong;
        public event EventHandler Event_TinhThanhTien;
        public tblChiTietHDB CTHDB;
        BUS_MatHang BUS_MatHang = new BUS_MatHang();
        BUS_KhuyenMai BUS_KhuyenMai = new BUS_KhuyenMai();
        public int ptg = 0;
        public C_CTHoaDonBan(tblChiTietHDB CTHDB)
        {
            InitializeComponent();
            this.CTHDB = CTHDB;
            Dock = DockStyle.Top;
            TopLevel = false;
            lbGiaTriKM.Visible = false;
        }

        void TinhThanhTien()
        {
            int thanhtien = (CTHDB.GiaBan * CTHDB.SoLg).Value;
            if (lbGiaTriKM.Visible)
            {
                thanhtien -= thanhtien * ptg;
            }
            txtThanhTien.Text = thanhtien.ToString("C");
            Raise_Event_TinhThanhTien();
        }

        void Raise_Event_TinhThanhTien()
        {
            Event_TinhThanhTien?.Invoke(this, EventArgs.Empty);
        }

        void Raise_Event_ThayDoiSoLuong()
        {
            TinhThanhTien();
            Event_ThayDoiSoLuong?.Invoke(this, new EventArgsChiTietHDB()
            {
                CTHDB = CTHDB
            });
        }

        public void Catch_Event_TangSoLuong()
        {
            CTHDB.SoLg++;
            txtSolg.Text = CTHDB.SoLg.ToString();
            Raise_Event_ThayDoiSoLuong();
        }

        private void C_CTHoaDon_Load(object sender, EventArgs e)
        {
            lbTenMH.Text = BUS_MatHang.LayTheoMa(CTHDB.MaMH).TenMH;
            txtSolg.Text = CTHDB.SoLg.ToString();
            txtGiaBan.Text = CTHDB.GiaBan.Value.ToString("C");
            ptg = BUS_KhuyenMai.PhamTramGiam(CTHDB.MaKM);
            if (ptg > 0)
            {
                lbGiaTriKM.Visible = true;
                lbGiaTriKM.Text = $"-{ptg}%";
            }
            TinhThanhTien();
        }

        // txtsolg_leave
        private void txtSolg_TextChanged(object sender, EventArgs e)
        {
            if (txtSolg.Text.Equals("") || txtSolg.Text.Equals("0"))
            {
                if (this.IsDisposed == false)
                    Close();
            }
            else
            {
                CTHDB.SoLg = Convert.ToInt32(txtSolg.Text);
                Raise_Event_ThayDoiSoLuong();
            }
        }

        private void txtSolg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void lbTenMH_Click(object sender, EventArgs e)
        {
            CTHDB.SoLg--;
            txtSolg.Text = CTHDB.SoLg.ToString();
            txtSolg_TextChanged(sender, e);
        }
    }
}
