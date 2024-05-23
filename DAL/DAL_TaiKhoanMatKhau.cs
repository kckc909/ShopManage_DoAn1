using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoanMatKhau
    {
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public void Them(tblTaiKhoanMatKhau TaiKhoan)
        {
            db.tblTaiKhoanMatKhaus.Add(TaiKhoan);
            db.SaveChanges();
        }
        public void Sua(tblTaiKhoanMatKhau OldTaiKhoanMatKhau, tblTaiKhoanMatKhau NewTaiKhoanMatKhau)
        {
            tblTaiKhoanMatKhau TaiKhoan = db.tblTaiKhoanMatKhaus.ToList().Find(x => Equals(x.TaiKhoan, OldTaiKhoanMatKhau.TaiKhoan));

            TaiKhoan.MatKhau = NewTaiKhoanMatKhau.MatKhau;
            TaiKhoan.MaNV = NewTaiKhoanMatKhau.MaNV;

            db.SaveChanges();
        }
        public void Sua(string TenTK, string TenTKMoi ,string MKMoi)
        {
            tblTaiKhoanMatKhau tk = db.tblTaiKhoanMatKhaus.Find(TenTK);
            if (tk != null)
            {
                tk.TaiKhoan = TenTKMoi;
                tk.MatKhau = MKMoi;
                db.SaveChanges();
            }
        }
        public void Xoa(string TenTaiKhoan)
        {
            var del_TKMK = DanhSachTaiKhoanMatKhau().Find(x => x.TaiKhoan == TenTaiKhoan);
            if (del_TKMK is null) { return; }
            db.tblTaiKhoanMatKhaus.Remove(del_TKMK);
            db.SaveChanges();
        }
        public List<tblTaiKhoanMatKhau> DanhSachTaiKhoanMatKhau()
        {
            List<tblTaiKhoanMatKhau> result = db.tblTaiKhoanMatKhaus.ToList();
            if (result.Count == 0)
            {
                var a = new tblTaiKhoanMatKhau()
                {
                    TaiKhoan = "admin"
                    ,
                    MatKhau = "admin"
                    ,
                    MaNV = MyDefault.NV0.MaNV
                };
                result.Add(a);
            }
            return result;
        }
    }
}
