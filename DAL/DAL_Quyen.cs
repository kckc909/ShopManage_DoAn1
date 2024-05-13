using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Quyen
    {
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public List<tblQuyen> GetAll() => db.tblQuyens.ToList();
    }
}
