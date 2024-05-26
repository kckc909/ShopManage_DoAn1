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
        public void Sua_TinhTrang(tblSoHuuVoucher SHVc)
        {
            var SoHuuVoucher = DanhSachSoHuuVoucher().Find(x => x.MaSHVc.Equals(SHVc));
            if (SoHuuVoucher != null)
            {
                SoHuuVoucher.TinhTrang = SHVc.TinhTrang;
                db.SaveChanges();
            }
        }
        public void Xoa(tblSoHuuVoucher shvc)
        {
            db.tblSoHuuVouchers.Remove(shvc);
            db.SaveChanges();
        }
        public List<tblSoHuuVoucher> DanhSachSoHuuVoucher() => db.tblSoHuuVouchers.ToList();
        public tblSoHuuVoucher GetById(string MaSHVc) => db.tblSoHuuVouchers.Find(MaSHVc);
    }
}
