using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {

        public void Them(tblKhachHang KhachHang)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    db.tblKhachHangs.Add(KhachHang);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Sua(tblKhachHang OldKhachHang, tblKhachHang NewKhachHang)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    tblKhachHang KhachHang = db.tblKhachHangs.ToList().Find(x => Equals(x.MaKH, OldKhachHang.MaKH));

                    KhachHang.TenKH = NewKhachHang.TenKH;
                    KhachHang.SDT = NewKhachHang.SDT;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Xoa(tblKhachHang KhachHang)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    db.tblKhachHangs.Remove(KhachHang);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<tblKhachHang> DanhSachKhachHang()
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    return db.tblKhachHangs.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<tblKhachHang>();
            }
        }
    }
}
