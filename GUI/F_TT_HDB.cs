using BUS;
using DTO;
using GUI.MyEventArgs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_TT_HDB : Form
    {
        tblHoaDonBan HDB;
        public F_TT_HDB(tblHoaDonBan HDB)
        {
            InitializeComponent();
            this.HDB = HDB;
        }

        void pn_Modify()
        {

        }

        void Load_TTHD()
        {
            if (HDB.NgayBan is null)
            {
                HDB.NgayBan = DateTime.Now;
            }
            dtpNgayHoanTat.Value = HDB.NgayBan.Value;
            txtMaHDB.Text = HDB.MaHDB;
            txtMa_TenNv.Text = HDB.MaNV + HDB.tblNhanVien.TenNV;
            txtTenKH.Text = HDB.tblKhachHang.TenKH;
            txtSDT.Text = HDB.tblKhachHang.SDT;
        }

        void Load_DS_CTHD()
        {
            if (HDB.tblChiTietHDBs != null)
            {
                HDB.tblChiTietHDBs.ToList().ForEach(ct =>
                {
                    flpDSMH.Controls.Add(new C_CTHoaDonBan(ct));
                });
            }
        }

        void Catch_ChonHoaDon(object sender, EventArgsHoaDon e)
        {

        }

        void Catch_ChonKhachHang(object sender, EventArgsKhachHang e)
        {

        }
        
        void Catch_ChonMatHang(object sender, EventArgsMatHang e)
        {

        }

        private void F_TT_HDB_Load(object sender, EventArgs e)
        {
            pn_Modify();
            Load_TTHD();
            Load_DS_CTHD();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Hiển thị hóa đơn
            // Chuyển đổi trạng thái thành đã thah toán

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Hiển thị thông tin hóa đơn lên màn hình (coi như đã in)
        }
    }
}
