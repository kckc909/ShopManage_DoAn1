using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoaiHang
    {
        ShopDatabaseEntities db = new ShopDatabaseEntities();
        public void Them(tblLoaiHang LoaiHang)
        {

            db.tblLoaiHangs.Add(LoaiHang);
            db.SaveChanges();

        }
        public void Sua(tblLoaiHang OldLoaiHang, tblLoaiHang NewLoaiHang)
        {

            tblLoaiHang LoaiHang = db.tblLoaiHangs.ToList().Find(x => Equals(x.MaLoai, OldLoaiHang.MaLoai));

            LoaiHang.TenLoai = NewLoaiHang.TenLoai;

            db.SaveChanges();

        }
        public void Xoa(tblLoaiHang LoaiHang)
        {
            db.tblLoaiHangs.Remove(LoaiHang);
            db.SaveChanges();
        }
        public List<tblLoaiHang> DanhSach()
        {
            return db.tblLoaiHangs.ToList();
        }
    }
}
