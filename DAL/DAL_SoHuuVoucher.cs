using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SoHuuVoucher
    {
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public void Them(tblSoHuuVoucher SoHuuVoucher)
        {
            db.tblSoHuuVouchers.Add(SoHuuVoucher);
            db.SaveChanges();
        }
        public void Sua(tblSoHuuVoucher _Old, tblSoHuuVoucher _New)
        {
            var SoHuuVoucher = DanhSachSoHuuVoucher().Find(x => Equals(x.MaKH, _Old.MaKH) && Equals(x.MaV, _Old.MaV));
            if (SoHuuVoucher != null)
            {
                SoHuuVoucher.NgayBatDau = _New.NgayBatDau;
                SoHuuVoucher.NgayKetThuc = _New.NgayKetThuc;
                SoHuuVoucher.TinhTrang = _New.TinhTrang;

                db.SaveChanges();
            }
        }
        public void Xoa(string MaV, string MaKH)
        {
            var del = DanhSachSoHuuVoucher().Find(x => x.MaV.Trim().ToUpper() == MaV.Trim().ToUpper()
            && Equals(x.MaKH.Trim().ToUpper(), MaKH.Trim().ToUpper()));

            db.tblSoHuuVouchers.Remove(del);
            db.SaveChanges();
        }
        public List<tblSoHuuVoucher> DanhSachSoHuuVoucher() => db.tblSoHuuVouchers.ToList();
    }
}
