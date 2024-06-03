using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_TrangChu : Form
    {
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        BUS_BaoCaoThongKe BUS_BaoCaoThongKe = new BUS_BaoCaoThongKe();

        public F_TrangChu()
        {
            InitializeComponent();
        }

        void DoanhThuThang()
        {
            var lst = BUS_BaoCaoThongKe.RevenueAllDayOfMonth(DateTime.Now);
            chart_DoanhThuThang.Series[0].Points.DataBindXY(lst.Select(x => x.Ngay).ToList(), lst.Select(x => x.DoanhThu).ToList());
        }

        void DoanhsoNVThang()
        {
            var lst = BUS_BaoCaoThongKe.DoanhSoNhanVienTheoThang(F_MainParent.NguoiDung.MaNV, DateTime.Now);
            chart_DoanhSoNVThangNay.Series[0].Points.DataBindY(lst);
        }

        void DSMatHangCanNhap()
        {
            dgvDSMHCanNhap.DataSource = BUS_BaoCaoThongKe.MatHangCanNhap().Select(x => new { x.MaMH, x.TenMH, x.SoLuong, x.date }).ToList();
            dgvDSMHCanNhap.Columns[0].DataPropertyName = "MaMH";
            dgvDSMHCanNhap.Columns[1].DataPropertyName = "TenMH";
            dgvDSMHCanNhap.Columns[2].DataPropertyName = "SoLuong";
            dgvDSMHCanNhap.Columns[3].DataPropertyName = "date";
        }

        void ThongTinNhanVien()
        {
            var NV = BUS_NhanVien.NhanVienTheoMa(F_MainParent.NguoiDung.MaNV);
            txtMaNV.Text = NV.MaNV.ToString();
            txtTenNV.Text = NV.TenNV.ToString();
            txtSDT.Text = NV.SDT.ToString();
            if (File.Exists(BUS_NhanVien.DuongDanHinhAnh(NV.Avatar)))
            {
                picAvatar.Image = Image.FromFile(BUS_NhanVien.DuongDanHinhAnh(NV.Avatar));
            }
            else
            {
                picAvatar.Image = null;
            }
        }

        void Cal()
        {
            DSMatHangCanNhap();
            ThongTinNhanVien();
            DoanhsoNVThang();
            DoanhThuThang();
        }

        private void F_TrangChu_Load(object sender, EventArgs e)
        {
            Cal();
        }

        private void F_TrangChu_SizeChanged(object sender, EventArgs e)
        {
            pnRight.Width = Width / 2 - 5;
            pnLeft.Width = Width / 2 - 5;
            pnLeft_Bottom.Height = Height / 2 - 5;
            pnLeft_Top.Height = Height / 2 - 5;
            pnRight_Bottom.Height = Height / 2 - 5;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Cal();
        }
    }
}
