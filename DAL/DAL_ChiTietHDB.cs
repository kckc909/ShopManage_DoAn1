using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietHDB
    {
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public void AddRange(List<tblChiTietHDB> DS_CTHDB)
        {
            DS_CTHDB.ForEach(x =>
            {
                var y = db.tblChiTietHDBs.Find(x.MaHDB, x.MaMH);
                if (y != null)
                {
                    y.SoLg = x.SoLg;
                }
                else
                {
                    db.tblChiTietHDBs.Add(x);
                }
            });
            db.SaveChanges();
        }
        public void DeleteRange(List<tblChiTietHDB> DS_CTHDB)
        {
            db.tblChiTietHDBs.RemoveRange(DS_CTHDB);
            db.SaveChanges();
        }
        public List<tblChiTietHDB> GetById_HDB(string MaHDB)
        {
            return db.tblChiTietHDBs.ToList().FindAll(x => x.MaHDB.Equals(MaHDB));
        }
        public List<tblChiTietHDB> GetAll()
        {
            return db.tblChiTietHDBs.ToList(); 
        }

    }
}
