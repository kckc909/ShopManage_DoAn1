﻿using DTO;
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
        public void Them(tblHoaDonNhap HoaDonNhap)
        {
            db.tblHoaDonNhaps.Add(HoaDonNhap);
            db.SaveChanges();
        }
        public void Sua(tblHoaDonNhap OldHoaDonNhap, tblHoaDonNhap NewHoaDonNhap)
        {
            tblHoaDonNhap HoaDonNhap = db.tblHoaDonNhaps.ToList().Find(x => Equals(x.MaHDN.Trim(), OldHoaDonNhap.MaHDN.Trim()));

            HoaDonNhap.MaNV = NewHoaDonNhap.MaNV;
            HoaDonNhap.MaNCC = NewHoaDonNhap.MaNCC;
            HoaDonNhap.NgayNhap = NewHoaDonNhap.NgayNhap;
            HoaDonNhap.TinhTrang = NewHoaDonNhap.TinhTrang;

            db.SaveChanges();
        }
        public void Xoa(tblHoaDonNhap HoaDonNhap)
        {
            db.tblHoaDonNhaps.Remove(HoaDonNhap);
            db.SaveChanges();
        }
        public List<tblHoaDonNhap> DanhSachHoaDonNhap() => db.tblHoaDonNhaps.ToList();
    }
}