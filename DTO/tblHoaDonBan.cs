//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tblHoaDonBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHoaDonBan()
        {
            this.tblApDungVouchers = new HashSet<tblApDungVoucher>();
            this.tblChiTietHDBs = new HashSet<tblChiTietHDB>();
        }
    
        public string MaHDB { get; set; }
        public Nullable<System.DateTime> NgayBan { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public Nullable<int> TinhTrang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblApDungVoucher> tblApDungVouchers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietHDB> tblChiTietHDBs { get; set; }
        public virtual tblKhachHang tblKhachHang { get; set; }
        public virtual tblNhanVien tblNhanVien { get; set; }
    }
}
