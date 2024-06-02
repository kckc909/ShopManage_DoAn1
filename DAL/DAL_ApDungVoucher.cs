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
        public List<tblApDungVoucher> DanhSachApDungVoucher() => db.tblApDungVouchers.ToList();
        public tblApDungVoucher GetById(string MaHDB, string MaSHVc)
        {
            return db.tblApDungVouchers.Find(MaHDB, MaSHVc);
        }
        public void AddRange(List<tblApDungVoucher> DSADVc)
        {
            db.tblApDungVouchers.AddRange(DSADVc);
            db.SaveChanges();
        }
        public void DeleteRange(List<tblApDungVoucher> DSADVc)
        {
            DSADVc.ToList().ForEach(advc =>
            {
                var a = db.tblApDungVouchers.Find(advc.MaHDB, advc.MaSHVc);
                if (a != null)
                    db.tblApDungVouchers.Remove(a);
            });
            db.SaveChanges();
        }
        public List<tblApDungVoucher> GetAll() => db.tblApDungVouchers.ToList();
    }
}
