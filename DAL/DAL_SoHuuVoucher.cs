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
        public void Them(tblSoHuuVoucher SoHuuVoucher)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    db.tblSoHuuVouchers.Add(SoHuuVoucher);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }
        public void Sua(tblSoHuuVoucher _Old, tblSoHuuVoucher _New)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    var SoHuuVoucher = DanhSachSoHuuVoucher().Find(x => Equals(x.MaKH.Trim().ToUpper(), _Old.MaKH.Trim().ToUpper()) 
                    && Equals(x.MaV.Trim().ToUpper(), _Old.MaV.Trim().ToUpper()));
                    
                    SoHuuVoucher.NgayBatDau = _New.NgayBatDau;
                    SoHuuVoucher.NgayKetThuc = _New.NgayKetThuc;
                    SoHuuVoucher.TinhTrang = _New.TinhTrang;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Xoa(string MaV, string MaKH)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    var del = DanhSachSoHuuVoucher().Find(x => x.MaV.Trim().ToUpper() == MaV.Trim().ToUpper()
                    && Equals(x.MaKH.Trim().ToUpper(), MaKH.Trim().ToUpper()));

                    db.tblSoHuuVouchers.Remove(del);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<tblSoHuuVoucher> DanhSachSoHuuVoucher()
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    return db.tblSoHuuVouchers.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
