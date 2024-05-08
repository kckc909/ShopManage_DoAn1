using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoanMatKhau
    {

        public void Them(tblTaiKhoanMatKhau TaiKhoan)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    db.tblTaiKhoanMatKhaus.Add(TaiKhoan);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Sua(tblTaiKhoanMatKhau OldTaiKhoanMatKhau, tblTaiKhoanMatKhau NewTaiKhoanMatKhau)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    tblTaiKhoanMatKhau TaiKhoan = db.tblTaiKhoanMatKhaus.ToList().Find(x => Equals(x.TaiKhoan, OldTaiKhoanMatKhau.TaiKhoan));

                    TaiKhoan.MatKhau = NewTaiKhoanMatKhau.MatKhau;
                    TaiKhoan.MaNV = NewTaiKhoanMatKhau.MaNV;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Xoa(string TenTaiKhoan)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    var del_TKMK = DanhSachTaiKhoanMatKhau().Find(x => x.TaiKhoan == TenTaiKhoan);
                    db.tblTaiKhoanMatKhaus.Remove(del_TKMK);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<tblTaiKhoanMatKhau> DanhSachTaiKhoanMatKhau()
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    return db.tblTaiKhoanMatKhaus.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<tblTaiKhoanMatKhau>();
            }
        }
    }
}
