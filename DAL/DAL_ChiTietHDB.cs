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
            if (!DS_CTHDB().Exists(x => Equals(x.MaHDB, ctHDB.MaHDB)) && ctHDB != null)
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
        public void Sua_SoLuong(string MaHDB, string MaMH, int SoLuongMoi)
        {
            db.tblChiTietHDBs.Find(MaHDB, MaMH).SoLg = SoLuongMoi;
            db.SaveChanges();
        }
        public void Xoa(tblChiTietHDB chiTietHDB)
        {
            if (chiTietHDB != null)
            {
                db.tblChiTietHDBs.Remove(chiTietHDB);
                db.SaveChanges();
            }
        }
        public List<tblChiTietHDB> DS_CTHDB() => db.tblChiTietHDBs.ToList();
        public List<tblChiTietHDB> DS_CTHDB(string MaHDB)
            => DS_CTHDB().Where(x => Equals(x.MaHDB.Trim(), MaHDB.Trim())).ToList();

    }
}
