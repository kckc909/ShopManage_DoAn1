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
            tblHoaDonBan HoaDonBan = new tblHoaDonBan();
            HoaDonBan.MaHDB = HDB.MaHDB;
            HoaDonBan.MaNV = HDB.MaNV;
            HoaDonBan.MaKH = HDB.MaKH;
            HoaDonBan.NgayBan = HDB.NgayBan;
            HoaDonBan.TinhTrang = HDB.TinhTrang;
            _db.tblHoaDonBans.Add(HoaDonBan);
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
        public void Sua_TinhTrang(string MaHDB, int TinhTrang)
        {
            _db.tblHoaDonBans.Find(MaHDB).TinhTrang = TinhTrang;
            _db.SaveChanges();
        }
        public void Sua_MaNV(string MaHDB, string MaNV)
        {
            _db.tblHoaDonBans.Find(MaHDB).MaNV = MaNV;
        }
        public void Sua_MaKH(string MaHDB, string MakH)
        {
            _db.tblHoaDonBans.Find(MaHDB).MaKH = MakH;
        }
        public void Xoa(tblHoaDonBan HDB)
        {
            if (HDB is null) return;
            _db.tblHoaDonBans.Remove(HDB);
            _db.SaveChanges();
        }
        public tblHoaDonBan GetByID(string MaHDB)
        {
            return _db.tblHoaDonBans.Find(MaHDB);
        }
        public List<tblHoaDonBan> DanhSachHoaDonBan() => _db.tblHoaDonBans.ToList();
    }
}
