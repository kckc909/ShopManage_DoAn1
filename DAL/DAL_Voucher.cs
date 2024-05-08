using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Voucher
    {
        public void Them(tblVoucher Voucher)
        {
            using (ShopDatabaseEntities db = new ShopDatabaseEntities())
            {
                db.tblVouchers.Add(Voucher);
                db.SaveChanges();
            }
        }
        public void Sua(tblVoucher OldVoucher, tblVoucher NewVoucher)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    tblVoucher Voucher = db.tblVouchers.ToList().Find(vc => Equals(vc.MaV, OldVoucher.MaV));
                    Voucher.TenV = NewVoucher.TenV;
                    Voucher.MoTa = NewVoucher.MoTa;
                    Voucher.GiaTri = NewVoucher.GiaTri;
                    Voucher.DonVi = NewVoucher.DonVi;
                    Voucher.GTToiThieu = NewVoucher.GTToiThieu;
                    Voucher.GTToiDa = NewVoucher.GTToiDa;
                    db.SaveChanges();
                }        
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Xoa(tblVoucher Voucher)
        {
            using (ShopDatabaseEntities db = new ShopDatabaseEntities())
            {
                db.tblVouchers.Remove(Voucher);
                db.SaveChanges();
            }
        }
        public List<tblVoucher> DanhSachVoucher()
        {
            using (ShopDatabaseEntities db = new ShopDatabaseEntities())
            {
                return db.tblVouchers.ToList();
            }
        }
    }
}
