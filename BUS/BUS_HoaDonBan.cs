using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_HoaDonBan
    {
        DAL_HoaDonBan dal_HoaDonBan = new DAL_HoaDonBan();
        DAL_ChiTietHDB dal_ChiTietHDB = new DAL_ChiTietHDB();
        DAL_Voucher dal_Voucher = new DAL_Voucher();
        DAL_ApDungVoucher dal_ApDungVoucher = new DAL_ApDungVoucher();
        DAL_MatHang dal_MatHang = new DAL_MatHang();
        DAL_KhachHang dal_KhachHang = new DAL_KhachHang();
        // HDB
        public void HDB_Add(tblHoaDonBan HDB)
        {
            dal_HoaDonBan.Add(HDB);
        }
        public void HDB_Change(tblHoaDonBan HDB)
        {
            dal_HoaDonBan.Change(HDB);
        }
        public void HDB_Change_Status_Off(tblHoaDonBan HDB)
        {
            dal_HoaDonBan.Change_Status_Off(HDB);
        }
        public void HDB_Delete(tblHoaDonBan HDB)
        {
            dal_HoaDonBan.Delete(HDB);
        }
        public tblHoaDonBan HDB_GetById(string MaHDB)
        {
            return dal_HoaDonBan.GetByID(MaHDB);
        }
        public List<tblHoaDonBan> HDB_GetAll()
        {
            return dal_HoaDonBan.GetAll();
        }
        // CTHDB
        public void CT_AddRange(List<tblChiTietHDB> DS_CTHDB, string MaHDB)
        {
            List<tblChiTietHDB> DelLst = CT_GetByID_HDB(MaHDB)
                .Where(ct => !DS_CTHDB.Any(x => x.MaMH.Equals(ct.MaMH))).ToList();
            dal_ChiTietHDB.DeleteRange(DelLst);
            dal_ChiTietHDB.AddRange(DS_CTHDB);
        }
        public List<tblChiTietHDB> CT_GetByID_HDB(string MaHDB)
        {
            return dal_ChiTietHDB.GetById_HDB(MaHDB);
        }
        // Logic
        public string AutomatiicID()
        {
            return DateTime.Now.ToString("ddMMyyyyHHmmssff");
        }
        public void HDB_dtg_Filter(DataGridView dtg_DSHD, int TinhTrang)
        {
            var lst = from hd in HDB_GetAll()
                      join kh in dal_KhachHang.GetAll()
                      on hd.MaKH equals kh.MaKH
                      where hd.TinhTrang == TinhTrang
                      select new { hd.MaHDB, hd.MaKH, kh.TenKH, kh.SDT };
            dtg_DSHD.DataSource = lst.ToList();
        }
        public void HDB_dtg_Search(DataGridView dtg, int TinhTrang,string ss)
        {
            var lst = from hd in HDB_GetAll()
                      join kh in dal_KhachHang.GetAll()
                      on hd.MaKH equals kh.MaKH
                      where (hd.TinhTrang == TinhTrang 
                      && (hd.MaHDB.Contains(ss)
                            || hd.MaKH.Contains(ss)
                            || hd.MaNV.Contains(ss)
                            || kh.TenKH.Contains(ss)
                            || kh.SDT.Contains(ss)
                            )
                        )
                      select new { hd.MaHDB, hd.MaKH, kh.TenKH, kh.SDT };
            dtg.DataSource = lst.ToList();
        }
        public int[] HDB_TinhTien(string MaHDB)
        {
            dal_HoaDonBan = new DAL_HoaDonBan();
            tblHoaDonBan HDB = dal_HoaDonBan.GetByID(MaHDB);
            int TongTien = 0;

            foreach (tblChiTietHDB CTHDB in HDB.tblChiTietHDBs)
            {
                TongTien += (CTHDB.SoLg * CTHDB.GiaBan * (1 - CTHDB.tblKhuyenMai.PhamTramGiam / 100)).Value;
            }

            int TongGiam = 0;
            foreach (tblApDungVoucher vc in HDB.tblApDungVouchers)
            {
                if (vc.tblSoHuuVoucher.tblVoucher.DonVi.Trim().Equals("%"))
                {
                    TongGiam += (TongTien * vc.tblSoHuuVoucher.tblVoucher.GiaTri / 100).Value;
                }
                else
                {
                    TongGiam += vc.tblSoHuuVoucher.tblVoucher.GiaTri.Value;
                }
            }
            return new int[] { TongTien, TongGiam, TongTien - TongGiam };
        }
        public void MH_ThayDoiSoLuong(List<tblChiTietHDB> DS_CTHDB)
        {
            List<tblMatHang> DSMH = new List<tblMatHang>();
            DS_CTHDB.ForEach(tblChiTietHDB =>
            {
                DSMH.Add(new tblMatHang() { MaMH = tblChiTietHDB.MaMH, SoLuong = tblChiTietHDB.SoLg});
            });
            dal_MatHang.Sua_DSMH_GiamSoLuong(DSMH);
        }
    }
}
