using BUS;
using DTO;
using GUI.MyEventArgs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_HoaDon_HoaDon_TaoHoaDon : Form
    {
        public event EventHandler<EventArgsHoaDonBan> Event_TaoHDB;
        public event EventHandler<EventArgsHoaDonNhap> Event_TaoHDN;
        BUS_KhachHang BUS_KhachHang = new BUS_KhachHang();
        BUS_HoaDonBan BUS_HoaDonBan = new BUS_HoaDonBan();
        BUS_NhaCungCap BUS_NhaCungCap = new BUS_NhaCungCap();
        BUS_HoaDonNhap BUS_HoaDonNhap = new BUS_HoaDonNhap();

        public F_HoaDon_HoaDon_TaoHoaDon()
        {
            InitializeComponent();
        }

        void cbo_LoadData()
        {
            cboLoaiHoaDon.Items.Add("Hóa đơn bán");
            cboLoaiHoaDon.Items.Add("Hóa đơn nhập");
            cboKhachHang.DataSource = BUS_KhachHang.DSKH();
            cboKhachHang.ValueMember = "MaKH";
            cboKhachHang.DisplayMember = "TenKH";
            cboNhaCungCap.DataSource = BUS_NhaCungCap.DanhSachNCC();
            cboNhaCungCap.ValueMember = "MaNCC";
            cboNhaCungCap.DisplayMember = "TenNCC";
        }

        void MacDinh()
        {
            cboLoaiHoaDon.SelectedIndex = 0;
            cboKhachHang.SelectedValue = MyDefault.KH.MaKH;
            cboNhaCungCap.SelectedIndex = 0;
            dtp.Value = DateTime.Now;
            txtTTNV.Text = F_MainParent.NguoiDung.MaNV + " - " + F_MainParent.NguoiDung.TenNV;
        }

        void TaoHoaDonBan()
        {
            var hdb = new tblHoaDonBan();
            if (cboKhachHang.SelectedValue != null)
            {
                hdb.MaKH = cboKhachHang.SelectedValue.ToString();
            }
            else
            {
                hdb.MaKH = MyDefault.KH.MaKH;
            }
            hdb.MaHDB = BUS_HoaDonBan.MaTuDong();
            hdb.MaNV = F_MainParent.NguoiDung.MaNV;
            hdb.NgayBan = dtp.Value;
            hdb.TinhTrang = 0;
            Raise_TaoHDB(this, hdb);
        }

        void TaoHoaDonNhap()
        {
            if (cboNhaCungCap.SelectedValue is null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!");
                return;
            }
            tblHoaDonNhap HDN = new tblHoaDonNhap()
            {
                MaHDN = BUS_HoaDonNhap.MaTuDong(),
                MaNCC = cboNhaCungCap.SelectedValue.ToString(),
                MaNV = F_MainParent.NguoiDung.MaNV,
                NgayNhap = dtp.Value,
                TinhTrang = 0
            };
            Raise_TaoHDN(this, HDN);
        }

        void Raise_TaoHDB(object sender, tblHoaDonBan HDB)
        {
            EventArgsHoaDonBan e_ = new EventArgsHoaDonBan();
            e_.HDB = HDB;
            Event_TaoHDB.Invoke(sender, e_);
        }

        void Raise_TaoHDN(object sender, tblHoaDonNhap HDN)
        {
            EventArgsHoaDonNhap e_ = new EventArgsHoaDonNhap();
            e_.HDN = HDN;
            Event_TaoHDN.Invoke(sender, e_);
        }

        private void F_HoaDon_HoaDonBan_TaoHoaDon_Load(object sender, EventArgs e)
        {
            cbo_LoadData();
            MacDinh();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (cboLoaiHoaDon.SelectedIndex == 0)
            {
                TaoHoaDonBan();
            }
            else if (cboLoaiHoaDon.SelectedIndex == 1)
            {
                TaoHoaDonNhap();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
