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
            var SoHuuVoucher = DanhSachSoHuuVoucher().Find(x => x.MaSHVc.Equals(_Old));
            if (SoHuuVoucher != null)
            {
                SoHuuVoucher.MaV = _New.MaSHVc;
                SoHuuVoucher.MaKH = _New.MaKH;
                SoHuuVoucher.NgayBatDau = _New.NgayBatDau;
                SoHuuVoucher.NgayKetThuc = _New.NgayKetThuc;
                SoHuuVoucher.TinhTrang = _New.TinhTrang;

                db.SaveChanges();
            }
        }
        public void Xoa(tblSoHuuVoucher shvc)
        {
            db.tblSoHuuVouchers.Remove(shvc);
            db.SaveChanges();
        }
        public List<tblSoHuuVoucher> DanhSachSoHuuVoucher() => db.tblSoHuuVouchers.ToList();
    }
}
