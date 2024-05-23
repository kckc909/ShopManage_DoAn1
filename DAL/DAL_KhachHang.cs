using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public void Them(tblKhachHang KhachHang)
        {
            if (!db.tblKhachHangs.Any(x => x.MaKH.Equals(KhachHang.MaKH)))
            {
                db.tblKhachHangs.Add(KhachHang);
                db.SaveChanges();
            }
        }
        public void Sua(tblKhachHang OldKhachHang, tblKhachHang NewKhachHang)
        {
            if (NewKhachHang != null)
            {
                tblKhachHang KhachHang = db.tblKhachHangs.ToList().Find(x => Equals(x.MaKH, OldKhachHang.MaKH));
                KhachHang.TenKH = NewKhachHang.TenKH;
                KhachHang.SDT = NewKhachHang.SDT;
                db.SaveChanges();
            }
        }
        public void Xoa(tblKhachHang KhachHang)
        {
            if (KhachHang != null)
            {
                db.tblKhachHangs.Remove(KhachHang);
                db.SaveChanges();
            }
        }
        public List<tblKhachHang> DanhSachKhachHang()
        {
            var result = db.tblKhachHangs.ToList();
            if (result.Count == 0)
            {
                result.Add(MyDefault.KH);
                Them(MyDefault.KH);
            }
            return result;  
        }
        public tblKhachHang GetByID(string ID)
        {
            return db.tblKhachHangs.Find(ID);
        }
    }
}
