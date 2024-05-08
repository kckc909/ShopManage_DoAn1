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

        public void Them(tblLoaiHang LoaiHang)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    db.tblLoaiHangs.Add(LoaiHang);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Sua(tblLoaiHang OldLoaiHang, tblLoaiHang NewLoaiHang)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    tblLoaiHang LoaiHang = db.tblLoaiHangs.ToList().Find(x => Equals(x.MaLoai, OldLoaiHang.MaLoai));

                    LoaiHang.TenLoai = NewLoaiHang.TenLoai;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Xoa(tblLoaiHang LoaiHang)
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    db.tblLoaiHangs.Remove(LoaiHang);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<tblLoaiHang> DanhSach()
        {
            try
            {
                using (ShopDatabaseEntities db = new ShopDatabaseEntities())
                {
                    return db.tblLoaiHangs.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<tblLoaiHang>();
            }
        }
    }
}
