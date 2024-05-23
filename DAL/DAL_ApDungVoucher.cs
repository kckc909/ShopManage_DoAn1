using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ApDungVoucher
    {
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public void Them(tblApDungVoucher adv)
        {
            if (db.tblApDungVouchers.ToList().Exists(x => Equals(x.MaV, adv.MaV) && Equals(x.MaHDB, adv.MaHDB)))
            {
                return;
            }
            db.tblApDungVouchers.Add(adv);
            db.SaveChanges();
        }
        public void Xoa(string MaHDB, string MaV)
        {
            db.tblApDungVouchers.Remove(new tblApDungVoucher()
            {
                MaHDB = MaHDB,
                MaV = MaV
            });
            db.SaveChanges();
        }
        public List<tblApDungVoucher> DanhSachApDungVoucher() => db.tblApDungVouchers.ToList();
        public tblApDungVoucher GetById(string MaHDB, string MaV)
        {
            return db.tblApDungVouchers.Find(MaHDB, MaV);
        }
        public void AddRange(List<tblApDungVoucher> DSADVc)
        {
            db.tblApDungVouchers.AddRange(DSADVc);
            db.SaveChanges() ;
        }
        public void DeleteRange(List<tblApDungVoucher> DSADVc)
        {
            db.tblApDungVouchers.RemoveRange(DSADVc);
            db.SaveChanges();
        }
    }
}
