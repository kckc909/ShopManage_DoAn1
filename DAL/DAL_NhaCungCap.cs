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
        public void Them(tblNCC NCC)
        {
            db.tblNCCs.Add(NCC);
            db.SaveChanges();
        }
        public void Sua(tblNCC OldNCC, tblNCC NewNCC)
        {
            tblNCC NCC = db.tblNCCs.ToList().Find(x => Equals(x.MaNCC, OldNCC.MaNCC));

            NCC.TenNCC = NewNCC.TenNCC;
            NCC.DiaChi = NewNCC.DiaChi;
            NCC.SDT = NewNCC.SDT;
            NCC.Email = NewNCC.Email;

            db.SaveChanges();
        }
        public void Xoa(tblNCC NCC)
        {
            db.tblNCCs.Remove(NCC);
            db.SaveChanges();
        }
        public List<tblNCC> DanhSachNCC()
        {
            var result = db.tblNCCs.ToList();
            if (result.Count == 0)
            {
                Them(MyDefault.NCC);
                result.Add(MyDefault.NCC);
            }
            return result;
        }
    }
}
