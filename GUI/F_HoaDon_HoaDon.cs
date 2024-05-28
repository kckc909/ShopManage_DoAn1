using BUS;
using DTO;
using GUI.MyEventArgs;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_HoaDon_HoaDon : Form
    {
        public event EventHandler<EventArgsHoaDonBan> Event_ChonHDB;
        public event EventHandler<EventArgsHoaDonNhap> Event_ChonHDN;
        public event EventHandler Event_Enable;
        public event EventHandler Event_Disable;
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

        void dtg_RenameColumns()
        {
            if (cboLoaiHoaDon.SelectedIndex == 0)
            {
                dtg.Columns[1].HeaderText = "Mã khách hàng";
                dtg.Columns[2].HeaderText = "Tên khách hàng";
            }
            else if (cboLoaiHoaDon.SelectedIndex == 1)
            {
                dtg.Columns[1].HeaderText = "Mã NCC";
                dtg.Columns[2].HeaderText = "Tên NCC";
            }
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
            if (cboLoaiHoaDon.SelectedIndex == 0)
            {
                BUS_HoaDonBan.HDB_GetAll().ForEach(h =>
                {
                    dtg_AddRow_HDB(h);
                });
                BUS_HoaDonBan.HDB_dtg_Filter(dtg, cboTrangThai.SelectedIndex);
            }
            else if (cboLoaiHoaDon.SelectedIndex == 1)
            {
                BUS_HoaDonNhap.HDN_GetAll().ForEach(h =>
                {
                    dtg_AddRow_HDN(h);
                });
                BUS_HoaDonNhap.HDN_dtg_Filter(dtg, cboTrangThai.SelectedIndex);
            }
        }

        int dtg_AddRow_HDB(tblHoaDonBan HDB)
        {
            var Kh = BUS_KhachHang.LayTheoMa(HDB.MaKH);
            dtg.Rows.Add(HDB.MaHDB, Kh.MaKH, Kh.TenKH, Kh.SDT, HDB.TinhTrang);
            int i = dtg.Rows.Count - 1;
            return i;
        }

        int dtg_AddRow_HDN(tblHoaDonNhap HDN)
        {
            var ncc = BUS_NhaCungCap.GetById(HDN.MaNCC);
            dtg.Rows.Add(HDN.MaHDN, ncc.MaNCC, ncc.TenNCC, ncc.SDT, HDN.TinhTrang);
            int i = dtg.RowCount - 1;
            return i;
        }

        public void LamMoi()
        {
            BUS_HoaDonBan = new BUS_HoaDonBan();
            BUS_HoaDonNhap = new BUS_HoaDonNhap();
            dtg_AddColumns();
            dtg_LoadData();
            dtg_RenameColumns();
        }

        void Catch_TaoHoaDonBan(object sender, EventArgsHoaDonBan e)
        {

            cboLoaiHoaDon.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            BUS_HoaDonBan.HDB_Add(e.HDB);
            Raise_ChonHDB(e.HDB);
            ((Form)sender).Close();
            dtg_LoadData();
        }

        void Catch_TaoHoaDonNhap(object sender, EventArgsHoaDonNhap e)
        {
            cboLoaiHoaDon.SelectedIndex = 1;
            cboTrangThai.SelectedIndex = 0;
            BUS_HoaDonNhap.HDN_Add(e.HDN);
            Raise_ChonHDN(e.HDN);
            ((Form)sender).Close();
            dtg_LoadData();
        }

        void Raise_ChonHDB(tblHoaDonBan HDB)
        {
            EventArgsHoaDonBan e = new EventArgsHoaDonBan();
            e.HDB = HDB;
            e.KH = BUS_KhachHang.LayTheoMa(e.HDB.MaKH);
            Event_ChonHDB?.Invoke(this, e);
        }

        void Raise_ChonHDN(tblHoaDonNhap HDN)
        {
            EventArgsHoaDonNhap e = new EventArgsHoaDonNhap();
            e.HDN = HDN;
            e.NCC = BUS_NhaCungCap.GetById(e.HDN.MaNCC);
            Event_ChonHDN?.Invoke(this, e);
        }

        void Raise_Event_Enable()
        {
            Event_Enable?.Invoke(this, EventArgs.Empty);
        }

        void Raise_Event_Disable()
        {
            Event_Disable?.Invoke(this, EventArgs.Empty);
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
                BUS_HoaDonBan.HDB_dtg_Search(dtg, txttimKiem.Text);
            }
            else if (cboLoaiHoaDon.SelectedIndex == 1)
            {
                BUS_HoaDonNhap.HDN_dtg_Search(dtg, txttimKiem.Text);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hóa đơn này không!", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (cboLoaiHoaDon.SelectedIndex == 0)
                {
                    if (Current_HDB != null)
                    {
                        BUS_HoaDonBan.HDB_Delete(Current_HDB);
                        Current_HDB = null;
                    }
                }
                else if (cboLoaiHoaDon.SelectedIndex == 1)
                {
                    if (Current_HDN != null)
                    {
                        BUS_HoaDonNhap.HDN_Delete(Current_HDN);
                        Current_HDN = null;
                    }
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
                        Current_HDB = BUS_HoaDonBan.HDB_GetById(dtg.SelectedRows[0].Cells[0].Value.ToString());
                        Raise_ChonHDB(Current_HDB);
                    }
                    else if (cboLoaiHoaDon.SelectedIndex == 1)
                    {
                        Current_HDN = BUS_HoaDonNhap.HDN_GetById(dtg.SelectedRows[0].Cells[0].Value.ToString());
                        Raise_ChonHDN(Current_HDN);
                    }
                }
            }
        }

        private void cboLoaiHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtg_LoadData();
            dtg_RenameColumns();
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiHoaDon.SelectedIndex == 0)
            {
                BUS_HoaDonBan.HDB_dtg_Filter(dtg, cboTrangThai.SelectedIndex);
            }
            else if (cboLoaiHoaDon.SelectedIndex == 1)
            {
                BUS_HoaDonNhap.HDN_dtg_Filter(dtg, cboTrangThai.SelectedIndex);
            }
            if (cboTrangThai.SelectedIndex == 0)
            {
                Raise_Event_Enable();
            }
            else
            {
                Raise_Event_Disable();
            }
        }
    }
}
