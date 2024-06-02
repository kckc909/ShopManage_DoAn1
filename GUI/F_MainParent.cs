using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GUI
{
    public partial class F_MainParent : Form
    {
        private static F_MainParent instance;
        private F_MainParent()
        {
            InitializeComponent();
        }

        private Guna2GradientButton BtnCurrent;
        Color _Color1 = Color.FromArgb(136, 136, 136, 136);
        Color _Color2 = Color.FromArgb(50, 50, 50, 50);

        public static F_MainParent Instance()
        {
            if (instance == null)
            {
                instance = new F_MainParent();
            }
            if (NguoiDung == null)
            {
                NguoiDung = new tblNhanVien()
                {
                    MaNV = "_",
                    TenNV = "Admin",
                    CapQuyen = 0
                };
            }
            return instance;
        }

        static public tblNhanVien NguoiDung = null;

        F_TrangChu _TrangChu = new F_TrangChu() { TopLevel = false, Dock = DockStyle.Fill, FormBorderStyle = FormBorderStyle.None };
        F_HoaDon _HoaDon = new F_HoaDon() { TopLevel = false, Dock = DockStyle.Fill, FormBorderStyle = FormBorderStyle.None };
        F_MatHang _MatHang = new F_MatHang() { TopLevel = false, Dock = DockStyle.Fill, FormBorderStyle = FormBorderStyle.None };
        F_KhachHang _KhachHang = new F_KhachHang() { TopLevel = false, Dock = DockStyle.Fill, FormBorderStyle = FormBorderStyle.None };
        F_NhaCungCap _NhaCungCap = new F_NhaCungCap() { TopLevel = false, Dock = DockStyle.Fill, FormBorderStyle = FormBorderStyle.None };
        F_LoaiHang _LoaiHang = new F_LoaiHang() { TopLevel = false, Dock = DockStyle.Fill, FormBorderStyle = FormBorderStyle.None };
        F_KhuyenMai _KhuyenMai = new F_KhuyenMai() { TopLevel = false, Dock = DockStyle.Fill, FormBorderStyle = FormBorderStyle.None };
        F_Voucher _Voucher = new F_Voucher() { TopLevel = false, Dock = DockStyle.Fill, FormBorderStyle = FormBorderStyle.None };
        F_NhanVien _NhanVien = new F_NhanVien() { TopLevel = false, Dock = DockStyle.Fill, FormBorderStyle = FormBorderStyle.None };
        F_TaiKhoan _TaiKhoan = new F_TaiKhoan() { TopLevel = false, Dock = DockStyle.Fill, FormBorderStyle = FormBorderStyle.None };
        F_BaoCaoThongKe _BaoCaoThongKe = new F_BaoCaoThongKe() { TopLevel = false, Dock = DockStyle.Fill, FormBorderStyle = FormBorderStyle.None };

        private void F_MainParent_Load(object sender, EventArgs e)
        {
            BtnCurrent = btnTrangChu;
            if (NguoiDung.CapQuyen == 0)
            {
                AddQuyenNhanVien();
                AddQuyenQuanLy();
            }
            else if (NguoiDung.CapQuyen == 1)
            {
                AddQuyenNhanVien();
                AnButtonTheoQuyen();
            }
        }

        private void AnButtonTheoQuyen()
        {
            btnBCTK.Hide();
            btnNhanVien.Hide();
        }

        private void AddQuyenNhanVien()
        {
            pnMain.Controls.Add(_TrangChu);
            pnMain.Controls.Add(_HoaDon);
            pnMain.Controls.Add(_MatHang);
            pnMain.Controls.Add(_KhachHang);
            pnMain.Controls.Add(_NhaCungCap);
            pnMain.Controls.Add(_LoaiHang);
            pnMain.Controls.Add(_KhuyenMai);
            pnMain.Controls.Add(_Voucher);
        }
        private void AddQuyenQuanLy()
        {
            pnMain.Controls.Add(_NhanVien);
            pnMain.Controls.Add(_TaiKhoan);
            pnMain.Controls.Add(_BaoCaoThongKe);
        }

        private void btnMatHang_Click(object sender, EventArgs e)
        {
            MoFormChucNang(btnMatHang);
            _MatHang.Show();
            _MatHang.BringToFront();
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            MoFormChucNang(btnHoadon);
            _HoaDon.Show();
            _HoaDon.BringToFront();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            MoFormChucNang(btnKhachHang);
            _KhachHang.Show();
            _KhachHang.BringToFront();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            MoFormChucNang(btnNhaCungCap);
            _NhaCungCap.Show();
            _NhaCungCap.BringToFront();
        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            MoFormChucNang(btnLoaiHang);
            _LoaiHang.Show();
            _LoaiHang.BringToFront();
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            MoFormChucNang(btnKhuyenMai);
            _KhuyenMai.Show();
            _KhuyenMai.BringToFront();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            MoFormChucNang(btnVoucher);
            _Voucher.Show();
            _Voucher.BringToFront();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            MoFormChucNang(btnNhanVien);
            _NhanVien.Show();
            _NhanVien.BringToFront();
        }

        private void btnBCTK_Click(object sender, EventArgs e)
        {
            MoFormChucNang(btnBCTK);
            _BaoCaoThongKe.Show();
            _BaoCaoThongKe.BringToFront();
        }

        private void btnTKMK_Click(object sender, EventArgs e)
        {
            MoFormChucNang(btnTKMK);
            _TaiKhoan.Show();
            _TaiKhoan.BringToFront();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            MoFormChucNang(btnTrangChu);
            _TrangChu.Show();
            _TrangChu.BringToFront();
        }

        private void F_MainParent_MaximumSizeChanged(object sender, EventArgs e)
        {
            foreach (var Button in pnLeft.Controls)
            {
                if (Button.GetType() == typeof(Guna2Button))
                    ((Guna2Button)Button).ImageSize = new Size(30, 30);
            }
        }

        private void MoFormChucNang(Guna2GradientButton Button)
        {
            BtnCurrent.FillColor2 = _Color1;
            foreach (Form OpeningForm in pnMain.Controls)
            {
                OpeningForm.Hide();
            }

            BtnCurrent = Button;
            BtnCurrent.FillColor2 = _Color2;
        }

        private void F_MainParent_FormClosed(object sender, FormClosedEventArgs e)
        {
            F_DangKyDangNhap.Instance().Show();
            instance = new F_MainParent();
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            F_MainParent_User F = new F_MainParent_User(NguoiDung);
            F.Location = new Point(btnNguoiDung.PointToScreen(Point.Empty).X + btnNguoiDung.Width, btnNguoiDung.PointToScreen(Point.Empty).Y - F.Height);
            F.Show();
        }
    }
}
