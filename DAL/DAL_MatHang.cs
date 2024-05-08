using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_MatHang
    {

        public void Them(tblMatHang MatHang)
        {
            using (ShopDatabaseEntities db = new ShopDatabaseEntities())
            {
                db.tblMatHangs.Add(MatHang);
                db.SaveChanges();
            }
        }
        public void Sua(tblMatHang OldMatHang, tblMatHang NewMatHang)
        {
            using (ShopDatabaseEntities db = new ShopDatabaseEntities())
            {
                tblMatHang MatHang = db.tblMatHangs.ToList().Find(x => Equals(x.MaMH, OldMatHang.MaMH));

                MatHang.TenMH = NewMatHang.TenMH;
                MatHang.Mota = NewMatHang.Mota;
                MatHang.LinkHinhAnh = NewMatHang.LinkHinhAnh;
                MatHang.GiaBan = NewMatHang.GiaBan;
                MatHang.SoLuong = NewMatHang.SoLuong;
                MatHang.DonViTinh = NewMatHang.DonViTinh;
                MatHang.HanSuDung = NewMatHang.HanSuDung;
                MatHang.MaKM = NewMatHang.MaKM;
                MatHang.MaLoai = NewMatHang.MaLoai;

                db.SaveChanges();
            }
        }
        public void Xoa(tblMatHang MatHang)
        {
            using (ShopDatabaseEntities db = new ShopDatabaseEntities())
            {
                db.tblMatHangs.Remove(db.tblMatHangs.Find(MatHang.MaMH));
                db.SaveChanges();
            }
        }
        public List<tblMatHang> DanhSachMatHang()
        {
            using (ShopDatabaseEntities db = new ShopDatabaseEntities())
            {
                return db.tblMatHangs.ToList();
            }
        }
        public tblMatHang LayMatHangTheoMaMH(string MaMH)
        {
            using (ShopDatabaseEntities db = new ShopDatabaseEntities())
            {
                return db.tblMatHangs.Find(MaMH);
            }
        }
    }
}
