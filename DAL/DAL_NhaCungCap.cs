using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhaCungCap
    {
        public void Them(tblNCC NCC)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    db.tblNCCs.Add(NCC);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
}
        public void Sua(tblNCC OldNCC, tblNCC NewNCC)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    tblNCC NCC = db.tblNCCs.ToList().Find(x => Equals(x.MaNCC, OldNCC.MaNCC));

                    NCC.TenNCC = NewNCC.TenNCC;
                    NCC.DiaChi = NewNCC.DiaChi;
                    NCC.SDT = NewNCC.SDT;
                    NCC.Email = NewNCC.Email;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Xoa(tblNCC NCC)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    db.tblNCCs.Remove(NCC);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<tblNCC> DanhSachNCC()
        {
            try 
            { 
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    return db.tblNCCs.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<tblNCC>();
            }
        }
    }
}
