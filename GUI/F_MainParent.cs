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
    public partial class F_MainParent : Form
    {
        public F_MainParent()
        {
            InitializeComponent();
        }

        F_TrangChu TrangChu = new F_TrangChu();
        F_HoaDon HoaDon = new F_HoaDon();
        F_MatHang MatHang = new F_MatHang();
        F_KhachHang KhachHang = new F_KhachHang();
        F_NhaCungCap NhaCungCap = new F_NhaCungCap();
        F_KhuyenMai KhuyenMai = new F_KhuyenMai();    
        F_Voucher Voucher = new F_Voucher();
        F_NhanVien NhanVien = new F_NhanVien();
        F_TaiKhoan TaiKhoan = new F_TaiKhoan();
        F_BaoCaoThongKe BaoCaoThongKe = new F_BaoCaoThongKe();

        private void F_MainParent_Load(object sender, EventArgs e)
        {
            AddQuyenNhanVien();
            AddQuyenQuanLy();
        }
        private void AddQuyenNhanVien()
        {
            pnMain.Controls.Add(TrangChu);
            pnMain.Controls.Add(HoaDon);
            pnMain.Controls.Add(MatHang);
            pnMain.Controls.Add(KhachHang);
            pnMain.Controls.Add(NhaCungCap);
            pnMain.Controls.Add(KhuyenMai);
            pnMain.Controls.Add(Voucher);
        }
        private void AddQuyenQuanLy()
        {
            pnMain.Controls.Add(NhanVien);
            pnMain.Controls.Add(TaiKhoan);
            pnMain.Controls.Add(BaoCaoThongKe);
        }
    }
}
