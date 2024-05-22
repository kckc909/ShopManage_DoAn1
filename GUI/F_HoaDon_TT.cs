using BUS;
using DTO;
using GUI.MyEventArgs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_HoaDon_TT : Form
    {
        public event EventHandler<tblChiTietHDB> Event_ThemMoiCTHDB;
        public event EventHandler<tblChiTietHDN> Event_ThemMoiCTHHDN;

        BUS_HoaDonBan BUS_HoaDonBan = new BUS_HoaDonBan();
        BUS_HoaDonNhap BUS_HoaDonNhap = new BUS_HoaDonNhap();

        tblHoaDonBan HDB = null;
        tblHoaDonNhap HDN = null;
        bool isHDB = true;

        public F_HoaDon_TT()
        {
            InitializeComponent();
            TopLevel = false;
            Dock = DockStyle.Fill;
        }

        void HDB_Modify()
        {
            isHDB = true;
            btnADVc.Show();
            lbTongGiam.Show();
            txtTongGiamGia.Show();
        }
        void HDB_Load_TTHD()
        {
            if (HDB is null)
            {
                dtpNgayHoanTat.Text = "";
                txtMaHD.Clear();
                txtMa_TenNv.Clear();
                txtSDT.Clear();
                txtTenKH_TenNCC.Clear();
            }
            else
            {
                if (HDB.NgayBan is null)
                {
                    HDB.NgayBan = DateTime.Now;
                }
                dtpNgayHoanTat.Value = HDB.NgayBan.Value;
                txtMaHD.Text = HDB.MaHDB;
                txtMa_TenNv.Text = HDB.MaNV + " - " + HDB.tblNhanVien.TenNV;
                txtTenKH_TenNCC.Text = HDB.tblKhachHang.TenKH;
                txtSDT.Text = HDB.tblKhachHang.SDT;
            }
        }
        void HDB_Load_DS_CTHD()
        {
            if (HDB is null)
            {
                flpDSMH.Controls.Clear();
            }
            else
            {
                HDB.tblChiTietHDBs.ToList().ForEach(ct =>
                {
                    flpDSMH.Controls.Add(new C_CTHoaDonBan(ct)
                    {
                        Dock = DockStyle.Top
                    });
                });
            }
        }
        void HDB_Load_DS_ADVc()
        {

        }
        void HDB_Load_Tien()
        {
            if (HDB is null)
            {
                txtTongTien.Clear();
                txtTongGiamGia.Clear();
                txtThanhTien.Clear();
            }
            else
            {
                int TT = BUS_HoaDonBan.Tinh_TongTien(HDB);
                int TG = BUS_HoaDonBan.Tinh_GiamGiaVoucher(HDB);
                txtTongTien.Text = TT.ToString();
                txtTongGiamGia.Text = TG.ToString();
                txtThanhTien.Text = BUS_HoaDonBan.Tinh_ThanhTien(TT, TG).ToString();
            }
        }

        void HDN_Modify()
        {
            isHDB = false;
            btnADVc.Hide();
            lbTongGiam.Hide();
            txtTongGiamGia.Hide();
        }
        void HDN_Load_TTHD()
        {
            if (HDN is null)
            {
                txtMaHD.Clear();
                txtMa_TenNv.Clear();
                txtTenKH_TenNCC.Clear();
                txtSDT.Clear();
                dtpNgayHoanTat.Text = "";
            }
            else
            {
                txtMaHD.Text = HDN.MaHDN;
                txtMa_TenNv.Text = HDN.MaNV + " - " + HDN.tblNhanVien.TenNV;
                txtTenKH_TenNCC.Text = HDN.tblNCC.TenNCC;
                txtSDT.Text = HDN.tblNCC.SDT;
            }
        }
        void HDN_Load_DS_CTHD()
        {
            if (HDN is null)
            {
                flpDSMH.Controls.Clear();
            }
            else
            {
                HDN.tblChiTietHDNs.ToList().ForEach(ct =>
                {
                    flpDSMH.Controls.Add(new C_CTHoaDonNhap(ct)
                    {
                        Dock = DockStyle.Top
                    });
                });
            }
        }
        void HDN_Load_Tien()
        {
            if (HDN is null)
            {
                txtTongTien.Clear();
                txtThanhTien.Clear();
            }
            else
            {
                txtTongTien.Text = BUS_HoaDonNhap.Tinh_TongTien(HDN).ToString();
                txtThanhTien.Text = txtTongTien.Text;
            }
        }

        public void Catch_ChonHDB(object sender, EventArgsHoaDonBan e)
        {
            HDB = e.HDB;
            HDB_Modify();
            HDB_Load_TTHD();
            HDB_Load_DS_CTHD();
            HDB_Load_DS_ADVc();
            HDB_Load_Tien();
        }

        public void Catch_ChonHDN(object sender, EventArgsHoaDonNhap e)
        {
            HDN = e.HDN;
            HDN_Modify();
            HDN_Load_TTHD();
            HDN_Load_DS_CTHD();
            HDN_Load_Tien();
        }

        public void Catch_ChonMatHang(object sender, EventArgsMatHang e)
        {
            if (isHDB)
            {
                if (HDB != null)
                {
                    var C_CTHDB = flpDSMH.Controls.Cast<C_CTHoaDonBan>().ToList().Find(x => x.CTHDB.MaMH.Equals(e.MatHang.MaMH));
                    if (C_CTHDB != null)
                    {
                        C_CTHDB.Catch_Event_TangSoLuong();
                    }
                    else
                    {
                        C_CTHDB = new C_CTHoaDonBan(new tblChiTietHDB()
                        {
                            MaHDB = HDB.MaHDB,
                            MaMH = e.MatHang.MaMH,
                            SoLg = 1,
                            GiaBan = e.MatHang.GiaBan,
                            MaKM = e.MatHang.MaKM,
                        });
                        flpDSMH.Controls.Add(C_CTHDB);
                        C_CTHDB.Event_ThayDoiSoLuong += Catch_ThayDoiSoLuong_CTHDB;
                        C_CTHDB.Show();
                    }
                }
            }
            else
            {
                if (HDN != null)
                {
                    var C_CTHDN = flpDSMH.Controls.Cast<C_CTHoaDonNhap>().ToList().Find(x => x.CTHDN.MaMH.Equals(e.MatHang.MaMH));
                    if (C_CTHDN != null)
                    {
                        C_CTHDN.Catch_Event_TangSoLuong();
                    }
                    else
                    {
                        C_CTHDN = new C_CTHoaDonNhap(new tblChiTietHDN()
                        {
                            MaHDN = HDN.MaHDN,
                            MaMH = e.MatHang.MaMH,
                            SoLg = 1,
                            GiaNhap = e.MatHang.GiaNhap
                        });
                        flpDSMH.Controls.Add(C_CTHDN);
                        C_CTHDN.Event_ThayDoiSoLuong += Catch_ThayDoiSoLuong_CTHDN;
                        C_CTHDN.Show();
                    }
                }
            }
        }

        public void Catch_ChonKhachHang(object sender, EventArgsKhachHang e)
        {
            if (isHDB)
            {
                HDB.MaKH = e.KhachHang.MaKH;
                HDB.tblKhachHang = e.KhachHang;
            }
            else
            {
                MessageBox.Show("Không thể chọn khách hàng cho hóa đơn nhập!");
            }
        }

        public void Catch_ChonNCC(object sender, EventArgsNCC e)
        {
            if (!isHDB)
            {
                HDN.MaNCC = e.NCC.MaNCC;
                HDN.tblNCC = e.NCC;
            }
            else
            {
                MessageBox.Show("Không thể chọn nhà cung cấp cho hóa đơn bán!");
            }
        }

        void Catch_ThayDoiSoLuong_CTHDB(object sender, EventArgsChiTietHDB e)
        {
            if (HDB != null)
            {
                HDB.tblChiTietHDBs.Cast<tblChiTietHDB>().ToList().Find(x => x.tblMatHang.MaMH.Equals(e.CTHDB.MaMH)).SoLg = e.CTHDB.SoLg;
            }
        }

        void Catch_ThayDoiSoLuong_CTHDN(object sender, EventArgsChiTietHDN e)
        {
            if (HDN != null)
            {
                HDN.tblChiTietHDNs.Cast<tblChiTietHDN>().ToList().Find(x => x.tblMatHang.MaMH.Equals(e.CTHDN.MaMH)).SoLg = e.CTHDN.SoLg;
            }
        }

        private void F_TT_HDB_Load(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Hiển thị hóa đơn
            // Chuyển đổi trạng thái thành đã thah toán

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Hiển thị thông tin hóa đơn lên màn hình (coi như đã in)
            // Dùng framework của microsoft 
        }
    }
}
