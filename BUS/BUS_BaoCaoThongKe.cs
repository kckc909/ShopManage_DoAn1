using DAL;
using System;
using System.Collections.Generic;
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

        public List<(string TenMH, int TongLuongBan)> MatHang()
        {
            // top 10 mặt hàng có số lượng bán cao nhất
            var lst = (from mh in dal_MH.GetAll()
                       join cthd in dal_CTHDB.GetAll() on mh.MaMH equals cthd.MaMH
                       group cthd by mh.MaMH into g
                       orderby g.Sum(ct => ct.SoLg) descending
                       select new
                       {
                           TenMH = (from m in dal_MH.GetAll()
                                    where m.MaMH == g.Key
                                    select m.TenMH).FirstOrDefault(),
                           TongLuongBan = g.Sum(ct => ct.SoLg)
                       })
                       .Take(10).Select(x => (x.TenMH, x.TongLuongBan));
            return lst.ToList();
        }

        public List<(double ChiPhi, double DoanhThu, string NgayString)> RevenueByDay(DateTime StartTime, DateTime EndTime, string TimeFormat)
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
                double chiPhi = GetDailyExpense(date, TimeFormat);
                double doanhThu = GetDailyRevenue(date, TimeFormat);
                result.Add((chiPhi, doanhThu, date.ToString(TimeFormat)));
            }
            return result;
        }
        private int GetDailyExpense(DateTime date, string TimeFormat)
        {
            var TongNhap = dal_HDN.GetAll()
                .Where(HDN => HDN.NgayNhap.Value.ToString(TimeFormat).Equals(date.ToString(TimeFormat)))
                .GroupJoin(dal_CTHDN.GetAll(), hdn => hdn.MaHDN, cthdn => cthdn.MaHDN, (hdn, cthdn) => new { hdn, cthdn })
                .Sum(x => x.cthdn.Sum(y => y.SoLg * y.GiaNhap)).Value;
            return TongNhap;
        }

        private int GetDailyRevenue(DateTime date, string TimeFormat)
        {
            var lst = dal_HDB.GetAll()
                        .Where(HDB => HDB.NgayBan.Value.ToString(TimeFormat).Equals(date.ToString(TimeFormat)))
                        .GroupJoin(dal_CTHDB.GetAll(), hdb => hdb.MaHDB, cthdb => cthdb.MaHDB, (hdb, cthdb) => new { HDB = hdb, CTHDBs = cthdb })
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
            .Sum(x => x.CTHDBs.Sum(y => y.SoLg * y.GiaBan));
            return lst.Value;
        }
    }
}
