﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShopDatabaseEntities : DbContext
    {
        public ShopDatabaseEntities()
            : base("name=ShopDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblApDungVoucher> tblApDungVouchers { get; set; }
        public virtual DbSet<tblChiTietHDB> tblChiTietHDBs { get; set; }
        public virtual DbSet<tblChiTietHDN> tblChiTietHDNs { get; set; }
        public virtual DbSet<tblDonVi> tblDonVis { get; set; }
        public virtual DbSet<tblGhiChu> tblGhiChus { get; set; }
        public virtual DbSet<tblHoaDonBan> tblHoaDonBans { get; set; }
        public virtual DbSet<tblHoaDonNhap> tblHoaDonNhaps { get; set; }
        public virtual DbSet<tblKhachHang> tblKhachHangs { get; set; }
        public virtual DbSet<tblKhuyenMai> tblKhuyenMais { get; set; }
        public virtual DbSet<tblLoaiHang> tblLoaiHangs { get; set; }
        public virtual DbSet<tblMatHang> tblMatHangs { get; set; }
        public virtual DbSet<tblNCC> tblNCCs { get; set; }
        public virtual DbSet<tblNhanVien> tblNhanViens { get; set; }
        public virtual DbSet<tblQuyen> tblQuyens { get; set; }
        public virtual DbSet<tblSoHuuVoucher> tblSoHuuVouchers { get; set; }
        public virtual DbSet<tblTaiKhoanMatKhau> tblTaiKhoanMatKhaus { get; set; }
        public virtual DbSet<tblVoucher> tblVouchers { get; set; }
    }
}
