using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietHDN
    {
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public void Them(tblChiTietHDN cthdn)
        {
            if (!ChiTietHoaDonNhap().Exists(x => Equals(x.MaHDN, cthdn.MaHDN)) && cthdn != null)
            {
                db.tblChiTietHDNs.Add(cthdn);
                db.SaveChanges();
            }
        }
        public void Sua(tblChiTietHDN _old, tblChiTietHDN _new)
        {
            if (_new != null)
            {
                tblChiTietHDN ct = db.tblChiTietHDNs.ToList().Find(x => Equals(x.MaHDN, _old.MaHDN) && Equals(x.MaMH, _old.MaMH));
                if (ct != null)
                {
                    Them(_new);
                }
                else
                {
                    ct.SoLg = _new.SoLg;
                    ct.GiaNhap = _new.GiaNhap;
                    db.SaveChanges();
                }
            }
        }
        public void Xoa(tblChiTietHDN chiTietHDN)
        {
            tblChiTietHDN ct = db.tblChiTietHDNs.ToList().Find(x => Equals(x.MaHDN, chiTietHDN.MaHDN) && Equals(x.MaMH, chiTietHDN.MaMH));
            if (ct != null)
            {
                db.tblChiTietHDNs.Remove(ct);
                db.SaveChanges();
            }
        }
        public List<tblChiTietHDN> ChiTietHoaDonNhap() => db.tblChiTietHDNs.ToList();
        public List<tblChiTietHDN> ChiTietHoaDonNhap(string MaHDN)
            => ChiTietHoaDonNhap().Where(x => Equals(x.MaHDN.Trim(), MaHDN.Trim())).ToList();
    }
}
