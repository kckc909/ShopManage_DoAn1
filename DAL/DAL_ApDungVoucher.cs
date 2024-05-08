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
        public void Them(tblApDungVoucher ApDungVoucher)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities()) 
                {
                    db.tblApDungVouchers.Add(ApDungVoucher);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }
        }
        
        //public void Sua(tblApDungVoucher _old, tblApDungVoucher _new)

        public void Xoa(string MaV, string MaHDB)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    var del = DanhSachApDungVoucher().Find(x => Equals(x.MaV, MaV) && Equals(x.MaHDB, MaHDB));
                    db.tblApDungVouchers.Remove(del);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<tblApDungVoucher> DanhSachApDungVoucher()
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    return db.tblApDungVouchers.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
