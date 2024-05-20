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
    public partial class F_HoaDon_HoaDonBan_TaoHoaDon : Form
    {
        public event EventHandler<MyEventArgs.EventArgsHoaDon> e_TaoHoaDon;
        BUS_KhachHang BUS_KhachHang = new BUS_KhachHang();
        BUS_HoaDonBan BUS_HoaDonBan = new BUS_HoaDonBan();

        public F_HoaDon_HoaDonBan_TaoHoaDon()
        {
            InitializeComponent();
        }

        void Raise_TaoHoaDon(object sender, tblHoaDonBan HDB)
        {
            MyEventArgs.EventArgsHoaDon e_ = new MyEventArgs.EventArgsHoaDon() { tblHoaDonBan = HDB };
            e_TaoHoaDon.Invoke(this, e_);
        }

        private void F_HoaDon_HoaDonBan_TaoHoaDon_Load(object sender, EventArgs e)
        {
            cboKhachHang.DataSource = BUS_KhachHang.DSKH();
            cboKhachHang.ValueMember = "MaKH";
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.SelectedValue = MyDefault.MaKM;
            dtp.Value = DateTime.Now;
            txtTTNV.Text = F_MainParent.NguoiDung.MaNV + " - " + F_MainParent.NguoiDung.TenNV;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            var hdb = new tblHoaDonBan();
            hdb.MaHDB = BUS_HoaDonBan.MaTuDong();
            if (cboKhachHang.SelectedValue != null)
            {
                hdb.MaKH = cboKhachHang.SelectedValue.ToString();
            }
            else
            {
                hdb.MaKH = MyDefault.KH.MaKH;
            }
            hdb.MaNV = F_MainParent.NguoiDung.MaNV;
            hdb.NgayBan = dtp.Value;
            hdb.TinhTrang = 0;
            Raise_TaoHoaDon(this, hdb);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
