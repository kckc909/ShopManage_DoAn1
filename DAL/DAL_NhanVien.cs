using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien
    {
        public void Them(tblNhanVien NhanVien)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    db.tblNhanViens.Add(NhanVien);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Sua(tblNhanVien OldNhanVien, tblNhanVien NewNhanVien)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    tblNhanVien NhanVien = db.tblNhanViens.ToList().Find(x => Equals(x.MaNV, OldNhanVien.MaNV));

                    NhanVien.TenNV = NewNhanVien.TenNV;
                    NhanVien.NgaySinh = NewNhanVien.NgaySinh;
                    NhanVien.DiaChi = NewNhanVien.DiaChi;
                    NhanVien.SDT = NewNhanVien.SDT;
                    NhanVien.Email = NewNhanVien.Email;
                    NhanVien.CapQuyen = NewNhanVien.CapQuyen;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Xoa(tblNhanVien NhanVien)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    db.tblNhanViens.Remove(NhanVien);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<tblNhanVien> DanhSachNhanVien()
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    return db.tblNhanViens.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<tblNhanVien>();
            }
        }
        public tblNhanVien LayNhanVienTheoMaNV(string MaNV)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    return db.tblNhanViens.FirstOrDefault(x => Equals(x.MaNV.Trim(), MaNV));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new tblNhanVien();
            }
        }
    }
}
