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
            if (_db.tblHoaDonBans.ToList().Exists(x => Equals(x.MaHDB, HDB.MaHDB)))
            {
                throw new Exception("Exist MaHDB");
            }
            _db.tblHoaDonBans.Add(HDB);
            _db.SaveChanges();
        }
        public void Sua(tblHoaDonBan _old, tblHoaDonBan _new)
        {
            var HDB = DanhSachHoaDonBan().Find(x => x.MaHDB.Trim() == _old.MaHDB.Trim());
            if (HDB is null)
            {
                throw new Exception("HDB was not found");
            }

            HDB.NgayBan = _new.NgayBan;
            HDB.MaNV = _new.MaNV;
            HDB.MaKH = _new.MaKH;
            HDB.TinhTrang = _new.TinhTrang;

            _db.SaveChanges();
        }
        public void Xoa(string MaHDB)
        {
            var HDB = DanhSachHoaDonBan().Find(x => x.MaHDB.Trim() == MaHDB.Trim());
            if (HDB is null)
            {
                throw new Exception("HDB was not found");
            }
            _db.tblHoaDonBans.Remove(HDB);
            _db.SaveChanges();
        }
        public List<tblHoaDonBan> DanhSachHoaDonBan() => _db.tblHoaDonBans.ToList();
    }
}
