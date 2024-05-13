using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietHDB
    {
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public void Them(tblChiTietHDB ctHDB)
        {
            if (!ChiTietHoaDonNhap().Exists(x => Equals(x.MaHDB, ctHDB.MaHDB)) && ctHDB != null)
            {
                db.tblChiTietHDBs.Add(ctHDB);
                db.SaveChanges();
            }
        }
        public void Sua(tblChiTietHDB _old, tblChiTietHDB _new)
        {
            if (_new != null)
            {
                tblChiTietHDB ct = db.tblChiTietHDBs.ToList().Find(x => Equals(x.MaHDB, _old.MaHDB) && Equals(x.MaMH, _old.MaMH));
                if (ct != null)
                {
                    Them(_new);
                }
                else
                {
                    ct.SoLg = _new.SoLg;
                    ct.MaKM = _new.MaKM;
                    ct.GiaBan = _new.GiaBan;
                    db.SaveChanges();
                }
            }
        }
        public void Xoa(tblChiTietHDB chiTietHDB)
        {
            tblChiTietHDB ct = db.tblChiTietHDBs.ToList().Find(x => Equals(x.MaHDB, chiTietHDB.MaHDB) && Equals(x.MaMH, chiTietHDB.MaMH));
            if (ct != null)
            {
                db.tblChiTietHDBs.Remove(ct);
                db.SaveChanges();
            }
        }
        public List<tblChiTietHDB> ChiTietHoaDonNhap() => db.tblChiTietHDBs.ToList();
        public List<tblChiTietHDB> ChiTietHoaDonNhap(string MaHDB)
            => ChiTietHoaDonNhap().Where(x => Equals(x.MaHDB.Trim(), MaHDB.Trim())).ToList();

    }
}
