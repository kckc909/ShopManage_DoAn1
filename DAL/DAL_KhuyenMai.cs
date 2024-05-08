using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhuyenMai
    {
        public void Them(tblKhuyenMai KhuyenMai)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    db.tblKhuyenMais.Add(KhuyenMai);
                    db.SaveChanges();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void Sua(tblKhuyenMai OldKhuyenMai, tblKhuyenMai NewKhuyenMai)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    tblKhuyenMai KhuyenMai = db.tblKhuyenMais.ToList().Find(x => Equals(x.MaKM, OldKhuyenMai.MaKM));
                    KhuyenMai.TenKM = NewKhuyenMai.TenKM;
                    KhuyenMai.NgayBatDau = NewKhuyenMai.NgayBatDau;
                    KhuyenMai.NgayKetThuc = NewKhuyenMai.NgayKetThuc;
                    KhuyenMai.PhamTramGiam = NewKhuyenMai.PhamTramGiam.Value;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Xoa(tblKhuyenMai KhuyenMai)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    db.tblKhuyenMais.Remove(KhuyenMai);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<tblKhuyenMai> DanhSachKhuyenMai()
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    return db.tblKhuyenMais.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<tblKhuyenMai>();
            }
        }
    }
}
