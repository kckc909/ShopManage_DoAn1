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
    public partial class F_HoaDon : Form
    {
        F_HoaDon_HoaDon F_HD = new F_HoaDon_HoaDon();
        F_HoaDon_MatHang F_MatHang = new F_HoaDon_MatHang();
        F_HoaDon_KhachHang F_KhachHang = new F_HoaDon_KhachHang();
        F_HoaDon_NCC F_NCC = new F_HoaDon_NCC();

        BUS_MatHang BUS_MatHang = new BUS_MatHang();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        BUS_NhaCungCap BUS_NhaCungCap = new BUS_NhaCungCap();
        BUS_KhachHang BUS_KhachHang = new BUS_KhachHang();
        BUS_HoaDonBan BUS_HoaDonBan = new BUS_HoaDonBan();
        BUS_HoaDonNhap BUS_HoaDonNhap = new BUS_HoaDonNhap();
        BUS_SoHuuVoucher BUS_SoHuuVoucher = new BUS_SoHuuVoucher();

        bool isHDB = true;
        tblNhanVien NV = null;
        tblHoaDonBan HDB = null;
        List<tblSoHuuVoucher> DSVc = null;
        tblKhachHang KH = null;
        tblHoaDonNhap HDN = null;
        tblNCC NCC = null;

        public F_HoaDon()
        {
            InitializeComponent();

            // pnNoiDung
            tpHoaDonBan.Controls.Add(F_HD);
            tpKhachHang.Controls.Add(F_KhachHang);
            tpMatHang.Controls.Add(F_MatHang);
            tpNCC.Controls.Add(F_NCC);

            F_HD.Show();
            F_KhachHang.Show();
            F_MatHang.Show();
            F_NCC.Show();

            F_HD.Event_ChonHDB += Catch_Event_ChonHDB;
            F_HD.Event_ChonHDN += Catch_Event_ChonHDN;
            F_MatHang.Event_ChonMatHang += Catch_Event_ChonMatHang;
            F_KhachHang.Event_ChonKhachHang += Catch_Event_ChonKhachHang;
            F_NCC.Event_ChonNCC += Catch_Event_ChonNCC;
        }
        // Other
        void Save()
        {
            if (isHDB)
            {
                HDB_Save(HDB);
            }
            else
            {
                HDN_Save(HDN);
            }
        }
        void NV_LoadData()
        {
            txtMa_TenNv.Text = NV.MaNV + " - " + NV.TenNV;
        }
        void KH_LoadData()
        {
            txtTenKH_TenNCC.Text = KH.TenKH;
            txtSDT.Text = KH.SDT;
        }
        void NCC_LoadData()
        {
            txtTenKH_TenNCC.Text = NCC.TenNCC;
            txtSDT.Text = NCC.SDT;
        }
        // HDB
        void HDB_Modify()
        {
            isHDB = true;
            btnADVc.Show();
            lbTongTien.Show();
            txtTongTien.Show();
            lbTongGiam.Show();
            txtTongGiamGia.Show();
        }
        void HDB_LoadData()
        {
            if (HDB != null)
            {
                txtMaHD.Text = HDB.MaHDB;
                NV = BUS_NhanVien.NhanVienTheoMa(HDB.MaNV);
                NV_LoadData();
                KH = BUS_KhachHang.LayTheoMa(HDB.MaKH);
                KH_LoadData();
                dtpNgayHoanTat.Value = HDB.NgayBan.Value;
            }
        }
        void HDB_Load_DSCTHDB()
        {
            pnDSMH.Controls.Clear();
            if (HDB != null)
            {
                List<tblChiTietHDB> DS_CTHDB = BUS_HoaDonBan.CT_GetByID_HDB(HDB.MaHDB);
                DS_CTHDB.ForEach(x =>
                {
                    var c = new C_CTHoaDonBan(x);
                    pnDSMH.Controls.Add(c);
                    c.Show();
                });
            }
        }
        void HDB_pn_AddMatHang(tblMatHang MatHang)
        {
            if (HDB != null)
            {
                C_CTHoaDonBan ct = pnDSMH.Controls.Cast<C_CTHoaDonBan>().ToList().Find(x => x.CTHDB.MaMH.Equals(MatHang.MaMH));
                if (ct != null)
                {
                    ct.Catch_Event_TangSoLuong();
                }
                else
                {
                    ct = new C_CTHoaDonBan(new tblChiTietHDB()
                    {
                        MaHDB = HDB.MaHDB,
                        MaMH = MatHang.MaMH,
                        MaKM = MatHang.MaKM,
                        GiaBan = MatHang.GiaBan,
                        SoLg = 1
                    });
                    pnDSMH.Controls.Add(ct);
                    ct.Show();
                }
            }
        }
        void HDB_TinhTien()
        {
            HDB_Save(HDB);
            var TinhTien = BUS_HoaDonBan.HDB_TinhTien(HDB.MaHDB);
            txtTongTien.Text = TinhTien[0].ToString();
            txtTongGiamGia.Text = TinhTien[1].ToString();
            txtThanhTien.Text = TinhTien[2].ToString();
        }
        void HDB_Save(tblHoaDonBan tblHoaDonBan)
        {
            if (tblHoaDonBan != null)
            {
                BUS_HoaDonBan.HDB_Change(tblHoaDonBan);
                BUS_HoaDonBan.CT_AddRange(pnDSMH.Controls.Cast<C_CTHoaDonBan>().Select(x => x.CTHDB).ToList());
            }
        }
        // HDN
        void HDN_Modify()
        {
            isHDB = false;
            btnADVc.Hide();
            lbTongGiam.Hide();
            txtTongGiamGia.Hide();
            lbTongTien.Hide();
            txtTongTien.Hide();
        }
        void HDN_LoadData()
        {
            if (HDN != null)
            {
                txtMaHD.Text = HDN.MaHDN;
                NV = BUS_NhanVien.NhanVienTheoMa(HDN.MaNV);
                NV_LoadData();
                NCC = BUS_NhaCungCap.GetById(HDN.MaNCC);
                NCC_LoadData();
                dtpNgayHoanTat.Value = HDN.NgayNhap.Value;
            }
        }
        void HDN_pn_AddMatHang(tblMatHang MatHang)
        {
            if (HDN != null)
            {
                C_CTHoaDonNhap ct = pnDSMH.Controls.Cast<C_CTHoaDonNhap>().ToList().Find(x => x.CTHDN.MaMH.Equals(MatHang.MaMH));
                if (ct != null)
                {
                    ct.Catch_Event_TangSoLuong();
                }
                else
                {
                    ct = new C_CTHoaDonNhap(new tblChiTietHDN()
                    {
                        MaHDN = HDB.MaHDB,
                        MaMH = MatHang.MaMH,
                        GiaNhap = MatHang.GiaBan,
                        SoLg = 1
                    });
                    pnDSMH.Controls.Add(ct);
                    ct.Show();
                }
            }
        }
        void HDN_Load_DSCTHDN()
        {
            pnDSMH.Controls.Clear();
            if (HDN != null)
            {
                List<tblChiTietHDN> DS_CTHDN = BUS_HoaDonNhap.CT_GetByID_HDN(HDN.MaHDN);
                DS_CTHDN.ForEach(x =>
                {
                    pnDSMH.Controls.Add(new C_CTHoaDonNhap(x));
                });
            }
        }
        void HDN_TinhTien()
        {
            txtThanhTien.Text = BUS_HoaDonNhap.HDN_TinhTien(HDN.MaHDN).ToString();
        }
        void HDN_Save(tblHoaDonNhap tblHoaDonNhap)
        {
            if (tblHoaDonNhap != null)
            {
                BUS_HoaDonNhap.HDN_Change(tblHoaDonNhap);
                BUS_HoaDonNhap.CT_AddRange(pnDSMH.Controls.Cast<C_CTHoaDonNhap>().Select(x => x.CTHDN).ToList());
            }
        }
        // Catch Event
        void Catch_Event_CTHDB_ThayDoiSoLuong()
        {

        }

        void Catch_Event_ChonHDB(object sender, EventArgsHoaDonBan e)
        {
            isHDB = true;
            Save();
            HDB = e.HDB;
            NV = BUS_NhanVien.NhanVienTheoMa(HDB.MaNV);
            KH = e.KH;
            HDB_Modify();
            HDB_LoadData();
            HDB_Load_DSCTHDB();
            HDB_TinhTien();
        }

        void Catch_Event_ChonHDN(object sender, EventArgsHoaDonNhap e)
        {
            isHDB = false;
            Save();
            HDN = e.HDN;
            NV = HDN.tblNhanVien;
            NCC = e.NCC;
            HDN_Modify();
            HDN_LoadData();
            HDN_Load_DSCTHDN();
            HDN_TinhTien();
        }

        void Catch_Event_ChonMatHang(object sender, EventArgsMatHang e)
        {
            if (isHDB)
            {
                HDB_pn_AddMatHang(e.MatHang);
            }
            else
            {
                HDN_pn_AddMatHang(e.MatHang);
            }
        }

        void Catch_Event_ChonKhachHang(object sender, EventArgsKhachHang e)
        {
            if (HDB != null && isHDB)
            {
                KH = e.KhachHang;
                KH_LoadData();
                HDB.MaKH = KH.MaKH;
            }
        }

        void Catch_Event_ChonNCC(object sender, EventArgsNCC e)
        {
            if (HDN != null && !isHDB)
            {
                NCC = e.NCC;
                NCC_LoadData();
                NCC.MaNCC = NCC.MaNCC;
            }
        }

        void Catch_Event_VoucherChanged(object sender, EventArgs e)
        {
            if (HDB != null)
            {
                HDB_TinhTien();
            }
        }

        private void F_HoaDon_SizeChanged(object sender, EventArgs e)
        {
            pnRight.Width = 550;
            if (pnRight.Width > pnNoiDung.Width)
            {
                pnRight.Width = 400;
            }
        }

        private void pnChucNang_SizeChanged(object sender, EventArgs e)
        {
            btnThanhToan.Width = pnChucNang.Width / 2;
        }

        private void btnADVc_Click(object sender, EventArgs e)
        {
            if (isHDB && HDB != null && KH != null)
            {
                F_HoaDon_TT_Voucher F = new F_HoaDon_TT_Voucher(HDB.MaHDB, KH.MaKH, Convert.ToInt32(txtTongTien.Text));
                F.Event_VoucherChanged += Catch_Event_VoucherChanged;
                F.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trước!");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (isHDB)
            {
                BUS_HoaDonBan.HDB_Change_Status_Off(HDB);
            }
            else
            {
                BUS_HoaDonNhap.HDN_Change_Status_Off(HDN);
            }
        }
    }
}

