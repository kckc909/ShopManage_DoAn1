using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDonNhap
    {
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public void Add(tblHoaDonNhap HDN)
        {
            db.tblHoaDonNhaps.Add(HDN);
            db.SaveChanges();
        }
        public void Change(tblHoaDonNhap HDN)
        {
            var tblHoaDonNhap = db.tblHoaDonNhaps.Find(HDN.MaHDN);
            if (tblHoaDonNhap is null)
            {
                Add(HDN);
                return;
            }
            db.tblHoaDonNhaps.Attach(tblHoaDonNhap);
            tblHoaDonNhap.MaNCC = HDN.MaNCC;
            tblHoaDonNhap.MaNV = HDN.MaNV;
            tblHoaDonNhap.NgayNhap = HDN.NgayNhap;
            tblHoaDonNhap.TinhTrang = HDN.TinhTrang;
            db.SaveChanges();
        }
        public void Change_Status_Off(tblHoaDonNhap HDN)
        {
            var hd = db.tblHoaDonNhaps.Find(HDN.MaHDN);
            hd.TinhTrang = 1;
            db.SaveChanges();
        }
        public void Delete(tblHoaDonNhap HDN)
        {
            db.tblHoaDonNhaps.Remove(HDN);
            db.SaveChanges();
        }
        public tblHoaDonNhap GetByID(string MaHDN)
        {
            return db.tblHoaDonNhaps.Find(MaHDN);
        }
        public List<tblHoaDonNhap> GetAll()
        {
            return db.tblHoaDonNhaps.ToList();
        }
    }
}
