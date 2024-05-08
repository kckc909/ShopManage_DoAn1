using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDonBan
    {
        private ShopDatabaseEntities _db = new ShopDatabaseEntities();
        public void Them(tblHoaDonBan HDB)
        {
            _db.tblHoaDonBans.Add(HDB);
            _db.SaveChanges();
        }
        public void Sua(tblHoaDonBan _old, tblHoaDonBan _new)
        {
            try
            {
                var HDB = DanhSachHoaDonBan().Find(x => x.MaHDB.Trim() == _old.MaHDB);
                HDB.NgayBan = _new .NgayBan;
                HDB.MaNV = _new .MaNV;
                HDB.MaKH = _new.MaKH;
                HDB.TinhTrang = _new .TinhTrang;
                
                _db.SaveChanges();
            }
            catch
            {
                throw new Exception("DAL_HoaDonBan_Sua");
            }
        }
        public void Xoa(string MaHDB)
        {
            try
            {
                var HDB= DanhSachHoaDonBan().Find(x => x.MaHDB.Trim() == MaHDB.Trim());
                _db.tblHoaDonBans.Remove(HDB);
                _db.SaveChanges();
            }
            catch
            {
                throw new Exception("DAL_HoaDonBan_Xoa");
            }
        }
        public List<tblHoaDonBan> DanhSachHoaDonBan() 
        { 
            return _db.tblHoaDonBans.ToList();
        }
    }

    public class DAL_HoaDonNhap
    {
        public void Them(tblHoaDonNhap HoaDonNhap)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    db.tblHoaDonNhaps.Add(HoaDonNhap);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Sua(tblHoaDonNhap OldHoaDonNhap, tblHoaDonNhap NewHoaDonNhap)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    tblHoaDonNhap HoaDonNhap = db.tblHoaDonNhaps.ToList().Find(x => Equals(x.MaHDN.Trim(), OldHoaDonNhap.MaHDN.Trim()));

                    HoaDonNhap.MaNV = NewHoaDonNhap.MaNV;
                    HoaDonNhap.MaNCC = NewHoaDonNhap.MaNCC;
                    HoaDonNhap.NgayNhap = NewHoaDonNhap.NgayNhap;
                    HoaDonNhap.TinhTrang = NewHoaDonNhap.TinhTrang;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Xoa(tblHoaDonNhap HoaDonNhap)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    db.tblHoaDonNhaps.Remove(HoaDonNhap);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<tblHoaDonNhap> DanhSachHoaDonNhap()
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    return db.tblHoaDonNhaps.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<tblHoaDonNhap>();
            }
        }
    }
}
