using BUS;
using DTO;
using GUI.MyEventArgs;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_HoaDon_HoaDon : Form
    {
        public event EventHandler<EventArgsHoaDonBan> Event_HDB;
        public event EventHandler<EventArgsHoaDonNhap> Event_HDN;
        BUS_HoaDonBan BUS_HoaDonBan = new BUS_HoaDonBan();
        BUS_HoaDonNhap BUS_HoaDonNhap = new BUS_HoaDonNhap();
        BUS_KhachHang BUS_KhachHang = new BUS_KhachHang();
        BUS_NhaCungCap BUS_NhaCungCap = new BUS_NhaCungCap();
        tblHoaDonBan Current_HDB = null;
        tblHoaDonNhap Current_HDN = null;

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
            if (cboLoaiHoaDon.SelectedIndex == 0)
            {
                dtg.Columns.Add("MaKH", "Mã khách hàng");
                dtg.Columns.Add("TenKH", "Tên khách hàng");
            }
            else if (cboLoaiHoaDon.SelectedIndex == 1)
            {
                dtg.Columns.Add("MaNCC", "Mã NCC");
                dtg.Columns.Add("TenNCC", "Tên NCC");
            }
            dtg.Columns.Add("SDT", "Số điện thoại");
            dtg.Columns.Add("TT", "Tình trạng");
            dtg.Columns["TT"].Visible = false;
        }

        void dtg_LoadData()
        {
            dtg.Rows.Clear();
            if (cboLoaiHoaDon.SelectedIndex == 0)
            {
                BUS_HoaDonBan.DS_HDB().ForEach(HDB =>
                {
                    if (HDB.TinhTrang == cboTrangThai.SelectedIndex)
                    {
                        dtg_AddRow_HDB(HDB);
                    }
                });
            }
            else if (cboLoaiHoaDon.SelectedIndex == 1)
            {
                BUS_HoaDonNhap.DS_HDN().ForEach(HDN =>
                {
                    if (HDN.TinhTrang == cboTrangThai.SelectedIndex)
                    {
                        dtg_AddRow_HDN(HDN);
                    }
                });
            }
        }

        int dtg_AddRow_HDB(tblHoaDonBan HDB)
        {
            var Kh = BUS_KhachHang.LayTheoMa(HDB.MaKH);
            int i = dtg.Rows.Count - 1;
            dtg.Rows.Add(HDB.MaHDB, Kh.MaKH, Kh.TenKH, Kh.SDT, HDB.TinhTrang);
            return i;
        }

        int dtg_AddRow_HDN(tblHoaDonNhap HDN)
        {
            var ncc = BUS_NhaCungCap.GetById(HDN.MaNCC);
            int i = dtg.RowCount - 1;
            dtg.Rows.Add(HDN.MaHDN, ncc.MaNCC, ncc.TenNCC, ncc.SDT, HDN.TinhTrang);
            return i;
        }

        void LamMoi()
        {
            Current_HDB = null;
            Current_HDN = null;

            dtg_AddColumns();
            dtg_LoadData();
        }

        void Catch_TaoHoaDonBan(object sender, EventArgsHoaDonBan e)
        {
            cboLoaiHoaDon.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            Current_HDB = e.HDB;
            BUS_HoaDonBan.Them(Current_HDB);
            int i = dtg_AddRow_HDB(Current_HDB);
            dtg.ClearSelection();
            dtg.Rows[i].Selected = true;
            ((Form)sender).Close();
        }

        void Catch_TaoHoaDonNhap(object sender, EventArgsHoaDonNhap e)
        {
            cboLoaiHoaDon.SelectedIndex = 1;
            cboTrangThai.SelectedIndex = 0;
            Current_HDN = e.HDN;
            BUS_HoaDonNhap.Them(Current_HDN);
            int i = dtg_AddRow_HDN(Current_HDN);
            dtg.ClearSelection();
            dtg.Rows[i].Selected = true;
            ((Form)sender).Close();
        }

        void Raise_ChonHDB(tblHoaDonBan HDB)
        {
            EventArgsHoaDonBan e = new EventArgsHoaDonBan();
            e.HDB = HDB;
            e.KH = BUS_KhachHang.LayTheoMa(e.HDB.MaKH);
            Event_HDB?.Invoke(this, e);
        }

        void Raise_ChonHDN(tblHoaDonNhap HDN)
        {
            EventArgsHoaDonNhap e = new EventArgsHoaDonNhap();
            e.HDN = HDN;
            e.NCC = BUS_NhaCungCap.GetById(e.HDN.MaNCC);
            Event_HDN?.Invoke(this, e);
        }

        private void F_HoaDon_QLHoaDon_Load(object sender, EventArgs e)
        {
            Controls_Modify();
            dtg_AddColumns();
            dtg_LoadData();
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            F_HoaDon_HoaDon_TaoHoaDon f = new F_HoaDon_HoaDon_TaoHoaDon();
            f.Event_TaoHDB += Catch_TaoHoaDonBan;
            f.Event_TaoHDN += Catch_TaoHoaDonNhap;
            f.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboLoaiHoaDon.SelectedIndex == 0)
            {
                BUS_HoaDonBan.Loc_TimKiem(dtg, txttimKiem.Text, cboTrangThai.SelectedIndex);
            }
            else if (cboLoaiHoaDon.SelectedIndex == 1)
            {
                BUS_HoaDonNhap.Loc_TimKiem(dtg, txttimKiem.Text, cboTrangThai.SelectedIndex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hóa đơn này không!", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (cboLoaiHoaDon.SelectedIndex == 0)
                {
                    BUS_HoaDonBan.Xoa(Current_HDB.MaHDB);
                    Current_HDB = null;
                }
                else if (cboLoaiHoaDon.SelectedIndex == 1)
                {
                    BUS_HoaDonNhap.Xoa(Current_HDN.MaHDN);
                    Current_HDN = null;
                }
                dtg_LoadData();
                MessageBox.Show("Đã xóa hóa đơn!");
            }
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dtg.SelectedRows[0].Cells[0].Value != null)
                {
                    if (cboLoaiHoaDon.SelectedIndex == 0)
                    {
                        Current_HDB = BUS_HoaDonBan.HDB_LayTheoMa(dtg.SelectedRows[0].Cells[0].Value.ToString());
                        Raise_ChonHDB(Current_HDB);
                    }
                    else if (cboLoaiHoaDon.SelectedIndex == 1)
                    {
                        Current_HDN = BUS_HoaDonNhap.HDN_LayTheoMa(dtg.SelectedRows[0].Cells[0].Value.ToString());
                        Raise_ChonHDN(Current_HDN);
                    }
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void cboLoaiHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtg_LoadData();
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtg_LoadData();
        }
    }
}
