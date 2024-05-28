using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_MatHang
    {
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public void Them(tblMatHang MatHang)
        {
            db.tblMatHangs.Add(MatHang);
            db.SaveChanges();
        }

        public void Sua_DSMH_GiamSoLuong(List<tblMatHang> DSMH)
        {
            DSMH.ForEach(MH =>
            {
                db.tblMatHangs.Find(MH.MaMH).SoLuong -= MH.SoLuong;
            });
            db.SaveChanges();
        }
        public void Sua_DSMH_TangSoLuong(List<tblMatHang> DSMH)
        {
            DSMH.ForEach(MH =>
            {
                db.tblMatHangs.Find(MH.MaMH).SoLuong += MH.SoLuong;
            });
            db.SaveChanges();
        }

        public void Sua(tblMatHang OldMatHang, tblMatHang NewMatHang)
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

        public void Xoa(tblMatHang MatHang)
        {
            db.tblMatHangs.Remove(db.tblMatHangs.Find(MatHang.MaMH));
            db.SaveChanges();
        }

        public List<tblMatHang> DanhSachMatHang() => db.tblMatHangs.ToList();

        public void TaoHinhAnh(string SourceImagePath, string ImageName)
        {
            File.Copy(SourceImagePath, ImageName, true);
        }
    }
}
