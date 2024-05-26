using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietHDN
    {
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public void AddRange(List<tblChiTietHDN> DS_CTHDN)
        {
            DS_CTHDN.ForEach(x =>
            {
                var y = db.tblChiTietHDNs.Find(x.MaHDN, x.MaMH);
                if (y != null)
                {
                    y.SoLg = x.SoLg;
                }
                else
                {
                    db.tblChiTietHDNs.Add(x);
                }
            });
            db.SaveChanges();
        }
        public void DeleteRange(List<tblChiTietHDN> DS_CTHDN)
        {
            db.tblChiTietHDNs.RemoveRange(DS_CTHDN);    
            db.SaveChanges();
        }
        public List<tblChiTietHDN> GetById_HDN(string MaHDN)
        {
            return db.tblChiTietHDNs.ToList().FindAll(x => x.MaHDN.Equals(MaHDN));
        }
    }
}
