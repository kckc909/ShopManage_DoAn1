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
using System.Web.Caching;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_HoaDon_HoaDon : Form
    {
        public event EventHandler<EventArgsHoaDonBan> e_ChonHoaDon;
        BUS_HoaDonBan BUS_HoaDonBan = new BUS_HoaDonBan();
        tblHoaDonBan Current = null;
        int TinhTrang = 0;

        public F_HoaDon_HoaDon()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;
        }

        void Controls_Modify()
        {
            dtg.AutoGenerateColumns = false;
        }

        void dtg_AddColumns()
        {
            dtg.Columns.Clear();
            dtg.Columns.Add("MaHD", "Mã hóa đơn");
            dtg.Columns.Add("MaKH", "Mã khách hàng");
            dtg.Columns.Add("TenKH", "Tên khách hàng");
            dtg.Columns.Add("SDT", "Số điện thoại");
            dtg.Columns.Add("TT", "Tình trạng");
            dtg.Columns["TT"].Visible = false;
        }

        void dtg_LoadData()
        { 
            dtg.Rows.Clear();
            BUS_HoaDonBan.DS_HDB().ForEach(x =>
            {
                dtg_AddRow(x);
            });
        }

        int dtg_AddRow(tblHoaDonBan x)
        {
            dtg.Rows.Add(x.MaHDB);
            int i = dtg.Rows.Count - 1;
            dtg.Rows[i].Cells[1].Value = x.MaKH;
            dtg.Rows[i].Cells[2].Value = x.tblKhachHang.TenKH;
            dtg.Rows[i].Cells[3].Value = x.tblKhachHang.SDT;
            dtg.Rows[i].Cells["TT"].Value = x.TinhTrang;
            return i;
        }

        void LamMoi()
        {
            Current = null;
            txttimKiem.Clear();
            TinhTrang = 0;

            dtg_AddColumns();
            dtg_LoadData();
        }
        
        void Catch_TaoHoaDonBan(object sender, EventArgsHoaDonBan e)
        {
            ((Form)sender).Close();
            Current = e.HDB;
            BUS_HoaDonBan.Them(Current);
            dtg.Rows[dtg_AddRow(Current)].Selected = true;
            Raise_ChonHoaDonBan(Current);
        }

        void Raise_ChonHoaDonBan(tblHoaDonBan hdb)
        {
            EventArgsHoaDonBan e = new EventArgsHoaDonBan();
            e.HDB = hdb;
            e_ChonHoaDon?.Invoke(this, e);
        }

        private void F_HoaDon_QLHoaDon_Load(object sender, EventArgs e)
        {
            Controls_Modify();
            dtg_AddColumns();
            dtg_LoadData();
        }

        private void btnHDChuaTT_Click(object sender, EventArgs e)
        {
            TinhTrang = 0;
            BUS_HoaDonBan.Loc_HDChuaTT(dtg);
        }

        private void btnHDDaTT_Click(object sender, EventArgs e)
        {
            TinhTrang = 1;
            BUS_HoaDonBan.Loc_HĐaTT(dtg);
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            F_HoaDon_HoaDon_TaoHoaDon f = new F_HoaDon_HoaDon_TaoHoaDon();
            f.Event_TaoHDB += Catch_TaoHoaDonBan;
            f.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            BUS_HoaDonBan.Loc_TimKiem(dtg, txttimKiem.Text, TinhTrang);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Current != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa hóa đơn này không!", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BUS_HoaDonBan.Xoa(Current.MaHDB);
                }
            }
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg.SelectedRows.Count > 0)
            {
                var MaHDB = dtg.SelectedRows[0].Cells[0].Value;
                if (MaHDB != null)
                {
                    Current = BUS_HoaDonBan.HDB_LayTheoMa(MaHDB.ToString());
                    Raise_ChonHoaDonBan(Current);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
    }
}
