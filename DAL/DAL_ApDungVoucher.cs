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
        public void Sua(tblApDungVoucher _old, tblApDungVoucher _new)
        {
            if (_new is null)
            { return; }
            Xoa(_old);
            Them(_new);
            db.SaveChanges();
        }
        public void Sua_GhiChu(tblApDungVoucher adv, string GhiChu)
        {
            var v = db.tblApDungVouchers.ToList().Find(x => Equals(x.MaV, adv.MaV) && Equals(x.MaHDB, adv.MaHDB));
            if (v is null)
            {
                return;
            }
            v.GhiChu = GhiChu;
        }
        public void Xoa(tblApDungVoucher adv)
        {
            var del = DanhSachApDungVoucher().Find(x => Equals(x.MaV, adv.MaV) && Equals(x.MaHDB, adv.MaHDB));
            if (del is null) { return; }
            db.tblApDungVouchers.Remove(del);
            db.SaveChanges();
        }
        public List<tblApDungVoucher> DanhSachApDungVoucher() => db.tblApDungVouchers.ToList();
    }
}
