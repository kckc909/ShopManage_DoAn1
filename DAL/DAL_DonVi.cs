using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DonVi
    {
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public void Them(tblDonVi DonVi)
        {
            if (DonVi != null && DS_DonVi().Exists(x => x.DonVi.Equals(DonVi.DonVi)))
            {
                db.tblDonVis.Add(DonVi);
                db.SaveChanges();
            }
        }
        public List<tblDonVi> DS_DonVi() => db.tblDonVis.ToList();
    }
}
