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
        public List<tblDonVi> DS_DonVi() => db.tblDonVis.ToList();
    }
}
