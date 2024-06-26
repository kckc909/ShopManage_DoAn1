﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BUS
{
    public class BUS_BaoCaoThongKe
    {
        DAL_HoaDonBan dal_HDB = new DAL_HoaDonBan();
        DAL_HoaDonNhap dal_HDN = new DAL_HoaDonNhap();
        DAL_ChiTietHDB dal_CTHDB = new DAL_ChiTietHDB();
        DAL_ChiTietHDN dal_CTHDN = new DAL_ChiTietHDN();
        DAL_MatHang dal_MH = new DAL_MatHang();
        DAL_NhanVien dal_NV = new DAL_NhanVien();
        DAL_ApDungVoucher dal_ADVC = new DAL_ApDungVoucher();
        DAL_SoHuuVoucher dal_SHVc = new DAL_SoHuuVoucher();
        DAL_Voucher DAL_Voucher = new DAL_Voucher();

        public List<(string TenNV, int DoanhSo)> TopDoanhSoNhanVien(DateTime StartTime, DateTime EndTime)
        {
            var doanhSoByNV = dal_HDB.GetAll()
                .Where(HDB => HDB.NgayBan >= StartTime && HDB.NgayBan <= EndTime)
                .GroupBy(hdb => hdb.MaNV)
                .Select(g => new
                {
                    MaNV = g.Key,
                    DoanhSo = g.Sum(hdb => dal_CTHDB.GetAll().Where(ct => ct.MaHDB == hdb.MaHDB).Sum(ct => ct.SoLg * ct.GiaBan) ?? 0)
                })
                .OrderByDescending(x => x.DoanhSo)
                .ToList();

            var topNVs = doanhSoByNV.Select(nvDS =>
            {
                var tenNV = dal_NV.GetAll().FirstOrDefault(nv => nv.MaNV == nvDS.MaNV)?.TenNV ?? "Không xác định";
                return (tenNV, nvDS.DoanhSo);
            })
            .ToList();

            return topNVs;
        }
        public List<(string MaMH, string TenMH, int TongLuongBan)> Top10MaTHangBanChay(DateTime StartTime, DateTime EndTime)
        {
            // top 10 mặt hàng có số lượng bán cao nhất
            var lst = dal_HDB.GetAll()
                    .Where(HDB => HDB.NgayBan.Value >= StartTime && HDB.NgayBan <= EndTime)
                    .GroupJoin(dal_CTHDB.GetAll(), hdb => hdb.MaHDB, cthdb => cthdb.MaHDB, (hdb, cthdb) => new { HDB = hdb, CTHDBs = cthdb })
                    .Select(x => x.CTHDBs)
                    .SelectMany(ct => dal_MH.GetAll().Where(mh => ct.Select(x => x.MaMH).Contains(mh.MaMH)), (ct, mh) => new { MatHang = mh, CTHDB = ct })
                    .GroupBy(g => g.MatHang)
                    .Select(g => new
                    {
                        g.Key.MaMH,
                        g.Key.TenMH,
                        SoLuongBan = g.SelectMany(x => x.CTHDB).Sum(x => x.SoLg)
                    })
                    .OrderByDescending(x => x.SoLuongBan)
                    .Select(x => (x.MaMH, x.TenMH, x.SoLuongBan))
                    .ToList();
            return lst.ToList();
        }
        public List<(double ChiPhi, double DoanhThu, string NgayString)> RevenueByTime(DateTime StartTime, DateTime EndTime, string TimeFormat)
        {
            List<(double ChiPhi, double DoanhThu, string NgayString)> result = new List<(double, double, string)>();
            IEnumerable<DateTime> dates = null;

            switch (TimeFormat)
            {
                case "dd/MM/yyyy":
                    dates = Enumerable.Range(0, (int)(EndTime - StartTime).TotalDays + 1).Select(i => StartTime.AddDays(i));
                    break;
                case "MM/yyyy":
                    dates = Enumerable.Range(0, EndTime.Year * 12 + EndTime.Month - StartTime.Year * 12 - StartTime.Month + 1).Select(i => StartTime.AddMonths(i));
                    break;
                case "yyyy":
                    dates = Enumerable.Range(0, EndTime.Year - StartTime.Year + 1).Select(i => StartTime.AddYears(i));
                    break;
                default:
                    return null;
            }

            foreach (var date in dates)
            {
                double chiPhi = GetTimeExpense(date, TimeFormat);
                double doanhThu = GetTimeRevenue(date, TimeFormat);
                result.Add((chiPhi, doanhThu, date.ToString(TimeFormat)));
            }
            return result;
        }
        public List<(int Ngay,double DoanhThu)> RevenueAllDayOfMonth(DateTime month)
        {
            List<(int Ngay, double DoanhThu)> result = new List<(int, double)>();
            List<DateTime> dates = GetDaysInMonth(month.Year, month.Month);
            int i = 1;
            foreach (var date in dates)
            {
                double DoanhThu = GetTimeRevenue(date, "ddMMyyyy");
                result.Add((i, DoanhThu));
                i++;
            }
            return result;
        }
        public int GetTimeExpense(DateTime date, string TimeFormat)
        {
            var TongNhap = dal_HDN.GetAll()
                .Where(HDN => HDN.NgayNhap.Value.ToString(TimeFormat).Equals(date.ToString(TimeFormat)))
                .GroupJoin(dal_CTHDN.GetAll(), hdn => hdn.MaHDN, cthdn => cthdn.MaHDN, (hdn, cthdn) => new { hdn, cthdn })
                .Sum(x => x.cthdn.Sum(y => y.SoLg * y.GiaNhap)).Value;
            return TongNhap;
        }
        public int GetTimeRevenue(DateTime date, string TimeFormat)
        {
            var lst = dal_HDB.GetAll()
                        .Where(HDB => HDB.NgayBan.Value.ToString(TimeFormat).Equals(date.ToString(TimeFormat)))
                        .GroupJoin(dal_CTHDB.GetAll(), hdb => hdb.MaHDB, cthdb => cthdb.MaHDB, (hdb, cthdb) => new { HDB = hdb, CTHDBs = cthdb })
            .Sum(x => x.CTHDBs.Sum(y => y.SoLg * y.GiaBan));
            return lst.Value;
            //.SelectMany(x => x.CTHDBs.DefaultIfEmpty(), (x, cthdb) => new
            //{
            //    x.HDB,
            //    CTHDBs = cthdb
            //})
            //            .GroupJoin(dal_ADVC.GetAll(), hdb => hdb.HDB.MaHDB, advc => advc.MaHDB, (hdb, advc) => new { hdb.HDB, hdb.CTHDBs, ADVCs = advc.DefaultIfEmpty() })
            //            .SelectMany(x => x.ADVCs, (x, advc) => new
            //            {
            //                x.HDB,
            //                x.CTHDBs,
            //                ADVC = advc
            //            })
            //            .GroupJoin(dal_SHVc.GetAll(), advc => advc.ADVC.MaSHVc, shvc => shvc.MaSHVc, (advc, shvc) => new { advc.HDB, advc.CTHDBs, advc.ADVC, SHVCs = shvc.DefaultIfEmpty() })
            //            .SelectMany(x => x.SHVCs, (x, shvc) => new
            //            {
            //                x.HDB,
            //                x.CTHDBs,
            //                x.ADVC,
            //                SHVC = shvc
            //            })
            //            .GroupJoin(DAL_Voucher.GetAll(), shvc => shvc.SHVC.MaV, vc => vc.MaV, (shvc, vc) => new { shvc.HDB, shvc.ADVC, shvc.CTHDBs, VCs = vc.DefaultIfEmpty() })
            //            .SelectMany(x => x.VCs, (x, vc) => new
            //            {
            //                x.HDB,
            //                x.ADVC,
            //                x.CTHDBs,
            //                VC = vc
            //            })
            //            .GroupBy(x => x.HDB.MaHDB)
            //            .Select(x => new
            //            {
            //                MaHDB = x.Key,
            //                TongTien = x.Sum(y => y.CTHDBs.SoLg * y.CTHDBs.GiaBan),
            //                Vouchers = x.Select(y => new
            //                {
            //                    y.VC.MaV,
            //                    y.VC.GiaTri,
            //                    y.VC.DonVi,
            //                    y.VC.GTToiDa
            //                })
            //            });
            //int ThanhTien = 0;
            //foreach (var hd in lst)
            //{
            //    int TongTien = hd.TongTien.Value;
            //    foreach (var vc in hd.Vouchers)
            //    {
            //        if (vc.DonVi.Trim().Equals("%"))
            //        {
            //            int TienGiam = (hd.TongTien * vc.GiaTri / 100).Value;
            //            if (TienGiam > vc.GTToiDa)
            //            {
            //                TienGiam = vc.GTToiDa.Value;
            //            }
            //            TongTien -= TienGiam;
            //        }
            //        else
            //        {
            //            TongTien -= vc.GiaTri.Value;
            //        }
            //    }
            //    ThanhTien += TongTien;
            //}
            //return ThanhTien;
        }
        public List<(string Ngay, int DoanhSo)> DoanhSoNhanVienTheoThang(string MaNV, DateTime Month)
        {   
            return dal_HDB.GetAll().Where(x => x.MaNV.Equals(MaNV) && x.NgayBan.Value.Month == Month.Month && x.NgayBan.Value.Year == Month.Year)
                .Select(y => (y.NgayBan.Value.ToString("dd"), y.tblChiTietHDBs.Sum(z => z.SoLg * z.GiaBan).Value)).ToList();
        }
        public List<(string MaMH, string TenMH, int SoLuong, string date)> MatHangCanNhap()
        {
            return dal_MH.GetAll().Where(x => x.SoLuong < 10 || x.HanSuDung.Value <= DateTime.Now.AddDays(10))
                .Select(y => (y.MaMH, y.TenMH, y.SoLuong.Value, y.HanSuDung.Value.ToString("d"))).ToList();
        }
        public static List<DateTime> GetDaysInMonth(int year, int month)
        {
            List<DateTime> days = new List<DateTime>();

            DateTime firstDay = new DateTime(year, month, 1);
            DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

            for (DateTime day = firstDay; day <= lastDay; day = day.AddDays(1))
            {
                days.Add(day);
            }

            return days;
        }
    }
}
