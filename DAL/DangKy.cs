using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    internal class DangKy
    {
        ShopDatabaseEntities db = new ShopDatabaseEntities();

        public tblTaiKhoanMatKhau Get_Account(string TenTaiKhoan)
        {
            return db.tblTaiKhoanMatKhaus.Find(TenTaiKhoan);
        }

        public List<tblTaiKhoanMatKhau> GetAllAccount()
        {
            return db.tblTaiKhoanMatKhaus.ToList();
        }
        public void CreateAccount(tblTaiKhoanMatKhau TaiKhoan)
        {
            db.tblTaiKhoanMatKhaus.Add(TaiKhoan);
        }
    }
}
