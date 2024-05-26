using BUS;
using DTO;
using GUI.MyEventArgs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_HoaDon_KhachHang : Form
    {
        public event EventHandler<EventArgsKhachHang> Event_ChonKhachHang;
        BUS_KhachHang BUS_KhachHang = new BUS_KhachHang();

        public F_HoaDon_KhachHang()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;
        }

        void dtg_AddColumn()
        {
            dtgDSKH.AutoGenerateColumns = false;
            dtgDSKH.Columns.Clear();
            dtgDSKH.Columns.Add("MaKH", "Mã khách hàng");
            dtgDSKH.Columns.Add("TenKH", "Tên khách hàng");
            dtgDSKH.Columns.Add("SDT", "Số điện thoại");
        }

        void dtg_Load()
        {
            dtgDSKH.DataSource = BUS_KhachHang.DSKH();
            dtgDSKH.Columns["MaKH"].DataPropertyName = "MaKH";
            dtgDSKH.Columns["TenKH"].DataPropertyName = "TenKH";
            dtgDSKH.Columns["SDT"].DataPropertyName = "SDT";
        }

        void Catch_ThemKhachHang(object sender, EventArgs e)
        {
            dtg_Load();
            ((Form)sender).Close();
        }

        void Raise_ChonKhachHang(tblKhachHang KH)
        {
            if (KH != null)
            {
                Event_ChonKhachHang?.Invoke(this, new EventArgsKhachHang()
                {
                    KhachHang = KH
                });
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            F_KhachHang_ThemKhachHang f = new F_KhachHang_ThemKhachHang();
            f.ThemKhachHang += Catch_ThemKhachHang;
            f.Show();
        }

        private void F_HoaDon_KhachHang_Load(object sender, EventArgs e)
        {
            dtg_AddColumn();
            dtg_Load();
        }

        private void dtgDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgDSKH.SelectedRows.Count > 0)
            {
                var MaKH = dtgDSKH.SelectedRows[0].Cells[0].Value;
                if (MaKH != null)
                {
                    tblKhachHang KH = BUS_KhachHang.LayTheoMa(MaKH.ToString());
                    Raise_ChonKhachHang(KH);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUS_KhachHang.dtg_Filter(dtgDSKH, txtTimKiem.Text);
        }
    }
}
