using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDonBan
    {
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public void Add(tblHoaDonBan HDB)
        {
            db.tblHoaDonBans.Add(HDB);
            db.SaveChanges();
        }
        public void Change(tblHoaDonBan HDB)
        {
            var tblHoaDonBan = db.tblHoaDonBans.Find(HDB.MaHDB);
            if (tblHoaDonBan is null)
            {
                return;
            }
            db.tblHoaDonBans.Attach(tblHoaDonBan);
            tblHoaDonBan.MaKH = HDB.MaKH;
            tblHoaDonBan.MaNV = HDB.MaNV;
            tblHoaDonBan.NgayBan = HDB.NgayBan;
            tblHoaDonBan.TinhTrang = HDB.TinhTrang;
            var saveFailed = false;
            do
            {
                saveFailed = false;
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    saveFailed = true;

                    ex.Entries.Single().Reload();
                }

            } while (saveFailed);
        }
        public void Change_Status_Off(tblHoaDonBan HDB)
        {
            var hd = db.tblHoaDonBans.Find(HDB.MaHDB);
            hd.TinhTrang = 1;
            db.SaveChanges();
        }
        public void Delete(tblHoaDonBan HDB)
        {
            db.tblHoaDonBans.Remove(HDB);
            db.SaveChanges();
        }
        public tblHoaDonBan GetByID(string MaHDB)
        {
            return db.tblHoaDonBans.Find(MaHDB);
        }
        public List<tblHoaDonBan> GetAll()
        {
            return db.tblHoaDonBans.ToList();
        }
    }
}
