using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhuyenMai
    {
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public void Them(tblKhuyenMai KhuyenMai)
        {
            db.tblKhuyenMais.Add(KhuyenMai);
            db.SaveChanges();
        }
        public void Sua(tblKhuyenMai OldKhuyenMai, tblKhuyenMai NewKhuyenMai)
        {
            tblKhuyenMai KhuyenMai = db.tblKhuyenMais.ToList().Find(x => Equals(x.MaKM, OldKhuyenMai.MaKM));
            KhuyenMai.TenKM = NewKhuyenMai.TenKM;
            KhuyenMai.NgayBatDau = NewKhuyenMai.NgayBatDau;
            KhuyenMai.NgayKetThuc = NewKhuyenMai.NgayKetThuc;
            KhuyenMai.PhamTramGiam = NewKhuyenMai.PhamTramGiam.Value;
            db.SaveChanges();
        }
        public void Xoa(tblKhuyenMai KhuyenMai)
        {
            db.tblKhuyenMais.Remove(KhuyenMai);
            db.SaveChanges();
        }
        public List<tblKhuyenMai> DanhSachKhuyenMai() => db.tblKhuyenMais.ToList();
    }
}
