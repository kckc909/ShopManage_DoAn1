using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Voucher
    {
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public void Add(tblVoucher Voucher)
        {
            if (Voucher != null)
            {
                db.tblVouchers.Add(Voucher);
                db.SaveChanges();
            }
        }
        public void Update(tblVoucher OldVoucher, tblVoucher NewVoucher)
        {
            if (NewVoucher is null)
            {
                return;
            }
            if (OldVoucher is null)
            {
                Add(NewVoucher);
            }
            else
            {
                tblVoucher Voucher = db.tblVouchers.ToList().Find(vc => Equals(vc.MaV, OldVoucher.MaV));
                Voucher.TenV = NewVoucher.TenV;
                Voucher.MoTa = NewVoucher.MoTa;
                Voucher.GiaTri = NewVoucher.GiaTri;
                Voucher.DonVi = NewVoucher.DonVi;
                Voucher.GTToiThieu = NewVoucher.GTToiThieu;
                Voucher.GTToiDa = NewVoucher.GTToiDa;
            }
            db.SaveChanges();
        }
        public void Delete(tblVoucher Voucher)
        {
            if (Voucher != null)
            {
                db.tblVouchers.Remove(Voucher);
                db.SaveChanges();
            }
        }
        public List<tblVoucher> GetAll() => db.tblVouchers.ToList();
        public tblVoucher GetById (string MaV)
        {
            return db.tblVouchers.Find(MaV);
        }
    }
}
