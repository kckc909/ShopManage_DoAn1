using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_HoaDonBan
    {
        DAL_HoaDonBan DAL_HoaDonBan = new DAL_HoaDonBan();
        public void Them(tblHoaDonBan hdb)
        {
            DAL_HoaDonBan.Them(hdb);
        }
        public tblHoaDonBan Sua_TinhTrang(tblHoaDonBan HDB, int TinhTrang)
        {
            HDB.TinhTrang = TinhTrang;
            return HDB;
        }
        public tblHoaDonBan Sua_MaNV(tblHoaDonBan HDB, string MaNV)
        {
            HDB.MaNV = MaNV;
            return HDB;
        }
        public void Xoa(string MaHDB)
        {
            DAL_HoaDonBan.Xoa(DS_HDB().Find(x => x.MaHDB.Trim().Equals(MaHDB.Trim())));
        }
        public tblHoaDonBan HDB_LayTheoMa(string MaHDB)
        {
            return DAL_HoaDonBan.GetByID(MaHDB);
        }
        public List<tblHoaDonBan> DS_HDB()
        {
            return DAL_HoaDonBan.DanhSachHoaDonBan();
        }
        public void Loc_TimKiem(DataGridView dtg, string s, int TinhTrang)
        {
            foreach (DataGridViewRow r in dtg.Rows)
            {
                r.Visible = false;
                r.Cells["TT"].Value = TinhTrang;
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.Value.ToString().Contains(s))
                    {
                        r.Visible = true;
                    }
                }
            }
        }
        public string MaTuDong()
        {
            return DateTime.Now.ToString("ddMMyyyyHHmmssff");
        }
        public int Tinh_TongTien(tblHoaDonBan HDB)
        {
            if (HDB.tblChiTietHDBs.Count == 0)
                return 0;
            return HDB.tblChiTietHDBs.Sum(x => x.SoLg * (x.GiaBan * (100 - x.tblKhuyenMai.PhamTramGiam) / 100 )).Value;
        }
        public int Tinh_GiamGiaVoucher(tblHoaDonBan HDB, int TongTien = 0)
        {
            if (TongTien == 0)
            {
                TongTien = Tinh_TongTien(HDB);
            }
            if (HDB.tblApDungVouchers.Count == 0)
            {
                return 0;
            }
            else
            {
                int TongGiamGia = 0;
                int temp;
                HDB.tblApDungVouchers.ToList().ForEach(x =>
                {
                    if (x.tblVoucher.DonVi.Equals("%"))
                    {
                        temp = (x.tblVoucher.GiaTri * TongGiamGia / 100).Value;
                        if (temp > x.tblVoucher.GTToiDa)
                        {
                            temp = x.tblVoucher.GTToiDa.Value;
                        }
                        TongGiamGia += temp;
                    }
                    else
                    {
                        TongGiamGia += x.tblVoucher.GiaTri.Value;
                    }
                });
                return TongGiamGia;
            }
        }
        public int Tinh_ThanhTien(int TongTien, int TongGiam)
        {
            return TongTien - TongGiam;
        }
    }
}
