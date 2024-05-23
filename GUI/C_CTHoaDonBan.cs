using DTO;
using GUI.MyEventArgs;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class C_CTHoaDonBan : Form
    {
        public event EventHandler<EventArgsChiTietHDB> Event_ThayDoiSoLuong;
        public tblChiTietHDB CTHDB;
        public C_CTHoaDonBan(tblChiTietHDB CTHDB)
        {
            InitializeComponent();
            this.CTHDB = CTHDB;
            TopLevel = false;
        }

        void Raise_Event_ThayDoiSoLuong()
        {
            Event_ThayDoiSoLuong(this, new EventArgsChiTietHDB()
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
            txtTenMH.Text = CTHDB.tblMatHang.TenMH;
            txtSolg.Text = CTHDB.SoLg.ToString();
            txtGiaBan.Text = CTHDB.GiaBan.ToString();
            txtThanhTien.Text = (CTHDB.GiaBan * CTHDB.SoLg).ToString();
        }

        private void txtSolg_TextChanged(object sender, EventArgs e)
        {
            if (txtSolg.Text.Equals(""))
            {
                Close();
            }
            else
            {
                CTHDB.SoLg = Convert.ToInt32(txtSolg.Text);
                Raise_Event_ThayDoiSoLuong();
            }
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            CTHDB.SoLg++;
            txtSolg.Text = CTHDB.SoLg.ToString();
            Raise_Event_ThayDoiSoLuong();
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            CTHDB.SoLg--;
            txtSolg.Text = CTHDB.SoLg.ToString();
            Raise_Event_ThayDoiSoLuong();
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
