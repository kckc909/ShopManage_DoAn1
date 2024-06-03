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
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public void Add(tblNhanVien NhanVien)
        {
            if (NhanVien is null || db.tblNhanViens.ToList().Exists(x => Equals(x.MaNV, NhanVien.MaNV)))
            {
                return;
            }
            db.tblNhanViens.Add(NhanVien);
            db.SaveChanges();
        }
        public void Update(tblNhanVien OldNhanVien, tblNhanVien NewNhanVien)
        {
            tblNhanVien NhanVien = db.tblNhanViens.ToList().Find(x => Equals(x.MaNV, OldNhanVien.MaNV));
            if (NhanVien is null)
            {
                return;
            }
            NhanVien.TenNV = NewNhanVien.TenNV;
            NhanVien.NgaySinh = NewNhanVien.NgaySinh;
            NhanVien.Avatar = NewNhanVien.Avatar;
            NhanVien.GioiTinh = NewNhanVien.GioiTinh;
            NhanVien.DiaChi = NewNhanVien.DiaChi;
            NhanVien.SDT = NewNhanVien.SDT;
            NhanVien.Email = NewNhanVien.Email;
            NhanVien.CapQuyen = NewNhanVien.CapQuyen;
            db.SaveChanges();
        }
        public void Delete(tblNhanVien NhanVien)
        {
            if (NhanVien is null || 
                !db.tblNhanViens.ToList().Any(x => Equals(x.MaNV, NhanVien.MaNV)))
            {
                return;
            }
            db.tblNhanViens.Remove(NhanVien);
            db.SaveChanges();
        }
        public List<tblNhanVien> GetAll() => db.tblNhanViens.ToList();
    }
}
