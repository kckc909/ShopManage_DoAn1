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
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public void Add(tblNCC NCC)
        {
            db.tblNCCs.Add(NCC);
            db.SaveChanges();
        }
        public void Update(tblNCC OldNCC, tblNCC NewNCC)
        {
            tblNCC NCC = db.tblNCCs.ToList().Find(x => Equals(x.MaNCC, OldNCC.MaNCC));

            NCC.TenNCC = NewNCC.TenNCC;
            NCC.DiaChi = NewNCC.DiaChi;
            NCC.SDT = NewNCC.SDT;
            NCC.Email = NewNCC.Email;

            db.SaveChanges();
        }
        public void Delete(tblNCC NCC)
        {
            db.tblNCCs.Remove(NCC);
            db.SaveChanges();
        }
        public List<tblNCC> GetAll()
        {
            var result = db.tblNCCs.ToList();
            if (result.Count == 0)
            {
                Add(MyDefault.NCC);
                result.Add(MyDefault.NCC);
            }
            return result;
        }
    }
}
