using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DangNhap
    {
        public List<tblTaiKhoanMatKhau> LayTatCaTaiKhoan()
        {
            using (ShopDatabaseEntities db = new ShopDatabaseEntities())
            {
                return db.tblTaiKhoanMatKhaus.ToList();
            }
        }
    }
}
